using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Таблица
	/// </summary>
	public class Table : BaseEntity
	{
		[XmlElement("TitleRow")]
		public Row? TitleRow { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(TitleRow))]
		public Guid? TitleRowId { get; set; }

		[XmlElement("Row")]
		public Row? Row { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Row))]
		public Guid? RowId { get; set; }

		[XmlIgnore]
		public TextBlock? TextBlock { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(TextBlock))]
		public Guid? TextBlockId { get; set; }
	}

	public class Row : BaseEntity
	{
		[XmlElement("Cell")]
		public Cell? Cell { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Cell))]
		public Guid? CellId { get; set; }
	}

	public class Cell : BaseEntity
	{
		[XmlText]
		public required string Value { get; set; }

		[XmlElement("align")]
		[NotMapped]
		public string? Align => this.AlignEnum?.ToString().ToLower();

		[XmlIgnore]
		public Align? AlignEnum { get; set; }
	}

	public enum Align
	{
		Left,
		Center,
		Right
	}
}
