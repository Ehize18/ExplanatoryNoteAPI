using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Файл
	/// </summary>
	public class File : BaseEntity
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



		//[XmlIgnore]
		//public Document? Document { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Document))]
		public Guid? DocumentId { get; set; }

		//[XmlIgnore]
		//public EngineeringSurveyDocument? EngineeringSurveyDocument { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(EngineeringSurveyDocument))]
		public Guid? EngineeringSurveyDocumentId { get; set; }

		//[XmlIgnore]
		//public ProjectDocument? ProjectDocument { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ProjectDocument))]
		public Guid? ProjectDocumentId { get; set; }

		//[XmlIgnore]
		//public Data? Data { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Data))]
		public Guid? DataId { get; set; }

		[XmlIgnore]
		public int Type { get; set; }
	}
}
