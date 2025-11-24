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

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="usersRepository">Репозиторий пользователей.</param>
		/// <param name="jwtProvider">Провайдер JWT токенов.</param>
		public AuthService(IRepositoryFactory repositoryFactory, IJwtProvider jwtProvider)
		{
			_usersRepository = repositoryFactory.CreateRepository<SysUser>();
			_jwtProvider = jwtProvider;
		}

		public async Task<bool> RegisterUser(AuthRequest request)
		{
			var user = new SysUser()
			{
				Id = Guid.NewGuid(),
				Email = request.Email,
				PasswordHash = Hash.SHA256Hash(request.Password),
			};

			try
			{
				await _usersRepository.AddAsync(user);
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public async Task<string> LoginUser(AuthRequest request)
		{
			var user = (await _usersRepository.FindAsync(u => u.Email == request.Email)).FirstOrDefault();

			var requestPasswordHash = Hash.SHA256Hash(request.Password);

			if (user != null &&
				user.PasswordHash == requestPasswordHash)
			{
				var token = _jwtProvider.GenerateToken(request.Email);
				return token;
			}
			return string.Empty;
		}
	}
}
