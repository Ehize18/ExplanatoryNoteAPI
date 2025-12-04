using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Маршруты
	/// </summary>
	public class Routes : BaseEntity
	{
		[XmlElement("RoutesNote")]
		public TextBlock? RoutesNote { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(RoutesNote))]
		public Guid? RoutesNoteId { get; set; }

		[XmlElement("Route")]
		public List<Route>? Route { get; set; }
	}
}
