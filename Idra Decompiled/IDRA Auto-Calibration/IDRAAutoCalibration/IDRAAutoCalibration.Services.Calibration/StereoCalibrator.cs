using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using G72C4k70ShV7Qxcyny;
using IDRAAutoCalibration.DTO.Calibration;
using IDRAAutoCalibration.Services.Calibration.ValidationMetrics;
using IodKeMsDBY9RwTYmwo;
using OO3ERm92I7MIQhT00f;
using cibwYfp1iGN979yZlM;
using mMWtJPWctee66WM7q3;
using qOTjYPmo7l9dIdWAMh;

namespace IDRAAutoCalibration.Services.Calibration;

public class StereoCalibrator
{
	public enum FileReplayMode
	{
		StrictReplay,
		ReapplyLiveGates
	}

	public sealed class DotGridStatistics
	{
		public double MedianArea;

		public double MedianRadius;

		public double MedianSpacing;

		public double MinRadius;

		public double MaxRadius;

		public DotGridStatistics()
		{
			edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
			base._002Ector();
		}
	}

	[CompilerGenerated]
	private Size ms4rlkL0wY;

	[CompilerGenerated]
	private float EVorL3s0rs;

	private bool jHgrYPPEct;

	private Size LTlrDdG9qD;

	private StereoCalibrationResult IKGrgllgMw;

	private static SimpleBlobDetectorParams? q8UrPwv4ey;

	private static DotGridStatistics? gkgrEBPCLU;

	private readonly double NwdrQA2fBj;

	private readonly double SU8ra9BT7q;

	private readonly double BiErBmv9ZB;

	private readonly u3V7kvv77B14SyahwY aXTrCoGC9d;

	public CalibrationGuidanceState CurrentGuidance => aXTrCoGC9d.fMIrFchle1();

