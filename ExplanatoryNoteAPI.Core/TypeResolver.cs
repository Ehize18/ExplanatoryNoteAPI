using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ExplanatoryNoteAPI.Core.Entities;

namespace ExplanatoryNoteAPI.Core
{
	public interface ITypeResolver
	{
		Type ResolveType(string typeName);
		IEnumerable<Type> GetAllEntityTypes();
		bool IsValidEntityType(Type type);
	}

	public class TypeResolver : ITypeResolver
	{
		private readonly Dictionary<string, Type> _typeCache;
		private readonly Assembly _assembly;

		public TypeResolver()
		{
			_assembly = typeof(ExplanatoryNote).Assembly;
			_typeCache = BuildTypeCache();
		}

		private Dictionary<string, Type> BuildTypeCache()
		{
			return _assembly
				.GetTypes()
				.Where(t => (t.Namespace == "ExplanatoryNoteAPI.Core.Classificators" || t.Namespace == "ExplanatoryNoteAPI.Core.Entities")
					&& t.IsClass
					&& !t.IsAbstract
					&& !t.IsNested)
				.ToDictionary(t => t.Name, t => t, StringComparer.OrdinalIgnoreCase);
		}

		public Type ResolveType(string typeName)
		{
			if (string.IsNullOrWhiteSpace(typeName))
			{
				throw new ArgumentException("Type name cannot be empty", nameof(typeName));
			}
				

			if (!_typeCache.TryGetValue(typeName, out var type))
			{
				throw new InvalidOperationException($"Type '{typeName}' not found in schema");
			}
				

			return type;
		}

		public IEnumerable<Type> GetAllEntityTypes()
		{
			return _typeCache.Values;
		}

		public bool IsValidEntityType(Type type)
		{
			return (type.Namespace == "ExplanatoryNoteAPI.Core.Classificators" || type.Namespace == "ExplanatoryNoteAPI.Core.Entities")
				&& type.IsClass
				&& !type.IsAbstract
				&& !type.IsNested;
		}
	}

}
