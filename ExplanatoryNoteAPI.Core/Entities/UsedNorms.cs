using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Используемые нормы
	/// </summary>
	public class UsedNorms : BaseEntity
	{
		[XmlElement("UsedNorm")]
		[NotMapped]
		public List<string?>? UsedNormStr => this.UsedNorm?.Select(x => x.Norm).ToList();

		[XmlIgnore]
		public List<UsedNorm>? UsedNorm { get; set; }
	}

	public class UsedNorm : BaseEntity
	{
		public UsedNorms? UsedNorms { get; set; }

		[ForeignKey(nameof(UsedNorms))]
		public Guid? UsedNormsId { get; set; }

		public string? Norm { get; set; }
	}
}
