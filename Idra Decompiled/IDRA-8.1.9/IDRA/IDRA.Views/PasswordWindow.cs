using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using GhU84wwqvI4UZ3pBfu;
using sxB8TYTZ87aKuujytY;

namespace IDRA.Views;

public class PasswordWindow : UserControl, IComponentConnector
{
	internal Button btn_7;

	internal Button btn_8;

	internal Button btn_9;

	internal Button btn_4;

	internal Button btn_5;

	internal Button btn_6;

	internal Button btn_1;

	internal Button btn_2;

	internal Button btn_3;

	internal Button btn_0;

	internal PasswordBox txtInput;

	internal Button btn_enter;

	private bool BTXcEACeF;

	public PasswordWindow()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		((UserControl)this)._002Ector();
		InitializeComponent();
		((FrameworkElement)this).Loaded += new RoutedEventHandler(nHaPh4voc);
	}

	private void nHaPh4voc(object P_0, RoutedEventArgs P_1)
	{
		Keyboard.Focus((IInputElement)(object)txtInput);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	public void InitializeComponent()
	{
		if (!BTXcEACeF)
		{
			BTXcEACeF = true;
			Uri uri = new Uri(QQXBLjLprwI58ya4VR.y8v8TMFOCb(1332), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			btn_7 = (Button)target;
			break;
		case 2:
			btn_8 = (Button)target;
			break;
		case 3:
			btn_9 = (Button)target;
			break;
		case 4:
			btn_4 = (Button)target;
			break;
		case 5:
			btn_5 = (Button)target;
			break;
		case 6:
			btn_6 = (Button)target;
			break;
		case 7:
			btn_1 = (Button)target;
			break;
		case 8:
			btn_2 = (Button)target;
			break;
		case 9:
			btn_3 = (Button)target;
			break;
		case 10:
			btn_0 = (Button)target;
			break;
		case 11:
			txtInput = (PasswordBox)target;
			break;
		case 12:
			btn_enter = (Button)target;
			break;
		default:
			BTXcEACeF = true;
			break;
		}
	}
}
