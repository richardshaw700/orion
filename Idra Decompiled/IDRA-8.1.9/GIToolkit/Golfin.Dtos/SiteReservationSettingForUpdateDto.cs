using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using GIToolkit.Model.Enum;
using GIToolkit.Resources;
using GIToolkit.Services;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class SiteReservationSettingForUpdateDto
{
	private bool S3pXXKSUfW;

	private bool aguXF0N5bh;

	private bool FDQXpsOd1k;

	[CompilerGenerated]
	private int uWkXWSN1x4;

	[CompilerGenerated]
	private int xcYXY7GogE;

	[CompilerGenerated]
	private int JhKXxrWXVR;

	[CompilerGenerated]
	private bool JMfX60ryl5;

	[CompilerGenerated]
	private InvoiceBillingTypes M2QXEFRIQq;

	[CompilerGenerated]
	private int keDXBwTX3C;

	[CompilerGenerated]
	private int FgTX3Q919x;

	[CompilerGenerated]
	private int pcXX2UetAT;

	[CompilerGenerated]
	private int mDfXogVUVo;

	[CompilerGenerated]
	private int ueNXtjuBKO;

	[CompilerGenerated]
	private bool sjqXDcdq7y;

	[CompilerGenerated]
	private bool iBlXvxxvF9;

	[CompilerGenerated]
	private bool b9pXJmVCDd;

	[CompilerGenerated]
	private bool FICXebBl6K;

	[CompilerGenerated]
	private bool y13XKHpo1V;

	[CompilerGenerated]
	private DateTime? DNBX769EUb;

	[CompilerGenerated]
	private DateTime? v4mX4INCxn;

	[CompilerGenerated]
	private List<NotificationRecipientDto> EtqXrc5JD3;

	[CompilerGenerated]
	private bool JUSX8xOIrT;

	[CompilerGenerated]
	private List<TimeSpan> WGcXlZwPxl;

	public static readonly Func<TimeSpan, string> TimeToReminderStringFunc;

	[CompilerGenerated]
	private string pqeXnwDvZ6;

	[CompilerGenerated]
	private SupportedCulture ENQX1GSRj8;

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return uWkXWSN1x4;
		}
		[CompilerGenerated]
		set
		{
			uWkXWSN1x4 = value;
		}
	}

	public int SiteId
	{
		[CompilerGenerated]
		get
		{
			return xcYXY7GogE;
		}
		[CompilerGenerated]
		set
		{
			xcYXY7GogE = value;
		}
	}

	public int SliceOfAnHour
	{
		[CompilerGenerated]
		get
		{
			return JhKXxrWXVR;
		}
		[CompilerGenerated]
		set
		{
			JhKXxrWXVR = value;
		}
	}

	public bool EnableNotifyService
	{
		[CompilerGenerated]
		get
		{
			return JMfX60ryl5;
		}
		[CompilerGenerated]
		set
		{
			JMfX60ryl5 = value;
		}
	}

	public bool EnforcePhoneInput
	{
		get
		{
			return aguXF0N5bh;
		}
		set
		{
			aguXF0N5bh = value;
			if (aguXF0N5bh)
			{
				FDQXpsOd1k = false;
			}
		}
	}

	public bool EnforceEmailInput
	{
		get
		{
			return S3pXXKSUfW;
		}
		set
		{
			S3pXXKSUfW = value;
			if (S3pXXKSUfW)
			{
				FDQXpsOd1k = false;
			}
		}
	}

	public bool EnforcePhoneOrEmailInput
	{
		get
		{
			return FDQXpsOd1k;
		}
		set
		{
			FDQXpsOd1k = value;
			if (FDQXpsOd1k)
			{
				S3pXXKSUfW = false;
				aguXF0N5bh = false;
			}
		}
	}

	public InvoiceBillingTypes InvoiceBillingType
	{
		[CompilerGenerated]
		get
		{
			return M2QXEFRIQq;
		}
		[CompilerGenerated]
		set
		{
			M2QXEFRIQq = value;
		}
	}

	[Range(0, int.MaxValue, ErrorMessageResourceName = "RangeMinNumberOfHour", ErrorMessageResourceType = typeof(DtoTraduction))]
	public int MinimumNumberHours
	{
		[CompilerGenerated]
		get
		{
			return keDXBwTX3C;
		}
		[CompilerGenerated]
		set
		{
			keDXBwTX3C = value;
		}
	}

	public int MaximumDayInAdvance
	{
		[CompilerGenerated]
		get
		{
			return FgTX3Q919x;
		}
		[CompilerGenerated]
		set
		{
			FgTX3Q919x = value;
		}
	}

	[Range(0, int.MaxValue, ErrorMessageResourceName = "RangeMinNumberOfMinute", ErrorMessageResourceType = typeof(DtoTraduction))]
	public int MinimumNumberMinutes
	{
		[CompilerGenerated]
		get
		{
			return pcXX2UetAT;
		}
		[CompilerGenerated]
		set
		{
			pcXX2UetAT = value;
		}
	}

	[Range(0, int.MaxValue, ErrorMessageResourceName = "RangeMaxNumberOfHour", ErrorMessageResourceType = typeof(DtoTraduction))]
	public int MaximumNumberHours
	{
		[CompilerGenerated]
		get
		{
			return mDfXogVUVo;
		}
		[CompilerGenerated]
		set
		{
			mDfXogVUVo = value;
		}
	}

	[Range(0, 8, ErrorMessageResourceName = "RangeMaxNumberPlayer", ErrorMessageResourceType = typeof(DtoTraduction))]
	public int MaximumOfPlayer
	{
		[CompilerGenerated]
		get
		{
			return ueNXtjuBKO;
		}
		[CompilerGenerated]
		set
		{
			ueNXtjuBKO = value;
		}
	}

	public bool UseReservationFeature
	{
		[CompilerGenerated]
		get
		{
			return sjqXDcdq7y;
		}
		[CompilerGenerated]
		set
		{
			sjqXDcdq7y = value;
		}
	}

	public bool UseMembersReservationFeature
	{
		[CompilerGenerated]
		get
		{
			return iBlXvxxvF9;
		}
		[CompilerGenerated]
		set
		{
			iBlXvxxvF9 = value;
		}
	}

	public bool UseInvoicingFeature
	{
		[CompilerGenerated]
		get
		{
			return b9pXJmVCDd;
		}
		[CompilerGenerated]
		set
		{
			b9pXJmVCDd = value;
		}
	}

	public bool UseSimulatorRemoteFeature
	{
		[CompilerGenerated]
		get
		{
			return FICXebBl6K;
		}
		[CompilerGenerated]
		set
		{
			FICXebBl6K = value;
		}
	}

	public bool UseReservationOutsideOpeningHours
	{
		[CompilerGenerated]
		get
		{
			return y13XKHpo1V;
		}
		[CompilerGenerated]
		set
		{
			y13XKHpo1V = value;
		}
	}

	public DateTime? SiteOpeningDate
	{
		[CompilerGenerated]
		get
		{
			return DNBX769EUb;
		}
		[CompilerGenerated]
		set
		{
			DNBX769EUb = value;
		}
	}

	public DateTime? SiteClosingDate
	{
		[CompilerGenerated]
		get
		{
			return v4mX4INCxn;
		}
		[CompilerGenerated]
		set
		{
			v4mX4INCxn = value;
		}
	}

	public List<NotificationRecipientDto> NotificationRecipients
	{
		[CompilerGenerated]
		get
		{
			return EtqXrc5JD3;
		}
		[CompilerGenerated]
		set
		{
			EtqXrc5JD3 = value;
		}
	}

	[Display(ResourceType = typeof(DtoTraduction), Name = "SiteReservationSetting_DefaultNotifyAppointee", Description = "SiteReservationSetting_DefaultNotifyAppointee_Tooltip")]
	public bool DefaultNotifyAppointee
	{
		[CompilerGenerated]
		get
		{
			return JUSX8xOIrT;
		}
		[CompilerGenerated]
		set
		{
			JUSX8xOIrT = value;
		}
	}

	public List<TimeSpan> TimesToReminderBeforeAppointment
	{
		[CompilerGenerated]
		get
		{
			return WGcXlZwPxl;
		}
		[CompilerGenerated]
		set
		{
			WGcXlZwPxl = value;
		}
	}

	public string Address
	{
		[CompilerGenerated]
		get
		{
			return pqeXnwDvZ6;
		}
		[CompilerGenerated]
		set
		{
			pqeXnwDvZ6 = value;
		}
	}

	public SupportedCulture WebBrowserCulture
	{
		[CompilerGenerated]
		get
		{
			return ENQX1GSRj8;
		}
		[CompilerGenerated]
		set
		{
			ENQX1GSRj8 = value;
		}
	}

	public SiteReservationSettingForUpdateDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		JhKXxrWXVR = 15;
		ENQX1GSRj8 = SupportedCulture.EN_US;
		base._002Ector();
	}

	static SiteReservationSettingForUpdateDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		TimeToReminderStringFunc = (TimeSpan item) => (item.Minutes == 0) ? string.Format(so95DAFNMfktfjp4Dm.An6v7kuCGg(21352), (int)item.TotalHours) : string.Format(so95DAFNMfktfjp4Dm.An6v7kuCGg(21364), Math.Floor(item.TotalHours), item.Minutes);
	}
}
