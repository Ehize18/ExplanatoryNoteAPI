using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Изображение
	/// </summary>
	public class Image : BaseEntity
	{
		[XmlAttribute("Type")]
		public string? Type { get; set; }

		[XmlElement("ImageData")]
		[NotMapped]
		public required string ImageData
		{
			get => Convert.ToBase64String(this._imageData);
			set => this._imageData = Encoding.UTF8.GetBytes(value);
		}

		[XmlIgnore]
		private byte[]? _imageData;

		[XmlElement("Comment")]
		public string? Comment { get; set; }

		[XmlIgnore]
		public TextBlock? TextBlock { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(TextBlock))]
		public Guid? TextBlockId { get; set; }
	}
}
