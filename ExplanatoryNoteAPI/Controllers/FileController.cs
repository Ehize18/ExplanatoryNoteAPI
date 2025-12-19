using ExplanatoryNoteAPI.Application.Contracts;
using ExplanatoryNoteAPI.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExplanatoryNoteAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FileController : ControllerBase
	{
		private readonly IFileService _fileService;

		public FileController(IFileService fileService)
		{
			_fileService = fileService;
		}

		[HttpPost]
		public async Task<IActionResult> Upload(IFormFile file)
		{
			var fileDTO = new FileDTO
			{
				FileName = file.FileName,
				ContentType = file.ContentType,
				Stream = file.OpenReadStream()
			};
			var id = await _fileService.Upload(fileDTO);
			return Ok(id);
		}

		[HttpGet("{id:guid}")]
		public async Task<IActionResult> Download(Guid id)
		{
			var file = await _fileService.Download(id);

			if (file == null)
			{
				return NotFound();
			}

			return File(file.Stream, file.ContentType, file.FileName);
		}
	}
}
