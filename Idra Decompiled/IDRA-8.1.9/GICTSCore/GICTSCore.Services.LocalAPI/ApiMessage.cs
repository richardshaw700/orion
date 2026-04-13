using System.Runtime.CompilerServices;
using GICTS.Data;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;

namespace GICTSCore.Services.LocalAPI;

public class ApiMessage
{
	[CompilerGenerated]
	private string ckDDnZBEva;

	[CompilerGenerated]
	private object R76DSnHkHu;

	[CompilerGenerated]
	private string auiDVLdhgq;

	[CompilerGenerated]
	private BallData XCMDvUaSJQ;

	[CompilerGenerated]
	private ClubData iofDHhGKWI;

	public string Type
	{
		[CompilerGenerated]
		get
		{
			return ckDDnZBEva;
		}
		[CompilerGenerated]
		set
		{
			ckDDnZBEva = value;
		}
	}

	public object Details
	{
		[CompilerGenerated]
		get
		{
			return R76DSnHkHu;
		}
		[CompilerGenerated]
		set
		{
			R76DSnHkHu = value;
		}
	}

	public string SubType
	{
		[CompilerGenerated]
		get
		{
			return auiDVLdhgq;
		}
		[CompilerGenerated]
		set
		{
			auiDVLdhgq = value;
		}
	}

	public BallData BallData
	{
		[CompilerGenerated]
		get
		{
			return XCMDvUaSJQ;
		}
		[CompilerGenerated]
		set
		{
			XCMDvUaSJQ = value;
		}
	}

	public ClubData ClubData
	{
		[CompilerGenerated]
		get
		{
			return iofDHhGKWI;
		}
		[CompilerGenerated]
		set
		{
			iofDHhGKWI = value;
		}
	}

	public bool IsShotSuccess()
	{
		if (Type == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13640) && SubType == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13650))
		{
			return Details.ToString() == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13670);
		}
		return false;
	}

	public ApiMessage()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
	}
}
