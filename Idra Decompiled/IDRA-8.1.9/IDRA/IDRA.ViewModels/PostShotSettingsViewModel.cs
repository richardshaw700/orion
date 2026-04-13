using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GIToolkit.Services;
using GhU84wwqvI4UZ3pBfu;
using IDRA.Auxiliary.Messages;
using IDRA.Auxiliary.Navigations;
using IDRASharedModels;
using MahApps.Metro.Controls.Dialogs;
using sxB8TYTZ87aKuujytY;

namespace IDRA.ViewModels;

public class PostShotSettingsViewModel : ObservableRecipient, IViewModel
{
	private bool oCQHtRQ6w1;

	private readonly INavigationService<VM> DKYHjuSsBb;

	private readonly IDialogCoordinator WfYHBNUnBb;

	private readonly IMessagingService txeHDqlkvt;

	public ManagerSettings ManagerSettings => ManagerSettings.Instance;

	public bool IsContinueTimerDisabled
	{
		get
		{
			return oCQHtRQ6w1;
		}
		set
		{
			SetProperty(ref oCQHtRQ6w1, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(6436));
		}
	}

	public ICommand BackCommand => new RelayCommand(delegate
	{
		txeHDqlkvt.Send(new NavigatePostShotViewMessage(disableAutoContinueTimer: false));
	});

	public ICommand DisablePostShotCommand => new RelayCommand(delegate
	{
		ManagerSettings.Instance.UseGolfInPostShotInGame = false;
		ManagerSettings.Instance.UseGolfInPostShotInPractice = false;
	});

	public ICommand SaveCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		if (IsContinueTimerDisabled)
		{
			ManagerSettings.PostShotAutoContinueDuration = TimeSpan.FromSeconds(0.0);
		}
		await WfYHBNUnBb.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12838), QQXBLjLprwI58ya4VR.y8v8TMFOCb(14686));
		BackCommand?.Execute(null);
	});

	public PostShotSettingsViewModel(INavigationService<VM> navigationService, IDialogCoordinator dialogCoordinator, IMessagingService messagingService)
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		oCQHtRQ6w1 = ManagerSettings.Instance.PostShotAutoContinueDuration.TotalSeconds <= 0.0;
		base._002Ector();
		DKYHjuSsBb = navigationService;
		WfYHBNUnBb = dialogCoordinator;
		txeHDqlkvt = messagingService;
	}

	[CompilerGenerated]
	private void tObH4kFWp2()
	{
		txeHDqlkvt.Send(new NavigatePostShotViewMessage(disableAutoContinueTimer: false));
	}

	[CompilerGenerated]
	private async Task RO3H3lpQCl()
	{
		if (IsContinueTimerDisabled)
		{
			ManagerSettings.PostShotAutoContinueDuration = TimeSpan.FromSeconds(0.0);
		}
		await WfYHBNUnBb.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12838), QQXBLjLprwI58ya4VR.y8v8TMFOCb(14686));
		BackCommand?.Execute(null);
	}
}
