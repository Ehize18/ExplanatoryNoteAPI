using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Документы
	/// </summary>
	public class Documents : BaseEntity
	{
		[XmlElement("Document")]
		public List<Document>? Document { get; set; }
	}
}
