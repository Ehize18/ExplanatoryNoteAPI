using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Части объекта
	/// </summary>
	public class ObjectParts : BaseEntity
	{
		[XmlElement("ComplexPart")]
		public List<ComplexPart> ComplexPart { get; set; }

		[XmlElement("OKS")]
		public List<OKS> OKS { get; set; }

		//77
	}
}
