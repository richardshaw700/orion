using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Storage.Files.Shares.Models;
using GIToolkit.Model;

namespace GIToolkit.Services;

public interface IAzureStorageFileShareService : IService
{
	void SetupServiceConnection(string connectionStringName, string fileShareName);

	Task<bool> UploadShot(LogRegistration model);

	IEnumerable<ShareFileItem> GetDirectoriesOrdered();

	Task<ShareDirectoryProperties> GetDirectoryProperties(string folderName);

	Task<ShareFileProperties> GetFileProperties(string parentFolderName, string fileName);

	Task<bool> SetNewMetaData(string folderName, Dictionary<string, string> newMetadata);

	Task<string> TryReadFileContent(string parentFolderName, string fileName);
}
