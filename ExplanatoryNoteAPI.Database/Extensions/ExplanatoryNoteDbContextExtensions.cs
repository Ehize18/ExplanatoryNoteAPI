using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExplanatoryNoteAPI.Database.Extensions
{
	public static class ExplanatoryNoteDbContextExtensions
	{
		public static void LoadFullGraph<T>(this DbContext context, T rootEntity) where T : class
		{
			var queue = new Queue<object>();
			queue.Enqueue(rootEntity);

			var visited = new HashSet<object> { rootEntity };

			while (queue.Count > 0)
			{
				var currentEntity = queue.Dequeue();
				var entry = context.Entry(currentEntity);

				foreach (var navigation in entry.Metadata.GetNavigations())
				{
					var navEntry = entry.Navigation(navigation.Name);
					if (!navEntry.IsLoaded)
					{
						navEntry.Load();
					}

					var navValue = navEntry.CurrentValue;

					if (navValue == null)
						continue;

					if (navigation.IsCollection)
					{
						if (navValue is System.Collections.IEnumerable collection)
						{
							foreach (var child in collection)
							{
								if (child != null && visited.Add(child))
								{
									queue.Enqueue(child);
								}
							}
						}
					}
					else
					{
						if (visited.Add(navValue))
						{
							queue.Enqueue(navValue);
						}
					}
				}
			}
		}

		public static IQueryable<TEntity> IncludeFirstLevel<TEntity>(this IQueryable<TEntity> query, DbContext context) where TEntity : class
		{
			var navigations = context.Model.FindEntityType(typeof(TEntity))!.GetNavigations();

			foreach(var navigation in navigations)
			{
				query = query.Include(navigation.Name);
			}
			return query;
		}
	}
}
