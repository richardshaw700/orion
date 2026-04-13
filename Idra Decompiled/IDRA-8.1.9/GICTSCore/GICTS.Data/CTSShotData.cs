using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;

namespace GICTS.Data;

public class CTSShotData
{
	[CompilerGenerated]
	private BallData vn6SL0CZF6;

	[CompilerGenerated]
	private ClubData PW1SnlE7fR;

	[CompilerGenerated]
	private ConfigData pD6SSsTK8l;

	[CompilerGenerated]
	private List<Point3D> DLHSVv3qHw;

	[CompilerGenerated]
	private bool reKSvu8NhK;

	[CompilerGenerated]
	private PlayerHandednessNatureEnum A3dSH04jpr;

	[CompilerGenerated]
	private float DIUSDqobR8;

	public List<string> Log;

	[CompilerGenerated]
	private ClubNatureEnum be1STtap82;

	[CompilerGenerated]
	private string rRsSCs0mZu;

	[CompilerGenerated]
	private string xnvSMrmaXM;

	public ShotStateEnum ShotState;

	public BallData Ball
	{
		[CompilerGenerated]
		get
		{
			return vn6SL0CZF6;
		}
		[CompilerGenerated]
		set
		{
			vn6SL0CZF6 = value;
		}
	}

	public ClubData Club
	{
		[CompilerGenerated]
		get
		{
			return PW1SnlE7fR;
		}
		[CompilerGenerated]
		set
		{
			PW1SnlE7fR = value;
		}
	}

	public ConfigData ConfigData
	{
		[CompilerGenerated]
		get
		{
			return pD6SSsTK8l;
		}
		[CompilerGenerated]
		set
		{
			pD6SSsTK8l = value;
		}
	}

	public List<Point3D> Points3D
	{
		[CompilerGenerated]
		get
		{
			return DLHSVv3qHw;
		}
		[CompilerGenerated]
		set
		{
			DLHSVv3qHw = value;
		}
	}

	public bool UseMLSpinCalculationMethod
	{
		[CompilerGenerated]
		get
		{
			return reKSvu8NhK;
		}
		[CompilerGenerated]
		set
		{
			reKSvu8NhK = value;
		}
	}

	public PlayerHandednessNatureEnum PlayerHandedness
	{
		[CompilerGenerated]
		get
		{
			return A3dSH04jpr;
		}
		[CompilerGenerated]
		set
		{
			A3dSH04jpr = value;
		}
	}

	public float ClubBallHitPercent
	{
		[CompilerGenerated]
		get
		{
			return DIUSDqobR8;
		}
		[CompilerGenerated]
		set
		{
			DIUSDqobR8 = value;
		}
	}

	public ClubNatureEnum ClubNature
	{
		[CompilerGenerated]
		get
		{
			return be1STtap82;
		}
		[CompilerGenerated]
		set
		{
			be1STtap82 = value;
		}
	}

	public string FullFilename
	{
		[CompilerGenerated]
		get
		{
			return rRsSCs0mZu;
		}
		[CompilerGenerated]
		set
		{
			rRsSCs0mZu = value;
		}
	}

	public string ShotName
	{
		[CompilerGenerated]
		get
		{
			return xnvSMrmaXM;
		}
		[CompilerGenerated]
		set
		{
			xnvSMrmaXM = value;
		}
	}

	public CTSShotData()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		reKSvu8NhK = true;
		base._002Ector();
		Ball = new BallData();
		Club = new ClubData();
		Log = new List<string>();
	}

	public ClubNatureCategoryEnum GetClubNatureCategory()
	{
		if (ClubNature == ClubNatureEnum.IRON_UNKNOWN || ClubNature == ClubNatureEnum.IRON_WEDGE)
		{
			return ClubNatureCategoryEnum.IRON;
		}
		if (ClubNature == ClubNatureEnum.WOOD_FAIRWAY_BIG || ClubNature == ClubNatureEnum.WOOD_FAIRWAY_SMALL || ClubNature == ClubNatureEnum.WOOD_DRIVER || ClubNature == ClubNatureEnum.WOOD_UNKNOWN)
		{
			return ClubNatureCategoryEnum.WOOD;
		}
		if (ClubNature == ClubNatureEnum.PUTTER)
		{
			return ClubNatureCategoryEnum.PUTTER;
		}
		return ClubNatureCategoryEnum.IRON;
	}

	public static ClubNatureCategoryEnum GetClubNatureCategory(ClubNatureEnum clubNature)
	{
		switch (clubNature)
		{
		case ClubNatureEnum.IRON_UNKNOWN:
		case ClubNatureEnum.IRON_WEDGE:
			return ClubNatureCategoryEnum.IRON;
		case ClubNatureEnum.WOOD_FAIRWAY_BIG:
		case ClubNatureEnum.WOOD_FAIRWAY_SMALL:
		case ClubNatureEnum.WOOD_DRIVER:
		case ClubNatureEnum.WOOD_UNKNOWN:
			return ClubNatureCategoryEnum.WOOD;
		case ClubNatureEnum.PUTTER:
			return ClubNatureCategoryEnum.PUTTER;
		default:
			return ClubNatureCategoryEnum.IRON;
		}
	}

	public string GetClubNatureToString()
	{
		return GetClubNatureToString(ClubNature);
	}

	public static string GetClubNatureToString(ClubNatureEnum clubNature)
	{
		return clubNature switch
		{
			ClubNatureEnum.IRON_UNKNOWN => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6876), 
			ClubNatureEnum.IRON_WEDGE => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6904), 
			ClubNatureEnum.WOOD_FAIRWAY_BIG => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6918), 
			ClubNatureEnum.WOOD_FAIRWAY_SMALL => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6954), 
			ClubNatureEnum.WOOD_DRIVER => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6994), 
			ClubNatureEnum.WOOD_UNKNOWN => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7010), 
			ClubNatureEnum.PUTTER => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7038), 
			_ => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7054), 
		};
	}

	public CTSShotData Copy()
	{
		CTSShotData obj = (CTSShotData)MemberwiseClone();
		obj.Ball = new BallData();
		obj.Ball.BackSpin = Ball.BackSpin;
		obj.Ball.BallSpeed = Ball.BallSpeed;
		obj.Ball.LaunchAngle = Ball.LaunchAngle;
		obj.Ball.LaunchDirection = Ball.LaunchDirection;
		obj.Ball.SideSpin = Ball.SideSpin;
		obj.Ball.SpinAxis = Ball.SpinAxis;
		obj.Ball.TotalSpin = Ball.TotalSpin;
		obj.Club = new ClubData();
		obj.Club.ClubAngleFace = Club.ClubAngleFace;
		obj.Club.ClubAnglePath = Club.ClubAnglePath;
		obj.Club.ClubAngleOfAttack = Club.ClubAngleOfAttack;
		obj.Club.ClubHeadSpeed = Club.ClubHeadSpeed;
		obj.ClubBallHitPercent = ClubBallHitPercent;
		obj.ShotName = ShotName;
		obj.FullFilename = FullFilename;
		obj.ClubNature = ClubNature;
		obj.Log = new List<string>();
		return obj;
	}
}
