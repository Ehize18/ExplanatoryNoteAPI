using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Classificators;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Энергетическая эффективность
	/// </summary>
	public class EnergyEfficiency : BaseEntity
	{
		[XmlElement("EnergyEfficiencyClass")]
		[NotMapped]
		public string? EnergyEfficiencyClassCode
		{
			get
			{
				return this.EnergyEfficiencyClass?.Code;
			}
			set { }
		}

		[XmlIgnore]
		public EfficiencyClass? EnergyEfficiencyClass { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(EnergyEfficiencyClass))]
		public Guid? EnergyEfficiencyClassId { get; set; }

		[XmlElement("EnergyEfficiencyImproving")]
		public TextBlock? EnergyEfficiencyImproving { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(EnergyEfficiencyImproving))]
		public Guid? EnergyEfficiencyImprovingId { get; set; }
	}
}
