using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GIToolkit.Services;
using GolfInLauncher.Internationalization;
using GolfInLauncher.Messages;
using GolfInLauncher.Navigation;
using GolfInLauncher.Services;
using Golfin.Dtos;
using Lmttrs0IQc7UR7Zpt6;
using MahApps.Metro.Controls.Dialogs;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.ViewModels;

public class PasswordViewModel : ObservableRecipient, IViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public string bqK5sIyS02;

		public _003C_003Ec__DisplayClass38_0()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal bool tak53uKQFw(UserForManagementDto x)
		{
			return x.CardNumber == bqK5sIyS02;
		}
	}

	private string LycG3iUbwE;

	private string PMyGsTBMBg;

	private bool UwOGqNHMWn;

	private readonly ILauncherDataApi CGFG5RcPfF;

	private readonly ILocalCachingServices gIWGQKXY7q;

	private readonly ILauncherEnv RmHGxcZS2d;

	private readonly INavigationService<ViewModelNavigationPages> RyMGHhSd2A;

	private readonly IDialogCoordinator vUBGcuGhyT;

	private readonly ILauncherSettings OsIGeVcXBv;

	private readonly IThreadHelper RR4GbiAUlg;

	private readonly IMessagingService SX7GVpO7YW;

	private readonly IProcessHelper rckGwa2dnr;

	private bool n7VG02wnA2;

	private ViewModelNavigationPages GSMGCj1VxM;

	public string Password
	{
		get
		{
			return LycG3iUbwE;
		}
		set
		{
			SetProperty(ref LycG3iUbwE, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(2118));
		}
	}

	public string NotifPassword
	{
		get
		{
			return PMyGsTBMBg;
		}
		set
		{
			SetProperty(ref PMyGsTBMBg, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(4852));
		}
	}

	public bool IsPasswordFocused
	{
		get
		{
			return UwOGqNHMWn;
		}
		set
		{
			SetProperty(ref UwOGqNHMWn, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(4882));
		}
	}

	public ICommand PasswordSendCommand => new RelayCommand<string>(delegate(string P_0)
	{
		Password += P_0;
		NotifPassword = Password.Length.ToString();
	});

	public ICommand CancelCommand => new RelayCommand(delegate
	{
		lSB8nPT3g9();
		RyMGHhSd2A.NavigateTo(ViewModelNavigationPages.Main);
	});

	public ICommand WindowClosedCommand => new RelayCommand(delegate
	{
		CancelCommand.Execute(null);
	});

	public ICommand EnterPasswordCommand => new AsyncRelayCommand<object>(async delegate(object? passwordItem)
	{
		PasswordBox passwordBox = (PasswordBox)passwordItem;
		string password = passwordBox.Password;
		if (string.IsNullOrEmpty(password))
		{
			password = Password;
		}
		if (!(await ValidatePassword(password)))
		{
			await vUBGcuGhyT.ShowMessageAsync(this, Resources.EmployeeNotFoundHeader, Resources.EmployeeNotFoundMessage);
			passwordBox.Clear();
			lSB8nPT3g9();
			Keyboard.Focus((IInputElement)(object)passwordBox);
		}
	});

	public ICommand ContinueCommand => new RelayCommand<object>(delegate(object? P_0)
	{
		EnterPasswordCommand.Execute(P_0);
	});

	public ICommand WindowLoadCommand => new RelayCommand(delegate
	{
		RR4GbiAUlg.StartTaskAsyncFunc(async delegate
		{
			await CGFG5RcPfF.FetchMinimumDataForLauncher();
			gIWGQKXY7q.Cache(LauncherEnv.LauncherDataKey, RmHGxcZS2d as LauncherEnv);
		});
	});

	public PasswordViewModel(ILauncherDataApi launcherDataApi, ILocalCachingServices localCachingServices, ILauncherEnv launcherEnv, INavigationService<ViewModelNavigationPages> navigationService, IDialogCoordinator dialogCoordinator, ILauncherSettings launcherSettings, IThreadHelper threadHelper, IMessagingService messagingService, IProcessHelper processHelper)
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
		CGFG5RcPfF = launcherDataApi;
		gIWGQKXY7q = localCachingServices;
		RmHGxcZS2d = launcherEnv;
		RyMGHhSd2A = navigationService;
		vUBGcuGhyT = dialogCoordinator;
		OsIGeVcXBv = launcherSettings;
		RR4GbiAUlg = threadHelper;
		SX7GVpO7YW = messagingService;
		rckGwa2dnr = processHelper;
		SX7GVpO7YW.Register(this, delegate(object P_0, RedirectToView P_1)
		{
			GSMGCj1VxM = P_1.Page;
		});
	}

	private bool K9u8UqIrCl(string P_0)
	{
		return P_0 == OsIGeVcXBv.GetAdminPassword();
	}

	private bool heA8tdUUf1(string P_0)
	{
		return P_0 == GolfinUtils.GeneratePin();
	}

	private bool ixy8LhsTZf(string P_0)
	{
		_003C_003Ec__DisplayClass38_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass38_0();
		CS_0024_003C_003E8__locals3.bqK5sIyS02 = P_0;
		try
		{
			return CS_0024_003C_003E8__locals3.bqK5sIyS02 == OsIGeVcXBv.GetAdminEmployeePassword() || RmHGxcZS2d.Employees.Any((UserForManagementDto x) => x.CardNumber == CS_0024_003C_003E8__locals3.bqK5sIyS02);
		}
		catch
		{
		}
		return false;
	}

	private bool PVl8Rk8kZd(string P_0)
	{
		if (!(P_0 == OsIGeVcXBv.CustomerPin))
		{
			return OsIGeVcXBv.CustomerPin.Length == 0;
		}
		return true;
	}

	public async Task<bool> ValidatePassword(string password)
	{
		if (GSMGCj1VxM == ViewModelNavigationPages.Settings && (K9u8UqIrCl(password) || heA8tdUUf1(password) || PVl8Rk8kZd(password)))
		{
			OsIGeVcXBv.IsInAdminMode = K9u8UqIrCl(password);
			RyMGHhSd2A.NavigateTo(GSMGCj1VxM);
			lSB8nPT3g9();
			return true;
		}
		if ((GSMGCj1VxM == ViewModelNavigationPages.SoftwareUpdates || GSMGCj1VxM == ViewModelNavigationPages.ExitSoftware || GSMGCj1VxM == ViewModelNavigationPages.Calibration) && (K9u8UqIrCl(password) || heA8tdUUf1(password) || ixy8LhsTZf(password) || PVl8Rk8kZd(password)))
		{
			OsIGeVcXBv.IsInAdminMode = K9u8UqIrCl(password);
			if (GSMGCj1VxM == ViewModelNavigationPages.ExitSoftware)
			{
				SX7GVpO7YW.Send(new CloseApplicationMessage(100));
			}
			else if (GSMGCj1VxM == ViewModelNavigationPages.Calibration)
			{
				SX7GVpO7YW.Send(new CloseAndStartCalibrationMessage(100));
			}
			else
			{
				RyMGHhSd2A.NavigateTo(GSMGCj1VxM);
			}
			lSB8nPT3g9();
			return true;
		}
		if (K9u8UqIrCl(password))
		{
			OsIGeVcXBv.IsInAdminMode = K9u8UqIrCl(password);
			RyMGHhSd2A.NavigateTo(GSMGCj1VxM);
			lSB8nPT3g9();
			return true;
		}
		if (heA8tdUUf1(password))
		{
			RyMGHhSd2A.NavigateTo(GSMGCj1VxM);
			if (GSMGCj1VxM == ViewModelNavigationPages.Support)
			{
				await XMR8gDk1SS();
			}
			lSB8nPT3g9();
			return true;
		}
		if (ixy8LhsTZf(password))
		{
			RyMGHhSd2A.NavigateTo(ViewModelNavigationPages.Support);
			lSB8nPT3g9();
			return true;
		}
		return false;
	}

	private void lSB8nPT3g9()
	{
		Password = string.Empty;
		NotifPassword = string.Empty;
	}

	private async Task XMR8gDk1SS()
	{
		bool flag;
		try
		{
			using Process processToStart = rckGwa2dnr.CreateProcess(LauncherConstant.TeamViewerExePath);
			rckGwa2dnr.StartProcess(processToStart);
			flag = true;
		}
		catch (Exception ex)
		{
			string text = ((ex is FileNotFoundException ex2) ? (ex2.Message + aL07ImwcwlxdnyfI30.olMQlwrxmw(18426) + ex2.FileName) : string.Empty);
			await vUBGcuGhyT.ShowMessageAsync(this, aL07ImwcwlxdnyfI30.olMQlwrxmw(1648), aL07ImwcwlxdnyfI30.olMQlwrxmw(18434) + text);
			SX7GVpO7YW.Send(new SendContainerConfigMessage(new SendContainerConfigMessageArguments
			{
				TopMost = true,
				WindowState = (WindowState)2
			}));
			EventViewerLogger.LogException(ex);
			flag = false;
		}
		if (flag)
		{
			SX7GVpO7YW.Send(new CloseApplicationMessage(100));
		}
	}

	[CompilerGenerated]
	private void uRS8o9aU2n(object P_0, RedirectToView P_1)
	{
		GSMGCj1VxM = P_1.Page;
	}

	[CompilerGenerated]
	private void nM98hcoFwP(string P_0)
	{
		Password += P_0;
		NotifPassword = Password.Length.ToString();
	}

	[CompilerGenerated]
	private void DUc8z4j79W()
	{
		lSB8nPT3g9();
		RyMGHhSd2A.NavigateTo(ViewModelNavigationPages.Main);
	}

	[CompilerGenerated]
	private void McsGpBg1ua()
	{
		CancelCommand.Execute(null);
	}

	[CompilerGenerated]
	private async Task l0WGkKfadS(object? passwordItem)
	{
		PasswordBox passwordBox = (PasswordBox)passwordItem;
		string password = passwordBox.Password;
		if (string.IsNullOrEmpty(password))
		{
			password = Password;
		}
		if (!(await ValidatePassword(password)))
		{
			await vUBGcuGhyT.ShowMessageAsync(this, Resources.EmployeeNotFoundHeader, Resources.EmployeeNotFoundMessage);
			passwordBox.Clear();
			lSB8nPT3g9();
			Keyboard.Focus((IInputElement)(object)passwordBox);
		}
	}

	[CompilerGenerated]
	private void MnRG8v3kXH(object? P_0)
	{
		EnterPasswordCommand.Execute(P_0);
	}

	[CompilerGenerated]
	private void nTSGGFyoNE()
	{
		RR4GbiAUlg.StartTaskAsyncFunc(async delegate
		{
			await CGFG5RcPfF.FetchMinimumDataForLauncher();
			gIWGQKXY7q.Cache(LauncherEnv.LauncherDataKey, RmHGxcZS2d as LauncherEnv);
		});
	}

	[CompilerGenerated]
	private async Task HEIGZfsGRn()
	{
		await CGFG5RcPfF.FetchMinimumDataForLauncher();
		gIWGQKXY7q.Cache(LauncherEnv.LauncherDataKey, RmHGxcZS2d as LauncherEnv);
	}
}
