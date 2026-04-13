using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Markup;
using GhU84wwqvI4UZ3pBfu;
using IDRA.Internationalization;

namespace DwLdjx4F7c3sKnI5Io;

internal class FoNoiqgVpSOI5y7Dsq : MarkupExtension, IValueConverter
{
	private static FoNoiqgVpSOI5y7Dsq KuuCW89jWP;

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		if (P_0 == null)
		{
			return "";
		}
		P_0.GetType();
		if (P_0.GetType() == typeof(string))
		{
			string text = P_0.ToString();
			return Resources.ResourceManager.GetString(text) ?? text;
		}
		if (P_0.GetType() == typeof(ObservableCollection<string>))
		{
			return new ObservableCollection<string>(((ObservableCollection<string>)P_0).Select((string s) => Resources.ResourceManager.GetString(s) ?? s));
		}
		return P_0;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public override object ProvideValue(IServiceProvider P_0)
	{
		return KuuCW89jWP ?? (KuuCW89jWP = new FoNoiqgVpSOI5y7Dsq());
	}

	public FoNoiqgVpSOI5y7Dsq()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		((MarkupExtension)this)._002Ector();
	}
}
