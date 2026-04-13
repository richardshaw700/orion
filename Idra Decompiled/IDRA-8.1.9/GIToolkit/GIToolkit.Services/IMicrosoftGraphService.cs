using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Graph;

namespace GIToolkit.Services;

public interface IMicrosoftGraphService
{
	void LoadGraphService(AuthenticationConfig config);

	Task DownloadFile(string pathFileToSave, DriveItem file, Action<object, DownloadProgressChangedEventArgs> onProgress, Action<object, AsyncCompletedEventArgs> onCompleted);

	Task DownloadFile(string pathFileToSave, string downloadUrl, Action<object, DownloadProgressChangedEventArgs> onProgress, Action<object, AsyncCompletedEventArgs> onCompleted);

	Task<IEnumerable<DriveItem>> GetItemsOfDrive(string driveId);

	Task<IEnumerable<DriveItem>> GetItemsOfFolder(string driveId, string itemId);
}
