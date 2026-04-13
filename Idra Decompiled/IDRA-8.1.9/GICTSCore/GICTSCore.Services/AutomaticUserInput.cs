using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;

namespace GICTSCore.Services;

public class AutomaticUserInput
{
	[DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
	private static extern nint DuEvoT85KN(nint P_0);

	[DllImport("user32.dll", EntryPoint = "SendMessage")]
	private static extern nint ymvvXOn02j(nint P_0, uint P_1, nint P_2, nint P_3);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "mouse_event")]
	private static extern void gsYveYXmRm(uint P_0, uint P_1, uint P_2, uint P_3, uint P_4);

	[DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
	private static extern int lYYv0ByOOs(int P_0);

	[DllImport("user32.dll", EntryPoint = "SetCursorPos")]
	private static extern bool xXDvRmXyFh(int P_0, int P_1);

	[DllImport("user32.dll")]
	public static extern uint MapVirtualKey(uint uCode, uint uMapType);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetForegroundWindow", ExactSpelling = true)]
	private static extern nint HHcvzrFOOa();

	[DllImport("user32.dll", EntryPoint = "FindWindowEx", SetLastError = true)]
	private static extern nint HeBHwEXAtA(nint P_0, nint P_1, string P_2, string P_3);

	public static void SendKey(string processName, uint key, bool maintain_ctrl = false)
	{
		checked
		{
			using Process process = Process.GetProcessesByName(processName).FirstOrDefault();
			if (process != null)
			{
				nint mainWindowHandle = process.MainWindowHandle;
				DuEvoT85KN(mainWindowHandle);
				if (maintain_ctrl)
				{
					ymvvXOn02j(mainWindowHandle, 256u, 162, IntPtr.Zero);
				}
				ymvvXOn02j(mainWindowHandle, 256u, (nint)key, IntPtr.Zero);
				Thread.Sleep(10);
				ymvvXOn02j(mainWindowHandle, 257u, (nint)key, IntPtr.Zero);
				if (maintain_ctrl)
				{
					ymvvXOn02j(mainWindowHandle, 257u, 162, IntPtr.Zero);
				}
			}
		}
	}

	public static void ClickButton(string processName, string buttonText)
	{
		using Process process = Process.GetProcessesByName(processName).FirstOrDefault();
		if (process != null)
		{
			nint mainWindowHandle = process.MainWindowHandle;
			DuEvoT85KN(mainWindowHandle);
			ymvvXOn02j(HeBHwEXAtA(mainWindowHandle, IntPtr.Zero, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12196), buttonText), 245u, IntPtr.Zero, IntPtr.Zero);
		}
	}

	public AutomaticUserInput()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
	}
}
