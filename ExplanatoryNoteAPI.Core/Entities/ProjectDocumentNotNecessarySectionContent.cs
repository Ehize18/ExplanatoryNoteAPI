using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Содержание необязательного раздела
	/// </summary>
	public class ProjectDocumentNotNecessarySectionContent : BaseEntity
	{
		[XmlElement("Document")]
		public List<ProjectDocument>? Document { get; set; }

		[XmlElement("OtherDocument")]
		public List<Document>? OtherDocument { get; set; }
	}
}
