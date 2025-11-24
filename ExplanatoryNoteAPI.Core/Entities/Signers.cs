using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Подписанты
	/// </summary>
	public class Signers : BaseEntity
	{
		[XmlElement("ChiefProjectEngineer")]
		public ChiefProjectEngineer? ChiefProjectEngineer { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ChiefProjectEngineer))]
		public Guid? ChiefProjectEngineerId { get; set; }

		[XmlElement("ChiefProjectArchitect")]
		public ChiefProjectEngineer? ChiefProjectArchitect { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ChiefProjectArchitect))]
		public Guid? ChiefProjectArchitectId { get; set; }

		[XmlElement("Signer")]
		public List<WorkPerson>? Signer { get; set; }
	}
}
