using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Участники разработки проектной документации
	/// </summary>
	public class ProjectDocParticipants : BaseEntity
	{
		[XmlElement("ProjectDocParticipant")]
		public List<ProjectDocParticipant>? ProjectDocParticipant { get; set; }
	}
}
