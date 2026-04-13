using System;
using System.Globalization;
using System.Windows.Data;

namespace SoftwareUpgradeLoadingScreen;

public sealed class ProgressWidthConverter : IMultiValueConverter
{
	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		if (values == null || values.Length < 2)
		{
			return 0.0;
		}
		if (!(values[0] is double val))
		{
			return 0.0;
		}
		if (!(values[1] is double val2))
		{
			return 0.0;
		}
		double num = Math.Max(0.0, Math.Min(100.0, val2));
		return Math.Max(0.0, val) * (num / 100.0);
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new NotSupportedException();
	}
}
