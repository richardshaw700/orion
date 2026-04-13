using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using GIToolkit.Resources;
using GIToolkit.Services;
using Golfin.CustomValidation;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class BaseUserForUpdateDto
{
	[CompilerGenerated]
	private string RPvXqf5dJ6;

	[CompilerGenerated]
	private string GFaXPbkd9G;

	[CompilerGenerated]
	private string lbOXzNH73q;

	[CompilerGenerated]
	private SupportedCulture? J2NFdWJ7Pp;

	[CompilerGenerated]
	private string Bx1FiqK7Li;

	[CompilerGenerated]
	private string QVdFuPSJWS;

	[CompilerGenerated]
	private string nBEFVOrgCK;

	[CompilerGenerated]
	private string SolFRCxkMB;

	[CompilerGenerated]
	private string tBfFAoiGeL;

	[CompilerGenerated]
	private string QXcFkP1XY6;

	[CompilerGenerated]
	private bool Oh3Fagn6iE;

	[CompilerGenerated]
	private bool D1oFXWqoWG;

	[CompilerGenerated]
	private bool xtQFFunbxI;

	[CompilerGenerated]
	private List<string> XoDFpOIjnI;

	[CompilerGenerated]
	private bool TDvFWCrUPs;

	[CompilerGenerated]
	private SiteLiteForProfileDto MNIFYubd2k;

	public string Username
	{
		[CompilerGenerated]
		get
		{
			return RPvXqf5dJ6;
		}
		[CompilerGenerated]
		set
		{
			RPvXqf5dJ6 = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredEmail", ErrorMessageResourceType = typeof(DtoTraduction))]
	[CustomEmailAddress(ErrorMessageResourceName = "RegexEmail", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string Email
	{
		[CompilerGenerated]
		get
		{
			return GFaXPbkd9G;
		}
		[CompilerGenerated]
		set
		{
			GFaXPbkd9G = value;
		}
	}

	[CardNumberLength(21, 4, ErrorMessageResourceName = "StringLengthCardNumber", ErrorMessageResourceType = typeof(DtoTraduction))]
	public virtual string CardNumber
	{
		[CompilerGenerated]
		get
		{
			return lbOXzNH73q;
		}
		[CompilerGenerated]
		set
		{
			lbOXzNH73q = value;
		}
	}

	public SupportedCulture? Language
	{
		[CompilerGenerated]
		get
		{
			return J2NFdWJ7Pp;
		}
		[CompilerGenerated]
		set
		{
			J2NFdWJ7Pp = value;
		}
	}

	public string FirstName
	{
		[CompilerGenerated]
		get
		{
			return Bx1FiqK7Li;
		}
		[CompilerGenerated]
		set
		{
			Bx1FiqK7Li = value;
		}
	}

	public string LastName
	{
		[CompilerGenerated]
		get
		{
			return QVdFuPSJWS;
		}
		[CompilerGenerated]
		set
		{
			QVdFuPSJWS = value;
		}
	}

	public string Gender
	{
		[CompilerGenerated]
		get
		{
			return nBEFVOrgCK;
		}
		[CompilerGenerated]
		set
		{
			nBEFVOrgCK = value;
		}
	}

	public string AvatarName
	{
		[CompilerGenerated]
		get
		{
			return SolFRCxkMB;
		}
		[CompilerGenerated]
		set
		{
			SolFRCxkMB = value;
		}
	}

	public string Country
	{
		[CompilerGenerated]
		get
		{
			return tBfFAoiGeL;
		}
		[CompilerGenerated]
		set
		{
			tBfFAoiGeL = value;
		}
	}

	public string Dexterity
	{
		[CompilerGenerated]
		get
		{
			return QXcFkP1XY6;
		}
		[CompilerGenerated]
		set
		{
			QXcFkP1XY6 = value;
		}
	}

	public bool IsTemporaryMember
	{
		[CompilerGenerated]
		get
		{
			return Oh3Fagn6iE;
		}
		[CompilerGenerated]
		set
		{
			Oh3Fagn6iE = value;
		}
	}

	public bool HasAcceptTermsAndConditions
	{
		[CompilerGenerated]
		get
		{
			return D1oFXWqoWG;
		}
		[CompilerGenerated]
		set
		{
			D1oFXWqoWG = value;
		}
	}

	public bool HasSubscribedToNews
	{
		[CompilerGenerated]
		get
		{
			return xtQFFunbxI;
		}
		[CompilerGenerated]
		set
		{
			xtQFFunbxI = value;
		}
	}

	public List<string> Roles
	{
		[CompilerGenerated]
		get
		{
			return XoDFpOIjnI;
		}
		[CompilerGenerated]
		set
		{
			XoDFpOIjnI = value;
		}
	}

	public bool IsActive
	{
		[CompilerGenerated]
		get
		{
			return TDvFWCrUPs;
		}
		[CompilerGenerated]
		set
		{
			TDvFWCrUPs = value;
		}
	}

	public SiteLiteForProfileDto SiteLite
	{
		[CompilerGenerated]
		get
		{
			return MNIFYubd2k;
		}
		[CompilerGenerated]
		set
		{
			MNIFYubd2k = value;
		}
	}

	public BaseUserForUpdateDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
