using System;
using System.Runtime.CompilerServices;
using GolfInPlugin;
using HarmonyLib;
using IDRASharedModels;
using PimDeWitte.UnityMainThreadDispatcher;
using UnityEngine;
using sX02IJN7NqxvB7iKPK;
using zLGfTg8qMbPmqnv69o;

namespace xAfL9sS3CUVgjbkw1o;

[HarmonyPatch(typeof(MainGameControler))]
internal class sVtJTLgFN4nTkUQAtJ
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public MainGameControler QtZKODDk80;

		public _003C_003Ec__DisplayClass7_0()
		{
			WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
			base._002Ector();
		}

		internal void fbBKKrFmLv()
		{
			try
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6534), DateTime.Now));
				QtZKODDk80.lieAnglS.DisplayLieNumbers(QtZKODDk80.BallOnGreen);
			}
			catch (Exception ex)
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6578) + ex.Message));
			}
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public MainGameControler py2Kh1ZRTP;

		public _003C_003Ec__DisplayClass8_0()
		{
			WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
			base._002Ector();
		}

		internal void jqpKTorsQ1()
		{
			try
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6698), DateTime.Now));
				py2Kh1ZRTP.lieAnglS.DisplayLieNumbers(py2Kh1ZRTP.BallOnGreen);
			}
			catch (Exception ex)
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6738) + ex.Message));
			}
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public MainGameControler hGXKlLHC19;

		public _003C_003Ec__DisplayClass9_0()
		{
			WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
			base._002Ector();
		}

		internal void QHGKuUKHVH()
		{
			try
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(6856));
				bool flag = hGXKlLHC19.ActiveGameCourseName == Dpdrn94xidrKkBCvWK.vZjKJCNxST(6904);
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6924), flag, hGXKlLHC19.ActiveGameCourseName));
				hGXKlLHC19.dataPnl.dataBtn.ColorSet(true);
				hGXKlLHC19.dataPnl.panels.SetActive(true);
				if (!ManagerSettings.Instance.DisplayGSProDataTile)
				{
					if (ManagerSettings.Instance.UseGolfInPostShotInPractice && flag)
					{
						hGXKlLHC19.dataPnl.DataPanelClose();
					}
					else if (ManagerSettings.Instance.UseGolfInPostShotInGame && !flag)
					{
						hGXKlLHC19.dataPnl.DataPanelClose();
					}
				}
				global::GolfInPlugin.GolfInPlugin.Instance.cn30UuvSh().CGq2jlBQ6(hGXKlLHC19.ActiveGameCourseName).ConfigureAwait(continueOnCapturedContext: false);
			}
			catch (Exception ex)
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(7036) + ex.Message));
			}
		}
	}

	public static bool IDSwiC6bWC;

	public static bool ucFwaQNJq4;

	private static OnScreenKeyboard ubyw3kbb6o;

	[HarmonyPatch("Start")]
	[HarmonyPostfix]
	public static void HinwQOsKuS(MainGameControler P_0)
	{
		ubyw3kbb6o = P_0.HomeMenuGO.OSKGO.GetComponent<OnScreenKeyboard>();
	}

	[HarmonyPostfix]
	[HarmonyPatch("Update")]
	public static void uNlwZQh2dw(MainGameControler P_0)
	{
		bool activeSelf = ((Component)((Component)P_0.scoreCard).gameObject.transform.parent).gameObject.activeSelf;
		if (activeSelf != IDSwiC6bWC)
		{
			try
			{
				global::GolfInPlugin.GolfInPlugin.Instance.cn30UuvSh().CiUUnW4ue(activeSelf).ConfigureAwait(continueOnCapturedContext: false);
				IDSwiC6bWC = activeSelf;
			}
			catch (Exception ex)
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(2844) + ex.Message));
			}
		}
		bool flag = ubyw3kbb6o?.isActive ?? false;
		if (flag != ucFwaQNJq4)
		{
			try
			{
				global::GolfInPlugin.GolfInPlugin.Instance.cn30UuvSh().XLsippTXf(flag).ConfigureAwait(continueOnCapturedContext: false);
				ucFwaQNJq4 = flag;
			}
			catch (Exception ex2)
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(2960) + ex2.Message));
			}
		}
	}

	[HarmonyPrefix]
	[HarmonyPatch("StartConnect")]
	public static bool EIowGEkWkb()
	{
		return false;
	}

	[HarmonyPatch("EnableShot")]
	[HarmonyPrefix]
	public static bool bL6wLSen7R(MainGameControler P_0)
	{
		try
		{
			global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(3074));
			if (P_0.ShotState == 0)
			{
				global::GolfInPlugin.GolfInPlugin.Instance.cn30UuvSh().mYnMuZQtU().ConfigureAwait(continueOnCapturedContext: false);
			}
		}
		catch (Exception ex)
		{
			global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(3116) + ex.Message));
		}
		P_0.ShotState = 1;
		return false;
	}

	[HarmonyPatch("takeMulligan")]
	[HarmonyPostfix]
	public static void Iq4w2bhAyE(MainGameControler P_0)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals3.QtZKODDk80 = P_0;
		if (!ManagerSettings.Instance.UseSwingPlateDr)
		{
			return;
		}
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(3180));
		UnityMainThreadDispatcher.Instance().Enqueue(delegate
		{
			try
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6534), DateTime.Now));
				CS_0024_003C_003E8__locals3.QtZKODDk80.lieAnglS.DisplayLieNumbers(CS_0024_003C_003E8__locals3.QtZKODDk80.BallOnGreen);
			}
			catch (Exception ex)
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6578) + ex.Message));
			}
		});
	}

	[HarmonyPatch("GetNextHole")]
	[HarmonyPostfix]
	public static void I4XwXPmBwB(MainGameControler P_0)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals3.py2Kh1ZRTP = P_0;
		if (!ManagerSettings.Instance.UseSwingPlateDr)
		{
			return;
		}
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(3252));
		UnityMainThreadDispatcher.Instance().Enqueue(delegate
		{
			try
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6698), DateTime.Now));
				CS_0024_003C_003E8__locals3.py2Kh1ZRTP.lieAnglS.DisplayLieNumbers(CS_0024_003C_003E8__locals3.py2Kh1ZRTP.BallOnGreen);
			}
			catch (Exception ex)
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6738) + ex.Message));
			}
		});
	}

	[HarmonyPatch("FirstTeeSetup")]
	[HarmonyPostfix]
	public static void puJwIwVdtx(MainGameControler P_0)
	{
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass9_0();
		CS_0024_003C_003E8__locals8.hGXKlLHC19 = P_0;
		UnityMainThreadDispatcher.Instance().Enqueue(delegate
		{
			try
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(6856));
				bool flag = CS_0024_003C_003E8__locals8.hGXKlLHC19.ActiveGameCourseName == Dpdrn94xidrKkBCvWK.vZjKJCNxST(6904);
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6924), flag, CS_0024_003C_003E8__locals8.hGXKlLHC19.ActiveGameCourseName));
				CS_0024_003C_003E8__locals8.hGXKlLHC19.dataPnl.dataBtn.ColorSet(true);
				CS_0024_003C_003E8__locals8.hGXKlLHC19.dataPnl.panels.SetActive(true);
				if (!ManagerSettings.Instance.DisplayGSProDataTile)
				{
					if (ManagerSettings.Instance.UseGolfInPostShotInPractice && flag)
					{
						CS_0024_003C_003E8__locals8.hGXKlLHC19.dataPnl.DataPanelClose();
					}
					else if (ManagerSettings.Instance.UseGolfInPostShotInGame && !flag)
					{
						CS_0024_003C_003E8__locals8.hGXKlLHC19.dataPnl.DataPanelClose();
					}
				}
				global::GolfInPlugin.GolfInPlugin.Instance.cn30UuvSh().CGq2jlBQ6(CS_0024_003C_003E8__locals8.hGXKlLHC19.ActiveGameCourseName).ConfigureAwait(continueOnCapturedContext: false);
			}
			catch (Exception ex)
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(7036) + ex.Message));
			}
		});
	}

	[HarmonyPrefix]
	[HarmonyPatch("EndRoundCleanUp")]
	public static bool yg1wk4TIgI()
	{
		try
		{
			global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(3322));
			global::GolfInPlugin.GolfInPlugin.Instance.cn30UuvSh().s6XpTi0a2().ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (Exception ex)
		{
			global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(3374) + ex.Message));
		}
		return true;
	}

	[HarmonyPrefix]
	[HarmonyPatch("ReportClubToLM")]
	public static bool iw9wMh1FmQ(MainGameControler P_0)
	{
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(3448));
		return XdgwUR44y2(ref P_0);
	}

	[HarmonyPrefix]
	[HarmonyPatch("ClubToLM")]
	public static bool dIVwp3tr0E(MainGameControler P_0)
	{
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(3526));
		return XdgwUR44y2(ref P_0);
	}

	private static bool XdgwUR44y2(ref MainGameControler P_0)
	{
		try
		{
			global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(3592));
			string handed = (P_0.player_a[P_0.ActivePlayer].hand ? Dpdrn94xidrKkBCvWK.vZjKJCNxST(3690) : Dpdrn94xidrKkBCvWK.vZjKJCNxST(3682));
			global::GolfInPlugin.GolfInPlugin.Instance.cn30UuvSh().is3GCUVgj(new PlayerDataDto
			{
				PlayerName = P_0.player_a[P_0.ActivePlayer].Name,
				PlayerID = P_0.player_a[P_0.ActivePlayer].PlayerID,
				Club = P_0.clubsel.clubs[P_0.clubsel.clubSelection],
				Handed = handed,
				DistanceToTarget = P_0.player_a[P_0.ActivePlayer].distanceToPin
			}).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (Exception ex)
		{
			global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(3698) + ex.Message));
		}
		return true;
	}

	public sVtJTLgFN4nTkUQAtJ()
	{
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		base._002Ector();
	}
}
