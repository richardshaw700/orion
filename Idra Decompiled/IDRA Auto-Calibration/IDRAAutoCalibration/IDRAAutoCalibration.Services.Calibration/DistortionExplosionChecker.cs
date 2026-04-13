using System;
using System.Collections.Generic;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Util;
using IodKeMsDBY9RwTYmwo;

namespace IDRAAutoCalibration.Services.Calibration;

public static class DistortionExplosionChecker
{
	public static DistortionExplosionReport AnalyzeCamera(Mat K, Mat D, Size imgSize, int stepPx = 40, double edgeBandPercent = 0.18, double edgeMaxThresholdPx = 110.0, double edgeP95ThresholdPx = 30.0, double edgeHighPxThreshold = 55.0, double edgeHighRatioThreshold = 0.06, double foldAreaEps = 0.15)
	{
		if (K == null || K.IsEmpty)
		{
			throw new ArgumentException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(7648));
		}
		if (D == null || D.IsEmpty)
		{
			throw new ArgumentException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(7682));
		}
		if (imgSize.Width <= 0 || imgSize.Height <= 0)
		{
			throw new ArgumentException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(7716));
		}
		if (stepPx < 8)
		{
			throw new ArgumentException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(7756));
		}
		int num;
		int num2;
		using VectorOfPointF vectorOfPointF = new VectorOfPointF(iMud9tnDh9(imgSize, stepPx, out num, out num2));
		using VectorOfPointF vectorOfPointF2 = new VectorOfPointF();
		CvInvoke.UndistortPoints(vectorOfPointF, vectorOfPointF2, K, D, null, K);
		PointF[] array = vectorOfPointF.ToArray();
		PointF[] array2 = vectorOfPointF2.ToArray();
		int val = (int)Math.Round((double)Math.Min(imgSize.Width, imgSize.Height) * edgeBandPercent);
		val = Math.Max(val, stepPx);
		List<double> list = new List<double>(array.Length);
		int num3 = 0;
		for (int i = 0; i < array.Length; i++)
		{
			double num4 = array2[i].X - array[i].X;
			double num5 = array2[i].Y - array[i].Y;
			double num6 = Math.Sqrt(num4 * num4 + num5 * num5);
			if (zkVdUarqtO(array[i], imgSize, val))
			{
				list.Add(num6);
				if (num6 >= edgeHighPxThreshold)
				{
					num3++;
				}
			}
		}
		if (list.Count == 0)
		{
			return new DistortionExplosionReport
			{
				Exploded = true,
				EdgeMaxPx = double.PositiveInfinity,
				EdgeP95Px = double.PositiveInfinity,
				EdgeMedianPx = double.PositiveInfinity,
				EdgeHighRatio = 1.0,
				FoldingCells = int.MaxValue,
				MinCellArea = 0.0
			};
		}
		list.Sort();
		double num7 = list[list.Count - 1];
		double edgeMedianPx = y2edhtsbMo(list, 50);
		double num8 = y2edhtsbMo(list, 95);
		double num9 = (double)num3 / (double)list.Count;
		int num10 = 0;
		double num11 = double.PositiveInfinity;
		int num12 = 0;
		for (int j = 0; j < num2 - 1; j++)
		{
			for (int k = 0; k < num - 1; k++)
			{
				int num13 = j * num + k;
				int num14 = j * num + (k + 1);
				int num15 = (j + 1) * num + k;
				PointF pointF = array2[num13];
				PointF pointF2 = array2[num14];
				PointF pointF3 = array2[num15];
				double num16 = pointF2.X - pointF.X;
				double num17 = pointF2.Y - pointF.Y;
				double num18 = pointF3.X - pointF.X;
				double num19 = pointF3.Y - pointF.Y;
				double value = num16 * num19 - num17 * num18;
				double num20 = Math.Abs(value);
				if (num20 < num11)
				{
					num11 = num20;
				}
				if (num12 == 0 && num20 > foldAreaEps)
				{
					num12 = Math.Sign(value);
				}
				bool num21 = num20 < foldAreaEps;
				bool flag = num12 != 0 && Math.Sign(value) != num12;
				if (num21 || flag)
				{
					num10++;
				}
			}
		}
		if (double.IsInfinity(num11))
		{
			num11 = 0.0;
		}
		bool exploded = num7 >= edgeMaxThresholdPx || num8 >= edgeP95ThresholdPx || num9 >= edgeHighRatioThreshold || num10 > 0;
		return new DistortionExplosionReport
		{
			Exploded = exploded,
			EdgeMaxPx = num7,
			EdgeP95Px = num8,
			EdgeMedianPx = edgeMedianPx,
			EdgeHighRatio = num9,
			FoldingCells = num10,
			MinCellArea = num11
		};
	}

	public static bool IsExplosionDetectedEither(Mat K1, Mat D1, Size size1, Mat K2, Mat D2, Size size2, out DistortionExplosionReport master, out DistortionExplosionReport slave)
	{
		master = AnalyzeCamera(K1, D1, size1);
		slave = AnalyzeCamera(K2, D2, size2);
		if (!master.Exploded)
		{
			return slave.Exploded;
		}
		return true;
	}

	private static PointF[] iMud9tnDh9(Size P_0, int P_1, out int P_2, out int P_3)
	{
		List<PointF> list = new List<PointF>();
		List<int> list2 = new List<int>();
		for (int i = 0; i < P_0.Width; i += P_1)
		{
			list2.Add(i);
		}
		if (list2.Count != 0)
		{
			if (list2[list2.Count - 1] == P_0.Width - 1)
			{
				goto IL_0061;
			}
		}
		list2.Add(P_0.Width - 1);
		goto IL_0061;
		IL_0061:
		List<int> list3 = new List<int>();
		for (int j = 0; j < P_0.Height; j += P_1)
		{
			list3.Add(j);
		}
		if (list3.Count != 0)
		{
			if (list3[list3.Count - 1] == P_0.Height - 1)
			{
				goto IL_00c1;
			}
		}
		list3.Add(P_0.Height - 1);
		goto IL_00c1;
		IL_00c1:
		P_2 = list2.Count;
		P_3 = list3.Count;
		for (int k = 0; k < list3.Count; k++)
		{
			for (int l = 0; l < list2.Count; l++)
			{
				list.Add(new PointF(list2[l], list3[k]));
			}
		}
		return list.ToArray();
	}

	private static bool zkVdUarqtO(PointF P_0, Size P_1, int P_2)
	{
		if (!(P_0.X <= (float)P_2) && !(P_0.Y <= (float)P_2) && !(P_0.X >= (float)(P_1.Width - 1 - P_2)))
		{
			return P_0.Y >= (float)(P_1.Height - 1 - P_2);
		}
		return true;
	}

	private static double y2edhtsbMo(List<double> P_0, int P_1)
	{
		if (P_0.Count == 0)
		{
			return 0.0;
		}
		double num = (double)P_1 / 100.0 * (double)(P_0.Count - 1);
		int num2 = (int)Math.Floor(num);
		int num3 = (int)Math.Ceiling(num);
		if (num2 == num3)
		{
			return P_0[num2];
		}
		double num4 = num - (double)num2;
		return P_0[num2] * (1.0 - num4) + P_0[num3] * num4;
	}
}
