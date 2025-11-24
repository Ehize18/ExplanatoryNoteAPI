using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Текстовый блок
	/// </summary>
	public class TextBlock : BaseEntity
	{
		[XmlText]
		public string? Text { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ExplanatoryNote))]
		public Guid? ExplanatoryNoteId { get; set; }
	}
}
