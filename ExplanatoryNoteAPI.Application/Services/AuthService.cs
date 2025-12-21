using ExplanatoryNoteAPI.Application.Contracts.Requests;
using ExplanatoryNoteAPI.Application.Interfaces;
using ExplanatoryNoteAPI.Core.Entities;
using ExplanatoryNoteAPI.Core.Interfaces;
using ExplanatoryNoteAPI.Database.Repositories;
using ExplanatoryNoteAPI.Utilities.Hash;
using ExplanatoryNoteAPI.Utilities.Jwt;

namespace ExplanatoryNoteAPI.Application.Services
{
	public class AuthService : IAuthService
	{
		/// <summary>
		/// Репозиторий пользователей.
		/// </summary>
		private readonly IRepository<SysUser> _usersRepository;

		/// <summary>
		/// Провайдер JWT токенов.
		/// </summary>
		private readonly IJwtProvider _jwtProvider;

		private readonly IEmailService _emailService;

		private readonly ICache _cache;

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="usersRepository">Репозиторий пользователей.</param>
		/// <param name="jwtProvider">Провайдер JWT токенов.</param>
		public AuthService(IRepositoryFactory repositoryFactory, IJwtProvider jwtProvider, IEmailService emailService, ICache cache)
		{
			_usersRepository = repositoryFactory.CreateRepository<SysUser>();
			_jwtProvider = jwtProvider;
			_emailService = emailService;
			_cache = cache;
		}

		public async Task<bool> RegisterUser(AuthRequest request)
		{
			var user = new SysUser()
			{
				Id = Guid.NewGuid(),
				Email = request.Email,
				PasswordHash = Hash.SHA256Hash(request.Password),
				IsEmailConfirmed = false,
				CreatedAt = DateTime.UtcNow
			};

			try
			{
				await _usersRepository.AddAsync(user);
				return await SendVerificationCode(request.Email);
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public async Task<bool> SendVerificationCode(string email)
		{
			try
			{
				var random = new Random();
				var randomInt = random.Next(1000, 99999999);
				var code = randomInt.ToString("D8");
				await _cache.SaveVerificationCode(email, code);
				await _emailService.Send(email, "Verification", code);
				return true;
			}
			catch
			{
				return false;
			}
		}

		public async Task<bool> VerifyEmail(VerifyRequest request)
		{
			var otpFromCache = await _cache.GetVerificationCode(request.Email);
			if (otpFromCache == null ||
				request.OtpCode != otpFromCache?.ToString("D8"))
			{
				return false;
			}
			var user = (await _usersRepository.FindAsync(x => x.Email == request.Email)).FirstOrDefault();
			if (user == null)
			{
				return false; 
			}
			user.IsEmailConfirmed = true;
			await _usersRepository.UpdateAsync(user);
			return true;
		}

		public async Task<string> LoginUser(AuthRequest request)
		{
			var user = (await _usersRepository.FindAsync(u => u.Email == request.Email)).FirstOrDefault();

			var requestPasswordHash = Hash.SHA256Hash(request.Password);

			if (user != null &&
				user.IsEmailConfirmed &&
				user.PasswordHash == requestPasswordHash)
			{
				var token = _jwtProvider.GenerateToken(user.Id.ToString());
				return token;
			}
			return string.Empty;
		}
	}
}
