using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using GIToolkit.Resources;
using GIToolkit.Services;
using Golfin.CustomValidation;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class AppointmentForUpdateDto : IAppointmentContactInfo
{
	[CompilerGenerated]
	private int TWHiAYgTDT;

	[CompilerGenerated]
	private string L6JikHbFbG;

	[CompilerGenerated]
	private string P3xiaPGigx;

	[CompilerGenerated]
	private string kXXiXJ9QAv;

	[CompilerGenerated]
	private string uQOiFCRt9D;

	[CompilerGenerated]
	private SimulatorDto InbipDFOpF;

	private DateTime YJXiWScYAg;

	[CompilerGenerated]
	private DateTime? keOiYPMgnU;

	[CompilerGenerated]
	private int kmgix27XJI;

	[CompilerGenerated]
	private int C3Gi66jncy;

	[CompilerGenerated]
	private int EnRiEbvJm0;

	[CompilerGenerated]
	private string E81iB3PDqL;

	[CompilerGenerated]
	private bool pJZi3GZt9f;

	[CompilerGenerated]
	private bool SS6i2JmGeT;

	[CompilerGenerated]
	private bool opvioTMuW4;

	[CompilerGenerated]
	private bool JnIitw49On;

	private string nFViDAE0L5;

	private string aWJivvxXHk;

	[CompilerGenerated]
	private string dCOiJURO1b;

	[CompilerGenerated]
	private bool XfKiecxBZQ;

	[CompilerGenerated]
	private int? ywgiKflIp9;

	[CompilerGenerated]
	private TimeSpan vaOi7OJvN5;

	[CompilerGenerated]
	private SupportedCulture rhDi4HeGNh;

	public int SiteId
	{
		[CompilerGenerated]
		get
		{
			return TWHiAYgTDT;
		}
		[CompilerGenerated]
		set
		{
			TWHiAYgTDT = value;
		}
	}

	public string AuthorUserId
	{
		[CompilerGenerated]
		get
		{
			return L6JikHbFbG;
		}
		[CompilerGenerated]
		set
		{
			L6JikHbFbG = value;
		}
	}

	public string UserId
	{
		[CompilerGenerated]
		get
		{
			return P3xiaPGigx;
		}
		[CompilerGenerated]
		set
		{
			P3xiaPGigx = value;
		}
	}

	public string SimulatorId
	{
		[CompilerGenerated]
		get
		{
			return kXXiXJ9QAv;
		}
		[CompilerGenerated]
		set
		{
			kXXiXJ9QAv = value;
		}
	}

	public string SimulatorName
	{
		[CompilerGenerated]
		get
		{
			return uQOiFCRt9D;
		}
		[CompilerGenerated]
		set
		{
			uQOiFCRt9D = value;
		}
	}

	public SimulatorDto Simulator
	{
		[CompilerGenerated]
		get
		{
			return InbipDFOpF;
		}
		[CompilerGenerated]
		set
		{
			InbipDFOpF = value;
		}
	}

	public DateTime Date
	{
		get
		{
			return YJXiWScYAg;
		}
		set
		{
			YJXiWScYAg = value;
			if (StartTime.HasValue)
			{
				StartTime = new DateTime(YJXiWScYAg.Year, YJXiWScYAg.Month, YJXiWScYAg.Day, StartTime.Value.Hour, StartTime.Value.Minute, StartTime.Value.Second);
			}
		}
	}

	public DateTime? StartTime
	{
		[CompilerGenerated]
		get
		{
			return keOiYPMgnU;
		}
		[CompilerGenerated]
		set
		{
			keOiYPMgnU = value;
		}
	}

	public int DurationHour
	{
		[CompilerGenerated]
		get
		{
			return kmgix27XJI;
		}
		[CompilerGenerated]
		set
		{
			kmgix27XJI = value;
		}
	}

	public int DurationMin
	{
		[CompilerGenerated]
		get
		{
			return C3Gi66jncy;
		}
		[CompilerGenerated]
		set
		{
			C3Gi66jncy = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredNbPlayer", ErrorMessageResourceType = typeof(DtoTraduction))]
	[Range(1, 8, ErrorMessageResourceName = "RangeNbPlayer", ErrorMessageResourceType = typeof(DtoTraduction))]
	public int NumberOfPlayers
	{
		[CompilerGenerated]
		get
		{
			return EnRiEbvJm0;
		}
		[CompilerGenerated]
		set
		{
			EnRiEbvJm0 = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredTitleReservation", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string Title
	{
		[CompilerGenerated]
		get
		{
			return E81iB3PDqL;
		}
		[CompilerGenerated]
		set
		{
			E81iB3PDqL = value;
		}
	}

	public bool IsFirstTimePlay
	{
		[CompilerGenerated]
		get
		{
			return pJZi3GZt9f;
		}
		[CompilerGenerated]
		set
		{
			pJZi3GZt9f = value;
		}
	}

	public bool HasBeenForcedToASim
	{
		[CompilerGenerated]
		get
		{
			return SS6i2JmGeT;
		}
		[CompilerGenerated]
		set
		{
			SS6i2JmGeT = value;
		}
	}

	public bool ShouldAddAsContact
	{
		[CompilerGenerated]
		get
		{
			return opvioTMuW4;
		}
		[CompilerGenerated]
		set
		{
			opvioTMuW4 = value;
		}
	}

	public bool HasSubscribedToNews
	{
		[CompilerGenerated]
		get
		{
			return JnIitw49On;
		}
		[CompilerGenerated]
		set
		{
			JnIitw49On = value;
		}
	}

	[CustomEmailAddress(ErrorMessageResourceName = "RegexEmail", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string Email
	{
		get
		{
			return nFViDAE0L5;
		}
		set
		{
			nFViDAE0L5 = (string.IsNullOrWhiteSpace(value) ? null : value);
		}
	}

	[CustomPhone(ErrorMessageResourceName = "RegexPhone", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string Phone
	{
		get
		{
			return aWJivvxXHk;
		}
		set
		{
			aWJivvxXHk = (string.IsNullOrWhiteSpace(value) ? null : value);
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return dCOiJURO1b;
		}
		[CompilerGenerated]
		set
		{
			dCOiJURO1b = value;
		}
	}

	public bool NotifyRecipient
	{
		[CompilerGenerated]
		get
		{
			return XfKiecxBZQ;
		}
		[CompilerGenerated]
		set
		{
			XfKiecxBZQ = value;
		}
	}

	public int? RentalInvoiceId
	{
		[CompilerGenerated]
		get
		{
			return ywgiKflIp9;
		}
		[CompilerGenerated]
		set
		{
			ywgiKflIp9 = value;
		}
	}

	public TimeSpan UserTimeZoneOffset
	{
		[CompilerGenerated]
		get
		{
			return vaOi7OJvN5;
		}
		[CompilerGenerated]
		set
		{
			vaOi7OJvN5 = value;
		}
	}

	public SupportedCulture WebBrowserCulture
	{
		[CompilerGenerated]
		get
		{
			return rhDi4HeGNh;
		}
		[CompilerGenerated]
		set
		{
			rhDi4HeGNh = value;
		}
	}

	public AppointmentForUpdateDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		rhDi4HeGNh = SupportedCulture.EN_US;
		base._002Ector();
	}
}
