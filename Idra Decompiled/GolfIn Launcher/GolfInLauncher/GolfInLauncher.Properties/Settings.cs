using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Lmttrs0IQc7UR7Zpt6;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.14.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance;

	public static Settings Default => defaultInstance;

	[DebuggerNonUserCode]
	[DefaultSettingValue("en-US")]
	[UserScopedSetting]
	public string EnglishCulture
	{
		get
		{
			return (string)((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(14802)];
		}
		set
		{
			((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(14802)] = value;
		}
	}

	[DefaultSettingValue("fr-CA")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string FrenchCulture
	{
		get
		{
			return (string)((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(14834)];
		}
		set
		{
			((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(14834)] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("en-US")]
	[DebuggerNonUserCode]
	public string AssignedCulture
	{
		get
		{
			return (string)((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(494)];
		}
		set
		{
			((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(494)] = value;
		}
	}

	[DefaultSettingValue("Residential")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string BusinessType
	{
		get
		{
			return (string)((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(528)];
		}
		set
		{
			((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(528)] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string CustomerPin
	{
		get
		{
			return (string)((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(556)];
		}
		set
		{
			((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(556)] = value;
		}
	}

	[DefaultSettingValue("False")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool ShowRestartButton
	{
		get
		{
			return (bool)((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(14864)];
		}
		set
		{
			((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(14864)] = value;
		}
	}

	[DefaultSettingValue("10000")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int AutoClickTime
	{
		get
		{
			return (int)((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(14902)];
		}
		set
		{
			((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(14902)] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int LaunchOptions
	{
		get
		{
			return (int)((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(646)];
		}
		set
		{
			((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(646)] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	public string UseInvoiceSoftware
	{
		get
		{
			return (string)((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(14932)];
		}
		set
		{
			((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(14932)] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	public bool ShowCloseButton
	{
		get
		{
			return (bool)((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(14972)];
		}
		set
		{
			((SettingsBase)this)[aL07ImwcwlxdnyfI30.olMQlwrxmw(14972)] = value;
		}
	}

	public Settings()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		((ApplicationSettingsBase)this)._002Ector();
	}

	static Settings()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());
	}
}
