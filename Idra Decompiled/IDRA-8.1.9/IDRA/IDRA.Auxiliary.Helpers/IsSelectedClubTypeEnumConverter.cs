using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;
using GICTS.Data;
using GhU84wwqvI4UZ3pBfu;
using sxB8TYTZ87aKuujytY;

namespace IDRA.Auxiliary.Helpers;

public class IsSelectedClubTypeEnumConverter : MarkupExtension, IMultiValueConverter
{
	private static IsSelectedClubTypeEnumConverter SiqCSitv34;

	public object Convert(object[] value, Type targetType, object parameter, CultureInfo culture)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		if (value.Length == 2)
		{
			object obj = value[1];
			if (obj is ClubTypeEnum)
			{
				_ = (ClubTypeEnum)obj;
				if (!Enum.TryParse<ClubTypeEnum>(value[0] as string, out var _))
				{
					return (object)(SolidColorBrush)((TypeConverter)new BrushConverter()).ConvertFrom((object)QQXBLjLprwI58ya4VR.y8v8TMFOCb(12008));
				}
				return (object)(SolidColorBrush)((TypeConverter)new BrushConverter()).ConvertFrom((object)QQXBLjLprwI58ya4VR.y8v8TMFOCb(11990));
			}
		}
		return (object)(SolidColorBrush)((TypeConverter)new BrushConverter()).ConvertFrom((object)QQXBLjLprwI58ya4VR.y8v8TMFOCb(12008));
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		return SiqCSitv34 ?? (SiqCSitv34 = new IsSelectedClubTypeEnumConverter());
	}

	public IsSelectedClubTypeEnumConverter()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		((MarkupExtension)this)._002Ector();
	}
}
