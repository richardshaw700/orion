using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Storage.Blobs;

namespace GIToolkit.Services;

public interface ISoftwareAzureBlobUpdater : ISoftwareUpdaterBase, IService
{
	Task<BlobClient> GetTaggedBlob(string containerName, Dictionary<string, string> tags);

	bool IsLastVersionInstalled(string exeLocalPath, BlobClient latestBlob);

	Version GetBlobItemVersion(BlobClient versionBlob);

	void SetupBlobServiceConnection(string connectionStringName);
}
