using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Объект капитального строительства (в составе сложного объекта)
	/// </summary>
	public class OKS : BaseEntity
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

		[XmlElement("EnergyEfficiency")]
		public EnergyEfficiency EnergyEfficiency { get; set; }

		[XmlElement("DangerousIndustrialObject")]
		public string DangerousIndustrialObject { get; set; }

		[XmlElement("FireDangerCategory")]
		public string FireDangerCategory { get; set; }

		[XmlElement("PeoplePermanentStay")]
		public TextBlock PeoplePermanentStay { get; set; }

		[XmlElement("ResponsibilityLevel")]
		public string ResponsibilityLevel { get; set; }

		[XmlElement("Model")]
		public Model Model { get; set; }
	}
}
