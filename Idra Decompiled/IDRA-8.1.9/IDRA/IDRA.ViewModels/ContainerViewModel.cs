using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using GIToolkit.Services;
using GhU84wwqvI4UZ3pBfu;
using IDRASharedModels;
using jyKONpPolZjh7nUXSI;
using sxB8TYTZ87aKuujytY;

namespace IDRA.ViewModels;

public class ContainerViewModel : ObservableRecipient, IViewModel
{
	private ObservableRecipient mQGxhHhfkS;

	private bool bVxxSSDXQe;

	private readonly IMessagingService yq5xicb8fQ;

	public ObservableRecipient CurrentPage
	{
		get
		{
			return mQGxhHhfkS;
		}
		set
		{
			SetProperty(ref mQGxhHhfkS, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(4070));
		}
	}

	public bool ContainerIsTopMost
	{
		get
		{
			return bVxxSSDXQe;
		}
		set
		{
			SetProperty(ref bVxxSSDXQe, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(4096));
		}
	}

	public ContainerViewModel(IMessagingService messagingService)
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		bVxxSSDXQe = true;
		base._002Ector();
		Task.Run(() => ManagerSettings.Instance.Reload()).Wait();
		yq5xicb8fQ = messagingService;
		yq5xicb8fQ.Register(this, delegate(object P_0, ObservableRecipient P_1)
		{
			CurrentPage = P_1;
		});
		yq5xicb8fQ.Register(this, delegate(object P_0, QjLZEbMKtQvrXWmOGN P_1)
		{
			ContainerIsTopMost = P_1.Value;
		});
	}

	[CompilerGenerated]
	private void tRcxYClWY5(object P_0, ObservableRecipient P_1)
	{
		CurrentPage = P_1;
	}

	[CompilerGenerated]
	private void b5LxvVjKUU(object P_0, QjLZEbMKtQvrXWmOGN P_1)
	{
		ContainerIsTopMost = P_1.Value;
	}
}
