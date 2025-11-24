using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Источник финансирования государственного заказчика
	/// </summary>
	public class StateCustomerSource : BaseEntity
	{
		[XmlElement("Owner")]
		public TechnicalCustomer? Owner { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Owner))]
		public Guid? OwnerId { get; set; }

		[XmlElement("SourceRatio")]
		public decimal? SourceRatio { get; set; }

		[XmlIgnore]
		public FinanceSources? FinanceSources { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(FinanceSources))]
		public Guid? FinanceSourcesId { get; set; }
	}
}
