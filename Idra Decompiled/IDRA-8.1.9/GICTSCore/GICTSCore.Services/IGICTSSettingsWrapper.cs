using System;
using System.IO;
using System.Threading.Tasks;
using GICTS.Data;
using GIToolkit.Services;

namespace GICTSCore.Services;

public interface IGICTSSettingsWrapper : IService
{
	int LoopBeforeAbandon { get; set; }

	int LoopWaitTimeMS { get; set; }

	Action<GICTSSettings, FileInfo> OnSettingsModified { get; set; }

	bool IsFileLocked(FileInfo file);

	Task<GICTSSettings> LoadSettings(string filePath);

	Task MonitorSettings(string filePath);

	Task<bool> SaveSettings(IGICTSSettings newSettings, string filePath);

	void SetLogger(ICircularLogService logger);

	Task ShowSettings(string filePath);

	Task<bool> WaitForFileIsUnlocked(FileInfo fileName);
}
