using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Сведения о внесении изменений в проектную документацию
	/// </summary>
	public class ExplanatoryNoteModifications : BaseEntity
	{
		[XmlElement("Modification")]
		public List<Modification> Modification { get; set; }
	}
}
