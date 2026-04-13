using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using GICTS.Data;
using GICTSCore.Data;
using GIToolkit.Helpers;
using GIToolkit.Services;
using JdN3qlxpK1fXeWoSKd;
using Newtonsoft.Json;
using lKEAGvFqWp7B16kDoY;

namespace GICTSCore.Services;

public class GICTSSettingsWrapper : IGICTSSettingsWrapper, IService
{
	[CompilerGenerated]
	private Action<GICTSSettings, FileInfo> XKsH9rFpC4;

	[CompilerGenerated]
	private int ELZHAOZIFu;

	[CompilerGenerated]
	private int rycHjL7K4v;

	private FileSystemWatcher kLqH6YsttN;

	private ICircularLogService HwuH1902sA;

	public Action<GICTSSettings, FileInfo> OnSettingsModified
	{
		[CompilerGenerated]
		get
		{
			return XKsH9rFpC4;
		}
		[CompilerGenerated]
		set
		{
			XKsH9rFpC4 = value;
		}
	}

	public int LoopBeforeAbandon
	{
		[CompilerGenerated]
		get
		{
			return ELZHAOZIFu;
		}
		[CompilerGenerated]
		set
		{
			ELZHAOZIFu = value;
		}
	}

	public int LoopWaitTimeMS
	{
		[CompilerGenerated]
		get
		{
			return rycHjL7K4v;
		}
		[CompilerGenerated]
		set
		{
			rycHjL7K4v = value;
		}
	}

	public GICTSSettingsWrapper()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		ELZHAOZIFu = 1000;
		rycHjL7K4v = 100;
		base._002Ector();
		lYBHhaAyNL();
	}

	private void lYBHhaAyNL()
	{
		try
		{
			new FileInfo(IDRAConstant.GICTSDefaultInstallationFilePath).CopyTo(IDRAConstant.GICTSDefaultSettingsFilePath, overwrite: true);
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
		}
	}

	public void SetLogger(ICircularLogService logger)
	{
		HwuH1902sA = logger;
	}

	public async Task<GICTSSettings> LoadSettings(string filePath)
	{
		FileInfo fileInfo = new FileInfo(filePath);
		await iX3HteuZnb(fileInfo);
		return JsonConvert.DeserializeObject<GICTSSettings>(fileInfo.ReadAllTextWithBackup());
	}

	private async Task iX3HteuZnb(FileInfo P_0)
	{
		Directory.CreateDirectory(IDRAConstant.GICTSDataFolder);
		if (!P_0.Exists)
		{
			string contents = JsonConvert.SerializeObject(new GICTSSettings
			{
				ClubSettings = new ClubSettings(),
				InsertSettings = new InsertSettings(),
				ShotAdsjustementSettings = new ShotAdsjustementSettings(),
				E6ConfigsSettings = new E6ConfigsSettings(),
				E6LimitsSettings = new E6LimitsSettings()
			}, Formatting.Indented);
			P_0.WriteAllTextWithBackup(contents);
		}
		await WaitForFileIsUnlocked(P_0);
	}

	public async Task<bool> SaveSettings(IGICTSSettings newSettings, string filePath)
	{
		FileInfo file = new FileInfo(filePath);
		await iX3HteuZnb(file);
		try
		{
			file.WriteAllTextWithBackup(JsonConvert.SerializeObject(newSettings, Formatting.Indented));
			OnSettingsModified?.Invoke(await LoadSettings(filePath), file);
			return true;
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
			return false;
		}
	}

	public async Task<bool> WaitForFileIsUnlocked(FileInfo file)
	{
		bool result = true;
		int safeCounter = 0;
		while (IsFileLocked(file))
		{
			int num = checked(safeCounter + 1);
			safeCounter = num;
			if (num >= LoopBeforeAbandon)
			{
				break;
			}
			await Task.Delay(LoopWaitTimeMS);
		}
		if (IsFileLocked(file))
		{
			result = false;
		}
		return result;
	}

	public bool IsFileLocked(FileInfo file)
	{
		try
		{
			using FileStream fileStream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
			fileStream.Close();
		}
		catch (IOException)
		{
			return true;
		}
		return false;
	}

	public async Task MonitorSettings(string filePath)
	{
		try
		{
			FileInfo file = new FileInfo(filePath);
			await iX3HteuZnb(file);
			kLqH6YsttN = new FileSystemWatcher(file.DirectoryName)
			{
				Filter = file.Name,
				IncludeSubdirectories = false,
				NotifyFilter = NotifyFilters.LastWrite,
				EnableRaisingEvents = true
			};
			kLqH6YsttN.Changed += async delegate(object P_0, FileSystemEventArgs P_1)
			{
				await mnDHrZgR0d(P_0, P_1);
			};
			HwuH1902sA?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(21236) + file.FullName);
		}
		catch (Exception ex)
		{
			HwuH1902sA?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(21284) + filePath + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(21366) + ex.Message);
		}
	}

	private async Task mnDHrZgR0d(object P_0, FileSystemEventArgs P_1)
	{
		kLqH6YsttN.EnableRaisingEvents = false;
		FileInfo file = new FileInfo(P_1.FullPath);
		if (await WaitForFileIsUnlocked(file))
		{
			OnSettingsModified?.Invoke(await LoadSettings(P_1.FullPath), file);
			HwuH1902sA?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(21394));
		}
		kLqH6YsttN.EnableRaisingEvents = true;
	}

	public async Task ShowSettings(string filePath)
	{
		FileInfo file = new FileInfo(filePath);
		await iX3HteuZnb(file);
		string directoryName = Path.GetDirectoryName(file.FullName);
		if (!string.IsNullOrWhiteSpace(directoryName))
		{
			Process.Start(Environment.GetEnvironmentVariable(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(21478)) + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(21494), directoryName);
		}
	}

	[CompilerGenerated]
	private async void nBLHy403pl(object P_0, FileSystemEventArgs P_1)
	{
		await mnDHrZgR0d(P_0, P_1);
	}
}
