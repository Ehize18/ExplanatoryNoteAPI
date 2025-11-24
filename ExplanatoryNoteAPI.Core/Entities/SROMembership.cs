using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Членство в СРО
	/// </summary>
	public class SROMembership : BaseEntity
	{
		[XmlElement("SRO")]
		public List<SRO>? SRO { get; set; }
	}
}
