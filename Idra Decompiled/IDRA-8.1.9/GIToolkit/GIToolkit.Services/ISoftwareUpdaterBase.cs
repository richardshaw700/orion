using System;
using System.Threading.Tasks;
using GIToolkit.Model;

namespace GIToolkit.Services;

public interface ISoftwareUpdaterBase : IService
{
	Task<string> DownloadWebFile(DownloadWebFileOptions option);

	string GetFileVersionInfo(string pathToFile);

	Task<long> GetRemoteFileSize(Uri uriPath);

	Task<ErrorCode> InstallFile(string downloadedFilePath, string softwareName);

	Task<bool> IsURLValid(Uri uriPath);
}
