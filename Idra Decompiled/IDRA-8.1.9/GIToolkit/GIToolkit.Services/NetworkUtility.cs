using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class NetworkUtility : INetworkUtility
{
	[CompilerGenerated]
	private Action<bool> Y3UxmxCktP;

	private bool FYhxjZDEVt;

	public event Action<bool> OnConnnectionStatusChanged
	{
		[CompilerGenerated]
		add
		{
			Action<bool> action = Y3UxmxCktP;
			Action<bool> action2;
			do
			{
				action2 = action;
				Action<bool> value2 = (Action<bool>)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref Y3UxmxCktP, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<bool> action = Y3UxmxCktP;
			Action<bool> action2;
			do
			{
				action2 = action;
				Action<bool> value2 = (Action<bool>)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref Y3UxmxCktP, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public void StartNetworkStatusTask()
	{
		while (true)
		{
			if (IsNetworkAvailable(0L) && !FYhxjZDEVt)
			{
				FYhxjZDEVt = !FYhxjZDEVt;
				Y3UxmxCktP(FYhxjZDEVt);
			}
			else if (!IsNetworkAvailable(0L) && FYhxjZDEVt)
			{
				FYhxjZDEVt = !FYhxjZDEVt;
				Y3UxmxCktP(FYhxjZDEVt);
			}
		}
	}

	public bool IsNetworkAvailable(long minimumSpeed)
	{
		if (!NetworkInterface.GetIsNetworkAvailable())
		{
			return false;
		}
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		foreach (NetworkInterface networkInterface in allNetworkInterfaces)
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up && networkInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback && networkInterface.NetworkInterfaceType != NetworkInterfaceType.Tunnel && networkInterface.Speed >= minimumSpeed && networkInterface.Description.IndexOf(so95DAFNMfktfjp4Dm.An6v7kuCGg(4960), StringComparison.OrdinalIgnoreCase) < 0 && networkInterface.Name.IndexOf(so95DAFNMfktfjp4Dm.An6v7kuCGg(4960), StringComparison.OrdinalIgnoreCase) < 0 && !networkInterface.Description.Equals(so95DAFNMfktfjp4Dm.An6v7kuCGg(4978), StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
		}
		return false;
	}

	public NetworkUtility()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
