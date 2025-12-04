using System.ComponentModel.DataAnnotations.Schema;
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
		public TextBlock? ObjectList { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ObjectList))]
		public Guid? ObjectListId { get; set; }

		[XmlElement("NuclearSafety")]
		public TextBlock? NuclearSafety { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(NuclearSafety))]
		public Guid? NuclearSafetyId { get; set; }

		[XmlElement("OperationalLimits")]
		public TextBlock? OperationalLimits { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(OperationalLimits))]
		public Guid? OperationalLimitsId { get; set; }

		[XmlElement("NuclearPlantControl")]
		public TextBlock? NuclearPlantControl { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(NuclearPlantControl))]
		public Guid? NuclearPlantControlId { get; set; }

		[XmlElement("ReactorPlant")]
		public TextBlock? ReactorPlant { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ReactorPlant))]
		public Guid? ReactorPlantId { get; set; }

		[XmlElement("NuclearSafitySoftware")]
		public TextBlock? NuclearSafitySoftware { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(NuclearSafitySoftware))]
		public Guid? NuclearSafitySoftwareId { get; set; }

		[XmlElement("MonitoringPrograms")]
		public MonitoringPrograms? MonitoringPrograms { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(MonitoringPrograms))]
		public Guid? MonitoringProgramsId { get; set; }
	}
}
