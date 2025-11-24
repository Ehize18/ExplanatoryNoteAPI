using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Корневой элемент - Пояснительная записка
	/// </summary>
	[XmlRoot("ExplanatoryNote")]
	public class ExplanatoryNote : BaseEntity
	{
		[XmlAttribute("SchemaVersion")]
		public string SchemaVersion { get; set; } = "01.05";

		[XmlAttribute("SchemaLink")]
		public string? SchemaLink { get; set; }

		[XmlAttribute("id")]
		[NotMapped]
		public string XmlId => this.Id.ToString();

		[XmlAttribute("AccessRestriction")]
		public string? AccessRestriction { get; set; }

		[XmlElement("ExplanatoryNoteNumber")]
		public string? ExplanatoryNoteNumber { get; set; }

		[XmlElement("ExplanatoryNoteYear")]
		public int ExplanatoryNoteYear { get; set; }

		[XmlElement("ExplanatoryNoteModifications")]
		public ExplanatoryNoteModifications? ExplanatoryNoteModifications { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ExplanatoryNoteModifications))]
		public Guid? ExplanatoryNoteModificationsId { get; set; }

		[XmlElement("IssueAuthor")]
		public Author? IssueAuthor { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(IssueAuthor))]
		public Guid? IssueAuthorId { get; set; }

		[XmlElement("ProjectDocumentationAuthors")]
		public ProjectDocumentationAuthors? ProjectDocumentationAuthors { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ProjectDocumentationAuthors))]
		public Guid? ProjectDocumentationAuthorsId { get; set; }

		[XmlElement("Signers")]
		public Signers? Signers { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Signers))]
		public Guid? SignersId { get; set; }

		[XmlElement("Developer")]
		public List<Developer>? Developer { get; set; }

		[XmlElement("TechnicalCustomer")]
		public List<TechnicalCustomer>? TechnicalCustomer { get; set; }

		[XmlElement("UsedAbbreviations")]
		public TextBlock? UsedAbbreviations { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(UsedAbbreviations))]
		public Guid? UsedAbbreviationsId { get; set; }

		[XmlElement("UsedNorms")]
		public UsedNorms? UsedNorms { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(UsedNorms))]
		public Guid? UsedNormsId { get; set; }

		[XmlElement("ProjectDecisionDocuments")]
		public Documents? ProjectDecisionDocuments { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ProjectDecisionDocuments))]
		public Guid? ProjectDecisionDocumentsId { get; set; }

		[XmlElement("ProjectInitialDocuments")]
		public Documents? ProjectInitialDocuments { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ProjectInitialDocuments))]
		public Guid? ProjectInitialDocumentsId { get; set; }

		[XmlElement("EngineeringSurveyDocuments")]
		public EngineeringSurveyDocuments? EngineeringSurveyDocuments { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(EngineeringSurveyDocuments))]
		public Guid? EngineeringSurveyDocumentsId { get; set; }

		[XmlElement("AdditionalData")]
		public AdditionalData? AdditionalData { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(AdditionalData))]
		public Guid? AdditionalDataId { get; set; }

		[XmlElement("FinanceSources")]
		public FinanceSources? FinanceSources { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(FinanceSources))]
		public Guid? FinanceSourcesId { get; set; }

		[XmlElement("NonIndustrialObject")]
		public NonIndustrialObject? NonIndustrialObject { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(NonIndustrialObject))]
		public Guid? NonIndustrialObjectId { get; set; }

		[XmlElement("IndustrialObject")]
		public IndustrialObject? IndustrialObject { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(IndustrialObject))]
		public Guid? IndustrialObjectId { get; set; }

		[XmlElement("LinearObject")]
		public LinearObject? LinearObject { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(LinearObject))]
		public Guid? LinearObjectId { get; set; }

		[XmlElement("DesignerNote")]
		public List<TextBlock>? DesignerNote { get; set; }

		[XmlElement("DesignerAssurance")]
		public TextBlock? DesignerAssurance { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(DesignerAssurance))]
		public Guid? DesignerAssuranceId { get; set; }
	}
}
