using System.Linq.Expressions;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Interfaces
{
	public interface IRepository<TEntity> where TEntity : class, IHasId
	{
		Task<TEntity?> GetByIdAsync(Guid id);
		Task<IEnumerable<TEntity>> GetAllAsync();
		Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
		Task AddAsync(TEntity entity);
		Task UpdateAsync(TEntity entity);
		Task DeleteAsync(TEntity entity);
		Task SaveChangesAsync();
	}
}
