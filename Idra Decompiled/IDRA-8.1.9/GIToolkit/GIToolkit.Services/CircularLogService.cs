#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class CircularLogService : IService, ICircularLogService
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public List<FileInfo> oVtYPABVvU;

		public CircularLogService bUHYzvap5M;

		public _003C_003Ec__DisplayClass36_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal void U3OYIcqysT(string x)
		{
			oVtYPABVvU.Add(new FileInfo(x));
		}

		internal bool yygYqcWqsZ(FileInfo x)
		{
			return (DateTime.Now - x.CreationTime).TotalDays > (double)bUHYzvap5M.ogZYQS1tV4;
		}
	}

	[CompilerGenerated]
	private FileInfo Oo8YObB4Mj;

	[CompilerGenerated]
	private int W5jY9yHM9d;

	[CompilerGenerated]
	private int hJ6Yhkxx2c;

	private int ogZYQS1tV4;

	private long ysLYTY3TgP;

	private string NqJYLGNkYT;

	private LogLevel iHAY0dNrRL;

	private bool HkvYZhCUAu;

	private object Wt1YM4BfE1;

	protected readonly SemaphoreSlim _traceLoggingSemaphore;

	protected readonly SemaphoreSlim _fileLoggingSemaphore;

	private DateTime FVuYSbNVOI;

	public FileInfo CurrentLogFile
	{
		[CompilerGenerated]
		get
		{
			return Oo8YObB4Mj;
		}
		[CompilerGenerated]
		private set
		{
			Oo8YObB4Mj = value;
		}
	}

	public int MinimumDayBeforeSuppression
	{
		[CompilerGenerated]
		get
		{
			return W5jY9yHM9d;
		}
		[CompilerGenerated]
		private set
		{
			W5jY9yHM9d = value;
		}
	}

	public int MaximumFileSizeDefault
	{
		[CompilerGenerated]
		get
		{
			return hJ6Yhkxx2c;
		}
		[CompilerGenerated]
		private set
		{
			hJ6Yhkxx2c = value;
		}
	}

	public CircularLogService()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		ogZYQS1tV4 = 30;
		ysLYTY3TgP = -1L;
		NqJYLGNkYT = "";
		HkvYZhCUAu = true;
		Wt1YM4BfE1 = new object();
		_traceLoggingSemaphore = new SemaphoreSlim(1, 1);
		_fileLoggingSemaphore = new SemaphoreSlim(1, 1);
		FVuYSbNVOI = DateTime.MinValue;
		base._002Ector();
		ysLYTY3TgP = MaximumFileSizeDefault;
		ogZYQS1tV4 = MinimumDayBeforeSuppression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string MMrYf0XQdm(int P_0 = 2)
	{
		return new StackTrace()?.GetFrame(P_0)?.GetMethod()?.DeclaringType?.Name ?? "";
	}

	private static string fZaYy4048s(string P_0, int P_1 = 70)
	{
		return P_0.PadRight(P_1, ' ');
	}

	public static void UnsafeLog(string text)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2638));
		defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now.ToString(so95DAFNMfktfjp4Dm.An6v7kuCGg(2644)));
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2694));
		defaultInterpolatedStringHandler.AppendFormatted(MMrYf0XQdm());
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2716));
		Trace.TraceWarning(fZaYy4048s(defaultInterpolatedStringHandler.ToStringAndClear(), 70 + (so95DAFNMfktfjp4Dm.An6v7kuCGg(2724).Length - so95DAFNMfktfjp4Dm.An6v7kuCGg(2750).Length)) + so95DAFNMfktfjp4Dm.An6v7kuCGg(2768) + text);
	}

	public static void LogOpenTag()
	{
		Trace.Write(new string('#', 75));
		Trace.Write(so95DAFNMfktfjp4Dm.An6v7kuCGg(2806));
		Trace.Write(new string('#', 75));
		Trace.WriteLine("");
		Trace.Flush();
	}

	public void LogFileOpenTag()
	{
		if (HkvYZhCUAu)
		{
			LogOpenTag();
		}
		else
		{
			bPTYwngLAm(new string('#', 75) + so95DAFNMfktfjp4Dm.An6v7kuCGg(2806) + new string('#', 75), LogLevel.Content);
		}
	}

	public static void LogCloseTag()
	{
		Trace.Write(new string('#', 75));
		Trace.Write(so95DAFNMfktfjp4Dm.An6v7kuCGg(2844));
		Trace.Write(new string('#', 75));
		Trace.WriteLine("");
		Trace.Flush();
		Trace.Close();
	}

	public void LogFileCloseTag()
	{
		if (HkvYZhCUAu)
		{
			LogCloseTag();
		}
		else
		{
			bPTYwngLAm(new string('#', 75) + so95DAFNMfktfjp4Dm.An6v7kuCGg(2844) + new string('#', 75), LogLevel.Content);
		}
	}

	private bool sITYHxZSZ0()
	{
		lock (Wt1YM4BfE1)
		{
			if (CurrentLogFile == null)
			{
				return false;
			}
			CurrentLogFile.Refresh();
			return CurrentLogFile.Exists && CurrentLogFile.Length > ysLYTY3TgP;
		}
	}

	public void SetLogLevel(LogLevel logLevel)
	{
		iHAY0dNrRL = logLevel;
	}

	public void Log<T>(string text, T logObject, LogLevel level = LogLevel.Info)
	{
		if (logObject == null)
		{
			Log(text, level);
			return;
		}
		string empty = string.Empty;
		try
		{
			empty = JsonSerializer.Serialize(logObject);
		}
		catch (Exception ex)
		{
			empty = so95DAFNMfktfjp4Dm.An6v7kuCGg(2882) + ex.Message;
		}
		Log(text + so95DAFNMfktfjp4Dm.An6v7kuCGg(1128) + empty, level);
	}

	public void Log(string text, LogLevel level = LogLevel.Info)
	{
		if (iHAY0dNrRL > level || CurrentLogFile == null)
		{
			return;
		}
		try
		{
			_traceLoggingSemaphore.Wait();
			int num = 70;
			if (sITYHxZSZ0())
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 1);
				defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2978));
				defaultInterpolatedStringHandler.AppendFormatted(ysLYTY3TgP);
				defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(3024));
				string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
				if (HkvYZhCUAu)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(12, 2);
					defaultInterpolatedStringHandler2.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2638));
					defaultInterpolatedStringHandler2.AppendFormatted(DateTime.Now.ToString(so95DAFNMfktfjp4Dm.An6v7kuCGg(2644)));
					defaultInterpolatedStringHandler2.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2694));
					defaultInterpolatedStringHandler2.AppendFormatted(MMrYf0XQdm());
					defaultInterpolatedStringHandler2.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2716));
					Trace.TraceInformation(fZaYy4048s(defaultInterpolatedStringHandler2.ToStringAndClear(), num) + so95DAFNMfktfjp4Dm.An6v7kuCGg(1128) + text2);
				}
				else
				{
					bPTYwngLAm(text2, level);
				}
				SetupLogFile(Path.GetDirectoryName(CurrentLogFile.FullName), NqJYLGNkYT, HkvYZhCUAu, ogZYQS1tV4, ysLYTY3TgP);
			}
			if (HkvYZhCUAu)
			{
				switch (level)
				{
				case LogLevel.Debug:
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler7 = new DefaultInterpolatedStringHandler(12, 2);
					defaultInterpolatedStringHandler7.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2638));
					defaultInterpolatedStringHandler7.AppendFormatted(DateTime.Now.ToString(so95DAFNMfktfjp4Dm.An6v7kuCGg(2644)));
					defaultInterpolatedStringHandler7.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2694));
					defaultInterpolatedStringHandler7.AppendFormatted(MMrYf0XQdm());
					defaultInterpolatedStringHandler7.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2716));
					Trace.WriteLine(fZaYy4048s(defaultInterpolatedStringHandler7.ToStringAndClear(), num + 27) + so95DAFNMfktfjp4Dm.An6v7kuCGg(1128) + text);
					break;
				}
				case LogLevel.Info:
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler6 = new DefaultInterpolatedStringHandler(12, 2);
					defaultInterpolatedStringHandler6.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2638));
					defaultInterpolatedStringHandler6.AppendFormatted(DateTime.Now.ToString(so95DAFNMfktfjp4Dm.An6v7kuCGg(2644)));
					defaultInterpolatedStringHandler6.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2694));
					defaultInterpolatedStringHandler6.AppendFormatted(MMrYf0XQdm());
					defaultInterpolatedStringHandler6.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2716));
					Trace.TraceInformation(fZaYy4048s(defaultInterpolatedStringHandler6.ToStringAndClear(), num) + so95DAFNMfktfjp4Dm.An6v7kuCGg(1128) + text);
					break;
				}
				case LogLevel.Warning:
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler5 = new DefaultInterpolatedStringHandler(12, 2);
					defaultInterpolatedStringHandler5.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2638));
					defaultInterpolatedStringHandler5.AppendFormatted(DateTime.Now.ToString(so95DAFNMfktfjp4Dm.An6v7kuCGg(2644)));
					defaultInterpolatedStringHandler5.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2694));
					defaultInterpolatedStringHandler5.AppendFormatted(MMrYf0XQdm());
					defaultInterpolatedStringHandler5.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2716));
					Trace.TraceWarning(fZaYy4048s(defaultInterpolatedStringHandler5.ToStringAndClear(), num + (so95DAFNMfktfjp4Dm.An6v7kuCGg(2724).Length - so95DAFNMfktfjp4Dm.An6v7kuCGg(2750).Length)) + so95DAFNMfktfjp4Dm.An6v7kuCGg(1128) + text);
					break;
				}
				case LogLevel.Error:
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(12, 2);
					defaultInterpolatedStringHandler4.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2638));
					defaultInterpolatedStringHandler4.AppendFormatted(DateTime.Now.ToString(so95DAFNMfktfjp4Dm.An6v7kuCGg(2644)));
					defaultInterpolatedStringHandler4.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2694));
					defaultInterpolatedStringHandler4.AppendFormatted(MMrYf0XQdm());
					defaultInterpolatedStringHandler4.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2716));
					Trace.TraceError(fZaYy4048s(defaultInterpolatedStringHandler4.ToStringAndClear(), num + (so95DAFNMfktfjp4Dm.An6v7kuCGg(2724).Length - so95DAFNMfktfjp4Dm.An6v7kuCGg(3080).Length)) + so95DAFNMfktfjp4Dm.An6v7kuCGg(1128) + text);
					break;
				}
				default:
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(12, 2);
					defaultInterpolatedStringHandler3.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2638));
					defaultInterpolatedStringHandler3.AppendFormatted(DateTime.Now.ToString(so95DAFNMfktfjp4Dm.An6v7kuCGg(2644)));
					defaultInterpolatedStringHandler3.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2694));
					defaultInterpolatedStringHandler3.AppendFormatted(MMrYf0XQdm());
					defaultInterpolatedStringHandler3.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2716));
					Trace.WriteLine(fZaYy4048s(defaultInterpolatedStringHandler3.ToStringAndClear(), num + 27) + so95DAFNMfktfjp4Dm.An6v7kuCGg(1128) + text);
					break;
				}
				}
			}
			else
			{
				bPTYwngLAm(text, level);
			}
		}
		catch (Exception ex)
		{
			if ((DateTime.Now - FVuYSbNVOI).TotalMinutes > 15.0)
			{
				EventViewerLogger.LogException(ex);
				FVuYSbNVOI = DateTime.Now;
			}
		}
		finally
		{
			_traceLoggingSemaphore.Release();
		}
	}

	private void bPTYwngLAm(string P_0, LogLevel P_1 = LogLevel.Info)
	{
		try
		{
			_fileLoggingSemaphore.Wait();
			int num = 70;
			using StreamWriter streamWriter = new StreamWriter(CurrentLogFile.FullName, append: true);
			streamWriter.AutoFlush = true;
			switch (P_1)
			{
			case LogLevel.Debug:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(12, 2);
				defaultInterpolatedStringHandler4.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2638));
				defaultInterpolatedStringHandler4.AppendFormatted(DateTime.Now.ToString(so95DAFNMfktfjp4Dm.An6v7kuCGg(2644)));
				defaultInterpolatedStringHandler4.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2694));
				defaultInterpolatedStringHandler4.AppendFormatted(MMrYf0XQdm(3));
				defaultInterpolatedStringHandler4.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2716));
				streamWriter.WriteLine(fZaYy4048s(defaultInterpolatedStringHandler4.ToStringAndClear(), num) + so95DAFNMfktfjp4Dm.An6v7kuCGg(3094) + P_0);
				break;
			}
			case LogLevel.Info:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(12, 2);
				defaultInterpolatedStringHandler3.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2638));
				defaultInterpolatedStringHandler3.AppendFormatted(DateTime.Now.ToString(so95DAFNMfktfjp4Dm.An6v7kuCGg(2644)));
				defaultInterpolatedStringHandler3.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2694));
				defaultInterpolatedStringHandler3.AppendFormatted(MMrYf0XQdm(3));
				defaultInterpolatedStringHandler3.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2716));
				streamWriter.WriteLine(fZaYy4048s(defaultInterpolatedStringHandler3.ToStringAndClear(), num) + so95DAFNMfktfjp4Dm.An6v7kuCGg(3120) + P_0);
				break;
			}
			case LogLevel.Warning:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(12, 2);
				defaultInterpolatedStringHandler2.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2638));
				defaultInterpolatedStringHandler2.AppendFormatted(DateTime.Now.ToString(so95DAFNMfktfjp4Dm.An6v7kuCGg(2644)));
				defaultInterpolatedStringHandler2.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2694));
				defaultInterpolatedStringHandler2.AppendFormatted(MMrYf0XQdm(3));
				defaultInterpolatedStringHandler2.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2716));
				streamWriter.WriteLine(fZaYy4048s(defaultInterpolatedStringHandler2.ToStringAndClear(), num) + so95DAFNMfktfjp4Dm.An6v7kuCGg(3146) + P_0);
				break;
			}
			case LogLevel.Error:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
				defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2638));
				defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now.ToString(so95DAFNMfktfjp4Dm.An6v7kuCGg(2644)));
				defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2694));
				defaultInterpolatedStringHandler.AppendFormatted(MMrYf0XQdm(3));
				defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2716));
				streamWriter.WriteLine(fZaYy4048s(defaultInterpolatedStringHandler.ToStringAndClear(), num) + so95DAFNMfktfjp4Dm.An6v7kuCGg(3172) + P_0);
				break;
			}
			default:
				streamWriter.WriteLine(P_0);
				break;
			}
		}
		catch (Exception ex)
		{
			if ((DateTime.Now - FVuYSbNVOI).TotalMinutes > 15.0)
			{
				EventViewerLogger.LogException(ex);
				FVuYSbNVOI = DateTime.Now;
			}
		}
		finally
		{
			_fileLoggingSemaphore.Release();
		}
	}

	public string GetCurrentLogFileDirectory()
	{
		if (CurrentLogFile == null)
		{
			return string.Empty;
		}
		CurrentLogFile.Refresh();
		return CurrentLogFile.DirectoryName;
	}

	public FileInfo SetupLogFile(string directoryPath, string logFileName, bool useTraceLoggingMethod, int minimumDayBeforeSuppression, long maximumFileSize)
	{
		_003C_003Ec__DisplayClass36_0 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass36_0();
		CS_0024_003C_003E8__locals7.bUHYzvap5M = this;
		if (useTraceLoggingMethod)
		{
			Trace.Close();
		}
		ogZYQS1tV4 = minimumDayBeforeSuppression;
		ysLYTY3TgP = maximumFileSize;
		NqJYLGNkYT = logFileName;
		HkvYZhCUAu = useTraceLoggingMethod;
		Directory.CreateDirectory(directoryPath);
		string[] files = Directory.GetFiles(directoryPath, so95DAFNMfktfjp4Dm.An6v7kuCGg(3198));
		CS_0024_003C_003E8__locals7.oVtYPABVvU = new List<FileInfo>();
		files.ToList().ForEach(delegate(string x)
		{
			CS_0024_003C_003E8__locals7.oVtYPABVvU.Add(new FileInfo(x));
		});
		foreach (FileInfo item in CS_0024_003C_003E8__locals7.oVtYPABVvU.Where((FileInfo x) => (DateTime.Now - x.CreationTime).TotalDays > (double)CS_0024_003C_003E8__locals7.bUHYzvap5M.ogZYQS1tV4).ToList())
		{
			File.Delete(item.FullName);
			CS_0024_003C_003E8__locals7.oVtYPABVvU.Remove(item);
		}
		FileInfo fileInfo = CS_0024_003C_003E8__locals7.oVtYPABVvU.OrderByDescending((FileInfo x) => x.LastWriteTime).FirstOrDefault();
		if (fileInfo == null || files.Length == 0 || fileInfo.Length >= ysLYTY3TgP)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 3);
			defaultInterpolatedStringHandler.AppendFormatted(directoryPath);
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(3212));
			defaultInterpolatedStringHandler.AppendFormatted(logFileName);
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(2176));
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now.ToString(so95DAFNMfktfjp4Dm.An6v7kuCGg(3218)));
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(3260));
			CurrentLogFile = new FileInfo(defaultInterpolatedStringHandler.ToStringAndClear());
			CurrentLogFile.Create().Dispose();
		}
		else
		{
			CurrentLogFile = fileInfo;
		}
		if (useTraceLoggingMethod)
		{
			Trace.Listeners.Clear();
			TextWriterTraceListener listener = new TextWriterTraceListener(CurrentLogFile.FullName);
			Trace.Listeners.Add(listener);
			Trace.AutoFlush = true;
		}
		LogFileOpenTag();
		return CurrentLogFile;
	}
}
