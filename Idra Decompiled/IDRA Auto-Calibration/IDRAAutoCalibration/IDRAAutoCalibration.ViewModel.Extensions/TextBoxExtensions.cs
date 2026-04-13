using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using IodKeMsDBY9RwTYmwo;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration.ViewModel.Extensions;

public static class TextBoxExtensions
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static TextChangedEventHandler qdfnvXABnb;
	}

	public static readonly DependencyProperty AutoScrollToEndProperty;

	public static bool GetAutoScrollToEnd(DependencyObject obj)
	{
		return (bool)obj.GetValue(AutoScrollToEndProperty);
	}

	public static void SetAutoScrollToEnd(DependencyObject obj, bool value)
	{
		obj.SetValue(AutoScrollToEndProperty, (object)value);
	}

	private static void JdrMooCfAx(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		TextBox val = (TextBox)(object)((P_0 is TextBox) ? P_0 : null);
		if (val == null)
		{
			return;
		}
		if ((bool)((DependencyPropertyChangedEventArgs)(ref P_1)).NewValue)
		{
			object obj = _003C_003EO.qdfnvXABnb;
			if (obj == null)
			{
				TextChangedEventHandler val2 = EkxMlM5q7I;
				_003C_003EO.qdfnvXABnb = val2;
				obj = (object)val2;
			}
			((TextBoxBase)val).TextChanged += (TextChangedEventHandler)obj;
		}
		else
		{
			object obj2 = _003C_003EO.qdfnvXABnb;
			if (obj2 == null)
			{
				TextChangedEventHandler val3 = EkxMlM5q7I;
				_003C_003EO.qdfnvXABnb = val3;
				obj2 = (object)val3;
			}
			((TextBoxBase)val).TextChanged -= (TextChangedEventHandler)obj2;
		}
	}

	private static void EkxMlM5q7I(object P_0, TextChangedEventArgs P_1)
	{
		TextBox val = (TextBox)((P_0 is TextBox) ? P_0 : null);
		if (val != null)
		{
			((TextBoxBase)val).ScrollToEnd();
		}
	}

	static TextBoxExtensions()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		AutoScrollToEndProperty = DependencyProperty.RegisterAttached(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3606), typeof(bool), typeof(TextBoxExtensions), new PropertyMetadata((object)false, new PropertyChangedCallback(JdrMooCfAx)));
	}
}
