using System.ComponentModel.DataAnnotations;

namespace ExplanatoryNoteAPI.Application.Contracts.Requests
{
	public class ReSendCodeRequest
	{
		[EmailAddress]
		public required string Email { get; set; }
	}
}
