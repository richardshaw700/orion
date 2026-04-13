using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GIToolkit.Services;
using GolfInLauncher.Internationalization;
using GolfInLauncher.Navigation;
using GolfInLauncher.Services;
using GolfInLauncher.Services.SoftwareUpdate;
using Lmttrs0IQc7UR7Zpt6;
using MahApps.Metro.Controls.Dialogs;
using SoftwareUpgradeLoadingScreen;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.ViewModels;

public class SoftwareUpdateViewModel : ObservableRecipient, IViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public UpdateInProgressWindow bwh5bi35vB;

		public _003C_003Ec__DisplayClass50_0()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal void Iut5eMcSBT(string line)
		{
			bwh5bi35vB.AppendDetailLine(line);
		}
	}

	private readonly INavigationService<ViewModelNavigationPages> uFwGULwimg;

	private readonly IDialogCoordinator eDNGt2NcqS;

	private readonly ICircularLogService syvGLiYdvO;

	private readonly ILauncherSettings BIGGRt9aDk;

	[CompilerGenerated]
	private readonly IRelayCommand SVdGnXMBNs;

	[CompilerGenerated]
	private readonly IRelayCommand<Software> kKSGgWodUR;

	[CompilerGenerated]
	private readonly IRelayCommand<Software> NvHGoqMVXm;

	[CompilerGenerated]
	private readonly IRelayCommand NJhGhZSwb0;

	private bool sPfGzksdD1;

	private bool JfEZppcQv3;

	private bool ueaZkWubBZ;

	private bool CMcZ81FQTW;

	public IRelayCommand WindowLoadCommand
	{
		[CompilerGenerated]
		get
		{
			return SVdGnXMBNs;
		}
	}

	public IRelayCommand<Software> UpdateSoftwareCommand
	{
		[CompilerGenerated]
		get
		{
			return kKSGgWodUR;
		}
	}

	public IRelayCommand<Software> UsePreviousVersionCommand
	{
		[CompilerGenerated]
		get
		{
			return NvHGoqMVXm;
		}
	}

	public IRelayCommand ExitWindowCommand
	{
		[CompilerGenerated]
		get
		{
			return NJhGhZSwb0;
		}
	}

	public string IDRAInstalledVersion => SoftwareVersionsService.GetActiveSoftwareVersionNumber(Software.IDRA);

	public string GolfInLauncherInstalledVersion => SoftwareVersionsService.GetActiveSoftwareVersionNumber(Software.GolfInLauncher);

	public string ZGISRemoteInstalledVersion => SoftwareVersionsService.GetActiveSoftwareVersionNumber(Software.ZGISRemote);

	public string IDRAAutoCalibrationInstalledVersion => SoftwareVersionsService.GetActiveSoftwareVersionNumber(Software.IDRAAutoCalibration);

	public bool HasIDRANewVersionAvailable
	{
		get
		{
			return sPfGzksdD1;
		}
		private set
		{
			SetProperty(ref sPfGzksdD1, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(5818));
		}
	}

	public bool HasGolfInLauncherNewVersionAvailable
	{
		get
		{
			return JfEZppcQv3;
		}
		private set
		{
			SetProperty(ref JfEZppcQv3, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(5874));
		}
	}

	public bool IsZGISRemoteActive => BIGGRt9aDk.LaunchOptions == LaunchOptions.UseRemoteInvoiceSoftware;

	public bool HasZGISRemoteNewVersionAvailable
	{
		get
		{
			return ueaZkWubBZ;
		}
		private set
		{
			SetProperty(ref ueaZkWubBZ, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(5950));
		}
	}

	public bool HasIDRAAutoCalibrationNewVersionAvailable
	{
		get
		{
			return CMcZ81FQTW;
		}
		private set
		{
			SetProperty(ref CMcZ81FQTW, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(6018));
		}
	}

	public int SoftwareGridColumns
	{
		get
		{
			if (!IsZGISRemoteActive)
			{
				return 1;
			}
			return 2;
		}
	}

	public int SoftwareGridRows
	{
		get
		{
			if (!IsZGISRemoteActive)
			{
				return 3;
			}
			return 2;
		}
	}

	public SoftwareUpdateViewModel(INavigationService<ViewModelNavigationPages> navigationService, IDialogCoordinator dialogCoordinator, ICircularLogService circularLogService, ILauncherSettings launcherSettings)
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
		uFwGULwimg = navigationService;
		eDNGt2NcqS = dialogCoordinator;
		syvGLiYdvO = circularLogService;
		BIGGRt9aDk = launcherSettings;
		SVdGnXMBNs = new AsyncRelayCommand(XUtGPP7NHf);
		kKSGgWodUR = new AsyncRelayCommand<Software>(srFG7vFsuv);
		NvHGoqMVXm = new RelayCommand<Software>(UsePreviousVersion);
		NJhGhZSwb0 = new RelayCommand(TGmGvHdJaU);
	}

	private async Task<bool> RRuGiqDk5P(Software P_0)
	{
		try
		{
			string activeSoftwareVersionNumber = SoftwareVersionsService.GetActiveSoftwareVersionNumber(P_0);
			return !(await SoftwareVersionsService.IsVersionLatestAvailableAsync(P_0, activeSoftwareVersionNumber));
		}
		catch
		{
			return true;
		}
	}

	private async Task XUtGPP7NHf()
	{
		HasIDRANewVersionAvailable = await RRuGiqDk5P(Software.IDRA);
		HasGolfInLauncherNewVersionAvailable = await RRuGiqDk5P(Software.GolfInLauncher);
		HasZGISRemoteNewVersionAvailable = await RRuGiqDk5P(Software.ZGISRemote);
		HasIDRAAutoCalibrationNewVersionAvailable = await RRuGiqDk5P(Software.IDRAAutoCalibration);
		OnPropertyChanged(aL07ImwcwlxdnyfI30.olMQlwrxmw(18492));
		OnPropertyChanged(aL07ImwcwlxdnyfI30.olMQlwrxmw(18536));
		OnPropertyChanged(aL07ImwcwlxdnyfI30.olMQlwrxmw(18600));
		OnPropertyChanged(aL07ImwcwlxdnyfI30.olMQlwrxmw(18656));
		OnPropertyChanged(aL07ImwcwlxdnyfI30.olMQlwrxmw(18730));
		OnPropertyChanged(aL07ImwcwlxdnyfI30.olMQlwrxmw(18772));
	}

	private void kakGJ0fUQb()
	{
		SoftwareVersionsService.CancelCurrentUpdate();
	}

	private async Task srFG7vFsuv(Software P_0)
	{
		_003C_003Ec__DisplayClass50_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass50_0();
		ICircularLogService circularLogService = syvGLiYdvO;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 1);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(18808));
		defaultInterpolatedStringHandler.AppendFormatted(P_0);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(18872));
		circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		string chocolateyPackageName = SoftwareVersionsService.GetSoftwareChocolateyPackageName(P_0);
		string executableToKill = "";
		string executableToRestart = "";
		if (P_0 == Software.GolfInLauncher)
		{
			executableToKill = P_0.ToString();
			executableToRestart = Path.Combine(GIConstant.SSCInstallPath, aL07ImwcwlxdnyfI30.olMQlwrxmw(18882));
			await eDNGt2NcqS.ShowMessageAsync(this, Resources.SoftwareVersion, Resources.GolfInLauncherUpdateWarning);
		}
		CS_0024_003C_003E8__locals4.bwh5bi35vB = new UpdateInProgressWindow(kakGJ0fUQb);
		((Window)CS_0024_003C_003E8__locals4.bwh5bi35vB).Show();
		Progress<string> progress = new Progress<string>(delegate(string line)
		{
			CS_0024_003C_003E8__locals4.bwh5bi35vB.AppendDetailLine(line);
		});
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 3);
		defaultInterpolatedStringHandler.AppendFormatted(GIConstant.SSCProgramDataPath);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(3528));
		defaultInterpolatedStringHandler.AppendFormatted(chocolateyPackageName);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(18954));
		defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now.Ticks);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(18974));
		string temporaryLogFileName = defaultInterpolatedStringHandler.ToStringAndClear();
		int num = await SoftwareVersionsService.RunChocolateyUpdateForSoftwareAsync(chocolateyPackageName, showPowerShellWindowAndKeepOpen: false, executableToKill, executableToRestart, null, temporaryLogFileName, runAsAdministrator: true, -1, progress);
		((Window)CS_0024_003C_003E8__locals4.bwh5bi35vB).Close();
		try
		{
			File.Delete(temporaryLogFileName);
		}
		catch (Exception)
		{
			syvGLiYdvO.Log(aL07ImwcwlxdnyfI30.olMQlwrxmw(18986) + temporaryLogFileName);
		}
		if (num == 0)
		{
			await eDNGt2NcqS.ShowMessageAsync(this, Resources.SoftwareVersion, string.Format(Resources.SoftwareUpdateNewVersionInstalled, P_0));
			ICircularLogService circularLogService2 = syvGLiYdvO;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 2);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(19100));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(19164));
			defaultInterpolatedStringHandler.AppendFormatted(SoftwareVersionsService.GetActiveSoftwareVersionNumber(P_0));
			circularLogService2.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		else
		{
			await eDNGt2NcqS.ShowMessageAsync(this, Resources.SoftwareVersion, Resources.SoftwareUpdateError);
			ICircularLogService circularLogService3 = syvGLiYdvO;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(71, 2);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(19196));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(19290));
			defaultInterpolatedStringHandler.AppendFormatted(SoftwareVersionsService.GetActiveSoftwareVersionNumber(P_0));
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(19314));
			circularLogService3.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		await XUtGPP7NHf();
	}

	private void UsePreviousVersion(Software software)
	{
		ICircularLogService circularLogService = syvGLiYdvO;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(81, 2);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(6104));
		defaultInterpolatedStringHandler.AppendFormatted(software);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(6220));
		defaultInterpolatedStringHandler.AppendFormatted(SoftwareVersionsService.GetActiveSoftwareVersionNumber(software));
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(6236));
		circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		try
		{
			string text = SoftwareVersionsService.SetActiveVersionToPrevious(software);
			string message = string.Format(Resources.SoftwareUpdatePreviousVersionRestored, text, software);
			eDNGt2NcqS.ShowMessageAsync(this, Resources.SoftwareVersion, message);
			ICircularLogService circularLogService2 = syvGLiYdvO;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 2);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(6278));
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(6352));
			defaultInterpolatedStringHandler.AppendFormatted(software);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(2680));
			circularLogService2.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		catch (Exception ex)
		{
			eDNGt2NcqS.ShowMessageAsync(this, Resources.SoftwareVersion, ex.Message);
			ICircularLogService circularLogService3 = syvGLiYdvO;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(75, 2);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(6366));
			defaultInterpolatedStringHandler.AppendFormatted(software);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(6464));
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(2680));
			circularLogService3.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		XUtGPP7NHf();
	}

	private void TGmGvHdJaU()
	{
		uFwGULwimg.NavigateTo(ViewModelNavigationPages.Main);
	}
}
