using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Маршрут
	/// </summary>
	public class Route : BaseEntity
	{
		[XmlElement("Name")]
		public string Name { get; set; }

		[XmlElement("Note")]
		public TextBlock Note { get; set; }
	}
}
