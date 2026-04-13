using System;
using System.Runtime.CompilerServices;
using GYFmeytn3uk9KnUELA;
using Newtonsoft.Json;
using RIrlNToRdPZ6Uy0SYo;

namespace IDRASharedModels;

[Serializable]
public class PlayerDataDto
{
	[CompilerGenerated]
	private string cJsVPDdggp;

	[CompilerGenerated]
	private string Pq3V4jQOLk;

	[CompilerGenerated]
	private float HXvVe7gcrp;

	[CompilerGenerated]
	private Guid G5rVudQnsB;

	[CompilerGenerated]
	private string dWYVUuICZa;

	[JsonProperty("Speed")]
	public string Speed
	{
		[CompilerGenerated]
		get
		{
			return cJsVPDdggp;
		}
		[CompilerGenerated]
		set
		{
			cJsVPDdggp = value;
		}
	}

	[JsonProperty("SpinAxis")]
	public string SpinAxis
	{
		[CompilerGenerated]
		get
		{
			return Pq3V4jQOLk;
		}
		[CompilerGenerated]
		set
		{
			Pq3V4jQOLk = value;
		}
	}

	[JsonProperty("TotalSpin")]
	public float TotalSpin
	{
		[CompilerGenerated]
		get
		{
			return HXvVe7gcrp;
		}
		[CompilerGenerated]
		set
		{
			HXvVe7gcrp = value;
		}
	}

	[JsonProperty("PlayerID")]
	public Guid PlayerID
	{
		[CompilerGenerated]
		get
		{
			return G5rVudQnsB;
		}
		[CompilerGenerated]
		set
		{
			G5rVudQnsB = value;
		}
	}

	[JsonProperty("PlayerName")]
	public string PlayerName
	{
		[CompilerGenerated]
		get
		{
			return dWYVUuICZa;
		}
		[CompilerGenerated]
		set
		{
			dWYVUuICZa = value;
		}
	}

	public string Handed
	{
		get
		{
			return Speed;
		}
		set
		{
			Speed = value;
		}
	}

	public float DistanceToTarget
	{
		get
		{
			return TotalSpin;
		}
		set
		{
			TotalSpin = value;
		}
	}

	public string Club
	{
		get
		{
			return SpinAxis;
		}
		set
		{
			SpinAxis = value;
		}
	}

	public PlayerDataDto()
	{
		l26t3npZsnUe1qbsCU.vf2WGHkzGx201();
		base._002Ector();
	}

	static PlayerDataDto()
	{
		G2089JiDB7k4x1yr7J.kLjw4iIsCLsZtxc4lksN0j();
	}
}
