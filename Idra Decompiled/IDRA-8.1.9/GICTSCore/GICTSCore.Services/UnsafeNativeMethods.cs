using System;
using System.Runtime.InteropServices;
using System.Security;

namespace GICTSCore.Services;

[SuppressUnmanagedCodeSecurity]
public static class UnsafeNativeMethods
{
	[Flags]
	public enum ThreadAccess
	{
		TERMINATE = 1,
		SUSPEND_RESUME = 2,
		GET_CONTEXT = 8,
		SET_CONTEXT = 0x10,
		SET_INFORMATION = 0x20,
		QUERY_INFORMATION = 0x40,
		SET_THREAD_TOKEN = 0x80,
		IMPERSONATE = 0x100,
		DIRECT_IMPERSONATION = 0x200
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern int ShowCursor([MarshalAs(UnmanagedType.Bool)] bool bShow);

	[DllImport("kernel32.dll")]
	public static extern nint OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

	[DllImport("kernel32.dll")]
	public static extern uint SuspendThread(nint hThread);

	[DllImport("kernel32.dll")]
	public static extern int ResumeThread(nint hThread);

	[DllImport("kernel32.dll")]
	public static extern int CloseHandle(nint hThread);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool AllocConsole();

	[DllImport("kernel32.dll")]
	public static extern nint GetConsoleWindow();

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(nint hWnd, int nCmdShow);
}
