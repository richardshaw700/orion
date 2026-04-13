using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using GIToolkit.Resources;
using GIToolkit.Services;
using Golfin.CustomValidation;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class AppointmentReccurenceForCreationDto : IAppointmentContactInfo
{
	[CompilerGenerated]
	private int kxPiyPEG0c;

	[CompilerGenerated]
	private DateTime iC7iHKUqxr;

	[CompilerGenerated]
	private DateTime JfeiwvxSdl;

	[CompilerGenerated]
	private IEnumerable<int> Vr3iG31hOR;

	[CompilerGenerated]
	private int FaoiC6KUIo;

	[CompilerGenerated]
	private int LHfisdi4s1;

	[CompilerGenerated]
	private DateTime? XKciOn1Wqr;

	[CompilerGenerated]
	private int QDgi92xtOJ;

	[CompilerGenerated]
	private string BCTihXi6wa;

	[CompilerGenerated]
	private bool dl7iQvjgnq;

	private string N9JiT1301l;

	private string Xu3iLCdOCJ;

	[CompilerGenerated]
	private string Dvci0UTKxU;

	[CompilerGenerated]
	private bool LJqiZrOGZb;

	[CompilerGenerated]
	private bool CROiMOQLKJ;

	[CompilerGenerated]
	private bool FOfiSHtFrJ;

	[CompilerGenerated]
	private string I9qigLNhj1;

	[CompilerGenerated]
	private TimeSpan lnAiNPY6go;

	[CompilerGenerated]
	private SupportedCulture BLOic9c0wJ;

	[Required(ErrorMessageResourceName = "RequiredSiteId", ErrorMessageResourceType = typeof(DtoTraduction))]
	public int SiteId
	{
		[CompilerGenerated]
		get
		{
			return kxPiyPEG0c;
		}
		[CompilerGenerated]
		set
		{
			kxPiyPEG0c = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredStartDate", ErrorMessageResourceType = typeof(DtoTraduction))]
	public DateTime StartDate
	{
		[CompilerGenerated]
		get
		{
			return iC7iHKUqxr;
		}
		[CompilerGenerated]
		set
		{
			iC7iHKUqxr = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredEndDate", ErrorMessageResourceType = typeof(DtoTraduction))]
	public DateTime EndDate
	{
		[CompilerGenerated]
		get
		{
			return JfeiwvxSdl;
		}
		[CompilerGenerated]
		set
		{
			JfeiwvxSdl = value;
		}
	}

	[NotNullOrEmptyCollection(ErrorMessageResourceName = "NotNullOrEmptyCollectionDays", ErrorMessageResourceType = typeof(DtoTraduction))]
	public IEnumerable<int> Days
	{
		[CompilerGenerated]
		get
		{
			return Vr3iG31hOR;
		}
		[CompilerGenerated]
		set
		{
			Vr3iG31hOR = value;
		}
	}

	[Range(0, int.MaxValue, ErrorMessageResourceName = "MinRangeHour", ErrorMessageResourceType = typeof(DtoTraduction))]
	public int DurationHour
	{
		[CompilerGenerated]
		get
		{
			return FaoiC6KUIo;
		}
		[CompilerGenerated]
		set
		{
			FaoiC6KUIo = value;
		}
	}

	public int DurationMin
	{
		[CompilerGenerated]
		get
		{
			return LHfisdi4s1;
		}
		[CompilerGenerated]
		set
		{
			LHfisdi4s1 = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredTeeTime", ErrorMessageResourceType = typeof(DtoTraduction))]
	public DateTime? StartTime
	{
		[CompilerGenerated]
		get
		{
			return XKciOn1Wqr;
		}
		[CompilerGenerated]
		set
		{
			XKciOn1Wqr = value;
		}
	}

	[Range(1, 8, ErrorMessageResourceName = "RangeNbPlayer", ErrorMessageResourceType = typeof(DtoTraduction))]
	[Required(ErrorMessageResourceName = "RequiredNbPlayer", ErrorMessageResourceType = typeof(DtoTraduction))]
	public int NumberOfPlayers
	{
		[CompilerGenerated]
		get
		{
			return QDgi92xtOJ;
		}
		[CompilerGenerated]
		set
		{
			QDgi92xtOJ = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredTitleReservation", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string Title
	{
		[CompilerGenerated]
		get
		{
			return BCTihXi6wa;
		}
		[CompilerGenerated]
		set
		{
			BCTihXi6wa = value;
		}
	}

	public bool IsFirstTimePlay
	{
		[CompilerGenerated]
		get
		{
			return dl7iQvjgnq;
		}
		[CompilerGenerated]
		set
		{
			dl7iQvjgnq = value;
		}
	}

	[CustomEmailAddress(ErrorMessageResourceName = "RegexEmail", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string Email
	{
		get
		{
			return N9JiT1301l;
		}
		set
		{
			N9JiT1301l = (string.IsNullOrWhiteSpace(value) ? null : value);
		}
	}

	[CustomPhone(ErrorMessageResourceName = "RegexPhone", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string Phone
	{
		get
		{
			return Xu3iLCdOCJ;
		}
		set
		{
			Xu3iLCdOCJ = (string.IsNullOrWhiteSpace(value) ? null : value);
		}
	}

	public string Notes
	{
		[CompilerGenerated]
		get
		{
			return Dvci0UTKxU;
		}
		[CompilerGenerated]
		set
		{
			Dvci0UTKxU = value;
		}
	}

	public bool NotifyRecipient
	{
		[CompilerGenerated]
		get
		{
			return LJqiZrOGZb;
		}
		[CompilerGenerated]
		set
		{
			LJqiZrOGZb = value;
		}
	}

	public bool ShouldAddAsContact
	{
		[CompilerGenerated]
		get
		{
			return CROiMOQLKJ;
		}
		[CompilerGenerated]
		set
		{
			CROiMOQLKJ = value;
		}
	}

	public bool HasSubscribedToNews
	{
		[CompilerGenerated]
		get
		{
			return FOfiSHtFrJ;
		}
		[CompilerGenerated]
		set
		{
			FOfiSHtFrJ = value;
		}
	}

	public string UserId
	{
		[CompilerGenerated]
		get
		{
			return I9qigLNhj1;
		}
		[CompilerGenerated]
		set
		{
			I9qigLNhj1 = value;
		}
	}

	public TimeSpan UserTimeZoneOffset
	{
		[CompilerGenerated]
		get
		{
			return lnAiNPY6go;
		}
		[CompilerGenerated]
		set
		{
			lnAiNPY6go = value;
		}
	}

	public SupportedCulture WebBrowserCulture
	{
		[CompilerGenerated]
		get
		{
			return BLOic9c0wJ;
		}
		[CompilerGenerated]
		set
		{
			BLOic9c0wJ = value;
		}
	}

	public AppointmentReccurenceForCreationDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		LJqiZrOGZb = true;
		BLOic9c0wJ = SupportedCulture.EN_US;
		base._002Ector();
	}
}
