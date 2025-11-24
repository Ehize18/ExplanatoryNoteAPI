using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Использованное ПО
	/// </summary>
	public class SoftwareUsed : BaseEntity
	{
		[XmlElement("SoftwareNote")]
		public TextBlock? SoftwareNote { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(SoftwareNote))]
		public Guid? SoftwareNoteId { get; set; }

		[XmlElement("Software")]
		public List<Software>? Software { get; set; }
	}
}
