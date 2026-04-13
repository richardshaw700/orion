using System;
using System.Runtime.CompilerServices;
using System.Windows;
using IDRAAutoCalibration.Models;
using IodKeMsDBY9RwTYmwo;
using MvCamCtrl.NET;
using PkY9gMOXojJgyukQM0;
using mMWtJPWctee66WM7q3;
using snShylJydZoCndilho;
using wNUVKQn3fCWBqcQOwZ;

namespace IDRAAutoCalibration.Services;

public class HikrobotDevice : IDisposable
{
	[CompilerGenerated]
	private DeviceMode TB5kXor1H9;

	private MyCamera V5VkMlHjcu;

	private MyCamera.MV_CC_DEVICE_INFO EJykk57FDC;

	private CameraRotation pW3kdLjP8y;

	private string osqkrhwAxI;

	private string rfxkJwGCP9;

	private bool uvJk4im0wY;

	private bool oGRkn1x7XZ;

	[CompilerGenerated]
	private bool KhHk1hsLe5;

	private Rect oBxkOMHbxl;

	public DeviceMode Mode
	{
		[CompilerGenerated]
		get
		{
			return TB5kXor1H9;
		}
		[CompilerGenerated]
		set
		{
			TB5kXor1H9 = value;
		}
	}

	public bool IsGrabbing
	{
		[CompilerGenerated]
		get
		{
			return KhHk1hsLe5;
		}
		[CompilerGenerated]
		private set
		{
			KhHk1hsLe5 = value;
		}
	}

	public string GetSerialNumber()
	{
		return osqkrhwAxI;
	}

