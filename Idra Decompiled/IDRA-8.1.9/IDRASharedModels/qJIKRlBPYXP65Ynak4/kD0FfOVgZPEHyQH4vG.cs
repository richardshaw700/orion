using System.Net.Sockets;
using GYFmeytn3uk9KnUELA;

namespace qJIKRlBPYXP65Ynak4;

internal static class kD0FfOVgZPEHyQH4vG
{
	public static bool lZ6nUy0SY(this Socket P_0)
	{
		try
		{
			return !P_0.Poll(1, SelectMode.SelectRead) || P_0.Available != 0;
		}
		catch (SocketException)
		{
			return false;
		}
	}

	static kD0FfOVgZPEHyQH4vG()
	{
		G2089JiDB7k4x1yr7J.kLjw4iIsCLsZtxc4lksN0j();
	}
}
