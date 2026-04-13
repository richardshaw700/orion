using System.Runtime.CompilerServices;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Model.Dtos.Contacts;

public class CreateContactDto
{
	[CompilerGenerated]
	private int WxivaH5VYW;

	[CompilerGenerated]
	private string OFLvX712Tn;

	[CompilerGenerated]
	private string YxmvFY4QIg;

	[CompilerGenerated]
	private string B7avpBWq9S;

	[CompilerGenerated]
	private string V1lvWZFMQ0;

	[CompilerGenerated]
	private string GYOvYqCvsZ;

	[CompilerGenerated]
	private bool oCgvxlnUu4;

	public int SiteId
	{
		[CompilerGenerated]
		get
		{
			return WxivaH5VYW;
		}
		[CompilerGenerated]
		set
		{
			WxivaH5VYW = value;
		}
	}

	public string FirstName
	{
		[CompilerGenerated]
		get
		{
			return OFLvX712Tn;
		}
		[CompilerGenerated]
		set
		{
			OFLvX712Tn = value;
		}
	}

	public string LastName
	{
		[CompilerGenerated]
		get
		{
			return YxmvFY4QIg;
		}
		[CompilerGenerated]
		set
		{
			YxmvFY4QIg = value;
		}
	}

	public string FullName
	{
		[CompilerGenerated]
		get
		{
			return B7avpBWq9S;
		}
		[CompilerGenerated]
		set
		{
			B7avpBWq9S = value;
		}
	}

	public string Email
	{
		[CompilerGenerated]
		get
		{
			return V1lvWZFMQ0;
		}
		[CompilerGenerated]
		set
		{
			V1lvWZFMQ0 = value;
		}
	}

	public string PhoneNumber
	{
		[CompilerGenerated]
		get
		{
			return GYOvYqCvsZ;
		}
		[CompilerGenerated]
		set
		{
			GYOvYqCvsZ = value;
		}
	}

	public bool HasSubscribedToNews
	{
		[CompilerGenerated]
		get
		{
			return oCgvxlnUu4;
		}
		[CompilerGenerated]
		set
		{
			oCgvxlnUu4 = value;
		}
	}

	public static CreateContactDto MapFrom(ContactDto from, int siteId)
	{
		return new CreateContactDto
		{
			SiteId = siteId,
			Email = from.Email,
			PhoneNumber = from.PhoneNumber,
			FirstName = from.FirstName,
			LastName = from.LastName,
			FullName = from.FullName,
			HasSubscribedToNews = from.HasSubscribedToNews
		};
	}

	public CreateContactDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
