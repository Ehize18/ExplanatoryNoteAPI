using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Ссылка на проектную документацию
	/// </summary>
	public class ProjectDocumentationLink : BaseEntity
	{
		[XmlElement("DocNumber")]
		public string? DocNumber { get; set; }

		[XmlElement("DocSectionLink")]
		public string? DocSectionLink { get; set; }

		//[XmlIgnore]
		//public ProjectDocumentationLinks? ProjectDocumentationLinks { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ProjectDocumentationLinks))]
		public Guid? ProjectDocumentationLinksId { get; set; }
	}
}
