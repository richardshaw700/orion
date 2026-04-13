using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.Messaging.Messages;
using Tree.Structures;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Messages;

public class RefreshAllChildList : ValueChangedMessage<SerializableCardTree>
{
	[CompilerGenerated]
	private SerializableCardTree s1gsy8EOar;

	public SerializableCardTree LauncherCardTree
	{
		[CompilerGenerated]
		get
		{
			return s1gsy8EOar;
		}
		[CompilerGenerated]
		set
		{
			s1gsy8EOar = value;
		}
	}

	public RefreshAllChildList(SerializableCardTree launcherCardTree)
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector(launcherCardTree);
		LauncherCardTree = launcherCardTree;
	}
}
