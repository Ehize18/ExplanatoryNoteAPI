using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Entities.TextBlockEntities;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Текстовый блок
	/// </summary>
	public class TextBlock : BaseEntity
	{
		[XmlElement("Title")]
		public string? Title { get; set; }

		[XmlElement("SubTitle", typeof(TextBlockSubTitle))]
		[XmlElement("Text", typeof(TextBlockText))]
		[XmlElement("Image", typeof(TextBlockImage))]
		[XmlElement("Table", typeof(TextBlockTable))]
		[NotMapped]
		public List<BaseTextBlockElement>? Elements
		{
			get
			{
				var innerList = new List<BaseTextBlockElement>();
				if (this._jsonElements != null)
				{
					foreach (var jsonString in this._jsonElements)
					{
						var element = this.ParseElement(jsonString);
						if (element != null)
						{
							innerList.Add(element);
						}
					}
				}
				return innerList.OrderBy(x => x.Order).ToList();
			}
			set
			{
				if (value != null)
				{
					var innerList = new List<string>();
					foreach (var element in value)
					{
						var jsonElement = this.SerializeBaseElement(element);
						if (jsonElement != null)
						{
							innerList.Add(jsonElement);
						}
					}
					this._jsonElements = innerList;
				}
			}
		}

		[XmlIgnore]
		[NotMapped]
		private List<string>? _jsonElements = new List<string>();

		[XmlIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public string Json
		{
			get
			{
				return JsonSerializer.Serialize(this._jsonElements);
			}
			set
			{
				this._jsonElements = JsonSerializer.Deserialize<List<string>?>(value);
			}
		}

		[XmlIgnore]
		[ForeignKey(nameof(ExplanatoryNote))]
		public Guid? ExplanatoryNoteId { get; set; }

		private string SerializeBaseElement(BaseTextBlockElement element)
		{
			if (element is TextBlockTable table)
			{
				return this.SerializeElement(table);
			}
			if (element is TextBlockImage image)
			{
				return this.SerializeElement(image);
			}
			if (element is TextBlockText text)
			{
				return this.SerializeElement(text);
			}
			if (element is TextBlockSubTitle subtitle)
			{
				return this.SerializeElement(subtitle);
			}
			return string.Empty;
		}

		private string SerializeElement<T>(T element) where T : BaseTextBlockElement
		{
			string? text;
			try
			{
				text = JsonSerializer.Serialize<T>(element);
			}
			catch
			{
				text = null;
			}
			return text;
		}

		private BaseTextBlockElement? ParseElement(string text)
		{
			BaseTextBlockElement? result;
			try
			{
				result = JsonSerializer.Deserialize<TextBlockTable>(text);
			}
			catch
			{
				try
				{
					result = JsonSerializer.Deserialize<TextBlockImage>(text);
				}
				catch
				{
					try
					{
						result = JsonSerializer.Deserialize<TextBlockText>(text);
					}
					catch
					{
						try
						{
							result = JsonSerializer.Deserialize<TextBlockSubTitle>(text);
						}
						catch
						{
							result = null;
						}
					}
				}
				
			}

			return result;
		}
	}
}

namespace ExplanatoryNoteAPI.Core.Entities.TextBlockEntities
{
	public abstract class BaseTextBlockElement
	{
		[XmlIgnore]
		public int Order { get; set; }
	}

	public class TextBlockSubTitle : BaseTextBlockElement
	{
		[XmlText]
		[JsonPropertyName("SubTitle")]
		public required string SubTitle { get; set; }
	}

	public class TextBlockText : BaseTextBlockElement
	{
		[XmlText]
		public required string Text { get; set; }
	}

	public class TextBlockImage : BaseTextBlockElement
	{
		[XmlAttribute("Type")]
		public required string Type { get; set; }

		[XmlElement("ImageData")]
		public required string ImageData { get; set; }

		[XmlElement("Comment")]
		public string? Comment { get; set; }
	}

	public class TextBlockTable : BaseTextBlockElement
	{
		public class Row
		{
			[XmlIgnore]
			public int Order { get; set; }

			[XmlIgnore]
			private List<Cell> _cells;

			[XmlElement("Cell")]
			public List<Cell> Cells
			{
				get
				{
					return this._cells.OrderBy(x => x.Order).ToList();
				}
				set
				{
					this._cells = value;
				}
			}
		}

		public class Cell
		{
			[XmlIgnore]
			public int Order { get; set; }

			[XmlText]
			public string Content { get; set; }
		}

		[XmlElement("TitleRow")]
		public Row? TitleRow { get; set; }

		[XmlIgnore]
		private List<Row> _rows;

		[XmlElement("Row")]
		public required List<Row> Rows
		{
			get
			{
				return this._rows.OrderBy(x => x.Order).ToList();
			}
			set
			{
				this._rows = value;
			}
		}
	}
}