	public string GetSnModel()
	{
		return osqkrhwAxI + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3770) + rfxkJwGCP9;
	}

	public HikrobotDevice(DeviceMode mode, MyCamera.MV_CC_DEVICE_INFO handle, string serialNumber, string model)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		oBxkOMHbxl = new Rect(0.0, 0.0, 540.0, 720.0);
		base._002Ector();
		Mode = mode;
		EJykk57FDC = handle;
		osqkrhwAxI = serialNumber;
		rfxkJwGCP9 = model;
		V5VkMlHjcu = new MyCamera();
	}

	public string PrintDeviceProperties()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 3);
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3780));
		defaultInterpolatedStringHandler.AppendFormatted(Enum.GetName(typeof(DeviceMode), Mode));
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3802));
		defaultInterpolatedStringHandler.AppendFormatted(osqkrhwAxI);
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3858));
		defaultInterpolatedStringHandler.AppendFormatted(rfxkJwGCP9);
		string text = defaultInterpolatedStringHandler.ToStringAndClear();
		Console.WriteLine(text);
		return text;
	}

	public void OpenDevice()
	{
		if (V5VkMlHjcu.MV_CC_CreateDevice_NET(ref EJykk57FDC) != 0)
		{
			return;
		}
		uvJk4im0wY = true;
		int num = V5VkMlHjcu.MV_CC_OpenDevice_NET();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
		string text = defaultInterpolatedStringHandler.ToStringAndClear();
		if (num != 0)
		{
			V5VkMlHjcu.MV_CC_DestroyDevice_NET();
			Console.WriteLine(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3890) + text);
			return;
		}
		oGRkn1x7XZ = true;
		zyLM2NDyNM(MyCamera.MV_CAM_TRIGGER_MODE.MV_TRIGGER_MODE_OFF);
		V5VkMlHjcu.MV_CC_SetGrabStrategy_NET(MyCamera.MV_GRAB_STRATEGY.MV_GrabStrategy_LatestImagesOnly);
		num = V5VkMlHjcu.MV_CC_SetImageNodeNum_NET(800u);
		pW3kdLjP8y = zQjMg4hVPV();
		if (Mode == DeviceMode.MASTER)
		{
			zyLM2NDyNM(MyCamera.MV_CAM_TRIGGER_MODE.MV_TRIGGER_MODE_OFF);
			XZgMGuIuuQ(MyCamera.MV_CAM_TRIGGER_SOURCE.MV_TRIGGER_SOURCE_LINE0);
			iaGMbJT5og(1u);
			C0SMiAlnjN((DbvIjsrBO8xZ4slNBQ)8);
			iVgMaUNoM1(HikrobotParameter.StrobeEnable, _0020: true);
		}
		else
		{
			zyLM2NDyNM(MyCamera.MV_CAM_TRIGGER_MODE.MV_TRIGGER_MODE_ON);
			AwrMFjgRwi(_0020: true);
		}
		YdSMNPcHOp((rfxkJwGCP9 == xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3946)) ? ((Y5EQpC4xB8GTrcekkF)2) : ((Y5EQpC4xB8GTrcekkF)0));
		V5VkMlHjcu.MV_CC_SetEnumValueByString_NET(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3976), xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3996));
		TnbMCTJbA8(HikrobotParameter.Gain);
		CrQMBWW6rR(HikrobotParameter.Gain, ApplicationSettings.Current.Gain);
		CrQMBWW6rR(HikrobotParameter.ExposureTime, ApplicationSettings.Current.Exposure);
		MyCamera.MV_CC_COLOR_CORRECT_PARAM pstColorCorrectParam = default(MyCamera.MV_CC_COLOR_CORRECT_PARAM);
		V5VkMlHjcu.MV_CC_ColorCorrect_NET(ref pstColorCorrectParam);
		MyCamera.MV_CC_FILE_ACCESS pstFileAccess = default(MyCamera.MV_CC_FILE_ACCESS);
		V5VkMlHjcu.MV_CC_FileAccessRead_NET(ref pstFileAccess);
	}

	private CameraRotation zQjMg4hVPV()
	{
		if (Mode != DeviceMode.MASTER)
		{
			return qIuX4r1axfa2Uf2YKa.Ts1kvluYBH();
		}
		return qIuX4r1axfa2Uf2YKa.oTSkRVrvYD();
	}

	public Rect GetCurrentImageROI()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		MyCamera.MVCC_INTVALUE pstValue = default(MyCamera.MVCC_INTVALUE);
		MyCamera.MVCC_INTVALUE pstValue2 = default(MyCamera.MVCC_INTVALUE);
		int num = V5VkMlHjcu.MV_CC_GetWidth_NET(ref pstValue);
		if (num != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 1);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4006));
			defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		num = V5VkMlHjcu.MV_CC_GetHeight_NET(ref pstValue2);
		if (num != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 1);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4090));
			defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return new Rect(0.0, 0.0, (double)(int)pstValue.nCurValue, (double)(int)pstValue2.nCurValue);
	}

	public CameraRotation GetCameraRotation()
	{
		return pW3kdLjP8y;
	}

	public Rect GetMaxImageROI()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return oBxkOMHbxl;
	}

	public bool StartLowSpeedAcquisition()
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return (byte)(1u & (PleMEgFcNw(default(Rect)) ? 1u : 0u) & (U7LMPf87tZ(500f) ? 1u : 0u)) != 0;
	}

	public bool StartHighSpeedAcquisition()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		return (byte)(1u & (PleMEgFcNw(new Rect(0.0, 0.0, 180.0, 720.0)) ? 1u : 0u) & (U7LMPf87tZ(1300f) ? 1u : 0u)) != 0;
	}

	private bool U7LMPf87tZ(float P_0)
	{
		int num = (int)(1u & (iVgMaUNoM1(HikrobotParameter.AcquisitionFrameRateEnable, _0020: true) ? 1u : 0u)) & (CrQMBWW6rR(HikrobotParameter.AcquisitionFrameRate, P_0) ? 1 : 0);
		float num2 = TnbMCTJbA8(HikrobotParameter.AcquisitionFrameRate);
		return (byte)((uint)num & ((num2 == P_0) ? 1u : 0u)) != 0;
	}

	public DeviceInfo GetDeviceInfo()
	{
		return new DeviceInfo
		{
			SerialNumber = GetSerialNumber(),
			DeviceLinkCurrent = m2MMytQFTd(HikrobotParameter.DeviceLinkCurrentThroughput),
			DeviceVersion = M0eMc30csw(HikrobotParameter.DeviceVersion),
			DeviceFirmwareVersion = M0eMc30csw(HikrobotParameter.DeviceFirmwareVersion),
			IsUsbSpeedMode = (KGmMTtelfN(HikrobotParameter.USBSpeedMode) == 8),
			U3VCurrentSpeed = m2MMytQFTd(HikrobotParameter.U3VCurrentSpeed)
		};
	}

	public float GetResultingFPS()
	{
		return TnbMCTJbA8(HikrobotParameter.ResultingFrameRate);
	}

	public float GetSetFPS()
	{
		return TnbMCTJbA8(HikrobotParameter.AcquisitionFrameRate);
	}

	private bool PleMEgFcNw(Rect P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		Rect maxImageROI = GetMaxImageROI();
		if (((Rect)(ref P_0)).Height == 0.0 || ((Rect)(ref P_0)).Width == 0.0)
		{
			P_0 = maxImageROI;
		}
		((Rect)(ref P_0)).X = 4.0 * (((Rect)(ref P_0)).X / 4.0);
		((Rect)(ref P_0)).Y = 4.0 * (((Rect)(ref P_0)).Y / 4.0);
		((Rect)(ref P_0)).Width = 4.0 * (((Rect)(ref P_0)).Width / 4.0);
		((Rect)(ref P_0)).Height = 4.0 * (((Rect)(ref P_0)).Height / 4.0);
		CI5MQnjikL(HikrobotParameter.OffsetX, 0u);
		CI5MQnjikL(HikrobotParameter.OffsetY, 0u);
		CI5MQnjikL(HikrobotParameter.Width, 32u);
		CI5MQnjikL(HikrobotParameter.Height, 32u);
		if (pW3kdLjP8y == CameraRotation.CAMERA_ROTATION_270)
		{
			CI5MQnjikL(HikrobotParameter.OffsetX, (uint)((Rect)(ref P_0)).Y);
			CI5MQnjikL(HikrobotParameter.OffsetY, (uint)((Rect)(ref P_0)).X);
			CI5MQnjikL(HikrobotParameter.Width, (uint)((Rect)(ref P_0)).Height);
			CI5MQnjikL(HikrobotParameter.Height, (uint)((Rect)(ref P_0)).Width);
		}
		else if (pW3kdLjP8y == CameraRotation.CAMERA_ROTATION_90)
		{
			CI5MQnjikL(HikrobotParameter.OffsetX, (uint)(((Rect)(ref maxImageROI)).Height - (((Rect)(ref P_0)).Y + ((Rect)(ref P_0)).Height)));
			CI5MQnjikL(HikrobotParameter.OffsetY, (uint)(((Rect)(ref maxImageROI)).Width - (((Rect)(ref P_0)).X + ((Rect)(ref P_0)).Width)));
			CI5MQnjikL(HikrobotParameter.Width, (uint)((Rect)(ref P_0)).Height);
			CI5MQnjikL(HikrobotParameter.Height, (uint)((Rect)(ref P_0)).Width);
		}
		else if (pW3kdLjP8y == CameraRotation.CAMERA_ROTATION_180)
		{
			CI5MQnjikL(HikrobotParameter.OffsetX, (uint)(((Rect)(ref maxImageROI)).Width - (((Rect)(ref P_0)).X + ((Rect)(ref P_0)).Width)));
			CI5MQnjikL(HikrobotParameter.OffsetY, (uint)(((Rect)(ref maxImageROI)).Height - (((Rect)(ref P_0)).Y + ((Rect)(ref P_0)).Height)));
			CI5MQnjikL(HikrobotParameter.Width, (uint)((Rect)(ref P_0)).Width);
			CI5MQnjikL(HikrobotParameter.Height, (uint)((Rect)(ref P_0)).Height);
		}
		else
		{
			CI5MQnjikL(HikrobotParameter.OffsetX, (uint)((Rect)(ref P_0)).X);
			CI5MQnjikL(HikrobotParameter.OffsetY, (uint)((Rect)(ref P_0)).Y);
			CI5MQnjikL(HikrobotParameter.Width, (uint)((Rect)(ref P_0)).Width);
			CI5MQnjikL(HikrobotParameter.Height, (uint)((Rect)(ref P_0)).Height);
		}
		return true;
	}

	public uint GetAdcBitDepth()
	{
		uint num = KGmMTtelfN(HikrobotParameter.ADCBitDepth);
		Y5EQpC4xB8GTrcekkF y5EQpC4xB8GTrcekkF = (Y5EQpC4xB8GTrcekkF)Enum.Parse(typeof(Y5EQpC4xB8GTrcekkF), num.ToString());
		if (rfxkJwGCP9 == xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3946))
		{
			switch (y5EQpC4xB8GTrcekkF)
			{
			case (Y5EQpC4xB8GTrcekkF)0:
				return 12u;
			case (Y5EQpC4xB8GTrcekkF)2:
				return 8u;
			}
		}
		else
		{
			switch (y5EQpC4xB8GTrcekkF)
			{
			case (Y5EQpC4xB8GTrcekkF)3:
				return 12u;
			case (Y5EQpC4xB8GTrcekkF)0:
				return 8u;
			}
		}
		throw new Exception(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4176));
	}

	private bool CI5MQnjikL(HikrobotParameter P_0, uint P_1)
	{
		int num = V5VkMlHjcu.MV_CC_SetIntValue_NET(P_0.ToString(), P_1);
		if (num != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 3);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4234));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4290));
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4302));
			defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return true;
	}

	private bool iVgMaUNoM1(HikrobotParameter P_0, bool P_1)
	{
		int num = V5VkMlHjcu.MV_CC_SetBoolValue_NET(P_0.ToString(), P_1);
		if (num != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 3);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4234));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4290));
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4302));
			defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return true;
	}

	private bool CrQMBWW6rR(HikrobotParameter P_0, float P_1)
	{
		int num = V5VkMlHjcu.MV_CC_SetFloatValue_NET(P_0.ToString(), P_1);
		if (num != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 3);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4234));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4290));
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4302));
			defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return true;
	}

	private float TnbMCTJbA8(HikrobotParameter P_0)
	{
		MyCamera.MVCC_FLOATVALUE pstValue = default(MyCamera.MVCC_FLOATVALUE);
		int num = V5VkMlHjcu.MV_CC_GetFloatValue_NET(P_0.ToString(), ref pstValue);
		if (num != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(48, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4338));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4394));
			defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return pstValue.fCurValue;
	}

	private uint m2MMytQFTd(HikrobotParameter P_0)
	{
		MyCamera.MVCC_INTVALUE pstValue = default(MyCamera.MVCC_INTVALUE);
		int num = V5VkMlHjcu.MV_CC_GetIntValue_NET(P_0.ToString(), ref pstValue);
		if (num != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(48, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4338));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4394));
			defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return pstValue.nCurValue;
	}

	private uint KGmMTtelfN(HikrobotParameter P_0)
	{
		MyCamera.MVCC_ENUMVALUE pstValue = default(MyCamera.MVCC_ENUMVALUE);
		int num = V5VkMlHjcu.MV_CC_GetEnumValue_NET(P_0.ToString(), ref pstValue);
		if (num != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(48, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4338));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4394));
			defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return pstValue.nCurValue;
	}

	private string M0eMc30csw(HikrobotParameter P_0)
	{
		MyCamera.MVCC_STRINGVALUE pstValue = default(MyCamera.MVCC_STRINGVALUE);
		int num = V5VkMlHjcu.MV_CC_GetStringValue_NET(P_0.ToString(), ref pstValue);
		if (num != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(48, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4338));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4394));
			defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return pstValue.chCurValue;
	}

	private bool zyLM2NDyNM(MyCamera.MV_CAM_TRIGGER_MODE P_0)
	{
		int num = V5VkMlHjcu.MV_CC_SetEnumValue_NET(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4442), (uint)P_0);
		if (num != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4468));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4302));
			defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return true;
	}

	private bool XZgMGuIuuQ(MyCamera.MV_CAM_TRIGGER_SOURCE P_0)
	{
		int num = V5VkMlHjcu.MV_CC_SetEnumValue_NET(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4532), (uint)P_0);
		if (num != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(48, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4562));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4302));
			defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return true;
	}

	private bool AwrMFjgRwi(bool P_0)
	{
		int num = V5VkMlHjcu.MV_CC_SetBoolValue_NET(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4630), P_0);
		if (num != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(54, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4670));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4302));
			defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return true;
	}

	private bool YdSMNPcHOp(Y5EQpC4xB8GTrcekkF P_0)
	{
		int num = V5VkMlHjcu.MV_CC_SetEnumValue_NET(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4750), (uint)P_0);
		if (num != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4776));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4302));
			defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return true;
	}

	private bool iaGMbJT5og(uint P_0)
	{
		int num = V5VkMlHjcu.MV_CC_SetEnumValue_NET(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4840), P_0);
		if (num != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4868));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4302));
			defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return true;
	}

	private bool C0SMiAlnjN(DbvIjsrBO8xZ4slNBQ P_0)
	{
		int num = V5VkMlHjcu.MV_CC_SetEnumValue_NET(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4934), (uint)P_0);
		if (num != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4868));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4302));
			defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return true;
	}

	private uint J7UMz6t0EG()
	{
		MyCamera.MVCC_INTVALUE pstValue = default(MyCamera.MVCC_INTVALUE);
		int num = V5VkMlHjcu.MV_CC_GetIntValue_NET(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4954), ref pstValue);
		if (num != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(4980));
			defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return pstValue.nCurValue;
	}

	public Frame GetFrame()
	{
		if (!IsGrabbing)
		{
			return new Frame();
		}
		MyCamera.MV_FRAME_OUT pFrame = default(MyCamera.MV_FRAME_OUT);
		int num = V5VkMlHjcu.MV_CC_GetImageBuffer_NET(ref pFrame, 500);
		Frame frame = new Frame();
		if (num == 0)
		{
			uint nDevTimeStampHigh = pFrame.stFrameInfo.nDevTimeStampHigh;
			frame.Timestamp = nDevTimeStampHigh + pFrame.stFrameInfo.nDevTimeStampLow;
			frame.Height = pFrame.stFrameInfo.nHeight;
			frame.Width = pFrame.stFrameInfo.nWidth;
			frame.BufferImgAdr = pFrame.pBufAddr;
			frame.FrameNumber = pFrame.stFrameInfo.nFrameNum;
			V5VkMlHjcu.MV_CC_FreeImageBuffer_NET(ref pFrame);
			return frame;
		}
		return new Frame();
	}

	public void StartGrabbing()
	{
		if (!IsGrabbing)
		{
			int num = V5VkMlHjcu.MV_CC_StartGrabbing_NET();
			if (num != 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
				defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5032));
				defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
				throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			IsGrabbing = true;
		}
	}

	public void StopGrabbing()
	{
		if (IsGrabbing)
		{
			int num = V5VkMlHjcu.MV_CC_StopGrabbing_NET();
			if (num != 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
				defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5080));
				defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
				throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			IsGrabbing = false;
		}
	}

	public void Dispose()
	{
		if (oGRkn1x7XZ)
		{
			int num = V5VkMlHjcu.MV_CC_CloseDevice_NET();
			if (num != 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
				defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5126));
				defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
				throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			oGRkn1x7XZ = false;
		}
		if (uvJk4im0wY)
		{
			int num2 = V5VkMlHjcu.MV_CC_DestroyDevice_NET();
			if (num2 != 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
				defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5170));
				defaultInterpolatedStringHandler.AppendFormatted(num2, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3882));
				throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			uvJk4im0wY = false;
		}
	}
}
