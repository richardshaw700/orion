using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;
using GhU84wwqvI4UZ3pBfu;
using sxB8TYTZ87aKuujytY;

namespace IDRA.Views;

public class PostShotHistoryView : UserControl, IComponentConnector
{
	private static readonly SolidColorBrush Ox32u990S;

	internal ItemsControl ICPlayerNames;

	internal DataGrid HistoryDataGrid;

	private bool rjWyIoATM;

	public PostShotHistoryView()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		((UserControl)this)._002Ector();
		InitializeComponent();
	}

	private void bMUkH6c0v(object P_0, DataGridRowEventArgs P_1)
	{
		if (P_1.Row != null && ((CollectionView)((ItemsControl)HistoryDataGrid).Items).IndexOf(P_1.Row.Item) == 0)
		{
			((Control)P_1.Row).Background = (Brush)(object)Ox32u990S;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	public void InitializeComponent()
	{
		if (!rjWyIoATM)
		{
			rjWyIoATM = true;
			Uri uri = new Uri(QQXBLjLprwI58ya4VR.y8v8TMFOCb(1582), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			ICPlayerNames = (ItemsControl)target;
			break;
		case 2:
			HistoryDataGrid = (DataGrid)target;
			HistoryDataGrid.LoadingRow += bMUkH6c0v;
			break;
		default:
			rjWyIoATM = true;
			break;
		}
	}

	static PostShotHistoryView()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		Ox32u990S = new SolidColorBrush(Color.FromRgb((byte)217, (byte)63, (byte)6));
	}
}
