using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using IodKeMsDBY9RwTYmwo;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration;

public class DistortionViewerWindow : Window, IComponentConnector
{
	private Mat? SMJMdYoWrJ;

	private Mat? CgFMrDLGRb;

	private Mat? ux0MJLlmtt;

	private Mat? IOtM4nnl5P;

	private Size RDfMnCAEfh;

	internal TextBlock InfoText;

	internal Image MasterImg;

	internal Image SlaveImg;

	private bool RuDM1WsHu4;

	public DistortionViewerWindow()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		((Window)this)._002Ector();
		InitializeComponent();
	}

	public void SetCalibration(Mat masterK, Mat masterD, Mat slaveK, Mat slaveD, Size size)
	{
		SMJMdYoWrJ = masterK;
		CgFMrDLGRb = masterD;
		ux0MJLlmtt = slaveK;
		IOtM4nnl5P = slaveD;
		RDfMnCAEfh = size;
		Refresh();
	}

	private void bK8Xz3MyOI(object P_0, RoutedEventArgs P_1)
	{
		Refresh();
	}

	private void Refresh()
	{
		if (SMJMdYoWrJ == null || CgFMrDLGRb == null || ux0MJLlmtt == null || IOtM4nnl5P == null)
		{
			return;
		}
		int value;
		using Mat mat = PmDM3oeVaX(SMJMdYoWrJ, CgFMrDLGRb, RDfMnCAEfh, out value);
		MasterImg.Source = (ImageSource)(object)m4kMkDmmS8(mat);
		int value2;
		using Mat mat2 = PmDM3oeVaX(ux0MJLlmtt, IOtM4nnl5P, RDfMnCAEfh, out value2);
		SlaveImg.Source = (ImageSource)(object)m4kMkDmmS8(mat2);
		TextBlock infoText = InfoText;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2874));
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2922));
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		infoText.Text = defaultInterpolatedStringHandler.ToStringAndClear();
	}

	private static Mat PmDM3oeVaX(Mat P_0, Mat P_1, Size P_2, out int P_3)
	{
		using Mat src = ICsMXp9gbe(P_2.Width, P_2.Height, 40);
		using Mat map = new Mat();
		using Mat map2 = new Mat();
		CvInvoke.InitUndistortRectifyMap(P_0, P_1, null, P_0, P_2, DepthType.Cv32F, 1, map, map2);
		Mat mat = new Mat();
		CvInvoke.Remap(src, mat, map, map2, Inter.Linear, BorderType.Constant, new MCvScalar(0.0, 0.0, 0.0));
		P_3 = b9DMMLV5jf(mat, P_0, P_1, P_2, 40);
		return mat;
	}

	private static Mat ICsMXp9gbe(int P_0, int P_1, int P_2)
	{
		Mat mat = new Mat(P_1, P_0, DepthType.Cv8U, 3);
		mat.SetTo(new MCvScalar(0.0, 0.0, 0.0));
		MCvScalar color = new MCvScalar(255.0, 255.0, 255.0);
		for (int i = 0; i < P_0; i += P_2)
		{
			CvInvoke.Line(mat, new Point(i, 0), new Point(i, P_1 - 1), color);
		}
		for (int j = 0; j < P_1; j += P_2)
		{
			CvInvoke.Line(mat, new Point(0, j), new Point(P_0 - 1, j), color);
		}
		CvInvoke.Rectangle(color: new MCvScalar(0.0, 0.0, 255.0), img: mat, rect: new Rectangle(10, 10, P_0 - 20, P_1 - 20), thickness: 3);
		return mat;
	}

	private static int b9DMMLV5jf(Mat P_0, Mat P_1, Mat P_2, Size P_3, int P_4)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < P_3.Width; i += P_4)
		{
			list.Add(i);
		}
		if (list[list.Count - 1] != P_3.Width - 1)
		{
			list.Add(P_3.Width - 1);
		}
		List<int> list2 = new List<int>();
		for (int j = 0; j < P_3.Height; j += P_4)
		{
			list2.Add(j);
		}
		if (list2[list2.Count - 1] != P_3.Height - 1)
		{
			list2.Add(P_3.Height - 1);
		}
		int count = list.Count;
		int count2 = list2.Count;
		List<PointF> list3 = new List<PointF>(count * count2);
		for (int k = 0; k < count2; k++)
		{
			for (int l = 0; l < count; l++)
			{
				list3.Add(new PointF(list[l], list2[k]));
			}
		}
		using VectorOfPointF src = new VectorOfPointF(list3.ToArray());
		using VectorOfPointF vectorOfPointF = new VectorOfPointF();
		CvInvoke.UndistortPoints(src, vectorOfPointF, P_1, P_2, null, P_1);
		PointF[] array = vectorOfPointF.ToArray();
		int num = 0;
		int num2 = 0;
		MCvScalar mCvScalar = new MCvScalar(0.0, 255.0, 255.0);
		MCvScalar mCvScalar2 = new MCvScalar(0.0, 0.0, 255.0);
		double num3 = 0.15;
		for (int m = 0; m < count2 - 1; m++)
		{
			for (int n = 0; n < count - 1; n++)
			{
				int num4 = m * count + n;
				int num5 = m * count + (n + 1);
				int num6 = (m + 1) * count + n;
				PointF pointF = array[num4];
				PointF pointF2 = array[num5];
				PointF pointF3 = array[num6];
				double num7 = pointF2.X - pointF.X;
				double num8 = pointF2.Y - pointF.Y;
				double num9 = pointF3.X - pointF.X;
				double num10 = pointF3.Y - pointF.Y;
				double value = num7 * num10 - num8 * num9;
				double num11 = Math.Abs(value);
				if (num2 == 0 && num11 > num3)
				{
					num2 = Math.Sign(value);
				}
				bool num12 = num11 <= num3;
				bool flag = num2 != 0 && Math.Sign(value) != num2;
				if (num12 || flag)
				{
					num++;
					Rectangle rect = new Rectangle(list[n], list2[m], list[n + 1] - list[n], list2[m + 1] - list2[m]);
					CvInvoke.Rectangle(P_0, rect, flag ? mCvScalar2 : mCvScalar, 2);
				}
			}
		}
		return num;
	}

	private static BitmapSource m4kMkDmmS8(Mat P_0)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		int width = P_0.Width;
		int height = P_0.Height;
		int step = P_0.Step;
		return BitmapSource.Create(width, height, 96.0, 96.0, PixelFormats.Bgr24, (BitmapPalette)null, (IntPtr)P_0.DataPointer, step * height, step);
	}

	[GeneratedCode("PresentationBuildTasks", "8.0.24.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!RuDM1WsHu4)
		{
			RuDM1WsHu4 = true;
			Uri uri = new Uri(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2942), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "8.0.24.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(bK8Xz3MyOI);
			break;
		case 2:
			InfoText = (TextBlock)target;
			break;
		case 3:
			MasterImg = (Image)target;
			break;
		case 4:
			SlaveImg = (Image)target;
			break;
		default:
			RuDM1WsHu4 = true;
			break;
		}
	}
}
