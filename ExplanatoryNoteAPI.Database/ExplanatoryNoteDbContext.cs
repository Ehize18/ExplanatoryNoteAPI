using System.Diagnostics.CodeAnalysis;
using ExplanatoryNoteAPI.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExplanatoryNoteAPI.Database
{
	public class ExplanatoryNoteDbContext : DbContext
	{
		public ExplanatoryNoteDbContext(DbContextOptions<ExplanatoryNoteDbContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			var classificators = typeof(ExplanatoryNote).Assembly
				.GetTypes()
				.Where(t => t.Namespace == "ExplanatoryNoteAPI.Core.Classificators"
					&& t.IsClass
					&& !t.IsAbstract
					&& !t.IsNested)
				.GroupBy(t => t.FullName)
				.Select(g => g.First())
				.ToList();

			foreach (var type in classificators)
			{
				modelBuilder.SafeAddType(type);
			}

			var entityTypes = typeof(ExplanatoryNote).Assembly
				.GetTypes()
				.Where(t => t.Namespace == "ExplanatoryNoteAPI.Core.Entities"
					&& t.IsClass
					&& !t.IsAbstract
					&& !t.IsNested)
				.GroupBy(t => t.FullName)
				.Select(g => g.First())
				.ToList();


			foreach (var type in entityTypes)
			{
				modelBuilder.SafeAddType(type);
			}

			Configure(modelBuilder);
		}

		private void Configure(ModelBuilder modelBuilder)
		{
			var entities = modelBuilder.Model.GetEntityTypes();

			foreach (var entity in entities)
			{
				var type = entity.GetType();
				var idProperty = type.GetProperty("Id");

				if (idProperty is not null)
				{
					modelBuilder.Entity(type).HasKey("Id");
				}

				var createdBy = type.GetProperty("CreatedBy");
				if (createdBy is not null)
				{
					modelBuilder.Entity(type)
						.HasOne(typeof(SysUser))
						.WithMany()
						.HasForeignKey("CreatedById");
				}

				var updatedBy = type.GetProperty("UpdatedBy");
				if (updatedBy is not null)
				{
					modelBuilder.Entity(type)
						.HasOne(typeof(SysUser))
						.WithMany()
						.HasForeignKey("UpdatedById");
				}
			}
		}

		public override DbSet<TEntity> Set<TEntity>() where TEntity : class
		{
			return base.Set<TEntity>();
		}
	}

	public static class ModelBuilderExtensions
	{
		public static ModelBuilder SafeAddType(this ModelBuilder modelBuilder, Type type)
		{
			var types = modelBuilder.Model.GetEntityTypes().Select(t => t.ClrType);

			if (!types.Contains(type))
			{
				modelBuilder.Model.AddEntityType(type);
			}

			return modelBuilder;
		}
	}
}
