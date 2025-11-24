using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Часть сложного объекта
	/// </summary>
	public class ComplexPart : BaseEntity
	{
		[XmlAttribute("ObjectID")]
		public string ObjectID { get; set; }

		[XmlElement("Name")]
		public string Name { get; set; }

		[XmlElement("Address")]
		public List<Address> Address { get; set; }

		[XmlElement("FunctionsClass")]
		public string FunctionsClass { get; set; }

		[XmlElement("FunctionsFeatures")]
		public TextBlock FunctionsFeatures { get; set; }

		[XmlElement("PowerIndicator")]
		public List<TEI> PowerIndicator { get; set; }

		[XmlElement("TEI")]
		public List<TEI> TEI { get; set; }

		[XmlElement("DangerousIndustrialObject")]
		public string DangerousIndustrialObject { get; set; }

		[XmlElement("ObjectParts")]
		public ObjectParts ObjectParts { get; set; }

		[XmlElement("Model")]
		public Model Model { get; set; }
	}
}
