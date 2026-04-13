using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Emgu.CV;
using Emgu.CV.Structure;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration.DTO.Calibration;

public class CalibrationResult : IDisposable
{
	[CompilerGenerated]
	private string ghd4XELtx3;

	[CompilerGenerated]
	private Mat? AbJ4M0RHIl;

	[CompilerGenerated]
	private Mat? OjV4kHgqi3;

	[CompilerGenerated]
	private Rectangle X6C4dtdx8Z;

	[CompilerGenerated]
	private Mat? Alw4rXRKqF;

	[CompilerGenerated]
	private Mat? NJO4J0Vup1;

	[CompilerGenerated]
	private Mat? TaC442OlgL;

	[CompilerGenerated]
	private Mat? F6F4nJWcSx;

	[CompilerGenerated]
	private MCvPoint3D32f yWS41SNwlD;

	[CompilerGenerated]
	private MCvPoint3D32f GCu4OIn6ax;

	[CompilerGenerated]
	private MCvPoint3D32f NEj460jDvh;

	[CompilerGenerated]
	private MCvPoint3D32f aTy4HPYTmm;

	[CompilerGenerated]
	private PointF bKC4jJmGHd;

	[CompilerGenerated]
	private PointF bu34RkdUi8;

	[CompilerGenerated]
	private PointF S3Z4vmBbjr;

	[CompilerGenerated]
	private PointF[]? bcB493dYw7;

	public string CameraId
	{
		[CompilerGenerated]
		get
		{
			return ghd4XELtx3;
		}
		[CompilerGenerated]
		set
		{
			ghd4XELtx3 = value;
		}
	}

	public Mat? Rectification
	{
		[CompilerGenerated]
		get
		{
			return AbJ4M0RHIl;
		}
		[CompilerGenerated]
		set
		{
			AbJ4M0RHIl = value;
		}
	}

	public Mat? Projection
	{
		[CompilerGenerated]
		get
		{
			return OjV4kHgqi3;
		}
		[CompilerGenerated]
		set
		{
			OjV4kHgqi3 = value;
		}
	}

	public Rectangle ROI
	{
		[CompilerGenerated]
		get
		{
			return X6C4dtdx8Z;
		}
		[CompilerGenerated]
		set
		{
			X6C4dtdx8Z = value;
		}
	}

	public Mat? CameraMatrix
	{
		[CompilerGenerated]
		get
		{
			return Alw4rXRKqF;
		}
		[CompilerGenerated]
		set
		{
			Alw4rXRKqF = value;
		}
	}

	public Mat? DistCoefficient
	{
		[CompilerGenerated]
		get
		{
			return NJO4J0Vup1;
		}
		[CompilerGenerated]
		set
		{
			NJO4J0Vup1 = value;
		}
	}

	public Mat? TargetRotation
	{
		[CompilerGenerated]
		get
		{
			return TaC442OlgL;
		}
		[CompilerGenerated]
		set
		{
			TaC442OlgL = value;
		}
	}

	public Mat? TargetTranslation
	{
		[CompilerGenerated]
		get
		{
			return F6F4nJWcSx;
		}
		[CompilerGenerated]
		set
		{
			F6F4nJWcSx = value;
		}
	}

	public MCvPoint3D32f TargetOrigin
	{
		[CompilerGenerated]
		get
		{
			return yWS41SNwlD;
		}
		[CompilerGenerated]
		set
		{
			yWS41SNwlD = value;
		}
	}

	public MCvPoint3D32f TargetVX
	{
		[CompilerGenerated]
		get
		{
			return GCu4OIn6ax;
		}
		[CompilerGenerated]
		set
		{
			GCu4OIn6ax = value;
		}
	}

	public MCvPoint3D32f TargetVY
	{
		[CompilerGenerated]
		get
		{
			return NEj460jDvh;
		}
		[CompilerGenerated]
		set
		{
			NEj460jDvh = value;
		}
	}

	public MCvPoint3D32f TargetVZ
	{
		[CompilerGenerated]
		get
		{
			return aTy4HPYTmm;
		}
		[CompilerGenerated]
		set
		{
			aTy4HPYTmm = value;
		}
	}

	public PointF TargetPO
	{
		[CompilerGenerated]
		get
		{
			return bKC4jJmGHd;
		}
		[CompilerGenerated]
		set
		{
			bKC4jJmGHd = value;
		}
	}

	public PointF TargetPX
	{
		[CompilerGenerated]
		get
		{
			return bu34RkdUi8;
		}
		[CompilerGenerated]
		set
		{
			bu34RkdUi8 = value;
		}
	}

	public PointF TargetPY
	{
		[CompilerGenerated]
		get
		{
			return S3Z4vmBbjr;
		}
		[CompilerGenerated]
		set
		{
			S3Z4vmBbjr = value;
		}
	}

	public PointF[]? DetectedBoardPoints
	{
		[CompilerGenerated]
		get
		{
			return bcB493dYw7;
		}
		[CompilerGenerated]
		set
		{
			bcB493dYw7 = value;
		}
	}

	public void Dispose()
	{
		Rectification?.Dispose();
		Projection?.Dispose();
		CameraMatrix?.Dispose();
		DistCoefficient?.Dispose();
		TargetRotation?.Dispose();
		TargetTranslation?.Dispose();
	}

	public CalibrationResult()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		ghd4XELtx3 = string.Empty;
		bcB493dYw7 = Array.Empty<PointF>();
		base._002Ector();
	}
}
