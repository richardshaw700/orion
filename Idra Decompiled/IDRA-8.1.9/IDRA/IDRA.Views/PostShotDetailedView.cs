using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using GIToolkit.Services;
using GhU84wwqvI4UZ3pBfu;
using IDRA.ViewModels;
using LiveChartsCore.SkiaSharpView.WPF;
using Unosquare.FFME;
using Unosquare.FFME.Common;
using sxB8TYTZ87aKuujytY;

namespace IDRA.Views;

public class PostShotDetailedView : UserControl, IComponentConnector
{
	internal Grid CentralGraphs;

	internal Border BallPositionGraph;

	internal Border PutterView;

	internal Border TopViewGraph;

	internal CartesianChart TopViewChart;

	internal Border SideViewGraph;

	internal Grid Video;

	internal MediaElement cameraFeed;

	internal Slider videoSlider;

	internal TextBlock Clock;

	private bool d7Vl8uflQ;

	public PostShotDetailedView()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		((UserControl)this)._002Ector();
		InitializeComponent();
		cameraFeed.MessageLogged += fwZrda5Xs;
		((FrameworkElement)this).DataContextChanged += new DependencyPropertyChangedEventHandler(gwLA5ALsE);
		((FrameworkElement)this).Unloaded += new RoutedEventHandler(znXZ7qDr9);
	}

	private void fwZrda5Xs(object P_0, MediaLogMessageEventArgs P_1)
	{
		if (P_1.MessageType == MediaLogMessageType.Error)
		{
			EventViewerLogger.LogException(new Exception(P_1.Message));
		}
	}

	private async void gwLA5ALsE(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (((FrameworkElement)this).DataContext == null)
		{
			return;
		}
		try
		{
			await ((PostShotViewModel)((FrameworkElement)this).DataContext).PostShotMediaPlayer.InitializeDependencyUIElement(cameraFeed);
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
		}
	}

	private async void znXZ7qDr9(object P_0, RoutedEventArgs P_1)
	{
		((FrameworkElement)this).DataContextChanged -= new DependencyPropertyChangedEventHandler(gwLA5ALsE);
		((FrameworkElement)this).DataContext = null;
		if (cameraFeed == null)
		{
			return;
		}
		try
		{
			cameraFeed.MessageLogged -= fwZrda5Xs;
			await cameraFeed.Close();
			cameraFeed.Dispose();
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!d7Vl8uflQ)
		{
			d7Vl8uflQ = true;
			Uri uri = new Uri(QQXBLjLprwI58ya4VR.y8v8TMFOCb(1442), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			CentralGraphs = (Grid)target;
			break;
		case 2:
			BallPositionGraph = (Border)target;
			break;
		case 3:
			PutterView = (Border)target;
			break;
		case 4:
			TopViewGraph = (Border)target;
			break;
		case 5:
			TopViewChart = (CartesianChart)target;
			break;
		case 6:
			SideViewGraph = (Border)target;
			break;
		case 7:
			Video = (Grid)target;
			break;
		case 8:
			cameraFeed = (MediaElement)target;
			break;
		case 9:
			videoSlider = (Slider)target;
			break;
		case 10:
			Clock = (TextBlock)target;
			break;
		default:
			d7Vl8uflQ = true;
			break;
		}
	}
}
