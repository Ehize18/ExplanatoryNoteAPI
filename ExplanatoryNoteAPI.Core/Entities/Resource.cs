using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Ресурс
	/// </summary>
	public class Resource : BaseEntity
	{
		[XmlElement("Name")]
		public string Name { get; set; }

		[XmlElement("Measure")]
		public string Measure { get; set; }

		[XmlElement("Volume")]
		public string Volume { get; set; }
	}
}
