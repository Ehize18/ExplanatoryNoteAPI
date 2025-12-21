using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;
using ExplanatoryNoteAPI.Application.Services;
using ExplanatoryNoteAPI.Core;
using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Entities;
using ExplanatoryNoteAPI.Core.Entities.TextBlockEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using WkHtmlToPdfDotNet;

namespace ExplanatoryNoteAPI.Controllers
{
	[ApiController]
	[Route("api/entities")]
	public class EntityController : ControllerBase
	{
		private readonly IGenericDataService _dataService;
		private readonly ITypeResolver _typeResolver;
		private readonly ILogger<EntityController> _logger;
		private readonly IExportService _exportService;

		private SysUser SysUser
		{
			get
			{
				var id = HttpContext?.User?.Claims?.FirstOrDefault()?.Value;
				if (id == null)
				{
					return new SysUser();
				}
				return (SysUser)_dataService.GetByIdAsync(typeof(SysUser), Guid.Parse(id)).GetAwaiter().GetResult();
			}
		}

		public EntityController(
			IGenericDataService dataService,
			ITypeResolver typeResolver,
			ILogger<EntityController> logger,
			IExportService exportService)
		{
			_dataService = dataService;
			_typeResolver = typeResolver;
			_logger = logger;
			_exportService = exportService;
		}

		/// <summary>
		/// GET /api/entities/Organization/1
		/// </summary>
		[HttpGet("{entityType}/{id}")]
		[Authorize]
		public async Task<IActionResult> GetById(string entityType, string id)
		{
			try
			{
				var type = _typeResolver.ResolveType(entityType);

				// Попытаться преобразовать id в нужный тип
				object convertedId = ConvertId(id);

				var result = await _dataService.GetByIdAsync(type, convertedId);

				if (result == null)
					return NotFound(new { message = $"Entity '{entityType}' with id '{id}' not found" });

				if (result is BaseEntity be)
				{
					if (be.CreatedById != SysUser.Id)
					{
						return NotFound(new { message = $"Entity '{entityType}' with id '{id}' not found" });
					}
				}

				return Ok(result);
			}
			catch (InvalidOperationException ex)
			{
				_logger.LogWarning($"Invalid entity type: {entityType}");
				return BadRequest(new { message = ex.Message });
			}
			catch (Exception ex)
			{
				_logger.LogError($"Error getting entity: {ex.Message}");
				return StatusCode(500, new { message = "Internal server error" });
			}
		}

		/// <summary>
		/// GET /api/entities/Organization
		/// </summary>
		[HttpGet("{entityType}")]
		[Authorize]
		public async Task<IActionResult> GetAll(string entityType, [FromQuery] int? skip = null, [FromQuery] int? take = null)
		{
			try
			{
				var type = _typeResolver.ResolveType(entityType);
				var result = await _dataService.GetAllAsync(type, SysUser.Id);

				if (skip.HasValue || take.HasValue)
				{
					result = result.Skip(skip ?? 0).Take(take ?? 100);
				}

				return Ok(new { count = result.Count(), data = result });
			}
			catch (InvalidOperationException ex)
			{
				return BadRequest(new { message = ex.Message });
			}
		}

		/// <summary>
		/// POST /api/entities/Organization
		/// Body: { "orgFullName": "ООО Компания", ... }
		/// </summary>
		[HttpPost("{entityType}")]
		[Authorize]
		public async Task<IActionResult> Create(string entityType, [FromBody] JObject payload)
		{
			try
			{
				var type = _typeResolver.ResolveType(entityType);
				object? entity;

				if (type == typeof(TextBlock))
				{
					entity = ParseTextBlock(payload);
				}
				else
				{
					entity = payload.ToObject(type);
				}

				var createdByIdProp = type.GetProperty("CreatedById");

				if (createdByIdProp != null)
				{
					createdByIdProp.SetValue(entity, SysUser.Id);
				}

				var createdAtProp = type.GetProperty("CreatedAt");

				if (createdAtProp != null)
				{
					createdAtProp.SetValue(entity, DateTime.UtcNow);
				}

				await _dataService.CreateAsync(type, entity);

				return CreatedAtAction(nameof(GetById),
					new { entityType = entityType, id = GetEntityId(entity) },
					entity);
			}
			catch (InvalidOperationException ex)
			{
				return BadRequest(new { message = ex.Message });
			}
			catch (JsonException ex)
			{
				return BadRequest(new { message = "Invalid JSON payload", details = ex.Message });
			}
		}

