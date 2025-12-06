using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Текстовый блок
	/// </summary>
	public class TextBlock : BaseEntity
	{
		[XmlElement("Title")]
		public string? Title { get; set; }

		[XmlElement("SubTitle")]
		[NotMapped]
		public List<string>? SubTitle
		{
			get => this._subTitle != null ? JsonSerializer.Deserialize<List<string>>(this._subTitle) : null;
			set
			{
				if (value != null)
				{
					this._subTitle = JsonSerializer.Serialize(value);
				}
				else
				{
					this._subTitle = null;
				}
			}
		}

		[XmlIgnore]
		private string? _subTitle;

		[XmlElement("Text")]
		[NotMapped]
		public List<string>? Text
		{
			get => this._text != null ? JsonSerializer.Deserialize<List<string>>(this._text) : null;
			set
			{
				if (value != null)
				{
					this._text = JsonSerializer.Serialize(value);
				}
				else
				{
					this._text = null;
				}
			}
		}

		[XmlIgnore]
		private string? _text;

		[XmlElement("Image")]
		public List<Image>? Image { get; set; }

		[XmlElement("Table")]
		public List<Table>? Table { get; set; }

		//[XmlIgnore]
		//public ExplanatoryNote? ExplanatoryNote { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ExplanatoryNote))]
		public Guid? ExplanatoryNoteId { get; set; }
	}
}
