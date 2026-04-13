using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Azure.Storage.Files.Shares;
using Azure.Storage.Files.Shares.Models;
using GIToolkit.Model;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class AzureStorageFileShareService : IAzureStorageFileShareService, IService
{
	private readonly IConfigurationHelper HopYnkXuML;

	private ShareClient sTrY1XpCUT;

	public AzureStorageFileShareService(IConfigurationHelper configurationHelper)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		HopYnkXuML = configurationHelper;
	}

	public void SetupServiceConnection(string connectionStringName, string fileShareName)
	{
		try
		{
			HopYnkXuML.ToggleConfigEncryption(Assembly.GetEntryAssembly().Location, protectSection: false);
			string connectionStringByName = HopYnkXuML.GetConnectionStringByName(connectionStringName);
			if (string.IsNullOrWhiteSpace(connectionStringByName))
			{
				throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(2326) + connectionStringName);
			}
			sTrY1XpCUT = new ShareClient(connectionStringByName, fileShareName);
			if (sTrY1XpCUT == null && !sTrY1XpCUT.CanGenerateSasUri)
			{
				throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(2438));
			}
		}
		finally
		{
			HopYnkXuML.ToggleConfigEncryption(Assembly.GetEntryAssembly().Location, protectSection: true);
		}
	}

	public async Task<bool> UploadShot(LogRegistration model)
	{
		if (sTrY1XpCUT == null)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(21562));
		}
		if (string.IsNullOrWhiteSpace(model.Title))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(21740));
		}
		if (string.IsNullOrWhiteSpace(model.ShotName))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(21786));
		}
		model.Title = model.Title.Trim();
		model.Notes = model.Notes.Trim();
		model.ShotName = model.ShotName.Trim();
		model.TicketLink = model.TicketLink.Trim();
		string text = model.Title + so95DAFNMfktfjp4Dm.An6v7kuCGg(21842) + model.ShotName;
		if (text.IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(21852));
		}
		ShareDirectoryClient directoryClient = sTrY1XpCUT.GetDirectoryClient(text);
		if (!directoryClient.Exists() && ((await directoryClient.CreateAsync())?.GetRawResponse().IsError ?? true))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(22028));
		}
		string fileName = so95DAFNMfktfjp4Dm.An6v7kuCGg(22086);
		string tempFilePath = Path.GetTempFileName();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(22108));
		defaultInterpolatedStringHandler.AppendFormatted(model.Title);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(22126));
		defaultInterpolatedStringHandler.AppendFormatted(model.ShotName);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(22154));
		defaultInterpolatedStringHandler.AppendFormatted(model.Notes);
		await File.WriteAllTextAsync(tempFilePath, defaultInterpolatedStringHandler.ToStringAndClear());
		if (!(await ca9YlrUEc0(fileName, tempFilePath, directoryClient)))
		{
			return false;
		}
		if (!string.IsNullOrWhiteSpace(model.TicketLink))
		{
			if (!(await akOY8nfjSN(model.TicketLink)))
			{
				throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(22174));
			}
			string ticketLinkFileName = so95DAFNMfktfjp4Dm.An6v7kuCGg(22254);
			string tempTicketLinkFilePath = Path.GetTempFileName();
			await File.WriteAllTextAsync(tempTicketLinkFilePath, so95DAFNMfktfjp4Dm.An6v7kuCGg(22278) + model.TicketLink);
			if (!(await ca9YlrUEc0(ticketLinkFileName, tempTicketLinkFilePath, directoryClient)))
			{
				return false;
			}
		}
		foreach (FileInfo item in model.LogsFile)
		{
			if (item.Exists)
			{
				try
				{
					await ca9YlrUEc0(item.Name, item.FullName, directoryClient);
				}
				catch (Exception)
				{
				}
			}
		}
		return true;
	}

	public IEnumerable<ShareFileItem> GetDirectoriesOrdered()
	{
		return from x in sTrY1XpCUT.GetRootDirectoryClient().GetFilesAndDirectories(new ShareDirectoryGetFilesAndDirectoriesOptions
			{
				IncludeExtendedInfo = true,
				Traits = ShareFileTraits.Timestamps
			})
			where x.IsDirectory
			orderby x.Properties.CreatedOn descending
			select x;
	}

	public async Task<ShareDirectoryProperties> GetDirectoryProperties(string folderName)
	{
		return await WA6Y4l7ZWG(folderName).GetPropertiesAsync();
	}

	public async Task<ShareFileProperties> GetFileProperties(string parentFolderName, string fileName)
	{
		return await w9CYrU4pTB(WA6Y4l7ZWG(parentFolderName), fileName).GetPropertiesAsync();
	}

	public async Task<bool> SetNewMetaData(string folderName, Dictionary<string, string> newMetadata)
	{
		ArgumentNullException.ThrowIfNull(newMetadata, so95DAFNMfktfjp4Dm.An6v7kuCGg(21384));
		return await WA6Y4l7ZWG(folderName).SetMetadataAsync(newMetadata) != null;
	}

	public async Task<string> TryReadFileContent(string parentFolderName, string fileName)
	{
		_ = 1;
		try
		{
			return await new StreamReader((await w9CYrU4pTB(WA6Y4l7ZWG(parentFolderName), fileName).DownloadAsync()).Value.Content).ReadToEndAsync();
		}
		catch
		{
			return string.Empty;
		}
	}

	private ShareDirectoryClient WA6Y4l7ZWG(string P_0)
	{
		if (string.IsNullOrWhiteSpace(P_0))
		{
			throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(2560));
		}
		return sTrY1XpCUT.GetDirectoryClient(P_0);
	}

	private ShareFileClient w9CYrU4pTB(ShareDirectoryClient P_0, string P_1)
	{
		ArgumentNullException.ThrowIfNull(P_0, so95DAFNMfktfjp4Dm.An6v7kuCGg(2584));
		if (string.IsNullOrWhiteSpace(P_1))
		{
			throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(2618));
		}
		return P_0.GetFileClient(P_1);
	}

	private static async Task<bool> akOY8nfjSN(string P_0)
	{
		using HttpClient client = new HttpClient();
		try
		{
			Uri requestUri = (Uri.IsWellFormedUriString(P_0, UriKind.Absolute) ? new Uri(P_0) : new Uri(so95DAFNMfktfjp4Dm.An6v7kuCGg(22328) + P_0));
			HttpResponseMessage httpResponseMessage = await client.GetAsync(requestUri);
			return httpResponseMessage.StatusCode == HttpStatusCode.OK || httpResponseMessage.StatusCode == HttpStatusCode.Found;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private async Task<bool> ca9YlrUEc0(string P_0, string P_1, ShareDirectoryClient P_2)
	{
		ShareFileClient fileClient = P_2.GetFileClient(P_0);
		using FileStream stream = File.OpenRead(P_1);
		if ((await fileClient.CreateAsync(stream.Length))?.GetRawResponse().IsError ?? true)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(21410));
		}
		fileClient.SetHttpHeaders(stream.Length);
		if ((await fileClient.UploadAsync(stream))?.GetRawResponse().IsError ?? true)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(21486));
		}
		return true;
	}
}
