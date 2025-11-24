using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Файл подписи
	/// </summary>
	public class SignFile : BaseEntity
	{
		[XmlElement("FileName")]
		public string? FileName { get; set; }

		[XmlElement("FileFormat")]
		public string? FileFormat { get; set; }

		[XmlElement("FileRelativePath")]
		public string? FileRelativePath { get; set; }

		[XmlElement("FileChecksum")]
		public string? FileChecksum { get; set; }



		[XmlIgnore]
		public File? File { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(File))]
		public Guid? FildeId { get; set; }
	}
}
