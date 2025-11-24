using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Иностранное юридическое лицо
	/// </summary>
	public class ForeignOrganization : BaseEntity
	{
		[XmlElement("OrgFullName")]
		public string? OrgFullName { get; set; }

		[XmlElement("OrgINN")]
		public string? OrgINN { get; set; }

		[XmlElement("OrgKPP")]
		public string? OrgKPP { get; set; }

		[XmlElement("Address")]
		public Address? Address { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Address))]
		public Guid? AddressId { get; set; }

		[XmlElement("Email")]
		public string? Email { get; set; }
	}
}
