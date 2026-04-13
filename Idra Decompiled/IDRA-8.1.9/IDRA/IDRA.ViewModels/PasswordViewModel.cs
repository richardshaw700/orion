using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GICTSCore.Data;
using GIToolkit.Services;
using GhU84wwqvI4UZ3pBfu;
using IDRA.Auxiliary.Navigations;
using IDRA.Internationalization;
using MahApps.Metro.Controls.Dialogs;
using sxB8TYTZ87aKuujytY;
using xffi3AOjEKFP5hQtL6;

namespace IDRA.ViewModels;

public class PasswordViewModel : ObservableRecipient, IViewModel
{
	private string NcXdhA5xAy;

	private string TTSdSvVxSX;

	private readonly INavigationService<VM> mpJdiWe6JC;

	private readonly IDialogCoordinator ttldnCjLZ9;

	private readonly IMessagingService VoHdfVJKBy;

	private readonly ICircularLogService E0udWmVxF8;

	public string Password
	{
		get
		{
			return NcXdhA5xAy;
		}
		set
		{
			SetProperty(ref NcXdhA5xAy, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(5246));
		}
	}

	public string NotifPassword
	{
		get
		{
			return TTSdSvVxSX;
		}
		set
		{
			SetProperty(ref TTSdSvVxSX, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(5266));
		}
	}

	public ICommand PasswordSendCommand => new RelayCommand<string>(delegate(string P_0)
	{
		Password += P_0;
		NotifPassword = Password.Length.ToString();
		ValidatePassword(Password);
	});

	public ICommand CancelCommand => new RelayCommand(delegate
	{
		KYFdLU9LWH();
		mpJdiWe6JC.NavigateTo(VM.Main);
	});

	public ICommand WindowClosedCommand => new RelayCommand(delegate
	{
		KYFdLU9LWH();
	});

	public ICommand EnterPasswordCommand => new AsyncRelayCommand<object>(async delegate(object? passwordItem)
	{
		PasswordBox passwordBox = (PasswordBox)passwordItem;
		if (passwordBox == null)
		{
			throw new ArgumentNullException(QQXBLjLprwI58ya4VR.y8v8TMFOCb(14566));
		}
		string password = (string.IsNullOrWhiteSpace(passwordBox.Password) ? Password : passwordBox.Password);
		if (!ValidatePassword(password))
		{
			await ttldnCjLZ9.ShowMessageAsync(this, Resources.Warning, Resources.AdminOnly);
			passwordBox.Clear();
			KYFdLU9LWH();
			Keyboard.Focus((IInputElement)(object)passwordBox);
		}
	});

	public ICommand ContinueCommand => new RelayCommand<object>(delegate(object? P_0)
	{
		EnterPasswordCommand.Execute(P_0);
	});

	public PasswordViewModel(INavigationService<VM> navigationService, IDialogCoordinator dialogCoordinator, IMessagingService messagingService, ICircularLogService circularLogService)
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		base._002Ector();
		mpJdiWe6JC = navigationService;
		ttldnCjLZ9 = dialogCoordinator;
		VoHdfVJKBy = messagingService;
		E0udWmVxF8 = circularLogService;
	}

	public bool ValidatePassword(string password)
	{
		if (password == IDRAConstant.AdminPassword)
		{
			KYFdLU9LWH();
			E0udWmVxF8.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5296));
			mpJdiWe6JC.NavigateTo(VM.Main);
			VoHdfVJKBy.Send(new CcKwZQJNLk6OcZDLLB(0));
			return true;
		}
		return false;
	}

	private void KYFdLU9LWH()
	{
		Password = string.Empty;
		NotifPassword = string.Empty;
	}

	[CompilerGenerated]
	private void vbtdTbkfQC(string P_0)
	{
		Password += P_0;
		NotifPassword = Password.Length.ToString();
		ValidatePassword(Password);
	}

	[CompilerGenerated]
	private void lwvdN45eaP()
	{
		KYFdLU9LWH();
		mpJdiWe6JC.NavigateTo(VM.Main);
	}

	[CompilerGenerated]
	private void qnNdwFmmdk()
	{
		KYFdLU9LWH();
	}

	[CompilerGenerated]
	private async Task jcqdYjMWHt(object? passwordItem)
	{
		PasswordBox passwordBox = (PasswordBox)passwordItem;
		if (passwordBox == null)
		{
			throw new ArgumentNullException(QQXBLjLprwI58ya4VR.y8v8TMFOCb(14566));
		}
		string password = (string.IsNullOrWhiteSpace(passwordBox.Password) ? Password : passwordBox.Password);
		if (!ValidatePassword(password))
		{
			await ttldnCjLZ9.ShowMessageAsync(this, Resources.Warning, Resources.AdminOnly);
			passwordBox.Clear();
			KYFdLU9LWH();
			Keyboard.Focus((IInputElement)(object)passwordBox);
		}
	}

	[CompilerGenerated]
	private void HPrdv02FmT(object? P_0)
	{
		EnterPasswordCommand.Execute(P_0);
	}
}
