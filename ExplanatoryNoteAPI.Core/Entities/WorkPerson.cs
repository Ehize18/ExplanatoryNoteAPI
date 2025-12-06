using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Работник
	/// </summary>
	public class WorkPerson : BaseEntity
	{
		[XmlElement("FamilyName")]
		public string? FamilyName { get; set; }

		[XmlElement("FirstName")]
		public string? FirstName { get; set; }

		[XmlElement("SecondName")]
		public string? SecondName { get; set; }

		[XmlElement("Position")]
		public string? Position { get; set; }

		[XmlAttribute("engineeringRegistry")]
		public string? EngineeringRegistry { get; set; }

		[XmlAttribute("constructionRegistry")]
		public string? ConstructionRegistry { get; set; }

		//[XmlIgnore]
		//public Signers? Signers { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Signers))]
		public Guid? SignersId { get; set; }
	}
}
