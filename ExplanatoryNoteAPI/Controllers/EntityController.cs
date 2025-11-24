using System.Text.Json;
using ExplanatoryNoteAPI.Application.Services;
using ExplanatoryNoteAPI.Core;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace ExplanatoryNoteAPI.Controllers
{
	[ApiController]
	[Route("api/entities")]
	public class EntityController : ControllerBase
	{
		private readonly IGenericDataService _dataService;
		private readonly ITypeResolver _typeResolver;
		private readonly ILogger<EntityController> _logger;

		public EntityController(
			IGenericDataService dataService,
			ITypeResolver typeResolver,
			ILogger<EntityController> logger)
		{
			_dataService = dataService;
			_typeResolver = typeResolver;
			_logger = logger;
		}

		/// <summary>
		/// GET /api/entities/Organization/1
		/// </summary>
		[HttpGet("{entityType}/{id}")]
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
		public async Task<IActionResult> GetAll(string entityType, [FromQuery] int? skip = null, [FromQuery] int? take = null)
		{
			try
			{
				var type = _typeResolver.ResolveType(entityType);
				var result = await _dataService.GetAllAsync(type);

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
		public async Task<IActionResult> Create(string entityType, [FromBody] JObject payload)
		{
			try
			{
				var type = _typeResolver.ResolveType(entityType);
				var entity = payload.ToObject(type);

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
		public async Task<IActionResult> Update(string entityType, string id, [FromBody] JObject payload)
		{
			try
			{
				var type = _typeResolver.ResolveType(entityType);
				var entity = payload.ToObject(type);

				var success = await _dataService.UpdateAsync(type, entity);

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
		/// DELETE /api/entities/Organization/1
		/// </summary>
		[HttpDelete("{entityType}/{id}")]
		public async Task<IActionResult> Delete(string entityType, string id)
		{
			try
			{
				var type = _typeResolver.ResolveType(entityType);
				var convertedId = ConvertId(id);

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
