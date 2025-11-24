using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Особенности атомных станций
	/// </summary>
	public class NuclearPlantFeatures : BaseEntity
	{
		[XmlElement("ObjectList")]
		public TextBlock ObjectList { get; set; }

		[XmlElement("NuclearSafety")]
		public TextBlock NuclearSafety { get; set; }

		[XmlElement("OperationalLimits")]
		public TextBlock OperationalLimits { get; set; }

		[XmlElement("NuclearPlantControl")]
		public TextBlock NuclearPlantControl { get; set; }

		[XmlElement("ReactorPlant")]
		public TextBlock ReactorPlant { get; set; }

		[XmlElement("NuclearSafitySoftware")]
		public TextBlock NuclearSafitySoftware { get; set; }
	}
}
