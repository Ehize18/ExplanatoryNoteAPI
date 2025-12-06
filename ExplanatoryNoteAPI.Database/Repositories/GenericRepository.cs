using System.Linq.Expressions;
using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Interfaces;
using ExplanatoryNoteAPI.Database.Extensions;
using Microsoft.EntityFrameworkCore;

namespace ExplanatoryNoteAPI.Database.Repositories
{
	public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class, IHasId
	{
		protected readonly ExplanatoryNoteDbContext _context;
		protected readonly DbSet<TEntity> _dbSet;

		public GenericRepository(ExplanatoryNoteDbContext context)
		{
			_context = context;
			_dbSet = context.Set<TEntity>();
		}

		public async Task<TEntity?> GetByIdAsync(Guid id)
		{
			return await _dbSet
				.IncludeFirstLevel<TEntity>(_context)
				.FirstOrDefaultAsync(x => x.Id == id);
		}

		public async Task<IEnumerable<TEntity>> GetAllAsync()
		{
			return await _dbSet.ToListAsync();
		}

		public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
		{
			return await _dbSet.Where(predicate).ToListAsync();
		}

		public async Task AddAsync(TEntity entity)
		{
			await _dbSet.AddAsync(entity);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(TEntity entity)
		{
			_dbSet.Update(entity);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(TEntity entity)
		{
			_dbSet.Remove(entity);
			await _context.SaveChangesAsync();
		}

		public async Task SaveChangesAsync()
		{
			await _context.SaveChangesAsync();
		}
	}
}
