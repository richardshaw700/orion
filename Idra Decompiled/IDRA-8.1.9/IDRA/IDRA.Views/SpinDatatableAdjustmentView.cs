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

public class SpinDatatableAdjustmentView : UserControl, IComponentConnector
{
	internal DataGrid SpinDataTable;

	private bool hkyjnCxFL;

	public SpinDatatableAdjustmentView()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		((UserControl)this)._002Ector();
		InitializeComponent();
	}

	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!hkyjnCxFL)
		{
			hkyjnCxFL = true;
			Uri uri = new Uri(QQXBLjLprwI58ya4VR.y8v8TMFOCb(1982), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		if (connectionId == 1)
		{
			SpinDataTable = (DataGrid)target;
		}
		else
		{
			hkyjnCxFL = true;
		}
	}
}
