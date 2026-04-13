using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml;
using GIToolkit.Services;
using GolfInLauncher.Services;
using GolfInLauncher.ViewModels;
using Lmttrs0IQc7UR7Zpt6;
using Services;
using U9xbeMdbyr6Pactctj;

namespace CPG4YAZ7RYgKaMMX22;

internal class oJVVwnGMHukYUoxD3w : IXmlSettingsRecoveryService, IService
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public List<FileInfo> vt9qNkudUa;

		public _003C_003Ec__DisplayClass3_0()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal void TQkqS3a8cU(string x)
		{
			vt9qNkudUa.Add(new FileInfo(x));
		}
	}

	private ILauncherSettings idnayfI30;

	private readonly ILocalCachingServices LmtutrsIQ;

	public oJVVwnGMHukYUoxD3w(ILocalCachingServices P_0, ILauncherSettings P_1)
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
		LmtutrsIQ = P_0;
		idnayfI30 = P_1;
	}

	public string FindSettingPath()
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass3_0();
		string[] files = Directory.GetFiles(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), LauncherConstant.ApplicationName), aL07ImwcwlxdnyfI30.olMQlwrxmw(418), SearchOption.AllDirectories);
		CS_0024_003C_003E8__locals3.vt9qNkudUa = new List<FileInfo>();
		files.ToList().ForEach(delegate(string x)
		{
			CS_0024_003C_003E8__locals3.vt9qNkudUa.Add(new FileInfo(x));
		});
		return CS_0024_003C_003E8__locals3.vt9qNkudUa.OrderByDescending((FileInfo x) => x.CreationTime)?.FirstOrDefault()?.FullName ?? string.Empty;
	}

	public void FetchLocalSettings()
	{
		string text = FindSettingPath();
		if (string.IsNullOrWhiteSpace(text))
		{
			idnayfI30.SetDefaultSettings();
			return;
		}
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes(aL07ImwcwlxdnyfI30.olMQlwrxmw(444));
		if (xmlNodeList == null || xmlNodeList.Count <= 0)
		{
			idnayfI30.SetDefaultSettings();
			return;
		}
		foreach (XmlNode item in xmlNodeList)
		{
			XmlNode xmlNode = item.SelectSingleNode(aL07ImwcwlxdnyfI30.olMQlwrxmw(466));
			XmlNode xmlNode2 = item.SelectSingleNode(aL07ImwcwlxdnyfI30.olMQlwrxmw(480));
			if (item == null || xmlNode2 == null || xmlNode == null)
			{
				continue;
			}
			string innerText = xmlNode2.InnerText;
			string value = xmlNode.Value;
			if (!(value == aL07ImwcwlxdnyfI30.olMQlwrxmw(494)))
			{
				if (!(value == aL07ImwcwlxdnyfI30.olMQlwrxmw(528)))
				{
					if (!(value == aL07ImwcwlxdnyfI30.olMQlwrxmw(556)))
					{
						if (!(value == aL07ImwcwlxdnyfI30.olMQlwrxmw(582)))
						{
							if (value == aL07ImwcwlxdnyfI30.olMQlwrxmw(646))
							{
								Enum.TryParse<LaunchOptions>(innerText, out var result);
								idnayfI30.LaunchOptions = result;
							}
						}
						else
						{
							bool.TryParse(innerText, out var result2);
							idnayfI30.StartLauncherOnComputerStartup = result2;
						}
					}
					else
					{
						idnayfI30.CustomerPin = innerText;
					}
				}
				else
				{
					Enum.TryParse<BusinessType>(innerText, out var result3);
					idnayfI30.BusinessType = result3;
				}
			}
			else
			{
				idnayfI30.AssignedCulture = innerText;
			}
		}
	}

	public async Task SaveLocalSettings()
	{
		_ = 1;
		try
		{
			if ((await LmtutrsIQ.GetAsync(LauncherSettings.LauncherSettingsDataKey))?.Data == null)
			{
				FetchLocalSettings();
				await LmtutrsIQ.CacheAsync(LauncherSettings.LauncherSettingsDataKey, idnayfI30 as LauncherSettings);
			}
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
		}
	}
}
