using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using hkpxmGISLhTJrZLcmi;
using jBnbmEXkwPOPpPQ9mC;

namespace IDRAMonitor.Views;

public class ShotAnalyzerSettingsMenu : UserControl, IComponentConnector
{
	internal CheckBox CbContinueTimer;

	private bool bRvBdpwOF;

	public ShotAnalyzerSettingsMenu()
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		((UserControl)this)._002Ector();
		InitializeComponent();
	}

	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!bRvBdpwOF)
		{
			bRvBdpwOF = true;
			Uri uri = new Uri(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(1636), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		if (connectionId == 1)
		{
			CbContinueTimer = (CheckBox)target;
		}
		else
		{
			bRvBdpwOF = true;
		}
	}
}
