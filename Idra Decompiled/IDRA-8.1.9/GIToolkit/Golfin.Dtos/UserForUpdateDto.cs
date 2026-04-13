using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class UserForUpdateDto : BaseUserForUpdateDto
{
	[CompilerGenerated]
	private string Yh2WgHI7fv;

	[CompilerGenerated]
	private string jJtWNaxy2I;

	public string Password
	{
		[CompilerGenerated]
		get
		{
			return Yh2WgHI7fv;
		}
		[CompilerGenerated]
		set
		{
			Yh2WgHI7fv = value;
		}
	}

	[RegularExpression("^(\\+\\d{1,2}\\s)?\\(?\\d{3}\\)?[\\s.-]?\\d{3}[\\s.-]?\\d{4}$", ErrorMessage = "Invalid Canadian or American phone number.")]
	public string PhoneNumber
	{
		[CompilerGenerated]
		get
		{
			return jJtWNaxy2I;
		}
		[CompilerGenerated]
		set
		{
			jJtWNaxy2I = value;
		}
	}

	public UserForUpdateDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
