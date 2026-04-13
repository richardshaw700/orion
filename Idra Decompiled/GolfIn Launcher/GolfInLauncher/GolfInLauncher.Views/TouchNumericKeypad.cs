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
using Lmttrs0IQc7UR7Zpt6;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Views;

public class TouchNumericKeypad : UserControl, IComponentConnector
{
	public static readonly DependencyProperty TargetTextBoxProperty;

	public static readonly DependencyProperty IsOpenProperty;

	public static readonly DependencyProperty AllowDecimalProperty;

	public static readonly DependencyProperty MaxDigitCountProperty;

	internal TouchNumericKeypad Root;

	internal Popup PART_Popup;

	private bool HkmkdjUYE6;

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

	public int MaxDigitCount
	{
		get
		{
			return (int)((DependencyObject)this).GetValue(MaxDigitCountProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(MaxDigitCountProperty, (object)value);
		}
	}

	public TouchNumericKeypad()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		((UserControl)this)._002Ector();
		InitializeComponent();
	}

	private void T2Pkblfj3g(object P_0, RoutedEventArgs P_1)
	{
		if (TargetTextBox != null)
		{
			Button val = (Button)((P_0 is Button) ? P_0 : null);
			if (val != null && TargetTextBox.Text.Length < MaxDigitCount)
			{
				TextBox targetTextBox = TargetTextBox;
				targetTextBox.Text += ((ContentControl)val).Content;
				TargetTextBox.CaretIndex = TargetTextBox.Text.Length;
			}
		}
	}

	private void SiokVHIGFj(object P_0, RoutedEventArgs P_1)
	{
		if (AllowDecimal && TargetTextBox != null && !TargetTextBox.Text.Contains(aL07ImwcwlxdnyfI30.olMQlwrxmw(2680)))
		{
			TextBox targetTextBox = TargetTextBox;
			targetTextBox.Text += aL07ImwcwlxdnyfI30.olMQlwrxmw(2680);
			TargetTextBox.CaretIndex = TargetTextBox.Text.Length;
		}
	}

	private void Cjvkw7CUnI(object P_0, RoutedEventArgs P_1)
	{
		if (TargetTextBox != null && TargetTextBox.Text.Length > 0)
		{
			TextBox targetTextBox = TargetTextBox;
			string text = TargetTextBox.Text;
			targetTextBox.Text = text.Substring(0, text.Length - 1);
			TargetTextBox.CaretIndex = TargetTextBox.Text.Length;
		}
	}

	private void hO0k0tYoJr(object P_0, RoutedEventArgs P_1)
	{
		IsOpen = false;
	}

	private void Hp7kCQOehR(object P_0, MouseButtonEventArgs P_1)
	{
		object originalSource = ((RoutedEventArgs)P_1).OriginalSource;
		if (VisualTreeHelper.GetParent((DependencyObject)((originalSource is DependencyObject) ? originalSource : null)) is Popup)
		{
			((RoutedEventArgs)P_1).Handled = true;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	public void InitializeComponent()
	{
		if (!HkmkdjUYE6)
		{
			HkmkdjUYE6 = true;
			Uri uri = new Uri(aL07ImwcwlxdnyfI30.olMQlwrxmw(2686), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
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
			((UIElement)PART_Popup).PreviewMouseLeftButtonDown += new MouseButtonEventHandler(Hp7kCQOehR);
			break;
		case 3:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(T2Pkblfj3g);
			break;
		case 4:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(T2Pkblfj3g);
			break;
		case 5:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(T2Pkblfj3g);
			break;
		case 6:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(Cjvkw7CUnI);
			break;
		case 7:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(T2Pkblfj3g);
			break;
		case 8:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(T2Pkblfj3g);
			break;
		case 9:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(T2Pkblfj3g);
			break;
		case 10:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(T2Pkblfj3g);
			break;
		case 11:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(T2Pkblfj3g);
			break;
		case 12:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(T2Pkblfj3g);
			break;
		case 13:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(SiokVHIGFj);
			break;
		case 14:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(T2Pkblfj3g);
			break;
		case 15:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(hO0k0tYoJr);
			break;
		default:
			HkmkdjUYE6 = true;
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
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		TargetTextBoxProperty = DependencyProperty.Register(aL07ImwcwlxdnyfI30.olMQlwrxmw(2800), typeof(TextBox), typeof(TouchNumericKeypad), new PropertyMetadata((PropertyChangedCallback)null));
		IsOpenProperty = DependencyProperty.Register(aL07ImwcwlxdnyfI30.olMQlwrxmw(2830), typeof(bool), typeof(TouchNumericKeypad), new PropertyMetadata((object)false));
		AllowDecimalProperty = DependencyProperty.Register(aL07ImwcwlxdnyfI30.olMQlwrxmw(2846), typeof(bool), typeof(TouchNumericKeypad), new PropertyMetadata((object)true));
		MaxDigitCountProperty = DependencyProperty.Register(aL07ImwcwlxdnyfI30.olMQlwrxmw(2874), typeof(int), typeof(TouchNumericKeypad), new PropertyMetadata((object)4));
	}
}
