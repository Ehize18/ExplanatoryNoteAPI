using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Classificators;

namespace ExplanatoryNoteAPI.Core.Entities
{
	/// <summary>
	/// Климатические условия
	/// </summary>
	public class ClimateConditions : BaseEntity
	{
		[XmlElement("ClimateNote")]
		public TextBlock? ClimateNote { get; set; }

		[XmlIgnore]
		[ForeignKey(nameof(ClimateNote))]
		public Guid? ClimateNoteId { get; set; }

		[XmlElement("ClimateDistrict")]
		[NotMapped]
		public List<string>? ClimateDistrictCode => this.ClimateDistrict?.Select(x => x.ClimateDistrict.Code).ToList();

		[XmlIgnore]
		public List<ClimateConditionsClimateDistrict>? ClimateDistrict { get; set; }

		[XmlElement("GeologicalConditions")]
		[NotMapped]
		public List<string>? GeologicalConditionsCode => this.GeologicalConditions?.Select(x => x.GeologicalConditions.Code).ToList();

		[XmlIgnore]
		public List<ClimateConditionsGeologicalConditions>? GeologicalConditions { get; set; }

		[XmlElement("WindDistrict")]
		[NotMapped]
		public List<string>? WindDistrictCode => this.WindDistrict?.Select(x => x.WindDistrict.Code).ToList();

		[XmlIgnore]
		public List<ClimateConditionsWindDistrict>? WindDistrict { get; set; }

		[XmlElement("SnowDistrict")]
		[NotMapped]
		public List<string>? SnowDistrictCode => this.SnowDistrict?.Select(x => x.SnowDistrict.Code).ToList();

		[XmlIgnore]
		public List<ClimateConditionsSnowDistrict>? SnowDistrict { get; set; }

		[XmlElement("SeismicActivity")]
		[NotMapped]
		public List<string>? SeismicActivityCode => this.SeismicActivity?.Select(x => x.SeismicActivity.Code).ToList();

		[XmlIgnore]
		public List<ClimateConditionsSeismicActivity>? SeismicActivity { get; set; }
	}

	public class ClimateConditionsSeismicActivity : BaseEntity
	{
		public required ClimateConditions ClimateConditions { get; set; }

		[ForeignKey(nameof(ClimateConditions))]
		public Guid ClimateConditionsId { get; set; }

		public required SeismicActivity SeismicActivity { get; set; }

		[ForeignKey(nameof(SeismicActivity))]
		public Guid SeismicActivityId { get; set; }
	}

	public class ClimateConditionsSnowDistrict : BaseEntity
	{
		public required ClimateConditions ClimateConditions { get; set; }

		[ForeignKey(nameof(ClimateConditions))]
		public Guid ClimateConditionsId { get; set; }

		public required SnowDistrict SnowDistrict { get; set; }

		[ForeignKey(nameof(SnowDistrict))]
		public Guid SnowDistrictId { get; set; }
	}

	public class ClimateConditionsWindDistrict : BaseEntity
	{
		public required ClimateConditions ClimateConditions { get; set; }

		[ForeignKey(nameof(ClimateConditions))]
		public Guid ClimateConditionsId { get; set; }

		public required WindDistrict WindDistrict { get; set; }

		[ForeignKey(nameof(WindDistrict))]
		public Guid WindDistrictId { get; set; }
	}

	public class ClimateConditionsGeologicalConditions : BaseEntity
	{
		public required ClimateConditions ClimateConditions { get; set; }

		[ForeignKey(nameof(ClimateConditions))]
		public Guid ClimateConditionsId { get; set; }

		public required GeologicalConditions GeologicalConditions { get; set; }

		[ForeignKey(nameof(GeologicalConditions))]
		public Guid GeologicalConditionsId { get; set; }
	}

	public class ClimateConditionsClimateDistrict : BaseEntity
	{
		public required ClimateConditions ClimateConditions { get; set; }

		[ForeignKey(nameof(ClimateConditions))]
		public Guid ClimateConditionsId { get; set; }

		public required ClimateDistrict ClimateDistrict { get; set; }

		[ForeignKey(nameof(ClimateDistrict))]
		public Guid ClimateDistrictId { get; set; }
	}
}
