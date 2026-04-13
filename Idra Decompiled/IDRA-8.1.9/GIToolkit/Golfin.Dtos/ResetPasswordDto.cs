using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using GIToolkit.Resources;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class ResetPasswordDto
{
	[CompilerGenerated]
	private string jMdpRbrVa6;

	[CompilerGenerated]
	private string YP1pAqqvS6;

	[CompilerGenerated]
	private string PIUpkB1f5O;

	[CompilerGenerated]
	private string ksmpaLnrb9;

	public string UserId
	{
		[CompilerGenerated]
		get
		{
			return jMdpRbrVa6;
		}
		[CompilerGenerated]
		set
		{
			jMdpRbrVa6 = value;
		}
	}

	public string Token
	{
		[CompilerGenerated]
		get
		{
			return YP1pAqqvS6;
		}
		[CompilerGenerated]
		set
		{
			YP1pAqqvS6 = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredNewPassword", ErrorMessageResourceType = typeof(DtoTraduction))]
	[StringLength(50, MinimumLength = 6, ErrorMessageResourceName = "StringLenghtNewPassword", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string NewPassword
	{
		[CompilerGenerated]
		get
		{
			return PIUpkB1f5O;
		}
		[CompilerGenerated]
		set
		{
			PIUpkB1f5O = value;
		}
	}

	[Compare("NewPassword", ErrorMessageResourceName = "CompareStringPassword", ErrorMessageResourceType = typeof(DtoTraduction))]
	[Required(ErrorMessageResourceName = "RequiredConfrimPassword", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string ConfirmPassword
	{
		[CompilerGenerated]
		get
		{
			return ksmpaLnrb9;
		}
		[CompilerGenerated]
		set
		{
			ksmpaLnrb9 = value;
		}
	}

	public ResetPasswordDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
