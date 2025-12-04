using System.ComponentModel.DataAnnotations.Schema;
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
		public TextBlock? StrengthCalculation { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(StrengthCalculation))]
		public Guid? StrengthCalculationId { get; set; }

		[XmlElement("EnvironmentalProtection")]
		public TextBlock? EnvironmentalProtection { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(EnvironmentalProtection))]
		public Guid? EnvironmentalProtectionId { get; set; }

		[XmlElement("FireSafety")]
		public TextBlock? FireSafety { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(FireSafety))]
		public Guid? FireSafetyId { get; set; }

		[XmlElement("OperationalSafety")]
		public TextBlock? OperationalSafety { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(OperationalSafety))]
		public Guid? OperationalSafetyId { get; set; }

		[XmlElement("RepairFrequency")]
		public TextBlock? RepairFrequency { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(RepairFrequency))]
		public Guid? RepairFrequencyId { get; set; }
	}
}
