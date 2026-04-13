using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using GIToolkit.Resources;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class ChangePasswordDto
{
	[CompilerGenerated]
	private string fViFoQ85st;

	[CompilerGenerated]
	private string RwiFtDEg0A;

	[CompilerGenerated]
	private string Q3PFDZ41Pa;

	[Required(ErrorMessageResourceName = "RequiredOldPassword", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string OldPassword
	{
		[CompilerGenerated]
		get
		{
			return fViFoQ85st;
		}
		[CompilerGenerated]
		set
		{
			fViFoQ85st = value;
		}
	}

	[StringLength(50, MinimumLength = 6, ErrorMessageResourceName = "StringLenghtNewPassword", ErrorMessageResourceType = typeof(DtoTraduction))]
	[Required(ErrorMessageResourceName = "RequiredNewPassword", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string NewPassword
	{
		[CompilerGenerated]
		get
		{
			return RwiFtDEg0A;
		}
		[CompilerGenerated]
		set
		{
			RwiFtDEg0A = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredConfrimPassword", ErrorMessageResourceType = typeof(DtoTraduction))]
	[Compare("NewPassword", ErrorMessageResourceName = "CompareStringPassword", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string ConfirmPassword
	{
		[CompilerGenerated]
		get
		{
			return Q3PFDZ41Pa;
		}
		[CompilerGenerated]
		set
		{
			Q3PFDZ41Pa = value;
		}
	}

	public ChangePasswordDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
