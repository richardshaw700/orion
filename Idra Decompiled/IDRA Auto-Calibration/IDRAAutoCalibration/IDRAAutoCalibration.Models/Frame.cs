using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.CvEnum;
using GIToolkit.Services;
using IDRAAutoCalibration.Services;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration.Models;

public class Frame : IDisposable
{
	[CompilerGenerated]
	private uint OOhJCC9uNG;

	[CompilerGenerated]
	private uint qrHJyAMgLq;

	[CompilerGenerated]
	private uint VBnJTWkeC0;

	[CompilerGenerated]
	private nint LWaJcE4fBe;

	[CompilerGenerated]
	private int hQKJ2avqDi;

	[CompilerGenerated]
	private int umJJGb4EWC;

	[CompilerGenerated]
	private bool sMnJFqBciY;

	private readonly object WM3JNH6jhg;

	public uint Id
	{
		[CompilerGenerated]
		get
		{
			return OOhJCC9uNG;
		}
		[CompilerGenerated]
		set
		{
			OOhJCC9uNG = value;
		}
	}

	public uint FrameNumber
	{
		[CompilerGenerated]
		get
		{
			return qrHJyAMgLq;
		}
		[CompilerGenerated]
		set
		{
			qrHJyAMgLq = value;
		}
	}

	public uint Timestamp
	{
		[CompilerGenerated]
		get
		{
			return VBnJTWkeC0;
		}
		[CompilerGenerated]
		set
		{
			VBnJTWkeC0 = value;
		}
	}

	public nint BufferImgAdr
	{
		[CompilerGenerated]
		get
		{
			return LWaJcE4fBe;
		}
		[CompilerGenerated]
		set
		{
			LWaJcE4fBe = value;
		}
	}

	public int Height
	{
		[CompilerGenerated]
		get
		{
			return hQKJ2avqDi;
		}
		[CompilerGenerated]
		set
		{
			hQKJ2avqDi = value;
		}
	}

	public int Width
	{
		[CompilerGenerated]
		get
		{
			return umJJGb4EWC;
		}
		[CompilerGenerated]
		set
		{
			umJJGb4EWC = value;
		}
	}

	public bool IsHighSpeed
	{
		[CompilerGenerated]
		get
		{
			return sMnJFqBciY;
		}
		[CompilerGenerated]
		set
		{
			sMnJFqBciY = value;
		}
	}

	public void Dispose()
	{
		lock (WM3JNH6jhg)
		{
			if (BufferImgAdr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(BufferImgAdr);
				BufferImgAdr = IntPtr.Zero;
			}
		}
	}

	public bool IsInvalidImage()
	{
		if (BufferImgAdr != IntPtr.Zero)
		{
			return FrameNumber == 0;
		}
		return true;
	}

	public Mat? GetImage(CameraRotation cameraRotation)
	{
		lock (WM3JNH6jhg)
		{
			Mat mat = null;
			try
			{
				if (BufferImgAdr == IntPtr.Zero)
				{
					return mat;
				}
				using Mat mat2 = new Mat(new Size(Width, Height), DepthType.Cv8U, 1, BufferImgAdr, 0);
				if (mat2.IsEmpty)
				{
					return mat;
				}
				mat = new Mat();
				CvInvoke.CvtColor(mat2, mat, ColorConversion.BayerBg2Bgr);
				CvInvoke.Rotate(mat, mat, (RotateFlags)cameraRotation);
			}
			catch (Exception ex)
			{
				EventViewerLogger.LogException(ex);
			}
			return mat;
		}
	}

	public Frame()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		LWaJcE4fBe = IntPtr.Zero;
		WM3JNH6jhg = new object();
		base._002Ector();
	}
}
