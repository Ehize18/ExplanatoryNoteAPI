using System.ComponentModel.DataAnnotations;

namespace ExplanatoryNoteAPI.Core.Abstractions
{
	public abstract class BaseClassificator : IHasId
	{
		[Key]
		public Guid Id { get; set; }

		public required string Name { get; set; }

		public required string Code { get; set; }
	}
}
