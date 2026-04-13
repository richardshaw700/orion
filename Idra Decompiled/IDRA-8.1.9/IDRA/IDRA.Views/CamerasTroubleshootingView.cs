using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using GhU84wwqvI4UZ3pBfu;
using sxB8TYTZ87aKuujytY;

namespace IDRA.Views;

public class CamerasTroubleshootingView : UserControl, IComponentConnector
{
	internal Button btn_language;

	private bool ua8FPc1hU;

	public CamerasTroubleshootingView()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		((UserControl)this)._002Ector();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	public void InitializeComponent()
	{
		if (!ua8FPc1hU)
		{
			ua8FPc1hU = true;
			Uri uri = new Uri(QQXBLjLprwI58ya4VR.y8v8TMFOCb(698), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		if (connectionId == 1)
		{
			btn_language = (Button)target;
		}
		else
		{
			ua8FPc1hU = true;
		}
	}
}
