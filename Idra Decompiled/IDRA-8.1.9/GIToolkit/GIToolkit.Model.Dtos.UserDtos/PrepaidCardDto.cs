using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using GIToolkit.Resources;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Model.Dtos.UserDtos;

public class PrepaidCardDto
{
	[CompilerGenerated]
	private string sZhDoKI1WD;

	[CompilerGenerated]
	private string xvMDtJMs1a;

	[CompilerGenerated]
	private string qePDDenGmQ;

	[CompilerGenerated]
	private decimal QriDvsa9tx;

	[CompilerGenerated]
	private decimal? Qh0DJ7XXwM;

	[CompilerGenerated]
	private string JgYDeH5F8n;

	public string FirstName
	{
		[CompilerGenerated]
		get
		{
			return sZhDoKI1WD;
		}
		[CompilerGenerated]
		set
		{
			sZhDoKI1WD = value;
		}
	}

	public string LastName
	{
		[CompilerGenerated]
		get
		{
			return xvMDtJMs1a;
		}
		[CompilerGenerated]
		set
		{
			xvMDtJMs1a = value;
		}
	}

	[StringLength(21, MinimumLength = 10, ErrorMessageResourceName = "StringLengthCardNumber", ErrorMessageResourceType = typeof(DtoTraduction))]
	[Required(ErrorMessageResourceName = "RequiredCardNumber", ErrorMessageResourceType = typeof(DtoTraduction))]
	public string CardNumber
	{
		[CompilerGenerated]
		get
		{
			return qePDDenGmQ;
		}
		[CompilerGenerated]
		set
		{
			qePDDenGmQ = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredAmount", ErrorMessageResourceType = typeof(DtoTraduction))]
	public decimal Amount
	{
		[CompilerGenerated]
		get
		{
			return QriDvsa9tx;
		}
		[CompilerGenerated]
		set
		{
			QriDvsa9tx = value;
		}
	}

	[Required(ErrorMessageResourceName = "RequiredAmountPaid", ErrorMessageResourceType = typeof(DtoTraduction))]
	public decimal? AmountPaid
	{
		[CompilerGenerated]
		get
		{
			return Qh0DJ7XXwM;
		}
		[CompilerGenerated]
		set
		{
			Qh0DJ7XXwM = value;
		}
	}

	public string FullName
	{
		[CompilerGenerated]
		get
		{
			return JgYDeH5F8n;
		}
		[CompilerGenerated]
		set
		{
			JgYDeH5F8n = value;
		}
	}

	public PrepaidCardDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		sZhDoKI1WD = string.Empty;
		xvMDtJMs1a = string.Empty;
		qePDDenGmQ = string.Empty;
		Qh0DJ7XXwM = default(decimal);
		JgYDeH5F8n = string.Empty;
		base._002Ector();
	}
}
