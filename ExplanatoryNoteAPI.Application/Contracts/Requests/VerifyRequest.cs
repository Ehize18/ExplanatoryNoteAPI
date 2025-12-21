using System.ComponentModel.DataAnnotations;

namespace ExplanatoryNoteAPI.Application.Contracts.Requests
{
	public record VerifyRequest : AuthRequest
	{
		public VerifyRequest([Required][EmailAddress] string Email, [Required] string Password, [Required] string OtpCode) : base(Email, Password)
		{
			this.OtpCode = OtpCode;
		}

		public string OtpCode { get; }
	}
}
