using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;
using static System.Collections.Specialized.BitVector32;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Раздел 5 - Сведения об инженерном оборудовании
	/// </summary>
	public class Section5 : BaseEntity
	{
		[XmlElement("NotDeveloped")]
		public string? NotDeveloped { get; set; }

		[XmlElement("SectionContent")]
		public Section5Content? SectionContent { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(SectionContent))]
		public Guid? SectionContentId { get; set; }
	}
}
