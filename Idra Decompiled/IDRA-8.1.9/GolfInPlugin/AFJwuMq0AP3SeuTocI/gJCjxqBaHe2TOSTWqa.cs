using HarmonyLib;
using zLGfTg8qMbPmqnv69o;

namespace AFJwuMq0AP3SeuTocI;

[HarmonyPatch(typeof(TCPserver))]
internal class gJCjxqBaHe2TOSTWqa
{
	[HarmonyPatch("TCPIPinit")]
	[HarmonyPrefix]
	public static bool RpBwzU7mgI()
	{
		return false;
	}

	[HarmonyPrefix]
	[HarmonyPatch("Update")]
	public static bool odJctLGfTg()
	{
		return false;
	}

	[HarmonyPrefix]
	[HarmonyPatch("OnApplicationQuit")]
	public static bool yMbcwPmqnv()
	{
		return false;
	}

	[HarmonyPrefix]
	[HarmonyPatch("KillTCPServer")]
	public static bool W9occ1whVn()
	{
		return false;
	}

	[HarmonyPatch("ForceKillTCPServer")]
	[HarmonyPrefix]
	public static bool Rd2cKiau9H()
	{
		return false;
	}

	[HarmonyPrefix]
	[HarmonyPatch("ListenForIncommingRequests")]
	public static bool lUIcOStbtf()
	{
		return false;
	}

	[HarmonyPrefix]
	[HarmonyPatch("CleanUpConnection2LMKill")]
	public static bool OBMcTkmkAk()
	{
		return false;
	}

	[HarmonyPrefix]
	[HarmonyPatch("SendRecipeData")]
	public static bool Q5VchyVQqi(int P_0)
	{
		return false;
	}

	[HarmonyPrefix]
	[HarmonyPatch("SendClubToLM")]
	public static bool IY3cuXnOI6(string P_0)
	{
		return false;
	}

	[HarmonyPatch("SendClubToLM2")]
	[HarmonyPrefix]
	public static bool p1Lcl5YBK7(string P_0)
	{
		return false;
	}

	[HarmonyPatch("SendDist2LM")]
	[HarmonyPrefix]
	public static bool iQucrnyCxU(string P_0)
	{
		return false;
	}

	[HarmonyPatch("SendMsgToLM")]
	[HarmonyPrefix]
	public static bool LyBc9kq6GM(string P_0)
	{
		return false;
	}

	[HarmonyPrefix]
	[HarmonyPatch("SendMessage")]
	public static bool R44cDQ43JJ(byte[] P_0, int P_1)
	{
		return false;
	}

	[HarmonyPatch("ObjectToByteArray")]
	[HarmonyPrefix]
	public static bool r0YcPDf1ZD(object P_0)
	{
		return false;
	}

	public gJCjxqBaHe2TOSTWqa()
	{
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		base._002Ector();
	}
}
