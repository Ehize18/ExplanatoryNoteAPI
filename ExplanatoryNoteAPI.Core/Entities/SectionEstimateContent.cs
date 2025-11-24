using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Содержание раздела сметы
	/// </summary>
	public class SectionEstimateContent : BaseEntity
	{
		[XmlElement("EstimateExplanatoryNote")]
		public ProjectDocumentSectionContent? EstimateExplanatoryNote { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(EstimateExplanatoryNote))]
		public Guid? EstimateExplanatoryNoteId { get; set; }

		[XmlElement("CostSummary")]
		public ProjectDocumentSectionContent? CostSummary { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(CostSummary))]
		public Guid? CostSummaryId { get; set; }

		[XmlElement("SummaryEstimate")]
		public ProjectDocumentSectionContent? SummaryEstimate { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(SummaryEstimate))]
		public Guid? SummaryEstimateId { get; set; }

		[XmlElement("ObjectEstimates")]
		public ProjectDocumentSectionContent? ObjectEstimates { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ObjectEstimates))]
		public Guid? ObjectEstimatesId { get; set; }

		[XmlElement("LocalEstimates")]
		public ProjectDocumentSectionContent? LocalEstimates { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(LocalEstimates))]
		public Guid? LocalEstimatesId { get; set; }

		[XmlElement("CostsEstimates")]
		public ProjectDocumentSectionContent? CostsEstimates { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(CostsEstimates))]
		public Guid? CostsEstimatesId { get; set; }
	}
}
