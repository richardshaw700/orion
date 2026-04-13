using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.Messaging.Messages;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Messages;

public class MainLaunchProgramMessage : ValueChangedMessage<string>
{
	[CompilerGenerated]
	private string t0esVwr6jX;

	public string ProgramName
	{
		[CompilerGenerated]
		get
		{
			return t0esVwr6jX;
		}
		[CompilerGenerated]
		set
		{
			t0esVwr6jX = value;
		}
	}

	public MainLaunchProgramMessage(string programName)
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector(programName);
		ProgramName = programName;
	}
}
