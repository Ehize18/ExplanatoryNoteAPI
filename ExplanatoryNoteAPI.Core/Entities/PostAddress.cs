using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Почтовый адрес
	/// </summary>
	public class PostAddress : Address
	{
		[XmlElement("PostIndex")]
		public string? PostIndex { get; set; }
	}
}
