using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Документ проектной документации
	/// </summary>
	public class ProjectDocument : BaseEntity
	{
		[XmlElement("DocName")]
		public string? DocName { get; set; }

		[XmlElement("DocNumber")]
		public string? DocNumber { get; set; }

		[XmlElement("DocChanges")]
		public string? DocChanges { get; set; }

		[XmlElement("ProjectDocParticipants")]
		public ProjectDocParticipants? ProjectDocParticipants { get; set; }

		[XmlIgnore]
		public List<File>? Files { get; set; }

		[XmlElement("IULFile")]
		[NotMapped]
		public List<File>? IULFile => this.Files?.Where(x => x.Type == 1).ToList();

		[XmlElement("File")]
		[NotMapped]
		public List<File>? File => this.Files?.Where(x => x.Type == 0).ToList();

		[XmlAttribute("ObjectIDREFS")]
		public string? ObjectIDREFS { get; set; }

		//[XmlIgnore]
		//public ProjectDocumentSectionContent? ProjectDocumentSectionContent { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ProjectDocumentSectionContent))]
		public Guid? ProjectDocumentSectionContentId { get; set; }

		//[XmlIgnore]
		//public ProjectDocumentSubSection? ProjectDocumentSubSection { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ProjectDocumentSubSection))]
		public Guid? ProjectDocumentSubSectionId { get; set; }

		//[XmlIgnore]
		//public ProjectDocumentNotNecessarySectionContent? ProjectDocumentNotNecessarySectionContent { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ProjectDocumentNotNecessarySectionContent))]
		public Guid? ProjectDocumentNotNecessarySectionContentId { get; set; }
	}
}
