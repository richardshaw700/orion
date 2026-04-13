using System;
using System.Windows;
using System.Windows.Controls;
using Lmttrs0IQc7UR7Zpt6;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Tools;

public static class WebBrowserUtility
{
	public static readonly DependencyProperty BindableSourceProperty;

	public static string GetBindableSource(DependencyObject obj)
	{
		return (string)obj.GetValue(BindableSourceProperty);
	}

	public static void SetBindableSource(DependencyObject obj, string value)
	{
		obj.SetValue(BindableSourceProperty, (object)value);
	}

	public static void BindableSourcePropertyChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
	{
		WebBrowser val = (WebBrowser)(object)((o is WebBrowser) ? o : null);
		if (val != null)
		{
			string text = ((DependencyPropertyChangedEventArgs)(ref e)).NewValue as string;
			val.Source = ((!string.IsNullOrEmpty(text)) ? new Uri(text) : null);
		}
	}

	static WebBrowserUtility()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		BindableSourceProperty = DependencyProperty.RegisterAttached(aL07ImwcwlxdnyfI30.olMQlwrxmw(6960), typeof(string), typeof(WebBrowserUtility), (PropertyMetadata)new UIPropertyMetadata((object)null, new PropertyChangedCallback(BindableSourcePropertyChanged)));
	}
}
