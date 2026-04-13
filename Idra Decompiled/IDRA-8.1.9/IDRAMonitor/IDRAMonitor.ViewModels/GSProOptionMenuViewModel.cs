using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using GICTS.Data;
using GICTSCore.Data;
using GICTSCore.Model;
using GICTSCore.Services;
using GIToolkit.Services;
using IDRA.Auxiliary.Helpers;
using IDRAMonitor.Auxiliary.Messages;
using IDRAMonitor.Auxiliary.Navigation;
using IDRAMonitor.Services;
using IDRASharedModels;
using MahApps.Metro.Controls.Dialogs;
using hkpxmGISLhTJrZLcmi;
using jBnbmEXkwPOPpPQ9mC;

namespace IDRAMonitor.ViewModels;

public class GSProOptionMenuViewModel : ObservableRecipient, IViewModel
{
	private bool iAij1tOHUa;

	private bool N69jIdRThf;

	private IDialogCoordinator R3tjcxmvjJ;

	private readonly IMessagingService TkujXnjh2C;

	private readonly INavigationService<VM> cmKjKi7mYf;

	private readonly ICircularLogService k0ljyWghqJ;

	private readonly ILocalAPIGameSettings koDjZN1ekv;

	private readonly IProjectProcessService OjAjRNYaPt;

	private readonly IProcessHelper ij8jmlUfb6;

	private readonly IGICTSSettingsWrapper VHHjiQbnIq;

	private IGICTSSettings xLxjh20HUa;

	private FileProcessCommunication vJ6jB2JOjZ;

	private bool WBojATC2PM;

	public string ApplicationVersion => Helper.GetAssemblyVersion();

	public double WindowWidth => SystemParameters.FullPrimaryScreenWidth / 1.59;

	public double WindowHeight => SystemParameters.FullPrimaryScreenHeight / 2.4;

