using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Classificators;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Линейный объект
	/// </summary>
	public class LinearObject : BaseEntity
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

		[XmlElement("FinishAddress")]
		public Address? FinishAddress { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(FinishAddress))]
		public Guid? FinishAddressId { get; set; }

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

		[XmlElement("DangerousIndustrialObject")]
		[NotMapped]
		public string? DangerousIndustrialObject => this.DangerIndustrialClass?.Code;

		[XmlIgnore]
		public DangerIndustrialClass? DangerIndustrialClass { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(DangerIndustrialClass))]
		public Guid? DangerIndustrialClassId { get; set; }

		[XmlElement("LinearObjectCategory")]
		public TextBlock? LinearObjectCategory { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(LinearObjectCategory))]
		public Guid? LinearObjectCategoryId { get; set; }

		[XmlElement("LinearObjectClass")]
		public TextBlock? LinearObjectClass { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(LinearObjectClass))]
		public Guid? LinearObjectClassId { get; set; }

		[XmlElement("LinearObjectNote")]
		public TextBlock? LinearObjectNote { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(LinearObjectNote))]
		public Guid? LinearObjectNoteId { get; set; }

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

		[XmlElement("Routes")]
		public Routes? Routes { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Routes))]
		public Guid? RoutesId { get; set; }

		[XmlElement("Resources")]
		public Resources? Resources { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Resources))]
		public Guid? ResourcesId { get; set; }

		[XmlElement("ResourceUseInfo")]
		public TextBlock? ResourceUseInfo { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ResourceUseInfo))]
		public Guid? ResourceUseInfoId { get; set; }

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

		[XmlElement("IndustrialSafetyLinks")]
		public ProjectDocumentationLinks? IndustrialSafetyLinks { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(IndustrialSafetyLinks))]
		public Guid? UndustrialSafetyLinksId { get; set; }

		[XmlElement("LandReclamationLink")]
		public TextBlock? LandReclamationLink { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(LandReclamationLink))]
		public Guid? LandReclamationLinkId { get; set; }

		[XmlElement("GasNetworksFeatures")]
		public GasNetworksFeatures? GasNetworksFeatures { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(GasNetworksFeatures))]
		public Guid? GasNetworksFeaturesId { get; set; }

		[XmlElement("EngineeringTerritoryProtection")]
		public TextBlock? EngineeringTerritoryProtection { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(EngineeringTerritoryProtection))]
		public Guid? EngineeringTerritoryProtectionId { get; set; }

		[XmlElement("ProjectDocumentation")]
		public LinearProjectDocumentContent? ProjectDocumentation { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ProjectDocumentation))]
		public Guid? ProjectDocumentationId { get; set; }

		[XmlElement("GasProjectDocumentation")]
		public GasLinearProjectDocumentContent GasProjectDocumentation { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(GasProjectDocumentation))]
		public Guid? GasProjectDocumentationId { get; set; }

		[XmlElement("Model")]
		public Model? Model { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Model))]
		public Guid? ModelId { get; set; }
	}
}
