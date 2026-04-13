using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using CommunityToolkit.Mvvm.Messaging;
using GolfInLauncher.Messages;
using Lmttrs0IQc7UR7Zpt6;
using MahApps.Metro.Controls;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Views;

public class MainWindow : UserControl, IComponentConnector, IStyleConnector
{
	internal MainWindow mainwindow;

	internal Grid mainGrid;

	private bool H88gvS59n;

	public MainWindow()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		((UserControl)this)._002Ector();
		InitializeComponent();
	}

	private void B7Cn7Yw6k(object P_0, RoutedEventArgs P_1)
	{
		string programName = ((FrameworkElement)(Tile)P_0).Tag.ToString();
		WeakReferenceMessenger.Default.Send(new MainLaunchProgramMessage(programName));
	}

	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!H88gvS59n)
		{
			H88gvS59n = true;
			Uri uri = new Uri(aL07ImwcwlxdnyfI30.olMQlwrxmw(2020), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			mainwindow = (MainWindow)target;
			break;
		case 2:
			mainGrid = (Grid)target;
			break;
		default:
			H88gvS59n = true;
			break;
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		switch (connectionId)
		{
		case 3:
			((ButtonBase)(Tile)target).Click += new RoutedEventHandler(B7Cn7Yw6k);
			break;
		case 4:
			((ButtonBase)(Tile)target).Click += new RoutedEventHandler(B7Cn7Yw6k);
			break;
		}
	}
}
