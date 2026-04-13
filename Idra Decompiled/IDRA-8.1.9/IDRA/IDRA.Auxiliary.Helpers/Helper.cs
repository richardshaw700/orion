using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using GICTSCore.Data;
using GhU84wwqvI4UZ3pBfu;
using IDRA.Internationalization;
using sxB8TYTZ87aKuujytY;

namespace IDRA.Auxiliary.Helpers;

public static class Helper
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public MediaPlayer UXIINuFBQi;

		public TaskCompletionSource<bool> MRyIwtjRaN;

		public _003C_003Ec__DisplayClass1_0()
		{
			RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
			base._002Ector();
		}

		internal void vSCITXWi3U(object? sender, EventArgs e)
		{
			UXIINuFBQi.Close();
			MRyIwtjRaN.TrySetResult(result: true);
		}
	}

	private static CultureResources WvsCYorEMW;

	public static Task PlayAudioFileAsync(string file)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals8.MRyIwtjRaN = new TaskCompletionSource<bool>();
		CS_0024_003C_003E8__locals8.UXIINuFBQi = new MediaPlayer();
		CS_0024_003C_003E8__locals8.UXIINuFBQi.MediaEnded += delegate
		{
			CS_0024_003C_003E8__locals8.UXIINuFBQi.Close();
			CS_0024_003C_003E8__locals8.MRyIwtjRaN.TrySetResult(result: true);
		};
		CS_0024_003C_003E8__locals8.UXIINuFBQi.Open(new Uri(file));
		CS_0024_003C_003E8__locals8.UXIINuFBQi.Play();
		return CS_0024_003C_003E8__locals8.MRyIwtjRaN.Task;
	}

	public static string GetAssemblyVersion()
	{
		return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
	}

	public static void ToggleUILanguage()
	{
		CultureInfo currentCulture = WvsCYorEMW.GetCurrentCulture();
		if (currentCulture != null && !string.IsNullOrWhiteSpace(currentCulture.Name))
		{
			string name = (IDRAConstant.EnglishCulture.Contains(currentCulture.Name) ? IDRAConstant.FrenchCulture : IDRAConstant.EnglishCulture);
			WvsCYorEMW.SetCulture(new CultureInfo(name));
		}
	}

	public static string GetReverseCulture()
	{
		if (string.IsNullOrWhiteSpace(WvsCYorEMW?.GetCurrentCulture()?.Name))
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(11818);
		}
		if (!IDRAConstant.EnglishCulture.Contains(WvsCYorEMW.GetCurrentCulture().Name))
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(11826);
		}
		return QQXBLjLprwI58ya4VR.y8v8TMFOCb(11818);
	}

	public static void DisableWPFTabletSupport()
	{
		TabletDeviceCollection tabletDevices = Tablet.TabletDevices;
		if (tabletDevices.Count <= 0 || typeof(InputManager).InvokeMember(QQXBLjLprwI58ya4VR.y8v8TMFOCb(11834), BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetProperty, null, InputManager.Current, null) == null)
		{
			return;
		}
		Type type = ((object)tabletDevices).GetType();
		checked
		{
			int num = tabletDevices.Count + 1;
			while (tabletDevices.Count > 0)
			{
				type.InvokeMember(QQXBLjLprwI58ya4VR.y8v8TMFOCb(11860), BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, tabletDevices, new object[1] { 0u });
				num--;
				if (tabletDevices.Count != num)
				{
					throw new Win32Exception(QQXBLjLprwI58ya4VR.y8v8TMFOCb(11902));
				}
			}
		}
	}

	public static double FpsToMph(double feetPerSecond)
	{
		return feetPerSecond * 0.681818;
	}

	public static double FeetToYard(double ft)
	{
		return ft / 3.0;
	}

	public static double Mph2Kph(double mph)
	{
		return mph *= 1.60934;
	}

	public static double Yard2Meter(double yard)
	{
		return yard *= 0.9144;
	}

	public static double Deg2Rad(double deg)
	{
		return deg * Math.PI / 180.0;
	}

	public static void CopyDirectoryRecursively(string sourceDir, string destinationDir)
	{
		if (!Directory.Exists(destinationDir))
		{
			Directory.CreateDirectory(destinationDir);
		}
		string[] files = Directory.GetFiles(sourceDir);
		foreach (string obj in files)
		{
			string fileName = Path.GetFileName(obj);
			string destFileName = Path.Combine(destinationDir, fileName);
			File.Copy(obj, destFileName, overwrite: true);
		}
		files = Directory.GetDirectories(sourceDir);
		foreach (string obj2 in files)
		{
			string fileName2 = Path.GetFileName(obj2);
			string destinationDir2 = Path.Combine(destinationDir, fileName2);
			CopyDirectoryRecursively(obj2, destinationDir2);
		}
	}

	static Helper()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		WvsCYorEMW = new CultureResources();
	}
}
