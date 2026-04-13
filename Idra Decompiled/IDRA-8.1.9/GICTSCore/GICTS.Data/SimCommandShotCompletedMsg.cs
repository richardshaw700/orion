using System.Runtime.CompilerServices;
using lKEAGvFqWp7B16kDoY;

namespace GICTS.Data;

public class SimCommandShotCompletedMsg : JsonMessage
{
	[CompilerGenerated]
	private double vn4SjrAFxT;

	[CompilerGenerated]
	private BallDataType FU1S65yX0t;

	[CompilerGenerated]
	private bool TqIS120TU9;

	[CompilerGenerated]
	private string o4ASkQEdrk;

	[CompilerGenerated]
	private double TFPSdk77XL;

	[CompilerGenerated]
	private double XANSNuy4aL;

	[CompilerGenerated]
	private double HeWS5suL4N;

	[CompilerGenerated]
	private ClubDataType xP3Sc7H8N0;

	[CompilerGenerated]
	private double yi3SWHUblx;

	[CompilerGenerated]
	private double xLZSJ3WClu;

	[CompilerGenerated]
	private double WcWS4KaMbt;

	[CompilerGenerated]
	private double gRhS3Wd7lr;

	public double Apex
	{
		[CompilerGenerated]
		get
		{
			return vn4SjrAFxT;
		}
		[CompilerGenerated]
		set
		{
			vn4SjrAFxT = value;
		}
	}

	public BallDataType BallData
	{
		[CompilerGenerated]
		get
		{
			return FU1S65yX0t;
		}
		[CompilerGenerated]
		set
		{
			FU1S65yX0t = value;
		}
	}

	public bool BallInHole
	{
		[CompilerGenerated]
		get
		{
			return TqIS120TU9;
		}
		[CompilerGenerated]
		set
		{
			TqIS120TU9 = value;
		}
	}

	public string BallLocation
	{
		[CompilerGenerated]
		get
		{
			return o4ASkQEdrk;
		}
		[CompilerGenerated]
		set
		{
			o4ASkQEdrk = value;
		}
	}

	public double CarryDeviationAngle
	{
		[CompilerGenerated]
		get
		{
			return TFPSdk77XL;
		}
		[CompilerGenerated]
		set
		{
			TFPSdk77XL = value;
		}
	}

	public double CarryDeviationFeet
	{
		[CompilerGenerated]
		get
		{
			return XANSNuy4aL;
		}
		[CompilerGenerated]
		set
		{
			XANSNuy4aL = value;
		}
	}

	public double CarryDistance
	{
		[CompilerGenerated]
		get
		{
			return HeWS5suL4N;
		}
		[CompilerGenerated]
		set
		{
			HeWS5suL4N = value;
		}
	}

	public ClubDataType ClubData
	{
		[CompilerGenerated]
		get
		{
			return xP3Sc7H8N0;
		}
		[CompilerGenerated]
		set
		{
			xP3Sc7H8N0 = value;
		}
	}

	public double DistanceToPin
	{
		[CompilerGenerated]
		get
		{
			return yi3SWHUblx;
		}
		[CompilerGenerated]
		set
		{
			yi3SWHUblx = value;
		}
	}

	public double TotalDeviationAngle
	{
		[CompilerGenerated]
		get
		{
			return xLZSJ3WClu;
		}
		[CompilerGenerated]
		set
		{
			xLZSJ3WClu = value;
		}
	}

	public double TotalDeviationFeet
	{
		[CompilerGenerated]
		get
		{
			return WcWS4KaMbt;
		}
		[CompilerGenerated]
		set
		{
			WcWS4KaMbt = value;
		}
	}

	public double TotalDistance
	{
		[CompilerGenerated]
		get
		{
			return gRhS3Wd7lr;
		}
		[CompilerGenerated]
		set
		{
			gRhS3Wd7lr = value;
		}
	}

	public SimCommandShotCompletedMsg()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
	}

	public SimCommandShotCompletedMsg(CTSShotData shot)
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
		BallData = new BallDataType
		{
			BackSpin = shot.Ball.BackSpin,
			BallSpeed = shot.Ball.BallSpeed,
			LaunchAngle = shot.Ball.LaunchAngle,
			LaunchDirection = shot.Ball.LaunchDirection,
			SideSpin = shot.Ball.SideSpin,
			SpinAxis = shot.Ball.SpinAxis,
			TotalSpin = shot.Ball.TotalSpin
		};
		ClubData = new ClubDataType
		{
			ClubAngleFace = shot.Club.ClubAngleFace,
			ClubAnglePath = shot.Club.ClubAnglePath,
			ClubHeadSpeed = shot.Club.ClubHeadSpeed,
			ClubHeadSpeedMPH = shot.Club.ClubHeadSpeedMPH,
			SmashFactor = shot.Ball.BallSpeed / ((shot.Club.ClubHeadSpeed <= 0.0) ? 1.0 : shot.Club.ClubHeadSpeed)
		};
	}
}
