using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using jBnbmEXkwPOPpPQ9mC;

namespace IDRAMonitor.Converters;

public class IntComparaisonConverter : MarkupExtension, IValueConverter
{
	private static IntComparaisonConverter lD3F6fk6No;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null || parameter == null)
		{
			return false;
		}
		if (int.TryParse(value.ToString(), out var result) && int.TryParse(parameter.ToString(), out var result2))
		{
			return result == result2;
		}
		return false;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return parameter;
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		return lD3F6fk6No ?? (lD3F6fk6No = new IntComparaisonConverter());
	}

	public IntComparaisonConverter()
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		((MarkupExtension)this)._002Ector();
	}
}
