using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Input;
using hkpxmGISLhTJrZLcmi;

namespace IDRAMonitor.Auxiliary.Helpers;

public static class Helper
{
	public static void DisableWPFTabletSupport()
	{
		TabletDeviceCollection tabletDevices = Tablet.TabletDevices;
		if (tabletDevices.Count <= 0 || typeof(InputManager).InvokeMember(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6968), BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetProperty, null, InputManager.Current, null) == null)
		{
			return;
		}
		Type type = ((object)tabletDevices).GetType();
		int num = tabletDevices.Count + 1;
		while (tabletDevices.Count > 0)
		{
			type.InvokeMember(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6994), BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, tabletDevices, new object[1] { 0u });
			num--;
			if (tabletDevices.Count != num)
			{
				throw new Win32Exception(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7036));
			}
		}
	}
}
