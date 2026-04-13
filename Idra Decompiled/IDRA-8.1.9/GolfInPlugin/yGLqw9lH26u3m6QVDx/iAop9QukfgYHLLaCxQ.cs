using System;
using System.Reflection;
using GolfInPlugin;
using HarmonyLib;
using UnityEngine;
using UnityEngine.EventSystems;
using sX02IJN7NqxvB7iKPK;
using zLGfTg8qMbPmqnv69o;

namespace yGLqw9lH26u3m6QVDx;

[HarmonyPatch(typeof(CameraControlScriptGSP))]
internal class iAop9QukfgYHLLaCxQ
{
	[HarmonyPostfix]
	[HarmonyPatch("SendAimStick")]
	public static void RdrwEn9xid(CameraControlScriptGSP P_0)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(1614));
			FieldInfo field = ((object)P_0).GetType().GetField(Dpdrn94xidrKkBCvWK.vZjKJCNxST(1660), BindingFlags.Instance | BindingFlags.NonPublic);
			if (field != null)
			{
				RaycastHit val = (RaycastHit)field.GetValue(P_0);
				GameObject currentSelectedGameObject = EventSystem.current.currentSelectedGameObject;
				if (!((Object)(object)currentSelectedGameObject != (Object)null) || currentSelectedGameObject.layer != LayerMask.NameToLayer(Dpdrn94xidrKkBCvWK.vZjKJCNxST(1670)))
				{
					P_0.mGC.AimPoint = (P_0.mGC.LastAimPoint = ((RaycastHit)(ref val)).point);
				}
			}
		}
		catch (Exception ex)
		{
			global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(1678) + ex.Message));
		}
	}

	public iAop9QukfgYHLLaCxQ()
	{
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		base._002Ector();
	}
}
