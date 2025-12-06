using System.ComponentModel.DataAnnotations.Schema;
using ExplanatoryNoteAPI.Core.Abstractions;
using ExplanatoryNoteAPI.Core.Entities;

namespace ExplanatoryNoteAPI.Core.Classificators
{
	public class ConstractionType : BaseClassificator
	{
	}

	public class DocumentType : BaseClassificator
	{
	}

	public class LandCategory : BaseClassificator
	{
	}

	public class LandCategoryMappings
	{
		public Guid Id { get; set; }
		public LandCategory? LandCategory { get; set; }

		[ForeignKey(nameof(LandCategory))]
		public Guid? LandCategoryId { get; set; }

		//public NonIndustrialObject? NonIndustrialObject { get; set; }

		[ForeignKey(nameof(NonIndustrialObject))]
		public Guid? NonIndustrialObjectId { get; set; }

		[ForeignKey(nameof(IndustrialObject))]
		public Guid? IndustrialObjectId { get; set; }

		[ForeignKey(nameof(LinearObject))]
		public Guid? LinearObjectId { get; set; }
	}

	public class ClimateDistrict : BaseClassificator
	{
	}

	public class GeologicalConditions : BaseClassificator
	{
	}

	public class WindDistrict : BaseClassificator
	{
	}

	public class SnowDistrict : BaseClassificator
	{
	}

	public class SeismicActivity : BaseClassificator
	{
	}

	public class RegionsRF : BaseClassificator
	{
	}

	public class Placement : BaseClassificator
	{
	}
	public class DangerousAndComplex : BaseClassificator
	{
	}
	public class Unique : BaseClassificator
	{
	}
	public class BudgetLevel : BaseClassificator
	{
	}
	public class SROType : BaseClassificator
	{
	}
	public class ModelFormat : BaseClassificator
	{
	}
	public class EfficiencyClass : BaseClassificator
	{
	}
	public class ResponsibilityLevel : BaseClassificator
	{
	}
	public class FireDangerCategory : BaseClassificator
	{
	}
	public class DangerIndustrialClass : BaseClassificator
	{
	}

	public class OKEI : BaseClassificator
	{
	}
	public class ParticipantResponsibilityLevel : BaseClassificator
	{
	}
}
