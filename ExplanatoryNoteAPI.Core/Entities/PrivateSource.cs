using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Частный источник финансирования
	/// </summary>
	public class PrivateSource : BaseEntity
	{
		[XmlElement("SourceRatio")]
		public decimal? SourceRatio { get; set; }

		[XmlIgnore]
		public FinanceSources? FinanceSources { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(FinanceSources))]
		public Guid? FinanceSourcesId { get; set; }
	}
}
