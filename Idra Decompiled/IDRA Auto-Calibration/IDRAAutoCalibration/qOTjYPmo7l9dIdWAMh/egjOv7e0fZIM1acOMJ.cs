using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using IDRAAutoCalibration.Services.Calibration.ValidationMetrics;

namespace qOTjYPmo7l9dIdWAMh;

internal static class egjOv7e0fZIM1acOMJ
{
	public static DotGridMetrics UToJt0bGyI(PointF[] P_0, Size P_1, Size P_2, double P_3)
	{
		int width = P_1.Width;
		int height = P_1.Height;
		if (P_0 == null || P_0.Length != width * height)
		{
			return new DotGridMetrics
			{
				CenterX01 = 0.5,
				CenterY01 = 0.5,
				CoverageArea01 = 0.0,
				DepthProxy = P_3,
				PitchProxy = 0.0,
				RollProxy = 0.0,
				YawProxyDeg = 0.0
			};
		}
		float num = float.MaxValue;
		float num2 = float.MaxValue;
		float num3 = float.MinValue;
		float num4 = float.MinValue;
		for (int i = 0; i < P_0.Length; i++)
		{
			PointF pointF = P_0[i];
			if (pointF.X < num)
			{
				num = pointF.X;
			}
			if (pointF.Y < num2)
			{
				num2 = pointF.Y;
			}
			if (pointF.X > num3)
			{
				num3 = pointF.X;
			}
			if (pointF.Y > num4)
			{
				num4 = pointF.Y;
			}
		}
		double num5 = 0.5 * (double)(num + num3);
		double num6 = 0.5 * (double)(num2 + num4);
		double num7 = num5 / (double)Math.Max(1, P_2.Width);
		double num8 = num6 / (double)Math.Max(1, P_2.Height);
		double num9 = Math.Max(1.0, num3 - num);
		double num10 = Math.Max(1.0, num4 - num2);
		double num11 = num9 * num10 / (Math.Max(1.0, P_2.Width) * Math.Max(1.0, P_2.Height));
		double num12 = YpEJ0okCTh(P_0, 0, width);
		double pitchProxy = nTyJoUmSK0(YpEJ0okCTh(P_0, height - 1, width), num12) - 1.0;
		double num13 = XYbJwpQPCN(P_0, 0, width, height);
		double rollProxy = nTyJoUmSK0(XYbJwpQPCN(P_0, width - 1, width, height), num13) - 1.0;
		PointF pointF2 = P_0[0];
		PointF pointF3 = P_0[width - 1];
		double num14 = Math.Atan2(pointF3.Y - pointF2.Y, pointF3.X - pointF2.X) * (180.0 / Math.PI);
		return new DotGridMetrics
		{
			CenterX01 = D3gJly0BIx(num7),
			CenterY01 = D3gJly0BIx(num8),
			CoverageArea01 = D3gJly0BIx(num11),
			DepthProxy = P_3,
			PitchProxy = pitchProxy,
			RollProxy = rollProxy,
			YawProxyDeg = QidJLSYI1W(num14)
		};
	}

	[CompilerGenerated]
	internal static double YpEJ0okCTh(PointF[] P_0, int P_1, int P_2)
	{
		int num = P_1 * P_2;
		double num2 = 0.0;
		for (int i = 0; i < P_2 - 1; i++)
		{
			num2 += (double)Math.Abs(P_0[num + i + 1].X - P_0[num + i].X);
		}
		return num2 / (double)Math.Max(1, P_2 - 1);
	}

	[CompilerGenerated]
	internal static double XYbJwpQPCN(PointF[] P_0, int P_1, int P_2, int P_3)
	{
		double num = 0.0;
		for (int i = 0; i < P_3 - 1; i++)
		{
			num += (double)Math.Abs(P_0[(i + 1) * P_2 + P_1].Y - P_0[i * P_2 + P_1].Y);
		}
		return num / (double)Math.Max(1, P_3 - 1);
	}

	[CompilerGenerated]
	internal static double nTyJoUmSK0(double P_0, double P_1)
	{
		if (!(Math.Abs(P_1) < 1E-09))
		{
			return P_0 / P_1;
		}
		return 1.0;
	}

	[CompilerGenerated]
	internal static double D3gJly0BIx(double P_0)
	{
		if (!(P_0 < 0.0))
		{
			if (!(P_0 > 1.0))
			{
				return P_0;
			}
			return 1.0;
		}
		return 0.0;
	}

	[CompilerGenerated]
	internal static double QidJLSYI1W(double P_0)
	{
		while (P_0 > 90.0)
		{
			P_0 -= 180.0;
		}
		while (P_0 < -90.0)
		{
			P_0 += 180.0;
		}
		return P_0;
	}
}
