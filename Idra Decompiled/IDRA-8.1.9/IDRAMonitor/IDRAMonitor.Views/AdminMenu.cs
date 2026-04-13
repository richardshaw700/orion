using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using hkpxmGISLhTJrZLcmi;
using jBnbmEXkwPOPpPQ9mC;

namespace IDRAMonitor.Views;

public class AdminMenu : UserControl, IComponentConnector
{
	private bool x2RItLoAm;

	public AdminMenu()
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		((UserControl)this)._002Ector();
		InitializeComponent();
	}

	private void YKY1N3W9v(object P_0, KeyEventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (((int)P_1.Key == 6 && (Keyboard.Modifiers & 4) == 4) || (int)P_1.Key == 6)
		{
			TextBox val = (TextBox)P_0;
			int caretIndex = val.CaretIndex;
			val.Text = val.Text.Insert(caretIndex, Environment.NewLine);
			val.CaretIndex = caretIndex + Environment.NewLine.Length;
			((RoutedEventArgs)P_1).Handled = true;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	public void InitializeComponent()
	{
		if (!x2RItLoAm)
		{
			x2RItLoAm = true;
			Uri uri = new Uri(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(722), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		if (connectionId == 1)
		{
			((UIElement)(TextBox)target).KeyDown += new KeyEventHandler(YKY1N3W9v);
		}
		else
		{
			x2RItLoAm = true;
		}
	}
}
