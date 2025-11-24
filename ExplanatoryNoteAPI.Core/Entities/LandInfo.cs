using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Информация о земельных участках
	/// </summary>
	public class LandInfo : BaseEntity
	{
		[XmlElement("CommonLandInfo")]
		public TextBlock? CommonLandInfo { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(CommonLandInfo))]
		public Guid? CommonLandInfoId { get; set; }

		[XmlElement("LandAreaInfo")]
		public List<LandAreaInfo>? LandAreaInfo { get; set; }
	}
}
