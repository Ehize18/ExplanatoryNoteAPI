using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Модель объекта
	/// </summary>
	public class Model : BaseEntity
	{
		[XmlElement("File")]
		public List<File> File { get; set; }
	}
}
