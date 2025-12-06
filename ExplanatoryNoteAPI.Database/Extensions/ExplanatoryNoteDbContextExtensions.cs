using ExplanatoryNoteAPI.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExplanatoryNoteAPI.Database.Extensions
{
	public static class ExplanatoryNoteDbContextExtensions
	{
		public static IQueryable<T> IncludeAll<T>(this IQueryable<T> query, ExplanatoryNoteDbContext context, int maxDepth = 5) where T : class
		{
			var entityType = context.Model.FindEntityType(typeof(T));
			if (entityType == null) return query;

			var includePaths = new List<string>();

			// Начинаем рекурсию. Стек родителей изначально содержит корневой тип.
			var stack = new HashSet<IEntityType> { entityType };

			BuildIncludePaths(entityType, "", includePaths, stack, maxDepth);

			foreach (var path in includePaths)
			{
				query = query.Include(path);
			}

			return query;

		}

		private static void BuildIncludePaths(
			IEntityType currentEntity,
			string currentPath,
			List<string> includePaths,
			HashSet<IEntityType> ancestorStack, // Стек родителей только для ЭТОЙ ветки
			int depth)
		{
			if (depth <= 0) return;

			var navigations = currentEntity.GetNavigations();

			foreach (var navigation in navigations.Where(x => x.ClrType != typeof(SysUser)))
			{
				var targetType = navigation.TargetEntityType;

				// ГЛАВНАЯ ПРОВЕРКА ЦИКЛА:
				// Если тип, на который мы ссылаемся, УЖЕ есть в списке наших родителей (выше по стеку),
				// значит мы идем по кругу (Parent -> Child -> Parent). Пропускаем.
				if (ancestorStack.Contains(targetType))
					continue;

				// Строим путь для Include
				var nextPath = string.IsNullOrEmpty(currentPath)
					? navigation.Name
					: $"{currentPath}.{navigation.Name}";

				includePaths.Add(nextPath);

				// Добавляем текущий тип в стек перед спуском вниз
				ancestorStack.Add(targetType);

				// Рекурсивно идем глубже
				BuildIncludePaths(targetType, nextPath, includePaths, ancestorStack, depth - 1);

				// ВАЖНО: Убираем тип из стека, когда возвращаемся назад (backtracking).
				// Это позволяет этому же типу появиться в СОСЕДНЕЙ ветке, но не в этой же.
				ancestorStack.Remove(targetType);
			}
		}

		public static void LoadFullGraph<T>(this DbContext context, T rootEntity) where T : class
		{
			// Используем очередь для BFS (обход в ширину), чтобы избежать рекурсии стека
			var queue = new Queue<object>();
			queue.Enqueue(rootEntity);

			// Храним посещённые ОБЪЕКТЫ (конкретные экземпляры), чтобы не зациклиться
			var visited = new HashSet<object> { rootEntity };

			while (queue.Count > 0)
			{
				var currentEntity = queue.Dequeue();
				var entry = context.Entry(currentEntity);

				// Получаем все навигации (связи) для текущего типа
				foreach (var navigation in entry.Metadata.GetNavigations())
				{
					// Если связь еще не загружена - грузим её из БД
					var navEntry = entry.Navigation(navigation.Name);
					if (!navEntry.IsLoaded)
					{
						navEntry.Load();
					}

					// Получаем значение (это может быть одиночная сущность или коллекция)
					var navValue = navEntry.CurrentValue;

					if (navValue == null)
						continue;

					// Если это коллекция (List, ICollection и т.д.)
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
					// Если это одиночная ссылка
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
	}
}
