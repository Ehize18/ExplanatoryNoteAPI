using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Classificators;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Информация о земельном участке
	/// </summary>
	public class LandAreaInfo : BaseEntity
	{
		[XmlElement("CadastralNumber")]
		public string? CadastralNumber { get; set; }

		[XmlElement("LandCategory")]
		[NotMapped]
		public string? LandCategoryCode => this.LandCategory?.Code;

		[XmlIgnore]
		public LandCategory? LandCategory { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(LandCategory))]
		public Guid? LandCategoryId { get; set; }

		[XmlElement("UsingNote")]
		public string? UsingNote { get; set; }

		[XmlIgnore]
		public LandInfo? LandInfo { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(LandInfo))]
		public Guid? LandInfoId { get; set; }
	}
}
