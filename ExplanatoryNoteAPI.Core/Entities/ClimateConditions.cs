using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Климатические условия
	/// </summary>
	public class ClimateConditions : BaseEntity
	{
		[XmlElement("ClimateNote")]
		public TextBlock ClimateNote { get; set; }

		[XmlElement("ClimateDistrict")]
		public List<string> ClimateDistrict { get; set; }

		[XmlElement("GeologicalConditions")]
		public List<string> GeologicalConditions { get; set; }

		[XmlElement("WindDistrict")]
		public List<string> WindDistrict { get; set; }

		[XmlElement("SnowDistrict")]
		public List<string> SnowDistrict { get; set; }

		[XmlElement("SeismicActivity")]
		public List<string> SeismicActivity { get; set; }
	}
}
