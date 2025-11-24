using System.ComponentModel.DataAnnotations;

namespace ExplanatoryNoteAPI.Application.Contracts.Requests
{
	public record AuthRequest([Required][EmailAddress] string Email, [Required] string Password)
	{
	}
}
