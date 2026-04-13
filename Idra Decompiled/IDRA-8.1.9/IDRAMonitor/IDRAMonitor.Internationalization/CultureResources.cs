using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Data;
using hkpxmGISLhTJrZLcmi;
using jBnbmEXkwPOPpPQ9mC;

namespace IDRAMonitor.Internationalization;

public class CultureResources
{
	private static bool ldVFfOflbe;

	private static readonly List<CultureInfo> MipFMRq64p;

	private static ObjectDataProvider lilFDcPXyJ;

	public static ObjectDataProvider ResourceProvider
	{
		get
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			object obj = lilFDcPXyJ;
			if (obj == null)
			{
				ObjectDataProvider val = (ObjectDataProvider)Application.Current.FindResource((object)ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6016));
				lilFDcPXyJ = val;
				obj = (object)val;
			}
			return (ObjectDataProvider)obj;
		}
	}

	public CultureResources()
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		base._002Ector();
		GetAvailableCultures();
	}

	public void GetAvailableCultures()
	{
		if (ldVFfOflbe)
		{
			return;
		}
		string[] directories = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory);
		foreach (string text in directories)
		{
			try
			{
				if (!text.Contains(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5990)))
				{
					CultureInfo cultureInfo = CultureInfo.GetCultureInfo(new DirectoryInfo(text).Name);
					MipFMRq64p.Add(cultureInfo);
				}
			}
			catch (ArgumentException)
			{
			}
		}
		ldVFfOflbe = true;
	}

	public Resources GetResourceInstance()
	{
		return new Resources();
	}

	public void ChangeCulture(CultureInfo culture)
	{
		if (MipFMRq64p.Contains(culture))
		{
			Resources.Culture = culture;
			((DataSourceProvider)ResourceProvider).Refresh();
		}
		else
		{
			Resources.Culture = new CultureInfo(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6038));
			((DataSourceProvider)ResourceProvider).Refresh();
		}
	}

	public void SetDefaultCulture()
	{
		Resources.Culture = new CultureInfo(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6038));
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
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		MipFMRq64p = new List<CultureInfo>();
	}
}
