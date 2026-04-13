using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.Messaging.Messages;
using GolfInLauncher.Navigation;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Messages;

public class RedirectToView : ValueChangedMessage<ViewModelNavigationPages>
{
	[CompilerGenerated]
	private ViewModelNavigationPages w3NsdtClHZ;

	public ViewModelNavigationPages Page
	{
		[CompilerGenerated]
		get
		{
			return w3NsdtClHZ;
		}
		[CompilerGenerated]
		set
		{
			w3NsdtClHZ = value;
		}
	}

	public RedirectToView(ViewModelNavigationPages page)
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector(page);
		Page = page;
	}
}
