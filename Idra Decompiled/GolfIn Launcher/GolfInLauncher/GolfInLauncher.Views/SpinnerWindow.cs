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
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Views;

public class SpinnerWindow : Window, IComponentConnector
{
	private bool BLhkH9V0Un;

	public SpinnerWindow()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		((Window)this)._002Ector();
		InitializeComponent();
	}

	private void M4Hkxve5EF(object P_0, RoutedEventArgs P_1)
	{
		WeakReferenceMessenger.Default.Send(new SendContainerConfigMessage(new SendContainerConfigMessageArguments
		{
			TopMost = false,
			WindowState = (WindowState)1
		}));
		WeakReferenceMessenger.Default.Send(new SendContainerConfigMessage(new SendContainerConfigMessageArguments
		{
			TopMost = true,
			WindowState = (WindowState)2
		}));
	}

	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!BLhkH9V0Un)
		{
			BLhkH9V0Un = true;
			Uri uri = new Uri(aL07ImwcwlxdnyfI30.olMQlwrxmw(2472), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(M4Hkxve5EF);
			break;
		case 2:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(M4Hkxve5EF);
			break;
		default:
			BLhkH9V0Un = true;
			break;
		}
	}
}
