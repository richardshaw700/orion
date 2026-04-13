using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Golfin.Dtos;

public enum DeductionType
{
	[Description("None")]
	[Display(Name = "None")]
	None = -1,
	[Description("Flat Price")]
	[Display(Name = "Flat price")]
	FlatPrice,
	[Description("Percentage")]
	[Display(Name = "Percentage discount")]
	Percentage,
	[Description("Price per hours")]
	[Display(Name = "Price per hours")]
	PricePerHour,
	[Display(Name = "Percentage per hours")]
	[Description("Percentage per hours")]
	PercentagePerHour
}
