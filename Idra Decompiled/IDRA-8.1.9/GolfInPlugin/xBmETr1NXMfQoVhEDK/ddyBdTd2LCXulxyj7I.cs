using Assets.Scripts.Helpers;
using GolfInPlugin;
using HarmonyLib;
using sX02IJN7NqxvB7iKPK;
using zLGfTg8qMbPmqnv69o;

namespace xBmETr1NXMfQoVhEDK;

[HarmonyPatch(typeof(SystemUpdate))]
internal class ddyBdTd2LCXulxyj7I
{
	[HarmonyPrefix]
	[HarmonyPatch("CheckForUpdate")]
	public static bool nVqwnDrXqr()
	{
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(4096));
		return false;
	}

	public ddyBdTd2LCXulxyj7I()
	{
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		base._002Ector();
	}
}
