using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Classificators;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Участник разработки проектной документации
	/// </summary>
	public class ProjectDocParticipant : BaseEntity
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

		[XmlElement("role")]
		[NotMapped]
		public string? RoleCode => this.Role?.Code;

		[XmlIgnore]
		public ParticipantResponsibilityLevel? Role { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(Role))]
		public Guid? RoleId { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ProjectDocParticipants))]
		public Guid? ProjectDocParticipantsId { get; set; }
	}
}
