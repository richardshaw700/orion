using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class SoftwareAzureBlobUpdater : SoftwareUpdaterBase, ISoftwareAzureBlobUpdater, ISoftwareUpdaterBase, IService
{
	private readonly IProcessHelper x6f6SNxsfn;

	private readonly IConfigurationHelper I6a6gJI7Pt;

	private BlobServiceClient n8F6NIWNA2;

	public SoftwareAzureBlobUpdater(IProcessHelper processHelper, IConfigurationHelper configurationHelper)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector(processHelper);
		x6f6SNxsfn = processHelper;
		I6a6gJI7Pt = configurationHelper;
	}

	public void SetupBlobServiceConnection(string connectionStringName)
	{
		try
		{
			I6a6gJI7Pt.ToggleConfigEncryption(Assembly.GetEntryAssembly().Location, protectSection: false);
			string connectionStringByName = I6a6gJI7Pt.GetConnectionStringByName(connectionStringName);
			if (string.IsNullOrWhiteSpace(connectionStringByName))
			{
				throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(2326) + connectionStringName);
			}
			n8F6NIWNA2 = new BlobServiceClient(connectionStringByName);
			if (n8F6NIWNA2 == null && !n8F6NIWNA2.CanGenerateAccountSasUri)
			{
				throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(9638));
			}
		}
		finally
		{
			I6a6gJI7Pt.ToggleConfigEncryption(Assembly.GetEntryAssembly().Location, protectSection: true);
		}
	}

	public bool IsLastVersionInstalled(string exeLocalPath, BlobClient latestBlob)
	{
		if (!File.Exists(exeLocalPath))
		{
			return false;
		}
		Version version = new Version(GetFileVersionInfo(exeLocalPath));
		Version version2 = new Version(latestBlob.GetTags().Value.Tags.FirstOrDefault((KeyValuePair<string, string> x) => x.Key == so95DAFNMfktfjp4Dm.An6v7kuCGg(25466)).Value);
		return version == version2;
	}

	public Version GetBlobItemVersion(BlobClient versionBlob)
	{
		string value = versionBlob.GetTags().Value.Tags.FirstOrDefault((KeyValuePair<string, string> x) => x.Key == so95DAFNMfktfjp4Dm.An6v7kuCGg(25466)).Value;
		if (string.IsNullOrWhiteSpace(value))
		{
			return new Version(-1, -1, -1, -1);
		}
		return new Version(value);
	}

	public async Task<BlobClient> GetTaggedBlob(string containerName, Dictionary<string, string> tags)
	{
		if (n8F6NIWNA2 == null)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(25484));
		}
		BlobContainerClient containerClient = n8F6NIWNA2.GetBlobContainerClient(containerName);
		if (!(await containerClient.ExistsAsync()))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(25784) + containerName + so95DAFNMfktfjp4Dm.An6v7kuCGg(25812));
		}
		TaggedBlobItem taggedBlobItem = await j0G6MW1wHZ(containerName, tags);
		return (taggedBlobItem != null) ? containerClient.GetBlobClient(taggedBlobItem.BlobName) : null;
	}

	private async Task<TaggedBlobItem> zhh6ZltUNZ(string P_0, StateTag P_1)
	{
		if (n8F6NIWNA2 == null)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(25484));
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(25724));
		defaultInterpolatedStringHandler.AppendFormatted(P_1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(20998));
		string tagFilterSqlExpression = defaultInterpolatedStringHandler.ToStringAndClear();
		if (!string.IsNullOrEmpty(P_0))
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(32, 2);
			defaultInterpolatedStringHandler2.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(25662));
			defaultInterpolatedStringHandler2.AppendFormatted(P_0);
			defaultInterpolatedStringHandler2.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(25746));
			defaultInterpolatedStringHandler2.AppendFormatted(Enum.GetName(typeof(StateTag), P_1).ToLower());
			defaultInterpolatedStringHandler2.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(20998));
			tagFilterSqlExpression = defaultInterpolatedStringHandler2.ToStringAndClear();
		}
		await using (IAsyncEnumerator<Page<TaggedBlobItem>> asyncEnumerator = n8F6NIWNA2.FindBlobsByTagsAsync(tagFilterSqlExpression).AsPages().GetAsyncEnumerator())
		{
			if (await asyncEnumerator.MoveNextAsync())
			{
				Page<TaggedBlobItem> current = asyncEnumerator.Current;
				return current.Values.OrderByDescending((TaggedBlobItem x) => x.BlobName).FirstOrDefault();
			}
		}
		return null;
	}

	private async Task<TaggedBlobItem> j0G6MW1wHZ(string P_0, Dictionary<string, string> P_1)
	{
		if (n8F6NIWNA2 == null)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(25484));
		}
		string text = so95DAFNMfktfjp4Dm.An6v7kuCGg(25662) + P_0 + so95DAFNMfktfjp4Dm.An6v7kuCGg(25694);
		if (!string.IsNullOrEmpty(P_0))
		{
			foreach (KeyValuePair<string, string> item in P_1)
			{
				string text2 = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
				defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(23276));
				defaultInterpolatedStringHandler.AppendFormatted(item.Key);
				defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(25710));
				defaultInterpolatedStringHandler.AppendFormatted(item.Value);
				defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(25694));
				text = text2 + defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}
		text = text.Remove(text.Length - 4);
		await using (IAsyncEnumerator<Page<TaggedBlobItem>> asyncEnumerator = n8F6NIWNA2.FindBlobsByTagsAsync(text).AsPages().GetAsyncEnumerator())
		{
			if (await asyncEnumerator.MoveNextAsync())
			{
				Page<TaggedBlobItem> current2 = asyncEnumerator.Current;
				return current2.Values.OrderByDescending((TaggedBlobItem x) => x.BlobName).FirstOrDefault();
			}
		}
		return null;
	}
}
