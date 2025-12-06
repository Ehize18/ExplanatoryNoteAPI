using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Classificators;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Объект капитального строительства (в составе сложного объекта)
	/// </summary>
	public class OKS : BaseEntity
	{
		[XmlAttribute("ObjectID")]
		public string? ObjectID { get; set; }

		[XmlElement("Name")]
		public string? Name { get; set; }

		[XmlElement("Address")]
		public List<Address>? Address { get; set; }

		[XmlElement("FunctionsClass")]
		public string? FunctionsClass { get; set; }

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

		[XmlElement("DangerousIndustrialObject")]
		[NotMapped]
		public string? DangerousIndustrialObjectCode => this.DangerousIndustrialObject?.Code;

		[XmlIgnore]
		public DangerIndustrialClass? DangerousIndustrialObject { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(DangerousIndustrialObject))]
		public Guid DangerousIndustrialObjectId { get; set; }

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

		[XmlElement("Model")]
		public Model? Model { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Model))]
		public Guid? ModelId { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ObjectParts))]
		public Guid? ObjectPartsId { get; set; }
	}
}
