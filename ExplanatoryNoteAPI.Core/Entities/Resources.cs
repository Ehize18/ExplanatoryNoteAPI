using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Ресурсы
	/// </summary>
	public class Resources : BaseEntity
	{
		[XmlElement("Note")]
		public TextBlock? Note { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Note))]
		public Guid? NoteId { get; set; }

		[XmlElement("Resource")]
		public List<Resource>? Resource { get; set; }
	}
}
