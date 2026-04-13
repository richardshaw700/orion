using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Threading;
using IDRAAutoCalibration.Controls;
using IodKeMsDBY9RwTYmwo;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration;

public class SettingsWindow : Window, IComponentConnector
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public Button EoGn6Yeuqh;

		public DispatcherTimer J5UnHpEwnW;

		public _003C_003Ec__DisplayClass4_0()
		{
			edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
			base._002Ector();
		}

		internal void tAInONXDrW(object? _, EventArgs __)
		{
			((ContentControl)EoGn6Yeuqh).Content = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(14778);
			J5UnHpEwnW.Stop();
		}
	}

	private readonly TouchNumericKeypad pKnMUk6yhK;

	internal TextBox txtGain;

	internal TextBox txtExposure;

	internal TextBox txtMasterCameraID;

	internal TextBox txtSlaveCameraID;

	internal TouchNumericKeypad Keypad;

	private bool i5EMhTXbbQ;

	public SettingsWindow()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		((Window)this)._002Ector();
		InitializeComponent();
		pKnMUk6yhK = ((FrameworkElement)this).FindName(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3166)) as TouchNumericKeypad;
	}

	private void YoxMR0RI8h(object P_0, RoutedEventArgs P_1)
	{
		TextBox val = (TextBox)((P_0 is TextBox) ? P_0 : null);
		if (val != null)
		{
			pKnMUk6yhK.TargetTextBox = val;
			pKnMUk6yhK.IsOpen = true;
			((TextBoxBase)val).SelectAll();
		}
	}

	protected override void OnDeactivated(EventArgs e)
	{
		((Window)this).OnDeactivated(e);
		pKnMUk6yhK.IsOpen = false;
	}

	private void MnUMv9AmOV(object P_0, RoutedEventArgs P_1)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals9 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals9.EoGn6Yeuqh = (Button)((P_0 is Button) ? P_0 : null);
		if (CS_0024_003C_003E8__locals9.EoGn6Yeuqh == null)
		{
			return;
		}
		object tag = ((FrameworkElement)CS_0024_003C_003E8__locals9.EoGn6Yeuqh).Tag;
		TextBox val = (TextBox)((tag is TextBox) ? tag : null);
		if (val == null)
		{
			return;
		}
		string text = val.Text ?? string.Empty;
		if (text.Length != 0)
		{
			Clipboard.SetText(text);
			((ContentControl)CS_0024_003C_003E8__locals9.EoGn6Yeuqh).Content = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3182);
			CS_0024_003C_003E8__locals9.J5UnHpEwnW = new DispatcherTimer
			{
				Interval = TimeSpan.FromSeconds(1.0)
			};
			CS_0024_003C_003E8__locals9.J5UnHpEwnW.Tick += delegate
			{
				((ContentControl)CS_0024_003C_003E8__locals9.EoGn6Yeuqh).Content = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(14778);
				CS_0024_003C_003E8__locals9.J5UnHpEwnW.Stop();
			};
			CS_0024_003C_003E8__locals9.J5UnHpEwnW.Start();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "8.0.24.0")]
	public void InitializeComponent()
	{
		if (!i5EMhTXbbQ)
		{
			i5EMhTXbbQ = true;
			Uri uri = new Uri(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3200), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "8.0.24.0")]
	internal Delegate OZiM9ESvFo(Type P_0, string P_1)
	{
		return Delegate.CreateDelegate(P_0, this, P_1);
	}

	[GeneratedCode("PresentationBuildTasks", "8.0.24.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			txtGain = (TextBox)target;
			((UIElement)txtGain).GotFocus += new RoutedEventHandler(YoxMR0RI8h);
			break;
		case 2:
			txtExposure = (TextBox)target;
			((UIElement)txtExposure).GotFocus += new RoutedEventHandler(YoxMR0RI8h);
			break;
		case 3:
			txtMasterCameraID = (TextBox)target;
			break;
		case 4:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(MnUMv9AmOV);
			break;
		case 5:
			txtSlaveCameraID = (TextBox)target;
			break;
		case 6:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(MnUMv9AmOV);
			break;
		case 7:
			Keypad = (TouchNumericKeypad)target;
			break;
		default:
			i5EMhTXbbQ = true;
			break;
		}
	}
}
