using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Функции объекта
	/// </summary>
	public class Functions : BaseEntity
	{
		[XmlElement("Functions")]
		public string? FunctionsText { get; set; }

		[XmlElement("FunctionsClass")]
		public string? FunctionsClass { get; set; }

		[XmlElement("ProductsNote")]
		public TextBlock? ProductsNote { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ProductsNote))]
		public Guid? ProductsNoteId { get; set; }
	}
}
