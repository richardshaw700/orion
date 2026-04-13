using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using GICTS.Data;
using GICTSCore.Data;
using GIToolkit.Model;
using GIToolkit.Services;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;

namespace GICTSCore.Services;

public class GSProServices : IGSProServices, IService
{
	private readonly IIOHelper tiVH4vM3n8;

	private readonly IGICTSSettingsWrapper MPGH3iDKDs;

	private readonly ISoftwareUpdaterBase UYnHl9iqlg;

	private readonly IProcessHelper m19HiYNUsJ;

	public GSProServices(IIOHelper ioHelper, IGICTSSettingsWrapper gICTSSettingsWrapper, ISoftwareUpdaterBase softwareUpdaterBase, IProcessHelper processHelper)
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
		tiVH4vM3n8 = ioHelper;
		MPGH3iDKDs = gICTSSettingsWrapper;
		UYnHl9iqlg = softwareUpdaterBase;
		m19HiYNUsJ = processHelper;
	}

	public void UninstallGSProLauncher()
	{
		if (m19HiYNUsJ.IsProcessRunning(IDRAConstant.GSProProcessName))
		{
			return;
		}
		string[] gSPLauncherFilePathDelete = IDRAConstant.GSPLauncherFilePathDelete;
		foreach (string text in gSPLauncherFilePathDelete)
		{
			if (!tiVH4vM3n8.FileExists(text))
			{
				break;
			}
			try
			{
				tiVH4vM3n8.FileDelete(text);
			}
			catch
			{
			}
		}
	}

	public async Task<bool> VerifyNewGSProVersion()
	{
		if (m19HiYNUsJ.IsProcessRunning(IDRAConstant.GSProProcessName))
		{
			return false;
		}
		Version currentGSProVersion = yGMHdbNZKH();
		Version stableVersion = await GetGSProStableVersion();
		if (stableVersion <= IDRAConstant.StableSupportedGSProVersion)
		{
			stableVersion = IDRAConstant.StableSupportedGSProVersion;
			await GABHkh2lGd(stableVersion);
		}
		return stableVersion != currentGSProVersion;
	}

	private async Task GABHkh2lGd(Version P_0)
	{
		GICTSSettings gICTSSettings = await MPGH3iDKDs.LoadSettings(IDRAConstant.GICTSSettingsFilePath);
		gICTSSettings.StableGSProVersion = P_0.ToString();
		await MPGH3iDKDs.SaveSettings(gICTSSettings, IDRAConstant.GICTSSettingsFilePath);
	}

	public async Task<Version> GetGSProStableVersion()
	{
		if (!Version.TryParse((await MPGH3iDKDs.LoadSettings(IDRAConstant.GICTSSettingsFilePath)).StableGSProVersion, out Version result))
		{
			throw new Exception(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(21762));
		}
		return result;
	}

	private Version yGMHdbNZKH()
	{
		if (!tiVH4vM3n8.FileExists(IDRAConstant.GSProVersionFilePath))
		{
			return null;
		}
		string input = tiVH4vM3n8.FileReadAllText(IDRAConstant.GSProVersionFilePath);
		string pattern = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12630);
		Match match = Regex.Match(input, pattern);
		if (!match.Success)
		{
			return null;
		}
		if (!Version.TryParse(match.Groups[1].Value, out Version result))
		{
			return null;
		}
		return result;
	}

	public async Task<bool> InstallNewGSProVersion(Version versionToInstall, Action<long, long> onProgress, Action onCompleted)
	{
		string httpUrlRequest = await aPuHNaBm77(versionToInstall);
		CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
		ISoftwareUpdaterBase uYnHl9iqlg = UYnHl9iqlg;
		string gSProTempDownloadZipName = IDRAConstant.GSProTempDownloadZipName;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
		defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(22198));
		defaultInterpolatedStringHandler.AppendFormatted(versionToInstall);
		string text = await uYnHl9iqlg.DownloadWebFile(new DownloadWebFileOptions(httpUrlRequest, gSProTempDownloadZipName, defaultInterpolatedStringHandler.ToStringAndClear())
		{
			OnProgress = onProgress,
			OnCompleted = onCompleted,
			CancellationToken = cancellationTokenSource.Token
		});
		if (string.IsNullOrWhiteSpace(text) || !tiVH4vM3n8.FileExists(text))
		{
			return false;
		}
		ZipFile.ExtractToDirectory(text, IDRAConstant.GSProInstalledDirectoryPath, overwriteFiles: true);
		ypUH5NrkLG(versionToInstall);
		return true;
	}

	private async Task<string> aPuHNaBm77(Version P_0)
	{
		string url = string.Concat(str1: P_0.ToString(), str0: YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(21880), str2: YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(21970));
		if (await UYnHl9iqlg.IsURLValid(new Uri(url)))
		{
			return url;
		}
		string versionStr = P_0.ToString(3);
		url = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(21880) + versionStr + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(21970);
		if (await UYnHl9iqlg.IsURLValid(new Uri(url)))
		{
			return url;
		}
		throw new Exception(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(21982) + versionStr + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(22042));
	}

	private void ypUH5NrkLG(Version P_0)
	{
		if (tiVH4vM3n8.FileExists(IDRAConstant.GSProVersionFilePath))
		{
			IIOHelper iIOHelper = tiVH4vM3n8;
			string gSProVersionFilePath = IDRAConstant.GSProVersionFilePath;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12682));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			iIOHelper.FileWriteAllText(gSProVersionFilePath, defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	public async Task<ErrorCode> ApplyGolfInMod()
	{
		try
		{
			if (!GjjHWFlgYf())
			{
				return new ErrorCode(success: false, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(21524), 400);
			}
			RY5Hc7xDwn();
			if (xDRHJPvIYA())
			{
				Process processByName = m19HiYNUsJ.GetProcessByName(IDRAConstant.GSProProcessName);
				if (processByName != null)
				{
					try
					{
						processByName.Kill();
						await Task.Delay(checked((int)TimeSpan.FromMilliseconds(500.0).TotalMilliseconds));
					}
					catch (Exception)
					{
						return new ErrorCode(success: false, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(21610), 405);
					}
				}
				tiVH4vM3n8.DirectoryCopy(IDRAConstant.GolfInPluginModFilesFolderPath, IDRAConstant.GSProFolderPath, copySubDirs: true);
			}
			return new ErrorCode(success: true);
		}
		catch (Exception ex2)
		{
			EventViewerLogger.LogException(ex2);
			return new ErrorCode(success: false, ex2.Message, 500);
		}
	}

	private void RY5Hc7xDwn()
	{
		string path = Path.Combine(IDRAConstant.GSProInstalledDirectoryPath, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12688));
		try
		{
			if (File.Exists(path))
			{
				File.Delete(path);
			}
		}
		catch (UnauthorizedAccessException)
		{
		}
		catch (Exception ex2)
		{
			EventViewerLogger.LogException(ex2);
		}
	}

	private bool GjjHWFlgYf()
	{
		if (!RegistryService.IsProgramInstalled(IDRAConstant.GSProRegistryUninstallDisplayNameV1))
		{
			return RegistryService.IsProgramInstalled(IDRAConstant.GSProRegistryUninstallDisplayNameV3);
		}
		return true;
	}

	private bool xDRHJPvIYA()
	{
		try
		{
			string fileVersionInfo = tiVH4vM3n8.GetFileVersionInfo(IDRAConstant.CurrentBepInExGIPluginDllFilePath, isForFileVersion: true);
			return tiVH4vM3n8.GetFileVersionInfo(IDRAConstant.NewBepInExGIPluginDllFilePath, isForFileVersion: true) != fileVersionInfo;
		}
		catch (Exception)
		{
			return true;
		}
	}
}
