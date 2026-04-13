using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using GhU84wwqvI4UZ3pBfu;

namespace JPlIXEkjrV91nwOeqs;

internal class qbM57nlU68gGsK0oo0 : MarkupExtension, IValueConverter
{
	private static qbM57nlU68gGsK0oo0 aSgCngrtCJ;

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		return System.Convert.ToDouble(P_2, CultureInfo.InvariantCulture) * System.Convert.ToDouble(P_0, CultureInfo.InvariantCulture);
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public override object ProvideValue(IServiceProvider P_0)
	{
		return aSgCngrtCJ ?? (aSgCngrtCJ = new qbM57nlU68gGsK0oo0());
	}

	public qbM57nlU68gGsK0oo0()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		((MarkupExtension)this)._002Ector();
	}
}
