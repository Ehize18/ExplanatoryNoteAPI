using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Classificators;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Документ инженерных изысканий
	/// </summary>
	public class EngineeringSurveyDocument : BaseEntity
	{
		[XmlElement("DocType")]
		[NotMapped]
		public string? DocTypeCode
		{
			get
			{
				return this.DocumentType?.Code;
			}
			set { }
		}

		[XmlIgnore]
		public DocumentType? DocumentType { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(DocumentType))]
		public Guid? DocumentTypeId { get; set; }

		[XmlElement("DocName")]
		public string? DocName { get; set; }

		[XmlElement("DocNumber")]
		public string? DocNumber { get; set; }

		[XmlElement("DocDate")]
		public DateTime? DocDate { get; set; }

		[XmlElement("FullDocIssueAuthor")]
		public List<Author>? FullDocIssueAuthor { get; set; }

		[XmlElement("DocChanges")]
		public string? DocChanges { get; set; }

		[XmlIgnore]
		public List<File>? Files { get; set; }

		[XmlElement("IULFile")]
		[NotMapped]
		public List<File>? IULFile => this.Files?.Where(x => x.Type == 1).ToList();

		[XmlElement("File")]
		[NotMapped]
		public List<File>? File => this.Files?.Where(x => x.Type == 0).ToList();

		



		//[XmlIgnore]
		//public EngineeringSurveyDocuments? EngineeringSurveyDocuments { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(EngineeringSurveyDocuments))]
		public Guid? EngineeringSurveyDocumentsId { get; set; }
	}
}
