using System;
using System.IO;
using GIToolkit.Services;
using Lmttrs0IQc7UR7Zpt6;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Services;

public class LauncherConstant
{
	public static class Graph
	{
		public static string Tenant => aL07ImwcwlxdnyfI30.olMQlwrxmw(19350);

		public static string ClientId => aL07ImwcwlxdnyfI30.olMQlwrxmw(19426);

		public static string ClientSecret => aL07ImwcwlxdnyfI30.olMQlwrxmw(19502);
	}

	public static class IDRA
	{
		public static string GICTSSettingsFilename => aL07ImwcwlxdnyfI30.olMQlwrxmw(19586);

		public static string GICTSSettingsFilePath => Path.Combine(GICTSDataFolder, GICTSSettingsFilename);

		public static string GICTSDataFolder => GIConstant.SSCProgramDataPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(19610);

		public static string UseGsProPropName => aL07ImwcwlxdnyfI30.olMQlwrxmw(19624);

		public static string UseE6ConnectPropName => aL07ImwcwlxdnyfI30.olMQlwrxmw(19644);
	}

	private static string j2m3NYAPHI;

	public static string AdminPin => aL07ImwcwlxdnyfI30.olMQlwrxmw(12334);

	public static string AdminEmployee => aL07ImwcwlxdnyfI30.olMQlwrxmw(12350);

	public static string ApplicationName => aL07ImwcwlxdnyfI30.olMQlwrxmw(12368);

	public static string OldZGISInvoiceSoftwareName => aL07ImwcwlxdnyfI30.olMQlwrxmw(12400);

	public static string ZGISRemoteInvoiceSoftwareName
	{
		get
		{
			if (!GIConstant.UsingSSCInstallPath)
			{
				return aL07ImwcwlxdnyfI30.olMQlwrxmw(12458);
			}
			return aL07ImwcwlxdnyfI30.olMQlwrxmw(12504);
		}
	}

	public static string LauncherLogDirectoryPath => GIConstant.SSCProgramDataPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(12536);

	public static string IDRAAutoCalibrationPath => Path.Combine(GIConstant.SSCInstallPath, aL07ImwcwlxdnyfI30.olMQlwrxmw(12582), aL07ImwcwlxdnyfI30.olMQlwrxmw(12628));

	public static string TeamViewerExePath => j2m3NYAPHI + aL07ImwcwlxdnyfI30.olMQlwrxmw(12678);

	public LauncherConstant()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
	}

	static LauncherConstant()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		j2m3NYAPHI = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
	}
}
