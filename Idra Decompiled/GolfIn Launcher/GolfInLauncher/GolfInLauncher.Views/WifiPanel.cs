using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Lmttrs0IQc7UR7Zpt6;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Views;

public class WifiPanel : UserControl, IComponentConnector
{
	internal PasswordBox txtInput;

	private bool NBHkyRm4I5;

	public WifiPanel()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		((UserControl)this)._002Ector();
		InitializeComponent();
	}

	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!NBHkyRm4I5)
		{
			NBHkyRm4I5 = true;
			Uri uri = new Uri(aL07ImwcwlxdnyfI30.olMQlwrxmw(2904), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		if (connectionId == 1)
		{
			txtInput = (PasswordBox)target;
		}
		else
		{
			NBHkyRm4I5 = true;
		}
	}
}
