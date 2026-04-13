using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using IDRAAutoCalibration.DTO.Calibration;
using IodKeMsDBY9RwTYmwo;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration.Services.Serialization;

public static class StereoCalibrationResultXmlReader
{
	private static readonly CultureInfo F78kTwimtt;

	public static StereoCalibrationResult Load(string xmlPath)
	{
		if (string.IsNullOrWhiteSpace(xmlPath))
		{
			throw new ArgumentException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6292), xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6342));
		}
		XElement xElement = XDocument.Load(xmlPath).Root ?? throw new FormatException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6360));
		if (!string.Equals(xElement.Name.LocalName, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5850), StringComparison.OrdinalIgnoreCase))
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 1);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6406));
			defaultInterpolatedStringHandler.AppendFormatted(xElement.Name);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6460));
			throw new FormatException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		StereoCalibrationResult stereoCalibrationResult = new StereoCalibrationResult();
		XElement xElement2 = JYxkYadOa3(xElement, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5892));
		XElement xElement3 = JYxkYadOa3(xElement2, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5910));
		XElement xElement4 = JYxkYadOa3(xElement2, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5928));
		srOkoIIWnT(stereoCalibrationResult, xElement3, CameraRole.Master);
		srOkoIIWnT(stereoCalibrationResult, xElement4, CameraRole.Slave);
		XElement xElement5 = JYxkYadOa3(xElement, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6022));
		XElement xElement6 = JYxkYadOa3(xElement5, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5892));
		XElement xElement7 = JYxkYadOa3(xElement6, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5910));
		XElement xElement8 = JYxkYadOa3(xElement6, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5928));
		jVFkloPE1Q(stereoCalibrationResult, xElement7, CameraRole.Master);
		jVFkloPE1Q(stereoCalibrationResult, xElement8, CameraRole.Slave);
		stereoCalibrationResult.PerspectiveTransformation = rymkggqm7V(egPkD8TvFV(xElement5, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6102)));
		stereoCalibrationResult.RotationMatrix = rymkggqm7V(egPkD8TvFV(xElement5, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6156)));
		stereoCalibrationResult.TranslationVector = rymkggqm7V(egPkD8TvFV(xElement5, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6176)));
		XElement xElement9 = JYxkYadOa3(xElement, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5876));
		XElement xElement10 = JYxkYadOa3(xElement9, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5892));
		XElement xElement11 = JYxkYadOa3(xElement10, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5910));
		XElement xElement12 = JYxkYadOa3(xElement10, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5928));
		tBXkLAEqHU(stereoCalibrationResult, xElement11, CameraRole.Master);
		tBXkLAEqHU(stereoCalibrationResult, xElement12, CameraRole.Slave);
		stereoCalibrationResult.TargetPO = XX3kQ38nZe(egPkD8TvFV(xElement9, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5946)));
		stereoCalibrationResult.TargetPX = XX3kQ38nZe(egPkD8TvFV(xElement9, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5954)));
		stereoCalibrationResult.TargetPY = XX3kQ38nZe(egPkD8TvFV(xElement9, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5962)));
		return stereoCalibrationResult;
	}

	private static void srOkoIIWnT(StereoCalibrationResult P_0, XElement P_1, CameraRole P_2)
	{
		string cameraId = egPkD8TvFV(P_1, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6264));
		string text = egPkD8TvFV(P_1, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6202));
		string text2 = egPkD8TvFV(P_1, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6248));
		CalibrationResult calibrationResult = P_0[P_2];
		calibrationResult.CameraId = cameraId;
		calibrationResult.DistCoefficient?.Dispose();
		calibrationResult.CameraMatrix?.Dispose();
		calibrationResult.DistCoefficient = rymkggqm7V(text);
		calibrationResult.CameraMatrix = rymkggqm7V(text2);
	}

	private static void jVFkloPE1Q(StereoCalibrationResult P_0, XElement P_1, CameraRole P_2)
	{
		string text = egPkD8TvFV(P_1, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6072));
		string text2 = egPkD8TvFV(P_1, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6038));
		string text3 = egPkD8TvFV(P_1, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6062));
		CalibrationResult calibrationResult = P_0[P_2];
		calibrationResult.Rectification?.Dispose();
		calibrationResult.Projection?.Dispose();
		calibrationResult.Rectification = rymkggqm7V(text);
		calibrationResult.Projection = rymkggqm7V(text2);
		calibrationResult.ROI = RRnkPpyOov(text3);
	}

	private static void tBXkLAEqHU(StereoCalibrationResult P_0, XElement P_1, CameraRole P_2)
	{
		CalibrationResult calibrationResult = P_0[P_2];
		calibrationResult.TargetOrigin = XX3kQ38nZe(egPkD8TvFV(P_1, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5970)));
		calibrationResult.TargetVX = XX3kQ38nZe(egPkD8TvFV(P_1, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5998)));
		calibrationResult.TargetVY = XX3kQ38nZe(egPkD8TvFV(P_1, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6006)));
		calibrationResult.TargetVZ = XX3kQ38nZe(egPkD8TvFV(P_1, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6014)));
		calibrationResult.TargetPO = b4LkEvk7d4(egPkD8TvFV(P_1, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5946)));
		calibrationResult.TargetPX = b4LkEvk7d4(egPkD8TvFV(P_1, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5954)));
		calibrationResult.TargetPY = b4LkEvk7d4(egPkD8TvFV(P_1, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5962)));
		calibrationResult.TargetRotation?.Dispose();
		calibrationResult.TargetTranslation?.Dispose();
		calibrationResult.TargetRotation = rymkggqm7V(egPkD8TvFV(P_1, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5986)));
		calibrationResult.TargetTranslation = rymkggqm7V(egPkD8TvFV(P_1, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5992)));
	}

	private static XElement JYxkYadOa3(XElement P_0, string P_1)
	{
		XElement? xElement = P_0.Element(P_1);
		if (xElement == null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6516));
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6554));
			defaultInterpolatedStringHandler.AppendFormatted(P_0.Name);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6576));
			throw new FormatException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return xElement;
	}

	private static string egPkD8TvFV(XElement P_0, string P_1)
	{
		XElement? xElement = P_0.Element(P_1);
		if (xElement == null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6516));
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6554));
			defaultInterpolatedStringHandler.AppendFormatted(P_0.Name);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6576));
			throw new FormatException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return (xElement.Value ?? string.Empty).Trim();
	}

	private static Mat rymkggqm7V(string P_0)
	{
		string[] array = OpSkawyTlm(P_0);
		if (array.Length < 4)
		{
			throw new FormatException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6584) + P_0 + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6666));
		}
		int num = sbTkB1ghFv(array[0]);
		int num2 = sbTkB1ghFv(array[1]);
		int num3 = sbTkB1ghFv(array[2]);
		if (num <= 0 || num2 <= 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 3);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6672));
			defaultInterpolatedStringHandler.AppendFormatted(num);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6710));
			defaultInterpolatedStringHandler.AppendFormatted(num2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6716));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6666));
			throw new FormatException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		var (num4, num5) = lAlkygV5vE(num3);
		DepthType depthType;
		switch (num4)
		{
		case 0:
			depthType = DepthType.Cv8U;
			break;
		case 1:
			depthType = DepthType.Cv8S;
			break;
		case 2:
			depthType = DepthType.Cv16U;
			break;
		case 3:
			depthType = DepthType.Cv16S;
			break;
		case 4:
			depthType = DepthType.Cv32S;
			break;
		case 5:
			depthType = DepthType.Cv32F;
			break;
		case 6:
			depthType = DepthType.Cv64F;
			break;
		default:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6730));
			defaultInterpolatedStringHandler.AppendFormatted(num4);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6796));
			defaultInterpolatedStringHandler.AppendFormatted(num3);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6820));
			throw new FormatException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		}
		DepthType depthType2 = depthType;
		Mat mat = new Mat(num, num2, depthType2, num5);
		int num6 = checked(num * num2 * num5);
		int num7 = array.Length - 3;
		if (num7 < num6)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6828));
			defaultInterpolatedStringHandler.AppendFormatted(num6);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6890));
			defaultInterpolatedStringHandler.AppendFormatted(num7);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3302));
			throw new FormatException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		string[] array2 = array.Skip(3).Take(num6).ToArray();
		nint dataPointer = mat.DataPointer;
		switch (depthType2)
		{
		case DepthType.Cv64F:
		{
			double[] array4 = new double[num6];
			for (int j = 0; j < num6; j++)
			{
				array4[j] = J6ekCC0IUB(array2[j]);
			}
			Marshal.Copy(array4, 0, dataPointer, num6);
			break;
		}
		case DepthType.Cv32F:
		{
			float[] array7 = new float[num6];
			for (int m = 0; m < num6; m++)
			{
				array7[m] = (float)J6ekCC0IUB(array2[m]);
			}
			Marshal.Copy(array7, 0, dataPointer, num6);
			break;
		}
		case DepthType.Cv32S:
		{
			int[] array5 = new int[num6];
			for (int k = 0; k < num6; k++)
			{
				array5[k] = sbTkB1ghFv(array2[k]);
			}
			Marshal.Copy(array5, 0, dataPointer, num6);
			break;
		}
		case DepthType.Cv16U:
		case DepthType.Cv16S:
		{
			short[] array6 = new short[num6];
			for (int l = 0; l < num6; l++)
			{
				array6[l] = (short)sbTkB1ghFv(array2[l]);
			}
			Marshal.Copy(array6, 0, dataPointer, num6);
			break;
		}
		case DepthType.Cv8U:
		case DepthType.Cv8S:
		{
			byte[] array3 = new byte[num6];
			for (int i = 0; i < num6; i++)
			{
				array3[i] = (byte)sbTkB1ghFv(array2[i]);
			}
			Marshal.Copy(array3, 0, dataPointer, num6);
			break;
		}
		default:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6920));
			defaultInterpolatedStringHandler.AppendFormatted(depthType2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6962));
			throw new FormatException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		}
		return mat;
	}

	private static Rectangle RRnkPpyOov(string P_0)
	{
		string[] array = OpSkawyTlm(P_0);
		if (array.Length < 4)
		{
			throw new FormatException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6970) + P_0 + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6666));
		}
		int x = sbTkB1ghFv(array[0]);
		int y = sbTkB1ghFv(array[1]);
		int width = sbTkB1ghFv(array[2]);
		int height = sbTkB1ghFv(array[3]);
		return new Rectangle(x, y, width, height);
	}

	private static PointF b4LkEvk7d4(string P_0)
	{
		string[] array = OpSkawyTlm(P_0);
		if (array.Length < 2)
		{
			throw new FormatException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(7020) + P_0 + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6666));
		}
		return new PointF((float)J6ekCC0IUB(array[0]), (float)J6ekCC0IUB(array[1]));
	}

	private static MCvPoint3D32f XX3kQ38nZe(string P_0)
	{
		string[] array = OpSkawyTlm(P_0);
		if (array.Length < 3)
		{
			throw new FormatException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(7076) + P_0 + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6666));
		}
		return new MCvPoint3D32f((float)J6ekCC0IUB(array[0]), (float)J6ekCC0IUB(array[1]), (float)J6ekCC0IUB(array[2]));
	}

	private static string[] OpSkawyTlm(string P_0)
	{
		return (from x in P_0.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries)
			select x.Trim() into x
			where x.Length > 0
			select x).ToArray();
	}

	private static int sbTkB1ghFv(string P_0)
	{
		return int.Parse(P_0, NumberStyles.Integer, F78kTwimtt);
	}

	private static double J6ekCC0IUB(string P_0)
	{
		return double.Parse(P_0, NumberStyles.Float, F78kTwimtt);
	}

	private static (int depthCode, int channels) lAlkygV5vE(int P_0)
	{
		int item = P_0 & 7;
		int item2 = (P_0 >> 3) + 1;
		return (depthCode: item, channels: item2);
	}

	static StereoCalibrationResultXmlReader()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		F78kTwimtt = CultureInfo.InvariantCulture;
	}
}
