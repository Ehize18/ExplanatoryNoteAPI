using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Раздел 13 - Прочая документация
	/// </summary>
	public class OtherDocumentsSection : BaseEntity
	{
		[XmlElement("NotDeveloped")]
		public string? NotDeveloped { get; set; }

		[XmlElement("SectionContent")]
		public SectionOtherContent? SectionContent { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(SectionContent))]
		public Guid? SectionContentId { get; set; }
	}
}
