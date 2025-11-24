using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Раздел проектной документации
	/// </summary>
	public class ProjectDocumentSection : BaseEntity
	{
		[XmlElement("NotDeveloped")]
		public string? NotDeveloped { get; set; }

		[XmlElement("SectionContent")]
		public ProjectDocumentSectionContent? SectionContent { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(SectionContent))]
		public Guid? SectionContentId { get; set; }
	}
}
