using GIToolkit.Services;
using GolfInLauncher.ViewModels;

namespace GolfInLauncher.Services;

public interface ILauncherSettings : IService
{
	string EnglishCulture { get; }

	string FrenchCulture { get; }

	string AssignedCulture { get; set; }

	BusinessType BusinessType { get; set; }

	string CustomerPin { get; set; }

	bool StartLauncherOnComputerStartup { get; set; }

	LaunchOptions LaunchOptions { get; set; }

	bool IsInAdminMode { get; set; }

	string GetAdminPassword();

	string GetAdminEmployeePassword();

	void SetDefaultSettings();
}