	public StereoCalibrator(Size _calibrationBoardPatternDimension, float _calibrationSquareSize, double minNoveltyMoveCells)
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		ms4rlkL0wY = _calibrationBoardPatternDimension;
		EVorL3s0rs = _calibrationSquareSize;
		LTlrDdG9qD = new Size(540, 720);
		IKGrgllgMw = new StereoCalibrationResult();
		NwdrQA2fBj = minNoveltyMoveCells;
		SU8ra9BT7q = 0.04;
		BiErBmv9ZB = 4.0;
		aXTrCoGC9d = new u3V7kvv77B14SyahwY();
		base._002Ector();
	}

	private string[] zx4r3joy1L(string P_0)
	{
		return Directory.GetFiles(P_0, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(10080), SearchOption.TopDirectoryOnly).Where(bEGrI3MT0J).OrderBy(Path.GetFileName)
			.ToArray();
	}

	private Dictionary<CameraRole, List<Mat>> aP3rXJYs3X(string P_0, string P_1)
	{
		if (!Directory.Exists(P_0) || !Directory.Exists(P_1))
		{
			throw new DirectoryNotFoundException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(10090));
		}
		Dictionary<CameraRole, List<Mat>> dictionary = new Dictionary<CameraRole, List<Mat>>
		{
			{
				CameraRole.Master,
				jDVrMXceeU(zx4r3joy1L(P_0))
			},
			{
				CameraRole.Slave,
				jDVrMXceeU(zx4r3joy1L(P_1))
			}
		};
		if (dictionary[CameraRole.Master].Count == dictionary[CameraRole.Slave].Count)
		{
			return dictionary;
		}
		throw new InvalidOperationException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(10154));
	}

	private List<Mat> jDVrMXceeU(string[] P_0)
	{
		return P_0.Select((string o) => CvInvoke.Imread(o)).ToList();
	}

	public StereoCalibrationResult CalibrateFromFiles(string masterFolderPath, string slaveFolderPath, string masterTargetCalibrationImagePath, string slaveTargetCalibrationImagePath, int minimumCalibrationImageCount = 10, bool isAsymmetric = false, FileReplayMode mode = FileReplayMode.StrictReplay)
	{
		jHgrYPPEct = isAsymmetric;
		aXTrCoGC9d.AKer26LgPu();
		IKGrgllgMw?.Dispose();
		IKGrgllgMw = new StereoCalibrationResult();
		using (Mat mat = CvInvoke.Imread(masterTargetCalibrationImagePath))
		{
			if (mat.IsEmpty)
			{
				throw new InvalidDataException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(10266) + masterTargetCalibrationImagePath);
			}
			InitializeDetectorFromTarget(mat);
		}
		string[] array = zx4r3joy1L(masterFolderPath);
		string[] array2 = zx4r3joy1L(slaveFolderPath);
		if (array.Length == 0 || array2.Length == 0)
		{
			throw new InvalidOperationException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(10342));
		}
		if (array.Length != array2.Length)
		{
			throw new InvalidOperationException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(10154));
		}
		List<PointF[]> list = new List<PointF[]>();
		List<PointF[]> list2 = new List<PointF[]>();
		PointF[] lastAcceptedMasterPts = null;
		Size? size = null;
		for (int i = 0; i < array.Length; i++)
		{
			using Mat mat2 = CvInvoke.Imread(array[i]);
			using Mat mat3 = CvInvoke.Imread(array2[i]);
			if (mat2.IsEmpty || mat3.IsEmpty || mat2.Size != mat3.Size)
			{
				continue;
			}
			Size valueOrDefault = size.GetValueOrDefault();
			if (!size.HasValue)
			{
				valueOrDefault = mat2.Size;
				size = valueOrDefault;
			}
			if (mat2.Size != size.Value)
			{
				continue;
			}
			if (mode == FileReplayMode.ReapplyLiveGates)
			{
				if (AcceptFrameIfUsable(mat2, mat3, lastAcceptedMasterPts, out PointF[] masterPts, out PointF[] slavePts, out string _))
				{
					list.Add(masterPts);
					list2.Add(slavePts);
					IKGrgllgMw.MasterImagePointsUsed.Add(masterPts);
					IKGrgllgMw.SlaveImagePointsUsed.Add(slavePts);
					lastAcceptedMasterPts = masterPts;
				}
				continue;
			}
			DotGridFrame dotGridFrame = DetectDotGrid(mat2);
			if (!dotGridFrame.IsValid)
			{
				continue;
			}
			DotGridFrame dotGridFrame2 = DetectDotGrid(mat3);
			if (!dotGridFrame2.IsValid)
			{
				continue;
			}
			int num = ms4rlkL0wY.Width * ms4rlkL0wY.Height;
			if (dotGridFrame.Points.Length == num && dotGridFrame2.Points.Length == num)
			{
				list.Add(dotGridFrame.Points);
				list2.Add(dotGridFrame2.Points);
				IKGrgllgMw.MasterImagePointsUsed.Add(dotGridFrame.Points);
				IKGrgllgMw.SlaveImagePointsUsed.Add(dotGridFrame2.Points);
				try
				{
					DotGridMetrics dotGridMetrics = egjOv7e0fZIM1acOMJ.UToJt0bGyI(dotGridFrame.Points, ms4rlkL0wY, mat2.Size, dotGridFrame.MedianSpacing);
					aXTrCoGC9d.VEArGO7Dlh(dotGridMetrics);
				}
				catch
				{
				}
			}
		}
		if (list.Count < minimumCalibrationImageCount)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(75, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(10440));
			defaultInterpolatedStringHandler.AppendFormatted(list.Count);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(10576));
			defaultInterpolatedStringHandler.AppendFormatted(minimumCalibrationImageCount);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6820));
			throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		LTlrDdG9qD = size.Value;
		using Mat mat4 = CvInvoke.Imread(masterTargetCalibrationImagePath);
		using Mat mat5 = CvInvoke.Imread(slaveTargetCalibrationImagePath);
		if (mat4.IsEmpty)
		{
			throw new InvalidDataException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(10266) + masterTargetCalibrationImagePath);
		}
		if (mat5.IsEmpty)
		{
			throw new InvalidDataException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(10594) + slaveTargetCalibrationImagePath);
		}
		MCvPoint3D32f[] array3 = aUHrSgE3ER(jHgrYPPEct);
		using VectorOfVectorOfPoint3D32F vectorOfVectorOfPoint3D32F = fNkrrF7UE6(list.Count, array3);
		using (VectorOfVectorOfPointF vectorOfVectorOfPointF = new VectorOfVectorOfPointF(list.ToArray()))
		{
			using VectorOfVectorOfPointF vectorOfVectorOfPointF2 = new VectorOfVectorOfPointF(list2.ToArray());
			iJPrk1MVHi(vectorOfVectorOfPoint3D32F, vectorOfVectorOfPointF, CameraRole.Master);
			iJPrk1MVHi(vectorOfVectorOfPoint3D32F, vectorOfVectorOfPointF2, CameraRole.Slave);
			O0erdqxBgL(vectorOfVectorOfPoint3D32F, vectorOfVectorOfPointF, vectorOfVectorOfPointF2);
		}
		aP4rsrrtwu();
		w8OrqsgDlV(mat4, mat5, array3);
		return IKGrgllgMw;
	}

	public StereoCalibrationResult Calibrate(Dictionary<CameraRole, List<Mat>> calibrationImageMatrixDictionary, Mat masterTargetCalibrationImageMatrix, Mat slaveTargetCalibrationImageMatrix, int minimumCalibrationImageCount = 10, bool isAsymmetric = false)
	{
		IKGrgllgMw?.Dispose();
		IKGrgllgMw = new StereoCalibrationResult();
		aXTrCoGC9d.AKer26LgPu();
		jHgrYPPEct = isAsymmetric;
		if (calibrationImageMatrixDictionary[CameraRole.Master].Count != calibrationImageMatrixDictionary[CameraRole.Slave].Count)
		{
			throw new InvalidOperationException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(10668));
		}
		int count = calibrationImageMatrixDictionary[CameraRole.Master].Count;
		if (count < minimumCalibrationImageCount)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(81, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(10804));
			defaultInterpolatedStringHandler.AppendFormatted(count);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(10934));
			defaultInterpolatedStringHandler.AppendFormatted(minimumCalibrationImageCount);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6820));
			throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		Dictionary<CameraRole, List<PointF[]>> dictionary = DBjrJYnVoF(calibrationImageMatrixDictionary, count);
		count = dictionary[CameraRole.Master].Count;
		MCvPoint3D32f[] array = aUHrSgE3ER(jHgrYPPEct);
		using VectorOfVectorOfPoint3D32F vectorOfVectorOfPoint3D32F = fNkrrF7UE6(count, array);
		using (VectorOfVectorOfPointF vectorOfVectorOfPointF = new VectorOfVectorOfPointF(dictionary[CameraRole.Master].ToArray()))
		{
			using VectorOfVectorOfPointF vectorOfVectorOfPointF2 = new VectorOfVectorOfPointF(dictionary[CameraRole.Slave].ToArray());
			iJPrk1MVHi(vectorOfVectorOfPoint3D32F, vectorOfVectorOfPointF, CameraRole.Master);
			iJPrk1MVHi(vectorOfVectorOfPoint3D32F, vectorOfVectorOfPointF2, CameraRole.Slave);
			O0erdqxBgL(vectorOfVectorOfPoint3D32F, vectorOfVectorOfPointF, vectorOfVectorOfPointF2);
		}
		aP4rsrrtwu();
		w8OrqsgDlV(masterTargetCalibrationImageMatrix, slaveTargetCalibrationImageMatrix, array);
		return IKGrgllgMw;
	}

	private void iJPrk1MVHi(VectorOfVectorOfPoint3D32F P_0, VectorOfVectorOfPointF P_1, CameraRole P_2)
	{
		Mat mat = CvInvoke.InitCameraMatrix2D(P_0, P_1, LTlrDdG9qD, 0.0);
		using Mat mat2 = new Mat(1, 5, DepthType.Cv64F, 1);
		using Mat rotationVectors = new Mat();
		using Mat translationVectors = new Mat();
		if (mat.Depth != DepthType.Cv64F)
		{
			Mat mat3 = new Mat();
			mat.ConvertTo(mat3, DepthType.Cv64F);
			mat.Dispose();
			mat = mat3;
		}
		double num = CvInvoke.CalibrateCamera(P_0, P_1, LTlrDdG9qD, mat, mat2, rotationVectors, translationVectors, CalibType.FixAspectRatio | CalibType.ZeroTangentDist, new MCvTermCriteria(100, 1E-06));
		switch (P_2)
		{
		case CameraRole.Master:
			IKGrgllgMw[CameraRole.Master].CameraMatrix = mat.Clone();
			IKGrgllgMw[CameraRole.Master].DistCoefficient = mat2.Clone();
			IKGrgllgMw.MasterCalculatedRms = num;
			break;
		case CameraRole.Slave:
			IKGrgllgMw[CameraRole.Slave].CameraMatrix = mat.Clone();
			IKGrgllgMw[CameraRole.Slave].DistCoefficient = mat2.Clone();
			IKGrgllgMw.SlaveCalculatedRms = num;
			break;
		}
		mat.Dispose();
	}

	private void O0erdqxBgL(VectorOfVectorOfPoint3D32F P_0, VectorOfVectorOfPointF P_1, VectorOfVectorOfPointF P_2)
	{
		IKGrgllgMw.RotationMatrix = new Mat();
		IKGrgllgMw.TranslationVector = new Mat();
		IKGrgllgMw.EssentialMatrix = new Mat();
		IKGrgllgMw.FundamentalMatrix = new Mat();
		IKGrgllgMw.StereoCalculatedRms = CvInvoke.StereoCalibrate(P_0, P_1, P_2, IKGrgllgMw[CameraRole.Master].CameraMatrix, IKGrgllgMw[CameraRole.Master].DistCoefficient, IKGrgllgMw[CameraRole.Slave].CameraMatrix, IKGrgllgMw[CameraRole.Slave].DistCoefficient, LTlrDdG9qD, IKGrgllgMw.RotationMatrix, IKGrgllgMw.TranslationVector, IKGrgllgMw.EssentialMatrix, IKGrgllgMw.FundamentalMatrix, CalibType.FixIntrinsic, new MCvTermCriteria(30, 1E-07));
	}

	private VectorOfVectorOfPoint3D32F fNkrrF7UE6(int P_0, MCvPoint3D32f[] P_1)
	{
		using VectorOfPoint3D32F value = new VectorOfPoint3D32F(P_1);
		VectorOfVectorOfPoint3D32F vectorOfVectorOfPoint3D32F = new VectorOfVectorOfPoint3D32F();
		for (int i = 0; i < P_0; i++)
		{
			vectorOfVectorOfPoint3D32F.Push(value);
		}
		return vectorOfVectorOfPoint3D32F;
	}

	private Dictionary<CameraRole, List<PointF[]>> DBjrJYnVoF(Dictionary<CameraRole, List<Mat>> P_0, int P_1)
	{
		List<PointF[]> list = new List<PointF[]>();
		List<PointF[]> list2 = new List<PointF[]>();
		Size size = P_0[CameraRole.Master][0].Size;
		Size size2 = P_0[CameraRole.Slave][0].Size;
		if (size != size2)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(10970));
			defaultInterpolatedStringHandler.AppendFormatted(size);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(10998));
			defaultInterpolatedStringHandler.AppendFormatted(size2);
			throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		LTlrDdG9qD = size;
		int num = ms4rlkL0wY.Width * ms4rlkL0wY.Height;
		for (int i = 0; i < P_1; i++)
		{
			Mat image = P_0[CameraRole.Master][i];
			Mat image2 = P_0[CameraRole.Slave][i];
			PointF[] points = DetectDotGrid(image).Points;
			PointF[] points2 = DetectDotGrid(image2).Points;
			if (points != null && points.Length == num && points2 != null && points2.Length == num)
			{
				list.Add(points);
				list2.Add(points2);
				IKGrgllgMw.MasterImagePointsUsed.Add(points);
				IKGrgllgMw.SlaveImagePointsUsed.Add(points2);
			}
			else
			{
				P_0[CameraRole.Master].RemoveAt(i);
				P_0[CameraRole.Slave].RemoveAt(i);
				i--;
				P_1--;
			}
		}
		return new Dictionary<CameraRole, List<PointF[]>>
		{
			{
				CameraRole.Master,
				list
			},
			{
				CameraRole.Slave,
				list2
			}
		};
	}

	private static double c54r45ArVK(PointF[] P_0, int P_1)
	{
		double num = 0.0;
		int num2 = 0;
		for (int i = 0; i < P_1 - 1; i++)
		{
			num += cVAruvldkl(P_0[i], P_0[i + 1]);
			num2++;
		}
		return num / (double)num2;
	}

	public static Mat BuildBlobInput(Mat bgrOrGray)
	{
		using Mat src = fBirHkLQKb(bgrOrGray);
		Mat mat = new Mat();
		CvInvoke.CLAHE(src, 1.5, new Size(8, 8), mat);
		CvInvoke.GaussianBlur(mat, mat, new Size(3, 3), 0.0);
		return mat;
	}

	private DotGridStatistics oSRrnJKAu9(Mat P_0)
	{
		if (P_0.NumberOfChannels != 1)
		{
			throw new ArgumentException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11032), xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11136));
		}
		using SimpleBlobDetector simpleBlobDetector = new SimpleBlobDetector(new SimpleBlobDetectorParams
		{
			MinThreshold = 5f,
			MaxThreshold = 220f,
			ThresholdStep = 10f,
			FilterByColor = true,
			blobColor = 0,
			FilterByArea = true,
			MinArea = 10f,
			MaxArea = P_0.Width * P_0.Height,
			FilterByCircularity = false,
			FilterByInertia = false,
			FilterByConvexity = false
		});
		using VectorOfKeyPoint vectorOfKeyPoint = new VectorOfKeyPoint();
		simpleBlobDetector.DetectRaw(P_0, vectorOfKeyPoint);
		if (vectorOfKeyPoint.Size < ms4rlkL0wY.Height * ms4rlkL0wY.Width)
		{
			throw new InvalidOperationException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11148));
		}
		List<double> list = new List<double>();
		List<double> list2 = new List<double>();
		MKeyPoint[] array = vectorOfKeyPoint.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			double num = (double)array[i].Size * 0.5;
			list2.Add(num);
			list.Add(Math.PI * num * num);
		}
		PointF[] array2 = (from k in vectorOfKeyPoint.ToArray()
			select k.Point).ToArray();
		List<double> list3 = new List<double>();
		for (int num2 = 0; num2 < array2.Length; num2++)
		{
			double num3 = double.MaxValue;
			for (int num4 = 0; num4 < array2.Length; num4++)
			{
				if (num2 != num4)
				{
					double val = Math.Sqrt(Math.Pow(array2[num2].X - array2[num4].X, 2.0) + Math.Pow(array2[num2].Y - array2[num4].Y, 2.0));
					num3 = Math.Min(num3, val);
				}
			}
			list3.Add(num3);
		}
		return new DotGridStatistics
		{
			MedianArea = NHjr1q7Qor(list),
			MedianRadius = NHjr1q7Qor(list2),
			MedianSpacing = NHjr1q7Qor(list3)
		};
	}

	private static double NHjr1q7Qor(List<double> P_0)
	{
		P_0.Sort();
		return P_0[P_0.Count / 2];
	}

	private static DotGridStatistics igqrOd4Zb6(DotGridStatistics P_0)
	{
		P_0.MinRadius = P_0.MedianRadius * 0.8;
		P_0.MaxRadius = P_0.MedianRadius * 1.2;
		return P_0;
	}

	private static SimpleBlobDetectorParams gS2r6jxWIJ(DotGridStatistics P_0)
	{
		bool flag = P_0.MedianRadius < 4.0;
		return new SimpleBlobDetectorParams
		{
			MinThreshold = 0f,
			MaxThreshold = 255f,
			ThresholdStep = 10f,
			FilterByColor = true,
			blobColor = 0,
			FilterByArea = true,
			MinArea = (float)(P_0.MedianArea * 0.45),
			MaxArea = (float)(P_0.MedianArea * 2.2),
			MinDistBetweenBlobs = (float)(P_0.MedianSpacing * 0.55),
			FilterByCircularity = true,
			MinCircularity = (flag ? 0.55f : 0.65f),
			FilterByInertia = true,
			MinInertiaRatio = (flag ? 0.2f : 0.3f),
			FilterByConvexity = true,
			MinConvexity = (flag ? 0.6f : 0.7f)
		};
	}

	public void InitializeDetectorFromTarget(Mat targetImage)
	{
		using Mat mat = BuildBlobInput(targetImage);
		CvInvoke.GaussianBlur(mat, mat, new Size(5, 5), 0.0);
		DotGridStatistics dotGridStatistics = oSRrnJKAu9(mat);
		gkgrEBPCLU = igqrOd4Zb6(dotGridStatistics);
		q8UrPwv4ey = gS2r6jxWIJ(dotGridStatistics);
	}

	private static Mat fBirHkLQKb(Mat P_0)
	{
		if (P_0.NumberOfChannels == 1)
		{
			return P_0.Clone();
		}
		Mat mat = new Mat();
		CvInvoke.CvtColor(P_0, mat, ColorConversion.Bgr2Gray);
		return mat;
	}

	private static PointF[] C3FrjS70n9(PointF[] P_0, Size P_1)
	{
		int width = P_1.Width;
		int height = P_1.Height;
		PointF[] array = new PointF[P_0.Length];
		int num = 0;
		for (int i = 0; i < height; i++)
		{
			for (int num2 = width - 1; num2 >= 0; num2--)
			{
				array[num++] = P_0[i * width + num2];
			}
		}
		return array;
	}

	private static PointF[] AVSrRKJJWO(PointF[] P_0, Size P_1)
	{
		int width = P_1.Width;
		int height = P_1.Height;
		PointF[] array = new PointF[P_0.Length];
		int num = 0;
		for (int num2 = height - 1; num2 >= 0; num2--)
		{
			for (int i = 0; i < width; i++)
			{
				array[num++] = P_0[num2 * width + i];
			}
		}
		return array;
	}

	public DotGridFrame DetectDotGrid(Mat image)
	{
		if (q8UrPwv4ey == null || gkgrEBPCLU == null)
		{
			return S9BrmJoc6B(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11280));
		}
		using Mat mat = BuildBlobInput(image);
		using SimpleBlobDetector simpleBlobDetector = new SimpleBlobDetector(q8UrPwv4ey);
		using VectorOfPointF vectorOfPointF = new VectorOfPointF();
		if (!CvInvoke.FindCirclesGrid(mat, ms4rlkL0wY, vectorOfPointF, (CalibCgType)(4 | ((!jHgrYPPEct) ? 1 : 2)), simpleBlobDetector))
		{
			return S9BrmJoc6B(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11404));
		}
		PointF[] array = SyHr7kaUu7(vectorOfPointF, ms4rlkL0wY);
		if (array == null || array.Length == 0)
		{
			return S9BrmJoc6B(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11452));
		}
		array = Gx7rvw6WqN(array, ms4rlkL0wY);
		if (array.Length == 0)
		{
			return S9BrmJoc6B(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11494));
		}
		double num = c54r45ArVK(array, ms4rlkL0wY.Width);
		if (num <= 1E-06)
		{
			return S9BrmJoc6B(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11536));
		}
		double num2 = hMArZ4lNUO(mat, simpleBlobDetector);
		if (double.IsNaN(num2))
		{
			return S9BrmJoc6B(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11570));
		}
		if (num2 < gkgrEBPCLU.MinRadius || num2 > gkgrEBPCLU.MaxRadius)
		{
			return S9BrmJoc6B(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11636));
		}
		return new DotGridFrame
		{
			Points = array,
			MedianRadius = num2,
			MedianSpacing = num,
			IsValid = true
		};
	}

	private static PointF[] Gx7rvw6WqN(PointF[] P_0, Size P_1)
	{
		int width = P_1.Width;
		int height = P_1.Height;
		if (P_0.Length != width * height)
		{
			return Array.Empty<PointF>();
		}
		if (P_0[width - 1].X < P_0[0].X)
		{
			P_0 = C3FrjS70n9(P_0, P_1);
		}
		if (P_0[width * (height - 1)].Y < P_0[0].Y)
		{
			P_0 = AVSrRKJJWO(P_0, P_1);
		}
		return P_0;
	}

	private static double ta7r9mP2Iw(PointF[] P_0, int P_1)
	{
		if (P_0 == null || P_0.Length < P_1 || P_1 < 2)
		{
			return 0.0;
		}
		PointF pointF = P_0[0];
		PointF pointF2 = P_0[P_1 - 1];
		return Math.Atan2(pointF2.Y - pointF.Y, pointF2.X - pointF.X) * (180.0 / Math.PI);
	}

	private static double HkOrUymc1W(double P_0, double P_1)
	{
		double num;
		for (num = P_0 - P_1; num > 180.0; num -= 360.0)
		{
		}
		for (; num < -180.0; num += 360.0)
		{
		}
		return Math.Abs(num);
	}

	private static double sDcrh1LKW9(PointF[] P_0, PointF[] P_1)
	{
		double num = 0.0;
		for (int i = 0; i < P_0.Length; i++)
		{
			num += cVAruvldkl(P_0[i], P_1[i]);
		}
		return num / (double)P_0.Length;
	}

	public bool AcceptFrameIfUsable(Mat masterBgr, Mat slaveBgr, PointF[]? lastAcceptedMasterPts, out PointF[] masterPts, out PointF[] slavePts, out string rejectReason, double minBlurScore = 60.0, double maxScaleMismatchRatio = 0.12, double minSpacingPx = 8.0, double maxSpacingPx = 120.0)
	{
		masterPts = Array.Empty<PointF>();
		slavePts = Array.Empty<PointF>();
		rejectReason = "";
		DotGridFrame dotGridFrame = DetectDotGrid(masterBgr);
		if (!dotGridFrame.IsValid)
		{
			rejectReason = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11680) + dotGridFrame.RejectReason;
			return false;
		}
		DotGridFrame dotGridFrame2 = DetectDotGrid(slaveBgr);
		if (!dotGridFrame2.IsValid)
		{
			rejectReason = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11710) + dotGridFrame2.RejectReason;
			return false;
		}
		masterPts = dotGridFrame.Points;
		slavePts = dotGridFrame2.Points;
		if (dotGridFrame.MedianSpacing < minSpacingPx || dotGridFrame.MedianSpacing > maxSpacingPx || dotGridFrame2.MedianSpacing < minSpacingPx || dotGridFrame2.MedianSpacing > maxSpacingPx)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11738));
			defaultInterpolatedStringHandler.AppendFormatted(dotGridFrame.MedianSpacing, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11790));
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11798));
			defaultInterpolatedStringHandler.AppendFormatted(dotGridFrame2.MedianSpacing, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11790));
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11810));
			rejectReason = defaultInterpolatedStringHandler.ToStringAndClear();
			return false;
		}
		double val = 0.5 * (dotGridFrame.MedianSpacing + dotGridFrame2.MedianSpacing);
		double num = Math.Abs(dotGridFrame.MedianSpacing - dotGridFrame2.MedianSpacing) / Math.Max(1E-09, val);
		if (num > maxScaleMismatchRatio)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11816));
			defaultInterpolatedStringHandler.AppendFormatted(num, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11882));
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11810));
			rejectReason = defaultInterpolatedStringHandler.ToStringAndClear();
			return false;
		}
		double num2 = ib9relrDSg(masterBgr);
		double num3 = ib9relrDSg(slaveBgr);
		if (num2 < minBlurScore || num3 < minBlurScore)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11890));
			defaultInterpolatedStringHandler.AppendFormatted(num2, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11790));
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11930));
			defaultInterpolatedStringHandler.AppendFormatted(num3, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11790));
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11810));
			rejectReason = defaultInterpolatedStringHandler.ToStringAndClear();
			return false;
		}
		if (lastAcceptedMasterPts != null && lastAcceptedMasterPts.Length == masterPts.Length)
		{
			int width = ms4rlkL0wY.Width;
			double num4 = sDcrh1LKW9(masterPts, lastAcceptedMasterPts) / Math.Max(1E-06, dotGridFrame.MedianSpacing);
			double num5 = c54r45ArVK(lastAcceptedMasterPts, width);
			double num6 = ((num5 > 1E-06) ? (Math.Abs(dotGridFrame.MedianSpacing - num5) / num5) : 0.0);
			double num7 = ta7r9mP2Iw(masterPts, width);
			double num8 = ta7r9mP2Iw(lastAcceptedMasterPts, width);
			double num9 = HkOrUymc1W(num7, num8);
			if (!(num4 >= NwdrQA2fBj) && !(num6 >= SU8ra9BT7q) && !(num9 >= BiErBmv9ZB))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(57, 6);
				defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11950));
				defaultInterpolatedStringHandler.AppendFormatted(num4, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11882));
				defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12000));
				defaultInterpolatedStringHandler.AppendFormatted(NwdrQA2fBj, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11882));
				defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12022));
				defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12030));
				defaultInterpolatedStringHandler.AppendFormatted(num6, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(7566));
				defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12048));
				defaultInterpolatedStringHandler.AppendFormatted(SU8ra9BT7q, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12058));
				defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12022));
				defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12066));
				defaultInterpolatedStringHandler.AppendFormatted(num9, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11790));
				defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12080));
				defaultInterpolatedStringHandler.AppendFormatted(BiErBmv9ZB, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(11790));
				defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12092));
				rejectReason = defaultInterpolatedStringHandler.ToStringAndClear();
				return false;
			}
		}
		try
		{
			DotGridMetrics dotGridMetrics = egjOv7e0fZIM1acOMJ.UToJt0bGyI(masterPts, ms4rlkL0wY, masterBgr.Size, dotGridFrame.MedianSpacing);
			aXTrCoGC9d.VEArGO7Dlh(dotGridMetrics);
		}
		catch
		{
		}
		return true;
	}

	private static double ib9relrDSg(Mat P_0)
	{
		using Mat mat = new Mat();
		if (P_0.NumberOfChannels == 1)
		{
			P_0.CopyTo(mat);
		}
		else
		{
			CvInvoke.CvtColor(P_0, mat, ColorConversion.Bgr2Gray);
		}
		using Mat mat2 = new Mat();
		CvInvoke.Laplacian(mat, mat2, DepthType.Cv64F);
		using Mat mean = new Mat();
		using Mat mat3 = new Mat();
		CvInvoke.MeanStdDev(mat2, mean, mat3);
		double num = mat3.GetData().Cast<double>().FirstOrDefault();
		return num * num;
	}

	private static DotGridFrame S9BrmJoc6B(string P_0)
	{
		return new DotGridFrame
		{
			IsValid = false,
			RejectReason = P_0
		};
	}

	private static double cVAruvldkl(PointF P_0, PointF P_1)
	{
		float num = P_0.X - P_1.X;
		float num2 = P_0.Y - P_1.Y;
		return Math.Sqrt(num * num + num2 * num2);
	}

	private static PointF[]? SyHr7kaUu7(VectorOfPointF P_0, Size P_1)
	{
		PointF[] array = P_0.ToArray();
		PointF pointF = array[0];
		PointF pointF2 = array[P_1.Width - 1];
		PointF pointF3 = array[P_1.Width];
		double num = Math.Sqrt(Math.Pow(pointF.X - pointF3.X, 2.0) + Math.Pow(pointF.Y - pointF3.Y, 2.0));
		double num2 = Math.Sqrt(Math.Pow(pointF2.X - pointF3.X, 2.0) + Math.Pow(pointF2.Y - pointF3.Y, 2.0));
		if (num > num2)
		{
			return Array.Empty<PointF>();
		}
		int num3 = P_1.Height - 1;
		PointF pointF4 = array[P_1.Width * num3];
		array = c2orpieNx8(pointF, pointF4, array, num3, P_1);
		return GLIr8jO2I9(pointF, pointF2, array, P_1);
	}

	private static PointF[] GLIr8jO2I9(PointF P_0, PointF P_1, PointF[] P_2, Size P_3)
	{
		if (!(P_0.X > P_1.X))
		{
			return P_2;
		}
		List<PointF> list = P_2.ToList();
		P_2 = new PointF[P_2.Length];
		int num = 0;
		for (int i = 0; i < P_3.Height; i++)
		{
			for (int num2 = P_3.Width - 1; num2 >= 0; num2--)
			{
				P_2[num++] = list[P_3.Width * i + num2];
			}
		}
		return P_2;
	}

	private static PointF[] c2orpieNx8(PointF P_0, PointF P_1, PointF[] P_2, int P_3, Size P_4)
	{
		if (P_0.Y <= P_1.Y)
		{
			return P_2;
		}
		List<PointF> list = P_2.ToList();
		P_2 = new PointF[P_2.Length];
		int num = 0;
		for (int i = 0; i < P_4.Height; i++)
		{
			for (int j = 0; j < P_4.Width; j++)
			{
				P_2[num++] = list[P_4.Width * (P_3 - i) + j];
			}
		}
		return P_2;
	}

	private MCvPoint3D32f[] aUHrSgE3ER(bool P_0)
	{
		MCvPoint3D32f[] array = new MCvPoint3D32f[ms4rlkL0wY.Width * ms4rlkL0wY.Height];
		for (int i = 0; i < ms4rlkL0wY.Height; i++)
		{
			for (int j = 0; j < ms4rlkL0wY.Width; j++)
			{
				float num = 0f;
				float y = (float)i * EVorL3s0rs;
				float z = 0f;
				if (P_0)
				{
					int num2 = i % 2;
					num = (float)(2 * j + num2) * EVorL3s0rs;
				}
				else
				{
					num = (float)j * EVorL3s0rs;
				}
				array[i * ms4rlkL0wY.Width + j] = new MCvPoint3D32f(num, y, z);
			}
		}
		return array;
	}

	private bool KUZrxK4QGN()
	{
		if (IKGrgllgMw.RotationMatrix != null && IKGrgllgMw.TranslationVector != null && IKGrgllgMw[CameraRole.Master].CameraMatrix != null && IKGrgllgMw[CameraRole.Slave].CameraMatrix != null && IKGrgllgMw[CameraRole.Master].DistCoefficient != null && IKGrgllgMw[CameraRole.Slave].DistCoefficient != null)
		{
			return !LTlrDdG9qD.IsEmpty;
		}
		return false;
	}

	private void aP4rsrrtwu()
	{
		if (!KUZrxK4QGN())
		{
			throw new InvalidOperationException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12100));
		}
		IKGrgllgMw[CameraRole.Master].Rectification = new Mat();
		IKGrgllgMw[CameraRole.Slave].Rectification = new Mat();
		IKGrgllgMw[CameraRole.Master].Projection = new Mat();
		IKGrgllgMw[CameraRole.Slave].Projection = new Mat();
		IKGrgllgMw.PerspectiveTransformation = new Mat();
		Rectangle validPixRoi = default(Rectangle);
		Rectangle validPixRoi2 = default(Rectangle);
		CvInvoke.StereoRectify(IKGrgllgMw[CameraRole.Master].CameraMatrix, IKGrgllgMw[CameraRole.Master].DistCoefficient, IKGrgllgMw[CameraRole.Slave].CameraMatrix, IKGrgllgMw[CameraRole.Slave].DistCoefficient, LTlrDdG9qD, IKGrgllgMw.RotationMatrix, IKGrgllgMw.TranslationVector, IKGrgllgMw[CameraRole.Master].Rectification, IKGrgllgMw[CameraRole.Slave].Rectification, IKGrgllgMw[CameraRole.Master].Projection, IKGrgllgMw[CameraRole.Slave].Projection, IKGrgllgMw.PerspectiveTransformation, StereoRectifyType.CalibZeroDisparity, -1.0, LTlrDdG9qD, ref validPixRoi, ref validPixRoi2);
		IKGrgllgMw[CameraRole.Master].ROI = validPixRoi;
		IKGrgllgMw[CameraRole.Slave].ROI = validPixRoi2;
	}

	private void w8OrqsgDlV(Mat P_0, Mat P_1, MCvPoint3D32f[]? virtualBoardPoints)
	{
		Dictionary<xRbEPmueCCroWyeJSW, PointF> dictionary = ujBrVA8AYb(P_0, CameraRole.Master);
		Dictionary<xRbEPmueCCroWyeJSW, PointF> dictionary2 = ujBrVA8AYb(P_1, CameraRole.Slave);
		IKGrgllgMw[CameraRole.Master].TargetPO = dictionary[(xRbEPmueCCroWyeJSW)3];
		IKGrgllgMw[CameraRole.Master].TargetPX = dictionary[(xRbEPmueCCroWyeJSW)0];
		IKGrgllgMw[CameraRole.Master].TargetPY = dictionary[(xRbEPmueCCroWyeJSW)1];
		IKGrgllgMw[CameraRole.Slave].TargetPO = dictionary2[(xRbEPmueCCroWyeJSW)3];
		IKGrgllgMw[CameraRole.Slave].TargetPX = dictionary2[(xRbEPmueCCroWyeJSW)0];
		IKGrgllgMw[CameraRole.Slave].TargetPY = dictionary2[(xRbEPmueCCroWyeJSW)1];
		KeyValuePair<Mat, Mat> keyValuePair = GLUrKGjt7j(CameraRole.Master, P_0, virtualBoardPoints, IKGrgllgMw[CameraRole.Master].CameraMatrix, IKGrgllgMw[CameraRole.Master].DistCoefficient);
		KeyValuePair<Mat, Mat> keyValuePair2 = GLUrKGjt7j(CameraRole.Slave, P_1, virtualBoardPoints, IKGrgllgMw[CameraRole.Slave].CameraMatrix, IKGrgllgMw[CameraRole.Slave].DistCoefficient);
		IKGrgllgMw[CameraRole.Master].TargetRotation = keyValuePair.Key.Clone();
		IKGrgllgMw[CameraRole.Master].TargetTranslation = keyValuePair.Value.Clone();
		IKGrgllgMw[CameraRole.Slave].TargetRotation = keyValuePair2.Key.Clone();
		IKGrgllgMw[CameraRole.Slave].TargetTranslation = keyValuePair2.Value.Clone();
		keyValuePair.Key.Dispose();
		keyValuePair.Value.Dispose();
		keyValuePair2.Key.Dispose();
		keyValuePair2.Value.Dispose();
		MCvPoint3D32f[] array = iCorfXNUHT(dictionary, dictionary2);
		MCvPoint3D32f targetPO = array[0];
		MCvPoint3D32f targetPX = array[1];
		MCvPoint3D32f targetPY = array[2];
		IKGrgllgMw.TargetPO = targetPO;
		IKGrgllgMw.TargetPX = targetPX;
		IKGrgllgMw.TargetPY = targetPY;
		MCvPoint3D32f[] array2 = I9OrAXtCD8(new PointF[3]
		{
			dictionary[(xRbEPmueCCroWyeJSW)3],
			dictionary[(xRbEPmueCCroWyeJSW)0],
			dictionary[(xRbEPmueCCroWyeJSW)1]
		}, CameraRole.Master);
		cixr5Ms3Ku(IKGrgllgMw[CameraRole.Master], array2[0], array2[1], array2[2]);
		MCvPoint3D32f[] array3 = I9OrAXtCD8(new PointF[3]
		{
			dictionary2[(xRbEPmueCCroWyeJSW)3],
			dictionary2[(xRbEPmueCCroWyeJSW)0],
			dictionary2[(xRbEPmueCCroWyeJSW)1]
		}, CameraRole.Slave);
		cixr5Ms3Ku(IKGrgllgMw[CameraRole.Slave], array3[0], array3[1], array3[2]);
	}

	private MCvPoint3D32f[] NmXrWATHCK(VectorOfPointF P_0, VectorOfPointF P_1)
	{
		using VectorOfPoint3D32F vectorOfPoint3D32F = new VectorOfPoint3D32F();
		using Mat mat = new Mat();
		VectorOfPointF vectorOfPointF = new VectorOfPointF();
		CvInvoke.UndistortPoints(P_0, vectorOfPointF, IKGrgllgMw[CameraRole.Master].CameraMatrix, IKGrgllgMw[CameraRole.Master].DistCoefficient, IKGrgllgMw[CameraRole.Master].Rectification, IKGrgllgMw[CameraRole.Master].Projection);
		VectorOfPointF vectorOfPointF2 = new VectorOfPointF();
		CvInvoke.UndistortPoints(P_1, vectorOfPointF2, IKGrgllgMw[CameraRole.Slave].CameraMatrix, IKGrgllgMw[CameraRole.Slave].DistCoefficient, IKGrgllgMw[CameraRole.Slave].Rectification, IKGrgllgMw[CameraRole.Slave].Projection);
		if (vectorOfPointF.Length != vectorOfPointF2.Length)
		{
			int count = (int)Math.Min(vectorOfPointF.Length, vectorOfPointF2.Length);
			vectorOfPointF = new VectorOfPointF(vectorOfPointF.ToArray().Take(count).ToArray());
			vectorOfPointF2 = new VectorOfPointF(vectorOfPointF2.ToArray().Take(count).ToArray());
		}
		CvInvoke.TriangulatePoints(IKGrgllgMw[CameraRole.Master].Projection, IKGrgllgMw[CameraRole.Slave].Projection, vectorOfPointF, vectorOfPointF2, mat);
		vectorOfPointF.Dispose();
		vectorOfPointF2.Dispose();
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
		return vectorOfPoint3D32F.ToArray();
	}

	private MCvPoint3D32f[] iCorfXNUHT(Dictionary<xRbEPmueCCroWyeJSW, PointF> P_0, Dictionary<xRbEPmueCCroWyeJSW, PointF> P_1)
	{
		using VectorOfPointF vectorOfPointF = new VectorOfPointF();
		vectorOfPointF.Push(new PointF[3]
		{
			P_0[(xRbEPmueCCroWyeJSW)3],
			P_0[(xRbEPmueCCroWyeJSW)0],
			P_0[(xRbEPmueCCroWyeJSW)1]
		});
		using VectorOfPointF vectorOfPointF2 = new VectorOfPointF();
		vectorOfPointF2.Push(new PointF[3]
		{
			P_1[(xRbEPmueCCroWyeJSW)3],
			P_1[(xRbEPmueCCroWyeJSW)0],
			P_1[(xRbEPmueCCroWyeJSW)1]
		});
		return NmXrWATHCK(vectorOfPointF, vectorOfPointF2);
	}

	private KeyValuePair<Mat, Mat> GLUrKGjt7j(CameraRole P_0, Mat P_1, MCvPoint3D32f[]? mCvPoint3D32F, Mat P_3, Mat P_4)
	{
		if (mCvPoint3D32F == null)
		{
			throw new ArgumentNullException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12312), xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12342));
		}
		PointF[] points = DetectDotGrid(P_1).Points;
		IKGrgllgMw[P_0].DetectedBoardPoints = points;
		if ((points == null || points.Length == 0) ? true : false)
		{
			throw new InvalidDataException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12410));
		}
		using Mat mat = new Mat(3, 1, DepthType.Cv64F, 1);
		using Mat mat2 = new Mat(3, 1, DepthType.Cv64F, 1);
		using Mat mat3 = new Mat(3, 3, DepthType.Cv64F, 1);
		using VectorOfPoint3D32F objectPoints = new VectorOfPoint3D32F(mCvPoint3D32F.ToArray());
		using VectorOfPointF imagePoints = new VectorOfPointF(points);
		CvInvoke.SolvePnP(objectPoints, imagePoints, P_3, P_4, mat, mat2);
		CvInvoke.Rodrigues(mat, mat3);
		return new KeyValuePair<Mat, Mat>(mat3.Clone(), mat2.Clone());
	}

	private Dictionary<xRbEPmueCCroWyeJSW, PointF> ujBrVA8AYb(Mat P_0, CameraRole P_1)
	{
		Dictionary<xRbEPmueCCroWyeJSW, PointF> dictionary = new Dictionary<xRbEPmueCCroWyeJSW, PointF>();
		PointF[] points = DetectDotGrid(P_0).Points;
		if (points == null || points.Length <= 0)
		{
			throw new InvalidDataException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12568));
		}
		int num = ms4rlkL0wY.Width * (ms4rlkL0wY.Height - 1);
		int num2 = ms4rlkL0wY.Width - 1;
		dictionary[(xRbEPmueCCroWyeJSW)3] = points[0];
		dictionary[(xRbEPmueCCroWyeJSW)0] = points[num];
		dictionary[(xRbEPmueCCroWyeJSW)1] = points[num2];
		return dictionary;
	}

	private bool bEGrI3MT0J(string P_0)
	{
		string text = Path.GetExtension(P_0).ToLower();
		if (text == xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12680) || text == xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12692) || text == xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2574))
		{
			return true;
		}
		return false;
	}

	public StereoCalibrationResult CalibrateFromMats(List<Mat> collectedMasterMats, List<Mat> collectedSlaveMats, Mat masterTargetCalibrationImageMatrix, Mat slaveTargetCalibrationImageMatrix)
	{
		Dictionary<CameraRole, List<Mat>> dictionary = new Dictionary<CameraRole, List<Mat>>();
		dictionary[CameraRole.Master] = collectedMasterMats;
		dictionary[CameraRole.Slave] = collectedSlaveMats;
		return Calibrate(dictionary, masterTargetCalibrationImageMatrix, slaveTargetCalibrationImageMatrix);
	}

	private static void cixr5Ms3Ku(CalibrationResult P_0, MCvPoint3D32f P_1, MCvPoint3D32f P_2, MCvPoint3D32f P_3)
	{
		MCvPoint3D32f mCvPoint3D32f = yt2rwISFlU(P_2 - P_1);
		MCvPoint3D32f mCvPoint3D32f2 = yt2rwISFlU(P_3 - P_1);
		MCvPoint3D32f mCvPoint3D32f3 = yt2rwISFlU(aFXrojmFnJ(mCvPoint3D32f, mCvPoint3D32f2));
		MCvPoint3D32f targetVY = yt2rwISFlU(aFXrojmFnJ(mCvPoint3D32f, mCvPoint3D32f3));
		P_0.TargetOrigin = P_1;
		P_0.TargetVX = mCvPoint3D32f;
		P_0.TargetVY = targetVY;
		P_0.TargetVZ = mCvPoint3D32f3;
	}

	private MCvPoint3D32f[] I9OrAXtCD8(PointF[] P_0, CameraRole P_1, float P_2 = 0f)
	{
		CalibrationResult calibrationResult = IKGrgllgMw[P_1];
		MCvPoint3D32f[] array = new MCvPoint3D32f[P_0.Length];
		using VectorOfPointF src = new VectorOfPointF(P_0);
		using VectorOfPointF vectorOfPointF = new VectorOfPointF();
		CvInvoke.UndistortPoints(src, vectorOfPointF, calibrationResult.CameraMatrix, calibrationResult.DistCoefficient, calibrationResult.Rectification, calibrationResult.Projection);
		using Mat mat = new Mat();
		CvInvoke.Invert(calibrationResult.TargetRotation, mat, DecompMethod.LU);
		using Mat mat2 = new Mat();
		CvInvoke.Invert(calibrationResult.CameraMatrix, mat2, DecompMethod.LU);
		Mat targetTranslation = calibrationResult.TargetTranslation;
		using Mat mat3 = new Mat();
		CvInvoke.Gemm(mat, targetTranslation, 1.0, null, 0.0, mat3);
		double num = oaBtWW8J5C9uEnllFR.vZB43531sp(mat3, 2, 0);
		for (int i = 0; i < vectorOfPointF.Size; i++)
		{
			PointF pointF = vectorOfPointF[i];
			using Mat mat4 = new Mat(3, 1, DepthType.Cv64F, 1);
			mat4.SetTo(new double[3] { pointF.X, pointF.Y, 1.0 });
			using Mat mat5 = new Mat();
			CvInvoke.Gemm(mat2, mat4, 1.0, null, 0.0, mat5);
			using Mat mat6 = new Mat();
			CvInvoke.Gemm(mat, mat5, 1.0, null, 0.0, mat6);
			double num2 = oaBtWW8J5C9uEnllFR.vZB43531sp(mat6, 2, 0);
			double v = ((double)P_2 + num) / num2;
			using Mat mat7 = new Mat(3, 1, DepthType.Cv64F, 1);
			mat7.SetTo(new MCvScalar(v));
			using Mat mat8 = new Mat();
			CvInvoke.Multiply(mat5, mat7, mat8);
			using Mat mat9 = new Mat();
			CvInvoke.Subtract(mat8, targetTranslation, mat9);
			using Mat mat10 = new Mat();
			CvInvoke.Gemm(mat, mat9, 1.0, null, 0.0, mat10);
			array[i] = new MCvPoint3D32f((float)oaBtWW8J5C9uEnllFR.vZB43531sp(mat10, 0, 0), (float)oaBtWW8J5C9uEnllFR.vZB43531sp(mat10, 1, 0), (float)oaBtWW8J5C9uEnllFR.vZB43531sp(mat10, 2, 0));
		}
		return array;
	}

	private static double hMArZ4lNUO(Mat P_0, SimpleBlobDetector P_1)
	{
		using VectorOfKeyPoint vectorOfKeyPoint = new VectorOfKeyPoint();
		P_1.DetectRaw(P_0, vectorOfKeyPoint);
		double[] array = (from k in vectorOfKeyPoint.ToArray()
			select (double)k.Size * 0.5 into r
			where r > 0.0
			orderby r
			select r).ToArray();
		if (array.Length == 0)
		{
			return double.NaN;
		}
		return array[array.Length / 2];
	}

	private static MCvPoint3D32f VFDrtWO7pG(MCvPoint3D32f P_0, MCvPoint3D32f P_1)
	{
		return new MCvPoint3D32f(P_0.X - P_1.X, P_0.Y - P_1.Y, P_0.Z - P_1.Z);
	}

	private static float Ip5r0pHLg2(MCvPoint3D32f P_0)
	{
		return MathF.Sqrt(P_0.X * P_0.X + P_0.Y * P_0.Y + P_0.Z * P_0.Z);
	}

	private static MCvPoint3D32f yt2rwISFlU(MCvPoint3D32f P_0)
	{
		float num = Ip5r0pHLg2(P_0);
		if (!(num > 1E-09f))
		{
			return P_0;
		}
		return new MCvPoint3D32f(P_0.X / num, P_0.Y / num, P_0.Z / num);
	}

	private static MCvPoint3D32f aFXrojmFnJ(MCvPoint3D32f P_0, MCvPoint3D32f P_1)
	{
		return new MCvPoint3D32f(P_0.Y * P_1.Z - P_0.Z * P_1.Y, P_0.Z * P_1.X - P_0.X * P_1.Z, P_0.X * P_1.Y - P_0.Y * P_1.X);
	}
}
