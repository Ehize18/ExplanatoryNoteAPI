namespace ExplanatoryNoteAPI.Application.Contracts
{
	public class FileDTO
	{
		public required string FileName { get; set; }
		
		public required string ContentType { get; set; }

		public required Stream Stream { get; set; }
	}
}
