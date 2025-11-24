using ExplanatoryNoteAPI.Application.Contracts.Requests;

namespace ExplanatoryNoteAPI.Application.Interfaces
{
	public interface IAuthService
	{
		Task<string> LoginUser(AuthRequest request);
		Task<bool> RegisterUser(AuthRequest request);
	}
}
