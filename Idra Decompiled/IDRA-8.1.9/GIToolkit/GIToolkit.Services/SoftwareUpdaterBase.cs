using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GIToolkit.Model;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class SoftwareUpdaterBase : ISoftwareUpdaterBase, IService
{
	private readonly IProcessHelper OB0E6ZdVg2;

	public SoftwareUpdaterBase(IProcessHelper processHelper)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		OB0E6ZdVg2 = processHelper;
	}

	public string GetFileVersionInfo(string pathToFile)
	{
		return (FileVersionInfo.GetVersionInfo(pathToFile) ?? throw new ArgumentNullException()).FileVersion;
	}

	public async Task<long> GetRemoteFileSize(Uri uriPath)
	{
		using HttpClient client = new HttpClient();
		using HttpResponseMessage httpResponseMessage = await client.SendAsync(new HttpRequestMessage(HttpMethod.Head, uriPath));
		httpResponseMessage.EnsureSuccessStatusCode();
		if (!httpResponseMessage.Content.Headers.ContentLength.HasValue || httpResponseMessage.Content.Headers.ContentLength <= 0)
		{
			throw new ArgumentException(so95DAFNMfktfjp4Dm.An6v7kuCGg(26012));
		}
		return httpResponseMessage.Content.Headers.ContentLength.Value;
	}

	public async Task<bool> IsURLValid(Uri uriPath)
	{
		try
		{
			using HttpClient client = new HttpClient();
			using HttpResponseMessage httpResponseMessage = await client.SendAsync(new HttpRequestMessage(HttpMethod.Head, uriPath));
			httpResponseMessage.EnsureSuccessStatusCode();
			return true;
		}
		catch
		{
			return false;
		}
	}

	public async Task<string> DownloadWebFile(DownloadWebFileOptions option)
	{
		using HttpClient httpClient = new HttpClient();
		string text = Path.Combine(Path.GetTempPath(), option.OutputTempHostFolderName);
		Directory.CreateDirectory(text);
		string localFilePath = Path.Combine(text, option.OutputFileName);
		FileInfo fileInfo = new FileInfo(localFilePath);
		long localFileSize = (fileInfo.Exists ? fileInfo.Length : 0);
		long remoteFileSize = await GetRemoteFileSize(new Uri(option.HttpUrlRequest));
		if (localFileSize == remoteFileSize)
		{
			return localFilePath;
		}
		if (localFileSize > 0)
		{
			httpClient.DefaultRequestHeaders.Range = new RangeHeaderValue(localFileSize, remoteFileSize);
		}
		using HttpResponseMessage response = await httpClient.GetAsync(option.HttpUrlRequest, HttpCompletionOption.ResponseHeadersRead, option.CancellationToken);
		response.EnsureSuccessStatusCode();
		using FileStream fileStream = new FileStream(localFilePath, FileMode.Append, FileAccess.Write, FileShare.None, 4096, useAsync: true);
		using Stream contentStream = await response.Content.ReadAsStreamAsync();
		byte[] buffer = new byte[4096];
		long totalDownloadedBytes = localFileSize;
		while (true)
		{
			int num;
			int bytesRead = (num = await contentStream.ReadAsync(buffer, option.CancellationToken));
			if (num <= 0)
			{
				break;
			}
			await fileStream.WriteAsync(buffer.AsMemory(0, bytesRead), option.CancellationToken);
			totalDownloadedBytes += bytesRead;
			if (bytesRead > 0)
			{
				option.OnProgress?.Invoke(totalDownloadedBytes, remoteFileSize);
			}
		}
		fileStream.Flush();
		if (new FileInfo(localFilePath).Length != remoteFileSize)
		{
			throw new IOException(so95DAFNMfktfjp4Dm.An6v7kuCGg(25876));
		}
		option.OnCompleted?.Invoke();
		return localFilePath;
	}

	public async Task<ErrorCode> InstallFile(string downloadedFilePath, string softwareName)
	{
		try
		{
			if (!File.Exists(downloadedFilePath))
			{
				return new ErrorCode(success: false, so95DAFNMfktfjp4Dm.An6v7kuCGg(26072));
			}
			await OB0E6ZdVg2.InstallProductPackages(downloadedFilePath);
			return new ErrorCode(success: true, string.Empty);
		}
		catch (Exception ex)
		{
			return new ErrorCode(success: false, so95DAFNMfktfjp4Dm.An6v7kuCGg(26190) + softwareName + so95DAFNMfktfjp4Dm.An6v7kuCGg(26228) + ex.Message);
		}
	}
}
