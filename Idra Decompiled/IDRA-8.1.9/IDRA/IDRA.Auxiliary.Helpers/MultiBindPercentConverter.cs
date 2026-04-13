using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using GhU84wwqvI4UZ3pBfu;

namespace IDRA.Auxiliary.Helpers;

public class MultiBindPercentConverter : MarkupExtension, IMultiValueConverter
{
	private static MultiBindPercentConverter g5PCiJv0vr;

	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		if (values.Any((object v) => v == DependencyProperty.UnsetValue))
		{
			return DependencyProperty.UnsetValue;
		}
		return System.Convert.ToDouble(values[0]) * System.Convert.ToDouble(values[1]);
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new NotSupportedException();
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		return g5PCiJv0vr ?? (g5PCiJv0vr = new MultiBindPercentConverter());
	}

	public MultiBindPercentConverter()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		((MarkupExtension)this)._002Ector();
	}
}
