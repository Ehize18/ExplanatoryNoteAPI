using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Classificators;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Ресурс
	/// </summary>
	public class Resource : BaseEntity
	{
		[XmlElement("Name")]
		public string? Name { get; set; }

		[XmlElement("Measure")]
		[NotMapped]
		public string? MeasureCode => this.Measure?.Code;

		[XmlIgnore]
		public OKEI? Measure { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Measure))]
		public Guid? MeasureId { get; set; }

		[XmlElement("Volume")]
		public string? Volume { get; set; }

		[XmlIgnore]
		public Resources? Resources { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Resources))]
		public Guid? ResourcesId { get; set; }
	}
}
