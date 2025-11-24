using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Источники финансирования
	/// </summary>
	public class FinanceSources : BaseEntity
	{
		[XmlElement("BudgetSource")]
		public List<BudgetSource>? BudgetSource { get; set; }

		[XmlElement("StateCustomerSource")]
		public List<StateCustomerSource>? StateCustomerSource { get; set; }

		[XmlElement("PrivateSource")]
		public List<PrivateSource>? PrivateSource { get; set; }

		[XmlElement("FinanceComment")]
		public string? FinanceComment { get; set; }
	}
}
