using ExplanatoryNoteAPI.Application.Contracts;

namespace ExplanatoryNoteAPI.Application.Interfaces
{
	public interface IFileService
	{
		Task<FileDTO?> Download(Guid id);
		Task<Guid> Upload(FileDTO fileDTO);
		Task<bool> Upload(ImageDTO imageDTO);
	}
}