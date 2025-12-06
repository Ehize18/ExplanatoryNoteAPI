using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Этап
	/// </summary>
	public class Stage : BaseEntity
	{
		[XmlElement("Number")]
		public string? Number { get; set; }

		[XmlElement("ConstructionDuration")]
		public decimal ConstructionDuration { get; set; }

		[XmlElement("BeginDate")]
		public DateTime? BeginDate { get; set; }

		[XmlElement("EndDate")]
		public DateTime? EndDate { get; set; }

		[XmlElement("OperationDate")]
		public DateTime? OperationDate { get; set; }

		[XmlElement("Note")]
		public TextBlock? Note { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Note))]
		public Guid? NoteId { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(StagesInfo))]
		public Guid? StagesInfoId { get; set; }
	}
}
