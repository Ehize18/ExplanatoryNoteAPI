using System.ComponentModel.DataAnnotations;

namespace ExplanatoryNoteAPI.Core.Abstractions
{
	public abstract class BaseClassificator
	{
		[Key]
		public Guid Id { get; set; }

		public required string Name { get; set; }

		public required string Code { get; set; }
	}
}
