using System.Collections.Generic;
using System.IO;
using GICTS.Data;
using GIToolkit.Services;

namespace GICTSCore.Services;

public interface ISpaceCleanUpService : IService
{
	void DeleteShot(CTSShotData newShot);

	void FreeUpSpace(DirectoryInfo path, int numberOfGB, int minimumNumberOfShotsToKeep);

	List<string> GetFirstShotDirectories(DirectoryInfo pathDir);

	DirectoryInfo GetFirstShotDirectory(string defaultPath);

	DirectoryInfo GetLastShotDirectory(string defaultPath);

	string GetLastShotName(string defaultPath);

	int GetNumberOfShots(string pathToMonitor);

	void KeepFreeSpace(int numberOfGB, int minimumNumberOfShotsToKeep);
}
