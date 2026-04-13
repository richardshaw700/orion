using Microsoft.Win32;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class RegistryService
{
	public static bool IsProgramInstalled(string programName)
	{
		string name = so95DAFNMfktfjp4Dm.An6v7kuCGg(6374);
		using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name))
		{
			string[] subKeyNames = registryKey.GetSubKeyNames();
			foreach (string name2 in subKeyNames)
			{
				using RegistryKey registryKey2 = registryKey.OpenSubKey(name2);
				string text = registryKey2.GetValue(so95DAFNMfktfjp4Dm.An6v7kuCGg(6480)) as string;
				if (!string.IsNullOrWhiteSpace(text) && text.Contains(programName))
				{
					return true;
				}
			}
		}
		return false;
	}

	public RegistryService()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
