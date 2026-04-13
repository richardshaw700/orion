using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using GIToolkit.Services;
using Lmttrs0IQc7UR7Zpt6;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Services.SoftwareUpdate;

public class ChocolateyLatestVersionFinder : IChocolateyLatestVersionFinder, IService
{
	[CompilerGenerated]
	private ICircularLogService gXG3JWJ72G;

	private readonly string kaQ37duRKY;

	private readonly string haK3vXwIko;

	private readonly string n6s3BSAAwK;

	private readonly string AGM3WdYfga;

	private readonly string sYG3MDhIG8;

	public ChocolateyLatestVersionFinder(ICircularLogService _circularLogService)
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		gXG3JWJ72G = _circularLogService;
		kaQ37duRKY = aL07ImwcwlxdnyfI30.olMQlwrxmw(13074);
		haK3vXwIko = aL07ImwcwlxdnyfI30.olMQlwrxmw(13216);
		n6s3BSAAwK = aL07ImwcwlxdnyfI30.olMQlwrxmw(13368);
		AGM3WdYfga = aL07ImwcwlxdnyfI30.olMQlwrxmw(13506);
		sYG3MDhIG8 = aL07ImwcwlxdnyfI30.olMQlwrxmw(13546);
		base._002Ector();
	}

	public async Task<string> FindPackageLatestVersionNumber(string packageId)
	{
		string baseUrl = string.Empty;
		IChocolateyLatestVersionFinder.Environment environment = await GetEnvironmentFromUsedChocolateySourceAsync();
		switch (environment)
		{
		case IChocolateyLatestVersionFinder.Environment.Internal:
			baseUrl = n6s3BSAAwK;
			break;
		case IChocolateyLatestVersionFinder.Environment.Prod:
			baseUrl = kaQ37duRKY;
			break;
		case IChocolateyLatestVersionFinder.Environment.ProdBeta:
			baseUrl = haK3vXwIko;
			break;
		case IChocolateyLatestVersionFinder.Environment.Unknown:
			return aL07ImwcwlxdnyfI30.olMQlwrxmw(20640);
		}
		ICircularLogService circularLogService = gXG3JWJ72G;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(89, 3);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(20650));
		defaultInterpolatedStringHandler.AppendFormatted(packageId);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(20766));
		defaultInterpolatedStringHandler.AppendFormatted(environment);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(20810));
		defaultInterpolatedStringHandler.AppendFormatted(baseUrl);
		circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		using HttpClient client = new HttpClient();
		string parameter = Convert.ToBase64String(Encoding.ASCII.GetBytes(AGM3WdYfga + aL07ImwcwlxdnyfI30.olMQlwrxmw(20840) + sYG3MDhIG8));
		client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(aL07ImwcwlxdnyfI30.olMQlwrxmw(20846), parameter);
		string requestUri = baseUrl + aL07ImwcwlxdnyfI30.olMQlwrxmw(20860);
		HttpResponseMessage indexResponse = await client.GetAsync(requestUri);
		if (!indexResponse.IsSuccessStatusCode)
		{
			ICircularLogService circularLogService2 = gXG3JWJ72G;
			object arg = indexResponse.StatusCode;
			string arg2 = await indexResponse.Content.ReadAsStringAsync();
			circularLogService2.Log(string.Format(aL07ImwcwlxdnyfI30.olMQlwrxmw(20886), arg, arg2));
		}
		using JsonDocument indexDoc = JsonDocument.Parse(await indexResponse.Content.ReadAsStringAsync());
		string text = rTO3Pi5gys(indexDoc.RootElement.GetProperty(aL07ImwcwlxdnyfI30.olMQlwrxmw(20968)));
		if (text == null)
		{
			gXG3JWJ72G.Log(aL07ImwcwlxdnyfI30.olMQlwrxmw(20990));
			return aL07ImwcwlxdnyfI30.olMQlwrxmw(20484);
		}
		string text2 = text + aL07ImwcwlxdnyfI30.olMQlwrxmw(21104) + packageId + aL07ImwcwlxdnyfI30.olMQlwrxmw(21114);
		return await bi53iW7UAc(packageId, client, text2);
	}

	public async Task<IChocolateyLatestVersionFinder.Environment> GetEnvironmentFromUsedChocolateySourceAsync()
	{
		ProcessStartInfo startInfo = new ProcessStartInfo
		{
			FileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(21152),
			Arguments = aL07ImwcwlxdnyfI30.olMQlwrxmw(21166),
			RedirectStandardOutput = true,
			RedirectStandardError = true,
			UseShellExecute = false,
			CreateNoWindow = true
		};
		try
		{
			using Process process = Process.Start(startInfo);
			if (process == null)
			{
				gXG3JWJ72G.Log(aL07ImwcwlxdnyfI30.olMQlwrxmw(21192));
				return IChocolateyLatestVersionFinder.Environment.Unknown;
			}
			Task<string> readOutputTask = process.StandardOutput.ReadToEndAsync();
			Task<string> readErrorTask = process.StandardError.ReadToEndAsync();
			using CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromSeconds(30.0));
			CancellationToken token = cts.Token;
			try
			{
				await process.WaitForExitAsync(token);
				string output = await readOutputTask;
				string text = await readErrorTask;
				if (process.ExitCode != 0)
				{
					gXG3JWJ72G.Log(aL07ImwcwlxdnyfI30.olMQlwrxmw(21422) + text);
					return IChocolateyLatestVersionFinder.Environment.Unknown;
				}
				if (Regex.IsMatch(output, aL07ImwcwlxdnyfI30.olMQlwrxmw(21568)))
				{
					return IChocolateyLatestVersionFinder.Environment.Internal;
				}
				if (Regex.IsMatch(output, aL07ImwcwlxdnyfI30.olMQlwrxmw(21610)))
				{
					return IChocolateyLatestVersionFinder.Environment.ProdBeta;
				}
				if (Regex.IsMatch(output, aL07ImwcwlxdnyfI30.olMQlwrxmw(21666)))
				{
					return IChocolateyLatestVersionFinder.Environment.Prod;
				}
			}
			catch (OperationCanceledException) when (cts.IsCancellationRequested)
			{
				gXG3JWJ72G.Log(aL07ImwcwlxdnyfI30.olMQlwrxmw(21712));
				try
				{
					process.Kill();
				}
				catch
				{
				}
				return IChocolateyLatestVersionFinder.Environment.Unknown;
			}
		}
		catch (Exception ex2)
		{
			gXG3JWJ72G.Log(aL07ImwcwlxdnyfI30.olMQlwrxmw(21846) + ex2.Message);
			return IChocolateyLatestVersionFinder.Environment.Unknown;
		}
		return IChocolateyLatestVersionFinder.Environment.Unknown;
	}

	private async Task<string> bi53iW7UAc(string P_0, HttpClient P_1, string P_2)
	{
		string latestVersion = aL07ImwcwlxdnyfI30.olMQlwrxmw(20484);
		HttpResponseMessage httpResponseMessage = await P_1.GetAsync(P_2);
		if (!httpResponseMessage.IsSuccessStatusCode)
		{
			ICircularLogService circularLogService = gXG3JWJ72G;
			object arg = httpResponseMessage.StatusCode;
			string arg2 = await httpResponseMessage.Content.ReadAsStringAsync();
			circularLogService.Log(string.Format(aL07ImwcwlxdnyfI30.olMQlwrxmw(20498), arg, arg2));
			return latestVersion;
		}
		using JsonDocument jsonDocument = JsonDocument.Parse(await httpResponseMessage.Content.ReadAsStringAsync());
		if (!jsonDocument.RootElement.TryGetProperty(aL07ImwcwlxdnyfI30.olMQlwrxmw(20562), out var value) || value.GetArrayLength() == 0)
		{
			gXG3JWJ72G.Log(aL07ImwcwlxdnyfI30.olMQlwrxmw(20574));
			return latestVersion;
		}
		foreach (JsonElement item in value.EnumerateArray())
		{
			if (item.TryGetProperty(aL07ImwcwlxdnyfI30.olMQlwrxmw(20614), out var value2) && string.Equals(value2.GetString(), P_0, StringComparison.OrdinalIgnoreCase) && item.TryGetProperty(aL07ImwcwlxdnyfI30.olMQlwrxmw(20622), out var value3))
			{
				latestVersion = value3.GetString();
				break;
			}
		}
		return latestVersion;
	}

	private static string rTO3Pi5gys(JsonElement P_0)
	{
		string result = string.Empty;
		foreach (JsonElement item in P_0.EnumerateArray())
		{
			if (item.TryGetProperty(aL07ImwcwlxdnyfI30.olMQlwrxmw(13564), out var value) && (value.GetString().StartsWith(aL07ImwcwlxdnyfI30.olMQlwrxmw(13578)) || value.GetString() == aL07ImwcwlxdnyfI30.olMQlwrxmw(13618)) && item.TryGetProperty(aL07ImwcwlxdnyfI30.olMQlwrxmw(13676), out var value2))
			{
				result = value2.GetString();
				break;
			}
		}
		return result;
	}
}
