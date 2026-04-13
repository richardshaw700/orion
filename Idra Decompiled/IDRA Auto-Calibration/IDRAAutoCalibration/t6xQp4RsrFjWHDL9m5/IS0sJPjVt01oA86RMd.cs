using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using IDRAAutoCalibration.DTO.Calibration;
using IDRAAutoCalibration.Services.Calibration;
using IodKeMsDBY9RwTYmwo;
using cibwYfp1iGN979yZlM;
using mMWtJPWctee66WM7q3;
using pgfqOKHc7YGvlOHApI;

namespace t6xQp4RsrFjWHDL9m5;

internal class IS0sJPjVt01oA86RMd
{
	public delegate void YoqGKWSB1WUwkSv6yD(string message);

	[CompilerGenerated]
	private StereoCalibrationResult ytNdN2tsPH;

	private readonly znGoeE6qUpb635LS5V XordbTNGDE;

	private readonly Dictionary<ValidationValueType, CalibrationValidationValue> wCxdi9GYw8;

	public YoqGKWSB1WUwkSv6yD? S6vdzmXvpc;

	public IS0sJPjVt01oA86RMd(StereoCalibrationResult P_0)
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		ytNdN2tsPH = P_0;
		XordbTNGDE = new znGoeE6qUpb635LS5V(ytNdN2tsPH);
		wCxdi9GYw8 = new Dictionary<ValidationValueType, CalibrationValidationValue>();
		base._002Ector();
	}

	private void Bm3dYj4Pyq(ValidationValueType P_0, double P_1, bool P_2)
	{
		wCxdi9GYw8[P_0] = new CalibrationValidationValue(P_0, P_1, P_2);
	}

	private float EVEdDSDWVL(ValidationValueType P_0)
	{
		return (float)wCxdi9GYw8[P_0].Value;
	}

	private bool ekgdgKW44C(ValidationValueType P_0)
	{
		return wCxdi9GYw8[P_0].IsValid;
	}

	public bool QnedPwpMqw()
	{
		string text = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(7792) + Environment.NewLine;
		string text2 = string.Empty;
		bool result = true;
		if (wCxdi9GYw8.Count == 0)
		{
			throw new InvalidOperationException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(7858));
		}
		if (!ekgdgKW44C(ValidationValueType.MasterHandedness) || !ekgdgKW44C(ValidationValueType.SlaveHandedness) || !ekgdgKW44C(ValidationValueType.WorldHandedness))
		{
			result = false;
			text2 = text2 + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(7968) + Environment.NewLine;
		}
		if (EVEdDSDWVL(ValidationValueType.TargetPlaneZSpread) >= 0.02f)
		{
			result = false;
			text2 = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(8020) + Environment.NewLine;
		}
		if (EVEdDSDWVL(ValidationValueType.BoardScaleError) >= 0.06f)
		{
			result = false;
			text2 = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(8092) + Environment.NewLine;
		}
		if (EVEdDSDWVL(ValidationValueType.StereoBaselineErrorPercent) >= 0.2f)
		{
			result = false;
			text2 = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(8156) + Environment.NewLine;
		}
		if (EVEdDSDWVL(ValidationValueType.RmsMaster) >= 0.2f || EVEdDSDWVL(ValidationValueType.RmsSlave) >= 0.2f || EVEdDSDWVL(ValidationValueType.RmsStereo) >= 0.25f)
		{
			result = false;
			text2 = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(8228) + Environment.NewLine;
		}
		if (EVEdDSDWVL(ValidationValueType.StereoReprojectionErrorMaster) >= 0.5f || EVEdDSDWVL(ValidationValueType.StereoReprojectionErrorSlave) >= 0.5f)
		{
			result = false;
			text2 = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(8276) + Environment.NewLine;
		}
		double num = oaBtWW8J5C9uEnllFR.vZB43531sp(ytNdN2tsPH.CameraResults[CameraRole.Master].CameraMatrix, 0, 0);
		if (num < 250.0 || num > 1500.0)
		{
			result = false;
			text2 = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(8350) + Environment.NewLine;
		}
		num = oaBtWW8J5C9uEnllFR.vZB43531sp(ytNdN2tsPH.CameraResults[CameraRole.Slave].CameraMatrix, 0, 0);
		if (num < 250.0 || num > 1500.0)
		{
			result = false;
			text2 = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(8444) + Environment.NewLine;
		}
		if (DistortionExplosionChecker.IsExplosionDetectedEither(ytNdN2tsPH.CameraResults[CameraRole.Master].CameraMatrix, ytNdN2tsPH.CameraResults[CameraRole.Master].DistCoefficient, new Size(540, 720), ytNdN2tsPH.CameraResults[CameraRole.Slave].CameraMatrix, ytNdN2tsPH.CameraResults[CameraRole.Slave].DistCoefficient, new Size(540, 720), out DistortionExplosionReport master, out DistortionExplosionReport slave))
		{
			text2 = text2 + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(8536) + Environment.NewLine;
			text2 = text2 + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(8600) + master?.ToString() + Environment.NewLine;
			text2 = text2 + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(8650) + slave?.ToString() + Environment.NewLine;
			result = false;
		}
		if (text2.Length > 0)
		{
			S6vdzmXvpc?.Invoke(text + text2);
		}
		return result;
	}

	private bool WCsdETI3aD()
	{
		bool flag = ytNdN2tsPH.MasterCalculatedRms < 0.11999999731779099;
		bool flag2 = ytNdN2tsPH.SlaveCalculatedRms < 0.11999999731779099;
		bool flag3 = ytNdN2tsPH.StereoCalculatedRms < 0.15000000596046448;
		Bm3dYj4Pyq(ValidationValueType.RmsMaster, ytNdN2tsPH.MasterCalculatedRms, flag);
		Bm3dYj4Pyq(ValidationValueType.RmsSlave, ytNdN2tsPH.SlaveCalculatedRms, flag2);
		Bm3dYj4Pyq(ValidationValueType.RmsStereo, ytNdN2tsPH.StereoCalculatedRms, flag3);
		return flag && flag2 && flag3;
	}

	private bool rZ2dQAjXvH()
	{
		float num = XordbTNGDE.jq1dKToZeh(CameraRole.Master);
		float num2 = XordbTNGDE.jq1dKToZeh(CameraRole.Slave);
		float num3 = XordbTNGDE.rmWdf8HDbF();
		bool flag = MathF.Abs(num) > 0.9f;
		bool flag2 = MathF.Abs(num2) > 0.9f;
		bool flag3 = num3 > 0.95f;
		Bm3dYj4Pyq(ValidationValueType.MasterHandedness, num, flag);
		Bm3dYj4Pyq(ValidationValueType.SlaveHandedness, num2, flag2);
		Bm3dYj4Pyq(ValidationValueType.WorldHandedness, num3, flag3);
		return flag && flag2 && flag3;
	}

	private bool hEldaKZRyN()
	{
		float num = MathF.Abs(XordbTNGDE.FModemnPfj() - 0.2f) / 0.2f;
		bool flag = num < 0.02f;
		Bm3dYj4Pyq(ValidationValueType.StereoBaselineErrorPercent, num, flag);
		return flag;
	}

	private bool YYMdBvr9dK()
	{
		float num = XordbTNGDE.gLydmHxL2u();
		bool flag = num < 0.01f;
		Bm3dYj4Pyq(ValidationValueType.TargetPlaneZSpread, num, flag);
		return flag;
	}

	private bool vNBdCiVbHo()
	{
		float num = XordbTNGDE.KlddWyHitW(ytNdN2tsPH[CameraRole.Master], XordbTNGDE.qqWd70ewpq(_0020: false), ytNdN2tsPH[CameraRole.Master].DetectedBoardPoints);
		float num2 = XordbTNGDE.KlddWyHitW(ytNdN2tsPH[CameraRole.Slave], XordbTNGDE.qqWd70ewpq(_0020: false), ytNdN2tsPH[CameraRole.Slave].DetectedBoardPoints);
		bool flag = num < 0.3f;
		bool flag2 = num2 < 0.3f;
		Bm3dYj4Pyq(ValidationValueType.StereoReprojectionErrorMaster, num, flag);
		Bm3dYj4Pyq(ValidationValueType.StereoReprojectionErrorSlave, num2, flag2);
		return flag && flag2;
	}

	private bool grUdy1DPFs()
	{
		float num = XordbTNGDE.u76dVMO2u2();
		bool flag = num < 0.05f;
		Bm3dYj4Pyq(ValidationValueType.BoardScaleError, num, flag);
		return flag;
	}

	public bool S6qdTtw9rI()
	{
		wCxdi9GYw8.Clear();
		bool num = WCsdETI3aD();
		bool flag = rZ2dQAjXvH();
		bool flag2 = hEldaKZRyN();
		bool flag3 = YYMdBvr9dK();
		bool flag4 = vNBdCiVbHo();
		bool flag5 = grUdy1DPFs();
		return num && flag && flag2 && flag3 && flag4 && flag5;
	}

	public float gj7dcojdUa()
	{
		if (wCxdi9GYw8.Count == 0)
		{
			throw new InvalidOperationException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(8698));
		}
		float num = 0f;
		float num2 = 0f;
		float num3 = 0.15f * KJ7d2xdpIc(EVEdDSDWVL(ValidationValueType.RmsMaster), 0.05f, 0.12f) + 0.15f * KJ7d2xdpIc(EVEdDSDWVL(ValidationValueType.RmsSlave), 0.05f, 0.12f) + 0.15f * KJ7d2xdpIc(EVEdDSDWVL(ValidationValueType.RmsStereo), 0.06f, 0.15f);
		num += num3;
		num2 += 0.45f;
		float num4 = 0.15f * KJ7d2xdpIc(EVEdDSDWVL(ValidationValueType.StereoReprojectionErrorMaster), 0.05f, 0.3f) + 0.15f * KJ7d2xdpIc(EVEdDSDWVL(ValidationValueType.StereoReprojectionErrorSlave), 0.05f, 0.3f);
		num += num4;
		num2 += 0.3f;
		num += 0.1f * KJ7d2xdpIc(EVEdDSDWVL(ValidationValueType.TargetPlaneZSpread), 0.005f, 0.02f, _0020: true);
		num2 += 0.1f;
		num += 0.05f * KJ7d2xdpIc(EVEdDSDWVL(ValidationValueType.StereoBaselineErrorPercent), 0f, 0.2f);
		num2 += 0.05f;
		num += 0.05f * KJ7d2xdpIc(EVEdDSDWVL(ValidationValueType.BoardScaleError), 0f, 0.05f);
		num2 += 0.05f;
		bool flag = MathF.Abs(EVEdDSDWVL(ValidationValueType.MasterHandedness)) > 0.9f && MathF.Abs(EVEdDSDWVL(ValidationValueType.SlaveHandedness)) > 0.9f && EVEdDSDWVL(ValidationValueType.WorldHandedness) > 0.95f;
		num += (flag ? 0.05f : 0f);
		num2 += 0.05f;
		return MathF.Round(100f * num / num2, 2);
	}

	private static float KJ7d2xdpIc(float P_0, float P_1, float P_2, bool P_3 = false)
	{
		if (P_0 <= P_1)
		{
			return 1f;
		}
		if (P_0 >= P_2)
		{
			return 0f;
		}
		float num = (P_0 - P_1) / (P_2 - P_1);
		float num2 = 1f - num;
		if (P_3)
		{
			num2 *= num2;
		}
		return Math.Clamp(num2, 0f, 1f);
	}

	public List<string> JfXdGkSjoW()
	{
		return (from v in wCxdi9GYw8
			orderby v.Key
			select v.Value.ToString()).ToList();
	}

	public List<string> fo9dFMu4l5()
	{
		List<string> list = new List<string>();
		if (!ekgdgKW44C(ValidationValueType.MasterHandedness) || !ekgdgKW44C(ValidationValueType.SlaveHandedness) || !ekgdgKW44C(ValidationValueType.WorldHandedness))
		{
			list.Add(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(8784));
		}
		if (EVEdDSDWVL(ValidationValueType.TargetPlaneZSpread) >= 0.02f)
		{
			list.Add(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(9000));
		}
		if (EVEdDSDWVL(ValidationValueType.BoardScaleError) >= 0.05f)
		{
			list.Add(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(9216));
		}
		if (EVEdDSDWVL(ValidationValueType.StereoBaselineErrorPercent) >= 0.2f)
		{
			list.Add(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(9448));
		}
		if (EVEdDSDWVL(ValidationValueType.RmsMaster) >= 0.2f || EVEdDSDWVL(ValidationValueType.RmsSlave) >= 0.2f || EVEdDSDWVL(ValidationValueType.RmsStereo) >= 0.25f)
		{
			list.Add(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(9684));
		}
		if (EVEdDSDWVL(ValidationValueType.StereoReprojectionErrorMaster) >= 0.5f || EVEdDSDWVL(ValidationValueType.StereoReprojectionErrorSlave) >= 0.5f)
		{
			list.Add(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(9864));
		}
		return list;
	}
}
