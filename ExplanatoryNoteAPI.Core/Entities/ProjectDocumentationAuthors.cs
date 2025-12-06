using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Авторы проектной документации
	/// </summary>
	public class ProjectDocumentationAuthors : BaseEntity
	{
		[XmlElement("ProjectDocumentationAuthor")]
		public List<Author>? ProjectDocumentationAuthor { get; set; }
	}
}
