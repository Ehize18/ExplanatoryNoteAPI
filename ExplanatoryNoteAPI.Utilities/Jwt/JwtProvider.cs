using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace ExplanatoryNoteAPI.Utilities.Jwt
{
	public interface IJwtProvider
	{
		string GenerateToken(string email);
	}

	public class JwtProvider : IJwtProvider
	{
		private readonly JwtOptions _jwtOptions;

		public JwtProvider(IOptions<JwtOptions> options)
		{
			_jwtOptions = options.Value;
		}

		public string GenerateToken(string id)
		{
			var claims = new List<Claim>
			{
				new("Id", id),
			};

			var signingCredentials = new SigningCredentials(
				new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.SecretKey)), SecurityAlgorithms.HmacSha256);

			var token = new JwtSecurityToken(
				claims: claims,
				signingCredentials: signingCredentials,
				expires: DateTime.UtcNow.AddHours(_jwtOptions.ExpiredHours));

			var tokenValue = new JwtSecurityTokenHandler().WriteToken(token);

			return tokenValue;
		}
	}
}
