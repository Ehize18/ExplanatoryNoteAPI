using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Состав проектной документации нелинейного объекта
	/// </summary>
	public class NonLinearProjectDocumentContent : BaseEntity
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
		public Section5? Section5 { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Section5))]
		public Guid? Section5Id { get; set; }

		[XmlElement("Section6")]
		public ProjectDocumentSection? Section6 { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Section6))]
		public Guid? Section6Id { get; set; }

		[XmlElement("Section7")]
		public ProjectDocumentSection? Section7 { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Section7))]
		public Guid? Section7Id { get; set; }

		[XmlElement("Section8")]
		public ProjectDocumentSection? Section8 { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Section8))]
		public Guid? Section8Id { get; set; }

		[XmlElement("Section9")]
		public ProjectDocumentSection? Section9 { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Section9))]
		public Guid? Section9Id { get; set; }

		[XmlElement("Section10")]
		public ProjectDocumentSection? Section10 { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Section10))]
		public Guid? Section10Id { get; set; }

		[XmlElement("Section11")]
		public ProjectDocumentSection? Section11 { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Section11))]
		public Guid? Section11Id { get; set; }

		[XmlElement("Section12")]
		public SectionEstimate? Section12 { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Section12))]
		public Guid? Section12Id { get; set; }

		[XmlElement("Section13")]
		public OtherDocumentsSection? Section13 { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Section13))]
		public Guid? Section13Id { get; set; }
	}
}
