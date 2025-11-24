using ExplanatoryNoteAPI.Application.Contracts.Requests;
using ExplanatoryNoteAPI.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExplanatoryNoteAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IAuthService _authService;

		public AuthController(IAuthService authService)
		{
			_authService = authService;
		}

		[HttpPost("register")]
		public async Task<IActionResult> Register(AuthRequest request)
		{
			if (await _authService.RegisterUser(request))
			{
				var token = await _authService.LoginUser(request);

				if (!string.IsNullOrWhiteSpace(token))
				{
					HttpContext.Response.Cookies.Append("Token", token);
					return Ok();
				}
			}
			return BadRequest();
		}

		[HttpPost("login")]
		public async Task<IActionResult> Login(AuthRequest request)
		{
			var token = await _authService.LoginUser(request);

			if (!string.IsNullOrWhiteSpace(token))
			{
				HttpContext.Response.Cookies.Append("Token", token);
				return Ok();
			}
			return BadRequest();
		}
	}
}
