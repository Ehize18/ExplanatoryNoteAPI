using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Индивидуальный предприниматель
	/// </summary>
	public class IP : BaseEntity
	{
		[XmlElement("FamilyName")]
		public string? FamilyName { get; set; }

		[XmlElement("FirstName")]
		public string? FirstName { get; set; }

		[XmlElement("SecondName")]
		public string? SecondName { get; set; }

		[XmlElement("OGRNIP")]
		public string? OGRNIP { get; set; }

		[XmlElement("PostAddress")]
		public PostAddress? PostAddress { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(PostAddress))]
		public Guid? PostAddressId { get; set; }

		[XmlElement("Email")]
		public string? Email { get; set; }
	}
}
