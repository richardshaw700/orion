using System;
using System.Runtime.CompilerServices;
using GYFmeytn3uk9KnUELA;
using Newtonsoft.Json;
using RIrlNToRdPZ6Uy0SYo;

namespace IDRASharedModels;

[Serializable]
public class ShotDataDto
{
	[CompilerGenerated]
	private int uosVYXE6aJ;

	[CompilerGenerated]
	private BallDataDto nKWVj8cSRg;

	[CompilerGenerated]
	private ClubDataDto? zsCVCPi7v2;

	[JsonProperty("ShotNumber")]
	public int ShotNumber
	{
		[CompilerGenerated]
		get
		{
			return uosVYXE6aJ;
		}
		[CompilerGenerated]
		set
		{
			uosVYXE6aJ = value;
		}
	}

	[JsonProperty("BallData")]
	public BallDataDto BallData
	{
		[CompilerGenerated]
		get
		{
			return nKWVj8cSRg;
		}
		[CompilerGenerated]
		set
		{
			nKWVj8cSRg = value;
		}
	}

	[JsonProperty("ClubData")]
	public ClubDataDto? ClubData
	{
		[CompilerGenerated]
		get
		{
			return zsCVCPi7v2;
		}
		[CompilerGenerated]
		set
		{
			zsCVCPi7v2 = value;
		}
	}

	public bool IsShot
	{
		get
		{
			if (BallData != null)
			{
				return ClubData != null;
			}
			return false;
		}
	}

	public ShotDataDto()
	{
		l26t3npZsnUe1qbsCU.vf2WGHkzGx201();
		base._002Ector();
	}

	static ShotDataDto()
	{
		G2089JiDB7k4x1yr7J.kLjw4iIsCLsZtxc4lksN0j();
	}
}
