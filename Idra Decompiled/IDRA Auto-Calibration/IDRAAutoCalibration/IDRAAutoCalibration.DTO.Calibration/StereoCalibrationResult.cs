using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using Emgu.CV;
using Emgu.CV.Structure;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration.DTO.Calibration;

public class StereoCalibrationResult : IDisposable
{
	[CompilerGenerated]
	private double spj4UhcW8N;

	[CompilerGenerated]
	private double RfH4hG9I7O;

	[CompilerGenerated]
	private double CEv4eGk7Lh;

	[CompilerGenerated]
	private Dictionary<CameraRole, CalibrationResult> AhJ4mqsEuv;

	[CompilerGenerated]
	private Mat? TAt4uK6luY;

	[CompilerGenerated]
	private Mat? pfR4750OPI;

	[CompilerGenerated]
	private Mat? BUW488bJAE;

	[CompilerGenerated]
	private Mat? TSR4psM6Je;

	[CompilerGenerated]
	private Mat? Si64SFOsvI;

	[CompilerGenerated]
	private MCvPoint3D32f wY84xwc47j;

	[CompilerGenerated]
	private MCvPoint3D32f LGc4saZlt8;

	[CompilerGenerated]
	private MCvPoint3D32f iGG4qAYFKA;

	[CompilerGenerated]
	private List<PointF[]> TN64WiYmbS;

	[CompilerGenerated]
	private List<PointF[]> qbR4f7DJre;

	[CompilerGenerated]
	private List<CalibrationValidationValue> HOn4KGs50N;

	public double MasterCalculatedRms
	{
		[CompilerGenerated]
		get
		{
			return spj4UhcW8N;
		}
		[CompilerGenerated]
		set
		{
			spj4UhcW8N = value;
		}
	}

	public double SlaveCalculatedRms
	{
		[CompilerGenerated]
		get
		{
			return RfH4hG9I7O;
		}
		[CompilerGenerated]
		set
		{
			RfH4hG9I7O = value;
		}
	}

	public double StereoCalculatedRms
	{
		[CompilerGenerated]
		get
		{
			return CEv4eGk7Lh;
		}
		[CompilerGenerated]
		set
		{
			CEv4eGk7Lh = value;
		}
	}

	public Dictionary<CameraRole, CalibrationResult> CameraResults
	{
		[CompilerGenerated]
		get
		{
			return AhJ4mqsEuv;
		}
		[CompilerGenerated]
		set
		{
			AhJ4mqsEuv = value;
		}
	}

	public Mat? RotationMatrix
	{
		[CompilerGenerated]
		get
		{
			return TAt4uK6luY;
		}
		[CompilerGenerated]
		set
		{
			TAt4uK6luY = value;
		}
	}

	public Mat? TranslationVector
	{
		[CompilerGenerated]
		get
		{
			return pfR4750OPI;
		}
		[CompilerGenerated]
		set
		{
			pfR4750OPI = value;
		}
	}

	public Mat? EssentialMatrix
	{
		[CompilerGenerated]
		get
		{
			return BUW488bJAE;
		}
		[CompilerGenerated]
		set
		{
			BUW488bJAE = value;
		}
	}

	public Mat? FundamentalMatrix
	{
		[CompilerGenerated]
		get
		{
			return TSR4psM6Je;
		}
		[CompilerGenerated]
		set
		{
			TSR4psM6Je = value;
		}
	}

	public Mat? PerspectiveTransformation
	{
		[CompilerGenerated]
		get
		{
			return Si64SFOsvI;
		}
		[CompilerGenerated]
		set
		{
			Si64SFOsvI = value;
		}
	}

	public MCvPoint3D32f TargetPO
	{
		[CompilerGenerated]
		get
		{
			return wY84xwc47j;
		}
		[CompilerGenerated]
		set
		{
			wY84xwc47j = value;
		}
	}

	public MCvPoint3D32f TargetPX
	{
		[CompilerGenerated]
		get
		{
			return LGc4saZlt8;
		}
		[CompilerGenerated]
		set
		{
			LGc4saZlt8 = value;
		}
	}

	public MCvPoint3D32f TargetPY
	{
		[CompilerGenerated]
		get
		{
			return iGG4qAYFKA;
		}
		[CompilerGenerated]
		set
		{
			iGG4qAYFKA = value;
		}
	}

	public List<PointF[]> MasterImagePointsUsed
	{
		[CompilerGenerated]
		get
		{
			return TN64WiYmbS;
		}
		[CompilerGenerated]
		set
		{
			TN64WiYmbS = value;
		}
	}

	public List<PointF[]> SlaveImagePointsUsed
	{
		[CompilerGenerated]
		get
		{
			return qbR4f7DJre;
		}
		[CompilerGenerated]
		set
		{
			qbR4f7DJre = value;
		}
	}

	public List<CalibrationValidationValue> CameraCalibrationValidationValues
	{
		[CompilerGenerated]
		get
		{
			return HOn4KGs50N;
		}
		[CompilerGenerated]
		set
		{
			HOn4KGs50N = value;
		}
	}

	public CalibrationResult this[CameraRole role]
	{
		get
		{
			return CameraResults[role];
		}
		set
		{
			CameraResults[role] = value;
		}
	}

	public StereoCalibrationResult()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		AhJ4mqsEuv = new Dictionary<CameraRole, CalibrationResult>();
		TN64WiYmbS = new List<PointF[]>();
		qbR4f7DJre = new List<PointF[]>();
		HOn4KGs50N = new List<CalibrationValidationValue>();
		base._002Ector();
		CameraResults.Add(CameraRole.Master, new CalibrationResult());
		CameraResults.Add(CameraRole.Slave, new CalibrationResult());
		CameraResults.Add(CameraRole.Stereo, new CalibrationResult());
	}

	public void Dispose()
	{
		foreach (CalibrationResult value in CameraResults.Values)
		{
			value.Dispose();
		}
		RotationMatrix?.Dispose();
		TranslationVector?.Dispose();
		EssentialMatrix?.Dispose();
		FundamentalMatrix?.Dispose();
		PerspectiveTransformation?.Dispose();
	}
}
