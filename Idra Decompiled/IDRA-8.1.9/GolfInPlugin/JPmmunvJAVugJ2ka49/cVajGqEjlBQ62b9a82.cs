using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.Models;
using GolfInPlugin;
using HarmonyLib;
using IDRASharedModels;
using PimDeWitte.UnityMainThreadDispatcher;
using sX02IJN7NqxvB7iKPK;
using zLGfTg8qMbPmqnv69o;

namespace JPmmunvJAVugJ2ka49;

[HarmonyPatch(typeof(NewRoundScript))]
internal class cVajGqEjlBQ62b9a82
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public NewRoundScript cJBK9dBCv5;

		public _003C_003Ec__DisplayClass0_0()
		{
			WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
			base._002Ector();
		}

		internal void kbkKrbLtAP()
		{
			try
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(7464));
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(7534));
				cJBK9dBCv5.elevationDD.value = ((!ManagerSettings.Instance.RoundSettings.UseCourseElevation) ? 1 : 0);
				cJBK9dBCv5.GimmiesDD.value = ManagerSettings.Instance.RoundSettings.SelectedGimmeCircleDistance;
				cJBK9dBCv5.StimpDD.value = ManagerSettings.Instance.RoundSettings.Stimp - 6;
				cJBK9dBCv5.pinsDD.value = ManagerSettings.Instance.RoundSettings.Pins;
				cJBK9dBCv5.MulliganDD.value = (ManagerSettings.Instance.RoundSettings.PermitMulligan ? 1 : 0);
				cJBK9dBCv5.PlayModeDD.value = (ManagerSettings.Instance.RoundSettings.ForceRealistic ? 1 : 0);
				cJBK9dBCv5.FairWayFirmnessDD.value = ManagerSettings.Instance.RoundSettings.SelectedFairWayFirmness;
				cJBK9dBCv5.GreenFirmnessDD.value = ManagerSettings.Instance.RoundSettings.SelectedGreenFirmness;
				cJBK9dBCv5.PuttingDD.value = ManagerSettings.Instance.RoundSettings.SelectedPutting;
				cJBK9dBCv5.AutoConcede.isOn = ManagerSettings.Instance.RoundSettings.AutoConcede;
				cJBK9dBCv5.ConcedeDD.value = ManagerSettings.Instance.RoundSettings.SelectedConcede;
				cJBK9dBCv5.HLACorrectEnable.isOn = false;
				cJBK9dBCv5.mainGameControler.camoffs.enable = ManagerSettings.Instance.VisualSettings.EnableTeeOffset;
				if (ManagerSettings.Instance.VisualSettings.EnableTeeOffset)
				{
					float num = global::GolfInPlugin.GolfInPlugin.Inch2millimeter(ManagerSettings.Instance.VisualSettings.BaseCenterOffsetInches);
					if (ManagerSettings.Instance.VisualSettings.RightLeftHittingMatOffset == 1)
					{
						num *= -1f;
					}
					if (!ManagerSettings.Instance.VisualSettings.EnableHittingMatOffset)
					{
						num = 0f;
					}
					cJBK9dBCv5.mainGameControler.camoffs.offset_rh = num;
					cJBK9dBCv5.mainGameControler.camoffs.offset_lh = num;
					cJBK9dBCv5.mainGameControler.camoffs.width = global::GolfInPlugin.GolfInPlugin.Inch2millimeter(ManagerSettings.Instance.VisualSettings.ScreenWidthInches);
				}
			}
			catch (Exception ex)
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(7646) + ex.Message));
			}
		}
	}

	[HarmonyPostfix]
	[HarmonyPatch("LoadCourseSettingsFromDB")]
	public static void bj1w6w7TcO(CourseRoundSettings P_0, NewRoundScript P_1)
	{
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals17 = new _003C_003Ec__DisplayClass0_0();
		CS_0024_003C_003E8__locals17.cJBK9dBCv5 = P_1;
		UnityMainThreadDispatcher.Instance().Enqueue(delegate
		{
			try
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(7464));
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(7534));
				CS_0024_003C_003E8__locals17.cJBK9dBCv5.elevationDD.value = ((!ManagerSettings.Instance.RoundSettings.UseCourseElevation) ? 1 : 0);
				CS_0024_003C_003E8__locals17.cJBK9dBCv5.GimmiesDD.value = ManagerSettings.Instance.RoundSettings.SelectedGimmeCircleDistance;
				CS_0024_003C_003E8__locals17.cJBK9dBCv5.StimpDD.value = ManagerSettings.Instance.RoundSettings.Stimp - 6;
				CS_0024_003C_003E8__locals17.cJBK9dBCv5.pinsDD.value = ManagerSettings.Instance.RoundSettings.Pins;
				CS_0024_003C_003E8__locals17.cJBK9dBCv5.MulliganDD.value = (ManagerSettings.Instance.RoundSettings.PermitMulligan ? 1 : 0);
				CS_0024_003C_003E8__locals17.cJBK9dBCv5.PlayModeDD.value = (ManagerSettings.Instance.RoundSettings.ForceRealistic ? 1 : 0);
				CS_0024_003C_003E8__locals17.cJBK9dBCv5.FairWayFirmnessDD.value = ManagerSettings.Instance.RoundSettings.SelectedFairWayFirmness;
				CS_0024_003C_003E8__locals17.cJBK9dBCv5.GreenFirmnessDD.value = ManagerSettings.Instance.RoundSettings.SelectedGreenFirmness;
				CS_0024_003C_003E8__locals17.cJBK9dBCv5.PuttingDD.value = ManagerSettings.Instance.RoundSettings.SelectedPutting;
				CS_0024_003C_003E8__locals17.cJBK9dBCv5.AutoConcede.isOn = ManagerSettings.Instance.RoundSettings.AutoConcede;
				CS_0024_003C_003E8__locals17.cJBK9dBCv5.ConcedeDD.value = ManagerSettings.Instance.RoundSettings.SelectedConcede;
				CS_0024_003C_003E8__locals17.cJBK9dBCv5.HLACorrectEnable.isOn = false;
				CS_0024_003C_003E8__locals17.cJBK9dBCv5.mainGameControler.camoffs.enable = ManagerSettings.Instance.VisualSettings.EnableTeeOffset;
				if (ManagerSettings.Instance.VisualSettings.EnableTeeOffset)
				{
					float num = global::GolfInPlugin.GolfInPlugin.Inch2millimeter(ManagerSettings.Instance.VisualSettings.BaseCenterOffsetInches);
					if (ManagerSettings.Instance.VisualSettings.RightLeftHittingMatOffset == 1)
					{
						num *= -1f;
					}
					if (!ManagerSettings.Instance.VisualSettings.EnableHittingMatOffset)
					{
						num = 0f;
					}
					CS_0024_003C_003E8__locals17.cJBK9dBCv5.mainGameControler.camoffs.offset_rh = num;
					CS_0024_003C_003E8__locals17.cJBK9dBCv5.mainGameControler.camoffs.offset_lh = num;
					CS_0024_003C_003E8__locals17.cJBK9dBCv5.mainGameControler.camoffs.width = global::GolfInPlugin.GolfInPlugin.Inch2millimeter(ManagerSettings.Instance.VisualSettings.ScreenWidthInches);
				}
			}
			catch (Exception ex)
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(7646) + ex.Message));
			}
		});
	}

	public cVajGqEjlBQ62b9a82()
	{
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		base._002Ector();
	}
}
