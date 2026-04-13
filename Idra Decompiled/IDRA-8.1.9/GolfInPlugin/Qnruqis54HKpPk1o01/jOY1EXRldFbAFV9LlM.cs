using System;
using System.Runtime.CompilerServices;
using GolfInPlugin;
using HarmonyLib;
using IDRASharedModels;
using Newtonsoft.Json;
using PimDeWitte.UnityMainThreadDispatcher;
using sX02IJN7NqxvB7iKPK;
using zLGfTg8qMbPmqnv69o;

namespace Qnruqis54HKpPk1o01;

[HarmonyPatch(typeof(homeMenu))]
internal class jOY1EXRldFbAFV9LlM
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public homeMenu PYTcz0YUII;

		public _003C_003Ec__DisplayClass0_0()
		{
			WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
			base._002Ector();
		}

		internal void NVGcnUFTra()
		{
			try
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(5512));
				string result = ManagerSettings.Instance.Reload(checkNewProp: false).Result;
				if (!string.IsNullOrWhiteSpace(result))
				{
					global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)result);
				}
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(5606) + JsonConvert.SerializeObject(ManagerSettings.Instance, Formatting.Indented)));
				PYTcz0YUII.topPnl.gs.GimmeCircleEnabledTgl.isOn = ManagerSettings.Instance.VisualSettings.EnableGimmeCircle;
				PYTcz0YUII.topPnl.gs.EnableDistanceDisplay.isOn = ManagerSettings.Instance.VisualSettings.EnableDistanceDisplay;
				if (ManagerSettings.Instance.VisualSettings.DistanceCountDirection == 1)
				{
					PYTcz0YUII.topPnl.gs.DistanceCountDownClick();
				}
				else if (ManagerSettings.Instance.VisualSettings.DistanceCountDirection == 0)
				{
					PYTcz0YUII.topPnl.gs.DistanceCountUpClick();
				}
				if (ManagerSettings.Instance.GameSettings.MiniMapLocation == 0)
				{
					PYTcz0YUII.topPnl.gs.MMLeftTxtClick();
				}
				else
				{
					PYTcz0YUII.topPnl.gs.MMRightTxtClick();
				}
				bool num = PYTcz0YUII.topPnl.globalSettings.Game_s.units != ManagerSettings.Instance.PostShotMetricUnit;
				PYTcz0YUII.topPnl.globalSettings.Game_s.units = ManagerSettings.Instance.PostShotMetricUnit;
				if (num)
				{
					PYTcz0YUII.mainGameControler.UnitsChanged(PYTcz0YUII.topPnl.globalSettings.Game_s.units);
				}
				PYTcz0YUII.topPnl.globalSettings.Game_s.RotationStyle = ManagerSettings.Instance.GameSettings.PlayerRotation;
				PYTcz0YUII.topPnl.globalSettings.Game_s.scorecardAfterHole = ManagerSettings.Instance.GameSettings.ScoreCardTimeAfterHole;
				PYTcz0YUII.topPnl.globalSettings.Game_s.altitude = ManagerSettings.Instance.GameSettings.GlobalAltitude;
				PYTcz0YUII.topPnl.gs.OffsetEnableToggle.isOn = ManagerSettings.Instance.VisualSettings.EnableTeeOffset;
				PYTcz0YUII.mainGameControler.camoffs.enable = ManagerSettings.Instance.VisualSettings.EnableTeeOffset;
				if (ManagerSettings.Instance.VisualSettings.EnableTeeOffset)
				{
					float num2 = global::GolfInPlugin.GolfInPlugin.Inch2millimeter(ManagerSettings.Instance.VisualSettings.BaseCenterOffsetInches);
					if (ManagerSettings.Instance.VisualSettings.RightLeftHittingMatOffset == 1)
					{
						num2 *= -1f;
					}
					if (!ManagerSettings.Instance.VisualSettings.EnableHittingMatOffset)
					{
						num2 = 0f;
					}
					PYTcz0YUII.mainGameControler.camoffs.offset_rh = num2;
					PYTcz0YUII.mainGameControler.camoffs.offset_lh = num2;
					PYTcz0YUII.mainGameControler.camoffs.width = global::GolfInPlugin.GolfInPlugin.Inch2millimeter(ManagerSettings.Instance.VisualSettings.ScreenWidthInches);
				}
				else
				{
					PYTcz0YUII.mainGameControler.camoffs.offset_rh = 0f;
					PYTcz0YUII.mainGameControler.camoffs.offset_lh = 0f;
					PYTcz0YUII.mainGameControler.camoffs.width = 0f;
				}
				if (ManagerSettings.Instance.RoundSettings.ForceRealistic)
				{
					PYTcz0YUII.topPnl.globalSettings.Game_s.ShotBoost = 100f;
					PYTcz0YUII.topPnl.globalSettings.Game_s.BallCurvature = 1f;
					PYTcz0YUII.topPnl.globalSettings.Game_s.PlayMode = 0;
				}
				PYTcz0YUII.topPnl.SaveGameSettings();
				PYTcz0YUII.topPnl.LoadPlayerSetting();
				PYTcz0YUII.topPnl.LoadSettingsFromDB();
			}
			catch (Exception ex)
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(5792) + ex.Message));
			}
		}
	}

	private static void Ggtwot1dM2(homeMenu P_0)
	{
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals28 = new _003C_003Ec__DisplayClass0_0();
		CS_0024_003C_003E8__locals28.PYTcz0YUII = P_0;
		UnityMainThreadDispatcher.Instance().Enqueue(delegate
		{
			try
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(5512));
				string result = ManagerSettings.Instance.Reload(checkNewProp: false).Result;
				if (!string.IsNullOrWhiteSpace(result))
				{
					global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)result);
				}
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(5606) + JsonConvert.SerializeObject(ManagerSettings.Instance, Formatting.Indented)));
				CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.gs.GimmeCircleEnabledTgl.isOn = ManagerSettings.Instance.VisualSettings.EnableGimmeCircle;
				CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.gs.EnableDistanceDisplay.isOn = ManagerSettings.Instance.VisualSettings.EnableDistanceDisplay;
				if (ManagerSettings.Instance.VisualSettings.DistanceCountDirection == 1)
				{
					CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.gs.DistanceCountDownClick();
				}
				else if (ManagerSettings.Instance.VisualSettings.DistanceCountDirection == 0)
				{
					CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.gs.DistanceCountUpClick();
				}
				if (ManagerSettings.Instance.GameSettings.MiniMapLocation == 0)
				{
					CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.gs.MMLeftTxtClick();
				}
				else
				{
					CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.gs.MMRightTxtClick();
				}
				bool num = CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.globalSettings.Game_s.units != ManagerSettings.Instance.PostShotMetricUnit;
				CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.globalSettings.Game_s.units = ManagerSettings.Instance.PostShotMetricUnit;
				if (num)
				{
					CS_0024_003C_003E8__locals28.PYTcz0YUII.mainGameControler.UnitsChanged(CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.globalSettings.Game_s.units);
				}
				CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.globalSettings.Game_s.RotationStyle = ManagerSettings.Instance.GameSettings.PlayerRotation;
				CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.globalSettings.Game_s.scorecardAfterHole = ManagerSettings.Instance.GameSettings.ScoreCardTimeAfterHole;
				CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.globalSettings.Game_s.altitude = ManagerSettings.Instance.GameSettings.GlobalAltitude;
				CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.gs.OffsetEnableToggle.isOn = ManagerSettings.Instance.VisualSettings.EnableTeeOffset;
				CS_0024_003C_003E8__locals28.PYTcz0YUII.mainGameControler.camoffs.enable = ManagerSettings.Instance.VisualSettings.EnableTeeOffset;
				if (ManagerSettings.Instance.VisualSettings.EnableTeeOffset)
				{
					float num2 = global::GolfInPlugin.GolfInPlugin.Inch2millimeter(ManagerSettings.Instance.VisualSettings.BaseCenterOffsetInches);
					if (ManagerSettings.Instance.VisualSettings.RightLeftHittingMatOffset == 1)
					{
						num2 *= -1f;
					}
					if (!ManagerSettings.Instance.VisualSettings.EnableHittingMatOffset)
					{
						num2 = 0f;
					}
					CS_0024_003C_003E8__locals28.PYTcz0YUII.mainGameControler.camoffs.offset_rh = num2;
					CS_0024_003C_003E8__locals28.PYTcz0YUII.mainGameControler.camoffs.offset_lh = num2;
					CS_0024_003C_003E8__locals28.PYTcz0YUII.mainGameControler.camoffs.width = global::GolfInPlugin.GolfInPlugin.Inch2millimeter(ManagerSettings.Instance.VisualSettings.ScreenWidthInches);
				}
				else
				{
					CS_0024_003C_003E8__locals28.PYTcz0YUII.mainGameControler.camoffs.offset_rh = 0f;
					CS_0024_003C_003E8__locals28.PYTcz0YUII.mainGameControler.camoffs.offset_lh = 0f;
					CS_0024_003C_003E8__locals28.PYTcz0YUII.mainGameControler.camoffs.width = 0f;
				}
				if (ManagerSettings.Instance.RoundSettings.ForceRealistic)
				{
					CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.globalSettings.Game_s.ShotBoost = 100f;
					CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.globalSettings.Game_s.BallCurvature = 1f;
					CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.globalSettings.Game_s.PlayMode = 0;
				}
				CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.SaveGameSettings();
				CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.LoadPlayerSetting();
				CS_0024_003C_003E8__locals28.PYTcz0YUII.topPnl.LoadSettingsFromDB();
			}
			catch (Exception ex)
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(5792) + ex.Message));
			}
		});
	}

	[HarmonyPatch("LocalGameClick")]
	[HarmonyPrefix]
	public static void gLQwFyTrug(homeMenu P_0)
	{
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(2438));
		Ggtwot1dM2(P_0);
	}

	[HarmonyPrefix]
	[HarmonyPatch("PracticeClick")]
	public static void bduwjKPVQc(homeMenu P_0)
	{
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(2536));
		Ggtwot1dM2(P_0);
	}

	[HarmonyPatch("ResetConnectConnection")]
	[HarmonyPrefix]
	public static bool coqwYRAQCF()
	{
		return false;
	}

	[HarmonyPrefix]
	[HarmonyPatch("DownloadLatestPublicBeta")]
	public static bool V1GwylGgD6()
	{
		return false;
	}

	[HarmonyPatch("DownloadLatestStable")]
	[HarmonyPrefix]
	public static bool NBtwbh6o9N()
	{
		return false;
	}

	public jOY1EXRldFbAFV9LlM()
	{
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		base._002Ector();
	}
}
