using ExplanatoryNoteAPI.Core.Interfaces;

namespace ExplanatoryNoteAPI.Database.Repositories
{
	public interface IRepositoryFactory
	{
		IRepository<T> CreateRepository<T>() where T : class;
	}

	public class RepositoryFactory : IRepositoryFactory
	{
		private readonly ExplanatoryNoteDbContext _context;
		private readonly Dictionary<Type, Func<IRepository<object>>> _factories;

		public RepositoryFactory(ExplanatoryNoteDbContext context)
		{
			_context = context;
			_factories = new();
		}

		public IRepository<T> CreateRepository<T>() where T : class
		{
			var type = typeof(T);
			return new GenericRepository<T>(_context);
		}
	}
}
