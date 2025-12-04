using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Изменение
	/// </summary>
	public class Modification : BaseEntity
	{
		[XmlElement("ModificationNumber")]
		public int? ModificationNumber { get; set; }

		[XmlElement("ModificationDate")]
		public DateTime? ModificationDate { get; set; }

		[XmlElement("ModificationNote")]
		public string? ModificationNote { get; set; }

		[XmlIgnore]
		public ExplanatoryNoteModifications? ExplanatoryNoteModifications { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ExplanatoryNoteModifications))]
		public Guid? ExplanatoryNoteModificationsId { get; set; }
	}
}
