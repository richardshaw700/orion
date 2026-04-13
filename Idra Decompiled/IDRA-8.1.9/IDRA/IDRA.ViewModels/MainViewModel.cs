using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GICTS.Core;
using GICTS.Data;
using GICTSCore.Data;
using GICTSCore.Services;
using GICTSCore.Services.LocalAPI;
using GIToolkit.Services;
using GhU84wwqvI4UZ3pBfu;
using IDRA.Auxiliary.Helpers;
using IDRA.Auxiliary.Messages;
using IDRA.Auxiliary.Navigations;
using IDRA.Services;
using IDRA.Views;
using IDRASharedModels;
using MahApps.Metro.Controls.Dialogs;
using bQB5pwCqu4xfJ9Ly8P;
using sxB8TYTZ87aKuujytY;
using t0vTx3Fu990SMjWIoA;
using xffi3AOjEKFP5hQtL6;
using zJ8L6GrwCFaej1bjN0;

namespace IDRA.ViewModels;

public class MainViewModel : ObservableRecipient, IViewModel
{
	private static class welqJK3cA4ESOYK8MX
	{
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public MainViewModel CcZ0OFTQ6y;

		public IDialogCoordinator FPv0M8659C;

		public Func<Task> uEN0PAcyro;

		public Func<Task> cFn0cODDLE;

		public _003C_003Ec__DisplayClass51_0()
		{
			RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
			base._002Ector();
		}