	public bool ShowProgress
	{
		get
		{
			return iAij1tOHUa;
		}
		set
		{
			SetProperty(ref iAij1tOHUa, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2278));
		}
	}

	public bool UseGsPro
	{
		get
		{
			return N69jIdRThf;
		}
		set
		{
			SetProperty(ref N69jIdRThf, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2912));
		}
	}

	public ManagerSettings ManagerSettings => ManagerSettings.Instance;

	public bool UsePostShot
	{
		get
		{
			if (!ManagerSettings.UseGolfInPostShotInGame)
			{
				return ManagerSettings.UseGolfInPostShotInPractice;
			}
			return true;
		}
	}

	public ICommand WindowLoadedCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		xLxjh20HUa = await VHHjiQbnIq.LoadSettings(IDRAConstant.GICTSSettingsFilePath);
		UseGsPro = xLxjh20HUa.UseGSPro;
		WBojATC2PM = ManagerSettings.Instance.UseGolfInPostShotInGame || ManagerSettings.Instance.UseGolfInPostShotInPractice;
	});

	public ICommand ResetCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		k0ljyWghqJ.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8082));
		if (!ShowProgress)
		{
			i14j7MVT4T(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8140));
			ShowProgress = true;
			ICircularLogService circularLogService = k0ljyWghqJ;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
			defaultInterpolatedStringHandler.AppendFormatted(new string('*', 30));
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8224));
			defaultInterpolatedStringHandler.AppendFormatted(new string('*', 30));
			circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear(), LogLevel.Warning);
			await OjAjRNYaPt.ResetIdra();
			await Task.Delay(IDRAConstant.ResetMaxDelayTimeMs);
			ShowProgress = false;
		}
	});

	public ICommand ServiceCommand => new RelayCommand(delegate
	{
		k0ljyWghqJ.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(3168));
	});

	public ICommand ViewShotAnalyserCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		if (ManagerSettings.Instance.UseGolfInPostShotInGame || ManagerSettings.Instance.UseGolfInPostShotInPractice)
		{
			await vJ6jB2JOjZ.WriteMessage(IDRAtoIDRAMCommunication.CommunicationCode.OpenShotAnalyser);
			k0ljyWghqJ.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8546));
			cmKjKi7mYf.NavigateTo(VM.Main);
		}
	});

	public ICommand SettingsCommand => new RelayCommand(delegate
	{
		k0ljyWghqJ.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(3230));
		if (GolfInLauncherSettingsService.GetCustomerPIN().Length > 0)
		{
			TkujXnjh2C.Send(new ShowPasswordMessage(PasswordWindowMode.Manager));
			cmKjKi7mYf.NavigateTo(VM.PasswordWindow);
		}
		else
		{
			cmKjKi7mYf.NavigateTo(VM.ManagerSettingMenu);
		}
	});

	public ICommand SimulateKeystrokeCommand => new AsyncRelayCommand<object>(async delegate(dynamic param)
	{
		try
		{
			string text = ((param is Array) ? param[0] : param);
			uint num = Convert.ToUInt32(text, 16);
			bool closeWindow = ((param is Array) ? param[1] : ((object)true));
			ICircularLogService circularLogService = k0ljyWghqJ;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8290));
			defaultInterpolatedStringHandler.AppendFormatted(num);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8328));
			circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear());
			AutomaticUserInput.SendKey(koDjZN1ekv.ProcessName, num, text == ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8340));
			await Task.Delay(50);
			if (closeWindow)
			{
				Application.Current.MainWindow.Activate();
				cmKjKi7mYf.NavigateTo(VM.Main);
			}
		}
		catch (Exception ex)
		{
			k0ljyWghqJ.Log(string.Format(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8352), (object?)param[0], ex.Message), LogLevel.Error);
		}
	});

	public ICommand TogglePostShotVisibilityCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		k0ljyWghqJ.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8438));
		WBojATC2PM = !WBojATC2PM;
		ManagerSettings.Instance.UseGolfInPostShotInGame = WBojATC2PM;
		ManagerSettings.Instance.UseGolfInPostShotInPractice = WBojATC2PM;
		OnPropertyChanged(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8520));
		OnPropertyChanged(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5038));
		await ManagerSettings.Instance.SaveEnablePostShotSetting(UsePostShot);
		if (UsePostShot)
		{
			await vJ6jB2JOjZ.WriteMessage(IDRAtoIDRAMCommunication.CommunicationCode.IDRAMonitorEnablePostShot);
		}
		else
		{
			await vJ6jB2JOjZ.WriteMessage(IDRAtoIDRAMCommunication.CommunicationCode.IDRAMonitorDisablePostShot);
		}
	});

	public ICommand CancelCommand => new RelayCommand(delegate
	{
		k0ljyWghqJ.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(3294));
		cmKjKi7mYf.NavigateTo(VM.Main);
	});

	public GSProOptionMenuViewModel(IDialogCoordinator dialogCoordinator, IMessagingService messagingService, INavigationService<VM> navigationService, ICircularLogService circularLogService, IGICTSSettings gICTSSettings, ILocalAPIGameSettings localAPIGameSettings, IProjectProcessService projectProcessService, IProcessHelper processHelper, IGICTSSettingsWrapper gICTSSettingsWrapper)
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		base._002Ector();
		R3tjcxmvjJ = dialogCoordinator;
		TkujXnjh2C = messagingService;
		cmKjKi7mYf = navigationService;
		k0ljyWghqJ = circularLogService;
		xLxjh20HUa = gICTSSettings;
		koDjZN1ekv = localAPIGameSettings;
		OjAjRNYaPt = projectProcessService;
		ij8jmlUfb6 = processHelper;
		VHHjiQbnIq = gICTSSettingsWrapper;
		WeakReferenceMessenger.Default.Register(this, delegate(object P_0, SetShowProgessMessage P_1)
		{
			ShowProgress = P_1.Data.NewShowProgressMessageValue;
			if (!ShowProgress && P_1.Data.IsOnGSProMenu)
			{
				CancelCommand.Execute(null);
			}
		});
		Task.Run(async delegate
		{
			vJ6jB2JOjZ = await FileProcessCommunication.GetInstanceAsync(new IDRAtoIDRAMCommunication(), k0ljyWghqJ);
		}).Wait();
		i14j7MVT4T(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2932));
	}

	private void i14j7MVT4T(string P_0)
	{
		try
		{
			k0ljyWghqJ.Log(P_0);
			k0ljyWghqJ.Log(MetricService.GetRAMInfo());
			k0ljyWghqJ.Log(MetricService.GetRAMInfo(koDjZN1ekv.ProcessName));
			k0ljyWghqJ.Log(MetricService.GetVRAMNividiaInfo());
		}
		catch (Exception ex)
		{
			k0ljyWghqJ.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(3034) + ex.Message, LogLevel.Error);
		}
	}

	[CompilerGenerated]
	private void AR3jFKMabn(object P_0, SetShowProgessMessage P_1)
	{
		ShowProgress = P_1.Data.NewShowProgressMessageValue;
		if (!ShowProgress && P_1.Data.IsOnGSProMenu)
		{
			CancelCommand.Execute(null);
		}
	}

	[CompilerGenerated]
	private async Task? GBhjGfsa8M()
	{
		vJ6jB2JOjZ = await FileProcessCommunication.GetInstanceAsync(new IDRAtoIDRAMCommunication(), k0ljyWghqJ);
	}

	[CompilerGenerated]
	private async Task GsXj2Fm3ks()
	{
		xLxjh20HUa = await VHHjiQbnIq.LoadSettings(IDRAConstant.GICTSSettingsFilePath);
		UseGsPro = xLxjh20HUa.UseGSPro;
		WBojATC2PM = ManagerSettings.Instance.UseGolfInPostShotInGame || ManagerSettings.Instance.UseGolfInPostShotInPractice;
	}

	[CompilerGenerated]
	private async Task igmj9V6KFj()
	{
		k0ljyWghqJ.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8082));
		if (!ShowProgress)
		{
			i14j7MVT4T(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8140));
			ShowProgress = true;
			ICircularLogService circularLogService = k0ljyWghqJ;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
			defaultInterpolatedStringHandler.AppendFormatted(new string('*', 30));
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8224));
			defaultInterpolatedStringHandler.AppendFormatted(new string('*', 30));
			circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear(), LogLevel.Warning);
			await OjAjRNYaPt.ResetIdra();
			await Task.Delay(IDRAConstant.ResetMaxDelayTimeMs);
			ShowProgress = false;
		}
	}

	[CompilerGenerated]
	private void tISjqjWObS()
	{
		k0ljyWghqJ.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(3168));
	}

	[CompilerGenerated]
	private async Task BUkjtIwk3D()
	{
		if (ManagerSettings.Instance.UseGolfInPostShotInGame || ManagerSettings.Instance.UseGolfInPostShotInPractice)
		{
			await vJ6jB2JOjZ.WriteMessage(IDRAtoIDRAMCommunication.CommunicationCode.OpenShotAnalyser);
			k0ljyWghqJ.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8546));
			cmKjKi7mYf.NavigateTo(VM.Main);
		}
	}

	[CompilerGenerated]
	private void nUXjWCTmab()
	{
		k0ljyWghqJ.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(3230));
		if (GolfInLauncherSettingsService.GetCustomerPIN().Length > 0)
		{
			TkujXnjh2C.Send(new ShowPasswordMessage(PasswordWindowMode.Manager));
			cmKjKi7mYf.NavigateTo(VM.PasswordWindow);
		}
		else
		{
			cmKjKi7mYf.NavigateTo(VM.ManagerSettingMenu);
		}
	}

	[CompilerGenerated]
	private async Task U6rj3ThkI5(dynamic param)
	{
		try
		{
			string text = ((param is Array) ? param[0] : param);
			uint num = Convert.ToUInt32(text, 16);
			bool closeWindow = ((param is Array) ? param[1] : ((object)true));
			ICircularLogService circularLogService = k0ljyWghqJ;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8290));
			defaultInterpolatedStringHandler.AppendFormatted(num);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8328));
			circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear());
			AutomaticUserInput.SendKey(koDjZN1ekv.ProcessName, num, text == ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8340));
			await Task.Delay(50);
			if (closeWindow)
			{
				Application.Current.MainWindow.Activate();
				cmKjKi7mYf.NavigateTo(VM.Main);
			}
		}
		catch (Exception ex)
		{
			k0ljyWghqJ.Log(string.Format(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8352), (object?)param[0], ex.Message), LogLevel.Error);
		}
	}

	[CompilerGenerated]
	private async Task WEAjJ0Itm9()
	{
		k0ljyWghqJ.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8438));
		WBojATC2PM = !WBojATC2PM;
		ManagerSettings.Instance.UseGolfInPostShotInGame = WBojATC2PM;
		ManagerSettings.Instance.UseGolfInPostShotInPractice = WBojATC2PM;
		OnPropertyChanged(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8520));
		OnPropertyChanged(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5038));
		await ManagerSettings.Instance.SaveEnablePostShotSetting(UsePostShot);
		if (UsePostShot)
		{
			await vJ6jB2JOjZ.WriteMessage(IDRAtoIDRAMCommunication.CommunicationCode.IDRAMonitorEnablePostShot);
		}
		else
		{
			await vJ6jB2JOjZ.WriteMessage(IDRAtoIDRAMCommunication.CommunicationCode.IDRAMonitorDisablePostShot);
		}
	}

	[CompilerGenerated]
	private void LyWjv1IJIK()
	{
		k0ljyWghqJ.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(3294));
		cmKjKi7mYf.NavigateTo(VM.Main);
	}
}
