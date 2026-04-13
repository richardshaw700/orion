using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using GhU84wwqvI4UZ3pBfu;
using MahApps.Metro.Controls;
using sxB8TYTZ87aKuujytY;

namespace IDRA.Views;

public class CustomShotView : MetroWindow, IComponentConnector
{
	private bool qUsO6uMeC;

	public CustomShotView()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		base._002Ector();
		InitializeComponent();
	}

	private void SOSJ0yPo6(object P_0, RoutedEventArgs P_1)
	{
		((Window)this).Close();
	}

	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!qUsO6uMeC)
		{
			qUsO6uMeC = true;
			Uri uri = new Uri(QQXBLjLprwI58ya4VR.y8v8TMFOCb(1120), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		if (connectionId == 1)
		{
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(SOSJ0yPo6);
		}
		else
		{
			qUsO6uMeC = true;
		}
	}
}
