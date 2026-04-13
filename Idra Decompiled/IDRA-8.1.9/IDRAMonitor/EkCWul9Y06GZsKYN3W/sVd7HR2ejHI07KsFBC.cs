using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using jBnbmEXkwPOPpPQ9mC;

namespace EkCWul9Y06GZsKYN3W;

internal class sVd7HR2ejHI07KsFBC : MarkupExtension, IValueConverter
{
	private static sVd7HR2ejHI07KsFBC bUoF565gWM;

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (!(P_0 is TimeSpan timeSpan))
		{
			if (P_0 is Duration val)
			{
				return ((Duration)(ref val)).HasTimeSpan ? ((Duration)(ref val)).TimeSpan.TotalSeconds : 0.0;
			}
			return 0.0;
		}
		return timeSpan.TotalSeconds;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (!(P_0 is double))
		{
			return 0.0;
		}
		TimeSpan timeSpan = TimeSpan.FromTicks(System.Convert.ToInt64(10000000.0 * (double)P_0));
		if (P_1 == typeof(TimeSpan))
		{
			return timeSpan;
		}
		if (!(P_1 == typeof(Duration)))
		{
			return Activator.CreateInstance(P_1);
		}
		return (object)new Duration(timeSpan);
	}

	public override object ProvideValue(IServiceProvider P_0)
	{
		return bUoF565gWM ?? (bUoF565gWM = new sVd7HR2ejHI07KsFBC());
	}

	public sVd7HR2ejHI07KsFBC()
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		((MarkupExtension)this)._002Ector();
	}
}
