using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using IodKeMsDBY9RwTYmwo;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration.ViewModel.Extensions;

public static class AutoScrollBehavior
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public TextBox utdnRnv7M4;

		public _003C_003Ec__DisplayClass3_0()
		{
			edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
			base._002Ector();
		}

		internal void xstnjfSdmn(object s, TextChangedEventArgs args)
		{
			((TextBoxBase)utdnRnv7M4).ScrollToEnd();
		}
	}

	public static readonly DependencyProperty AutoScrollProperty;

	public static bool GetAutoScroll(DependencyObject obj)
	{
		return (bool)obj.GetValue(AutoScrollProperty);
	}

	public static void SetAutoScroll(DependencyObject obj, bool value)
	{
		obj.SetValue(AutoScrollProperty, (object)value);
	}

	private static void IQVMw8H9Ef(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals4.utdnRnv7M4 = (TextBox)(object)((P_0 is TextBox) ? P_0 : null);
		if (CS_0024_003C_003E8__locals4.utdnRnv7M4 != null && (bool)((DependencyPropertyChangedEventArgs)(ref P_1)).NewValue)
		{
			((TextBoxBase)CS_0024_003C_003E8__locals4.utdnRnv7M4).TextChanged += (TextChangedEventHandler)delegate
			{
				((TextBoxBase)CS_0024_003C_003E8__locals4.utdnRnv7M4).ScrollToEnd();
			};
		}
	}

	static AutoScrollBehavior()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		AutoScrollProperty = DependencyProperty.RegisterAttached(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3582), typeof(bool), typeof(AutoScrollBehavior), new PropertyMetadata((object)false, new PropertyChangedCallback(IQVMw8H9Ef)));
	}
}
