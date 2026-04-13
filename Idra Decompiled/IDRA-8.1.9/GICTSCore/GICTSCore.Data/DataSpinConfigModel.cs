using System;
using System.Runtime.CompilerServices;
using lKEAGvFqWp7B16kDoY;

namespace GICTSCore.Data;

[Serializable]
public class DataSpinConfigModel
{
	[CompilerGenerated]
	private int AfcvcP0MWr;

	[CompilerGenerated]
	private int cndvW9ZdqX;

	[CompilerGenerated]
	private int GK6vJYVyOS;

	[CompilerGenerated]
	private int uTLv41wjct;

	[CompilerGenerated]
	private int xIbv3R7FRQ;

	[CompilerGenerated]
	private int WG8vl0CMBw;

	[CompilerGenerated]
	private int Mx2vi8IHX1;

	[CompilerGenerated]
	private int Rb5vQmAeGZ;

	public int DefaultFactorValue
	{
		[CompilerGenerated]
		get
		{
			return AfcvcP0MWr;
		}
		[CompilerGenerated]
		set
		{
			AfcvcP0MWr = value;
		}
	}

	public int DefaultOffsetValue
	{
		[CompilerGenerated]
		get
		{
			return cndvW9ZdqX;
		}
		[CompilerGenerated]
		set
		{
			cndvW9ZdqX = value;
		}
	}

	public int BallSpeedRangeMax
	{
		[CompilerGenerated]
		get
		{
			return GK6vJYVyOS;
		}
		[CompilerGenerated]
		set
		{
			GK6vJYVyOS = value;
		}
	}

	public int BallSpeedSteps
	{
		[CompilerGenerated]
		get
		{
			return uTLv41wjct;
		}
		[CompilerGenerated]
		set
		{
			uTLv41wjct = value;
		}
	}

	public int NbBallSpeedFactor => BallSpeedRangeMax / ((BallSpeedSteps == 0) ? 1 : BallSpeedSteps);

	public int LaunchAngleRangeMax
	{
		[CompilerGenerated]
		get
		{
			return xIbv3R7FRQ;
		}
		[CompilerGenerated]
		set
		{
			xIbv3R7FRQ = value;
		}
	}

	public int LaunchAngleSteps
	{
		[CompilerGenerated]
		get
		{
			return WG8vl0CMBw;
		}
		[CompilerGenerated]
		set
		{
			WG8vl0CMBw = value;
		}
	}

	public int NbLaunchAngleFactor => LaunchAngleRangeMax / ((LaunchAngleSteps == 0) ? 1 : LaunchAngleSteps);

	public int BallPositionRangeMax
	{
		[CompilerGenerated]
		get
		{
			return Mx2vi8IHX1;
		}
		[CompilerGenerated]
		set
		{
			Mx2vi8IHX1 = value;
		}
	}

	public int BallPositionSteps
	{
		[CompilerGenerated]
		get
		{
			return Rb5vQmAeGZ;
		}
		[CompilerGenerated]
		set
		{
			Rb5vQmAeGZ = value;
		}
	}

	public int NbBallPositionFactor => BallPositionRangeMax / ((BallPositionSteps == 0) ? 1 : BallPositionSteps);

	public bool IsInitialized()
	{
		if (BallSpeedRangeMax > 0 && BallSpeedSteps > 0 && LaunchAngleRangeMax > 0 && LaunchAngleSteps > 0 && BallPositionRangeMax > 0)
		{
			return BallPositionSteps > 0;
		}
		return false;
	}

	public bool IsEmpty()
	{
		if (DefaultFactorValue == 0 && DefaultOffsetValue == 0 && BallSpeedRangeMax == 0 && BallSpeedSteps == 0 && LaunchAngleRangeMax == 0 && LaunchAngleSteps == 0 && BallPositionRangeMax == 0)
		{
			return BallPositionSteps == 0;
		}
		return false;
	}

	public void FillDefault()
	{
		BallSpeedRangeMax = 250;
		BallSpeedSteps = 10;
		LaunchAngleRangeMax = 80;
		LaunchAngleSteps = 3;
		BallPositionRangeMax = 200;
		BallPositionSteps = 5;
		DefaultFactorValue = 62;
		DefaultOffsetValue = 0;
	}

	public DataSpinConfigModel()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
	}
}
