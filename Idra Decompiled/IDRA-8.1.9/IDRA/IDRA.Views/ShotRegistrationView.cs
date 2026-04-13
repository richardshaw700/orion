using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using GhU84wwqvI4UZ3pBfu;
using sxB8TYTZ87aKuujytY;

namespace IDRA.Views;

public class ShotRegistrationView : UserControl, IComponentConnector
{
	internal TextBox firstTxtInput;

	private bool yXotuFuxB;

	public ShotRegistrationView()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		((UserControl)this)._002Ector();
		InitializeComponent();
		((FrameworkElement)this).Loaded += new RoutedEventHandler(nve4qmm48);
	}

	private void nve4qmm48(object P_0, RoutedEventArgs P_1)
	{
		((UIElement)firstTxtInput).Focus();
		((TextBoxBase)firstTxtInput).SelectAll();
		Application.Current.MainWindow.Activate();
	}

	private void xYD3IioFO(object P_0, KeyEventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		if ((int)P_1.Key == 6)
		{
			object obj = ((P_0 is TextBox) ? P_0 : null);
			BindingExpression obj2 = ((obj != null) ? ((FrameworkElement)obj).GetBindingExpression(TextBox.TextProperty) : null);
			if (obj2 != null)
			{
				((BindingExpressionBase)obj2).UpdateSource();
			}
		}
		if ((int)P_1.Key == 3)
		{
			((RoutedEventArgs)P_1).Handled = true;
			IInputElement focusedElement = Keyboard.FocusedElement;
			IInputElement obj3 = ((focusedElement is UIElement) ? focusedElement : null);
			if (obj3 != null)
			{
				((UIElement)obj3).MoveFocus(new TraversalRequest((FocusNavigationDirection)0));
			}
			IInputElement focusedElement2 = Keyboard.FocusedElement;
			TextBox val = (TextBox)(object)((focusedElement2 is TextBox) ? focusedElement2 : null);
			if (val != null)
			{
				((UIElement)val).Focus();
				((TextBoxBase)val).SelectAll();
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	public void InitializeComponent()
	{
		if (!yXotuFuxB)
		{
			yXotuFuxB = true;
			Uri uri = new Uri(QQXBLjLprwI58ya4VR.y8v8TMFOCb(1860), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			firstTxtInput = (TextBox)target;
			((UIElement)firstTxtInput).PreviewKeyDown += new KeyEventHandler(xYD3IioFO);
			break;
		case 2:
			((UIElement)(TextBox)target).PreviewKeyDown += new KeyEventHandler(xYD3IioFO);
			break;
		case 3:
			((UIElement)(TextBox)target).PreviewKeyDown += new KeyEventHandler(xYD3IioFO);
			break;
		case 4:
			((UIElement)(TextBox)target).PreviewKeyDown += new KeyEventHandler(xYD3IioFO);
			break;
		case 5:
			((UIElement)(TextBox)target).PreviewKeyDown += new KeyEventHandler(xYD3IioFO);
			break;
		case 6:
			((UIElement)(TextBox)target).PreviewKeyDown += new KeyEventHandler(xYD3IioFO);
			break;
		case 7:
			((UIElement)(TextBox)target).PreviewKeyDown += new KeyEventHandler(xYD3IioFO);
			break;
		case 8:
			((UIElement)(TextBox)target).PreviewKeyDown += new KeyEventHandler(xYD3IioFO);
			break;
		case 9:
			((UIElement)(TextBox)target).PreviewKeyDown += new KeyEventHandler(xYD3IioFO);
			break;
		default:
			yXotuFuxB = true;
			break;
		}
	}
}
