using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GICTSCore.Data;
using GICTSCore.Model;
using GICTSCore.Services;
using GIToolkit.Services;
using IDRAMonitor.Auxiliary.Messages;
using IDRAMonitor.Auxiliary.Navigation;
using IDRAMonitor.Internationalization;
using IDRASharedModels;
using MahApps.Metro.Controls.Dialogs;
using hkpxmGISLhTJrZLcmi;
using jBnbmEXkwPOPpPQ9mC;

namespace IDRAMonitor.ViewModels;

public class PasswordViewModel : ObservableRecipient, IViewModel
{
	private string BOq7egMK25;

	private string NE77ljOEiY;

	private string CkG78tdpV6;

	private readonly INavigationService<VM> i8f7kJ13aH;

	private readonly IDialogCoordinator p4M746qDPJ;

	private readonly IMessagingService lJ67UcPmgv;

	private readonly ICircularLogService YqJ7fWOOO5;

	private PasswordWindowMode gwx7MKNCV7;

	private string WI47D2hHsT;

	public string Password
	{
		get
		{
			return BOq7egMK25;
		}
		set
		{
			SetProperty(ref BOq7egMK25, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5162));
		}
	}

	public string NotifPassword
	{
		get
		{
			return NE77ljOEiY;
		}
		set
		{
			SetProperty(ref NE77ljOEiY, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5182));
		}
	}

	public string Title
	{
		get
		{
			return CkG78tdpV6;
		}
		set
		{
			SetProperty(ref CkG78tdpV6, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5212));
		}
	}

	public ICommand PasswordSendCommand => new AsyncRelayCommand<string>(async delegate(string P_0)
	{
		Password += P_0;
		NotifPassword = Password.Length.ToString();
		await ValidatePassword(Password);
	});

	public ICommand CancelCommand => new RelayCommand(delegate
	{
		qSY7Tdouht();
		i8f7kJ13aH.NavigateTo(VM.Main);
	});

	public ICommand WindowClosedCommand => new RelayCommand(delegate
	{
		qSY7Tdouht();
	});

	public ICommand EnterPasswordCommand => new AsyncRelayCommand<object>(async delegate(object? passwordItem)
	{
		PasswordBox passwordBox = (PasswordBox)passwordItem;
		if (passwordBox == null)
		{
			throw new ArgumentNullException(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(11688));
		}
		string password = (string.IsNullOrWhiteSpace(passwordBox.Password) ? Password : passwordBox.Password);
		if (!(await ValidatePassword(password)))
		{
			await p4M746qDPJ.ShowMessageAsync(this, Resources.Warning, WI47D2hHsT);
			passwordBox.Clear();
			qSY7Tdouht();
			Keyboard.Focus((IInputElement)(object)passwordBox);
		}
	});

	public ICommand ContinueCommand => new RelayCommand<object>(delegate(object? P_0)
	{
		EnterPasswordCommand.Execute(P_0);
	});

	public PasswordViewModel(INavigationService<VM> navigationService, IDialogCoordinator dialogCoordinator, IMessagingService messagingService, ICircularLogService circularLogService)
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		gwx7MKNCV7 = PasswordWindowMode.Admin;
		WI47D2hHsT = Resources.AdminOnly;
		base._002Ector();
		i8f7kJ13aH = navigationService;
		p4M746qDPJ = dialogCoordinator;
		lJ67UcPmgv = messagingService;
		YqJ7fWOOO5 = circularLogService;
		lJ67UcPmgv.Register(this, delegate(object P_0, ShowPasswordMessage P_1)
		{
			gwx7MKNCV7 = P_1.PasswordWindowMode;
			PasswordWindowMode passwordWindowMode = P_1.PasswordWindowMode;
			if (passwordWindowMode != PasswordWindowMode.Admin && passwordWindowMode == PasswordWindowMode.Manager)
			{
				Title = Resources.ManagerPinTitle;
				WI47D2hHsT = Resources.ManagerOnly;
			}
			else
			{
				Title = Resources.AdminPinTitle;
				WI47D2hHsT = Resources.AdminOnly;
			}
		});
	}

	public async Task<bool> ValidatePassword(string password)
	{
		if (password == IDRAConstant.AdminPassword && gwx7MKNCV7 == PasswordWindowMode.Admin)
		{
			qSY7Tdouht();
			YqJ7fWOOO5.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(11714));
			i8f7kJ13aH.NavigateTo(VM.AdminMenu);
			return true;
		}
		if ((password == IDRAConstant.AdminManagerPassword || password == GolfInLauncherSettingsService.GetCustomerPIN()) && gwx7MKNCV7 == PasswordWindowMode.Manager)
		{
			qSY7Tdouht();
			YqJ7fWOOO5.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(11828));
			await ManagerSettings.Instance.Reload(checkNewProp: false);
			i8f7kJ13aH.NavigateTo(VM.ManagerSettingMenu);
			return true;
		}
		return false;
	}

	private void qSY7Tdouht()
	{
		Password = string.Empty;
		NotifPassword = string.Empty;
	}

	[CompilerGenerated]
	private void U857ONCUaD(object P_0, ShowPasswordMessage P_1)
	{
		gwx7MKNCV7 = P_1.PasswordWindowMode;
		PasswordWindowMode passwordWindowMode = P_1.PasswordWindowMode;
		if (passwordWindowMode != PasswordWindowMode.Admin && passwordWindowMode == PasswordWindowMode.Manager)
		{
			Title = Resources.ManagerPinTitle;
			WI47D2hHsT = Resources.ManagerOnly;
		}
		else
		{
			Title = Resources.AdminPinTitle;
			WI47D2hHsT = Resources.AdminOnly;
		}
	}

	[CompilerGenerated]
	private async Task tnP7NB7wLq(string P_0)
	{
		Password += P_0;
		NotifPassword = Password.Length.ToString();
		await ValidatePassword(Password);
	}

	[CompilerGenerated]
	private void iI07EBdr2S()
	{
		qSY7Tdouht();
		i8f7kJ13aH.NavigateTo(VM.Main);
	}

	[CompilerGenerated]
	private void lZ37uqm53Q()
	{
		qSY7Tdouht();
	}

	[CompilerGenerated]
	private async Task Vsn7pNsBlL(object? passwordItem)
	{
		PasswordBox passwordBox = (PasswordBox)passwordItem;
		if (passwordBox == null)
		{
			throw new ArgumentNullException(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(11688));
		}
		string password = (string.IsNullOrWhiteSpace(passwordBox.Password) ? Password : passwordBox.Password);
		if (!(await ValidatePassword(password)))
		{
			await p4M746qDPJ.ShowMessageAsync(this, Resources.Warning, WI47D2hHsT);
			passwordBox.Clear();
			qSY7Tdouht();
			Keyboard.Focus((IInputElement)(object)passwordBox);
		}
	}

	[CompilerGenerated]
	private void AH270Xdfgf(object? P_0)
	{
		EnterPasswordCommand.Execute(P_0);
	}
}
