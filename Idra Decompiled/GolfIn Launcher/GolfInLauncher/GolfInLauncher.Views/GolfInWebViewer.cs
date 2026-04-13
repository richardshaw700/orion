using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using GolfInLauncher.Services;
using Lmttrs0IQc7UR7Zpt6;
using Microsoft.Web.WebView2.Wpf;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Views;

public class GolfInWebViewer : UserControl, IComponentConnector
{
	private readonly KeyboardService gAvUwsiRH;

	internal GolfInWebViewer WebWindow;

	internal MediaElement mediaPlayer;

	internal Button btn_play;

	internal Button btn_pause;

	internal Button btn_stop;

	internal WebView2 webBrowser;

	internal WebBrowser pdfViewer;

	internal Button btn_goback;

	private bool plIthOx88;

	public GolfInWebViewer()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		((UserControl)this)._002Ector();
		gAvUwsiRH = new KeyboardService();
		gAvUwsiRH.SettingsHookOnKey();
		InitializeComponent();
		mediaPlayer.MediaFailed += PgoWOmuZF;
		((UIElement)this).KeyDown += new KeyEventHandler(gAvUwsiRH.OnKeyDown);
		((UIElement)this).KeyUp += new KeyEventHandler(gAvUwsiRH.OnKeyUp);
	}

	private void gaK7XKEOK(object P_0, RoutedEventArgs P_1)
	{
		mediaPlayer.Play();
	}

	private void cGPvF7GAK(object P_0, RoutedEventArgs P_1)
	{
		mediaPlayer.Pause();
	}

	private void c1dBB6xnf(object P_0, RoutedEventArgs P_1)
	{
		mediaPlayer.Stop();
		mediaPlayer.Play();
	}

	private void PgoWOmuZF(object P_0, ExceptionRoutedEventArgs P_1)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(aL07ImwcwlxdnyfI30.olMQlwrxmw(1766) + P_1.ErrorException.Message);
	}

	private void mxyMhT7Cm(object P_0, RoutedEventArgs P_1)
	{
		mediaPlayer.Play();
	}

	private void XQiF7DK1l(object P_0, RoutedEventArgs P_1)
	{
	}

	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!plIthOx88)
		{
			plIthOx88 = true;
			Uri uri = new Uri(aL07ImwcwlxdnyfI30.olMQlwrxmw(1800), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			WebWindow = (GolfInWebViewer)target;
			((FrameworkElement)WebWindow).Loaded += new RoutedEventHandler(mxyMhT7Cm);
			break;
		case 2:
			mediaPlayer = (MediaElement)target;
			break;
		case 3:
			btn_play = (Button)target;
			((ButtonBase)btn_play).Click += new RoutedEventHandler(gaK7XKEOK);
			break;
		case 4:
			btn_pause = (Button)target;
			((ButtonBase)btn_pause).Click += new RoutedEventHandler(cGPvF7GAK);
			break;
		case 5:
			btn_stop = (Button)target;
			((ButtonBase)btn_stop).Click += new RoutedEventHandler(c1dBB6xnf);
			break;
		case 6:
			webBrowser = (WebView2)target;
			break;
		case 7:
			pdfViewer = (WebBrowser)target;
			break;
		case 8:
			btn_goback = (Button)target;
			break;
		default:
			plIthOx88 = true;
			break;
		}
	}
}
