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
		public TextBlock RoutesNote { get; set; }

		[XmlElement("Route")]
		public List<Route> Route { get; set; }
	}
}
