using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.Messaging;
using IDRAMonitor.Auxiliary.Messages;
using MahApps.Metro.Controls;
using hkpxmGISLhTJrZLcmi;
using jBnbmEXkwPOPpPQ9mC;
using r8FF027V5kft9n1ATY;

namespace IDRAMonitor.Views;

public class ContainerView : MetroWindow, IComponentConnector
{
	private bool mM1K2FOIk;

	public ContainerView()
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		base._002Ector();
		InitializeComponent();
		WeakReferenceMessenger.Default.Register<CloseApplicationMessage>(this, UJscltkQH);
	}

	private void UJscltkQH(object P_0, CloseApplicationMessage P_1)
	{
		Jged61jttKo6ryRwn0.OF07ad7VOo();
		if (P_1.ExitCode != 100)
		{
			return;
		}
		if (Application.Current == null)
		{
			Environment.Exit(0);
			return;
		}
		Application current = Application.Current;
		if (current == null)
		{
			return;
		}
		Dispatcher dispatcher = ((DispatcherObject)current).Dispatcher;
		if (dispatcher != null)
		{
			dispatcher.Invoke((Action)delegate
			{
				((Window)this).Close();
			});
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	public void InitializeComponent()
	{
		if (!mM1K2FOIk)
		{
			mM1K2FOIk = true;
			Uri uri = new Uri(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(812), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		mM1K2FOIk = true;
	}

	[CompilerGenerated]
	private void BXEX2vAnw()
	{
		((Window)this).Close();
	}
}
