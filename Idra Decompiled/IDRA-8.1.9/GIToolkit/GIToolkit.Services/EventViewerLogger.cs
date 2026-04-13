using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using U4yoVEpfEeOhjCsFXj;

namespace GIToolkit.Services;

public static class EventViewerLogger
{
	public const ushort EVENTLOG_INFORMATION_TYPE = 4;

	public const ushort EVENTLOG_WARNING_TYPE = 2;

	public const ushort EVENTLOG_ERROR_TYPE = 1;

	[CompilerGenerated]
	private static string iY5YtlYZuc;

	public static string Source
	{
		[CompilerGenerated]
		get
		{
			return iY5YtlYZuc;
		}
		[CompilerGenerated]
		set
		{
			iY5YtlYZuc = value;
		}
	}

	public static string LogName => so95DAFNMfktfjp4Dm.An6v7kuCGg(1700);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, EntryPoint = "RegisterEventSource")]
	private static extern nint mvfYW4DqmW(string P_0, string P_1);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, EntryPoint = "DeregisterEventSource")]
	private static extern bool koRYYXgrja(nint P_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, EntryPoint = "ReportEventW")]
	private static extern bool Kd9Yx0ZPhj(nint P_0, ushort P_1, ushort P_2, int P_3, nint P_4, ushort P_5, uint P_6, string[] P_7, byte[] P_8);

	public static void LogDebug(string message, bool debugLoggingEnabled, int logEventId = 1)
	{
		if (debugLoggingEnabled)
		{
			ClBY6ESaK4(message, 4, logEventId);
		}
	}

	public static void LogInformation(string message, int logEventId = 1)
	{
		ClBY6ESaK4(message, 4, logEventId);
	}

	public static void LogWarning(string message, int logEventId = 1)
	{
		ClBY6ESaK4(message, 2, logEventId);
	}

	public static void LogException(Exception ex, int logEventId = 1)
	{
		if (ex == null)
		{
			throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(1732));
		}
		if (Environment.UserInteractive)
		{
			Console.WriteLine(ex.ToString());
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
		defaultInterpolatedStringHandler.AppendFormatted(ex);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(1756));
		defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(1778));
		defaultInterpolatedStringHandler.AppendFormatted(ex.InnerException?.Message);
		ClBY6ESaK4(defaultInterpolatedStringHandler.ToStringAndClear(), 1, logEventId);
	}

	private static void ClBY6ESaK4(string P_0, ushort P_1, int P_2)
	{
		JWvYEf3ISM(oHIYoOtRe8(P_0), P_1, P_2);
		if (Environment.UserInteractive)
		{
			Console.WriteLine(P_0);
		}
	}

	public static EventLogEntry GetFirstEntry()
	{
		return new EventLog(so95DAFNMfktfjp4Dm.An6v7kuCGg(1830), Environment.MachineName).Entries.Cast<EventLogEntry>().Reverse().FirstOrDefault();
	}

	private static void JWvYEf3ISM(string P_0, ushort P_1, int P_2, byte[] P_3 = null)
	{
		nint num = mvfYW4DqmW(null, i9iY23niR3());
		uint num2 = ((P_3 != null) ? ((uint)P_3.Length) : 0u);
		Kd9Yx0ZPhj(num, P_1, 0, P_2, IntPtr.Zero, 1, num2, new string[1] { P_0 }, P_3);
		koRYYXgrja(num);
	}

	private static void df8YBojihU(string P_0)
	{
		if (!LdPY3UXts8())
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(1856));
		}
		if (!EventLog.Exists(LogName) || !EventLog.SourceExists(P_0))
		{
			if (EventLog.Exists(LogName))
			{
				EventLog.Delete(LogName);
			}
			if (EventLog.SourceExists(P_0))
			{
				EventLog.DeleteEventSource(P_0);
			}
			EventLog.CreateEventSource(new EventSourceCreationData(P_0, LogName));
		}
	}

	private static bool LdPY3UXts8()
	{
		using WindowsIdentity ntIdentity = WindowsIdentity.GetCurrent();
		return new WindowsPrincipal(ntIdentity).IsInRole(WindowsBuiltInRole.Administrator);
	}

	private static string i9iY23niR3()
	{
		if (!string.IsNullOrWhiteSpace(Source))
		{
			return Source;
		}
		try
		{
			Assembly assembly = Assembly.GetEntryAssembly();
			if (assembly == null)
			{
				assembly = Assembly.GetExecutingAssembly();
			}
			if (assembly == null)
			{
				assembly = new StackTrace().GetFrames().Last().GetMethod()
					.Module.Assembly;
			}
			if (assembly == null)
			{
				return so95DAFNMfktfjp4Dm.An6v7kuCGg(2038);
			}
			return assembly.GetName().Name + so95DAFNMfktfjp4Dm.An6v7kuCGg(2056);
		}
		catch
		{
			return so95DAFNMfktfjp4Dm.An6v7kuCGg(2038);
		}
	}

	private static string oHIYoOtRe8(string P_0)
	{
		if (P_0.Length > 30000)
		{
			string text = string.Format(CultureInfo.CurrentCulture, so95DAFNMfktfjp4Dm.An6v7kuCGg(2072), 30000);
			P_0 = P_0.Substring(0, 30000 - text.Length);
			P_0 = string.Format(CultureInfo.CurrentCulture, so95DAFNMfktfjp4Dm.An6v7kuCGg(2160), P_0, text);
		}
		return P_0;
	}
}
