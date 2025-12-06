using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Автор (юридическое лицо, иностранное юридическое лицо или ИП)
	/// </summary>
	public class Author : BaseEntity
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

		[XmlElement("SROMembership")]
		public SROMembership? SROMembership { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(SROMembership))]
		public Guid? SROMembershipId { get; set; }



		//[XmlIgnore]
		//public ProjectDocumentationAuthors? ProjectDocumentationAuthors { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ProjectDocumentationAuthors))]
		public Guid? ProjectDocumentationAuthorsId { get; set; }

		//[XmlIgnore]
		//public EngineeringSurveyDocument? EngineeringSurveyDocument { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(EngineeringSurveyDocument))]
		public Guid? EngineeringSurveyDocumentId { get; set; }
	}
}
