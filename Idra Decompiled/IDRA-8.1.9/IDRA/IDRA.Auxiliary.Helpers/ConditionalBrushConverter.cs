using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using GhU84wwqvI4UZ3pBfu;

namespace IDRA.Auxiliary.Helpers;

public class ConditionalBrushConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		bool flag = (bool)value;
		string[] array = parameter.ToString()?.Split(',');
		if (array == null || array.Length != 2)
		{
			return null;
		}
		if (flag)
		{
			return (object)new SolidColorBrush((Color)ColorConverter.ConvertFromString(array[0]));
		}
		return (object)new SolidColorBrush((Color)ColorConverter.ConvertFromString(array[1]));
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public ConditionalBrushConverter()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		base._002Ector();
	}
}
