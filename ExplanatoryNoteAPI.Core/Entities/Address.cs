using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Classificators;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Адрес
	/// </summary>
	public class Address : BaseEntity
	{
		[XmlElement("Country")]
		public string? Country { get; set; }

		[XmlElement("Region")]
		[NotMapped]
		public string? RegionCode => this.Region?.Code;

		[XmlIgnore]
		public RegionsRF? Region { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Region))]
		public Guid? RegionId { get; set; }

		[XmlElement("District")]
		public string? District { get; set; }

		[XmlElement("City")]
		public string? City { get; set; }

		[XmlElement("Settlement")]
		public string? Settlement { get; set; }

		[XmlElement("Street")]
		public string? Street { get; set; }

		[XmlElement("Building")]
		public string? Building { get; set; }

		[XmlElement("Room")]
		public string? Room { get; set; }

		[XmlElement("Note")]
		public string? Note { get; set; }



		//[XmlIgnore]
		//public ComplexPart? ComplexPart { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ComplexPart))]
		public Guid? ComplexPartId { get; set; }

		//[XmlIgnore]
		//public OKS? OKS { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(OKS))]
		public Guid? OKSId { get; set; }
	}
}
