using System.Collections.Generic;
using GIToolkit.Model;
using GIToolkit.Models;
using GIToolkit.Services;
using Tree.Structures;

namespace GolfInLauncher.Services;

public interface ILauncherConfiguration : IService
{
	LauncherCardSettings GetOrSetAllLaucherCard();

	void SaveSettings(LauncherCardSettings settings);

	bool VerifyFileExist(LauncherCard card);

	ErrorCode LaunchProgram(List<SerializableCardLeaf> fromList, string programNameToLaunch);
}
