using ExplanatoryNoteAPI.Core;
using ExplanatoryNoteAPI.Core.Interfaces;

namespace ExplanatoryNoteAPI.Application.Services
{
	public interface IGenericDataService
	{
		Task<object> GetByIdAsync(Type entityType, object id);
		Task<IEnumerable<object>> GetAllAsync(Type entityType);
		Task<IEnumerable<object>> FindAsync(Type entityType, string jsonPredicate);
		Task<object> CreateAsync(Type entityType, object entity);
		Task<bool> UpdateAsync(Type entityType, object entity);
		Task<bool> DeleteAsync(Type entityType, object id);
	}

	public class GenericDataService : IGenericDataService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly ITypeResolver _typeResolver;

		public GenericDataService(IUnitOfWork unitOfWork, ITypeResolver typeResolver)
		{
			_unitOfWork = unitOfWork;
			_typeResolver = typeResolver;
		}

		public async Task<object> GetByIdAsync(Type entityType, object id)
		{
			ValidateType(entityType);

			var method = typeof(IRepository<>)
				.MakeGenericType(entityType)
				.GetMethod(nameof(IRepository<object>.GetByIdAsync));

			var repository = _unitOfWork.Repository(entityType);
			var task = (Task)method.Invoke(repository, new[] { id });

			await task.ConfigureAwait(false);
			var resultProperty = task.GetType().GetProperty("Result");
			return resultProperty?.GetValue(task);
		}

		public async Task<IEnumerable<object>> GetAllAsync(Type entityType)
		{
			ValidateType(entityType);

			var method = typeof(IRepository<>)
				.MakeGenericType(entityType)
				.GetMethod(nameof(IRepository<object>.GetAllAsync));

			var repository = _unitOfWork.Repository(entityType);
			var task = (Task)method.Invoke(repository, Array.Empty<object>());

			await task.ConfigureAwait(false);
			var resultProperty = task.GetType().GetProperty("Result");
			return (IEnumerable<object>)resultProperty?.GetValue(task);
		}

		public async Task<IEnumerable<object>> FindAsync(Type entityType, string jsonPredicate)
		{
			ValidateType(entityType);

			// Простой поиск по первому свойству
			var properties = entityType.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.IgnoreCase);

			return await GetAllAsync(entityType);
		}

		public async Task<object> CreateAsync(Type entityType, object entity)
		{
			ValidateType(entityType);

			if (entity == null)
			{
				throw new ArgumentNullException(nameof(entity));
			}
			var method = typeof(IRepository<>)
				.MakeGenericType(entityType)
				.GetMethod(nameof(IRepository<object>.AddAsync));

			var repository = _unitOfWork.Repository(entityType);
			var task = (Task)method.Invoke(repository, new[] { entity });

			await task.ConfigureAwait(false);
			await _unitOfWork.SaveChangesAsync();

			return entity;
		}

		public async Task<bool> UpdateAsync(Type entityType, object entity)
		{
			ValidateType(entityType);

			if (entity == null)
			{
				throw new ArgumentNullException(nameof(entity));
			}
			var method = typeof(IRepository<>)
				.MakeGenericType(entityType)
				.GetMethod(nameof(IRepository<object>.UpdateAsync));

			var repository = _unitOfWork.Repository(entityType);
			var task = (Task)method.Invoke(repository, new[] { entity });

			await task.ConfigureAwait(false);

			return true;
		}

		public async Task<bool> DeleteAsync(Type entityType, object id)
		{
			ValidateType(entityType);

			var entity = await GetByIdAsync(entityType, id);

			if (entity == null)
			{
				return false;
			}
			var method = typeof(IRepository<>)
				.MakeGenericType(entityType)
				.GetMethod(nameof(IRepository<object>.DeleteAsync));

			var repository = _unitOfWork.Repository(entityType);
			var task = (Task)method.Invoke(repository, new[] { entity });

			await task.ConfigureAwait(false);

			return true;
		}

		private void ValidateType(Type entityType)
		{
			if (!_typeResolver.IsValidEntityType(entityType))
			{
				throw new InvalidOperationException($"Type '{entityType.Name}' is not a valid entity type");
			}
		}
	}

}
