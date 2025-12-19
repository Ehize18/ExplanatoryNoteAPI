namespace ExplanatoryNoteAPI.Application.Contracts
{
	public class ImageDTO : FileDTO
	{
		public Guid TextBlockId { get; set; }
		public string? Comment { get; set; }
		public int Order { get; set; }
	}
}
