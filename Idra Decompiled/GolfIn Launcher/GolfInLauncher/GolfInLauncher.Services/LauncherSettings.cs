using System;
using System.Runtime.CompilerServices;
using GIToolkit.Services;
using GolfInLauncher.ViewModels;
using Lmttrs0IQc7UR7Zpt6;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Services;

[Serializable]
public class LauncherSettings : ILauncherSettings, IService
{
	[CompilerGenerated]
	private string bae3jMpXBN;

	[CompilerGenerated]
	private BusinessType uOs3m6nivx;

	[CompilerGenerated]
	private string wxJ3ItLV9A;

	[CompilerGenerated]
	private bool qrm3E82G6x;

	[CompilerGenerated]
	private LaunchOptions G3o3fn32g5;

	[CompilerGenerated]
	private bool CiV3lISIoF;

	public string EnglishCulture => aL07ImwcwlxdnyfI30.olMQlwrxmw(12790);

	public string FrenchCulture => aL07ImwcwlxdnyfI30.olMQlwrxmw(12804);

	public string AssignedCulture
	{
		[CompilerGenerated]
		get
		{
			return bae3jMpXBN;
		}
		[CompilerGenerated]
		set
		{
			bae3jMpXBN = value;
		}
	}

	public BusinessType BusinessType
	{
		[CompilerGenerated]
		get
		{
			return uOs3m6nivx;
		}
		[CompilerGenerated]
		set
		{
			uOs3m6nivx = value;
		}
	}

	public string CustomerPin
	{
		[CompilerGenerated]
		get
		{
			return wxJ3ItLV9A;
		}
		[CompilerGenerated]
		set
		{
			wxJ3ItLV9A = value;
		}
	}

	public bool StartLauncherOnComputerStartup
	{
		[CompilerGenerated]
		get
		{
			return qrm3E82G6x;
		}
		[CompilerGenerated]
		set
		{
			qrm3E82G6x = value;
		}
	}

	public LaunchOptions LaunchOptions
	{
		[CompilerGenerated]
		get
		{
			return G3o3fn32g5;
		}
		[CompilerGenerated]
		set
		{
			G3o3fn32g5 = value;
		}
	}

	public bool IsInAdminMode
	{
		[CompilerGenerated]
		get
		{
			return CiV3lISIoF;
		}
		[CompilerGenerated]
		set
		{
			CiV3lISIoF = value;
		}
	}

	public static string LauncherSettingsDataKey => aL07ImwcwlxdnyfI30.olMQlwrxmw(12818);

	public void SetDefaultSettings()
	{
		BusinessType = BusinessType.Residential;
		CustomerPin = string.Empty;
		StartLauncherOnComputerStartup = false;
		LaunchOptions = LaunchOptions.None;
	}

	public string GetAdminPassword()
	{
		return LauncherConstant.AdminPin;
	}

	public string GetAdminEmployeePassword()
	{
		return LauncherConstant.AdminEmployee;
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(97, 5);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(12874));
		defaultInterpolatedStringHandler.AppendFormatted(BusinessType);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(12906));
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(12916));
		defaultInterpolatedStringHandler.AppendFormatted(CustomerPin);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(12906));
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(12946));
		defaultInterpolatedStringHandler.AppendFormatted(StartLauncherOnComputerStartup);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(12906));
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(13018));
		defaultInterpolatedStringHandler.AppendFormatted(LaunchOptions);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(12906));
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(13052));
		defaultInterpolatedStringHandler.AppendFormatted(AssignedCulture);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public LauncherSettings()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		bae3jMpXBN = aL07ImwcwlxdnyfI30.olMQlwrxmw(12790);
		uOs3m6nivx = BusinessType.Residential;
		wxJ3ItLV9A = string.Empty;
		base._002Ector();
	}
}
