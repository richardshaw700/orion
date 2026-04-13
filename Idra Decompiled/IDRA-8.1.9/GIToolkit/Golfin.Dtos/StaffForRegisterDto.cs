using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using GIToolkit.Resources;
using Golfin.CustomValidation;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class StaffForRegisterDto
{
	[CompilerGenerated]
	private string ubJpFRaOrY;

	[CompilerGenerated]
	private string ulnppCE0n4;

	[CompilerGenerated]
	private string rcGpWQ7vbl;

	[CompilerGenerated]
	private string wMYpY9GPji;

	[CompilerGenerated]
	private string FXrpxYyFDH;

	[CompilerGenerated]
	private string VIjp6QE9Un;

	[CompilerGenerated]
	private string Q0npE5ZsNg;

	[CompilerGenerated]
	private string dCOpB797cp;

	[CompilerGenerated]
	private string v5wp3IKRiS;

	[CompilerGenerated]
	private string tFgp29Tj8p;

	[CompilerGenerated]
	private bool tQ3poEwuSo;

	[CompilerGenerated]
	private decimal x1iptioWGZ;

	[CompilerGenerated]
	private bool GZBpDAdtv7;

	[CompilerGenerated]
	private bool XirpvmHvKA;

	[CompilerGenerated]
	private bool nR3pJMllnF;

	[CompilerGenerated]
	private DateTime K8HpewYxJy;

	[CompilerGenerated]
	private string[] f8IpKAtW93;

	[CompilerGenerated]
	private int? IF5p7ex0G1;

	public string Username
	{
		[CompilerGenerated]
		get
		{
			return ubJpFRaOrY;
		}
		[CompilerGenerated]
		set
		{
			ubJpFRaOrY = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredEmail", ErrorMessageResourceType = typeof(DtoTraduction))]
	[CustomEmailAddress(ErrorMessageResourceName = "RegexEmail", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string Email
	{
		[CompilerGenerated]
		get
		{
			return ulnppCE0n4;
		}
		[CompilerGenerated]
		set
		{
			ulnppCE0n4 = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredPassword", ErrorMessageResourceType = typeof(DtoTraduction))]
	[StringLength(50, MinimumLength = 6, ErrorMessageResourceName = "StringLenghtNewPassword", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string Password
	{
		[CompilerGenerated]
		get
		{
			return rcGpWQ7vbl;
		}
		[CompilerGenerated]
		set
		{
			rcGpWQ7vbl = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredCardNumber", ErrorMessageResourceType = typeof(DtoTraduction))]
	[StringLength(21, MinimumLength = 4, ErrorMessageResourceName = "StringLengthCardNumber", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string CardNumber
	{
		[CompilerGenerated]
		get
		{
			return wMYpY9GPji;
		}
		[CompilerGenerated]
		set
		{
			wMYpY9GPji = value;
		}
	}

	public string FirstName
	{
		[CompilerGenerated]
		get
		{
			return FXrpxYyFDH;
		}
		[CompilerGenerated]
		set
		{
			FXrpxYyFDH = value;
		}
	}

	public string LastName
	{
		[CompilerGenerated]
		get
		{
			return VIjp6QE9Un;
		}
		[CompilerGenerated]
		set
		{
			VIjp6QE9Un = value;
		}
	}

	public string Gender
	{
		[CompilerGenerated]
		get
		{
			return Q0npE5ZsNg;
		}
		[CompilerGenerated]
		set
		{
			Q0npE5ZsNg = value;
		}
	}

	public string AvatarName
	{
		[CompilerGenerated]
		get
		{
			return dCOpB797cp;
		}
		[CompilerGenerated]
		set
		{
			dCOpB797cp = value;
		}
	}

	public string Country
	{
		[CompilerGenerated]
		get
		{
			return v5wp3IKRiS;
		}
		[CompilerGenerated]
		set
		{
			v5wp3IKRiS = value;
		}
	}

	public string Dexterity
	{
		[CompilerGenerated]
		get
		{
			return tFgp29Tj8p;
		}
		[CompilerGenerated]
		set
		{
			tFgp29Tj8p = value;
		}
	}

	public bool IsActive
	{
		[CompilerGenerated]
		get
		{
			return tQ3poEwuSo;
		}
		[CompilerGenerated]
		set
		{
			tQ3poEwuSo = value;
		}
	}

	public decimal Balance
	{
		[CompilerGenerated]
		get
		{
			return x1iptioWGZ;
		}
		[CompilerGenerated]
		set
		{
			x1iptioWGZ = value;
		}
	}

	public bool IsTemporaryMember
	{
		[CompilerGenerated]
		get
		{
			return GZBpDAdtv7;
		}
		[CompilerGenerated]
		set
		{
			GZBpDAdtv7 = value;
		}
	}

	public bool HasAcceptTermsAndConditions
	{
		[CompilerGenerated]
		get
		{
			return XirpvmHvKA;
		}
		[CompilerGenerated]
		set
		{
			XirpvmHvKA = value;
		}
	}

	public bool HasSubscribedToNews
	{
		[CompilerGenerated]
		get
		{
			return nR3pJMllnF;
		}
		[CompilerGenerated]
		set
		{
			nR3pJMllnF = value;
		}
	}

	public DateTime ActiveSince
	{
		[CompilerGenerated]
		get
		{
			return K8HpewYxJy;
		}
		[CompilerGenerated]
		set
		{
			K8HpewYxJy = value;
		}
	}

	public string[] Roles
	{
		[CompilerGenerated]
		get
		{
			return f8IpKAtW93;
		}
		[CompilerGenerated]
		set
		{
			f8IpKAtW93 = value;
		}
	}

	public int? SiteId
	{
		[CompilerGenerated]
		get
		{
			return IF5p7ex0G1;
		}
		[CompilerGenerated]
		set
		{
			IF5p7ex0G1 = value;
		}
	}

	public StaffForRegisterDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		IsActive = true;
	}
}
