using System.Linq;
using GolfInPlugin;
using HarmonyLib;
using IDRASharedModels;
using UnityEngine;
using UnityEngine.UI;
using sX02IJN7NqxvB7iKPK;
using zLGfTg8qMbPmqnv69o;

namespace R1CrtVP6vDG4aWk9YN;

[HarmonyPatch(typeof(GameSetting))]
internal class iWTXqhDwGArMZEfGqn
{
	[HarmonyPostfix]
	[HarmonyPatch("Start")]
	public static void sX0wf2IJ7N(GameSetting P_0)
	{
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(1890));
		yxvw7B7iKP<Button>(P_0, new string[3]
		{
			Dpdrn94xidrKkBCvWK.vZjKJCNxST(1962),
			Dpdrn94xidrKkBCvWK.vZjKJCNxST(1996),
			Dpdrn94xidrKkBCvWK.vZjKJCNxST(2034)
		});
		yxvw7B7iKP<Toggle>(P_0, new string[1] { Dpdrn94xidrKkBCvWK.vZjKJCNxST(2062) });
		yxvw7B7iKP<HorizontalLayoutGroup>(P_0, new string[1] { Dpdrn94xidrKkBCvWK.vZjKJCNxST(2084) });
		AnHw1G1nMJ(P_0);
	}

	private static void yxvw7B7iKP<AV4ygResFWMXGR6U92>(GameSetting P_0, string[] P_1) where AV4ygResFWMXGR6U92 : Component
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		AV4ygResFWMXGR6U92[] componentsInChildren = ((Component)P_0).GetComponentsInChildren<AV4ygResFWMXGR6U92>(true);
		foreach (AV4ygResFWMXGR6U92 val in componentsInChildren)
		{
			if ((Object)(object)val == (Object)null)
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(2118) + typeof(AV4ygResFWMXGR6U92).Name + Dpdrn94xidrKkBCvWK.vZjKJCNxST(2158)));
			}
			else if (P_1.Contains(((Object)((Component)val).gameObject).name))
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(2208) + ((Object)((Component)val).gameObject).name));
				((Component)val).gameObject.SetActive(false);
				if (val is HorizontalLayoutGroup)
				{
					((Component)val).transform.localScale = Vector3.zero;
				}
			}
		}
	}

	[HarmonyPrefix]
	[HarmonyPatch("OSKCheckboxClick")]
	public static bool c09wdctJLK(GameSetting P_0)
	{
		if (!ManagerSettings.Instance.GameSettings.ForceOSK)
		{
			return true;
		}
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(2234));
		Q4Lwqs3JOy(P_0);
		return false;
	}

	[HarmonyPatch("DrawDistanceChange")]
	[HarmonyPrefix]
	public static bool AnHw1G1nMJ(GameSetting P_0)
	{
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(2288));
		float num = 5000f;
		P_0.mGC.mainCam.farClipPlane = num;
		P_0.topPnl.globalSettings.Game_s.DrawDistance = num;
		return false;
	}

	[HarmonyPrefix]
	[HarmonyPatch("SetOSKState")]
	public static bool ynDwBZwF7e(GameSetting P_0)
	{
		if (!ManagerSettings.Instance.GameSettings.ForceOSK)
		{
			return true;
		}
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(2346));
		Q4Lwqs3JOy(P_0);
		return false;
	}

	private static void Q4Lwqs3JOy(GameSetting P_0)
	{
		P_0.OSKToggle.isOn = true;
		P_0.topPnl.globalSettings.Game_s.ShowOSK = true;
		P_0.mGC.HomeMenuGO.OSKGO.SetActive(true);
	}

	[HarmonyPatch("LMcarry_click")]
	[HarmonyPrefix]
	public static bool ttAwJQnHgV(GameSetting P_0)
	{
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(2390));
		P_0.topPnl.globalSettings.Game_s.LMCarry = false;
		return false;
	}

	public iWTXqhDwGArMZEfGqn()
	{
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		base._002Ector();
	}
}
