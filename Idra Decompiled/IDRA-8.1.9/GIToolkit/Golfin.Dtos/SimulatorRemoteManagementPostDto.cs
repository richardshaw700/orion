using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using GIToolkit.Resources;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class SimulatorRemoteManagementPostDto
{
	[CompilerGenerated]
	private string WBFkfewGDi;

	[CompilerGenerated]
	private string dtOkyeffLZ;

	[CompilerGenerated]
	private string mQTkHU2kIE;

	[CompilerGenerated]
	private int xa9kwCgtke;

	[Required]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return WBFkfewGDi;
		}
		[CompilerGenerated]
		set
		{
			WBFkfewGDi = value;
		}
	}

	public string AzureDeviceId
	{
		[CompilerGenerated]
		get
		{
			return dtOkyeffLZ;
		}
		[CompilerGenerated]
		set
		{
			dtOkyeffLZ = value;
		}
	}

	public string AzureSharedAccessKey
	{
		[CompilerGenerated]
		get
		{
			return mQTkHU2kIE;
		}
		[CompilerGenerated]
		set
		{
			mQTkHU2kIE = value;
		}
	}

	[Range(1, int.MaxValue, ErrorMessageResourceName = "RequiredSite", ErrorMessageResourceType = typeof(DtoTraduction))]
	[Required]
	public int SiteId
	{
		[CompilerGenerated]
		get
		{
			return xa9kwCgtke;
		}
		[CompilerGenerated]
		set
		{
			xa9kwCgtke = value;
		}
	}

	public SimulatorRemoteManagementPostDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
