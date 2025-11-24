using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Раздел 12 - Смета
	/// </summary>
	public class SectionEstimate : BaseEntity
	{
		[XmlElement("NotDeveloped")]
		public string? NotDeveloped { get; set; }

		[XmlElement("SectionContent")]
		public SectionEstimateContent? SectionContent { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(SectionContent))]
		public Guid? SectionContentId { get; set; }
	}
}
