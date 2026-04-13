using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class PowershellService : IPowershellService
{
	public async Task<ProductVersionInfo> GetPackageProductVersionInfo(string filePath)
	{
		if (!File.Exists(filePath))
		{
			return null;
		}
		try
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(484, 2);
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(23894));
			defaultInterpolatedStringHandler.AppendFormatted(filePath);
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(23958));
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(24054));
			defaultInterpolatedStringHandler.AppendFormatted(filePath);
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(24118));
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(24172));
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(24436));
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(24648));
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(24812));
			string scriptPlainText = defaultInterpolatedStringHandler.ToStringAndClear();
			return JsonConvert.DeserializeObject<ProductVersionInfo>(await ExecutePowerShellScript(scriptPlainText));
		}
		catch (Exception)
		{
			return null;
		}
	}

	public async Task<ProductVersionInfo> GetInstalledPackageProductVersionInfo(string productName)
	{
		if (string.IsNullOrWhiteSpace(productName))
		{
			return null;
		}
		try
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(213, 1);
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(23452));
			defaultInterpolatedStringHandler.AppendFormatted(productName);
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(23564));
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(23650));
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(23858));
			string scriptPlainText = defaultInterpolatedStringHandler.ToStringAndClear();
			InstalledProductVersionInfo installedProductVersionInfo = JsonConvert.DeserializeObject<InstalledProductVersionInfo>(await ExecutePowerShellScript(scriptPlainText));
			if (installedProductVersionInfo == null)
			{
				return null;
			}
			bool num = installedProductVersionInfo.ProductName.Any() && installedProductVersionInfo.ProductVersion.Any();
			bool flag = installedProductVersionInfo.ProductName.Count == installedProductVersionInfo.ProductVersion.Count;
			string text = installedProductVersionInfo.ProductName.FirstOrDefault();
			string text2 = installedProductVersionInfo.ProductVersion.FirstOrDefault();
			bool flag2 = !string.IsNullOrWhiteSpace(text) && !string.IsNullOrWhiteSpace(text2);
			return (num && flag && flag2) ? new ProductVersionInfo(text, text2) : null;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public async Task<string> ExecutePowerShellScript(string scriptPlainText, double timeOutMin = 15.0)
	{
		string ps1TempFilePath = Path.GetTempPath() + so95DAFNMfktfjp4Dm.An6v7kuCGg(23098);
		Directory.CreateDirectory(Path.GetDirectoryName(ps1TempFilePath));
		using (StreamWriter streamWriter = new StreamWriter(ps1TempFilePath, append: false))
		{
			streamWriter.WriteLine(scriptPlainText);
		}
		string response = string.Empty;
		Task delayTask = Task.Delay(TimeSpan.FromMinutes(timeOutMin));
		try
		{
			using (Process process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = so95DAFNMfktfjp4Dm.An6v7kuCGg(23178),
					Arguments = so95DAFNMfktfjp4Dm.An6v7kuCGg(23210) + ps1TempFilePath + so95DAFNMfktfjp4Dm.An6v7kuCGg(23276),
					WindowStyle = ProcessWindowStyle.Hidden,
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					UseShellExecute = false,
					CreateNoWindow = true,
					Verb = so95DAFNMfktfjp4Dm.An6v7kuCGg(5558)
				}
			})
			{
				process.Start();
				Task<string> responseTask = process.StandardOutput.ReadToEndAsync();
				await Task.WhenAny(responseTask, delayTask);
				if (delayTask.IsCompleted)
				{
					try
					{
						process.Kill();
					}
					catch (Exception)
					{
					}
					throw new TimeoutException(so95DAFNMfktfjp4Dm.An6v7kuCGg(23282));
				}
				response = await responseTask;
				string text = await process.StandardError.ReadToEndAsync();
				if (!string.IsNullOrWhiteSpace(text))
				{
					throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(23370) + text);
				}
			}
			return response;
		}
		finally
		{
			File.Delete(ps1TempFilePath);
		}
	}

	public PowershellService()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
