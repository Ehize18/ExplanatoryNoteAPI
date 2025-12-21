using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;
using Newtonsoft.Json;

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

		[JsonIgnore]
		public string PasswordHash { get; set; }

		public bool IsEmailConfirmed { get; set; }
	}
}
