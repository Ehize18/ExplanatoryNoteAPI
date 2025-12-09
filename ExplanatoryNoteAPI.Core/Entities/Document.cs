using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Classificators;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Документ
	/// </summary>
	public class Document : BaseEntity
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

		[XmlElement("DocIssueAuthor")]
		public string? DocIssueAuthor { get; set; }

		[XmlElement("DocChanges")]
		public string? DocChanges { get; set; }

		[XmlElement("File")]
		public List<File>? File { get; set; }

		[XmlElement("Link")]
		public string? Link { get; set; }

		[XmlElement("Included")]
		public string? Included { get; set; }



		//[XmlIgnore]
		//public ProjectDocumentNotNecessarySectionContent? ProjectDocumentNotNecessarySectionContent { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ProjectDocumentNotNecessarySectionContent))]
		public Guid? ProjectDocumentNotNecessarySectionContentId { get; set; }
	}
}
