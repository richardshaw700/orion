using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using IodKeMsDBY9RwTYmwo;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration.Controls;

public class TouchNumericKeypad : UserControl, IComponentConnector
{
	public static readonly DependencyProperty TargetTextBoxProperty;

	public static readonly DependencyProperty IsOpenProperty;

	public static readonly DependencyProperty AllowDecimalProperty;

	internal TouchNumericKeypad Root;

	internal Popup PART_Popup;

	private bool lJ0MphSAxl;

	public TextBox TargetTextBox
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			return (TextBox)((DependencyObject)this).GetValue(TargetTextBoxProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(TargetTextBoxProperty, (object)value);
		}
	}

	public bool IsOpen
	{
		get
		{
			return (bool)((DependencyObject)this).GetValue(IsOpenProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(IsOpenProperty, (object)value);
		}
	}

	public bool AllowDecimal
	{
		get
		{
			return (bool)((DependencyObject)this).GetValue(AllowDecimalProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(AllowDecimalProperty, (object)value);
		}
	}

	public TouchNumericKeypad()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		((UserControl)this)._002Ector();
		InitializeComponent();
	}

	private void XmfMeA3F29(object P_0, RoutedEventArgs P_1)
	{
		if (TargetTextBox != null)
		{
			Button val = (Button)((P_0 is Button) ? P_0 : null);
			if (val != null)
			{
				TextBox targetTextBox = TargetTextBox;
				targetTextBox.Text += ((ContentControl)val).Content;
				TargetTextBox.CaretIndex = TargetTextBox.Text.Length;
			}
		}
	}

	private void KsVMmVUsHR(object P_0, RoutedEventArgs P_1)
	{
		if (AllowDecimal && TargetTextBox != null && !TargetTextBox.Text.Contains(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3302)))
		{
			TextBox targetTextBox = TargetTextBox;
			targetTextBox.Text += xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3302);
			TargetTextBox.CaretIndex = TargetTextBox.Text.Length;
		}
	}

	private void mKrMuyGYi9(object P_0, RoutedEventArgs P_1)
	{
		if (TargetTextBox != null && TargetTextBox.Text.Length > 0)
		{
			TextBox targetTextBox = TargetTextBox;
			string text = TargetTextBox.Text;
			targetTextBox.Text = text.Substring(0, text.Length - 1);
			TargetTextBox.CaretIndex = TargetTextBox.Text.Length;
		}
	}

	private void mqBM7yFu1Q(object P_0, RoutedEventArgs P_1)
	{
		IsOpen = false;
	}

	private void vPhM8AXC2R(object P_0, MouseButtonEventArgs P_1)
	{
		object originalSource = ((RoutedEventArgs)P_1).OriginalSource;
		if (VisualTreeHelper.GetParent((DependencyObject)((originalSource is DependencyObject) ? originalSource : null)) is Popup)
		{
			((RoutedEventArgs)P_1).Handled = true;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "8.0.24.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!lJ0MphSAxl)
		{
			lJ0MphSAxl = true;
			Uri uri = new Uri(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3308), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "8.0.24.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			Root = (TouchNumericKeypad)target;
			break;
		case 2:
			PART_Popup = (Popup)target;
			((UIElement)PART_Popup).PreviewMouseLeftButtonDown += new MouseButtonEventHandler(vPhM8AXC2R);
			break;
		case 3:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(XmfMeA3F29);
			break;
		case 4:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(XmfMeA3F29);
			break;
		case 5:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(XmfMeA3F29);
			break;
		case 6:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(mKrMuyGYi9);
			break;
		case 7:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(XmfMeA3F29);
			break;
		case 8:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(XmfMeA3F29);
			break;
		case 9:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(XmfMeA3F29);
			break;
		case 10:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(XmfMeA3F29);
			break;
		case 11:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(XmfMeA3F29);
			break;
		case 12:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(XmfMeA3F29);
			break;
		case 13:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(KsVMmVUsHR);
			break;
		case 14:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(XmfMeA3F29);
			break;
		case 15:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(mqBM7yFu1Q);
			break;
		default:
			lJ0MphSAxl = true;
			break;
		}
	}

	static TouchNumericKeypad()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		TargetTextBoxProperty = DependencyProperty.Register(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3430), typeof(TextBox), typeof(TouchNumericKeypad), new PropertyMetadata((PropertyChangedCallback)null));
		IsOpenProperty = DependencyProperty.Register(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3460), typeof(bool), typeof(TouchNumericKeypad), new PropertyMetadata((object)false));
		AllowDecimalProperty = DependencyProperty.Register(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3476), typeof(bool), typeof(TouchNumericKeypad), new PropertyMetadata((object)true));
	}
}
