using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using GIToolkit.Resources;
using Golfin.CustomValidation;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class NewUserFromAdminDto
{
	[CompilerGenerated]
	private string zeCFLUPRyp;

	[CompilerGenerated]
	private string wlIF07K7v7;

	[CompilerGenerated]
	private string TkDFZY7EtW;

	[CompilerGenerated]
	private string ORvFMKlHab;

	[CompilerGenerated]
	private string eAPFSjOdRX;

	[CompilerGenerated]
	private string k1LFgpaQBf;

	[CompilerGenerated]
	private SiteLiteDto RYhFNqZRQH;

	[CompilerGenerated]
	private string Oj7Fct6ubg;

	[CompilerGenerated]
	private string OCcFIkQxIm;

	[CompilerGenerated]
	private string HRQFqiUbHc;

	[CompilerGenerated]
	private string et5FPQVOC3;

	[CompilerGenerated]
	private bool mMvFzekv1l;

	[CompilerGenerated]
	private bool AJrpd9Fpco;

	[CompilerGenerated]
	private bool MKIpiGB4RD;

	[CompilerGenerated]
	private bool xi7puqoV45;

	[CompilerGenerated]
	private DateTime KYypVeouEf;

	public string Username
	{
		[CompilerGenerated]
		get
		{
			return zeCFLUPRyp;
		}
		[CompilerGenerated]
		set
		{
			zeCFLUPRyp = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredEmail", ErrorMessageResourceType = typeof(DtoTraduction))]
	[CustomEmailAddress(ErrorMessageResourceName = "RegexEmail", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string Email
	{
		[CompilerGenerated]
		get
		{
			return wlIF07K7v7;
		}
		[CompilerGenerated]
		set
		{
			wlIF07K7v7 = value;
		}
	}

	[StringLength(50, MinimumLength = 6, ErrorMessageResourceName = "StringLenghtNewPassword", ErrorMessageResourceType = typeof(DtoTraduction))]
	[Required(ErrorMessageResourceName = "RequiredPassword", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string Password
	{
		[CompilerGenerated]
		get
		{
			return TkDFZY7EtW;
		}
		[CompilerGenerated]
		set
		{
			TkDFZY7EtW = value;
		}
	}

	[StringLength(21, MinimumLength = 10, ErrorMessageResourceName = "StringLengthCardNumber", ErrorMessageResourceType = typeof(DtoTraduction))]
	[Required(ErrorMessageResourceName = "RequiredCardNumber", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string CardNumber
	{
		[CompilerGenerated]
		get
		{
			return ORvFMKlHab;
		}
		[CompilerGenerated]
		set
		{
			ORvFMKlHab = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredFullName", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string FullName
	{
		[CompilerGenerated]
		get
		{
			return eAPFSjOdRX;
		}
		[CompilerGenerated]
		set
		{
			eAPFSjOdRX = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredRole", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string Role
	{
		[CompilerGenerated]
		get
		{
			return k1LFgpaQBf;
		}
		[CompilerGenerated]
		set
		{
			k1LFgpaQBf = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredSite", ErrorMessageResourceType = typeof(DtoTraduction))]
	public SiteLiteDto Site
	{
		[CompilerGenerated]
		get
		{
			return RYhFNqZRQH;
		}
		[CompilerGenerated]
		set
		{
			RYhFNqZRQH = value;
		}
	}

	public string Gender
	{
		[CompilerGenerated]
		get
		{
			return Oj7Fct6ubg;
		}
		[CompilerGenerated]
		set
		{
			Oj7Fct6ubg = value;
		}
	}

	public string AvatarName
	{
		[CompilerGenerated]
		get
		{
			return OCcFIkQxIm;
		}
		[CompilerGenerated]
		set
		{
			OCcFIkQxIm = value;
		}
	}

	public string Country
	{
		[CompilerGenerated]
		get
		{
			return HRQFqiUbHc;
		}
		[CompilerGenerated]
		set
		{
			HRQFqiUbHc = value;
		}
	}

	public string Dexterity
	{
		[CompilerGenerated]
		get
		{
			return et5FPQVOC3;
		}
		[CompilerGenerated]
		set
		{
			et5FPQVOC3 = value;
		}
	}

	public bool IsActive
	{
		[CompilerGenerated]
		get
		{
			return mMvFzekv1l;
		}
		[CompilerGenerated]
		private set
		{
			mMvFzekv1l = value;
		}
	}

	public bool IsTemporaryMember
	{
		[CompilerGenerated]
		get
		{
			return AJrpd9Fpco;
		}
		[CompilerGenerated]
		private set
		{
			AJrpd9Fpco = value;
		}
	}

	public bool HasAcceptTermsAndConditions
	{
		[CompilerGenerated]
		get
		{
			return MKIpiGB4RD;
		}
		[CompilerGenerated]
		private set
		{
			MKIpiGB4RD = value;
		}
	}

	public bool HasSubscribedToNews
	{
		[CompilerGenerated]
		get
		{
			return xi7puqoV45;
		}
		[CompilerGenerated]
		private set
		{
			xi7puqoV45 = value;
		}
	}

	public DateTime ActiveSince
	{
		[CompilerGenerated]
		get
		{
			return KYypVeouEf;
		}
		[CompilerGenerated]
		private set
		{
			KYypVeouEf = value;
		}
	}

	public NewUserFromAdminDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		IsActive = true;
		IsTemporaryMember = false;
		HasAcceptTermsAndConditions = true;
		HasSubscribedToNews = true;
		Site = new SiteLiteDto();
	}
}
