using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.Messaging.Messages;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Messages;

public class CloseApplicationMessage : ValueChangedMessage<int>
{
	[CompilerGenerated]
	private readonly int Tb8sbWDwUf;

	public int ExitCode
	{
		[CompilerGenerated]
		get
		{
			return Tb8sbWDwUf;
		}
	}

	public CloseApplicationMessage(int exitCode)
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector(exitCode);
		Tb8sbWDwUf = exitCode;
	}
}
