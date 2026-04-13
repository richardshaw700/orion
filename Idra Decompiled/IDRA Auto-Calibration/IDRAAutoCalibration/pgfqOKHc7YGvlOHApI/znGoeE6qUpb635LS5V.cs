using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using G72C4k70ShV7Qxcyny;
using IDRAAutoCalibration.DTO.Calibration;
using cibwYfp1iGN979yZlM;
using mMWtJPWctee66WM7q3;

namespace pgfqOKHc7YGvlOHApI;

internal class znGoeE6qUpb635LS5V
{
	[CompilerGenerated]
	private StereoCalibrationResult MWIdowxSnt;

	private readonly Size lT4dliSqRU;

	private readonly float OqvdLyFf0b;

	public znGoeE6qUpb635LS5V(StereoCalibrationResult P_0)
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		MWIdowxSnt = P_0;
		lT4dliSqRU = new Size(7, 11);
		OqvdLyFf0b = 0.075f;
		base._002Ector();
	}

	public float FModemnPfj()
	{
		Mat? translationVector = MWIdowxSnt.TranslationVector;
		float num = (float)oaBtWW8J5C9uEnllFR.vZB43531sp(translationVector, 0, 0);
		float num2 = (float)oaBtWW8J5C9uEnllFR.vZB43531sp(translationVector, 1, 0);
		float num3 = (float)oaBtWW8J5C9uEnllFR.vZB43531sp(translationVector, 2, 0);
		return MathF.Sqrt(num * num + num2 * num2 + num3 * num3);
	}

	public float gLydmHxL2u()
	{
		List<PointF[]> masterImagePointsUsed = MWIdowxSnt.MasterImagePointsUsed;
		List<PointF[]> slaveImagePointsUsed = MWIdowxSnt.SlaveImagePointsUsed;
		if (masterImagePointsUsed.Count == 0 || slaveImagePointsUsed.Count == 0)
		{
			return 0f;
		}
		int num = Math.Min(masterImagePointsUsed.Count, slaveImagePointsUsed.Count);
		List<float> list = new List<float>(num);
		for (int i = 0; i < num; i++)
		{
			float item = u4SdIWWsvM(qqHduF3kMq(masterImagePointsUsed[i], slaveImagePointsUsed[i]));
			list.Add(item);
		}
		return n03dA3PbLR(list, 0.95f);
	}

	private MCvPoint3D32f[] qqHduF3kMq(PointF[] P_0, PointF[] P_1)
	{
		using VectorOfPointF vectorOfPointF = new VectorOfPointF();
		vectorOfPointF.Push(P_0);
		using VectorOfPointF vectorOfPointF2 = new VectorOfPointF();
		vectorOfPointF2.Push(P_1);
		using VectorOfPoint3D32F vectorOfPoint3D32F = Qmbd0bIfYA(vectorOfPointF, vectorOfPointF2);
		return vectorOfPoint3D32F.ToArray();
	}

	public MCvPoint3D32f[] qqWd70ewpq(bool P_0)
	{
		MCvPoint3D32f[] array = new MCvPoint3D32f[lT4dliSqRU.Width * lT4dliSqRU.Height];
		for (int i = 0; i < lT4dliSqRU.Height; i++)
		{
			for (int j = 0; j < lT4dliSqRU.Width; j++)
			{
				float y = (float)i * OqvdLyFf0b;
				float z = 0f;
				float x;
				if (P_0)
				{
					int num = i % 2;
					x = (float)(2 * j + num) * OqvdLyFf0b;
				}
				else
				{
					x = (float)j * OqvdLyFf0b;
				}
				array[i * lT4dliSqRU.Width + j] = new MCvPoint3D32f(x, y, z);
			}
		}
		return array;
	}

	private static double zXfd8tKuke(double P_0)
	{
		return 0.15 + 0.0025 * P_0;
	}

	private static double bYqdpqDMjW(double P_0, double P_1)
	{
		if (P_0 <= P_1)
		{
			return 1.0;
		}
		double num = P_0 / P_1;
		return Math.Exp(-0.9 * (num - 1.0));
	}

	private static double TMmdSOEWRD(StereoCalibrationResult P_0)
	{
		MCvPoint3D32f targetPO = P_0.TargetPO;
		MCvPoint3D32f targetPX = P_0.TargetPX;
		MCvPoint3D32f targetPY = P_0.TargetPY;
		MCvPoint3D32f mCvPoint3D32f = new MCvPoint3D32f((targetPO.X + targetPX.X + targetPY.X) / 3f, (targetPO.Y + targetPX.Y + targetPY.Y) / 3f, (targetPO.Z + targetPX.Z + targetPY.Z) / 3f);
		return Math.Sqrt(mCvPoint3D32f.X * mCvPoint3D32f.X + mCvPoint3D32f.Y * mCvPoint3D32f.Y + mCvPoint3D32f.Z * mCvPoint3D32f.Z);
	}

	private static double iixdxTkA4q(StereoCalibrationResult P_0)
	{
		double num = zXfd8tKuke(TMmdSOEWRD(P_0));
		double num2 = bYqdpqDMjW(P_0.MasterCalculatedRms, num);
		double num3 = bYqdpqDMjW(P_0.SlaveCalculatedRms, num);
		double num4 = bYqdpqDMjW(P_0.StereoCalculatedRms, num * 1.2);
		return 0.35 * num2 + 0.35 * num3 + 0.3 * num4;
	}

	public static double KhUds7oIVK(StereoCalibrationResult P_0)
	{
		return Math.Round(100.0 * iixdxTkA4q(P_0), 2);
	}

	public static double GdHdqhSiM7(StereoCalibrationResult P_0, double P_1)
	{
		double num = KhUds7oIVK(P_0);
		return Math.Round(0.55 * P_1 + 0.45 * num, 2);
	}

	public float KlddWyHitW(CalibrationResult P_0, MCvPoint3D32f[] P_1, PointF[] P_2)
	{
		float num = 0f;
		int num2 = P_1.Length;
		for (int i = 0; i < num2; i++)
		{
			using VectorOfPoint3D32F objectPoints = new VectorOfPoint3D32F(new MCvPoint3D32f[1] { P_1[i] });
			using VectorOfPointF vectorOfPointF = new VectorOfPointF();
			CvInvoke.ProjectPoints(objectPoints, P_0.TargetRotation, P_0.TargetTranslation, P_0.CameraMatrix, P_0.DistCoefficient, vectorOfPointF);
			float num3 = vectorOfPointF[0].X - P_2[i].X;
			float num4 = vectorOfPointF[0].Y - P_2[i].Y;
			num += MathF.Sqrt(num3 * num3 + num4 * num4);
		}
		return num / (float)num2;
	}

	public float rmWdf8HDbF()
	{
		MCvPoint3D32f mCvPoint3D32f = new MCvPoint3D32f(MWIdowxSnt.TargetPX.X - MWIdowxSnt.TargetPO.X, MWIdowxSnt.TargetPX.Y - MWIdowxSnt.TargetPO.Y, MWIdowxSnt.TargetPX.Z - MWIdowxSnt.TargetPO.Z);
		MCvPoint3D32f mCvPoint3D32f2 = new MCvPoint3D32f(MWIdowxSnt.TargetPY.X - MWIdowxSnt.TargetPO.X, MWIdowxSnt.TargetPY.Y - MWIdowxSnt.TargetPO.Y, MWIdowxSnt.TargetPY.Z - MWIdowxSnt.TargetPO.Z);
		float num = (float)mCvPoint3D32f.Norm;
		float num2 = (float)mCvPoint3D32f2.Norm;
		if (num < 1E-06f || num2 < 1E-06f)
		{
			return 0f;
		}
		mCvPoint3D32f = new MCvPoint3D32f(mCvPoint3D32f.X / num, mCvPoint3D32f.Y / num, mCvPoint3D32f.Z / num);
		mCvPoint3D32f2 = new MCvPoint3D32f(mCvPoint3D32f2.X / num2, mCvPoint3D32f2.Y / num2, mCvPoint3D32f2.Z / num2);
		MCvPoint3D32f mCvPoint3D32f3 = new MCvPoint3D32f(mCvPoint3D32f.Y * mCvPoint3D32f2.Z - mCvPoint3D32f.Z * mCvPoint3D32f2.Y, mCvPoint3D32f.Z * mCvPoint3D32f2.X - mCvPoint3D32f.X * mCvPoint3D32f2.Z, mCvPoint3D32f.X * mCvPoint3D32f2.Y - mCvPoint3D32f.Y * mCvPoint3D32f2.X);
		float num3 = (float)mCvPoint3D32f3.Norm;
		if (num3 < 1E-06f)
		{
			return 0f;
		}
		mCvPoint3D32f3 = new MCvPoint3D32f(mCvPoint3D32f3.X / num3, mCvPoint3D32f3.Y / num3, mCvPoint3D32f3.Z / num3);
		MCvPoint3D32f mCvPoint3D32f4 = new MCvPoint3D32f(mCvPoint3D32f.Y * mCvPoint3D32f2.Z - mCvPoint3D32f.Z * mCvPoint3D32f2.Y, mCvPoint3D32f.Z * mCvPoint3D32f2.X - mCvPoint3D32f.X * mCvPoint3D32f2.Z, mCvPoint3D32f.X * mCvPoint3D32f2.Y - mCvPoint3D32f.Y * mCvPoint3D32f2.X);
		float num4 = mCvPoint3D32f4.X * mCvPoint3D32f3.X + mCvPoint3D32f4.Y * mCvPoint3D32f3.Y + mCvPoint3D32f4.Z * mCvPoint3D32f3.Z;
		float num5 = (float)mCvPoint3D32f4.Norm;
		if (num5 < 1E-06f)
		{
			return 0f;
		}
		return num4 / num5;
	}

	public float jq1dKToZeh(CameraRole P_0)
	{
		CalibrationResult calibrationResult = MWIdowxSnt.CameraResults[P_0];
		MCvPoint3D32f targetVX = calibrationResult.TargetVX;
		MCvPoint3D32f targetVY = calibrationResult.TargetVY;
		MCvPoint3D32f targetVZ = calibrationResult.TargetVZ;
		MCvPoint3D32f mCvPoint3D32f = new MCvPoint3D32f(targetVX.Y * targetVY.Z - targetVX.Z * targetVY.Y, targetVX.Z * targetVY.X - targetVX.X * targetVY.Z, targetVX.X * targetVY.Y - targetVX.Y * targetVY.X);
		float num = mCvPoint3D32f.X * targetVZ.X + mCvPoint3D32f.Y * targetVZ.Y + mCvPoint3D32f.Z * targetVZ.Z;
		float num2 = MathF.Sqrt(mCvPoint3D32f.X * mCvPoint3D32f.X + mCvPoint3D32f.Y * mCvPoint3D32f.Y + mCvPoint3D32f.Z * mCvPoint3D32f.Z);
		float num3 = MathF.Sqrt(targetVZ.X * targetVZ.X + targetVZ.Y * targetVZ.Y + targetVZ.Z * targetVZ.Z);
		if (num2 < 1E-06f || num3 < 1E-06f)
		{
			return 0f;
		}
		return num / (num2 * num3);
	}

	public float u76dVMO2u2()
	{
		List<PointF[]> masterImagePointsUsed = MWIdowxSnt.MasterImagePointsUsed;
		List<PointF[]> slaveImagePointsUsed = MWIdowxSnt.SlaveImagePointsUsed;
		if (masterImagePointsUsed.Count == 0 || slaveImagePointsUsed.Count == 0)
		{
			MCvPoint3D32f[] array = K59dtJGh8R(MWIdowxSnt.CameraResults[CameraRole.Master].DetectedBoardPoints, MWIdowxSnt.CameraResults[CameraRole.Slave].DetectedBoardPoints);
			return JW1d5NCxm1(array);
		}
		int num = Math.Min(masterImagePointsUsed.Count, slaveImagePointsUsed.Count);
		List<float> list = new List<float>(num);
		for (int i = 0; i < num; i++)
		{
			MCvPoint3D32f[] array2 = K59dtJGh8R(masterImagePointsUsed[i], slaveImagePointsUsed[i]);
			list.Add(JW1d5NCxm1(array2));
		}
		return n03dA3PbLR(list, 0.95f);
	}

	private static float u4SdIWWsvM(MCvPoint3D32f[] P_0)
	{
		int num = P_0.Length;
		if (num < 3)
		{
			return float.NaN;
		}
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		for (int i = 0; i < num; i++)
		{
			num2 += (double)P_0[i].X;
			num3 += (double)P_0[i].Y;
			num4 += (double)P_0[i].Z;
		}
		num2 /= (double)num;
		num3 /= (double)num;
		num4 /= (double)num;
		double num5 = 0.0;
		double num6 = 0.0;
		double num7 = 0.0;
		double num8 = 0.0;
		double num9 = 0.0;
		double num10 = 0.0;
		for (int j = 0; j < num; j++)
		{
			double num11 = (double)P_0[j].X - num2;
			double num12 = (double)P_0[j].Y - num3;
			double num13 = (double)P_0[j].Z - num4;
			num5 += num11 * num11;
			num6 += num11 * num12;
			num7 += num11 * num13;
			num8 += num12 * num12;
			num9 += num12 * num13;
			num10 += num13 * num13;
		}
		num5 /= (double)num;
		num6 /= (double)num;
		num7 /= (double)num;
		num8 /= (double)num;
		num9 /= (double)num;
		num10 /= (double)num;
		using Matrix<double> matrix = new Matrix<double>(3, 3);
		matrix[0, 0] = num5;
		matrix[0, 1] = num6;
		matrix[0, 2] = num7;
		matrix[1, 0] = num6;
		matrix[1, 1] = num8;
		matrix[1, 2] = num9;
		matrix[2, 0] = num7;
		matrix[2, 1] = num9;
		matrix[2, 2] = num10;
		using Mat w = new Mat();
		using Mat u = new Mat();
		using Mat mat = new Mat();
		CvInvoke.SVDecomp(matrix.Mat, w, u, mat, SvdFlag.Default);
		double num14 = oaBtWW8J5C9uEnllFR.vZB43531sp(mat, 2, 0);
		double num15 = oaBtWW8J5C9uEnllFR.vZB43531sp(mat, 2, 1);
		double num16 = oaBtWW8J5C9uEnllFR.vZB43531sp(mat, 2, 2);
		double num17 = Math.Sqrt(num14 * num14 + num15 * num15 + num16 * num16);
		if (num17 < 1E-12)
		{
			return float.NaN;
		}
		num14 /= num17;
		num15 /= num17;
		num16 /= num17;
		double[] array = new double[num];
		for (int k = 0; k < num; k++)
		{
			double num18 = (double)P_0[k].X - num2;
			double num19 = (double)P_0[k].Y - num3;
			double num20 = (double)P_0[k].Z - num4;
			array[k] = num18 * num14 + num19 * num15 + num20 * num16;
		}
		Array.Sort(array);
		int num21 = (int)Math.Floor(0.05 * (double)(num - 1));
		int num22 = (int)Math.Floor(0.95 * (double)(num - 1));
		return (float)(array[num22] - array[num21]);
	}

	private float JW1d5NCxm1(MCvPoint3D32f[] P_0)
	{
		int width = lT4dliSqRU.Width;
		int height = lT4dliSqRU.Height;
		float oqvdLyFf0b = OqvdLyFf0b;
		double num = 0.0;
		int num2 = 0;
		for (int i = 0; i < height; i++)
		{
			for (int j = 0; j < width - 1; j++)
			{
				int num3 = i * width + j;
				int num4 = i * width + (j + 1);
				double num5 = Math.Abs(sWKdZyGQjH(P_0[num3], P_0[num4]) - oqvdLyFf0b) / oqvdLyFf0b;
				num += num5;
				num2++;
			}
		}
		for (int k = 0; k < height - 1; k++)
		{
			for (int l = 0; l < width; l++)
			{
				int num6 = k * width + l;
				int num7 = (k + 1) * width + l;
				double num8 = Math.Abs(sWKdZyGQjH(P_0[num6], P_0[num7]) - oqvdLyFf0b) / oqvdLyFf0b;
				num += num8;
				num2++;
			}
		}
		if (num2 <= 0)
		{
			return float.NaN;
		}
		return (float)(num / (double)num2);
	}

	private static float n03dA3PbLR(IReadOnlyList<float> P_0, float P_1)
	{
		if (P_0.Count == 0)
		{
			return float.NaN;
		}
		float[] array = P_0.OrderBy((float v) => v).ToArray();
		float num = (float)(array.Length - 1) * P_1;
		int num2 = (int)MathF.Floor(num);
		int num3 = Math.Min(num2 + 1, array.Length - 1);
		float num4 = num - (float)num2;
		return array[num2] * (1f - num4) + array[num3] * num4;
	}

	private static float sWKdZyGQjH(MCvPoint3D32f P_0, MCvPoint3D32f P_1)
	{
		float num = P_0.X - P_1.X;
		float num2 = P_0.Y - P_1.Y;
		float num3 = P_0.Z - P_1.Z;
		return MathF.Sqrt(num * num + num2 * num2 + num3 * num3);
	}

	private MCvPoint3D32f[] K59dtJGh8R(PointF[] P_0, PointF[] P_1)
	{
		using VectorOfPointF vectorOfPointF = new VectorOfPointF();
		vectorOfPointF.Push(P_0);
		using VectorOfPointF vectorOfPointF2 = new VectorOfPointF();
		vectorOfPointF2.Push(P_1);
		using VectorOfPoint3D32F vectorOfPoint3D32F = Qmbd0bIfYA(vectorOfPointF, vectorOfPointF2);
		Dictionary<xRbEPmueCCroWyeJSW, MCvPoint3D32f> dictionary = N9RdwjIiSF(MWIdowxSnt.TargetPO, MWIdowxSnt.TargetPX, MWIdowxSnt.TargetPY);
		MCvPoint3D32f[] array = new MCvPoint3D32f[vectorOfPoint3D32F.Size];
		MCvPoint3D32f targetPO = MWIdowxSnt.TargetPO;
		MCvPoint3D32f point = dictionary[(xRbEPmueCCroWyeJSW)0];
		MCvPoint3D32f point2 = dictionary[(xRbEPmueCCroWyeJSW)1];
		MCvPoint3D32f point3 = dictionary[(xRbEPmueCCroWyeJSW)2];
		for (int i = 0; i < vectorOfPoint3D32F.Size; i++)
		{
			MCvPoint3D32f mCvPoint3D32f = vectorOfPoint3D32F[i] - targetPO;
			array[i] = new MCvPoint3D32f(mCvPoint3D32f.DotProduct(point), 0f - mCvPoint3D32f.DotProduct(point2), mCvPoint3D32f.DotProduct(point3));
		}
		return array;
	}

	private VectorOfPoint3D32F Qmbd0bIfYA(VectorOfPointF P_0, VectorOfPointF P_1)
	{
		VectorOfPoint3D32F vectorOfPoint3D32F = new VectorOfPoint3D32F();
		Mat mat = new Mat();
		VectorOfPointF vectorOfPointF = new VectorOfPointF();
		CvInvoke.UndistortPoints(P_0, vectorOfPointF, MWIdowxSnt[CameraRole.Master].CameraMatrix, MWIdowxSnt[CameraRole.Master].DistCoefficient, MWIdowxSnt[CameraRole.Master].Rectification, MWIdowxSnt[CameraRole.Master].Projection);
		VectorOfPointF vectorOfPointF2 = new VectorOfPointF();
		CvInvoke.UndistortPoints(P_1, vectorOfPointF2, MWIdowxSnt[CameraRole.Slave].CameraMatrix, MWIdowxSnt[CameraRole.Slave].DistCoefficient, MWIdowxSnt[CameraRole.Slave].Rectification, MWIdowxSnt[CameraRole.Slave].Projection);
		if (vectorOfPointF.Length != vectorOfPointF2.Length)
		{
			int count = (int)Math.Min(vectorOfPointF.Length, vectorOfPointF2.Length);
			vectorOfPointF = new VectorOfPointF(vectorOfPointF.ToArray().Take(count).ToArray());
			vectorOfPointF2 = new VectorOfPointF(vectorOfPointF2.ToArray().Take(count).ToArray());
		}
		CvInvoke.TriangulatePoints(MWIdowxSnt[CameraRole.Master].Projection, MWIdowxSnt[CameraRole.Slave].Projection, vectorOfPointF, vectorOfPointF2, mat);
		for (int i = 0; i < mat.Cols; i++)
		{
			double num = oaBtWW8J5C9uEnllFR.vZB43531sp(mat, 0, i);
			double num2 = oaBtWW8J5C9uEnllFR.vZB43531sp(mat, 1, i);
			double num3 = oaBtWW8J5C9uEnllFR.vZB43531sp(mat, 2, i);
			double num4 = oaBtWW8J5C9uEnllFR.vZB43531sp(mat, 3, i);
			vectorOfPoint3D32F.Push(new MCvPoint3D32f[1]
			{
				new MCvPoint3D32f((float)(num / num4), (float)(num2 / num4), (float)(num3 / num4))
			});
		}
		return vectorOfPoint3D32F;
	}

	private static Dictionary<xRbEPmueCCroWyeJSW, MCvPoint3D32f> N9RdwjIiSF(MCvPoint3D32f P_0, MCvPoint3D32f P_1, MCvPoint3D32f P_2)
	{
		MCvPoint3D32f value = new MCvPoint3D32f(P_1.X - P_0.X, P_1.Y - P_0.Y, P_1.Z - P_0.Z);
		float num = (float)Math.Sqrt(value.X * value.X + value.Y * value.Y + value.Z * value.Z);
		if (num > 0f)
		{
			value = new MCvPoint3D32f(value.X / num, value.Y / num, value.Z / num);
		}
		MCvPoint3D32f mCvPoint3D32f = new MCvPoint3D32f(P_2.X - P_0.X, P_2.Y - P_0.Y, P_2.Z - P_0.Z);
		float num2 = (float)Math.Sqrt(mCvPoint3D32f.X * mCvPoint3D32f.X + mCvPoint3D32f.Y * mCvPoint3D32f.Y + mCvPoint3D32f.Z * mCvPoint3D32f.Z);
		if (num2 > 0f)
		{
			mCvPoint3D32f = new MCvPoint3D32f(mCvPoint3D32f.X / num2, mCvPoint3D32f.Y / num2, mCvPoint3D32f.Z / num2);
		}
		MCvPoint3D32f value2 = new MCvPoint3D32f(value.Y * mCvPoint3D32f.Z - value.Z * mCvPoint3D32f.Y, value.Z * mCvPoint3D32f.X - value.X * mCvPoint3D32f.Z, value.X * mCvPoint3D32f.Y - value.Y * mCvPoint3D32f.X);
		float num3 = (float)Math.Sqrt(value2.X * value2.X + value2.Y * value2.Y + value2.Z * value2.Z);
		if (num3 > 0f)
		{
			value2 = new MCvPoint3D32f(value2.X / num3, value2.Y / num3, value2.Z / num3);
		}
		MCvPoint3D32f value3 = new MCvPoint3D32f(value.Y * value2.Z - value.Z * value2.Y, value.Z * value2.X - value.X * value2.Z, value.X * value2.Y - value.Y * value2.X);
		float num4 = (float)Math.Sqrt(value3.X * value3.X + value3.Y * value3.Y + value3.Z * value3.Z);
		if (num4 > 0f)
		{
			value3 = new MCvPoint3D32f(value3.X / num4, value3.Y / num4, value3.Z / num4);
		}
		return new Dictionary<xRbEPmueCCroWyeJSW, MCvPoint3D32f>
		{
			{
				(xRbEPmueCCroWyeJSW)0,
				value
			},
			{
				(xRbEPmueCCroWyeJSW)1,
				value3
			},
			{
				(xRbEPmueCCroWyeJSW)2,
				value2
			}
		};
	}
}
