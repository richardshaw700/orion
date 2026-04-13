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

public class MaintenanceWindow : UserControl, IComponentConnector, IStyleConnector
{
	private bool q9MRiZAOx;

	public MaintenanceWindow()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		((UserControl)this)._002Ector();
		InitializeComponent();
		WeakReferenceMessenger.Default.Send(new RefreshCardListMessage(0));
	}

	private void mw9LHobal(object P_0, RoutedEventArgs P_1)
	{
		string programName = ((FrameworkElement)(Tile)P_0).Tag.ToString();
		WeakReferenceMessenger.Default.Send(new MaintenanceLaunchProgramMessage(programName));
	}

	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!q9MRiZAOx)
		{
			q9MRiZAOx = true;
			Uri uri = new Uri(aL07ImwcwlxdnyfI30.olMQlwrxmw(1908), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		q9MRiZAOx = true;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			((ButtonBase)(Tile)target).Click += new RoutedEventHandler(mw9LHobal);
			break;
		case 2:
			((ButtonBase)(Tile)target).Click += new RoutedEventHandler(mw9LHobal);
			break;
		}
	}
}
