using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SoftwareUpgradeLoadingScreen;

public sealed class InverseBooleanToVisibilityConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is bool)
		{
			return (object)(Visibility)(((bool)value) ? 2 : 0);
		}
		return (object)(Visibility)0;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		if (value is Visibility val)
		{
			return (int)val > 0;
		}
		return false;
	}
}
