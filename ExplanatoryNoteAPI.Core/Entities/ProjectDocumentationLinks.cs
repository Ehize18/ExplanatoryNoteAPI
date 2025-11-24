using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Ссылки на проектную документацию
	/// </summary>
	public class ProjectDocumentationLinks : BaseEntity
	{
		[XmlElement("ProjectDocumentationLink")]
		public List<ProjectDocumentationLink>? ProjectDocumentationLink { get; set; }
	}
}
