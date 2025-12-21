using ExplanatoryNoteAPI.Core;
using ExplanatoryNoteAPI.Core.Entities;
using ExplanatoryNoteAPI.Database.Repositories;

namespace ExplanatoryNoteAPI.Application.Services
{
	public interface IExportService
	{
		Task<ExplanatoryNote?> GetFullNote(Guid id, Guid creatorId);
	}

	public class ExportService : IExportService
	{
		private readonly IRepositoryFactory _repositoryFactory;

		public ExportService(IRepositoryFactory repositoryFactory)
		{
			_repositoryFactory = repositoryFactory;
		}

		public async Task<ExplanatoryNote?> GetFullNote(Guid id, Guid creatorId)
		{
			var repository = _repositoryFactory.CreateRepository<ExplanatoryNote>();

			if (repository is ExplanatoryNoteRepository explanatoryNoteRepository)
			{
				return await explanatoryNoteRepository.GetFullNote(id, creatorId);
			}
			else
			{
				return await repository.GetByIdAsync(id);
			}
		}
	}
}
