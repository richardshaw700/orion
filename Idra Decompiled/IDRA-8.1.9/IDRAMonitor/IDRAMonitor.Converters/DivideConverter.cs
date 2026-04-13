using System;
using System.Globalization;
using System.Windows.Data;
using jBnbmEXkwPOPpPQ9mC;

namespace IDRAMonitor.Converters;

public class DivideConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null)
		{
			return 0;
		}
		if (parameter == null)
		{
			parameter = 1;
		}
		if (double.TryParse(value.ToString(), out var result) && double.TryParse(parameter.ToString(), out var result2))
		{
			return (result2 == 0.0) ? result : (result / result2);
		}
		return 0;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotSupportedException();
	}

	public DivideConverter()
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		base._002Ector();
	}
}
