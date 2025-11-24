using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// ПО
	/// </summary>
	public class Software : BaseEntity
	{
		[XmlElement("Name")]
		public string? Name { get; set; }

		[XmlElement("Version")]
		public string? Version { get; set; }

		[XmlElement("UsingNote")]
		public string? UsingNote { get; set; }

		[XmlIgnore]
		public SoftwareUsed? SoftwareUsed { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(SoftwareUsed))]
		public Guid? SoftwareUsedId { get; set; }
	}
}
