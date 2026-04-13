using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GICTSCore.Data;
using GICTSCore.Services;
using GIToolkit.Services;
using IDRAMonitor.Auxiliary.Navigation;
using IDRASharedModels;
using MahApps.Metro.Controls.Dialogs;
using hkpxmGISLhTJrZLcmi;
using jBnbmEXkwPOPpPQ9mC;

namespace IDRAMonitor.ViewModels;

public class ManagerSettingsMenuViewModel : ObservableRecipient, IViewModel
{
	private bool XRs7KMI3py;

	private bool jx07ybTsZi;

	private readonly INavigationService<VM> R0S7Z2U34N;

	private readonly ICircularLogService W1P7RiegZT;

	private readonly IDialogCoordinator rlQ7m0JkDq;

	private readonly IProcessHelper nYj7iIrlN2;

	private readonly ILocalAPIGameSettings P727hVQSHs;

	public ManagerSettings ManagerSettings => ManagerSettings.Instance;

	public bool IsContinueTimerDisabled
	{
		get
		{
			return XRs7KMI3py;
		}
		set
		{
			SetProperty(ref XRs7KMI3py, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4938));
		}
	}

	public bool IsForceOSKOptionVisible
	{
		get
		{
			return jx07ybTsZi;
		}
		set
		{
			SetProperty(ref jx07ybTsZi, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4988));
		}
	}

	public ICommand WindowLoadedCommand => new RelayCommand(delegate
	{
		OnPropertyChanged(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5038));
	});

	public ICommand SaveCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		if (ManagerSettings.GameSettings.ScoreCardTimeAfterHole == int.Parse(IDRAConstant.AdminManagerPassword))
		{
			IsForceOSKOptionVisible = true;
		}
		else
		{
			IsForceOSKOptionVisible = false;
			await hjX7vo9lLu();
			CancelCommand.Execute(null);
		}
	});

	public ICommand CloseRunningGame => new AsyncRelayCommand((Func<Task>)async delegate
	{
		try
		{
			if (await rlQ7m0JkDq.ShowMessageAsync(this, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6670), ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(11274) + P727hVQSHs.ProcessName + ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(11338), MessageDialogStyle.AffirmativeAndNegative, new MetroDialogSettings
			{
				AffirmativeButtonText = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6688),
				NegativeButtonText = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6462)
			}) == MessageDialogResult.Affirmative)
			{
				ICircularLogService w1P7RiegZT = W1P7RiegZT;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
				defaultInterpolatedStringHandler.AppendFormatted(new string('*', 30));
				defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(11346));
				defaultInterpolatedStringHandler.AppendFormatted(new string('*', 30));
				w1P7RiegZT.Log(defaultInterpolatedStringHandler.ToStringAndClear(), LogLevel.Warning);
				nYj7iIrlN2.GetProcessByName(P727hVQSHs.ProcessName).Kill();
			}
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
			W1P7RiegZT.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(11378) + ex.Message, LogLevel.Error);
			await rlQ7m0JkDq.ShowMessageAsync(this, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6670), ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(11446));
		}
	});

	public ICommand CancelCommand => new RelayCommand(delegate
	{
		R0S7Z2U34N.NavigateTo(VM.Main);
	});

	public ManagerSettingsMenuViewModel(INavigationService<VM> navigationService, ICircularLogService circularLogService, IDialogCoordinator dialogCoordinator, IProcessHelper processHelper, ILocalAPIGameSettings localAPIGameSettings)
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		XRs7KMI3py = ManagerSettings.Instance.PostShotAutoContinueDuration.TotalSeconds <= 0.0;
		base._002Ector();
		R0S7Z2U34N = navigationService;
		W1P7RiegZT = circularLogService;
		rlQ7m0JkDq = dialogCoordinator;
		nYj7iIrlN2 = processHelper;
		P727hVQSHs = localAPIGameSettings;
	}

	private async Task hjX7vo9lLu()
	{
		if (IsContinueTimerDisabled)
		{
			ManagerSettings.PostShotAutoContinueDuration = TimeSpan.FromSeconds(0.0);
		}
		if (ManagerSettings.VisualSettings.BaseCenterOffsetInches > 0f && ManagerSettings.VisualSettings.ScreenWidthInches <= 0f)
		{
			await rlQ7m0JkDq.ShowMessageAsync(this, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6670), ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(11492));
			return;
		}
		(bool, string) tuple = await ManagerSettings.SaveSetting();
		if (!tuple.Item1)
		{
			W1P7RiegZT.Log(tuple.Item2, LogLevel.Error);
			return;
		}
		await (await FileProcessCommunication.GetInstanceAsync(new IDRAtoIDRAMCommunication(), W1P7RiegZT)).WriteMessage(IDRAtoIDRAMCommunication.CommunicationCode.IDRAMonitorUpdateManagerSettings);
		await rlQ7m0JkDq.ShowMessageAsync(this, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7510), ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(11628));
	}

	[CompilerGenerated]
	private void pBu71OCYem()
	{
		OnPropertyChanged(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5038));
	}

	[CompilerGenerated]
	private async Task oqn7IVeHsb()
	{
		if (ManagerSettings.GameSettings.ScoreCardTimeAfterHole == int.Parse(IDRAConstant.AdminManagerPassword))
		{
			IsForceOSKOptionVisible = true;
			return;
		}
		IsForceOSKOptionVisible = false;
		await hjX7vo9lLu();
		CancelCommand.Execute(null);
	}

	[CompilerGenerated]
	private async Task Xyq7cIbBZD()
	{
		try
		{
			if (await rlQ7m0JkDq.ShowMessageAsync(this, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6670), ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(11274) + P727hVQSHs.ProcessName + ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(11338), MessageDialogStyle.AffirmativeAndNegative, new MetroDialogSettings
			{
				AffirmativeButtonText = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6688),
				NegativeButtonText = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6462)
			}) == MessageDialogResult.Affirmative)
			{
				ICircularLogService w1P7RiegZT = W1P7RiegZT;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
				defaultInterpolatedStringHandler.AppendFormatted(new string('*', 30));
				defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(11346));
				defaultInterpolatedStringHandler.AppendFormatted(new string('*', 30));
				w1P7RiegZT.Log(defaultInterpolatedStringHandler.ToStringAndClear(), LogLevel.Warning);
				nYj7iIrlN2.GetProcessByName(P727hVQSHs.ProcessName).Kill();
			}
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
			W1P7RiegZT.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(11378) + ex.Message, LogLevel.Error);
			await rlQ7m0JkDq.ShowMessageAsync(this, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6670), ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(11446));
		}
	}

	[CompilerGenerated]
	private void FUI7Xcoamx()
	{
		R0S7Z2U34N.NavigateTo(VM.Main);
	}
}
