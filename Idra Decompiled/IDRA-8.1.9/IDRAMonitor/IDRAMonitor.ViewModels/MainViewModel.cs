using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Input;
using Azure.Storage.Blobs;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GICTS.Data;
using GICTSCore.Data;
using GICTSCore.Model;
using GICTSCore.Services;
using GIToolkit.Model;
using GIToolkit.Services;
using IDRA.Auxiliary.Helpers;
using IDRAMonitor.Auxiliary.Messages;
using IDRAMonitor.Auxiliary.Navigation;
using IDRAMonitor.Internationalization;
using IDRAMonitor.Services;
using IDRASharedModels;
using MahApps.Metro.Controls.Dialogs;
using Osklib;
using hkpxmGISLhTJrZLcmi;
using jBnbmEXkwPOPpPQ9mC;

namespace IDRAMonitor.ViewModels;

public class MainViewModel : ObservableRecipient, IViewModel
{
	private static class gK8I1dJlWDOFDIT7Rv
	{
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public MainViewModel CVpGQ1pgdD;

		public IChocolateyVersionFinderService XrAGVA1xy1;

		public _003C_003Ec__DisplayClass59_0()
		{
			sfdIMacorwsONDcXji.p9wJZFvkayjbK();
			base._002Ector();
		}

		internal async Task? FG8GPfKwT1()
		{
			FileProcessCommunication zh773o2UTE = await FileProcessCommunication.GetInstanceAsync(new IDRAtoIDRAMCommunication(), CVpGQ1pgdD.UAmjnZhZWI);
			CVpGQ1pgdD.zh773o2UTE = zh773o2UTE;
			FileProcessCommunication zh773o2UTE2 = CVpGQ1pgdD.zh773o2UTE;
			zh773o2UTE2.OnReceiveMessage = (Func<string, Task>)Delegate.Combine(zh773o2UTE2.OnReceiveMessage, new Func<string, Task>(CVpGQ1pgdD.OnFileReceiveMessage));
			string vg57rUTuX = await XrAGVA1xy1.FindLatestProductionVersion(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(15456), IChocolateyVersionFinderService.Environment.Prod);
			CVpGQ1pgdD.vg57rUTuX1 = vg57rUTuX;
			bool yfj7Jiy5C = await XrAGVA1xy1.IsUsingProductionChocolateyRepository();
			CVpGQ1pgdD.Yfj7Jiy5C0 = yfj7Jiy5C;
		}
	}

	private Thickness DuSjllZ4NW;

	private int aS2j82RtlD;

	private int lHtjkJZcic;

	private VerticalAlignment Hq3j4gPj80;

	private string DRcjU5Kpoj;

	private bool UeujfCkpkw;

	private bool TQOjMDuXwG;

	[CompilerGenerated]
	private ButtonStyle jyxjDQ41rZ;

	private IDialogCoordinator fhQjH7dMny;

	private readonly IMessagingService Kd5ja7yIbt;

	private readonly IProcessHelper AOhj6fr5Ol;

	private readonly ISoftwareAzureBlobUpdater HHvj5U5E4M;

	private readonly IProjectProcessService LGJjdohl3s;

	private readonly INavigationService<VM> vP1jSBDy5g;

	private readonly ICircularLogService UAmjnZhZWI;

	private readonly IGICTSSettings mvyjoKRlPo;

	private readonly ILocalAPIGameSettings GkWjbqfXKy;

	private readonly IGSProServices ojFjspQJo1;

	private readonly INetworkUtility Op5jzUJXbX;

	private string vg57rUTuX1;

	private System.Timers.Timer MsZ7jQbYnj;

	private int HZW77O8M6S;

	private ProgressDialogController KHv7FrscUF;

	private Task h2V7GP9nLL;

	private bool A3y721A5nJ;

	private readonly CancellationTokenSource LZI79aBGw6;

	private long N047qWSAtN;

	private DateTime Gw17tggRna;

	private bool YwE7WbgCfX;

	private FileProcessCommunication zh773o2UTE;

	private bool Yfj7Jiy5C0;

	public bool IsApplicationUpToDateWithProduction
	{
		get
		{
			if (!(Helper.GetAssemblyVersion() == vg57rUTuX1))
			{
				return Yfj7Jiy5C0;
			}
			return true;
		}
	}

