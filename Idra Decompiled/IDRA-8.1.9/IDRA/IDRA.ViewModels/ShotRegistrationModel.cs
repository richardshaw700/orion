using System.Runtime.CompilerServices;
using GICTS.Data;
using GhU84wwqvI4UZ3pBfu;
using sxB8TYTZ87aKuujytY;

namespace IDRA.ViewModels;

public class ShotRegistrationModel
{
	[CompilerGenerated]
	private float oi0QsYE54x;

	[CompilerGenerated]
	private float wHZQxKg7Lq;

	[CompilerGenerated]
	private float EStQdb1DZr;

	[CompilerGenerated]
	private float zMxQHs2PSc;

	[CompilerGenerated]
	private float LmKQEuxKOH;

	[CompilerGenerated]
	private float w3pQQhKktZ;

	[CompilerGenerated]
	private float WU1Qa0T1bm;

	[CompilerGenerated]
	private float b0CQqsGlcf;

	[CompilerGenerated]
	private float QIKQCIFlX1;

	[CompilerGenerated]
	private int AkmQ0FNLDg;

	[CompilerGenerated]
	private string KTiQ7o6uA4;

	[CompilerGenerated]
	private ClubNatureEnum FLDQIcgs7R;

	[CompilerGenerated]
	private PlayerHandednessNatureEnum H81Q8MDLlf;

	public int MaxTestCaseLenght => 80;

	public float BallSpeed
	{
		[CompilerGenerated]
		get
		{
			return oi0QsYE54x;
		}
		[CompilerGenerated]
		set
		{
			oi0QsYE54x = value;
		}
	}

	public float LaunchAngle
	{
		[CompilerGenerated]
		get
		{
			return wHZQxKg7Lq;
		}
		[CompilerGenerated]
		set
		{
			wHZQxKg7Lq = value;
		}
	}

	public float BallDirection
	{
		[CompilerGenerated]
		get
		{
			return EStQdb1DZr;
		}
		[CompilerGenerated]
		set
		{
			EStQdb1DZr = value;
		}
	}

	public float ClubSpeed
	{
		[CompilerGenerated]
		get
		{
			return zMxQHs2PSc;
		}
		[CompilerGenerated]
		set
		{
			zMxQHs2PSc = value;
		}
	}

	public float ClubPath
	{
		[CompilerGenerated]
		get
		{
			return LmKQEuxKOH;
		}
		[CompilerGenerated]
		set
		{
			LmKQEuxKOH = value;
		}
	}

	public float BackSpin
	{
		[CompilerGenerated]
		get
		{
			return w3pQQhKktZ;
		}
		[CompilerGenerated]
		set
		{
			w3pQQhKktZ = value;
		}
	}

	public float SideSpin
	{
		[CompilerGenerated]
		get
		{
			return WU1Qa0T1bm;
		}
		[CompilerGenerated]
		set
		{
			WU1Qa0T1bm = value;
		}
	}

	public float SpinAxis
	{
		[CompilerGenerated]
		get
		{
			return b0CQqsGlcf;
		}
		[CompilerGenerated]
		set
		{
			b0CQqsGlcf = value;
		}
	}

	public float ClubFace
	{
		[CompilerGenerated]
		get
		{
			return QIKQCIFlX1;
		}
		[CompilerGenerated]
		set
		{
			QIKQCIFlX1 = value;
		}
	}

	public int ClubBallHitPositionPercentage
	{
		[CompilerGenerated]
		get
		{
			return AkmQ0FNLDg;
		}
		[CompilerGenerated]
		set
		{
			AkmQ0FNLDg = value;
		}
	}

	public string TestCase
	{
		[CompilerGenerated]
		get
		{
			return KTiQ7o6uA4;
		}
		[CompilerGenerated]
		set
		{
			KTiQ7o6uA4 = value;
		}
	}

	public ClubNatureEnum ClubNature
	{
		[CompilerGenerated]
		get
		{
			return FLDQIcgs7R;
		}
		[CompilerGenerated]
		private set
		{
			FLDQIcgs7R = value;
		}
	}

	public PlayerHandednessNatureEnum PlayerHanded
	{
		[CompilerGenerated]
		get
		{
			return H81Q8MDLlf;
		}
		[CompilerGenerated]
		private set
		{
			H81Q8MDLlf = value;
		}
	}

	public string ClubBallHitPositionStr
	{
		get
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
			defaultInterpolatedStringHandler.AppendFormatted(ClubBallHitPositionPercentage);
			defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6974));
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}

	public ShotRegistrationModel(ClubNatureEnum clubNature, PlayerHandednessNatureEnum playerHanded)
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		base._002Ector();
		ClubNature = clubNature;
		PlayerHanded = playerHanded;
	}
}
