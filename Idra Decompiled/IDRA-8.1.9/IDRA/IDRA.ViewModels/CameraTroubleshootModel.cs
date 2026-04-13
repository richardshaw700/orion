using System.Runtime.CompilerServices;
using GhU84wwqvI4UZ3pBfu;

namespace IDRA.ViewModels;

public class CameraTroubleshootModel
{
	[CompilerGenerated]
	private string fejY1bjN0;

	[CompilerGenerated]
	private bool fMovC58ku;

	[CompilerGenerated]
	private bool FK4hn88bo;

	[CompilerGenerated]
	private bool rdxSqDyee;

	public string SN
	{
		[CompilerGenerated]
		get
		{
			return fejY1bjN0;
		}
		[CompilerGenerated]
		set
		{
			fejY1bjN0 = value;
		}
	}

	public bool IsDetected
	{
		[CompilerGenerated]
		get
		{
			return fMovC58ku;
		}
		[CompilerGenerated]
		set
		{
			fMovC58ku = value;
		}
	}

	public bool IsUSBSuperSpeed
	{
		[CompilerGenerated]
		get
		{
			return FK4hn88bo;
		}
		[CompilerGenerated]
		set
		{
			FK4hn88bo = value;
		}
	}

	public bool CameraLightIsOpen
	{
		[CompilerGenerated]
		get
		{
			return rdxSqDyee;
		}
		[CompilerGenerated]
		set
		{
			rdxSqDyee = value;
		}
	}

	public bool Status
	{
		get
		{
			if (IsDetected && IsUSBSuperSpeed)
			{
				return CameraLightIsOpen;
			}
			return false;
		}
	}

	public CameraTroubleshootModel()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		base._002Ector();
	}
}