	public Thickness MenuMargin
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return DuSjllZ4NW;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			SetProperty(ref DuSjllZ4NW, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(3354));
		}
	}

	public int MenuWidth
	{
		get
		{
			return aS2j82RtlD;
		}
		set
		{
			SetProperty(ref aS2j82RtlD, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(3378));
		}
	}

	public int MenuHeight
	{
		get
		{
			return lHtjkJZcic;
		}
		set
		{
			SetProperty(ref lHtjkJZcic, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(3400));
		}
	}

	public VerticalAlignment MenuVerticalAlignment
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return Hq3j4gPj80;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			SetProperty(ref Hq3j4gPj80, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(3424));
		}
	}

	public string BtnResetStyle
	{
		get
		{
			return DRcjU5Kpoj;
		}
		set
		{
			SetProperty(ref DRcjU5Kpoj, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(3470));
		}
	}

	public bool GameProcessIsRunning
	{
		get
		{
			if (!UseGSPro)
			{
				return UeujfCkpkw;
			}
			return false;
		}
		set
		{
			SetProperty(ref UeujfCkpkw, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(3500));
		}
	}

	public bool UseGSPro
	{
		get
		{
			return TQOjMDuXwG;
		}
		set
		{
			SetProperty(ref TQOjMDuXwG, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(3544));
		}
	}

	public ButtonStyle GSProShortcutButton
	{
		[CompilerGenerated]
		get
		{
			return jyxjDQ41rZ;
		}
		[CompilerGenerated]
		set
		{
			jyxjDQ41rZ = value;
		}
	}

	public ICommand WindowLoadedCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		if (!A3y721A5nJ)
		{
			A3y721A5nJ = true;
			bool flag = !GIConstant.UsingSSCInstallPath;
			if (flag)
			{
				flag = !(await VGLjLa1sd7());
			}
			if (!flag)
			{
				if (UseGSPro)
				{
					ojFjspQJo1.UninstallGSProLauncher();
					if (!YwE7WbgCfX)
					{
						if (!Op5jzUJXbX.IsNetworkAvailable(0L))
						{
							UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8782), LogLevel.Warning);
						}
						else if (await ojFjspQJo1.VerifyNewGSProVersion())
						{
							Version stableVersion = await ojFjspQJo1.GetGSProStableVersion();
							try
							{
								IDialogCoordinator dialogCoordinator = fhQjH7dMny;
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
								defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8904));
								defaultInterpolatedStringHandler.AppendFormatted(stableVersion);
								KHv7FrscUF = await dialogCoordinator.ShowProgressAsync(this, defaultInterpolatedStringHandler.ToStringAndClear(), ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8936));
								await ojFjspQJo1.InstallNewGSProVersion(stableVersion, XXKjxmJqn0, Ep4jTfM3eL);
							}
							finally
							{
								await KHv7FrscUF.CloseAsync();
							}
						}
					}
					if (!(await xJyjY8boMr()))
					{
						return;
					}
				}
				if (mvyjoKRlPo.StartWithGame)
				{
					await h1pjVmJWbG();
				}
				await LGJjdohl3s.LaunchIdra(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8968));
			}
		}
	});

	public ICommand OpenKeyboardCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		try
		{
			UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8620));
			if (!OnScreenKeyboard.IsOpened())
			{
				OnScreenKeyboard.Show();
			}
			AOhj6fr5Ol.ModifyWindowState(GkWjbqfXKy.ProcessName, ShowWindowEnum.ShowMaximized, setFocus: true);
		}
		catch (Exception ex)
		{
			await fhQjH7dMny.ShowMessageAsync(this, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6670), ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8694));
			EventViewerLogger.LogException(ex);
			vP1jSBDy5g.NavigateTo(VM.Main);
		}
	});

	public ICommand OpenPasswordWindowCommand => new RelayCommand(delegate
	{
		UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4778));
		Kd5ja7yIbt.Send(new ShowPasswordMessage(PasswordWindowMode.Admin));
		vP1jSBDy5g.NavigateTo(VM.PasswordWindow);
	});

	public ICommand MenuCommand => new RelayCommand(delegate
	{
		UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4866));
		if (UseGSPro)
		{
			vP1jSBDy5g.NavigateTo(VM.GSProOptionMenu);
		}
		else
		{
			vP1jSBDy5g.NavigateTo(VM.OptionDialog);
		}
	});

	public MainViewModel(IDialogCoordinator dialogCoordinator, IMessagingService messagingService, IProcessHelper processHelper, ISoftwareAzureBlobUpdater softwareUpdater, IProjectProcessService projectProcessService, INavigationService<VM> navigationService, ICircularLogService circularLogService, IGICTSSettings gICTSSettings, ILocalAPIGameSettings localAPIGameSettings, IGSProServices gSProServices, INetworkUtility networkUtility, IChocolateyVersionFinderService chocolateyVersionFinderService)
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		LZI79aBGw6 = new CancellationTokenSource();
		Gw17tggRna = DateTime.Now;
		Yfj7Jiy5C0 = true;
		_003C_003Ec__DisplayClass59_0 CS_0024_003C_003E8__locals10 = new _003C_003Ec__DisplayClass59_0();
		CS_0024_003C_003E8__locals10.XrAGVA1xy1 = chocolateyVersionFinderService;
		base._002Ector();
		CS_0024_003C_003E8__locals10.CVpGQ1pgdD = this;
		fhQjH7dMny = dialogCoordinator;
		Kd5ja7yIbt = messagingService;
		AOhj6fr5Ol = processHelper;
		HHvj5U5E4M = softwareUpdater;
		LGJjdohl3s = projectProcessService;
		vP1jSBDy5g = navigationService;
		UAmjnZhZWI = circularLogService;
		mvyjoKRlPo = gICTSSettings;
		GkWjbqfXKy = localAPIGameSettings;
		ojFjspQJo1 = gSProServices;
		Op5jzUJXbX = networkUtility;
		UseGSPro = mvyjoKRlPo.UseGSPro;
		GSProShortcutButton = new ButtonStyle();
		Jb1jgENYvc();
		eAQjQOYiTi();
		fhfjCI7fpe();
		try
		{
			UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(3564));
			Process[] processesByName = Process.GetProcessesByName(IDRAConstant.LoadingScreenProcessName);
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
		}
		Task.Run(async delegate
		{
			FileProcessCommunication fileProcessCommunication = await FileProcessCommunication.GetInstanceAsync(new IDRAtoIDRAMCommunication(), CS_0024_003C_003E8__locals10.CVpGQ1pgdD.UAmjnZhZWI);
			CS_0024_003C_003E8__locals10.CVpGQ1pgdD.zh773o2UTE = fileProcessCommunication;
			FileProcessCommunication fileProcessCommunication2 = CS_0024_003C_003E8__locals10.CVpGQ1pgdD.zh773o2UTE;
			fileProcessCommunication2.OnReceiveMessage = (Func<string, Task>)Delegate.Combine(fileProcessCommunication2.OnReceiveMessage, new Func<string, Task>(CS_0024_003C_003E8__locals10.CVpGQ1pgdD.OnFileReceiveMessage));
			string text = await CS_0024_003C_003E8__locals10.XrAGVA1xy1.FindLatestProductionVersion(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(15456), IChocolateyVersionFinderService.Environment.Prod);
			CS_0024_003C_003E8__locals10.CVpGQ1pgdD.vg57rUTuX1 = text;
			bool yfj7Jiy5C = await CS_0024_003C_003E8__locals10.XrAGVA1xy1.IsUsingProductionChocolateyRepository();
			CS_0024_003C_003E8__locals10.CVpGQ1pgdD.Yfj7Jiy5C0 = yfj7Jiy5C;
		}).Wait();
	}

	private async Task<bool> xJyjY8boMr()
	{
		if (!UseGSPro)
		{
			return true;
		}
		ErrorCode errorCode = await ojFjspQJo1.ApplyGolfInMod();
		if (!errorCode.Success && errorCode.Code != 500 && await fhQjH7dMny.ShowMessageAsync(this, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6670), errorCode.ErrorMessage, MessageDialogStyle.AffirmativeAndNegative, new MetroDialogSettings
		{
			AffirmativeButtonText = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9010),
			NegativeButtonText = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9044)
		}) == MessageDialogResult.Negative)
		{
			try
			{
				AOhj6fr5Ol.GetProcessByName(GkWjbqfXKy.ProcessName)?.Kill();
			}
			catch (Exception ex)
			{
				EventViewerLogger.LogException(ex);
			}
			finally
			{
				Environment.Exit(0);
			}
			return false;
		}
		return true;
	}

	private async Task OnFileReceiveMessage(string message)
	{
		if (string.IsNullOrWhiteSpace(message))
		{
			return;
		}
		UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(10416) + message);
		try
		{
			MatchCollection matchCollection = new Regex(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(10528)).Matches(message);
			int exitCode = -1;
			int.TryParse(matchCollection[0].Value, out exitCode);
			ICircularLogService uAmjnZhZWI = UAmjnZhZWI;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(10538));
			defaultInterpolatedStringHandler.AppendFormatted(exitCode);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(10586));
			uAmjnZhZWI.Log(defaultInterpolatedStringHandler.ToStringAndClear());
			if (exitCode == IDRAtoIDRAMCommunication.CommunicationCode.OpenShotAnalyser || exitCode == IDRAtoIDRAMCommunication.CommunicationCode.IDRAMonitorUpdateManagerSettings || exitCode == IDRAtoIDRAMCommunication.CommunicationCode.IDRAMonitorEnablePostShot || exitCode == IDRAtoIDRAMCommunication.CommunicationCode.IDRAMonitorDisablePostShot)
			{
				return;
			}
			if (exitCode == IDRAtoIDRAMCommunication.CommunicationCode.IDRAFirstTeeEvent)
			{
				await ManagerSettings.Instance.Reload(checkNewProp: false);
				return;
			}
			LGJjdohl3s.IdraHasCloseSuccessfully = true;
			if (exitCode == IDRAtoIDRAMCommunication.CommunicationCode.NormalClose)
			{
				UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(10592));
				Kd5ja7yIbt.Send(new CloseApplicationMessage(100));
				return;
			}
			if (exitCode == IDRAtoIDRAMCommunication.CommunicationCode.FactoryReset)
			{
				UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(10710));
				LGJjdohl3s.IsDesiredExit = true;
				Kd5ja7yIbt.Send(new SetShowProgessMessage(new OptionDialogViewModelMessageData
				{
					ActHasProgressWithMessage = true,
					DisplayMessage = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(10802),
					NewShowProgressMessageValue = true,
					IsOnGSProMenu = UseGSPro
				}));
				vP1jSBDy5g.NavigateTo(VM.OptionDialog);
				await Task.Delay(IDRAConstant.DelayTimeToFactoryReset);
			}
			if (LGJjdohl3s.LaunchBackIdra || exitCode == IDRAtoIDRAMCommunication.CommunicationCode.ACKResetIDRA)
			{
				UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(10942));
				await LGJjdohl3s.LaunchIdra(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(10984));
				await Task.Delay(IDRAConstant.DelayTimeToOpenIdra);
				Kd5ja7yIbt.Send(new SetShowProgessMessage(new OptionDialogViewModelMessageData
				{
					ActHasProgressWithMessage = false,
					DisplayMessage = string.Empty,
					NewShowProgressMessageValue = false,
					IsOnGSProMenu = UseGSPro
				}));
			}
			else if (exitCode != -1)
			{
				UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(11028));
				Kd5ja7yIbt.Send(new CloseApplicationMessage(100));
			}
		}
		catch (Exception ex)
		{
			UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(11150) + message, LogLevel.Error);
			EventViewerLogger.LogException(ex);
		}
	}

	private void fhfjCI7fpe()
	{
		MsZ7jQbYnj = new System.Timers.Timer(10000.0)
		{
			AutoReset = false,
			Enabled = true
		};
		MsZ7jQbYnj.Elapsed += DmijPRHOh9;
		DmijPRHOh9(null, null);
	}

	private void DmijPRHOh9(object P_0, ElapsedEventArgs P_1)
	{
		if (P_0 == null || !(P_0 is System.Timers.Timer))
		{
			return;
		}
		(P_0 as System.Timers.Timer).Enabled = false;
		try
		{
			using Process process = AOhj6fr5Ol.GetProcessByName(GkWjbqfXKy.ProcessName);
			GameProcessIsRunning = process != null;
		}
		catch (Exception ex)
		{
			UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(3672), LogLevel.Warning);
			EventViewerLogger.LogException(ex);
		}
		finally
		{
			(P_0 as System.Timers.Timer).Enabled = true;
		}
	}

	private static void eAQjQOYiTi()
	{
		Directory.CreateDirectory(IDRAConstant.IdraProgramDataPath);
		Directory.CreateDirectory(IDRAConstant.IdraProgramDataPathConfig);
		Directory.CreateDirectory(IDRAConstant.IdraProgramDataPathCalib);
		Directory.CreateDirectory(IDRAConstant.GICTSSamplesFolder);
		Directory.CreateDirectory(IDRAConstant.GICTSSamplesResultsFolder);
		Directory.CreateDirectory(IDRAConstant.GICTSSamplesShotsFolder);
		Directory.CreateDirectory(IDRAConstant.GICTSSamplesGroundTruthFolder);
	}

	private async Task h1pjVmJWbG()
	{
		UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(10122));
		if (!File.Exists(GkWjbqfXKy.ProcessPath))
		{
			UAmjnZhZWI.Log(Resources.Game_is_not_installed_on_the_current_pc, LogLevel.Error);
			await fhQjH7dMny.ShowMessageAsync(this, Resources.ProgramError, Resources.Game_is_not_installed_on_the_current_pc);
			return;
		}
		try
		{
			Process processByName = AOhj6fr5Ol.GetProcessByName(GkWjbqfXKy.ProcessName);
			bool num = processByName != null;
			Process process = (num ? processByName : AOhj6fr5Ol.CreateProcess(GkWjbqfXKy.ProcessPath));
			if (!num)
			{
				UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(10184));
				AOhj6fr5Ol.StartProcess(process);
			}
			UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(10252));
			AOhj6fr5Ol.ModifyWindowState(process?.ProcessName, ShowWindowEnum.ShowMaximized, setFocus: true);
			UhNjwjvSYk(process, GameProcess_Exited);
		}
		catch (Exception ex)
		{
			UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(10324), LogLevel.Error);
			EventViewerLogger.LogException(ex);
		}
	}

	private void UhNjwjvSYk(Process P_0, EventHandler P_1)
	{
		try
		{
			AOhj6fr5Ol.AttachListenerOnExited(P_0, P_1);
		}
		catch (Exception ex)
		{
			UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(3812) + ex.Message, LogLevel.Error);
		}
	}

	public void GameProcess_Exited(object sender, EventArgs e)
	{
		UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4006));
		LGJjdohl3s.CloseApplication();
	}

	private void Jb1jgENYvc()
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		double fullPrimaryScreenHeight = SystemParameters.FullPrimaryScreenHeight;
		double fullPrimaryScreenWidth = SystemParameters.FullPrimaryScreenWidth;
		MenuMargin = (UseGSPro ? new Thickness(0.0, fullPrimaryScreenHeight * 0.02337, fullPrimaryScreenWidth / 2.85, 0.0) : new Thickness(0.0, fullPrimaryScreenHeight * 0.03343, fullPrimaryScreenWidth * 0.02708, 0.0));
		MenuVerticalAlignment = (VerticalAlignment)(UseGSPro ? 0 : 0);
		GSProShortcutButton.Width = fullPrimaryScreenWidth / 11.6363;
		GSProShortcutButton.Height = fullPrimaryScreenHeight / 7.6074;
		GSProShortcutButton.Margin = new Thickness(0.0, fullPrimaryScreenHeight / 11.9072, fullPrimaryScreenWidth / 10.66667, 0.0);
		MenuWidth = (UseGSPro ? 55 : 175);
		MenuHeight = (UseGSPro ? 55 : 50);
		ICircularLogService uAmjnZhZWI = UAmjnZhZWI;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(58, 3);
		defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4106));
		defaultInterpolatedStringHandler.AppendFormatted<Thickness>(MenuMargin);
		defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4158));
		defaultInterpolatedStringHandler.AppendFormatted(fullPrimaryScreenWidth);
		defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4224));
		defaultInterpolatedStringHandler.AppendFormatted(fullPrimaryScreenHeight);
		uAmjnZhZWI.Log(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	private async Task<bool> VGLjLa1sd7()
	{
		if (Debugger.IsAttached)
		{
			return true;
		}
		if (!Op5jzUJXbX.IsNetworkAvailable(0L))
		{
			UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9056), LogLevel.Warning);
			return true;
		}
		try
		{
			bool result;
			try
			{
				Dictionary<string, string> tags = new Dictionary<string, string> { 
				{
					ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9160),
					ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9182)
				} };
				string blobStorage = ConfigurationManager.AppSettings[ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9194)];
				string connectionStringName = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7398);
				HHvj5U5E4M.SetupBlobServiceConnection(connectionStringName);
				BlobClient taggedIdra = await HHvj5U5E4M.GetTaggedBlob(blobStorage, tags);
				if (taggedIdra == null)
				{
					UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9238) + blobStorage);
					result = true;
				}
				else if (HHvj5U5E4M.IsLastVersionInstalled(IDRAConstant.IdraProcessPath + ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9336) + IDRAConstant.IdraProcess, taggedIdra))
				{
					UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9342) + taggedIdra.BlobContainerName);
					result = true;
				}
				else
				{
					UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9408) + taggedIdra.BlobContainerName);
					IDialogCoordinator dialogCoordinator = fhQjH7dMny;
					MainViewModel context = this;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
					defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9474));
					defaultInterpolatedStringHandler.AppendFormatted(HHvj5U5E4M.GetBlobItemVersion(taggedIdra));
					KHv7FrscUF = await dialogCoordinator.ShowProgressAsync(context, defaultInterpolatedStringHandler.ToStringAndClear(), ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8936), isCancelable: true);
					UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9502));
					_ = string.Empty;
					string downloadedFilePath;
					try
					{
						downloadedFilePath = await HHvj5U5E4M.DownloadWebFile(new DownloadWebFileOptions(taggedIdra.Uri.ToString(), Path.GetFileName(taggedIdra.Name), ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9566))
						{
							OnProgress = XXKjxmJqn0,
							OnCompleted = Ep4jTfM3eL,
							CancellationToken = LZI79aBGw6.Token
						});
					}
					catch (OperationCanceledException)
					{
						await KHv7FrscUF.CloseAsync();
						UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9586));
						YwE7WbgCfX = true;
						result = true;
						goto end_IL_00a4;
					}
					YwE7WbgCfX = false;
					await KHv7FrscUF.CloseAsync();
					string text = IDRAConstant.LoadingScreenProcessPath + ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9336) + IDRAConstant.LoadingScreenProcess;
					if (File.Exists(text))
					{
						string text2 = Path.GetTempPath() + ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9644);
						string loadingScreenProcess = IDRAConstant.LoadingScreenProcess;
						string text3 = text2 + loadingScreenProcess;
						text3 = text3.Replace(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9672), ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9336));
						Directory.CreateDirectory(text2);
						if (File.Exists(text3))
						{
							File.Delete(text3);
						}
						File.Copy(text, text3);
						UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9678));
						using Process processToStart = AOhj6fr5Ol.CreateProcess(text3, "", enableRaisingEvent: false);
						AOhj6fr5Ol.StartProcess(processToStart);
					}
					await Task.Delay(TimeSpan.FromSeconds(5.0));
					UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9752));
					ErrorCode errorCode = await HHvj5U5E4M.InstallFile(downloadedFilePath, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9812));
					ICircularLogService uAmjnZhZWI = UAmjnZhZWI;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(62, 2);
					defaultInterpolatedStringHandler2.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9824));
					defaultInterpolatedStringHandler2.AppendFormatted(errorCode.Success);
					defaultInterpolatedStringHandler2.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9908));
					defaultInterpolatedStringHandler2.AppendFormatted(errorCode.ErrorMessage);
					uAmjnZhZWI.Log(defaultInterpolatedStringHandler2.ToStringAndClear());
					await LGJjdohl3s.CloseApplication();
					result = false;
				}
				end_IL_00a4:;
			}
			catch (Exception ex2)
			{
				UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9956), LogLevel.Error);
				await fhQjH7dMny.ShowMessageAsync(this, Resources.ProgramError, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9956));
				EventViewerLogger.LogException(ex2);
				goto end_IL_007e;
			}
			return result;
			end_IL_007e:;
		}
		finally
		{
			if (KHv7FrscUF != null && KHv7FrscUF.IsOpen)
			{
				await KHv7FrscUF.CloseAsync();
			}
		}
		return true;
	}

	private void XXKjxmJqn0(long P_0, long P_1)
	{
		int num = (int)(P_0 * 100 / P_1);
		if (num <= 0)
		{
			HZW77O8M6S = 0;
		}
		if (KHv7FrscUF.IsCanceled && !LZI79aBGw6.IsCancellationRequested)
		{
			LZI79aBGw6.Cancel();
		}
		else if (num > HZW77O8M6S)
		{
			DateTime now = DateTime.Now;
			TimeSpan timeSpan = now - Gw17tggRna;
			Gw17tggRna = now;
			long num2 = P_0 - N047qWSAtN;
			N047qWSAtN = P_0;
			double num3 = (double)num2 / timeSpan.TotalSeconds;
			string value = s6vjN0W1K3(num3);
			string value2 = qd2jOgXL8J(P_0) + ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4234) + qd2jOgXL8J(P_1);
			long num4 = P_1 - P_0;
			string value3 = tLGjE7lcts((double)num4 / num3);
			HZW77O8M6S = num;
			ICircularLogService uAmjnZhZWI = UAmjnZhZWI;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(68, 4);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4244));
			defaultInterpolatedStringHandler.AppendFormatted(num);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4308));
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4320));
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4344));
			defaultInterpolatedStringHandler.AppendFormatted(value3);
			uAmjnZhZWI.Log(defaultInterpolatedStringHandler.ToStringAndClear());
			ProgressDialogController kHv7FrscUF = KHv7FrscUF;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(65, 4);
			defaultInterpolatedStringHandler2.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4396));
			defaultInterpolatedStringHandler2.AppendFormatted(num);
			defaultInterpolatedStringHandler2.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4444));
			defaultInterpolatedStringHandler2.AppendFormatted(value3);
			defaultInterpolatedStringHandler2.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4496));
			defaultInterpolatedStringHandler2.AppendFormatted(value2);
			defaultInterpolatedStringHandler2.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4320));
			defaultInterpolatedStringHandler2.AppendFormatted(value);
			kHv7FrscUF.SetMessage(defaultInterpolatedStringHandler2.ToStringAndClear());
			KHv7FrscUF.SetProgress((double)num / 100.0);
		}
	}

	private void Ep4jTfM3eL()
	{
		UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4518));
		KHv7FrscUF.SetMessage(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4586));
	}

	private string qd2jOgXL8J(long P_0)
	{
		if (P_0 >= 1073741824)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler.AppendFormatted((double)P_0 / 1073741824.0, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4626));
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4638));
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		if (P_0 >= 1048576)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler2.AppendFormatted((double)P_0 / 1048576.0, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4626));
			defaultInterpolatedStringHandler2.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4648));
			return defaultInterpolatedStringHandler2.ToStringAndClear();
		}
		if (P_0 >= 1024)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler3.AppendFormatted((double)P_0 / 1024.0, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4626));
			defaultInterpolatedStringHandler3.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4658));
			return defaultInterpolatedStringHandler3.ToStringAndClear();
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(2, 1);
		defaultInterpolatedStringHandler4.AppendFormatted(P_0);
		defaultInterpolatedStringHandler4.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4668));
		return defaultInterpolatedStringHandler4.ToStringAndClear();
	}

	private string s6vjN0W1K3(double P_0)
	{
		if (P_0 >= 1048576.0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
			defaultInterpolatedStringHandler.AppendFormatted(P_0 / 1048576.0, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4626));
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4676));
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		if (P_0 >= 1024.0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 1);
			defaultInterpolatedStringHandler2.AppendFormatted(P_0 / 1024.0, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4626));
			defaultInterpolatedStringHandler2.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4690));
			return defaultInterpolatedStringHandler2.ToStringAndClear();
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(4, 1);
		defaultInterpolatedStringHandler3.AppendFormatted(P_0, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4626));
		defaultInterpolatedStringHandler3.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4704));
		return defaultInterpolatedStringHandler3.ToStringAndClear();
	}

	private string tLGjE7lcts(double P_0)
	{
		TimeSpan timeSpan = TimeSpan.FromSeconds(P_0);
		if (timeSpan.TotalHours >= 1.0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 3);
			defaultInterpolatedStringHandler.AppendFormatted((int)timeSpan.TotalHours);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4716));
			defaultInterpolatedStringHandler.AppendFormatted(timeSpan.Minutes);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4716));
			defaultInterpolatedStringHandler.AppendFormatted(timeSpan.Seconds);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4722));
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		if (timeSpan.TotalMinutes >= 1.0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(9, 2);
			defaultInterpolatedStringHandler2.AppendFormatted((int)timeSpan.TotalMinutes);
			defaultInterpolatedStringHandler2.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4716));
			defaultInterpolatedStringHandler2.AppendFormatted(timeSpan.Seconds);
			defaultInterpolatedStringHandler2.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4738));
			return defaultInterpolatedStringHandler2.ToStringAndClear();
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(8, 1);
		defaultInterpolatedStringHandler3.AppendFormatted(timeSpan.Seconds);
		defaultInterpolatedStringHandler3.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4758));
		return defaultInterpolatedStringHandler3.ToStringAndClear();
	}

	[CompilerGenerated]
	private async Task wtXjuf4SxZ()
	{
		if (A3y721A5nJ)
		{
			return;
		}
		A3y721A5nJ = true;
		bool flag = !GIConstant.UsingSSCInstallPath;
		if (flag)
		{
			flag = !(await VGLjLa1sd7());
		}
		if (flag)
		{
			return;
		}
		if (UseGSPro)
		{
			ojFjspQJo1.UninstallGSProLauncher();
			if (!YwE7WbgCfX)
			{
				if (!Op5jzUJXbX.IsNetworkAvailable(0L))
				{
					UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8782), LogLevel.Warning);
				}
				else if (await ojFjspQJo1.VerifyNewGSProVersion())
				{
					Version stableVersion = await ojFjspQJo1.GetGSProStableVersion();
					try
					{
						IDialogCoordinator dialogCoordinator = fhQjH7dMny;
						MainViewModel context = this;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
						defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8904));
						defaultInterpolatedStringHandler.AppendFormatted(stableVersion);
						KHv7FrscUF = await dialogCoordinator.ShowProgressAsync(context, defaultInterpolatedStringHandler.ToStringAndClear(), ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8936));
						await ojFjspQJo1.InstallNewGSProVersion(stableVersion, XXKjxmJqn0, Ep4jTfM3eL);
					}
					finally
					{
						await KHv7FrscUF.CloseAsync();
					}
				}
			}
			if (!(await xJyjY8boMr()))
			{
				return;
			}
		}
		if (mvyjoKRlPo.StartWithGame)
		{
			await h1pjVmJWbG();
		}
		await LGJjdohl3s.LaunchIdra(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8968));
	}

	[CompilerGenerated]
	private async Task Xwcjp2XEmc()
	{
		try
		{
			UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8620));
			if (!OnScreenKeyboard.IsOpened())
			{
				OnScreenKeyboard.Show();
			}
			AOhj6fr5Ol.ModifyWindowState(GkWjbqfXKy.ProcessName, ShowWindowEnum.ShowMaximized, setFocus: true);
		}
		catch (Exception ex)
		{
			await fhQjH7dMny.ShowMessageAsync(this, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6670), ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8694));
			EventViewerLogger.LogException(ex);
			vP1jSBDy5g.NavigateTo(VM.Main);
		}
	}

	[CompilerGenerated]
	private void UUlj0s2efk()
	{
		UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4778));
		Kd5ja7yIbt.Send(new ShowPasswordMessage(PasswordWindowMode.Admin));
		vP1jSBDy5g.NavigateTo(VM.PasswordWindow);
	}

	[CompilerGenerated]
	private void dBeje9Guq6()
	{
		UAmjnZhZWI.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4866));
		if (UseGSPro)
		{
			vP1jSBDy5g.NavigateTo(VM.GSProOptionMenu);
		}
		else
		{
			vP1jSBDy5g.NavigateTo(VM.OptionDialog);
		}
	}
}
