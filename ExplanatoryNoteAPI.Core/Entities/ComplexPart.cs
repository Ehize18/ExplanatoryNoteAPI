using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Часть сложного объекта
	/// </summary>
	public class ComplexPart : BaseEntity
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
		public Guid? FunctionFeaturesId { get; set; }

		[XmlIgnore]
		public List<TEI>? TEIAll { get; set; }

		[XmlElement("PowerIndicator")]
		[NotMapped]
		public List<TEI>? PowerIndicator => this.TEIAll?.Where(x => x.Type == 1).ToList();

		[XmlElement("TEI")]
		[NotMapped]
		public List<TEI>? TEI => this.TEIAll?.Where(x => x.Type == 0).ToList();

		[XmlElement("DangerousIndustrialObject")]
		public string? DangerousIndustrialObject { get; set; }

		[XmlElement("ObjectParts")]
		public ObjectParts? ObjectParts { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ObjectParts))]
		public Guid? ObjectPartsId { get; set; }

		[XmlElement("Model")]
		public Model? Model { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Model))]
		public Guid? ModelId { get; set; }
	}
}
