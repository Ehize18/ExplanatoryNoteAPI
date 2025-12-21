using ExplanatoryNoteAPI.Core.Entities;
using ExplanatoryNoteAPI.Core.Interfaces;
using ExplanatoryNoteAPI.Database.Extensions;
using Microsoft.EntityFrameworkCore;

namespace ExplanatoryNoteAPI.Database.Repositories
{
	public class ExplanatoryNoteRepository : GenericRepository<ExplanatoryNote>, IRepository<ExplanatoryNote>
	{
		public ExplanatoryNoteRepository(ExplanatoryNoteDbContext context) : base(context)
		{
		}

		public async Task<ExplanatoryNote?> GetFullNote(Guid id, Guid creatorId)
		{
			var note = await this.GetByIdAsync(id);

			if (note == null || note.CreatedById != creatorId)
			{
				return null;
			}

			_context.LoadFullGraph(note);

			return note;
		}
	}
}
