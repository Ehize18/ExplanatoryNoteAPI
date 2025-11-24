using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Информация об этапах
	/// </summary>
	public class StagesInfo : BaseEntity
	{
		[XmlElement("ReasonNote")]
		public TextBlock? ReasonNote { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ReasonNote))]
		public Guid? ReasonNoteId { get; set; }

		[XmlElement("Stage")]
		public List<Stage>? Stage { get; set; }
	}
}
