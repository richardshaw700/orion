using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.Messaging.Messages;
using GICTS.Data;
using GhU84wwqvI4UZ3pBfu;

namespace IDRA.Auxiliary.Messages;

public class FillCustomShotMessages : ValueChangedMessage<CTSShotData>
{
	[CompilerGenerated]
	private CTSShotData hugC1ULAVl;

	public CTSShotData Shot
	{
		[CompilerGenerated]
		get
		{
			return hugC1ULAVl;
		}
		[CompilerGenerated]
		set
		{
			hugC1ULAVl = value;
		}
	}

	public FillCustomShotMessages(CTSShotData value)
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		base._002Ector(value);
		Shot = value;
	}
}
