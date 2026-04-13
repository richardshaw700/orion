using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GIToolkit.Model;
using GIToolkit.Services;
using GolfInLauncher.Internationalization;
using GolfInLauncher.Navigation;
using Lmttrs0IQc7UR7Zpt6;
using MahApps.Metro.Controls.Dialogs;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.ViewModels;

public class WifiPanelViewModel : ObservableRecipient, IViewModel
{
	private Process dQBZXOlllZ;

	private ObservableCollection<ConnectionModel> mZIZ1M7dXv;

	private ConnectionModel hJ6ZrM5Z4n;

	private string W2uZ4nsSuw;

	private readonly INavigationService<ViewModelNavigationPages> DY3ZORfj5l;

	private readonly IWifiService cNtZ9CIOlV;

	private readonly IDialogCoordinator zi4ZATQKP3;

	public ObservableCollection<ConnectionModel> AvailableConnectionModel
	{
		get
		{
			return mZIZ1M7dXv;
		}
		set
		{
			SetProperty(ref mZIZ1M7dXv, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(6796));
		}
	}

	public ConnectionModel SelectedConnection
	{
		get
		{
			return hJ6ZrM5Z4n;
		}
		set
		{
			SetProperty(ref hJ6ZrM5Z4n, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(6848));
		}
	}

	public string NotificationStatus
	{
		get
		{
			return W2uZ4nsSuw;
		}
		set
		{
			SetProperty(ref W2uZ4nsSuw, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(6888));
		}
	}

