using ExplanatoryNoteAPI.Application.Contracts.Requests;

namespace ExplanatoryNoteAPI.Application.Interfaces
{
	public interface IAuthService
	{
		Task<string> LoginUser(AuthRequest request);
		Task<bool> VerifyEmail(VerifyRequest request);
		Task<bool> SendVerificationCode(string email);
		Task<bool> RegisterUser(AuthRequest request);
	}
}
