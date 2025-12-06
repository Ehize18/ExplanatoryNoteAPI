using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Содержание раздела проектной документации
	/// </summary>
	public class ProjectDocumentSectionContent : BaseEntity
	{
		[XmlElement("Document")]
		public List<ProjectDocument>? Document { get; set; }

		[XmlElement("SubSection")]
		public List<ProjectDocumentSubSection>? SubSection { get; set; }
	}
}
