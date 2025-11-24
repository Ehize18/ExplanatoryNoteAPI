namespace ExplanatoryNoteAPI.Utilities.Jwt
{
	public class JwtOptions
	{
		public string SecretKey { get; set; }
		public int ExpiredHours { get; set; }
	}
}
