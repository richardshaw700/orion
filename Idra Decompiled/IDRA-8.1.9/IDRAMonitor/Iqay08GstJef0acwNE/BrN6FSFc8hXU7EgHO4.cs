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
using IDRAMonitor.Services;
using hkpxmGISLhTJrZLcmi;
using jBnbmEXkwPOPpPQ9mC;

namespace Iqay08GstJef0acwNE;

internal class BrN6FSFc8hXU7EgHO4 : IChocolateyVersionFinderService, IService
{
	[CompilerGenerated]
	private ICircularLogService p8eFwSTPhb;

	private readonly string aKKFgudhLj;

	private readonly string l5RFLpVH1P;

	private readonly string rGaFx7NF3N;

	private readonly string dDIFTRRICT;

	public BrN6FSFc8hXU7EgHO4(ICircularLogService P_0)
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		p8eFwSTPhb = P_0;
		aKKFgudhLj = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5270);
		l5RFLpVH1P = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5412);
		rGaFx7NF3N = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5550);
		dDIFTRRICT = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5590);
		base._002Ector();
	}

	public async Task<string> FindLatestProductionVersion(string P_0, IChocolateyVersionFinderService.Environment P_1)
	{
		string latestVersion = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12092);
		try
		{
			string text = ((P_1 == IChocolateyVersionFinderService.Environment.Internal) ? l5RFLpVH1P : aKKFgudhLj);
			ICircularLogService circularLogService = p8eFwSTPhb;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(89, 3);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12248));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12364));
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12408));
			defaultInterpolatedStringHandler.AppendFormatted(text);
			circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear());
			using HttpClient client = new HttpClient();
			string parameter = Convert.ToBase64String(Encoding.ASCII.GetBytes(rGaFx7NF3N + ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(4716) + dDIFTRRICT));
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12438), parameter);
			string requestUri = text + ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12452);
			HttpResponseMessage indexResponse = await client.GetAsync(requestUri);
			if (!indexResponse.IsSuccessStatusCode)
			{
				ICircularLogService circularLogService2 = p8eFwSTPhb;
				object arg = indexResponse.StatusCode;
				string arg2 = await indexResponse.Content.ReadAsStringAsync();
				circularLogService2.Log(string.Format(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12478), arg, arg2));
			}
			using JsonDocument indexDoc = JsonDocument.Parse(await indexResponse.Content.ReadAsStringAsync());
			string text2 = VLGFV1DDh9(indexDoc.RootElement.GetProperty(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12560)));
			if (text2 == null)
			{
				p8eFwSTPhb.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12582));
				return latestVersion;
			}
			string text3 = text2 + ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12696) + P_0 + ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12706);
			return await sj0FQ74fj1(P_0, client, text3);
		}
		catch (Exception ex)
		{
			p8eFwSTPhb.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12744) + ex.Message, LogLevel.Error);
			return latestVersion;
		}
	}

	public async Task<bool> IsUsingProductionChocolateyRepository()
	{
		ProcessStartInfo startInfo = new ProcessStartInfo
		{
			FileName = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12952),
			Arguments = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12966),
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
				p8eFwSTPhb.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12992));
				return true;
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
					p8eFwSTPhb.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(13222) + text);
					return true;
				}
				return !Regex.IsMatch(output, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(13368));
			}
			catch (OperationCanceledException) when (cts.IsCancellationRequested)
			{
				p8eFwSTPhb.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(13410));
				try
				{
					process.Kill();
				}
				catch
				{
				}
				return true;
			}
		}
		catch (Exception ex2)
		{
			p8eFwSTPhb.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(13544) + ex2.Message);
			return true;
		}
	}

	private async Task<string> sj0FQ74fj1(string P_0, HttpClient P_1, string P_2)
	{
		string latestVersion = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12092);
		HttpResponseMessage httpResponseMessage = await P_1.GetAsync(P_2);
		if (!httpResponseMessage.IsSuccessStatusCode)
		{
			ICircularLogService circularLogService = p8eFwSTPhb;
			object arg = httpResponseMessage.StatusCode;
			string arg2 = await httpResponseMessage.Content.ReadAsStringAsync();
			circularLogService.Log(string.Format(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12106), arg, arg2));
			return latestVersion;
		}
		using JsonDocument jsonDocument = JsonDocument.Parse(await httpResponseMessage.Content.ReadAsStringAsync());
		if (!jsonDocument.RootElement.TryGetProperty(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12170), out var value) || value.GetArrayLength() == 0)
		{
			p8eFwSTPhb.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12182));
			return latestVersion;
		}
		foreach (JsonElement item in value.EnumerateArray())
		{
			if (item.TryGetProperty(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12222), out var value2) && string.Equals(value2.GetString(), P_0, StringComparison.OrdinalIgnoreCase) && item.TryGetProperty(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12230), out var value3))
			{
				latestVersion = value3.GetString();
				break;
			}
		}
		return latestVersion;
	}

	private static string VLGFV1DDh9(JsonElement P_0)
	{
		string result = string.Empty;
		foreach (JsonElement item in P_0.EnumerateArray())
		{
			if (item.TryGetProperty(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5608), out var value) && (value.GetString().StartsWith(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5622)) || value.GetString() == ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5662)) && item.TryGetProperty(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5720), out var value2))
			{
				result = value2.GetString();
				break;
			}
		}
		return result;
	}
}
