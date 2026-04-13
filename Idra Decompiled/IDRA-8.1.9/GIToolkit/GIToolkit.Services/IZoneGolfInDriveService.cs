using System;
using System.ComponentModel;
using System.Net;
using System.Threading.Tasks;
using GIToolkit.Model;

namespace GIToolkit.Services;

public interface IZoneGolfInDriveService
{
	IZoneGolfInDriveFile CurrentDriveFile { get; }

	ProductVersionInfo DownloadedProductInfo { get; }

	ProductVersionInfo InstalledProductInfo { get; }

	Task DownloadExecutableDriveFile(Action<object, DownloadProgressChangedEventArgs> onProgress, Action<object, AsyncCompletedEventArgs> onCompleted);

	Task DownloadFile(Action<object, DownloadProgressChangedEventArgs> onProgress, Action<object, AsyncCompletedEventArgs> onCompleted);

	bool DriveFileIsInstalledOnPC();

	bool DriveFileLastUpdateHasBeenDownloaded();

	bool DriveFileUpdateIsNeeded();

	Version GetDownloadedVersion();

	Version GetInstalledVersion();

	Task<ErrorCode> InstallPackageDriveFile();

	Task SetCurrentDriveFile(IZoneGolfInDriveFile newCurrentDriveFile, string downloadPath = "");
}
