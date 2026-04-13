using System.Runtime.InteropServices;
using System.Security;

namespace GICTSCore.Services;

[SuppressUnmanagedCodeSecurity]
public static class SafeNativeMethods
{
	[DllImport("advapi32.dll", CharSet = CharSet.Unicode)]
	public static extern nint RegisterEventSource(string lpUNCServerName, string lpSourceName);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode)]
	public static extern bool DeregisterEventSource(nint hEventLog);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, EntryPoint = "ReportEventW")]
	public static extern bool ReportEvent(nint hEventLog, ushort wType, ushort wCategory, int dwEventID, nint lpUserSid, ushort wNumStrings, uint dwDataSize, string[] lpStrings, byte[] lpRawData);
}
