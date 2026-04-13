using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class ProcessHelper : IProcessHelper
{
	[DllImport("user32.dll", EntryPoint = "ShowWindow")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool sNFxLyR6oP(nint P_0, ShowWindowEnum P_1);

	[DllImport("user32.dll")]
	public static extern bool IsIconic(nint handle);

	[DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
	private static extern int oRIx07HYhq(nint P_0);

	public Process CreateProcess(string fileName, string arguments = "", bool enableRaisingEvent = true)
	{
		FileInfo fileInfo = new FileInfo(fileName);
		if (!fileInfo.Exists)
		{
			throw new FileNotFoundException(so95DAFNMfktfjp4Dm.An6v7kuCGg(5034), fileName);
		}
		return new Process
		{
			StartInfo = new ProcessStartInfo(fileInfo.FullName)
			{
				WorkingDirectory = fileInfo.DirectoryName,
				Arguments = arguments
			},
			EnableRaisingEvents = enableRaisingEvent
		};
	}

	[Obsolete]
	public Process CreateProcess(string fileName, string workingDirectory, string arguments = "", bool enableRaisingEvent = true)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName)
		{
			WorkingDirectory = workingDirectory
		};
		processStartInfo.Arguments = arguments;
		return new Process
		{
			StartInfo = processStartInfo,
			EnableRaisingEvents = enableRaisingEvent
		};
	}

	public Process GetProcessByName(string name, bool enableRaisingEvent = true)
	{
		Process[] processesByName = Process.GetProcessesByName(name);
		if (processesByName.Any())
		{
			Process process = processesByName.FirstOrDefault();
			if (process != null && !process.HasExited)
			{
				process.EnableRaisingEvents = enableRaisingEvent;
			}
			return process;
		}
		return null;
	}

	public bool IsProcessRunning(string processName)
	{
		return GetProcessByName(processName) != null;
	}

	[Obsolete]
	public void BringWindowToFront(string processName)
	{
		Process process = Process.GetProcessesByName(processName)?.FirstOrDefault();
		if (process != null)
		{
			if (process.MainWindowHandle == IntPtr.Zero)
			{
				sNFxLyR6oP(process.Handle, ShowWindowEnum.Restore);
			}
			else if (IsIconic(process.MainWindowHandle))
			{
				sNFxLyR6oP(process.MainWindowHandle, ShowWindowEnum.Restore);
			}
			oRIx07HYhq(process.MainWindowHandle);
		}
	}

	public void ModifyWindowState(string processName, ShowWindowEnum state, bool setFocus = false)
	{
		Process process = Process.GetProcessesByName(processName).FirstOrDefault();
		if (process != null && process.MainWindowHandle != IntPtr.Zero)
		{
			sNFxLyR6oP(process.MainWindowHandle, state);
			if (setFocus)
			{
				oRIx07HYhq(process.MainWindowHandle);
			}
		}
	}

	public bool ProcessIsSetAndHasNotExited(Process processToCheck)
	{
		if (processToCheck == null)
		{
			return false;
		}
		bool flag = false;
		try
		{
			return !processToCheck.HasExited;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public void StartProcess(Process processToStart, int maxRetries = 3)
	{
		for (int i = 1; i <= maxRetries; i++)
		{
			try
			{
				processToStart.Start();
				return;
			}
			catch (Exception ex)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
				defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(5066));
				defaultInterpolatedStringHandler.AppendFormatted(i);
				defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(5086));
				defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
				defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(5108));
				EventViewerLogger.LogWarning(defaultInterpolatedStringHandler.ToStringAndClear());
				Thread.Sleep(2000);
			}
		}
		throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(5138));
	}

	public void AttachListenerOnExited(Process process, EventHandler actionToPerformOnExit)
	{
		TqnxZ6rnAA(process);
		process.Exited -= actionToPerformOnExit;
		process.Exited += actionToPerformOnExit;
	}

	public void DetachListenerOnExited(Process process, EventHandler actionToPerformOnExit)
	{
		TqnxZ6rnAA(process);
		process.Exited -= actionToPerformOnExit;
	}

	private void TqnxZ6rnAA(Process P_0)
	{
		if (!ProcessIsSetAndHasNotExited(P_0))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(5218));
		}
		if (!P_0.EnableRaisingEvents)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(5314));
		}
	}

	[Obsolete("Use InstallProductPackages instead")]
	public void StartDownloadProcessSilentlyAsAdmin(string fileName)
	{
		Process process = new Process();
		bool flag = fileName.Contains(so95DAFNMfktfjp4Dm.An6v7kuCGg(5456));
		ProcessStartInfo startInfo = new ProcessStartInfo
		{
			WindowStyle = ProcessWindowStyle.Hidden,
			FileName = (flag ? so95DAFNMfktfjp4Dm.An6v7kuCGg(5468) : fileName),
			Arguments = (flag ? (so95DAFNMfktfjp4Dm.An6v7kuCGg(5526) + fileName + so95DAFNMfktfjp4Dm.An6v7kuCGg(5538)) : so95DAFNMfktfjp4Dm.An6v7kuCGg(5486)),
			Verb = so95DAFNMfktfjp4Dm.An6v7kuCGg(5558),
			UseShellExecute = true
		};
		process.StartInfo = startInfo;
		process.Start();
	}

	public async Task<bool> InstallProductPackages(string filePath, double timeOutMin = 15.0)
	{
		FileInfo fileInfo = new FileInfo(filePath);
		if (fileInfo == null || !fileInfo.Exists)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(24894) + filePath + so95DAFNMfktfjp4Dm.An6v7kuCGg(24908));
		}
		bool flag = fileInfo.Extension == so95DAFNMfktfjp4Dm.An6v7kuCGg(5456);
		bool flag2 = fileInfo.Extension == so95DAFNMfktfjp4Dm.An6v7kuCGg(24942);
		if (!flag && !flag2)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(24894) + filePath + so95DAFNMfktfjp4Dm.An6v7kuCGg(24954) + fileInfo.Extension);
		}
		using Process process = new Process
		{
			StartInfo = new ProcessStartInfo
			{
				FileName = (flag ? so95DAFNMfktfjp4Dm.An6v7kuCGg(5468) : (so95DAFNMfktfjp4Dm.An6v7kuCGg(23276) + fileInfo.FullName + so95DAFNMfktfjp4Dm.An6v7kuCGg(23276))),
				Arguments = (flag ? (so95DAFNMfktfjp4Dm.An6v7kuCGg(5526) + fileInfo.FullName + so95DAFNMfktfjp4Dm.An6v7kuCGg(5538)) : so95DAFNMfktfjp4Dm.An6v7kuCGg(5486)),
				WindowStyle = ProcessWindowStyle.Hidden,
				Verb = so95DAFNMfktfjp4Dm.An6v7kuCGg(5558),
				UseShellExecute = true,
				CreateNoWindow = true
			}
		};
		process.Start();
		return await WaitProcessExitedTimeOut(process, timeOutMin);
	}

	public async Task<bool> WaitProcessExitedTimeOut(Process process, double timeOutMin)
	{
		bool successfullyInstall = false;
		DateTime startTime = DateTime.Now;
		while ((DateTime.Now - startTime).TotalMinutes < timeOutMin)
		{
			if (process.HasExited)
			{
				successfullyInstall = true;
				break;
			}
			await Task.Delay(TimeSpan.FromSeconds(1.0));
		}
		try
		{
			process.Kill();
		}
		catch (Exception)
		{
		}
		return successfullyInstall;
	}

	public void AutoResetPC(bool underCondition)
	{
		if (underCondition)
		{
			Process.Start(so95DAFNMfktfjp4Dm.An6v7kuCGg(5572), so95DAFNMfktfjp4Dm.An6v7kuCGg(5592));
		}
	}

	public void DeleteUnusedCredentialManagement()
	{
		List<string> list = new List<string>();
		Process process = new Process
		{
			StartInfo = new ProcessStartInfo
			{
				FileName = so95DAFNMfktfjp4Dm.An6v7kuCGg(5610),
				Arguments = so95DAFNMfktfjp4Dm.An6v7kuCGg(5634),
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			}
		};
		process.Start();
		while (!process.StandardOutput.EndOfStream)
		{
			string text = process.StandardOutput.ReadLine();
			if (text.Contains(so95DAFNMfktfjp4Dm.An6v7kuCGg(5648)))
			{
				string item = text.Substring(text.IndexOf(so95DAFNMfktfjp4Dm.An6v7kuCGg(5648)) + so95DAFNMfktfjp4Dm.An6v7kuCGg(5648).Length);
				list.Add(item);
			}
			else if (text.Contains(so95DAFNMfktfjp4Dm.An6v7kuCGg(5666)))
			{
				string item2 = text.Substring(text.IndexOf(so95DAFNMfktfjp4Dm.An6v7kuCGg(5666)) + so95DAFNMfktfjp4Dm.An6v7kuCGg(5666).Length);
				list.Add(item2);
			}
		}
		List<string> second = new List<string>
		{
			so95DAFNMfktfjp4Dm.An6v7kuCGg(5682),
			so95DAFNMfktfjp4Dm.An6v7kuCGg(5726),
			so95DAFNMfktfjp4Dm.An6v7kuCGg(5764),
			so95DAFNMfktfjp4Dm.An6v7kuCGg(5806),
			so95DAFNMfktfjp4Dm.An6v7kuCGg(5840),
			so95DAFNMfktfjp4Dm.An6v7kuCGg(5880),
			so95DAFNMfktfjp4Dm.An6v7kuCGg(5936),
			so95DAFNMfktfjp4Dm.An6v7kuCGg(5998),
			so95DAFNMfktfjp4Dm.An6v7kuCGg(6050),
			so95DAFNMfktfjp4Dm.An6v7kuCGg(6106),
			so95DAFNMfktfjp4Dm.An6v7kuCGg(6154),
			so95DAFNMfktfjp4Dm.An6v7kuCGg(6208),
			so95DAFNMfktfjp4Dm.An6v7kuCGg(6278)
		};
		foreach (string item3 in list.Except(second))
		{
			Process process2 = new Process();
			process2.StartInfo = new ProcessStartInfo
			{
				FileName = so95DAFNMfktfjp4Dm.An6v7kuCGg(5610),
				Arguments = so95DAFNMfktfjp4Dm.An6v7kuCGg(6354) + item3,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			};
			process2.Start();
		}
	}

	public ProcessHelper()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
