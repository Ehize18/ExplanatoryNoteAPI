using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Classificators;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Саморегулируемая организация
	/// </summary>
	public class SRO : BaseEntity
	{
		[XmlAttribute("SROType")]
		[NotMapped]
		public string? SROTypeCode
		{
			get
			{
				return this.SROType?.Code;
			}
			set { }
		}

		[XmlIgnore]
		public SROType? SROType { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(SROType))]
		public Guid? SROTypeId { get; set; }

		[XmlText]
		public string? Value { get; set; }

		//[XmlIgnore]
		//public SROMembership? SROMembership { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(SROMembership))]
		public Guid? SROMembershipId { get; set; }
	}
}
