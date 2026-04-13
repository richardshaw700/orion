using System.Drawing;
using System.Globalization;
using System.Text;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using IodKeMsDBY9RwTYmwo;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration.Services.Serialization;

public class OpenCvMatToStringConverter
{
	public static string ToString(MCvPoint3D32f vec)
	{
		string text = vec.X.ToString(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6276), CultureInfo.InvariantCulture);
		string text2 = vec.Y.ToString(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6276), CultureInfo.InvariantCulture);
		string text3 = vec.Z.ToString(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6276), CultureInfo.InvariantCulture);
		return text + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6286) + text2 + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6286) + text3 + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6286);
	}

	public static string ToString(PointF point)
	{
		return string.Concat(point.X.ToString(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6276), CultureInfo.InvariantCulture), str2: point.Y.ToString(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6276), CultureInfo.InvariantCulture), str1: xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6286), str3: xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6286));
	}

	public static string ToString(Rectangle roiRect)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(roiRect.X);
		stringBuilder.Append(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6286));
		stringBuilder.Append(roiRect.Y);
		stringBuilder.Append(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6286));
		stringBuilder.Append(roiRect.Width);
		stringBuilder.Append(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6286));
		stringBuilder.Append(roiRect.Height);
		stringBuilder.Append(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6286));
		return stringBuilder.ToString();
	}

	public static string ToString(Mat? value)
	{
		if (value == null)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(value.Rows + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6286));
		stringBuilder.Append(value.Cols + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6286));
		stringBuilder.Append((int)value.Depth + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6286));
		int numberOfChannels = value.NumberOfChannels;
		if (value.Depth == DepthType.Cv32F && numberOfChannels == 1)
		{
			Matrix<float> matrix = new Matrix<float>(value.Rows, value.Cols);
			value.CopyTo(matrix);
			for (int i = 0; i < value.Rows; i++)
			{
				for (int j = 0; j < value.Cols; j++)
				{
					stringBuilder.Append(matrix[i, j].ToString(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6276), CultureInfo.InvariantCulture) + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6286));
				}
			}
		}
		if (value.Depth == DepthType.Cv64F && numberOfChannels == 1)
		{
			Matrix<double> matrix2 = new Matrix<double>(value.Rows, value.Cols);
			value.CopyTo(matrix2);
			for (int k = 0; k < value.Rows; k++)
			{
				for (int l = 0; l < value.Cols; l++)
				{
					stringBuilder.Append(matrix2[k, l].ToString(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6276), CultureInfo.InvariantCulture) + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6286));
				}
			}
		}
		return stringBuilder.ToString();
	}

	public OpenCvMatToStringConverter()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		base._002Ector();
	}
}
