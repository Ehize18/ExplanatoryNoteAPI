namespace ExplanatoryNoteAPI.Core.Interfaces
{
	public interface ICache
	{
		Task<int?> GetVerificationCode(string email);
		Task SaveVerificationCode(string email, string verificationCode);
	}
}
