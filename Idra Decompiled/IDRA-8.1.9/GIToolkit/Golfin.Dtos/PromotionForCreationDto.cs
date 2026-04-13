using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using GIToolkit.Resources;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class PromotionForCreationDto
{
	[CompilerGenerated]
	private string JhvuInDRRv;

	[CompilerGenerated]
	private decimal LkTuqSElar;

	[CompilerGenerated]
	private DateTime Da6uPu4pv2;

	[CompilerGenerated]
	private DateTime HixuzIH8dQ;

	[CompilerGenerated]
	private bool? YUMVd3kW6I;

	[CompilerGenerated]
	private bool? r1rVi50F7k;

	[CompilerGenerated]
	private bool? aSWVuQTtlN;

	[CompilerGenerated]
	private DeductionType UxYVV9e9Nf;

	[CompilerGenerated]
	private int FaEVRt6JRe;

	[Required(ErrorMessageResourceName = "RequiredName", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return JhvuInDRRv;
		}
		[CompilerGenerated]
		set
		{
			JhvuInDRRv = value;
		}
	}

	[Range(0.0, double.MaxValue, ErrorMessageResourceName = "RangePrice", ErrorMessageResourceType = typeof(DtoTraduction))]
	[Required(ErrorMessageResourceName = "RequiredPrice", ErrorMessageResourceType = typeof(DtoTraduction))]
	public decimal Price
	{
		[CompilerGenerated]
		get
		{
			return LkTuqSElar;
		}
		[CompilerGenerated]
		set
		{
			LkTuqSElar = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredExpirationDate", ErrorMessageResourceType = typeof(DtoTraduction))]
	public DateTime ExpirationDate
	{
		[CompilerGenerated]
		get
		{
			return Da6uPu4pv2;
		}
		[CompilerGenerated]
		set
		{
			Da6uPu4pv2 = value;
		}
	}

	public DateTime CreationDate
	{
		[CompilerGenerated]
		get
		{
			return HixuzIH8dQ;
		}
		[CompilerGenerated]
		set
		{
			HixuzIH8dQ = value;
		}
	}

	public bool? IsActive
	{
		[CompilerGenerated]
		get
		{
			return YUMVd3kW6I;
		}
		[CompilerGenerated]
		set
		{
			YUMVd3kW6I = value;
		}
	}

	public bool? IsDefault
	{
		[CompilerGenerated]
		get
		{
			return r1rVi50F7k;
		}
		[CompilerGenerated]
		set
		{
			r1rVi50F7k = value;
		}
	}

	public bool? IsActiveOnlyForManager
	{
		[CompilerGenerated]
		get
		{
			return aSWVuQTtlN;
		}
		[CompilerGenerated]
		set
		{
			aSWVuQTtlN = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredDeductionType", ErrorMessageResourceType = typeof(DtoTraduction))]
	public DeductionType DeductionType
	{
		[CompilerGenerated]
		get
		{
			return UxYVV9e9Nf;
		}
		[CompilerGenerated]
		set
		{
			UxYVV9e9Nf = value;
		}
	}

	public int SiteId
	{
		[CompilerGenerated]
		get
		{
			return FaEVRt6JRe;
		}
		[CompilerGenerated]
		set
		{
			FaEVRt6JRe = value;
		}
	}

	public PromotionForCreationDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		IsActive = true;
		CreationDate = DateTime.UtcNow;
	}
}
