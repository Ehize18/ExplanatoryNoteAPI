using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Содержание раздела прочей документации
	/// </summary>
	public class SectionOtherContent : BaseEntity
	{
		[XmlElement("IndustrialSafetyDeclaration")]
		public ProjectDocumentNotNecessarySectionContent? IndustrialSafetyDeclaration { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(IndustrialSafetyDeclaration))]
		public Guid? IndustrialSafetyDeclarationId { get; set; }

		[XmlElement("HydraulicStructuresSafetyDeclaration")]
		public ProjectDocumentNotNecessarySectionContent? HydraulicStructuresSafetyDeclaration { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(HydraulicStructuresSafetyDeclaration))]
		public Guid? HydraulicStructuresSafetyDeclarationId { get; set; }

		[XmlElement("CivilDefense")]
		public ProjectDocumentNotNecessarySectionContent? CivilDefense { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(CivilDefense))]
		public Guid? CivilDefenseId { get; set; }

		[XmlElement("CounteringTerrorism")]
		public ProjectDocumentNotNecessarySectionContent? CounteringTerrorism { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(CounteringTerrorism))]
		public Guid? CounteringTerrorismId { get; set; }

		[XmlElement("RadiationNuclearSafety")]
		public ProjectDocumentNotNecessarySectionContent? RadiationNuclearSafety { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(RadiationNuclearSafety))]
		public Guid? RadiationNuclearSafetyId { get; set; }

		[XmlElement("SanitarySafety")]
		public ProjectDocumentNotNecessarySectionContent? SanitarySafety { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(SanitarySafety))]
		public Guid? SanitarySafetyId { get; set; }

		[XmlElement("CulturalHeritageSites")]
		public ProjectDocumentNotNecessarySectionContent? CulturalHeritageSites { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(CulturalHeritageSites))]
		public Guid? CulturalHeritageSitesId { get; set; }

		[XmlElement("LandsReclamation")]
		public ProjectDocumentNotNecessarySectionContent? LandsReclamation { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(LandsReclamation))]
		public Guid? LandsReclamationId { get; set; }

		[XmlElement("BiologicalResourcesImpact")]
		public ProjectDocumentNotNecessarySectionContent? BiologicalResourcesImpact { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(BiologicalResourcesImpact))]
		public Guid? BiologicalResourcesImpactId { get; set; }

		[XmlElement("OtherDocuments")]
		public ProjectDocumentNotNecessarySectionContent? OtherDocuments { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(OtherDocuments))]
		public Guid? OtherDocumentsId { get; set; }
	}
}
