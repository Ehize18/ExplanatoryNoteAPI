using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Главный инженер проекта
	/// </summary>
	public class ChiefProjectEngineer : BaseEntity
	{
		[XmlElement("FamilyName")]
		public string? FamilyName { get; set; }

		[XmlElement("FirstName")]
		public string? FirstName { get; set; }

		[XmlElement("SecondName")]
		public string? SecondName { get; set; }

		[XmlElement("SNILS")]
		public string? SNILS { get; set; }

		[XmlElement("NOPRIZ")]
		public string? NOPRIZ { get; set; }
	}
}