		/// <summary>
		/// PUT /api/entities/Organization/1
		/// Body: { "orgFullName": "Новое название", ... }
		/// </summary>
		[HttpPut("{entityType}/{id}")]
		[Authorize]
		public async Task<IActionResult> Update(string entityType, Guid id, [FromBody] JObject payload)
		{
			try
			{
				var type = _typeResolver.ResolveType(entityType);
				object? entity;

				if (type == typeof(TextBlock))
				{
					entity = ParseTextBlock(payload);
				}
				else
				{
					entity = payload.ToObject(type);
				}

				var dbEntity = await _dataService.GetByIdAsync(type, id);

				if (dbEntity is BaseEntity be)
				{
					if (be.CreatedById != SysUser.Id)
					{
						return NotFound(new { message = $"Entity '{entityType}' with id '{id}' not found" });
					}
				}

				var dict = payload.ToObject<Dictionary<string, object>>();

				var properties = type.GetProperties();

				foreach (var key in dict.Keys)
				{
					var prop = properties.First(x => x.Name == key);
					var newValue = prop.GetValue(entity);
					prop.SetValue(dbEntity, newValue);
				}

				var updatedByIdProp = type.GetProperty("UpdatedById");

				if (updatedByIdProp != null)
				{
					updatedByIdProp.SetValue(entity, SysUser.Id);
				}

				var updatedAtProp = type.GetProperty("UpdatedAt");

				if (updatedAtProp != null)
				{
					updatedAtProp.SetValue(entity, DateTime.UtcNow);
				}

				var success = await _dataService.UpdateAsync(type, dbEntity);

				if (!success)
					return NotFound(new { message = $"Entity '{entityType}' with id '{id}' not found" });

				return NoContent();
			}
			catch (InvalidOperationException ex)
			{
				return BadRequest(new { message = ex.Message });
			}
		}

		private object? ParseTextBlock(JObject textObject)
		{
			var elementsToken = textObject["Elements"];
			var elementsList = new List<BaseTextBlockElement>();
			if (elementsToken != null)
			{
				foreach (var elementToken in elementsToken)
				{
					var element = this.ParseTextBlockElement(elementToken.ToString());
					if (element != null)
					{
						elementsList.Add(element);
					}
				}
				textObject.Remove("Elements");
			}
			var entity = textObject.ToObject(typeof(TextBlock));
			textObject["Elements"] = elementsToken;
			if (elementsList.Count > 0)
			{
				((TextBlock)entity).Elements = elementsList;
			}
			return entity;
		}

		private BaseTextBlockElement? ParseTextBlockElement(string text)
		{
			BaseTextBlockElement? result;
			try
			{
				result = JsonSerializer.Deserialize<TextBlockTable>(text);
			}
			catch
			{
				try
				{
					result = JsonSerializer.Deserialize<TextBlockImage>(text);
				}
				catch
				{
					try
					{
						result = JsonSerializer.Deserialize<TextBlockText>(text);
					}
					catch
					{
						try
						{
							result = JsonSerializer.Deserialize<TextBlockSubTitle>(text);
						}
						catch
						{
							result = null;
						}
					}
				}

			}

			return result;
		}

		/// <summary>
		/// DELETE /api/entities/Organization/1
		/// </summary>
		[HttpDelete("{entityType}/{id}")]
		[Authorize]
		public async Task<IActionResult> Delete(string entityType, string id)
		{
			try
			{
				var type = _typeResolver.ResolveType(entityType);
				var convertedId = ConvertId(id);

				var entity = await _dataService.GetByIdAsync(type, convertedId);

				if (entity is BaseEntity be)
				{
					if (be.CreatedById != SysUser.Id)
					{
						return NotFound(new { message = $"Entity '{entityType}' with id '{id}' not found" });
					}
				}

				var success = await _dataService.DeleteAsync(type, convertedId);

				if (!success)
					return NotFound(new { message = $"Entity '{entityType}' with id '{id}' not found" });

				return NoContent();
			}
			catch (InvalidOperationException ex)
			{
				return BadRequest(new { message = ex.Message });
			}
		}

