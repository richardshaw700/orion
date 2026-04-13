using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using GIToolkit.Resources;
using GIToolkit.Services;
using Golfin.CustomValidation;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class AppointmentForCreationDto : IAppointmentContactInfo
{
	[CompilerGenerated]
	private int NlkQop3XO;

	[CompilerGenerated]
	private DateTime FIqTZqEDM;

	[CompilerGenerated]
	private int OfPLyovPE;

	[CompilerGenerated]
	private int o0c0J5ogP;

	[CompilerGenerated]
	private DateTime? a4NZUxG9l;

	[CompilerGenerated]
	private int xMnMD2fXk;

	[CompilerGenerated]
	private string QkiSIQVZJ;

	[CompilerGenerated]
	private bool jCNglZwdh;

	[CompilerGenerated]
	private bool rZQNGd8gL;

	private string KEhchIwt1;

	private string M3aI3Do50;

	[CompilerGenerated]
	private string K1CqPhxHX;

	[CompilerGenerated]
	private bool kJiPpCW1N;

	[CompilerGenerated]
	private bool fUBz9npv4;

	[CompilerGenerated]
	private bool VNtidedcY5;

	[CompilerGenerated]
	private int? VCPiis8IMA;

	[CompilerGenerated]
	private string QlWiufFujT;

	[CompilerGenerated]
	private TimeSpan HHsiV7fiy0;

	[CompilerGenerated]
	private SupportedCulture AANiRJuKQT;

	[Required(ErrorMessageResourceName = "RequiredSiteId", ErrorMessageResourceType = typeof(DtoTraduction))]
	public int SiteId
	{
		[CompilerGenerated]
		get
		{
			return NlkQop3XO;
		}
		[CompilerGenerated]
		set
		{
			NlkQop3XO = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredDateTime", ErrorMessageResourceType = typeof(DtoTraduction))]
	public DateTime Date
	{
		[CompilerGenerated]
		get
		{
			return FIqTZqEDM;
		}
		[CompilerGenerated]
		set
		{
			FIqTZqEDM = value;
		}
	}

	[Range(0, int.MaxValue, ErrorMessageResourceName = "MinRangeHour", ErrorMessageResourceType = typeof(DtoTraduction))]
	public int DurationHour
	{
		[CompilerGenerated]
		get
		{
			return OfPLyovPE;
		}
		[CompilerGenerated]
		set
		{
			OfPLyovPE = value;
		}
	}

	public int DurationMin
	{
		[CompilerGenerated]
		get
		{
			return o0c0J5ogP;
		}
		[CompilerGenerated]
		set
		{
			o0c0J5ogP = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredTeeTime", ErrorMessageResourceType = typeof(DtoTraduction))]
	public DateTime? StartTime
	{
		[CompilerGenerated]
		get
		{
			return a4NZUxG9l;
		}
		[CompilerGenerated]
		set
		{
			a4NZUxG9l = value;
		}
	}

	[Range(1, 8, ErrorMessageResourceName = "RangeNbPlayer", ErrorMessageResourceType = typeof(DtoTraduction))]
	[Required(ErrorMessageResourceName = "RequiredNbPlayer", ErrorMessageResourceType = typeof(DtoTraduction))]
	public int NumberOfPlayers
	{
		[CompilerGenerated]
		get
		{
			return xMnMD2fXk;
		}
		[CompilerGenerated]
		set
		{
			xMnMD2fXk = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredTitleReservation", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string Title
	{
		[CompilerGenerated]
		get
		{
			return QkiSIQVZJ;
		}
		[CompilerGenerated]
		set
		{
			QkiSIQVZJ = value;
		}
	}

	public bool IsFirstTimePlay
	{
		[CompilerGenerated]
		get
		{
			return jCNglZwdh;
		}
		[CompilerGenerated]
		set
		{
			jCNglZwdh = value;
		}
	}

	public bool HasBeenForcedToASim
	{
		[CompilerGenerated]
		get
		{
			return rZQNGd8gL;
		}
		[CompilerGenerated]
		set
		{
			rZQNGd8gL = value;
		}
	}

	[CustomEmailAddress(ErrorMessageResourceName = "RegexEmail", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string Email
	{
		get
		{
			return KEhchIwt1;
		}
		set
		{
			KEhchIwt1 = (string.IsNullOrWhiteSpace(value) ? null : value);
		}
	}

	[CustomPhone(ErrorMessageResourceName = "RegexPhone", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string Phone
	{
		get
		{
			return M3aI3Do50;
		}
		set
		{
			M3aI3Do50 = (string.IsNullOrWhiteSpace(value) ? null : value);
		}
	}

	public string Notes
	{
		[CompilerGenerated]
		get
		{
			return K1CqPhxHX;
		}
		[CompilerGenerated]
		set
		{
			K1CqPhxHX = value;
		}
	}

	public bool NotifyRecipient
	{
		[CompilerGenerated]
		get
		{
			return kJiPpCW1N;
		}
		[CompilerGenerated]
		set
		{
			kJiPpCW1N = value;
		}
	}

	public bool ShouldAddAsContact
	{
		[CompilerGenerated]
		get
		{
			return fUBz9npv4;
		}
		[CompilerGenerated]
		set
		{
			fUBz9npv4 = value;
		}
	}

	public bool HasSubscribedToNews
	{
		[CompilerGenerated]
		get
		{
			return VNtidedcY5;
		}
		[CompilerGenerated]
		set
		{
			VNtidedcY5 = value;
		}
	}

	public int? AppointmentRecurrenceId
	{
		[CompilerGenerated]
		get
		{
			return VCPiis8IMA;
		}
		[CompilerGenerated]
		set
		{
			VCPiis8IMA = value;
		}
	}

	public string UserId
	{
		[CompilerGenerated]
		get
		{
			return QlWiufFujT;
		}
		[CompilerGenerated]
		set
		{
			QlWiufFujT = value;
		}
	}

	public TimeSpan UserTimeZoneOffset
	{
		[CompilerGenerated]
		get
		{
			return HHsiV7fiy0;
		}
		[CompilerGenerated]
		set
		{
			HHsiV7fiy0 = value;
		}
	}

	public SupportedCulture WebBrowserCulture
	{
		[CompilerGenerated]
		get
		{
			return AANiRJuKQT;
		}
		[CompilerGenerated]
		set
		{
			AANiRJuKQT = value;
		}
	}

	public AppointmentForCreationDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		kJiPpCW1N = true;
		AANiRJuKQT = SupportedCulture.EN_US;
		base._002Ector();
	}
}
