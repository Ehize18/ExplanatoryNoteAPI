using ExplanatoryNoteAPI.Core;
using ExplanatoryNoteAPI.Core.Interfaces;
using ExplanatoryNoteAPI.Database;
using ExplanatoryNoteAPI.Database.Repositories;

namespace ExplanatoryNoteAPI.Application.Services
{
	public interface IUnitOfWork : IDisposable
	{
		IRepository<T> Repository<T>() where T : class;
		object Repository(Type type);
		Task<int> SaveChangesAsync();
	}

	public class UnitOfWork : IUnitOfWork
	{
		private readonly ExplanatoryNoteDbContext _context;
		private readonly Dictionary<Type, object> _repositories = new();
		private readonly ITypeResolver _typeResolver;

		public UnitOfWork(ExplanatoryNoteDbContext context, ITypeResolver typeResolver)
		{
			_context = context;
			_typeResolver = typeResolver;
		}

		public IRepository<T> Repository<T>() where T : class
		{
			var type = typeof(T);

			if (!_repositories.ContainsKey(type))
			{
				var repositoryType = typeof(GenericRepository<>).MakeGenericType(type)!;
				var repositoryInstance = Activator.CreateInstance(repositoryType, _context)!;
				_repositories.Add(type, repositoryInstance);
			}

			return (IRepository<T>)_repositories[type];
		}

		public object Repository(Type type)
		{
			if (!_typeResolver.IsValidEntityType(type))
				throw new InvalidOperationException($"Type '{type.Name}' is not a valid entity type");

			if (!_repositories.ContainsKey(type))
			{
				var repositoryType = typeof(GenericRepository<>).MakeGenericType(type)!;
				var repositoryInstance = Activator.CreateInstance(repositoryType, _context)!;
				_repositories.Add(type, repositoryInstance);
			}

			return _repositories[type];
		}

		public async Task<int> SaveChangesAsync()
		{
			return await _context.SaveChangesAsync();
		}

		public void Dispose()
		{
			_context?.Dispose();
		}
	}
}
