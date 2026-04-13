using System.ComponentModel.DataAnnotations;
using GIToolkit.Resources;

namespace GIToolkit.Model.Enum;

public enum InvoiceBillingTypes
{
	[Display(ResourceType = typeof(DtoTraduction), Name = "InvoiceBillingTypes_TimeReserved")]
	TimeReserved,
	[Display(ResourceType = typeof(DtoTraduction), Name = "InvoiceBillingTypes_TimeConsumed")]
	TimeConsumed
}
