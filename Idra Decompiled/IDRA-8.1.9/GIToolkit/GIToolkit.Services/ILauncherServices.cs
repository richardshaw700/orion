using GIToolkit.Models;

namespace GIToolkit.Services;

public interface ILauncherServices
{
	string GetLauncherCardSettings(string pathToJsonFile);

	LauncherCardSettings GetLauncherCardSettingsToObject(string pathToJsonFile);

	bool SetLauncherCardSettings(string pathToFolder, string pathToFile, string newLauncherCard);
}
