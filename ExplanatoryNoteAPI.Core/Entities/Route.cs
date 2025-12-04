using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Маршрут
	/// </summary>
	public class Route : BaseEntity
	{
		[XmlElement("Name")]
		public string? Name { get; set; }

		[XmlElement("Note")]
		public TextBlock? Note { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Note))]
		public Guid? NoteId { get; set; }

		[XmlIgnore]
		public Routes? Routes { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Routes))]
		public Guid? RoutesId { get; set; }
	}
}
