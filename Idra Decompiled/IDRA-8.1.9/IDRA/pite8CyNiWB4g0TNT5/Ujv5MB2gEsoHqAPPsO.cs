using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using GhU84wwqvI4UZ3pBfu;

namespace pite8CyNiWB4g0TNT5;

internal class Ujv5MB2gEsoHqAPPsO : MarkupExtension, IValueConverter
{
	private static Ujv5MB2gEsoHqAPPsO ESYCfY47nb;

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
		return ESYCfY47nb ?? (ESYCfY47nb = new Ujv5MB2gEsoHqAPPsO());
	}

	public Ujv5MB2gEsoHqAPPsO()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		((MarkupExtension)this)._002Ector();
	}
}
