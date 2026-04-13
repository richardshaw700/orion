using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using GIToolkit.Resources;
using Golfin.CustomValidation;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class ChangeRateDto
{
	[CompilerGenerated]
	private IEnumerable<int> QOau3fLru3;

	[CompilerGenerated]
	private decimal BgHu28uAOD;

	[NotNullOrEmptyCollection(ErrorMessageResourceName = "NotNullOrEmptyCollectionDays", ErrorMessageResourceType = typeof(DtoTraduction))]
	public IEnumerable<int> Days
	{
		[CompilerGenerated]
		get
		{
			return QOau3fLru3;
		}
		[CompilerGenerated]
		set
		{
			QOau3fLru3 = value;
		}
	}

	[Range(0.0, double.MaxValue, ErrorMessageResourceName = "RangeRate", ErrorMessageResourceType = typeof(DtoTraduction))]
	public decimal Rate
	{
		[CompilerGenerated]
		get
		{
			return BgHu28uAOD;
		}
		[CompilerGenerated]
		set
		{
			BgHu28uAOD = value;
		}
	}

	public ChangeRateDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
