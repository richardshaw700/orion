using System;
using System.Net.Sockets;

namespace wVHl9VOlgpYv6rdPWy;

internal static class BcgsSZK7hKQBNJUNhs
{
	public static bool GXh5Rfs9W(this Socket P_0)
	{
		try
		{
			return !P_0.Poll(1, SelectMode.SelectRead) || P_0.Available != 0;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
