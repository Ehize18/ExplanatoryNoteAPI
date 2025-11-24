using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Classificators;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Технико-экономический показатель
	/// </summary>
	public class TEI : BaseEntity
	{
		[XmlElement("Name")]
		public string? Name { get; set; }

		[XmlElement("Measure")]
		[NotMapped]
		public string? Measure => this.OKEI?.Code;

		[XmlIgnore]
		public OKEI? OKEI { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(OKEI))]
		public Guid? OKEIId { get; set; }

		[XmlElement("Value")]
		public string? Value { get; set; }

		[XmlElement("OldValue")]
		public string? OldValue { get; set; }

		[XmlIgnore]
		public int Type { get; set; }



		[XmlIgnore]
		[ForeignKey(nameof(NonIndustrialObject))]
		public Guid? NonIndustialObjectId { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(IndustrialObject))]
		public Guid? IndustialObjectId { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(LinearObject))]
		public Guid? LinearObjectId { get; set; }
	}
}
