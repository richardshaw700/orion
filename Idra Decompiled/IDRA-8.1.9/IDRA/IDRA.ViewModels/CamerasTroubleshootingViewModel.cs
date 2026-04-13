using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DRn49vdRLT7e1qC615;
using GICTS.Core;
using GICTSCore.Data;
using GICTSCore.Services;
using GIToolkit.Services;
using GhU84wwqvI4UZ3pBfu;
using IDRA.Auxiliary.Helpers;
using IDRA.Auxiliary.Navigations;
using IDRA.Internationalization;
using IDRA.Views.Shared;
using MahApps.Metro.Controls.Dialogs;
using sxB8TYTZ87aKuujytY;
using t0vTx3Fu990SMjWIoA;

namespace IDRA.ViewModels;

public class CamerasTroubleshootingViewModel : ObservableRecipient, IViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public CamerasTroubleshootingViewModel DAO0HwjDIV;

		public Bc1oFQxb497DIFVleV D9t0EmD7LG;

		public _003C_003Ec__DisplayClass40_0()
		{
			RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
			base._002Ector();
		}

		internal void Ab40sAUajy()
		{
			DAO0HwjDIV.A0TxdNT5Do();
			if (D9t0EmD7LG.Yo0WUPlIX)
			{
				DAO0HwjDIV.v5PxmuSmXq.NavigateTo(VM.Main);
			}
		}

		internal async void mrm0xrUqBF()
		{
			if (!D9t0EmD7LG.djroV91nw || await DAO0HwjDIV.ByXxOTa2KO.ShowMessageAsync(DAO0HwjDIV, Resources.Warning, Resources.AreSureExitLooseProgressionWarning, MessageDialogStyle.AffirmativeAndNegative) != MessageDialogResult.Negative)
			{
				DAO0HwjDIV.Y9yxuNXRQQ.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20844));
				DAO0HwjDIV.KfHxbMvjJO.Send(new fDr9H7RV8uflQdMUH6(IDRAtoIDRAMCommunication.CommunicationCode.NormalClose));
				DAO0HwjDIV.v5PxmuSmXq.NavigateTo(VM.Main);
				DAO0HwjDIV.oBUxMl6oTY.CloseGame(DAO0HwjDIV.Vyjx6W5dGr.GetApiGameLaunched()?.LocalAPIGameSettings.ProcessName);
			}
		}

		internal void l1Z0diLdIJ()
		{
			DAO0HwjDIV.WarningMessageModal.Title = Resources.Warning;
			DAO0HwjDIV.WarningMessageModal.Message = Resources.ResourceManager.GetString(D9t0EmD7LG.l1WiUoIGQ);
			DAO0HwjDIV.WarningMessageModal.AffirmativeText = Resources.ResourceManager.GetString(D9t0EmD7LG.rXJnbM57n);
			DAO0HwjDIV.WarningMessageModal.NegativeText = Resources.Exit;
		}
	}

	private CameraTroubleshootModel LZJx00qqvp;

	private CameraTroubleshootModel Mngx7Jf7Gu;

	private GICustomMessage jqIxI6vm38;

	private bool LCrx8oL4F2;

	private string BexxR1w472;

	private ModalName neXxFUCwIw;

	private readonly IMessagingService KfHxbMvjJO;

	private readonly IGICTSDirector Vyjx6W5dGr;

	private readonly INavigationService<VM> v5PxmuSmXq;

	private readonly ICircularLogService Y9yxuNXRQQ;

	private readonly IXmlHelper OxGxJcuSC2;

	private readonly IDialogCoordinator ByXxOTa2KO;

	private readonly IIdraModeService oBUxMl6oTY;

	private bool U1YxPhSCqO;

	private bool WqjxcocaK7;

	private bool dLlxrs1tZZ;

	public CameraTroubleshootModel Camera1
	{
		get
		{
			return LZJx00qqvp;
		}
		set
		{
			SetProperty(ref LZJx00qqvp, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(2730));
		}
	}

	public CameraTroubleshootModel Camera2
	{
		get
		{
			return Mngx7Jf7Gu;
		}
		set
		{
			SetProperty(ref Mngx7Jf7Gu, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(2748));
		}
	}

	public GICustomMessage WarningMessageModal
	{
		get
		{
			return jqIxI6vm38;
		}
		set
		{
			SetProperty(ref jqIxI6vm38, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(2766));
		}
	}

	public bool AreCameraConnectionSuccess
	{
		get
		{
			if (Camera1.Status && Camera2.Status)
			{
				if (!IsWarningMessageModalNotDisplay)
				{
					WarningMessageModal.AffirmativeBtnIsEnabled = true;
				}
				Task.Factory.StartNew((Func<Task>)sBgzEsoHq);
				return true;
			}
			return false;
		}
	}

	public bool IsInDeviceReset
	{
		get
		{
			return LCrx8oL4F2;
		}
		set
		{
			SetProperty(ref LCrx8oL4F2, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(2808));
		}
	}

	public string TroubleshootCode
	{
		get
		{
			return BexxR1w472;
		}
		set
		{
			SetProperty(ref BexxR1w472, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(2842));
		}
	}

	public string CurrentCultureName => Helper.GetReverseCulture();

	public bool IsWarningMessageModalNotDisplay => WarningMessageModal == null;

	public ICommand SimulateCamChange => new AsyncRelayCommand<string>(async delegate(string? codeStr)
	{
		int num = int.Parse(codeStr);
		switch (num)
		{
		case 401:
			await vPPxssOuit(num, string.Empty, _0020: false);
			break;
		case 402:
			await vPPxssOuit(num, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12026), _0020: true);
			break;
		case 403:
			await vPPxssOuit(num, "", _0020: false);
			break;
		case 4031:
			await vPPxssOuit(num, "", _0020: false);
			break;
		case 404:
			await vPPxssOuit(num, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12026), _0020: false);
			break;
		case 4041:
			await vPPxssOuit(num, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12026), _0020: false);
			break;
		case 205:
			await vPPxssOuit(num, "", _0020: true);
			break;
		}
	});

	public ICommand ExitCommand => new RelayCommand(delegate
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		F8CxxNiWB4(ModalName.ExitingModal, new Bc1oFQxb497DIFVleV
		{
			l1WiUoIGQ = QQXBLjLprwI58ya4VR.y8v8TMFOCb(3060),
			rXJnbM57n = QQXBLjLprwI58ya4VR.y8v8TMFOCb(3130),
			J68fgGsK0 = true,
			AffirmativeBtnVisibility = (Visibility)0,
			Yo0WUPlIX = false,
			djroV91nw = false,
			req5sijv5 = 0
		});
	});

	public ICommand ChangeLanguageCommand => new RelayCommand(delegate
	{
		Helper.ToggleUILanguage();
		OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3180));
	});

	public CamerasTroubleshootingViewModel(IMessagingService messagingService, IGICTSDirector gICTSDirector, INavigationService<VM> navigationService, ICircularLogService circularLogService, IXmlHelper xmlHelper, IDialogCoordinator dialogCoordinator, IIdraModeService idraModeService)
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		neXxFUCwIw = ModalName.Unknown;
		base._002Ector();
		KfHxbMvjJO = messagingService;
		Vyjx6W5dGr = gICTSDirector;
		v5PxmuSmXq = navigationService;
		Y9yxuNXRQQ = circularLogService;
		OxGxJcuSC2 = xmlHelper;
		ByXxOTa2KO = dialogCoordinator;
		oBUxMl6oTY = idraModeService;
		Camera1 = new CameraTroubleshootModel
		{
			SN = string.Empty,
			IsDetected = false,
			IsUSBSuperSpeed = false,
			CameraLightIsOpen = false
		};
		Camera2 = new CameraTroubleshootModel
		{
			SN = string.Empty,
			IsDetected = false,
			IsUSBSuperSpeed = false,
			CameraLightIsOpen = false
		};
		IGICTSDirector vyjx6W5dGr = Vyjx6W5dGr;
		vyjx6W5dGr.OnCamErrorCode = (Func<int, string, bool, Task>)Delegate.Combine(vyjx6W5dGr.OnCamErrorCode, new Func<int, string, bool, Task>(vPPxssOuit));
		IGICTSDirector vyjx6W5dGr2 = Vyjx6W5dGr;
		vyjx6W5dGr2.OnRefreshIDRAConfiguration = (Action)Delegate.Combine(vyjx6W5dGr2.OnRefreshIDRAConfiguration, (Action)async delegate
		{
			await PoixHqVpSO();
		});
	}

	private async Task sBgzEsoHq()
	{
		try
		{
			if (!WqjxcocaK7)
			{
				WqjxcocaK7 = true;
				await Helper.PlayAudioFileAsync(IDRAConstant.SuccessSoundPath);
			}
		}
		catch
		{
		}
		finally
		{
			WqjxcocaK7 = false;
		}
	}

	private async Task vPPxssOuit(int P_0, string P_1, bool P_2)
	{
		bool IsNavOnThisPage = v5PxmuSmXq.CurrentPage() == VM.CameraTroubleshooting;
		if (!IsNavOnThisPage && P_0 == 205)
		{
			return;
		}
		if (!U1YxPhSCqO)
		{
			await PoixHqVpSO();
			U1YxPhSCqO = true;
		}
		if (!dLlxrs1tZZ)
		{
			return;
		}
		if (!IsNavOnThisPage)
		{
			v5PxmuSmXq.NavigateTo(VM.CameraTroubleshooting);
		}
		IsInDeviceReset = P_0.ToString().EndsWith('1') && P_0.ToString().Length == 4;
		if (neXxFUCwIw == ModalName.TurnOnCameraLightModal)
		{
			if (P_0 == 205)
			{
				v5PxmuSmXq.NavigateTo(VM.Main);
			}
			else
			{
				A0TxdNT5Do();
			}
		}
		CameraTroubleshootModel camera = Camera1;
		camera.IsDetected = P_0 switch
		{
			401 => false, 
			402 => Camera1.SN == P_1, 
			_ => true, 
		};
		camera = Camera1;
		bool isUSBSuperSpeed;
		switch (P_0)
		{
		case 401:
			isUSBSuperSpeed = false;
			break;
		case 402:
			isUSBSuperSpeed = Camera1.SN == P_1 && P_2;
			break;
		case 403:
		case 4031:
			isUSBSuperSpeed = false;
			break;
		case 404:
		case 4041:
			isUSBSuperSpeed = !(Camera1.SN == P_1);
			break;
		default:
			isUSBSuperSpeed = true;
			break;
		}
		camera.IsUSBSuperSpeed = isUSBSuperSpeed;
		camera = Camera2;
		camera.IsDetected = P_0 switch
		{
			401 => false, 
			402 => Camera2.SN == P_1, 
			_ => true, 
		};
		camera = Camera2;
		switch (P_0)
		{
		case 401:
			isUSBSuperSpeed = false;
			break;
		case 402:
			isUSBSuperSpeed = Camera2.SN == P_1 && P_2;
			break;
		case 403:
		case 4031:
			isUSBSuperSpeed = false;
			break;
		case 404:
		case 4041:
			isUSBSuperSpeed = !(Camera2.SN == P_1);
			break;
		default:
			isUSBSuperSpeed = true;
			break;
		}
		camera.IsUSBSuperSpeed = isUSBSuperSpeed;
		camera = Camera1;
		switch (P_0)
		{
		case 405:
		case 4051:
			isUSBSuperSpeed = false;
			break;
		case 205:
			isUSBSuperSpeed = true;
			break;
		default:
			isUSBSuperSpeed = Camera1.CameraLightIsOpen;
			break;
		}
		camera.CameraLightIsOpen = isUSBSuperSpeed;
		camera = Camera2;
		switch (P_0)
		{
		case 405:
		case 4051:
			isUSBSuperSpeed = false;
			break;
		case 205:
			isUSBSuperSpeed = true;
			break;
		default:
			isUSBSuperSpeed = Camera2.CameraLightIsOpen;
			break;
		}
		camera.CameraLightIsOpen = isUSBSuperSpeed;
		CamerasTroubleshootingViewModel camerasTroubleshootingViewModel = this;
		object troubleshootCode;
		if (string.IsNullOrWhiteSpace(P_1))
		{
			troubleshootCode = $"{P_0}";
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(12776));
			defaultInterpolatedStringHandler.AppendFormatted(new string(P_1.TakeLast(3).ToArray()));
			troubleshootCode = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		camerasTroubleshootingViewModel.TroubleshootCode = (string)troubleshootCode;
		if (P_0 == 405 && WarningMessageModal == null)
		{
			((DispatcherObject)Application.Current).Dispatcher.Invoke((Action)delegate
			{
				//IL_0037: Unknown result type (might be due to invalid IL or missing references)
				F8CxxNiWB4(ModalName.TurnOnCameraLightModal, new Bc1oFQxb497DIFVleV
				{
					l1WiUoIGQ = QQXBLjLprwI58ya4VR.y8v8TMFOCb(2980),
					rXJnbM57n = QQXBLjLprwI58ya4VR.y8v8TMFOCb(3032),
					J68fgGsK0 = false,
					AffirmativeBtnVisibility = (Visibility)2,
					Yo0WUPlIX = true,
					djroV91nw = true,
					req5sijv5 = 30000
				});
			});
		}
		OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2730));
		OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2748));
		OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(12782));
		if (AreCameraConnectionSuccess)
		{
			await Task.Delay(1000);
			v5PxmuSmXq.NavigateTo(VM.Main);
		}
	}

	private void F8CxxNiWB4(ModalName P_0, Bc1oFQxb497DIFVleV P_1)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass40_0 CS_0024_003C_003E8__locals24 = new _003C_003Ec__DisplayClass40_0();
		CS_0024_003C_003E8__locals24.DAO0HwjDIV = this;
		CS_0024_003C_003E8__locals24.D9t0EmD7LG = P_1;
		neXxFUCwIw = P_0;
		WarningMessageModal = new GICustomMessage(CS_0024_003C_003E8__locals24.D9t0EmD7LG.req5sijv5)
		{
			Title = Resources.Warning,
			Message = Resources.ResourceManager.GetString(CS_0024_003C_003E8__locals24.D9t0EmD7LG.l1WiUoIGQ),
			AffirmativeText = Resources.ResourceManager.GetString(CS_0024_003C_003E8__locals24.D9t0EmD7LG.rXJnbM57n),
			AffirmativeBtnColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2878))),
			NegativeText = Resources.Exit,
			NegativeBtnColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2896))),
			AffirmativeBtnIsEnabled = CS_0024_003C_003E8__locals24.D9t0EmD7LG.J68fgGsK0,
			AffirmativeBtnVisibility = CS_0024_003C_003E8__locals24.D9t0EmD7LG.AffirmativeBtnVisibility
		};
		GICustomMessage warningMessageModal = WarningMessageModal;
		warningMessageModal.OnAffirmativeClick = (Action)Delegate.Combine(warningMessageModal.OnAffirmativeClick, (Action)delegate
		{
			CS_0024_003C_003E8__locals24.DAO0HwjDIV.A0TxdNT5Do();
			if (CS_0024_003C_003E8__locals24.D9t0EmD7LG.Yo0WUPlIX)
			{
				CS_0024_003C_003E8__locals24.DAO0HwjDIV.v5PxmuSmXq.NavigateTo(VM.Main);
			}
		});
		GICustomMessage warningMessageModal2 = WarningMessageModal;
		warningMessageModal2.OnNegativeClick = (Action)Delegate.Combine(warningMessageModal2.OnNegativeClick, (Action)async delegate
		{
			if (!CS_0024_003C_003E8__locals24.D9t0EmD7LG.djroV91nw || await CS_0024_003C_003E8__locals24.DAO0HwjDIV.ByXxOTa2KO.ShowMessageAsync(CS_0024_003C_003E8__locals24.DAO0HwjDIV, Resources.Warning, Resources.AreSureExitLooseProgressionWarning, MessageDialogStyle.AffirmativeAndNegative) != MessageDialogResult.Negative)
			{
				CS_0024_003C_003E8__locals24.DAO0HwjDIV.Y9yxuNXRQQ.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20844));
				CS_0024_003C_003E8__locals24.DAO0HwjDIV.KfHxbMvjJO.Send(new fDr9H7RV8uflQdMUH6(IDRAtoIDRAMCommunication.CommunicationCode.NormalClose));
				CS_0024_003C_003E8__locals24.DAO0HwjDIV.v5PxmuSmXq.NavigateTo(VM.Main);
				CS_0024_003C_003E8__locals24.DAO0HwjDIV.oBUxMl6oTY.CloseGame(CS_0024_003C_003E8__locals24.DAO0HwjDIV.Vyjx6W5dGr.GetApiGameLaunched()?.LocalAPIGameSettings.ProcessName);
			}
		});
		GICustomMessage warningMessageModal3 = WarningMessageModal;
		warningMessageModal3.OnChangeLanguage = (Action)Delegate.Combine(warningMessageModal3.OnChangeLanguage, (Action)delegate
		{
			CS_0024_003C_003E8__locals24.DAO0HwjDIV.WarningMessageModal.Title = Resources.Warning;
			CS_0024_003C_003E8__locals24.DAO0HwjDIV.WarningMessageModal.Message = Resources.ResourceManager.GetString(CS_0024_003C_003E8__locals24.D9t0EmD7LG.l1WiUoIGQ);
			CS_0024_003C_003E8__locals24.DAO0HwjDIV.WarningMessageModal.AffirmativeText = Resources.ResourceManager.GetString(CS_0024_003C_003E8__locals24.D9t0EmD7LG.rXJnbM57n);
			CS_0024_003C_003E8__locals24.DAO0HwjDIV.WarningMessageModal.NegativeText = Resources.Exit;
		});
		OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2914));
	}

	private void A0TxdNT5Do()
	{
		WarningMessageModal = null;
		OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2914));
	}

	private async Task PoixHqVpSO()
	{
		try
		{
			await OxGxJcuSC2.LoadXmlDocument(IDRAConstant.IdraConfigurationFilePath());
			Camera1.SN = OxGxJcuSC2.ReadNodeValue<string>(QQXBLjLprwI58ya4VR.y8v8TMFOCb(12052));
			Camera2.SN = OxGxJcuSC2.ReadNodeValue<string>(QQXBLjLprwI58ya4VR.y8v8TMFOCb(12124));
			dLlxrs1tZZ = OxGxJcuSC2.ReadNodeValue<bool>(QQXBLjLprwI58ya4VR.y8v8TMFOCb(12196));
		}
		catch (Exception ex) when (((ex is FileNotFoundException || ex is FileLoadException) ? 1 : 0) != 0)
		{
			Y9yxuNXRQQ.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(12264) + ex.Message + QQXBLjLprwI58ya4VR.y8v8TMFOCb(12330), LogLevel.Warning);
		}
		catch (Exception ex2)
		{
			await ByXxOTa2KO.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12418), QQXBLjLprwI58ya4VR.y8v8TMFOCb(12432));
			Y9yxuNXRQQ.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(12692) + ex2.Message);
		}
	}

	[CompilerGenerated]
	private async void j5yxE7Dsqj()
	{
		await PoixHqVpSO();
	}

	[CompilerGenerated]
	private void QLdxQjxF7c()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		F8CxxNiWB4(ModalName.TurnOnCameraLightModal, new Bc1oFQxb497DIFVleV
		{
			l1WiUoIGQ = QQXBLjLprwI58ya4VR.y8v8TMFOCb(2980),
			rXJnbM57n = QQXBLjLprwI58ya4VR.y8v8TMFOCb(3032),
			J68fgGsK0 = false,
			AffirmativeBtnVisibility = (Visibility)2,
			Yo0WUPlIX = true,
			djroV91nw = true,
			req5sijv5 = 30000
		});
	}

	[CompilerGenerated]
	private async Task CsKxanI5Io(string? codeStr)
	{
		int num = int.Parse(codeStr);
		switch (num)
		{
		case 401:
			await vPPxssOuit(num, string.Empty, _0020: false);
			break;
		case 402:
			await vPPxssOuit(num, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12026), _0020: true);
			break;
		case 403:
			await vPPxssOuit(num, "", _0020: false);
			break;
		case 4031:
			await vPPxssOuit(num, "", _0020: false);
			break;
		case 404:
			await vPPxssOuit(num, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12026), _0020: false);
			break;
		case 4041:
			await vPPxssOuit(num, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12026), _0020: false);
			break;
		case 205:
			await vPPxssOuit(num, "", _0020: true);
			break;
		}
	}

	[CompilerGenerated]
	private void welxqqJKcA()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		F8CxxNiWB4(ModalName.ExitingModal, new Bc1oFQxb497DIFVleV
		{
			l1WiUoIGQ = QQXBLjLprwI58ya4VR.y8v8TMFOCb(3060),
			rXJnbM57n = QQXBLjLprwI58ya4VR.y8v8TMFOCb(3130),
			J68fgGsK0 = true,
			AffirmativeBtnVisibility = (Visibility)0,
			Yo0WUPlIX = false,
			djroV91nw = false,
			req5sijv5 = 0
		});
	}

	[CompilerGenerated]
	private void BESxCOYK8M()
	{
		Helper.ToggleUILanguage();
		OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3180));
	}
}
