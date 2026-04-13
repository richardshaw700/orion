using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class FileProcessCommunication
{
	private static readonly Dictionary<string, FileProcessCommunication> thHxFJRrAW;

	private static readonly SemaphoreSlim ajQxprbPLy;

	private FileSystemWatcher? aLWxW6Wtch;

	private FileCommunicationSettings oC2xYMf9DZ;

	private ICircularLogService CRLxx7EwL1;

	[CompilerGenerated]
	private Func<string, Task> VDdx6tfFfs;

	private static readonly SemaphoreSlim P2fxEyQeGw;

	private bool xhfxB5bXIF;

	public Func<string, Task> OnReceiveMessage
	{
		[CompilerGenerated]
		get
		{
			return VDdx6tfFfs;
		}
		[CompilerGenerated]
		set
		{
			VDdx6tfFfs = value;
		}
	}

	private FileProcessCommunication(FileCommunicationSettings settings, ICircularLogService logService)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		oC2xYMf9DZ = settings;
		CRLxx7EwL1 = logService;
	}

	public static async Task<FileProcessCommunication> GetInstanceAsync(FileCommunicationSettings settings, ICircularLogService logService)
	{
		string key = settings.FileFullPath;
		await ajQxprbPLy.WaitAsync();
		try
		{
			if (!thHxFJRrAW.ContainsKey(key))
			{
				thHxFJRrAW[key] = new FileProcessCommunication(settings, logService);
				await thHxFJRrAW[key].V1NxRifp3e();
			}
			return thHxFJRrAW[key];
		}
		finally
		{
			ajQxprbPLy.Release();
		}
	}

	private async Task V1NxRifp3e()
	{
		if (xhfxB5bXIF)
		{
			CRLxx7EwL1.Log(so95DAFNMfktfjp4Dm.An6v7kuCGg(22584) + oC2xYMf9DZ.FileName, LogLevel.Error);
			return;
		}
		try
		{
			if (!File.Exists(oC2xYMf9DZ.FileFullPath))
			{
				await using (File.Create(oC2xYMf9DZ.FileFullPath))
				{
				}
			}
			if (!(await z7Zxa9YRyw(oC2xYMf9DZ.FileFullPath)))
			{
				CRLxx7EwL1.Log(so95DAFNMfktfjp4Dm.An6v7kuCGg(22662) + oC2xYMf9DZ.FileFullPath + so95DAFNMfktfjp4Dm.An6v7kuCGg(22750), LogLevel.Error);
				return;
			}
			File.WriteAllText(oC2xYMf9DZ.FileFullPath, string.Empty);
			aLWxW6Wtch = new FileSystemWatcher(oC2xYMf9DZ.FileDirectoryPath)
			{
				Filter = oC2xYMf9DZ.FileName,
				IncludeSubdirectories = false,
				NotifyFilter = NotifyFilters.LastWrite,
				EnableRaisingEvents = true
			};
			aLWxW6Wtch.Changed += async delegate
			{
				await w9NxAlF5Lw();
			};
			xhfxB5bXIF = true;
		}
		catch (Exception ex)
		{
			CRLxx7EwL1.Log(so95DAFNMfktfjp4Dm.An6v7kuCGg(22758) + ex.Message, LogLevel.Error);
		}
	}

	private async Task w9NxAlF5Lw()
	{
		string lastLine = string.Empty;
		xwAxkGIvjf();
		try
		{
			try
			{
				if (!(await z7Zxa9YRyw(oC2xYMf9DZ.FileFullPath)))
				{
					CRLxx7EwL1.Log(so95DAFNMfktfjp4Dm.An6v7kuCGg(22346), LogLevel.Warning);
					return;
				}
				List<string> list = new List<string>();
				using (FileStream stream = new FileStream(oC2xYMf9DZ.FileFullPath, FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					using StreamReader streamReader = new StreamReader(stream);
					string item;
					while ((item = streamReader.ReadLine()) != null)
					{
						list.Add(item);
					}
				}
				if (list.Count() > 0)
				{
					lastLine = list.Last();
				}
			}
			catch (Exception ex)
			{
				CRLxx7EwL1.Log(so95DAFNMfktfjp4Dm.An6v7kuCGg(22462) + ex.Message, LogLevel.Error);
				EventViewerLogger.LogException(ex);
			}
			OnReceiveMessage?.Invoke(lastLine);
		}
		finally
		{
			xwAxkGIvjf();
		}
	}

	public async Task WriteMessage(int code)
	{
		_ = 2;
		try
		{
			await P2fxEyQeGw.WaitAsync();
			if (!File.Exists(oC2xYMf9DZ.FileFullPath))
			{
				File.Create(oC2xYMf9DZ.FileFullPath).Dispose();
			}
			bool success = false;
			int retryCount = 0;
			int maxRetries = 3;
			int delay = 1000;
			while (!success && retryCount < maxRetries)
			{
				try
				{
					using StreamWriter file = new StreamWriter(oC2xYMf9DZ.FileFullPath, append: false);
					await file.WriteLineAsync($"{code}");
					success = true;
				}
				catch (IOException ex)
				{
					retryCount++;
					ICircularLogService cRLxx7EwL = CRLxx7EwL1;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 2);
					defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(22872));
					defaultInterpolatedStringHandler.AppendFormatted(code);
					defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(22946));
					defaultInterpolatedStringHandler.AppendFormatted(retryCount);
					defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(21274));
					cRLxx7EwL.Log(defaultInterpolatedStringHandler.ToStringAndClear(), LogLevel.Warning);
					if (retryCount >= maxRetries)
					{
						EventViewerLogger.LogException(ex);
						throw;
					}
					await Task.Delay(delay);
				}
			}
		}
		catch (Exception ex2)
		{
			EventViewerLogger.LogException(ex2);
			throw;
		}
		finally
		{
			P2fxEyQeGw.Release();
		}
	}

	private void xwAxkGIvjf()
	{
		if (aLWxW6Wtch == null)
		{
			throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(3344));
		}
		aLWxW6Wtch.EnableRaisingEvents = !aLWxW6Wtch.EnableRaisingEvents;
	}

	private static async Task<bool> z7Zxa9YRyw(string P_0, int P_1 = 300, int P_2 = 100)
	{
		int cptAttemps = 0;
		while (true)
		{
			int num = cptAttemps + 1;
			cptAttemps = num;
			if (num >= P_1)
			{
				break;
			}
			try
			{
				using (File.Open(P_0, FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					return true;
				}
			}
			catch (Exception)
			{
				await Task.Delay(TimeSpan.FromMilliseconds(P_2));
			}
		}
		return false;
	}

	static FileProcessCommunication()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		thHxFJRrAW = new Dictionary<string, FileProcessCommunication>();
		ajQxprbPLy = new SemaphoreSlim(1, 1);
		P2fxEyQeGw = new SemaphoreSlim(1, 1);
	}

	[CompilerGenerated]
	private async void tnhxXues4Q(object P_0, FileSystemEventArgs P_1)
	{
		await w9NxAlF5Lw();
	}
}
