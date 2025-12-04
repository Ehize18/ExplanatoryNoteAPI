using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Модель объекта
	/// </summary>
	public class Model : BaseEntity
	{
		[XmlElement("Description")]
		public string? Description { get; set; }

		[XmlElement("ModelFile")]
		public List<ModelFile>? File { get; set; }
	}

	public class ModelFile : BaseEntity
	{
		[XmlElement("FileName")]
		public string? FileName { get; set; }

		[XmlElement("FileFormat")]
		public string? FileFormat { get; set; }

		[XmlElement("FileRelativePath")]
		public string? FileRelativePath { get; set; }

		[XmlElement("FileChecksum")]
		public string? FileChecksum { get; set; }

		[XmlElement("SignFile")]
		public List<SignFile>? SignFile { get; set; }

		[XmlAttribute("description")]
		public string? Description { get; set; }

		[XmlIgnore]
		public Model? Model { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Model))]
		public Guid? ModelId { get; set; }
	}
}
