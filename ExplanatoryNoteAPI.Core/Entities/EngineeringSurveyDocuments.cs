using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Документы инженерных изысканий
	/// </summary>
	public class EngineeringSurveyDocuments : BaseEntity
	{
		[XmlElement("Document")]
		public List<EngineeringSurveyDocument>? Document { get; set; }
	}
}
