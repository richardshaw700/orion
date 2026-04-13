using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Data;
using Lmttrs0IQc7UR7Zpt6;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Internationalization;

public class CultureResources
{
	private static bool MSYsO0AneN;

	private static readonly List<CultureInfo> fYss9X0LUT;

	private static ObjectDataProvider eHGsANixZc;

	public static ObjectDataProvider ResourceProvider
	{
		get
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			object obj = eHGsANixZc;
			if (obj == null)
			{
				ObjectDataProvider val = (ObjectDataProvider)Application.Current.FindResource((object)aL07ImwcwlxdnyfI30.olMQlwrxmw(15068));
				eHGsANixZc = val;
				obj = (object)val;
			}
			return (ObjectDataProvider)obj;
		}
	}

	public CultureResources()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
		GetAvailableCultures();
	}

	public void GetAvailableCultures()
	{
		if (MSYsO0AneN)
		{
			return;
		}
		string[] directories = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory);
		foreach (string text in directories)
		{
			try
			{
				if (!text.Contains(aL07ImwcwlxdnyfI30.olMQlwrxmw(15042)))
				{
					CultureInfo cultureInfo = CultureInfo.GetCultureInfo(new DirectoryInfo(text).Name);
					fYss9X0LUT.Add(cultureInfo);
				}
			}
			catch (ArgumentException)
			{
			}
		}
		MSYsO0AneN = true;
	}

	public Resources GetResourceInstance()
	{
		return new Resources();
	}

	public void ChangeCulture(CultureInfo culture)
	{
		if (fYss9X0LUT.Contains(culture))
		{
			Resources.Culture = culture;
			((DataSourceProvider)ResourceProvider).Refresh();
		}
		else
		{
			Resources.Culture = new CultureInfo(aL07ImwcwlxdnyfI30.olMQlwrxmw(15090));
			((DataSourceProvider)ResourceProvider).Refresh();
		}
	}

	public void SetDefaultCulture()
	{
		Resources.Culture = new CultureInfo(aL07ImwcwlxdnyfI30.olMQlwrxmw(15090));
		((DataSourceProvider)ResourceProvider).Refresh();
	}

	public static string GetValue(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException();
		}
		return Resources.ResourceManager.GetString(key, Resources.Culture);
	}

	public void SetCulture(CultureInfo cultureInfo)
	{
		CultureInfo culture = new CultureInfo(cultureInfo.Name.Substring(0, 2));
		ChangeCulture(culture);
		Thread.CurrentThread.CurrentCulture = cultureInfo;
		Thread.CurrentThread.CurrentUICulture = cultureInfo;
	}

	static CultureResources()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		fYss9X0LUT = new List<CultureInfo>();
	}
}
