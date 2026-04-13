using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using jBnbmEXkwPOPpPQ9mC;

namespace IDRAMonitor.Auxiliary.Helpers;

public class InverseBooleanConverter : MarkupExtension, IValueConverter
{
	private static InverseBooleanConverter pZKGWTmaqm;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return !(bool)value;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return parameter;
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		return pZKGWTmaqm ?? (pZKGWTmaqm = new InverseBooleanConverter());
	}

	public InverseBooleanConverter()
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		((MarkupExtension)this)._002Ector();
	}
}
