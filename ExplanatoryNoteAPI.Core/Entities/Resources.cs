using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Ресурсы
	/// </summary>
	public class Resources : BaseEntity
	{
		[XmlElement("Note")]
		public TextBlock Note { get; set; }

		[XmlElement("Resource")]
		public List<Resource> Resource { get; set; }
	}
}
