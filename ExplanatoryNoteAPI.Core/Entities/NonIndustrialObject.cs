using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Classificators;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Объект непроизводственного назначения
	/// </summary>
	public class NonIndustrialObject : BaseEntity
	{
		[XmlAttribute("ObjectID")]
		public string? ObjectID { get; set; }

		[XmlAttribute("Placement")]
		[NotMapped]
		public string? PlacementCode => this.Placement?.Code;

		[XmlIgnore]
		public Placement? Placement { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Placement))]
		public Guid? PlacementId { get; set; }

		[XmlAttribute("DangerousAndComplex")]
		[NotMapped]
		public string? DangerousAndComplexCode => this.DangerousAndComplex?.Code;

		[XmlIgnore]
		public DangerousAndComplex? DangerousAndComplex { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(DangerousAndComplex))]
		public Guid? DangerousAndComplexId { get; set; }

		[XmlAttribute("Unique")]
		[NotMapped]
		public string? UniqueCode => this.Unique?.Code;

		[XmlIgnore]
		public Unique? Unique { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Unique))]
		public Guid? UniqueId { get; set; }

		[XmlElement("Name")]
		public string? Name { get; set; }

		[XmlElement("ConstructionType")]
		public string? ConstructionTypeCode { get; set; }

		[XmlIgnore]
		public ConstractionType? ConstractionType { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ConstractionType))]
		public Guid? ConstractionTypeId { get; set; }

		[XmlElement("ConstructionDuration")]
		public decimal? ConstructionDuration { get; set; }

		[XmlElement("ConstructionDates")]
		public ConstructionDates? ConstructionDates { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ConstructionDates))]
		public Guid? ConstractionDatesId { get; set; }

		[XmlElement("Address")]
		public Address? Address { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Address))]
		public Guid? AddressId { get; set; }

		[XmlElement("Functions")]
		public Functions? Functions { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Functions))]
		public Guid? FunctionsId { get; set; }

		[XmlElement("FunctionsFeatures")]
		public TextBlock? FunctionsFeatures { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(FunctionsFeatures))]
		public Guid? FunctionsFeaturesId { get; set; }

		[XmlIgnore]
		public List<TEI>? TEIAll { get; set; }

		[XmlElement("PowerIndicator")]
		[NotMapped]
		public List<TEI>? PowerIndicator => this.TEIAll?.Where(x => x.Type == 1).ToList();

		[XmlElement("TEI")]
		[NotMapped]
		public List<TEI>? TEI => this.TEIAll?.Where(x => x.Type == 0).ToList();

		[XmlElement("EnergyEfficiency")]
		public EnergyEfficiency? EnergyEfficiency { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(EnergyEfficiency))]
		public Guid? EnergyEfficiencyId { get; set; }

		[XmlElement("FireDangerCategory")]
		[NotMapped]
		public string? FireDangerCategoryCode => this.FireDangerCategory?.Code;

		[XmlIgnore]
		public FireDangerCategory? FireDangerCategory { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(FireDangerCategory))]
		public Guid? FireDangerCategoryId { get; set; }

		[XmlElement("PeoplePermanentStay")]
		public TextBlock? PeoplePermanentStay { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(PeoplePermanentStay))]
		public Guid? PeoplePermanentStayId { get; set; }

		[XmlElement("ResponsibilityLevel")]
		[NotMapped]
		public string? ResponsibilityLevelCode => this.ResponsibilityLevel?.Code;

		[XmlIgnore]
		public ResponsibilityLevel? ResponsibilityLevel { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ResponsibilityLevel))]
		public Guid? ResponsibilityLevelId { get; set; }

		[XmlElement("ObjectParts")]
		public ObjectParts? ObjectParts { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ObjectParts))]
		public Guid? ObjectPartsId { get; set; }

		[XmlElement("ClimateConditions")]
		public ClimateConditions? ClimateConditions { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ClimateConditions))]
		public Guid? ClimateConditionsId { get; set; }

		[XmlElement("Resources")]
		public Resources? Resources { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Resources))]
		public Guid? ResourcesId { get; set; }

		[XmlElement("RenewableSourceInfo")]
		public TextBlock? RenewableSourceInfo { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(RenewableSourceInfo))]
		public Guid? RenewableSourceInfoId { get; set; }

		[XmlElement("LandCategory")]
		[NotMapped]
		public List<string?>? LandCategoryCodes => this.LandCategoryMappings?.Select(x => x.LandCategory?.Code).ToList();

		[XmlIgnore]
		public List<LandCategoryMappings>? LandCategoryMappings { get; set; }

		[XmlElement("LandInfo")]
		public LandInfo? LandInfo { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(LandInfo))]
		public Guid? LandInfoId { get; set; }

		[XmlElement("LandFunds")]
		public TextBlock? LandFunds { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(LandFunds))]
		public Guid? LandFundsId { get; set; }

		[XmlElement("PatentsUsed")]
		public TextBlock? PatentsUsed { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(PatentsUsed))]
		public Guid? PatentsUsedId { get; set; }

		[XmlElement("SpecialRequirements")]
		public TextBlock? SpecialRequirements { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(SpecialRequirements))]
		public Guid? SpecialRequirementsId { get; set; }

		[XmlElement("StaffNote")]
		public TextBlock? StaffNote { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(StaffNote))]
		public Guid? StaffNoteId { get; set; }

		[XmlElement("SoftwareUsed")]
		public SoftwareUsed? SoftwareUsed { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(SoftwareUsed))]
		public Guid? SoftwareUsedId { get; set; }

		[XmlElement("StagesInfo")]
		public StagesInfo? StagesInfo { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(StagesInfo))]
		public Guid? StagesInfoId { get; set; }

		[XmlElement("DestroyFunds")]
		public TextBlock? DestroyFunds { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(DestroyFunds))]
		public Guid? DestroyFundsId { get; set; }

		[XmlElement("EnergyEfficiencyLinks")]
		public ProjectDocumentationLinks? EnergyEfficiencyLinks { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(EnergyEfficiencyLinks))]
		public Guid? EnergyEfficiencyLinksId { get; set; }

		[XmlElement("LandReclamationLink")]
		public TextBlock? LandReclamationLink { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(LandReclamationLink))]
		public Guid? LandReclamationLinkId { get; set; }

		[XmlElement("ProjectDocumentation")]
		public NonLinearProjectDocumentContent? ProjectDocumentation { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ProjectDocumentation))]
		public Guid? ProjectDocumentationId { get; set; }

		[XmlElement("Model")]
		public Model? Model { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Model))]
		public Guid? ModelId { get; set; }
	}
}
