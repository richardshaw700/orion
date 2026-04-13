using System;
using System.Runtime.CompilerServices;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Model.Dtos.Contacts;

public class ContactDto
{
	[CompilerGenerated]
	private int iQeDCQH0Ue;

	[CompilerGenerated]
	private int o12DsDFpEZ;

	[CompilerGenerated]
	private string Sb9DOpvDn7;

	[CompilerGenerated]
	private string WSHD9t8isp;

	[CompilerGenerated]
	private string WhFDhYZOr0;

	[CompilerGenerated]
	private string FEwDQrVVHo;

	[CompilerGenerated]
	private bool Ha3DTmeAej;

	[CompilerGenerated]
	private DateTime? fimDLfYkrS;

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return iQeDCQH0Ue;
		}
		[CompilerGenerated]
		set
		{
			iQeDCQH0Ue = value;
		}
	}

	public int SiteId
	{
		[CompilerGenerated]
		get
		{
			return o12DsDFpEZ;
		}
		[CompilerGenerated]
		set
		{
			o12DsDFpEZ = value;
		}
	}

	public string FirstName
	{
		[CompilerGenerated]
		get
		{
			return Sb9DOpvDn7;
		}
		[CompilerGenerated]
		set
		{
			Sb9DOpvDn7 = value;
		}
	}

	public string LastName
	{
		[CompilerGenerated]
		get
		{
			return WSHD9t8isp;
		}
		[CompilerGenerated]
		set
		{
			WSHD9t8isp = value;
		}
	}

	public string FullName => FirstName + so95DAFNMfktfjp4Dm.An6v7kuCGg(1128) + LastName;

	public string Email
	{
		[CompilerGenerated]
		get
		{
			return WhFDhYZOr0;
		}
		[CompilerGenerated]
		set
		{
			WhFDhYZOr0 = value;
		}
	}

	public string PhoneNumber
	{
		[CompilerGenerated]
		get
		{
			return FEwDQrVVHo;
		}
		[CompilerGenerated]
		set
		{
			FEwDQrVVHo = value;
		}
	}

	public bool HasSubscribedToNews
	{
		[CompilerGenerated]
		get
		{
			return Ha3DTmeAej;
		}
		[CompilerGenerated]
		set
		{
			Ha3DTmeAej = value;
		}
	}

	public DateTime? SubscribedToNewsAt
	{
		[CompilerGenerated]
		get
		{
			return fimDLfYkrS;
		}
		[CompilerGenerated]
		set
		{
			fimDLfYkrS = value;
		}
	}

	public void CopyFrom(ContactDto from)
	{
		Id = from.Id;
		SiteId = from.SiteId;
		FirstName = from.FirstName;
		LastName = from.LastName;
		Email = from.Email;
		PhoneNumber = from.PhoneNumber;
		HasSubscribedToNews = from.HasSubscribedToNews;
	}

	public ContactDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