		/// <summary>
		/// GET /api/entities/types
		/// Список всех доступных типов
		/// </summary>
		[HttpGet("admin/types")]
		public IActionResult GetAvailableTypes()
		{
			var types = _typeResolver.GetAllEntityTypes()
				.Select(t => new { name = t.Name, fullName = t.FullName })
				.OrderBy(t => t.name);

			return Ok(types);
		}

		[HttpGet("admin/types/{entityType}")]
		public IActionResult GetEntityTypeStructure(string entityType)
		{
			try
			{
				var type = _typeResolver.ResolveType(entityType);
				var entity = Activator.CreateInstance(type);
				var properties = type.GetProperties();

				var dict = new Dictionary<string, string>();

				foreach(var property in properties.Where(x => x.SetMethod != null))
				{
					property.SetValue(entity, default);
					dict.Add(property.Name, property.PropertyType.ToString());
				}

				return Ok(dict);
			}
			catch (Exception ex)
			{
				return BadRequest(new { message = ex.Message });
			}
		}

		[HttpGet("fullNote/{id}")]
		[Authorize]
		public async Task<IActionResult> GetFullNote(Guid id)
		{
			var fullNote = await _exportService.GetFullNote(id, SysUser.Id);

			var ns = new XmlSerializerNamespaces();
			ns.Add("", "");

			var serializer = new XmlSerializer(typeof(ExplanatoryNote));

			using var memoryStream = new MemoryStream();


			var settings = new XmlWriterSettings
			{
				Indent = true,
				Encoding = Encoding.UTF8,
				OmitXmlDeclaration = false
			};

			using (var writer = XmlWriter.Create(memoryStream, settings))
			{
				serializer.Serialize(writer, fullNote, ns);
			}


			return File(
				memoryStream.ToArray(),
				"application/xml",
				$"document_{id}.xml"
			);
		}

		[HttpGet("fullNote/pdf/{id}")]
		[Authorize]
		public async Task<IActionResult> GetFullNotePdf(Guid id)
		{
			var fullNote = await _exportService.GetFullNote(id, SysUser.Id);

			var ns = new XmlSerializerNamespaces();
			ns.Add("", "");

			var serializer = new XmlSerializer(typeof(ExplanatoryNote));

			using var memoryStream = new MemoryStream();


			var settings = new XmlWriterSettings
			{
				Indent = true,
				Encoding = Encoding.UTF8,
				OmitXmlDeclaration = false
			};

			using (var writer = XmlWriter.Create(memoryStream, settings))
			{
				serializer.Serialize(writer, fullNote, ns);
			}

			var transform = new XslCompiledTransform();
			transform.Load("explanatorynote-01-05.xsl");
			using var resultwriter = new StringWriter();
			memoryStream.Position = 0;
			using (var xmlReader = XmlReader.Create(memoryStream))
			{
				transform.Transform(xmlReader, null, resultwriter);
			}
			var html = resultwriter.ToString();
			
			var pdfBytes = ConvertHtmlToPdfBytes(html);

			return File(
				pdfBytes,
				"application/pdf",
				$"document_{id}.pdf");
		}

		private byte[] ConvertHtmlToPdfBytes(string html)
		{
			var converter = new SynchronizedConverter(new PdfTools());

			var doc = new HtmlToPdfDocument
			{
				GlobalSettings = new()
				{
					ColorMode = ColorMode.Color,
					Orientation = Orientation.Portrait,
					PaperSize = PaperKind.A4
				},
				Objects =
				{
					new ObjectSettings
					{
						HtmlContent = html,
						WebSettings = { DefaultEncoding = "utf8" }
					}
				}
			};

			var pdfBytes = converter.Convert(doc);

			//var pdf = ;

			return pdfBytes;
		}

		private object ConvertId(string id)
		{
			// Попытаться преобразовать в int
			if (int.TryParse(id, out int intId))
				return intId;

			// Попытаться преобразовать в guid
			if (Guid.TryParse(id, out Guid guidId))
				return guidId;

			// По умолчанию - строка
			return id;
		}

		private object GetEntityId(object entity)
		{
			var idProp = entity.GetType().GetProperty("Id");
			return idProp?.GetValue(entity) ?? "unknown";
		}
	}

}