		internal void fVn0Cpmxh2(bool result)
		{
			ICircularLogService fTxdD6Vfwu = CcZ0OFTQ6y.FTxdD6Vfwu;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 1);
			defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13218));
			defaultInterpolatedStringHandler.AppendFormatted(result);
			defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13310));
			fTxdD6Vfwu.Log(defaultInterpolatedStringHandler.ToStringAndClear());
			CcZ0OFTQ6y.GameProcessIsRunning = result;
			if (result)
			{
				return;
			}
			CcZ0OFTQ6y.TNMdVZ4Glb = IDRAtoIDRAMCommunication.CommunicationCode.NormalClose;
			Application current = Application.Current;
			if (current != null)
			{
				((DispatcherObject)current).Dispatcher.Invoke<Task>((Func<Task>)async delegate
				{
					await (CcZ0OFTQ6y.ExitCommand as AsyncRelayCommand).ExecuteAsync(null);
				});
			}
		}

		internal async Task Dfj00bebwn()
		{
			await (CcZ0OFTQ6y.ExitCommand as AsyncRelayCommand).ExecuteAsync(null);
		}

		internal void kjs07GXLu1(bool result)
		{
			CcZ0OFTQ6y.IsNotReady = !result;
		}

		internal async Task FqM0IdffPI(SimCommandShotCompletedMsg result)
		{
			CcZ0OFTQ6y.IsShotCompleted = true;
			await Task.CompletedTask;
		}

		internal async Task MfL08JSvE8(CTSShotData result)
		{
			CcZ0OFTQ6y.IsShotCompleted = false;
			await Task.CompletedTask;
		}

		internal void gjp0Rwox8k(bool isVisible)
		{
			CcZ0OFTQ6y.IsNotReady = !isVisible;
		}

		internal async Task Vhb0FhkBUx(string selectedCourse)
		{
			await ManagerSettings.Instance.Reload(checkNewProp: false);
			CcZ0OFTQ6y.sQpdH9wUEE(QQXBLjLprwI58ya4VR.y8v8TMFOCb(21216) + selectedCourse);
			await ManagerSettings.Instance.SaveEnablePostShotSetting(ManagerSettings.Instance.UseGolfInPostShotInGame || ManagerSettings.Instance.UseGolfInPostShotInPractice);
			CcZ0OFTQ6y.Gc4dtaN7nc.Send(new tDSRbrcOQu5Paq7lMy(_0020: true));
			await CcZ0OFTQ6y.Ws0dXQG2k3.WriteMessage(IDRAtoIDRAMCommunication.CommunicationCode.IDRAFirstTeeEvent);
		}

		internal void C7H0b1229g()
		{
			((DispatcherObject)Application.Current).Dispatcher.Invoke<Task>((Func<Task>)async delegate
			{
				await FPv0M8659C.ShowMessageAsync(CcZ0OFTQ6y, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12418), QQXBLjLprwI58ya4VR.y8v8TMFOCb(20940));
				CcZ0OFTQ6y.Gf8dp5lEn0.CloseGame(CcZ0OFTQ6y.piXdjevEbf.GetApiGameLaunched()?.LocalAPIGameSettings.ProcessName);
				CcZ0OFTQ6y.piXdjevEbf.Release();
				await CcZ0OFTQ6y.EbKda0CThd(400);
				CcZ0OFTQ6y.woidx5l1h2();
			});
		}

		internal async Task ujK06YxmAt()
		{
			await FPv0M8659C.ShowMessageAsync(CcZ0OFTQ6y, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12418), QQXBLjLprwI58ya4VR.y8v8TMFOCb(20940));
			CcZ0OFTQ6y.Gf8dp5lEn0.CloseGame(CcZ0OFTQ6y.piXdjevEbf.GetApiGameLaunched()?.LocalAPIGameSettings.ProcessName);
			CcZ0OFTQ6y.piXdjevEbf.Release();
			await CcZ0OFTQ6y.EbKda0CThd(400);
			CcZ0OFTQ6y.woidx5l1h2();
		}

		internal void ld30mjIb3S(object o, CcKwZQJNLk6OcZDLLB var)
		{
			CcZ0OFTQ6y.ShowMenu = !CcZ0OFTQ6y.ShowMenu;
			ICircularLogService fTxdD6Vfwu = CcZ0OFTQ6y.FTxdD6Vfwu;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
			defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13316));
			defaultInterpolatedStringHandler.AppendFormatted(CcZ0OFTQ6y.ShowMenu);
			fTxdD6Vfwu.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		internal async void DZt0ug3ZND(object o, fDr9H7RV8uflQdMUH6 obj)
		{
			await CcZ0OFTQ6y.EbKda0CThd(obj.a26CKynuPP());
		}

		internal async Task? jPK0JfAO3K()
		{
			FileProcessCommunication ws0dXQG2k = await FileProcessCommunication.GetInstanceAsync(new IDRAtoIDRAMCommunication(), CcZ0OFTQ6y.FTxdD6Vfwu);
			CcZ0OFTQ6y.Ws0dXQG2k3 = ws0dXQG2k;
			FileProcessCommunication ws0dXQG2k2 = CcZ0OFTQ6y.Ws0dXQG2k3;
			ws0dXQG2k2.OnReceiveMessage = (Func<string, Task>)Delegate.Combine(ws0dXQG2k2.OnReceiveMessage, new Func<string, Task>(CcZ0OFTQ6y.uGQdQjHqFi));
			await Task.Delay(500);
			await CcZ0OFTQ6y.QUYdC28oaF();
		}
	}

	private Thickness VbhdrBaHwU;

	private int YuEdAh3CSy;

	private bool H8edZJ9ijm;

	private bool xBgdlLG4XC;

	private string v6wdkND6B2;

	private string rscd2WSdZm;

	private bool zPhdyeRwM5;

	private bool VC6dgbEwpI;

	private bool NItd4FgheT;

	private IDialogCoordinator zTRd3e67PV;

	private readonly IMessagingService Gc4dtaN7nc;

	private readonly IGICTSDirector piXdjevEbf;

	private readonly INavigationService<VM> l2JdBuuTd7;

	private readonly ICircularLogService FTxdD6Vfwu;

	private readonly CustomShotViewModel aqwde5UPaK;

	private readonly IIdraModeService Gf8dp5lEn0;

	private readonly IProcessHelper HiWd1PI7bw;

	private bool n2idKU8Gpc;

	private bool i4idUnAUXt;

	private int TNMdVZ4Glb;

	private bool mqsdGMYi8Z;

	private FileProcessCommunication Ws0dXQG2k3;

	private A8ra8Pqc1hUiRhYnT0 yyed9w4rFa;

	public Thickness MenuMargin
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return VbhdrBaHwU;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			SetProperty(ref VbhdrBaHwU, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(4196));
		}
	}

	public int MenuWidthHeight
	{
		get
		{
			return YuEdAh3CSy;
		}
		set
		{
			SetProperty(ref YuEdAh3CSy, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(4220));
		}
	}

	public bool GameProcessIsRunning
	{
		get
		{
			return H8edZJ9ijm;
		}
		set
		{
			SetProperty(ref H8edZJ9ijm, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(4254));
		}
	}

	public bool ShowMenu
	{
		get
		{
			return xBgdlLG4XC;
		}
		set
		{
			SetProperty(ref xBgdlLG4XC, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(4298));
		}
	}

	public string PublishVersion
	{
		get
		{
			return v6wdkND6B2;
		}
		set
		{
			SetProperty(ref v6wdkND6B2, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(4318));
		}
	}

	public string ClubTypeToUseBtnContent
	{
		get
		{
			return rscd2WSdZm;
		}
		set
		{
			SetProperty(ref rscd2WSdZm, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(4350));
		}
	}

	public bool UseGSPro
	{
		get
		{
			return zPhdyeRwM5;
		}
		set
		{
			SetProperty(ref zPhdyeRwM5, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(4400));
		}
	}

	public bool IsNotReady
	{
		get
		{
			return VC6dgbEwpI;
		}
		set
		{
			SetProperty(ref VC6dgbEwpI, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(4420));
		}
	}

	public bool IsShotCompleted
	{
		get
		{
			return NItd4FgheT;
		}
		set
		{
			SetProperty(ref NItd4FgheT, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(4444));
		}
	}

	public ICommand ExitCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		try
		{
			if (!n2idKU8Gpc)
			{
				n2idKU8Gpc = true;
				FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13094));
				piXdjevEbf.Release();
				await EbKda0CThd(IDRAtoIDRAMCommunication.CommunicationCode.ACKResetIDRA);
				Application current = Application.Current;
				if (current != null)
				{
					((DispatcherObject)current).Dispatcher.Invoke((Action)delegate
					{
						Gc4dtaN7nc.Send(new CloseApplicationMessage(100));
					});
				}
			}
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
		}
	});

	public ICommand OpenContextMenuCommand => new RelayCommand(delegate
	{
		l2JdBuuTd7.NavigateTo(VM.Password);
	});

	public ICommand ToggleCameraAcquistionCommand => new RelayCommand(delegate
	{
		if (mqsdGMYi8Z)
		{
			piXdjevEbf.ResumeCameraAcquisition();
		}
		else
		{
			piXdjevEbf.PauseCameraAcquisition();
		}
		mqsdGMYi8Z = !mqsdGMYi8Z;
	});

	public ICommand NavigateSettingsCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13158));
		await new GICTSSettingsWrapper().ShowSettings(IDRAConstant.GICTSSettingsFilePath);
		ShowMenu = !ShowMenu;
	});

	public ICommand SendLastShotCommand => new RelayCommand(delegate
	{
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4920));
		piXdjevEbf.SimulateLastShot();
		ShowMenu = !ShowMenu;
	});

	public ICommand GetPlayerDataCommand => new RelayCommand(delegate
	{
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4964));
		piXdjevEbf.GetPlayerData();
		ShowMenu = !ShowMenu;
	});

	public ICommand CloseMenuCommand => new RelayCommand(delegate
	{
		ShowMenu = !ShowMenu;
	});

	public ICommand OpenClubFaceAdjustmentCommand => new RelayCommand(delegate
	{
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5014));
		l2JdBuuTd7.NavigateTo(VM.ClubFaceCorrectionDatatableAdjustment);
		ShowMenu = !ShowMenu;
	});

	public ICommand OpenSpinAdjustmentCommand => new RelayCommand(delegate
	{
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5080));
		l2JdBuuTd7.NavigateTo(VM.SpinDatatableAdjustment);
		ShowMenu = !ShowMenu;
	});

	public ICommand SendCustomShotCommand => new RelayCommand(delegate
	{
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5136));
		CustomShotView customShotView = new CustomShotView();
		((FrameworkElement)customShotView).DataContext = aqwde5UPaK;
		((Window)customShotView).Show();
		if (piXdjevEbf.LastShotSent != null)
		{
			Gc4dtaN7nc.Send(new FillCustomShotMessages(piXdjevEbf.LastShotSent));
		}
		ShowMenu = !ShowMenu;
	});

	public ICommand SendDebugShotCommand => new RelayCommand(delegate
	{
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5204));
		piXdjevEbf.SendDebugAnalyseShot();
		ShowMenu = !ShowMenu;
	});

	public MainViewModel(IDialogCoordinator dialogCoordinator, IMessagingService messagingService, IProcessHelper processHelper, IGICTSDirector gICTSDirector, INavigationService<VM> navigationService, ICircularLogService circularLogService, CustomShotViewModel customShotViewModel, IIdraModeService idraModeService)
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		NItd4FgheT = true;
		TNMdVZ4Glb = -1;
		_003C_003Ec__DisplayClass51_0 CS_0024_003C_003E8__locals31 = new _003C_003Ec__DisplayClass51_0();
		CS_0024_003C_003E8__locals31.FPv0M8659C = dialogCoordinator;
		base._002Ector();
		CS_0024_003C_003E8__locals31.CcZ0OFTQ6y = this;
		zTRd3e67PV = CS_0024_003C_003E8__locals31.FPv0M8659C;
		Gc4dtaN7nc = messagingService;
		HiWd1PI7bw = processHelper;
		piXdjevEbf = gICTSDirector;
		l2JdBuuTd7 = navigationService;
		FTxdD6Vfwu = circularLogService;
		aqwde5UPaK = customShotViewModel;
		Gf8dp5lEn0 = idraModeService;
		UseGSPro = piXdjevEbf.Settings.UseGSPro;
		string value = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyConfigurationAttribute>()?.Configuration ?? QQXBLjLprwI58ya4VR.y8v8TMFOCb(4478);
		string value2 = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? QQXBLjLprwI58ya4VR.y8v8TMFOCb(4496);
		ICircularLogService fTxdD6Vfwu = FTxdD6Vfwu;
		string text = new string('-', 15);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4530));
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4550));
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4562));
		fTxdD6Vfwu.Log(text + defaultInterpolatedStringHandler.ToStringAndClear() + new string('-', 15));
		IGICTSDirector iGICTSDirector = piXdjevEbf;
		iGICTSDirector.OnUIAvailableStatusChange = (Action<bool>)Delegate.Combine(iGICTSDirector.OnUIAvailableStatusChange, (Action<bool>)delegate(bool result)
		{
			ICircularLogService fTxdD6Vfwu2 = CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.FTxdD6Vfwu;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(45, 1);
			defaultInterpolatedStringHandler2.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13218));
			defaultInterpolatedStringHandler2.AppendFormatted(result);
			defaultInterpolatedStringHandler2.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13310));
			fTxdD6Vfwu2.Log(defaultInterpolatedStringHandler2.ToStringAndClear());
			CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.GameProcessIsRunning = result;
			if (!result)
			{
				CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.TNMdVZ4Glb = IDRAtoIDRAMCommunication.CommunicationCode.NormalClose;
				Application current = Application.Current;
				if (current != null)
				{
					((DispatcherObject)current).Dispatcher.Invoke<Task>((Func<Task>)async delegate
					{
						await (CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.ExitCommand as AsyncRelayCommand).ExecuteAsync(null);
					});
				}
			}
		});
		z2udEe5xA7();
		IGICTSDirector iGICTSDirector2 = piXdjevEbf;
		iGICTSDirector2.IdraHasExited = (Func<int, Task>)Delegate.Combine(iGICTSDirector2.IdraHasExited, new Func<int, Task>(EbKda0CThd));
		IGICTSDirector iGICTSDirector3 = piXdjevEbf;
		iGICTSDirector3.OnGolfLocalAPIArmed = (Action)Delegate.Combine(iGICTSDirector3.OnGolfLocalAPIArmed, new Action(qOXdqsbIqA));
		IGICTSDirector iGICTSDirector4 = piXdjevEbf;
		iGICTSDirector4.IsReadyNotReadySignal = (Action<bool>)Delegate.Combine(iGICTSDirector4.IsReadyNotReadySignal, (Action<bool>)delegate(bool result)
		{
			CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.IsNotReady = !result;
		});
		IGICTSDirector iGICTSDirector5 = piXdjevEbf;
		iGICTSDirector5.OnShotReceiveFromGame = (Func<SimCommandShotCompletedMsg, Task>)Delegate.Combine(iGICTSDirector5.OnShotReceiveFromGame, (Func<SimCommandShotCompletedMsg, Task>)async delegate
		{
			CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.IsShotCompleted = true;
			await Task.CompletedTask;
		});
		IGICTSDirector iGICTSDirector6 = piXdjevEbf;
		iGICTSDirector6.OnNewShotSent = (Func<CTSShotData, Task>)Delegate.Combine(iGICTSDirector6.OnNewShotSent, (Func<CTSShotData, Task>)async delegate
		{
			CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.IsShotCompleted = false;
			await Task.CompletedTask;
		});
		IGICTSDirector iGICTSDirector7 = piXdjevEbf;
		iGICTSDirector7.OnGSPROOSKVisible = (Action<bool>)Delegate.Combine(iGICTSDirector7.OnGSPROOSKVisible, (Action<bool>)delegate(bool isVisible)
		{
			CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.IsNotReady = !isVisible;
		});
		IGICTSDirector iGICTSDirector8 = piXdjevEbf;
		iGICTSDirector8.OnFirstTee = (Func<string, Task>)Delegate.Combine(iGICTSDirector8.OnFirstTee, (Func<string, Task>)async delegate(string selectedCourse)
		{
			await ManagerSettings.Instance.Reload(checkNewProp: false);
			CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.sQpdH9wUEE(QQXBLjLprwI58ya4VR.y8v8TMFOCb(21216) + selectedCourse);
			await ManagerSettings.Instance.SaveEnablePostShotSetting(ManagerSettings.Instance.UseGolfInPostShotInGame || ManagerSettings.Instance.UseGolfInPostShotInPractice);
			CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.Gc4dtaN7nc.Send(new tDSRbrcOQu5Paq7lMy(_0020: true));
			await CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.Ws0dXQG2k3.WriteMessage(IDRAtoIDRAMCommunication.CommunicationCode.IDRAFirstTeeEvent);
		});
		IGICTSDirector iGICTSDirector9 = piXdjevEbf;
		iGICTSDirector9.OnMissingCalibrationForConnectedIDRA = (Action)Delegate.Combine(iGICTSDirector9.OnMissingCalibrationForConnectedIDRA, (Action)delegate
		{
			((DispatcherObject)Application.Current).Dispatcher.Invoke<Task>((Func<Task>)async delegate
			{
				await CS_0024_003C_003E8__locals31.FPv0M8659C.ShowMessageAsync(CS_0024_003C_003E8__locals31.CcZ0OFTQ6y, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12418), QQXBLjLprwI58ya4VR.y8v8TMFOCb(20940));
				CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.Gf8dp5lEn0.CloseGame(CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.piXdjevEbf.GetApiGameLaunched()?.LocalAPIGameSettings.ProcessName);
				CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.piXdjevEbf.Release();
				await CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.EbKda0CThd(400);
				CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.woidx5l1h2();
			});
		});
		Jmcd0p2wod();
		Gc4dtaN7nc.Register<CcKwZQJNLk6OcZDLLB>(this, delegate
		{
			CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.ShowMenu = !CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.ShowMenu;
			ICircularLogService fTxdD6Vfwu2 = CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.FTxdD6Vfwu;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(23, 1);
			defaultInterpolatedStringHandler2.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13316));
			defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.ShowMenu);
			fTxdD6Vfwu2.Log(defaultInterpolatedStringHandler2.ToStringAndClear());
		});
		Gc4dtaN7nc.Register(this, async delegate(object o, fDr9H7RV8uflQdMUH6 obj)
		{
			await CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.EbKda0CThd(obj.a26CKynuPP());
		});
		try
		{
			using Process process = HiWd1PI7bw.GetProcessByName(gICTSDirector.GetApiGameLaunched().LocalAPIGameSettings.ProcessName);
			GameProcessIsRunning = process != null;
		}
		catch (Exception ex)
		{
			GameProcessIsRunning = false;
			FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4568) + ex.Message, LogLevel.Error);
			EventViewerLogger.LogException(ex);
		}
		PublishVersion = Helper.GetAssemblyVersion();
		ClubTypeToUseBtnContent = QQXBLjLprwI58ya4VR.y8v8TMFOCb(4766);
		Task.Run(async delegate
		{
			FileProcessCommunication ws0dXQG2k = await FileProcessCommunication.GetInstanceAsync(new IDRAtoIDRAMCommunication(), CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.FTxdD6Vfwu);
			CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.Ws0dXQG2k3 = ws0dXQG2k;
			FileProcessCommunication ws0dXQG2k2 = CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.Ws0dXQG2k3;
			ws0dXQG2k2.OnReceiveMessage = (Func<string, Task>)Delegate.Combine(ws0dXQG2k2.OnReceiveMessage, new Func<string, Task>(CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.uGQdQjHqFi));
			await Task.Delay(500);
			await CS_0024_003C_003E8__locals31.CcZ0OFTQ6y.QUYdC28oaF();
		});
		if (ManagerSettings.Instance.UseAutoTee)
		{
			yyed9w4rFa = new A8ra8Pqc1hUiRhYnT0(FTxdD6Vfwu);
			A8ra8Pqc1hUiRhYnT0 a8ra8Pqc1hUiRhYnT = yyed9w4rFa;
			a8ra8Pqc1hUiRhYnT.xT5aTL9PoE = (Action<AutoTeeMoveSide>)Delegate.Combine(a8ra8Pqc1hUiRhYnT.xT5aTL9PoE, new Action<AutoTeeMoveSide>(SKHddwjZJi));
			yyed9w4rFa.bQyaVRKmTe();
		}
	}

	private void woidx5l1h2()
	{
		string text = Path.Combine(GIConstant.SSCInstallPath, IDRAConstant.IDRACalibrationProgramFolderName, IDRAConstant.IDRACalibrationProcess);
		if (File.Exists(text))
		{
			Process.Start(new ProcessStartInfo(text));
		}
	}

	private void SKHddwjZJi(AutoTeeMoveSide P_0)
	{
		if (P_0 == AutoTeeMoveSide.Left)
		{
			piXdjevEbf.SendAutoTeeBallMovementLeft();
		}
		else
		{
			piXdjevEbf.SendAutoTeeBallMovementRight();
		}
	}

	private void sQpdH9wUEE(string P_0)
	{
		try
		{
			FTxdD6Vfwu.Log(P_0);
			FTxdD6Vfwu.Log(MetricService.GetRAMInfo());
			FTxdD6Vfwu.Log(MetricService.GetRAMInfo(piXdjevEbf.GetApiGameLaunched().LocalAPIGameSettings.ProcessName));
			FTxdD6Vfwu.Log(MetricService.GetVRAMNividiaInfo());
		}
		catch (Exception ex)
		{
			FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4786) + ex.Message, LogLevel.Error);
		}
	}

	private void z2udEe5xA7()
	{
		if (piXdjevEbf.GetApiGameLaunched() is GSProAPIService gSProAPIService)
		{
			gSProAPIService.OnGSProHasExited = (Action)Delegate.Combine(gSProAPIService.OnGSProHasExited, (Action)async delegate
			{
				await (ExitCommand as AsyncRelayCommand).ExecuteAsync(null);
			});
		}
	}

	private async Task uGQdQjHqFi(string P_0)
	{
		if (string.IsNullOrWhiteSpace(P_0))
		{
			return;
		}
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13542) + P_0);
		try
		{
			if (!int.TryParse(new Regex(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13654)).Matches(P_0)[0].Value, out var result))
			{
				FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13664), LogLevel.Warning);
				return;
			}
			if (result == IDRAtoIDRAMCommunication.CommunicationCode.ResetIDRA)
			{
				ExitCommand.Execute(null);
			}
			else if (result == IDRAtoIDRAMCommunication.CommunicationCode.OpenShotAnalyser)
			{
				if (piXdjevEbf.LastShotSent == null)
				{
					await zTRd3e67PV.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(11358), QQXBLjLprwI58ya4VR.y8v8TMFOCb(13732));
				}
				else
				{
					Gc4dtaN7nc.Send(new NavigatePostShotViewMessage(disableAutoContinueTimer: true));
				}
			}
			else if (result == IDRAtoIDRAMCommunication.CommunicationCode.IDRAMonitorUpdateManagerSettings)
			{
				await ManagerSettings.Instance.Reload();
			}
			else if (result == IDRAtoIDRAMCommunication.CommunicationCode.IDRAMonitorEnablePostShot)
			{
				ManagerSettings.Instance.UseGolfInPostShotInGame = true;
				ManagerSettings.Instance.UseGolfInPostShotInPractice = true;
				Gc4dtaN7nc.Send(new tDSRbrcOQu5Paq7lMy(_0020: true));
			}
			else if (result == IDRAtoIDRAMCommunication.CommunicationCode.IDRAMonitorDisablePostShot)
			{
				ManagerSettings.Instance.UseGolfInPostShotInGame = false;
				ManagerSettings.Instance.UseGolfInPostShotInPractice = false;
			}
			Gc4dtaN7nc.Send(new tDSRbrcOQu5Paq7lMy(_0020: false));
		}
		catch (Exception ex)
		{
			FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13788) + P_0, LogLevel.Error);
			EventViewerLogger.LogException(ex);
		}
	}

	private async Task EbKda0CThd(int P_0)
	{
		ICircularLogService fTxdD6Vfwu = FTxdD6Vfwu;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(58, 1);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13898));
		defaultInterpolatedStringHandler.AppendFormatted(P_0);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(14012));
		fTxdD6Vfwu.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(14022));
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(14140));
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(14238));
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(14330));
		if (TNMdVZ4Glb != -1)
		{
			ICircularLogService fTxdD6Vfwu2 = FTxdD6Vfwu;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(38, 1);
			defaultInterpolatedStringHandler2.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(14492));
			defaultInterpolatedStringHandler2.AppendFormatted(TNMdVZ4Glb);
			defaultInterpolatedStringHandler2.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(14012));
			fTxdD6Vfwu2.Log(defaultInterpolatedStringHandler2.ToStringAndClear());
			P_0 = TNMdVZ4Glb;
			TNMdVZ4Glb = -1;
		}
		await Ws0dXQG2k3.WriteMessage(P_0);
		Application current = Application.Current;
		if (current != null)
		{
			((DispatcherObject)current).Dispatcher.Invoke((Action)delegate
			{
				Gc4dtaN7nc.Send(new CloseApplicationMessage(100));
			});
		}
	}

	private void qOXdqsbIqA()
	{
		HiWd1PI7bw.ModifyWindowState(IDRAConstant.IdraProcessName, ShowWindowEnum.ShowDefault, setFocus: true);
		Jmcd0p2wod();
	}

	private async Task QUYdC28oaF()
	{
		ICircularLogService fTxdD6Vfwu = FTxdD6Vfwu;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 1);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13366));
		defaultInterpolatedStringHandler.AppendFormatted(i4idUnAUXt);
		fTxdD6Vfwu.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		if (i4idUnAUXt)
		{
			return;
		}
		i4idUnAUXt = true;
		try
		{
			await piXdjevEbf.Launch();
		}
		catch (Exception ex)
		{
			FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13464) + ex.Message, LogLevel.Error);
			EventViewerLogger.LogException(ex);
		}
		finally
		{
			i4idUnAUXt = false;
		}
	}

	private void Jmcd0p2wod()
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		double fullPrimaryScreenHeight = SystemParameters.FullPrimaryScreenHeight;
		double fullPrimaryScreenWidth = SystemParameters.FullPrimaryScreenWidth;
		MenuMargin = (UseGSPro ? new Thickness(0.0, fullPrimaryScreenHeight * 0.02337, fullPrimaryScreenWidth / 1.73, 0.0) : new Thickness(0.0, fullPrimaryScreenHeight * 0.03343, fullPrimaryScreenWidth * (15.0 / 128.0), 0.0));
		MenuWidthHeight = (UseGSPro ? 55 : 50);
	}

	[CompilerGenerated]
	private async void YAhd7lVLVP()
	{
		await (ExitCommand as AsyncRelayCommand).ExecuteAsync(null);
	}

	[CompilerGenerated]
	private void raOdIAcHK7()
	{
		Gc4dtaN7nc.Send(new CloseApplicationMessage(100));
	}

	[CompilerGenerated]
	private async Task lHOd8MYdDM()
	{
		try
		{
			if (n2idKU8Gpc)
			{
				return;
			}
			n2idKU8Gpc = true;
			FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13094));
			piXdjevEbf.Release();
			await EbKda0CThd(IDRAtoIDRAMCommunication.CommunicationCode.ACKResetIDRA);
			Application current = Application.Current;
			if (current != null)
			{
				((DispatcherObject)current).Dispatcher.Invoke((Action)delegate
				{
					Gc4dtaN7nc.Send(new CloseApplicationMessage(100));
				});
			}
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
		}
	}

	[CompilerGenerated]
	private void o9XdRrKxh2()
	{
		Gc4dtaN7nc.Send(new CloseApplicationMessage(100));
	}

	[CompilerGenerated]
	private void e98dFtSI1F()
	{
		l2JdBuuTd7.NavigateTo(VM.Password);
	}

	[CompilerGenerated]
	private void QnZdburldA()
	{
		if (mqsdGMYi8Z)
		{
			piXdjevEbf.ResumeCameraAcquisition();
		}
		else
		{
			piXdjevEbf.PauseCameraAcquisition();
		}
		mqsdGMYi8Z = !mqsdGMYi8Z;
	}

	[CompilerGenerated]
	private async Task eZAd6nQ8Ik()
	{
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13158));
		await new GICTSSettingsWrapper().ShowSettings(IDRAConstant.GICTSSettingsFilePath);
		ShowMenu = !ShowMenu;
	}

	[CompilerGenerated]
	private void VfmdmfCKbu()
	{
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4920));
		piXdjevEbf.SimulateLastShot();
		ShowMenu = !ShowMenu;
	}

	[CompilerGenerated]
	private void vmIdu5onEK()
	{
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4964));
		piXdjevEbf.GetPlayerData();
		ShowMenu = !ShowMenu;
	}

	[CompilerGenerated]
	private void UP6dJ5fs6n()
	{
		ShowMenu = !ShowMenu;
	}

	[CompilerGenerated]
	private void mspdOV9S1r()
	{
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5014));
		l2JdBuuTd7.NavigateTo(VM.ClubFaceCorrectionDatatableAdjustment);
		ShowMenu = !ShowMenu;
	}

	[CompilerGenerated]
	private void GCSdM50GAw()
	{
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5080));
		l2JdBuuTd7.NavigateTo(VM.SpinDatatableAdjustment);
		ShowMenu = !ShowMenu;
	}

	[CompilerGenerated]
	private void h8GdPo2SJp()
	{
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5136));
		CustomShotView customShotView = new CustomShotView();
		((FrameworkElement)customShotView).DataContext = aqwde5UPaK;
		((Window)customShotView).Show();
		if (piXdjevEbf.LastShotSent != null)
		{
			Gc4dtaN7nc.Send(new FillCustomShotMessages(piXdjevEbf.LastShotSent));
		}
		ShowMenu = !ShowMenu;
	}

	[CompilerGenerated]
	private void LpcdcAfq14()
	{
		FTxdD6Vfwu.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5204));
		piXdjevEbf.SendDebugAnalyseShot();
		ShowMenu = !ShowMenu;
	}
}
