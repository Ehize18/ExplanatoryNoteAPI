using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Сведения о программах мониторинга
	/// </summary>
	public class MonitoringPrograms : BaseEntity
	{
		[XmlElement("GeotechnicalMonitoring")]
		public TextBlock? GeotechnicalMonitoring { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(GeotechnicalMonitoring))]
		public Guid? GeotechnicalMonitoringId { get; set; }

		[XmlElement("HydrogeologicalMonitoring")]
		public TextBlock? HydrogeologicalMonitoring { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(HydrogeologicalMonitoring))]
		public Guid? HydrogeologicalMonitoringId { get; set; }

		[XmlElement("SeismologicalMonitoring")]
		public TextBlock? SeismologicalMonitoring { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(SeismologicalMonitoring))]
		public Guid? SeismologicalMonitoringId { get; set; }

		[XmlElement("MeteorologicalMonitoring")]
		public TextBlock? MeteorologicalMonitoring { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(MeteorologicalMonitoring))]
		public Guid? MeteorologicalMonitoringId { get; set; }

		[XmlElement("AerologicalMonitoring")]
		public TextBlock? AerologicalMonitoring { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(AerologicalMonitoring))]
		public Guid? AerologicalMonitoringId { get; set; }

		[XmlElement("HydrologicalMonitoring")]
		public TextBlock? HydrologicalMonitoring { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(HydrologicalMonitoring))]
		public Guid? HydrologicalMonitoringId { get; set; }

		[XmlElement("GeodynamicalMonitoring")]
		public TextBlock? GeodynamicalMonitoring { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(GeodynamicalMonitoring))]
		public Guid? GeodynamicalMonitoringId { get; set; }

		[XmlElement("TechnogenicMonitoring")]
		public TextBlock? TechnogenicMonitoring { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(TechnogenicMonitoring))]
		public Guid? TechnogenicMonitoringId { get; set; }
	}
}
