using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Data;
using GhU84wwqvI4UZ3pBfu;
using sxB8TYTZ87aKuujytY;

namespace IDRA.Internationalization;

public class CultureResources
{
	private static bool BGDCAKntky;

	private static readonly List<CultureInfo> V6JCZmMoBW;

	private static ObjectDataProvider cSRClODn7N;

	public static ObjectDataProvider ResourceProvider
	{
		get
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			object obj = cSRClODn7N;
			if (obj == null)
			{
				ObjectDataProvider val = (ObjectDataProvider)Application.Current.FindResource((object)QQXBLjLprwI58ya4VR.y8v8TMFOCb(10008));
				cSRClODn7N = val;
				obj = (object)val;
			}
			return (ObjectDataProvider)obj;
		}
	}

	public CultureResources()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		base._002Ector();
		GetAvailableCultures();
	}

	public void GetAvailableCultures()
	{
		if (BGDCAKntky)
		{
			return;
		}
		string[] directories = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory);
		foreach (string text in directories)
		{
			try
			{
				if (!text.Contains(QQXBLjLprwI58ya4VR.y8v8TMFOCb(9982)))
				{
					CultureInfo cultureInfo = CultureInfo.GetCultureInfo(new DirectoryInfo(text).Name);
					V6JCZmMoBW.Add(cultureInfo);
				}
			}
			catch (ArgumentException)
			{
			}
		}
		BGDCAKntky = true;
	}

	public Resources GetResourceInstance()
	{
		return new Resources();
	}

	public void ChangeCulture(CultureInfo culture)
	{
		if (V6JCZmMoBW.Contains(culture))
		{
			Resources.Culture = culture;
			((DataSourceProvider)ResourceProvider).Refresh();
		}
		else
		{
			Resources.Culture = new CultureInfo(QQXBLjLprwI58ya4VR.y8v8TMFOCb(10030));
			((DataSourceProvider)ResourceProvider).Refresh();
		}
	}

	public void SetDefaultCulture()
	{
		Resources.Culture = new CultureInfo(QQXBLjLprwI58ya4VR.y8v8TMFOCb(10030));
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

	public CultureInfo GetCurrentCulture()
	{
		return Resources.Culture;
	}

	static CultureResources()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		V6JCZmMoBW = new List<CultureInfo>();
	}
}
