using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;
using GhU84wwqvI4UZ3pBfu;
using sxB8TYTZ87aKuujytY;

namespace IDRA.Auxiliary.Helpers;

public class IsSelectedConverter : MarkupExtension, IMultiValueConverter
{
	private static IsSelectedConverter p7EChbrnGX;

	public object Convert(object[] value, Type targetType, object parameter, CultureInfo culture)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		if (value.Length == 2 && value[0] != null && value[0].Equals(value[1]))
		{
			return (object)(SolidColorBrush)((TypeConverter)new BrushConverter()).ConvertFrom((object)QQXBLjLprwI58ya4VR.y8v8TMFOCb(11990));
		}
		return (object)(SolidColorBrush)((TypeConverter)new BrushConverter()).ConvertFrom((object)QQXBLjLprwI58ya4VR.y8v8TMFOCb(12008));
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		return p7EChbrnGX ?? (p7EChbrnGX = new IsSelectedConverter());
	}

	public IsSelectedConverter()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		((MarkupExtension)this)._002Ector();
	}
}
