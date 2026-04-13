using System;
using System.Runtime.CompilerServices;
using BepInEx.Logging;
using GolfInPlugin;
using HarmonyLib;
using IDRASharedModels;
using PimDeWitte.UnityMainThreadDispatcher;
using SwingPlateDr;
using UnityEngine.UI;
using sX02IJN7NqxvB7iKPK;
using zLGfTg8qMbPmqnv69o;

namespace bqtahUH0VsWSFQC6d9;

[HarmonyPatch(typeof(LieAngleScript))]
internal class pV2k19Wbgrdnu37fNR
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public LieAngleScript kclKwmGGeu;

		public bool QTZKcJmD2N;

		public _003C_003Ec__DisplayClass2_0()
		{
			WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
			base._002Ector();
		}

		internal void DkEKt7LCi0()
		{
			try
			{
				LieAngleScript obj = kclKwmGGeu;
				object obj2;
				if (obj == null)
				{
					obj2 = null;
				}
				else
				{
					Text lieTextLeftRight = obj.LieTextLeftRight;
					obj2 = ((lieTextLeftRight != null) ? lieTextLeftRight.text : null);
				}
				string text = (string)obj2;
				LieAngleScript obj3 = kclKwmGGeu;
				object obj4;
				if (obj3 == null)
				{
					obj4 = null;
				}
				else
				{
					Text lieTextUpDown = obj3.LieTextUpDown;
					obj4 = ((lieTextUpDown != null) ? lieTextUpDown.text : null);
				}
				string text2 = (string)obj4;
				float num = (float)Math.Round(kclKwmGGeu.GetLieVLAchange(2, 0f), 1);
				float num2 = (float)Math.Round(kclKwmGGeu.GetLieHLAchange(2, 0f), 1);
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(5876), DateTime.Now));
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(5950), QTZKcJmD2N));
				ManualLogSource l6UB92DOY = global::GolfInPlugin.GolfInPlugin.l6UB92DOY;
				string text3 = Dpdrn94xidrKkBCvWK.vZjKJCNxST(5992);
				string text4 = Dpdrn94xidrKkBCvWK.vZjKJCNxST(6022);
				LieAngleScript obj5 = kclKwmGGeu;
				object obj6;
				if (obj5 == null)
				{
					obj6 = null;
				}
				else
				{
					Text leftRightLabel = obj5.LeftRightLabel;
					obj6 = ((leftRightLabel != null) ? leftRightLabel.text : null);
				}
				l6UB92DOY.LogInfo((object)(text3 + text + text4 + (string?)obj6));
				ManualLogSource l6UB92DOY2 = global::GolfInPlugin.GolfInPlugin.l6UB92DOY;
				string text5 = Dpdrn94xidrKkBCvWK.vZjKJCNxST(6028);
				string text6 = Dpdrn94xidrKkBCvWK.vZjKJCNxST(6022);
				LieAngleScript obj7 = kclKwmGGeu;
				object obj8;
				if (obj7 == null)
				{
					obj8 = null;
				}
				else
				{
					Text upDownLabel = obj7.UpDownLabel;
					obj8 = ((upDownLabel != null) ? upDownLabel.text : null);
				}
				l6UB92DOY2.LogInfo((object)(text5 + text2 + text6 + (string?)obj8));
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6052), num2, num));
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6114), fQZw5Hqbya, YFqwCKlYbn));
				if (num == YFqwCKlYbn && num2 == fQZw5Hqbya)
				{
					global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6190), YFqwCKlYbn, fQZw5Hqbya));
					return;
				}
				float leftRightAngle = (QTZKcJmD2N ? 0f : num2);
				float upDownAngle = (QTZKcJmD2N ? 0f : num);
				global::GolfInPlugin.GolfInPlugin.Instance.nh9EWTXqh().SetAngles(new SwingPlateDrService.TerrainLiesAngles
				{
					LeftRightAngle = leftRightAngle,
					UpDownAngle = upDownAngle
				});
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6348), DateTime.Now, global::GolfInPlugin.GolfInPlugin.Instance.nh9EWTXqh().GetLog()));
				YFqwCKlYbn = num;
				fQZw5Hqbya = num2;
			}
			catch (Exception ex)
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6420) + ex.Message));
			}
		}
	}

	private static float YFqwCKlYbn;

	private static float fQZw5Hqbya;

	[HarmonyPostfix]
	[HarmonyPatch("DisplayLieNumbers")]
	public static void yBuwmUhDuh(bool P_0, LieAngleScript P_1)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals11 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals11.kclKwmGGeu = P_1;
		CS_0024_003C_003E8__locals11.QTZKcJmD2N = P_0;
		if (!ManagerSettings.Instance.UseSwingPlateDr || global::GolfInPlugin.GolfInPlugin.Instance.nh9EWTXqh() == null)
		{
			return;
		}
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(2632));
		UnityMainThreadDispatcher.Instance().Enqueue(delegate
		{
			try
			{
				LieAngleScript obj = CS_0024_003C_003E8__locals11.kclKwmGGeu;
				object obj2;
				if (obj == null)
				{
					obj2 = null;
				}
				else
				{
					Text lieTextLeftRight = obj.LieTextLeftRight;
					obj2 = ((lieTextLeftRight != null) ? lieTextLeftRight.text : null);
				}
				string text = (string)obj2;
				LieAngleScript obj3 = CS_0024_003C_003E8__locals11.kclKwmGGeu;
				object obj4;
				if (obj3 == null)
				{
					obj4 = null;
				}
				else
				{
					Text lieTextUpDown = obj3.LieTextUpDown;
					obj4 = ((lieTextUpDown != null) ? lieTextUpDown.text : null);
				}
				string text2 = (string)obj4;
				float num = (float)Math.Round(CS_0024_003C_003E8__locals11.kclKwmGGeu.GetLieVLAchange(2, 0f), 1);
				float num2 = (float)Math.Round(CS_0024_003C_003E8__locals11.kclKwmGGeu.GetLieHLAchange(2, 0f), 1);
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(5876), DateTime.Now));
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(5950), CS_0024_003C_003E8__locals11.QTZKcJmD2N));
				ManualLogSource l6UB92DOY = global::GolfInPlugin.GolfInPlugin.l6UB92DOY;
				string text3 = Dpdrn94xidrKkBCvWK.vZjKJCNxST(5992);
				string text4 = Dpdrn94xidrKkBCvWK.vZjKJCNxST(6022);
				LieAngleScript obj5 = CS_0024_003C_003E8__locals11.kclKwmGGeu;
				object obj6;
				if (obj5 == null)
				{
					obj6 = null;
				}
				else
				{
					Text leftRightLabel = obj5.LeftRightLabel;
					obj6 = ((leftRightLabel != null) ? leftRightLabel.text : null);
				}
				l6UB92DOY.LogInfo((object)(text3 + text + text4 + (string?)obj6));
				ManualLogSource l6UB92DOY2 = global::GolfInPlugin.GolfInPlugin.l6UB92DOY;
				string text5 = Dpdrn94xidrKkBCvWK.vZjKJCNxST(6028);
				string text6 = Dpdrn94xidrKkBCvWK.vZjKJCNxST(6022);
				LieAngleScript obj7 = CS_0024_003C_003E8__locals11.kclKwmGGeu;
				object obj8;
				if (obj7 == null)
				{
					obj8 = null;
				}
				else
				{
					Text upDownLabel = obj7.UpDownLabel;
					obj8 = ((upDownLabel != null) ? upDownLabel.text : null);
				}
				l6UB92DOY2.LogInfo((object)(text5 + text2 + text6 + (string?)obj8));
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6052), num2, num));
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6114), fQZw5Hqbya, YFqwCKlYbn));
				if (num == YFqwCKlYbn && num2 == fQZw5Hqbya)
				{
					global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6190), YFqwCKlYbn, fQZw5Hqbya));
				}
				else
				{
					float leftRightAngle = (CS_0024_003C_003E8__locals11.QTZKcJmD2N ? 0f : num2);
					float upDownAngle = (CS_0024_003C_003E8__locals11.QTZKcJmD2N ? 0f : num);
					global::GolfInPlugin.GolfInPlugin.Instance.nh9EWTXqh().SetAngles(new SwingPlateDrService.TerrainLiesAngles
					{
						LeftRightAngle = leftRightAngle,
						UpDownAngle = upDownAngle
					});
					global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6348), DateTime.Now, global::GolfInPlugin.GolfInPlugin.Instance.nh9EWTXqh().GetLog()));
					YFqwCKlYbn = num;
					fQZw5Hqbya = num2;
				}
			}
			catch (Exception ex)
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(6420) + ex.Message));
			}
		});
	}

	public pV2k19Wbgrdnu37fNR()
	{
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		base._002Ector();
	}

	static pV2k19Wbgrdnu37fNR()
	{
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		YFqwCKlYbn = -1f;
		fQZw5Hqbya = -1f;
	}
}
