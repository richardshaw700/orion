using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Security;
using System.Threading.Tasks;
using Azure.Identity;
using Microsoft.Graph;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class MicrosoftGraphService : IMicrosoftGraphService
{
	private ClientSecretCredential TGyx5ITs06;

	private string[] PpdxU5rLiQ;

	public void LoadGraphService(AuthenticationConfig config)
	{
		string tenant = config.Tenant;
		string clientId = config.ClientId;
		string clientSecret = config.ClientSecret;
		TokenCredentialOptions options = new TokenCredentialOptions
		{
			AuthorityHost = AzureAuthorityHosts.AzurePublicCloud
		};
		TGyx5ITs06 = new ClientSecretCredential(tenant, clientId, clientSecret, options);
		try
		{
			new GraphServiceClient(TGyx5ITs06);
		}
		catch (Exception)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(4778));
		}
	}

	public async Task<IEnumerable<DriveItem>> GetItemsOfDrive(string driveId)
	{
		if (TGyx5ITs06 == null)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(22966));
		}
		GraphServiceClient graphServiceClient = new GraphServiceClient(TGyx5ITs06);
		List<QueryOption> options = new List<QueryOption>
		{
			new QueryOption(so95DAFNMfktfjp4Dm.An6v7kuCGg(23062), so95DAFNMfktfjp4Dm.An6v7kuCGg(23078))
		};
		return await graphServiceClient.Drives[driveId].Items.Request(options).GetAsync();
	}

	public async Task<IEnumerable<DriveItem>> GetItemsOfFolder(string driveId, string itemId)
	{
		if (TGyx5ITs06 == null)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(22966));
		}
		GraphServiceClient graphServiceClient = new GraphServiceClient(TGyx5ITs06);
		List<QueryOption> options = new List<QueryOption>
		{
			new QueryOption(so95DAFNMfktfjp4Dm.An6v7kuCGg(23062), so95DAFNMfktfjp4Dm.An6v7kuCGg(23078))
		};
		return await graphServiceClient.Drives[driveId].Items[itemId].Children.Request(options).GetAsync();
	}

	public async Task DownloadFile(string pathFileToSave, DriveItem file, Action<object, DownloadProgressChangedEventArgs> onProgress, Action<object, AsyncCompletedEventArgs> onCompleted)
	{
		file.AdditionalData.TryGetValue(so95DAFNMfktfjp4Dm.An6v7kuCGg(10786), out var value);
		await p4Zx1VYEyI(pathFileToSave, value.ToString(), onProgress, onCompleted);
	}

	public async Task DownloadFile(string pathFileToSave, string downloadUrl, Action<object, DownloadProgressChangedEventArgs> onProgress, Action<object, AsyncCompletedEventArgs> onCompleted)
	{
		await p4Zx1VYEyI(pathFileToSave, downloadUrl, onProgress, onCompleted);
	}

	private async Task p4Zx1VYEyI(string P_0, string P_1, Action<object, DownloadProgressChangedEventArgs> P_2, Action<object, AsyncCompletedEventArgs> P_3)
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFileCompleted += P_3.Invoke;
		webClient.DownloadProgressChanged += P_2.Invoke;
		await webClient.DownloadFileTaskAsync(new Uri(P_1), P_0);
	}

	private SecureString P7ZxbMLSEC(string P_0)
	{
		SecureString secureString = new SecureString();
		char[] array = P_0.ToCharArray();
		foreach (char c in array)
		{
			secureString.AppendChar(c);
		}
		return secureString;
	}

	public MicrosoftGraphService()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		PpdxU5rLiQ = new string[1] { so95DAFNMfktfjp4Dm.An6v7kuCGg(4884) };
		base._002Ector();
	}
}
