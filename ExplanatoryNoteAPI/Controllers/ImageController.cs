using System.Buffers.Text;
using ExplanatoryNoteAPI.Application.Contracts;
using ExplanatoryNoteAPI.Application.Interfaces;
using ExplanatoryNoteAPI.Application.Services;
using ExplanatoryNoteAPI.Core.Entities;
using ExplanatoryNoteAPI.Core.Entities.TextBlockEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplanatoryNoteAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ImageController : ControllerBase
	{
		private readonly IFileService _fileService;
		private readonly IGenericDataService _dataService;

		public ImageController(IFileService fileService, IGenericDataService dataService)
		{
			_fileService = fileService;
			_dataService = dataService;
		}

		[HttpPost("{textBlockId:guid}")]
		public async Task<IActionResult> Upload(Guid textBlockId, string? comment, int order, IFormFile file)
		{
			var fileDTO = new ImageDTO
			{
				FileName = file.FileName,
				ContentType = file.ContentType,
				Stream = file.OpenReadStream(),
				TextBlockId = textBlockId,
				Comment = comment,
				Order = order
			};
			var id = await _fileService.Upload(fileDTO);
			return Ok(id);
		}

		[HttpGet("{textBlockId:guid}/{order:int}")]
		public async Task<IActionResult> ImageFromBase64(Guid textBlockId, int order)
		{
			var obj = await _dataService.GetByIdAsync(typeof(TextBlock), textBlockId);
			if (obj != null && obj is TextBlock textBlock)
			{
				var element = textBlock.Elements.FirstOrDefault(x => x.Order == order);
				if (element != null && element is TextBlockImage image)
				{
					var bytes = Convert.FromBase64String(image.ImageData);
					var mamoryStream = new MemoryStream(bytes);
					return File(mamoryStream, $"image/{image.Type}");
				}
			}

			return NotFound();
		}
	}
}
