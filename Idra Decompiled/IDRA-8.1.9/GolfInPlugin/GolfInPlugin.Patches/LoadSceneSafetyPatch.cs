using System.Collections;
using HarmonyLib;
using UnityEngine;
using sX02IJN7NqxvB7iKPK;

namespace GolfInPlugin.Patches;

[HarmonyPatch(typeof(MenuOrchestrator), "LoadScene")]
public static class LoadSceneSafetyPatch
{
	[HarmonyPrefix]
	public static void Prefix()
	{
		GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(3762));
		Application.targetFrameRate = 30;
	}

	[HarmonyPostfix]
	public static void Postfix(ref IEnumerator __result)
	{
		__result = chhwARkniy(__result);
	}

	private static IEnumerator chhwARkniy(IEnumerator P_0)
	{
		yield return P_0;
		GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(7106));
		yield return (object)new WaitForSeconds(2f);
		float num = 1f / Time.deltaTime;
		if (num > 25f)
		{
			GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(7224));
			Application.targetFrameRate = 60;
		}
		else
		{
			GolfInPlugin.l6UB92DOY.LogError((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(7320), num));
		}
	}
}
