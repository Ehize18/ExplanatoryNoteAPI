namespace ExplanatoryNoteAPI.Application.Contracts.Requests
{
	public record CreateEntityRequest(
		Dictionary<string, object> Columns
		);
}
