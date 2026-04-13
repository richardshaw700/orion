using System.Runtime.CompilerServices;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Model.Dtos.Contacts;

public class ContactListFilter
{
	[CompilerGenerated]
	private int? zO7vdt0H3a;

	[CompilerGenerated]
	private string ciZviGRPdK;

	[CompilerGenerated]
	private string Q7xvuya7hR;

	[CompilerGenerated]
	private string Fg4vVTOMtV;

	[CompilerGenerated]
	private bool? HZLvROQKY0;

	[CompilerGenerated]
	private int u1yvA0DhDf;

	[CompilerGenerated]
	private int JpbvklYjEJ;

	public int? SiteId
	{
		[CompilerGenerated]
		get
		{
			return zO7vdt0H3a;
		}
		[CompilerGenerated]
		set
		{
			zO7vdt0H3a = value;
		}
	}

	public string FullName
	{
		[CompilerGenerated]
		get
		{
			return ciZviGRPdK;
		}
		[CompilerGenerated]
		set
		{
			ciZviGRPdK = value;
		}
	}

	public string Email
	{
		[CompilerGenerated]
		get
		{
			return Q7xvuya7hR;
		}
		[CompilerGenerated]
		set
		{
			Q7xvuya7hR = value;
		}
	}

	public string PhoneNumber
	{
		[CompilerGenerated]
		get
		{
			return Fg4vVTOMtV;
		}
		[CompilerGenerated]
		set
		{
			Fg4vVTOMtV = value;
		}
	}

	public bool? HasSubscribedToNews
	{
		[CompilerGenerated]
		get
		{
			return HZLvROQKY0;
		}
		[CompilerGenerated]
		set
		{
			HZLvROQKY0 = value;
		}
	}

	public int CurrentPage
	{
		[CompilerGenerated]
		get
		{
			return u1yvA0DhDf;
		}
		[CompilerGenerated]
		set
		{
			u1yvA0DhDf = value;
		}
	}

	public int PageSize
	{
		[CompilerGenerated]
		get
		{
			return JpbvklYjEJ;
		}
		[CompilerGenerated]
		set
		{
			JpbvklYjEJ = value;
		}
	}

	public bool Compare(ContactListFilter filterToCompare)
	{
		if (filterToCompare == null)
		{
			return false;
		}
		if (SiteId == filterToCompare.SiteId && FullName == filterToCompare.FullName && Email == filterToCompare.Email)
		{
			return PhoneNumber == filterToCompare.PhoneNumber;
		}
		return false;
	}

	public void Clear()
	{
		FullName = string.Empty;
		Email = string.Empty;
		PhoneNumber = string.Empty;
		CurrentPage = 1;
		PageSize = 10;
	}

	public bool IsCleared()
	{
		if (string.IsNullOrWhiteSpace(FullName) && string.IsNullOrWhiteSpace(Email))
		{
			return string.IsNullOrWhiteSpace(PhoneNumber);
		}
		return false;
	}

	public ContactListFilter()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		u1yvA0DhDf = 1;
		JpbvklYjEJ = 10;
		base._002Ector();
	}
}
