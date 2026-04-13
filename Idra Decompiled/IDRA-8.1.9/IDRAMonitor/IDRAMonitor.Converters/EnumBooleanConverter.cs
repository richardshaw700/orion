using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using jBnbmEXkwPOPpPQ9mC;

namespace IDRAMonitor.Converters;

public class EnumBooleanConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(parameter is string value2))
		{
			return DependencyProperty.UnsetValue;
		}
		if (!Enum.IsDefined(value.GetType(), value))
		{
			return DependencyProperty.UnsetValue;
		}
		return Enum.Parse(value.GetType(), value2).Equals(value);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(parameter is string value2))
		{
			return DependencyProperty.UnsetValue;
		}
		return Enum.Parse(targetType, value2);
	}

	public EnumBooleanConverter()
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		base._002Ector();
	}
}
