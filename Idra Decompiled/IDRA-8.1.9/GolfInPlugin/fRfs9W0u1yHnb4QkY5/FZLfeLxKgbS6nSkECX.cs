using System;
using GolfInPlugin;
using HarmonyLib;
using IDRASharedModels;
using UnityEngine;
using UnityEngine.UI;
using sX02IJN7NqxvB7iKPK;
using zLGfTg8qMbPmqnv69o;

namespace fRfs9W0u1yHnb4QkY5;

[HarmonyPatch(typeof(LMdata))]
internal class FZLfeLxKgbS6nSkECX
{
	[HarmonyPatch("FixedUpdate")]
	[HarmonyPrefix]
	public static bool z76w4KCp26(LMdata P_0)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)P_0.TcpStatus).color = (global::GolfInPlugin.GolfInPlugin.Instance.cn30UuvSh().PY5NEVtJT() ? Color.green : Color.red);
		P_0.HearthBeatTime += ((Time.timeScale > 1f) ? 0f : Time.deltaTime);
		return false;
	}

	[HarmonyPostfix]
	[HarmonyPatch("CopyClubShotData")]
	public static void UCewNRFRQq(LMdata P_0)
	{
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(2714));
		try
		{
			global::GolfInPlugin.GolfInPlugin.Instance.cn30UuvSh().FmuInJAVu(new ShotDataDto
			{
				BallData = new BallDataDto
				{
					Speed = (float)P_0.fSP,
					HLA = (float)P_0.fAZ,
					VLA = (float)P_0.fEL,
					CarryDistance = P_0.traj.GetShotDistance(),
					SideSpin = (float)P_0.fSS,
					BackSpin = (float)P_0.fBS,
					TotalSpin = (float)P_0.fTS
				},
				ClubData = new ClubDataDto
				{
					Speed = (float)P_0.pfCS,
					Path = (float)P_0.pfHP,
					SpeedAtImpact = (float)P_0.pfSI,
					FaceToTarget = (float)P_0.pfFC,
					AngleOfAttack = (float)P_0.pfVP,
					ClosureRate = (float)P_0.pfCR,
					HorizontalFaceImpact = (float)P_0.pfHI,
					VerticalFaceImpact = (float)P_0.pfVI,
					Lie = (float)P_0.pfLI,
					Loft = (float)P_0.pfLE
				},
				ShotNumber = P_0.traj.ShotCounter
			}).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (Exception ex)
		{
			global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(2768) + ex.Message));
		}
	}

	public FZLfeLxKgbS6nSkECX()
	{
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		base._002Ector();
	}
}
