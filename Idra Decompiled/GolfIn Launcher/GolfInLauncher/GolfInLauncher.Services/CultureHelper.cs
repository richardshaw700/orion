using GIToolkit.Services;
using GolfInLauncher.Messages;
using Golfin.Dtos;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Services;

public class CultureHelper : ICultureHelper, IService
{
	private readonly ILauncherSettings RER3k6nqhc;

	private readonly ICultureResourcesService AY138wvp2T;

	private readonly IMessagingService J6N3GrRXcV;

	public CultureHelper(ILauncherSettings launcherSettings, ICultureResourcesService cultureResourcesService, IMessagingService messagingService)
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
		RER3k6nqhc = launcherSettings;
		AY138wvp2T = cultureResourcesService;
		J6N3GrRXcV = messagingService;
	}

	public void ChangeCultureLanguage(string culture)
	{
		RER3k6nqhc.AssignedCulture = culture;
		AssignCultureLanguage();
	}

	public void AssignCultureLanguage()
	{
		AY138wvp2T.SetCulture(RER3k6nqhc.AssignedCulture);
		J6N3GrRXcV.Send(new OnLanguageChangeMessage(GetCurrentLanguage()));
	}

	public Language GetCurrentLanguage()
	{
		if (RER3k6nqhc.AssignedCulture == RER3k6nqhc.FrenchCulture)
		{
			return Language.French;
		}
		return Language.English;
	}
}
