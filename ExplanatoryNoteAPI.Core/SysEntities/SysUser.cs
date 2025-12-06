using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Пользователь
	/// </summary>
	public class SysUser : IHasId
	{
		[XmlIgnore]
		public Guid Id { get; set; }

		[XmlIgnore]
		public DateTime CreatedAt { get; set; }

		[XmlIgnore]
		public DateTime UpdatedAt { get; set; }

		public string Email { get; set; }

		public string PasswordHash { get; set; }
	}
}
