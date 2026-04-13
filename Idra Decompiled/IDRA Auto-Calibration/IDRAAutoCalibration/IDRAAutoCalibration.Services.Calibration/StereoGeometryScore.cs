using System;
using Emgu.CV;
using IDRAAutoCalibration.DTO.Calibration;
using cibwYfp1iGN979yZlM;

namespace IDRAAutoCalibration.Services.Calibration;

public static class StereoGeometryScore
{
	public static float ComputeGeometryScore(StereoCalibrationResult r)
	{
		float num = 0f;
		float num2 = 0f;
		if (r.TranslationVector == null)
		{
			return 0f;
		}
		float num3 = (float)oaBtWW8J5C9uEnllFR.vZB43531sp(r.TranslationVector, 0, 0);
		float num4 = (float)oaBtWW8J5C9uEnllFR.vZB43531sp(r.TranslationVector, 1, 0);
		float num5 = (float)oaBtWW8J5C9uEnllFR.vZB43531sp(r.TranslationVector, 2, 0);
		float num6 = MathF.Sqrt(num3 * num3 + num4 * num4 + num5 * num5);
		if (num6 < 0.0001f)
		{
			return 0f;
		}
		float num7 = MathF.Abs(num5) / num6;
		float num8 = hiIryjTLdx(1f - num7);
		float num9 = 1f;
		float num10 = 0.7f * num8 + 0.3f * num9;
		num += 0.45f * num10;
		num2 += 0.45f;
		if (r.RotationMatrix == null)
		{
			return 0f;
		}
		float num11 = OcJrTHavet(r.RotationMatrix);
		float num12 = rGqrcRwZyq(r.RotationMatrix);
		float num13 = hiIryjTLdx(1f - MathF.Abs(num11 - 1f) * 5f);
		float num14 = hiIryjTLdx(1f - num12 * 5f);
		float num15 = 0.5f * num13 + 0.5f * num14;
		num += 0.55f * num15;
		num2 += 0.55f;
		return MathF.Round(100f * num / num2, 2);
	}

	private static float hiIryjTLdx(float P_0)
	{
		return MathF.Max(0f, MathF.Min(1f, P_0));
	}

	private static float OcJrTHavet(Mat P_0)
	{
		return (float)(oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 0, 0) * (oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 1, 1) * oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 2, 2) - oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 1, 2) * oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 2, 1)) - oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 0, 1) * (oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 1, 0) * oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 2, 2) - oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 1, 2) * oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 2, 0)) + oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 0, 2) * (oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 1, 0) * oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 2, 1) - oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 1, 1) * oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 2, 0)));
	}

	private static float rGqrcRwZyq(Mat P_0)
	{
		double num = oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 0, 0);
		double num2 = oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 0, 1);
		double num3 = oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 0, 2);
		double num4 = oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 1, 0);
		double num5 = oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 1, 1);
		double num6 = oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 1, 2);
		double num7 = oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 2, 0);
		double num8 = oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 2, 1);
		double num9 = oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 2, 2);
		double num10 = num * num + num4 * num4 + num7 * num7;
		double num11 = num * num2 + num4 * num5 + num7 * num8;
		double num12 = num * num3 + num4 * num6 + num7 * num9;
		double num13 = num2 * num + num5 * num4 + num8 * num7;
		double num14 = num2 * num2 + num5 * num5 + num8 * num8;
		double num15 = num2 * num3 + num5 * num6 + num8 * num9;
		double num16 = num3 * num + num6 * num4 + num9 * num7;
		double num17 = num3 * num2 + num6 * num5 + num9 * num8;
		double num18 = num3 * num3 + num6 * num6 + num9 * num9;
		double num19 = num10 - 1.0;
		double num20 = num11;
		double num21 = num12;
		double num22 = num13;
		double num23 = num14 - 1.0;
		double num24 = num15;
		double num25 = num16;
		double num26 = num17;
		double num27 = num18 - 1.0;
		return (float)Math.Sqrt(num19 * num19 + num20 * num20 + num21 * num21 + num22 * num22 + num23 * num23 + num24 * num24 + num25 * num25 + num26 * num26 + num27 * num27);
	}
}
