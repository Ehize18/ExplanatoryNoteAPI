using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Дополнительные данные
	/// </summary>
	public class AdditionalData : BaseEntity
	{
		[XmlElement("Data")]
		public List<Data>? Data { get; set; }
	}
}
