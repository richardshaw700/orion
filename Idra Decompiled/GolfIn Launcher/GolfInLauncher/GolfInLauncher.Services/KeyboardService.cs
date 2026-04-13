using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Services;

public class KeyboardService
{
	private struct hJEGiBeAM7po1GmIaW
	{
		public Keys epL5f2wQXq;

		public int uMP5lwMoLi;

		public int M4Q5ip84ni;

		public int Bd75PyoBSO;

		public nint oYn5J7Vshf;
	}

	private delegate nint TsLhPDbFW3YAg2Qv2i(int nCode, nint wParam, nint lParam);

	private nint ifR3HTj17V;

	private TsLhPDbFW3YAg2Qv2i pJk3ciiTAm;

	private bool Asm3eaKJpn;

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowsHookEx", SetLastError = true)]
	private static extern nint lHR33uMT9m(int P_0, TsLhPDbFW3YAg2Qv2i P_1, nint P_2, uint P_3);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "UnhookWindowsHookEx", SetLastError = true)]
	private static extern bool s6E3sV98yD(nint P_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "CallNextHookEx", SetLastError = true)]
	private static extern nint r1M3qksE6o(nint P_0, int P_1, nint P_2, nint P_3);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "GetModuleHandle", SetLastError = true)]
	private static extern nint wC935TE4ST(string P_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetAsyncKeyState")]
	private static extern short UiC3QOmiUL(Keys P_0);

	public void SettingsHookOnKey()
	{
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		pJk3ciiTAm = FXC3x6McWF;
		ifR3HTj17V = lHR33uMT9m(13, pJk3ciiTAm, wC935TE4ST(mainModule.ModuleName), 0u);
	}

	public void OnKeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		if ((int)e.SystemKey == 120 || (int)e.SystemKey == 121)
		{
			Asm3eaKJpn = true;
		}
		else if ((int)e.SystemKey == 93 && Asm3eaKJpn)
		{
			((RoutedEventArgs)e).Handled = true;
		}
	}

	public void OnKeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		if ((int)e.SystemKey == 120 || (int)e.SystemKey == 121)
		{
			Asm3eaKJpn = false;
		}
	}

	private nint FXC3x6McWF(int P_0, nint P_1, nint P_2)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		if (P_0 >= 0)
		{
			hJEGiBeAM7po1GmIaW hJEGiBeAM7po1GmIaW = (hJEGiBeAM7po1GmIaW)Marshal.PtrToStructure(P_2, typeof(hJEGiBeAM7po1GmIaW));
			if ((int)hJEGiBeAM7po1GmIaW.epL5f2wQXq == 92 || (int)hJEGiBeAM7po1GmIaW.epL5f2wQXq == 91)
			{
				return 1;
			}
		}
		return r1M3qksE6o(ifR3HTj17V, P_0, P_1, P_2);
	}

	public void OnClosed(EventArgs e)
	{
		if (ifR3HTj17V != IntPtr.Zero)
		{
			s6E3sV98yD(ifR3HTj17V);
			ifR3HTj17V = IntPtr.Zero;
		}
	}

	public KeyboardService()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
	}
}
