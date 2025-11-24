using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Застройщик
	/// </summary>
	public class Developer : BaseEntity
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

		[XmlElement("IP")]
		public IP? IP { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(IP))]
		public Guid? IPId { get; set; }

		[XmlElement("Person")]
		public Person? Person { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Person))]
		public Guid? PersonId { get; set; }
	}
}
