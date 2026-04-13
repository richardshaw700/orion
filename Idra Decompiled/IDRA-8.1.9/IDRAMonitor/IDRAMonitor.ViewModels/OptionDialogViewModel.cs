using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using GICTSCore.Data;
using GIToolkit.Services;
using IDRAMonitor.Auxiliary.Messages;
using IDRAMonitor.Auxiliary.Navigation;
using IDRAMonitor.Services;
using MahApps.Metro.Controls.Dialogs;
using hkpxmGISLhTJrZLcmi;
using jBnbmEXkwPOPpPQ9mC;

namespace IDRAMonitor.ViewModels;

public class OptionDialogViewModel : ObservableRecipient, IViewModel
{
	private bool SHU7CNM6S9;

	private bool UbH7POGNXH;

	private string cDK7QO4Bfg;

	private readonly IDialogCoordinator V1E7VBsxpv;

	private readonly IMessagingService a7l7wfT8Bk;

	private readonly IProjectProcessService M1Q7g1tAms;

	private readonly INavigationService<VM> llQ7Lcsv4i;

	private readonly ICircularLogService x1l7xhf951;

	public bool ShowProgress
	{
		get
		{
			return SHU7CNM6S9;
		}
		set
		{
			SetProperty(ref SHU7CNM6S9, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2278));
		}
	}

	public bool ActHasProgressWithMessage
	{
		get
		{
			return UbH7POGNXH;
		}
		set
		{
			SetProperty(ref UbH7POGNXH, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5072));
		}
	}

	public string MessageToDisplay
	{
		get
		{
			return cDK7QO4Bfg;
		}
		set
		{
			SetProperty(ref cDK7QO4Bfg, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5126));
		}
	}

	public ICommand ResetCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		if (!ShowProgress)
		{
			ShowProgress = true;
			x1l7xhf951.Log(new string('*', 30) + ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8224) + new string('*', 30), LogLevel.Warning);
			await M1Q7g1tAms.ResetIdra();
			await Task.Delay(IDRAConstant.ResetMaxDelayTimeMs);
			if (ShowProgress)
			{
				ShowProgress = false;
				CancelCommand.Execute(null);
			}
		}
	});

	public ICommand CancelCommand => new RelayCommand(delegate
	{
		llQ7Lcsv4i.NavigateTo(VM.Main);
	});

	public OptionDialogViewModel(IDialogCoordinator dialogCoordinator, IMessagingService messagingService, IProjectProcessService projectProcessService, INavigationService<VM> navigationService, ICircularLogService circularLogService)
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		base._002Ector();
		V1E7VBsxpv = dialogCoordinator;
		a7l7wfT8Bk = messagingService;
		M1Q7g1tAms = projectProcessService;
		llQ7Lcsv4i = navigationService;
		x1l7xhf951 = circularLogService;
		WeakReferenceMessenger.Default.Register(this, delegate(object P_0, SetShowProgessMessage P_1)
		{
			ActHasProgressWithMessage = P_1.Data.ActHasProgressWithMessage;
			MessageToDisplay = P_1.Data.DisplayMessage;
			ShowProgress = P_1.Data.NewShowProgressMessageValue;
			if (!ShowProgress && !P_1.Data.IsOnGSProMenu)
			{
				CancelCommand.Execute(null);
			}
		});
	}

	[CompilerGenerated]
	private void KGU7BwPk7f(object P_0, SetShowProgessMessage P_1)
	{
		ActHasProgressWithMessage = P_1.Data.ActHasProgressWithMessage;
		MessageToDisplay = P_1.Data.DisplayMessage;
		ShowProgress = P_1.Data.NewShowProgressMessageValue;
		if (!ShowProgress && !P_1.Data.IsOnGSProMenu)
		{
			CancelCommand.Execute(null);
		}
	}

	[CompilerGenerated]
	private async Task mPr7AyCZ0u()
	{
		if (!ShowProgress)
		{
			ShowProgress = true;
			x1l7xhf951.Log(new string('*', 30) + ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(8224) + new string('*', 30), LogLevel.Warning);
			await M1Q7g1tAms.ResetIdra();
			await Task.Delay(IDRAConstant.ResetMaxDelayTimeMs);
			if (ShowProgress)
			{
				ShowProgress = false;
				CancelCommand.Execute(null);
			}
		}
	}

	[CompilerGenerated]
	private void DLt7YciCEG()
	{
		llQ7Lcsv4i.NavigateTo(VM.Main);
	}
}
