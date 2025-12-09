using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Classificators;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Бюджетный источник финансирования
	/// </summary>
	public class BudgetSource : BaseEntity
	{
		[XmlElement("BudgetLevel")]
		[NotMapped]
		public string? BudgetLevelCode
		{
			get
			{
				return this.BudgetLevel?.Code;
			}
			set { }
		}

		[XmlIgnore]
		public BudgetLevel? BudgetLevel { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(BudgetLevel))]
		public Guid? BudgetLevelId { get; set; }

		[XmlElement("SourceRatio")]
		public decimal? SourceRatio { get; set; }

		//[XmlIgnore]
		//public FinanceSources? FinanceSources { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(FinanceSources))]
		public Guid? FinanceSourcesId { get; set; }
	}
}
