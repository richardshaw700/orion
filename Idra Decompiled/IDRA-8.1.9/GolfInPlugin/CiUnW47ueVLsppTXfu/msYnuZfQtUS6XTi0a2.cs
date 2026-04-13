using GolfInPlugin;
using HarmonyLib;
using sX02IJN7NqxvB7iKPK;
using zLGfTg8qMbPmqnv69o;

namespace CiUnW47ueVLsppTXfu;

[HarmonyPatch(typeof(SettingsTopPanel))]
internal class msYnuZfQtUS6XTi0a2
{
	[HarmonyPostfix]
	[HarmonyPatch("LoadDefaultSettings")]
	public static void yG6wVL2qEq(SettingsTopPanel P_0)
	{
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(3876));
		P_0.gs.HideUIonShot.isOn = true;
	}

	[HarmonyPatch("LoadPlayerSetting")]
	[HarmonyPostfix]
	public static void tlsw8CAgid(SettingsTopPanel P_0)
	{
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(3988));
		P_0.gs.HideUIonShot.isOn = true;
	}

	public msYnuZfQtUS6XTi0a2()
	{
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		base._002Ector();
	}
}
