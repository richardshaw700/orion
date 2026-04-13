using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using cibwYfp1iGN979yZlM;

namespace IDRAAutoCalibration.Services.Calibration;

public static class BoardScaleValidator
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Ec__DisplayClass0_0
	{
		public double No2nAQj7MC;

		public List<double> zCanZi6Px2;

		public List<double> sJQntOTwtd;
	}

	public static BoardSpacingScaleReport AnalyzeScaleFromDotGrid(Mat K1, Mat D1, Mat K2, Mat D2, Mat R, Mat T, Size imageSize, Size patternSize, double expectedSpacingMeters, IReadOnlyList<(PointF[] Master, PointF[] Slave)> frames, double expectedBaselineMeters = 0.2, double maxAbsErrorMmGate = 6.0, double requireAtLeastSamples = 200.0)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		_003C_003Ec__DisplayClass0_.No2nAQj7MC = maxAbsErrorMmGate;
		if (frames == null || frames.Count == 0)
		{
			return new BoardSpacingScaleReport
			{
				IsValid = false
			};
		}
		using Mat mat = new Mat();
		using Mat mat2 = new Mat();
		using Mat mat3 = new Mat();
		using Mat mat4 = new Mat();
		using Mat q = new Mat();
		Rectangle validPixRoi = Rectangle.Empty;
		Rectangle validPixRoi2 = Rectangle.Empty;
		CvInvoke.StereoRectify(K1, D1, K2, D2, imageSize, R, T, mat, mat2, mat3, mat4, q, StereoRectifyType.Default, -1.0, imageSize, ref validPixRoi, ref validPixRoi2);
		double num = mqTdMXATFf(T);
		double baselineErrorPercentVsExpected = Math.Abs(num - expectedBaselineMeters) / expectedBaselineMeters;
		_003C_003Ec__DisplayClass0_.zCanZi6Px2 = new List<double>(frames.Count * 2 * 200);
		_003C_003Ec__DisplayClass0_.sJQntOTwtd = new List<double>(frames.Count * 2 * 200);
		int width = patternSize.Width;
		int height = patternSize.Height;
		int num2 = width * height;
		foreach (var (array, array2) in frames)
		{
			if (array == null || array2 == null || array.Length != num2 || array2.Length != num2)
			{
				continue;
			}
			using VectorOfPointF src = new VectorOfPointF(array);
			using VectorOfPointF src2 = new VectorOfPointF(array2);
			using VectorOfPointF vectorOfPointF = new VectorOfPointF();
			using VectorOfPointF vectorOfPointF2 = new VectorOfPointF();
			CvInvoke.UndistortPoints(src, vectorOfPointF, K1, D1, mat, mat3);
			CvInvoke.UndistortPoints(src2, vectorOfPointF2, K2, D2, mat2, mat4);
			PointF[] array3 = vectorOfPointF.ToArray();
			PointF[] array4 = vectorOfPointF2.ToArray();
			if (array3.Length != num2 || array4.Length != num2)
			{
				continue;
			}
			using Mat mat5 = new Mat();
			wdgdkC8Wil(mat3, mat4, array3, array4, mat5);
			MCvPoint3D64f[] array5 = KY7drPjYD8(mat5);
			for (int i = 0; i < height; i++)
			{
				int num3 = i * width;
				for (int j = 0; j < width - 1; j++)
				{
					int num4 = num3 + j;
					int num5 = num3 + j + 1;
					gKpdnJcpO4(array5[num4], array5[num5], expectedSpacingMeters, ref _003C_003Ec__DisplayClass0_);
				}
			}
			for (int k = 0; k < height - 1; k++)
			{
				int num6 = k * width;
				int num7 = (k + 1) * width;
				for (int l = 0; l < width; l++)
				{
					int num8 = num6 + l;
					int num9 = num7 + l;
					gKpdnJcpO4(array5[num8], array5[num9], expectedSpacingMeters, ref _003C_003Ec__DisplayClass0_);
				}
			}
		}
		if (_003C_003Ec__DisplayClass0_.zCanZi6Px2.Count == 0)
		{
			return new BoardSpacingScaleReport
			{
				IsValid = false,
				ExpectedSpacingMeters = expectedSpacingMeters,
				BaselineMeters = num,
				BaselineErrorPercentVsExpected = baselineErrorPercentVsExpected,
				FramesUsed = 0,
				SamplesUsed = 0
			};
		}
		double num10 = NhldJ0HREZ(_003C_003Ec__DisplayClass0_.zCanZi6Px2);
		double medianAbsErrorMm = NhldJ0HREZ(_003C_003Ec__DisplayClass0_.sJQntOTwtd);
		double p90AbsErrorMm = LjTd4w1BAJ(_003C_003Ec__DisplayClass0_.sJQntOTwtd, 0.9);
		double num11 = Math.Abs(num10 - expectedSpacingMeters) / expectedSpacingMeters;
		bool isValid = (double)_003C_003Ec__DisplayClass0_.zCanZi6Px2.Count >= requireAtLeastSamples && num11 < 0.01;
		return new BoardSpacingScaleReport
		{
			IsValid = isValid,
			ExpectedSpacingMeters = expectedSpacingMeters,
			MedianSpacingMeters = num10,
			SpacingScaleErrorPercent = num11,
			MedianAbsErrorMm = medianAbsErrorMm,
			P90AbsErrorMm = p90AbsErrorMm,
			FramesUsed = frames.Count,
			SamplesUsed = _003C_003Ec__DisplayClass0_.zCanZi6Px2.Count,
			BaselineMeters = num,
			BaselineErrorPercentVsExpected = baselineErrorPercentVsExpected
		};
	}

	private static double mqTdMXATFf(Mat P_0)
	{
		double num = oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 0, 0);
		double num2 = oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 1, 0);
		double num3 = oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 2, 0);
		return Math.Sqrt(num * num + num2 * num2 + num3 * num3);
	}

	private static void wdgdkC8Wil(Mat P_0, Mat P_1, PointF[] P_2, PointF[] P_3, Mat P_4)
	{
		using VectorOfPointF vectorOfPointF = new VectorOfPointF(P_2);
		using VectorOfPointF vectorOfPointF2 = new VectorOfPointF(P_3);
		using Mat projPoints = CRjddI3rDf(vectorOfPointF);
		using Mat projPoints2 = CRjddI3rDf(vectorOfPointF2);
		CvInvoke.TriangulatePoints(P_0, P_1, projPoints, projPoints2, P_4);
	}

	private static Mat CRjddI3rDf(VectorOfPointF P_0)
	{
		int size = P_0.Size;
		Mat mat = new Mat(2, size, DepthType.Cv32F, 1);
		PointF[] array = P_0.ToArray();
		float[] array2 = new float[2 * size];
		for (int i = 0; i < size; i++)
		{
			array2[i] = array[i].X;
			array2[size + i] = array[i].Y;
		}
		mat.SetTo(array2);
		return mat;
	}

	private static MCvPoint3D64f[] KY7drPjYD8(Mat P_0)
	{
		int cols = P_0.Cols;
		MCvPoint3D64f[] array = new MCvPoint3D64f[cols];
		for (int i = 0; i < cols; i++)
		{
			double num = oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 0, i);
			double num2 = oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 1, i);
			double num3 = oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 2, i);
			double num4 = oaBtWW8J5C9uEnllFR.vZB43531sp(P_0, 3, i);
			if (Math.Abs(num4) < 1E-12)
			{
				num4 = 1E-12;
			}
			array[i] = new MCvPoint3D64f(num / num4, num2 / num4, num3 / num4);
		}
		return array;
	}

	private static double NhldJ0HREZ(List<double> P_0)
	{
		double[] array = P_0.OrderBy((double v) => v).ToArray();
		int num = array.Length;
		if (num == 0)
		{
			return double.NaN;
		}
		if ((num & 1) == 1)
		{
			return array[num / 2];
		}
		return 0.5 * (array[num / 2 - 1] + array[num / 2]);
	}

	private static double LjTd4w1BAJ(List<double> P_0, double P_1)
	{
		double[] array = P_0.OrderBy((double v) => v).ToArray();
		if (array.Length == 0)
		{
			return double.NaN;
		}
		double num = (double)(array.Length - 1) * P_1;
		int num2 = (int)Math.Floor(num);
		int num3 = Math.Min(num2 + 1, array.Length - 1);
		double num4 = num - (double)num2;
		return array[num2] * (1.0 - num4) + array[num3] * num4;
	}

	[CompilerGenerated]
	internal static void gKpdnJcpO4(MCvPoint3D64f P_0, MCvPoint3D64f P_1, double P_2, ref _003C_003Ec__DisplayClass0_0 P_3)
	{
		double num = P_0.X - P_1.X;
		double num2 = P_0.Y - P_1.Y;
		double num3 = P_0.Z - P_1.Z;
		double num4 = Math.Sqrt(num * num + num2 * num2 + num3 * num3);
		double num5 = Math.Abs(num4 - P_2) * 1000.0;
		if (!(num5 > P_3.No2nAQj7MC))
		{
			P_3.zCanZi6Px2.Add(num4);
			P_3.sJQntOTwtd.Add(num5);
		}
	}
}
