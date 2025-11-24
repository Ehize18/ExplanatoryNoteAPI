using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Данные
	/// </summary>
	public class Data : BaseEntity
	{
		[XmlElement("DataDescription")]
		public string? DataDescription { get; set; }

		[XmlElement("File")]
		public List<File>? File { get; set; }

		[XmlIgnore]
		public AdditionalData? AdditionalData { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(AdditionalData))]
		public Guid? AdditionalDataId { get; set; }
	}
}
