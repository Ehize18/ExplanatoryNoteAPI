using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Состав проектной документации газового линейного объекта
	/// </summary>
	public class GasLinearProjectDocumentContent : BaseEntity
	{
		[XmlElement("Section2")]
		public ProjectDocumentSection? Section2 { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Section2))]
		public Guid? Section2Id { get; set; }

		[XmlElement("Section3")]
		public ProjectDocumentSection? Section3 { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Section3))]
		public Guid? Section3Id { get; set; }

		[XmlElement("Section4")]
		public ProjectDocumentSection? Section4 { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Section4))]
		public Guid? Section4Id { get; set; }

		[XmlElement("Section5")]
		public ProjectDocumentSection? Section5 { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Section5))]
		public Guid? Section5Id { get; set; }

		[XmlElement("Section6")]
		public ProjectDocumentSection? Section6 { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Section6))]
		public Guid? Section6Id { get; set; }

		[XmlElement("Section7")]
		public OtherDocumentsSection? Section7 { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Section7))]
		public Guid? Section7Id { get; set; }
	}
}
