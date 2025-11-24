using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Энергетическая эффективность
	/// </summary>
	public class EnergyEfficiency : BaseEntity
	{
		[XmlElement("EnergyEfficiencyClass")]
		public string EnergyEfficiencyClass { get; set; }

		[XmlElement("EnergyEfficiencyImproving")]
		public TextBlock EnergyEfficiencyImproving { get; set; }
	}
}
