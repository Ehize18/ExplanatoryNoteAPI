using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Особенности газовых сетей
	/// </summary>
	public class GasNetworksFeatures : BaseEntity
	{
		[XmlElement("StrengthCalculation")]
		public TextBlock StrengthCalculation { get; set; }

		[XmlElement("EnvironmentalProtection")]
		public TextBlock EnvironmentalProtection { get; set; }

		[XmlElement("FireSafety")]
		public TextBlock FireSafety { get; set; }

		[XmlElement("OperationalSafety")]
		public TextBlock OperationalSafety { get; set; }

		[XmlElement("RepairFrequency")]
		public TextBlock RepairFrequency { get; set; }
	}
}
