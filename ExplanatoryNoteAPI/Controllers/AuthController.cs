using ExplanatoryNoteAPI.Application.Contracts.Requests;
using ExplanatoryNoteAPI.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
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
				return Ok();
			}
			return BadRequest();
		}

		[HttpPost("verify")]
		public async Task<IActionResult> Verify(VerifyRequest request)
		{
			if (await _authService.VerifyEmail(request))
			{
				var token = await _authService.LoginUser(request);

				if (!string.IsNullOrWhiteSpace(token))
				{
					HttpContext.Response.Cookies.Append("Token", token, new CookieOptions { HttpOnly = true });
					return Ok();
				}
			}
			return BadRequest();
		}

		[HttpPost("resendcode")]
		public async Task<IActionResult> ReSendCode(ReSendCodeRequest request)
		{
			if (await _authService.SendVerificationCode(request.Email))
			{
				return Ok();
			}
			return BadRequest();
		}

		[HttpPost("login")]
		public async Task<IActionResult> Login(AuthRequest request)
		{
			var token = await _authService.LoginUser(request);

			if (!string.IsNullOrWhiteSpace(token))
			{
				HttpContext.Response.Cookies.Append("Token", token, new CookieOptions { HttpOnly = true });
				return Ok();
			}
			return BadRequest();
		}

		[HttpPost("logout")]
		[Authorize]
		public async Task<IActionResult> Logout()
		{
			HttpContext.Response.Cookies.Delete("Token");
			return Ok();
		}
	}
}
