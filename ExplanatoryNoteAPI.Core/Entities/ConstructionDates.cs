using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Сроки строительства
	/// </summary>
	public class ConstructionDates : BaseEntity
	{
		[XmlElement("BeginDate")]
		public DateTime? BeginDate { get; set; }

		[XmlElement("EndDate")]
		public DateTime? EndDate { get; set; }

		[XmlElement("OperationDate")]
		public DateTime? OperationDate { get; set; }
	}
}
