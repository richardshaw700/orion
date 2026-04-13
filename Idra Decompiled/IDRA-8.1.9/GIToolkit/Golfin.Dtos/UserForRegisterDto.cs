using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using GIToolkit.Resources;
using Golfin.CustomValidation;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class UserForRegisterDto
{
	[CompilerGenerated]
	private string XlrWUVnJkg;

	[CompilerGenerated]
	private string nEnWm3ypb3;

	[CompilerGenerated]
	private string VAvWjM6B3L;

	[CompilerGenerated]
	private string lYuWfaaq2S;

	[CompilerGenerated]
	private string GM5WyxQth3;

	[CompilerGenerated]
	private string wFcWHEwv98;

	[CompilerGenerated]
	private string KN0WwTb9Kn;

	[CompilerGenerated]
	private string AiCWGI8n3M;

	[CompilerGenerated]
	private string PR3WCugOeA;

	[CompilerGenerated]
	private string CntWs7poyR;

	[CompilerGenerated]
	private string WvMWO2Y7J2;

	[CompilerGenerated]
	private bool FjtW9AxJEJ;

	[CompilerGenerated]
	private decimal wA2WhZGw6h;

	[CompilerGenerated]
	private bool bw0WQ5LbAC;

	[CompilerGenerated]
	private bool ejPWTLvsVQ;

	[CompilerGenerated]
	private bool uXLWLWDcZY;

	[CompilerGenerated]
	private DateTime mrpW0N1Zsf;

	[CompilerGenerated]
	private string[] bUyWZpZeBy;

	[CompilerGenerated]
	private string eVXWMvoe8C;

	[CompilerGenerated]
	private int? Ai7WSwiMHT;

	public string Username
	{
		[CompilerGenerated]
		get
		{
			return XlrWUVnJkg;
		}
		[CompilerGenerated]
		set
		{
			XlrWUVnJkg = value;
		}
	}

	[CustomEmailAddress(ErrorMessageResourceName = "RegexEmail", ErrorMessageResourceType = typeof(DtoTraduction))]
	[Required(ErrorMessageResourceName = "RequiredEmail", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string Email
	{
		[CompilerGenerated]
		get
		{
			return nEnWm3ypb3;
		}
		[CompilerGenerated]
		set
		{
			nEnWm3ypb3 = value;
		}
	}

	[StringLength(50, MinimumLength = 6, ErrorMessageResourceName = "StringLenghtNewPassword", ErrorMessageResourceType = typeof(DtoTraduction))]
	[Required(ErrorMessageResourceName = "RequiredPassword", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string Password
	{
		[CompilerGenerated]
		get
		{
			return VAvWjM6B3L;
		}
		[CompilerGenerated]
		set
		{
			VAvWjM6B3L = value;
		}
	}

	public string CardNumber
	{
		[CompilerGenerated]
		get
		{
			return lYuWfaaq2S;
		}
		[CompilerGenerated]
		set
		{
			lYuWfaaq2S = value;
		}
	}

	public string Language
	{
		[CompilerGenerated]
		get
		{
			return GM5WyxQth3;
		}
		[CompilerGenerated]
		set
		{
			GM5WyxQth3 = value;
		}
	}

	public string FirstName
	{
		[CompilerGenerated]
		get
		{
			return wFcWHEwv98;
		}
		[CompilerGenerated]
		set
		{
			wFcWHEwv98 = value;
		}
	}

	public string LastName
	{
		[CompilerGenerated]
		get
		{
			return KN0WwTb9Kn;
		}
		[CompilerGenerated]
		set
		{
			KN0WwTb9Kn = value;
		}
	}

	public string Gender
	{
		[CompilerGenerated]
		get
		{
			return AiCWGI8n3M;
		}
		[CompilerGenerated]
		set
		{
			AiCWGI8n3M = value;
		}
	}

	public string AvatarName
	{
		[CompilerGenerated]
		get
		{
			return PR3WCugOeA;
		}
		[CompilerGenerated]
		set
		{
			PR3WCugOeA = value;
		}
	}

	public string Country
	{
		[CompilerGenerated]
		get
		{
			return CntWs7poyR;
		}
		[CompilerGenerated]
		set
		{
			CntWs7poyR = value;
		}
	}

	public string Dexterity
	{
		[CompilerGenerated]
		get
		{
			return WvMWO2Y7J2;
		}
		[CompilerGenerated]
		set
		{
			WvMWO2Y7J2 = value;
		}
	}

	public bool IsActive
	{
		[CompilerGenerated]
		get
		{
			return FjtW9AxJEJ;
		}
		[CompilerGenerated]
		set
		{
			FjtW9AxJEJ = value;
		}
	}

	public decimal Balance
	{
		[CompilerGenerated]
		get
		{
			return wA2WhZGw6h;
		}
		[CompilerGenerated]
		set
		{
			wA2WhZGw6h = value;
		}
	}

	public bool IsTemporaryMember
	{
		[CompilerGenerated]
		get
		{
			return bw0WQ5LbAC;
		}
		[CompilerGenerated]
		set
		{
			bw0WQ5LbAC = value;
		}
	}

	public bool HasAcceptTermsAndConditions
	{
		[CompilerGenerated]
		get
		{
			return ejPWTLvsVQ;
		}
		[CompilerGenerated]
		set
		{
			ejPWTLvsVQ = value;
		}
	}

	public bool HasSubscribedToNews
	{
		[CompilerGenerated]
		get
		{
			return uXLWLWDcZY;
		}
		[CompilerGenerated]
		set
		{
			uXLWLWDcZY = value;
		}
	}

	public DateTime ActiveSince
	{
		[CompilerGenerated]
		get
		{
			return mrpW0N1Zsf;
		}
		[CompilerGenerated]
		set
		{
			mrpW0N1Zsf = value;
		}
	}

	public string[] Roles
	{
		[CompilerGenerated]
		get
		{
			return bUyWZpZeBy;
		}
		[CompilerGenerated]
		set
		{
			bUyWZpZeBy = value;
		}
	}

	[CustomPhone(ErrorMessageResourceName = "RegexPhone", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string PhoneNumber
	{
		[CompilerGenerated]
		get
		{
			return eVXWMvoe8C;
		}
		[CompilerGenerated]
		set
		{
			eVXWMvoe8C = value;
		}
	}

	public int? SiteId
	{
		[CompilerGenerated]
		get
		{
			return Ai7WSwiMHT;
		}
		[CompilerGenerated]
		set
		{
			Ai7WSwiMHT = value;
		}
	}

	public UserForRegisterDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		ActiveSince = DateTime.UtcNow;
		IsActive = true;
	}
}
