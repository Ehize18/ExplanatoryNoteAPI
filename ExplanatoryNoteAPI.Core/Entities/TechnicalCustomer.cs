using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Технический заказчик
	/// </summary>
	public class TechnicalCustomer : BaseEntity
	{
		[XmlElement("Organization")]
		public Organization? Organization { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Organization))]
		public Guid? OrganizationId { get; set; }

		[XmlElement("ForeignOrganization")]
		public ForeignOrganization? ForeignOrganization { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ForeignOrganization))]
		public Guid? ForeignOrganizationId { get; set; }

		[XmlElement("SROMembership")]
		public SROMembership? SROMembership { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(SROMembership))]
		public Guid? SROMembershipId { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ExplanatoryNote))]
		public Guid? ExplanatoryNoteId { get; set; }
	}
}
