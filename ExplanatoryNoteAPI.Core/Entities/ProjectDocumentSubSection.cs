using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Подраздел проектной документации
	/// </summary>
	public class ProjectDocumentSubSection : BaseEntity
	{
		[XmlAttribute("Name")]
		public string? Name { get; set; }

		[XmlElement("Document")]
		public List<ProjectDocument>? Document { get; set; }

		[XmlElement("SubSection")]
		public List<ProjectDocumentSubSection>? SubSection { get; set; }



		//[XmlIgnore]
		//public ProjectDocumentSubSection? ParentSection { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ProjectDocumentSubSection))]
		public Guid? ParentSectionId { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ProjectDocumentSectionContent))]
		public Guid? ProjectDocumentSectionContentId { get; set; }
	}
}
