using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using GIToolkit.Services;
using IDRASharedModels;
using hkpxmGISLhTJrZLcmi;
using jBnbmEXkwPOPpPQ9mC;

namespace IDRAMonitor.ViewModels;

public class ContainerViewModel : ObservableRecipient, IViewModel
{
	private ObservableRecipient WLDjr04TZu;

	private readonly IMessagingService jYXjjQpiyK;

	public ObservableRecipient CurrentPage
	{
		get
		{
			return WLDjr04TZu;
		}
		set
		{
			SetProperty(ref WLDjr04TZu, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2886));
		}
	}

	public ContainerViewModel(IMessagingService messagingService)
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		base._002Ector();
		Task.Run(() => ManagerSettings.Instance.Reload()).Wait();
		jYXjjQpiyK = messagingService;
		jYXjjQpiyK.Register(this, delegate(object P_0, ObservableRecipient P_1)
		{
			CurrentPage = P_1;
		});
	}

	[CompilerGenerated]
	private void huhzOLSuk(object P_0, ObservableRecipient P_1)
	{
		CurrentPage = P_1;
	}
}
