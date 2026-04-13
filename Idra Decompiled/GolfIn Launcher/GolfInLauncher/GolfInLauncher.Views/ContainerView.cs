using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Markup;
using CommunityToolkit.Mvvm.Messaging;
using GolfInLauncher.Messages;
using GolfInLauncher.Services;
using Lmttrs0IQc7UR7Zpt6;
using MahApps.Metro.Controls;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Views;

public class ContainerView : MetroWindow, IComponentConnector
{
	private bool ON0JW0uR1;

	public ContainerView()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
		InitializeComponent();
		WeakReferenceMessenger.Default.Register<CloseApplicationMessage>(this, Iy0ijue7S);
		WeakReferenceMessenger.Default.Register<CloseAndStartCalibrationMessage>(this, FE0PFsYvU);
	}

	private void Iy0ijue7S(object P_0, CloseApplicationMessage P_1)
	{
		if (P_1.ExitCode == 100)
		{
			((Window)this).Close();
		}
	}

	private void FE0PFsYvU(object P_0, CloseAndStartCalibrationMessage P_1)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if (P_1.ExitCode == 100)
		{
			string iDRAAutoCalibrationPath = LauncherConstant.IDRAAutoCalibrationPath;
			if (File.Exists(iDRAAutoCalibrationPath))
			{
				Process.Start(iDRAAutoCalibrationPath);
				((Window)this).Close();
			}
			else
			{
				MessageBox.Show(aL07ImwcwlxdnyfI30.olMQlwrxmw(1210), aL07ImwcwlxdnyfI30.olMQlwrxmw(1648), (MessageBoxButton)0, (MessageBoxImage)16);
			}
		}
	}

	protected override void OnClosed(EventArgs e)
	{
		((Window)this).OnClosed(e);
	}

	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!ON0JW0uR1)
		{
			ON0JW0uR1 = true;
			Uri uri = new Uri(aL07ImwcwlxdnyfI30.olMQlwrxmw(1662), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		ON0JW0uR1 = true;
	}
}