	public ICommand WindowLoadCommand => new RelayCommand(async delegate
	{
		try
		{
			await Task.Run(delegate
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
				defaultInterpolatedStringHandler.AppendFormatted(Environment.GetFolderPath(Environment.SpecialFolder.System));
				defaultInterpolatedStringHandler.AppendFormatted(Path.DirectorySeparatorChar);
				defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(6928));
				ProcessStartInfo startInfo = new ProcessStartInfo(defaultInterpolatedStringHandler.ToStringAndClear())
				{
					UseShellExecute = true,
					Verb = aL07ImwcwlxdnyfI30.olMQlwrxmw(6946)
				};
				dQBZXOlllZ = Process.Start(startInfo);
			});
			if (dQBZXOlllZ == null)
			{
				await zi4ZATQKP3.ShowMessageAsync(this, Resources.WarningText, aL07ImwcwlxdnyfI30.olMQlwrxmw(16996));
				DY3ZORfj5l.NavigateTo(ViewModelNavigationPages.Main);
				return;
			}
		}
		catch (Exception ex)
		{
			_ = ex;
			await zi4ZATQKP3.ShowMessageAsync(this, Resources.WarningText, aL07ImwcwlxdnyfI30.olMQlwrxmw(16996));
			DY3ZORfj5l.NavigateTo(ViewModelNavigationPages.Main);
			return;
		}
		IWifiService wifiService = cNtZ9CIOlV;
		wifiService.OnConnectionStatusUpdate = (Action<string>)Delegate.Remove(wifiService.OnConnectionStatusUpdate, new Action<string>(OnConnectionStatusUpdate));
		IWifiService wifiService2 = cNtZ9CIOlV;
		wifiService2.OnConnectionStatusUpdate = (Action<string>)Delegate.Combine(wifiService2.OnConnectionStatusUpdate, new Action<string>(OnConnectionStatusUpdate));
		IWifiService wifiService3 = cNtZ9CIOlV;
		wifiService3.OnSuccessConnected = (Action<bool>)Delegate.Remove(wifiService3.OnSuccessConnected, new Action<bool>(OnSuccessConnected));
		IWifiService wifiService4 = cNtZ9CIOlV;
		wifiService4.OnSuccessConnected = (Action<bool>)Delegate.Combine(wifiService4.OnSuccessConnected, new Action<bool>(OnSuccessConnected));
		AvailableConnectionModel = new ObservableCollection<ConnectionModel>(cNtZ9CIOlV.GetAvalaibleWifiNetwork());
	});

	public ICommand ContinueCommand => new RelayCommand<object>(async delegate(object? P_0)
	{
		string password = ((PasswordBox)P_0).Password;
		if (SelectedConnection == null)
		{
			await zi4ZATQKP3.ShowMessageAsync(this, Resources.WarningText, Resources.SelectAvailableWifiConnectionText);
		}
		else if (string.IsNullOrWhiteSpace(password))
		{
			await zi4ZATQKP3.ShowMessageAsync(this, Resources.WarningText, Resources.EnterPasswordText);
		}
		else
		{
			SelectedConnection.Password = password;
			cNtZ9CIOlV.ConnectToWifi(SelectedConnection);
		}
	});

	public ICommand CancelCommand => new RelayCommand(delegate
	{
		if (!dQBZXOlllZ.HasExited)
		{
			dQBZXOlllZ?.Kill();
		}
		SelectedConnection = null;
		NotificationStatus = string.Empty;
		DY3ZORfj5l.NavigateTo(ViewModelNavigationPages.Main);
	});

	public WifiPanelViewModel(INavigationService<ViewModelNavigationPages> navigationService, IWifiService wifiService, IDialogCoordinator dialogCoordinator)
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
		DY3ZORfj5l = navigationService;
		cNtZ9CIOlV = wifiService;
		zi4ZATQKP3 = dialogCoordinator;
	}

	public void OnConnectionStatusUpdate(string status)
	{
		NotificationStatus += status;
	}

	public async void OnSuccessConnected(bool success)
	{
		if (success)
		{
			if (!dQBZXOlllZ.HasExited)
			{
				dQBZXOlllZ?.Kill();
			}
			await zi4ZATQKP3.ShowMessageAsync(this, Resources.SuccessText, Resources.SuccessfullyConnectToWifiText);
			DY3ZORfj5l.NavigateTo(ViewModelNavigationPages.Main);
		}
	}

	[CompilerGenerated]
	private async void VdpZT1QHEf()
	{
		try
		{
			await Task.Run(delegate
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
				defaultInterpolatedStringHandler.AppendFormatted(Environment.GetFolderPath(Environment.SpecialFolder.System));
				defaultInterpolatedStringHandler.AppendFormatted(Path.DirectorySeparatorChar);
				defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(6928));
				ProcessStartInfo startInfo = new ProcessStartInfo(defaultInterpolatedStringHandler.ToStringAndClear())
				{
					UseShellExecute = true,
					Verb = aL07ImwcwlxdnyfI30.olMQlwrxmw(6946)
				};
				dQBZXOlllZ = Process.Start(startInfo);
			});
			if (dQBZXOlllZ == null)
			{
				await zi4ZATQKP3.ShowMessageAsync(this, Resources.WarningText, aL07ImwcwlxdnyfI30.olMQlwrxmw(16996));
				DY3ZORfj5l.NavigateTo(ViewModelNavigationPages.Main);
				return;
			}
		}
		catch (Exception ex)
		{
			_ = ex;
			await zi4ZATQKP3.ShowMessageAsync(this, Resources.WarningText, aL07ImwcwlxdnyfI30.olMQlwrxmw(16996));
			DY3ZORfj5l.NavigateTo(ViewModelNavigationPages.Main);
			return;
		}
		IWifiService wifiService = cNtZ9CIOlV;
		wifiService.OnConnectionStatusUpdate = (Action<string>)Delegate.Remove(wifiService.OnConnectionStatusUpdate, new Action<string>(OnConnectionStatusUpdate));
		IWifiService wifiService2 = cNtZ9CIOlV;
		wifiService2.OnConnectionStatusUpdate = (Action<string>)Delegate.Combine(wifiService2.OnConnectionStatusUpdate, new Action<string>(OnConnectionStatusUpdate));
		IWifiService wifiService3 = cNtZ9CIOlV;
		wifiService3.OnSuccessConnected = (Action<bool>)Delegate.Remove(wifiService3.OnSuccessConnected, new Action<bool>(OnSuccessConnected));
		IWifiService wifiService4 = cNtZ9CIOlV;
		wifiService4.OnSuccessConnected = (Action<bool>)Delegate.Combine(wifiService4.OnSuccessConnected, new Action<bool>(OnSuccessConnected));
		AvailableConnectionModel = new ObservableCollection<ConnectionModel>(cNtZ9CIOlV.GetAvalaibleWifiNetwork());
	}

	[CompilerGenerated]
	private void EmcZY8xEKl()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
		defaultInterpolatedStringHandler.AppendFormatted(Environment.GetFolderPath(Environment.SpecialFolder.System));
		defaultInterpolatedStringHandler.AppendFormatted(Path.DirectorySeparatorChar);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(6928));
		ProcessStartInfo startInfo = new ProcessStartInfo(defaultInterpolatedStringHandler.ToStringAndClear())
		{
			UseShellExecute = true,
			Verb = aL07ImwcwlxdnyfI30.olMQlwrxmw(6946)
		};
		dQBZXOlllZ = Process.Start(startInfo);
	}

	[CompilerGenerated]
	private async void tTQZSBHmNJ(object? P_0)
	{
		string password = ((PasswordBox)P_0).Password;
		if (SelectedConnection == null)
		{
			await zi4ZATQKP3.ShowMessageAsync(this, Resources.WarningText, Resources.SelectAvailableWifiConnectionText);
			return;
		}
		if (string.IsNullOrWhiteSpace(password))
		{
			await zi4ZATQKP3.ShowMessageAsync(this, Resources.WarningText, Resources.EnterPasswordText);
			return;
		}
		SelectedConnection.Password = password;
		cNtZ9CIOlV.ConnectToWifi(SelectedConnection);
	}

	[CompilerGenerated]
	private void ihCZNrP0Ss()
	{
		if (!dQBZXOlllZ.HasExited)
		{
			dQBZXOlllZ?.Kill();
		}
		SelectedConnection = null;
		NotificationStatus = string.Empty;
		DY3ZORfj5l.NavigateTo(ViewModelNavigationPages.Main);
	}
}
