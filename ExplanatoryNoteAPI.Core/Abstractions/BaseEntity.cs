using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Entities;

namespace ExplanatoryNoteAPI.Core.Abstractions
{
	/// <summary>
	/// Базовая сушность
	/// </summary>
	public abstract class BaseEntity : IHasId
	{
		[XmlIgnore]
		[Key]
		public Guid Id { get; set; }

		[XmlIgnore]
		public DateTime CreatedAt { get; set; }

		[XmlIgnore]
		public DateTime UpdatedAt { get; set; }

		[XmlIgnore]
		public SysUser? CreatedBy { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(CreatedBy))]
		public Guid? CreatedById { get; set; }

		[XmlIgnore]
		public SysUser? UpdatedBy { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(UpdatedBy))]
		public Guid? UpdatedById { get; set; }
	}

	public interface IHasId
	{
		public Guid Id { get; set; }
	}
}
