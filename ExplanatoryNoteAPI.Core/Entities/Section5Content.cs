using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;
using static System.Collections.Specialized.BitVector32;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Содержание раздела 5
	/// </summary>
	public class Section5Content : BaseEntity
	{
		[XmlElement("ElectricitySupply")]
		public ProjectDocumentSectionContent? ElectricitySupply { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ElectricitySupply))]
		public Guid? ElectricitySupplyId { get; set; }

		[XmlElement("WaterSupply")]
		public ProjectDocumentSectionContent? WaterSupply { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(WaterSupply))]
		public Guid? WaterSupplyId { get; set; }

		[XmlElement("WaterRemoval")]
		public ProjectDocumentSectionContent? WaterRemoval { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(WaterRemoval))]
		public Guid? WaterRemovalId { get; set; }

		[XmlElement("HeatingVentilation")]
		public ProjectDocumentSectionContent? HeatingVentilation { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(HeatingVentilation))]
		public Guid? HeatingVentilationId { get; set; }

		[XmlElement("Communication")]
		public ProjectDocumentSectionContent? Communication { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Communication))]
		public Guid? CommunicationId { get; set; }

		[XmlElement("GasSupply")]
		public ProjectDocumentSectionContent? GasSupply { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(GasSupply))]
		public Guid? GasSupplyId { get; set; }
	}
}
