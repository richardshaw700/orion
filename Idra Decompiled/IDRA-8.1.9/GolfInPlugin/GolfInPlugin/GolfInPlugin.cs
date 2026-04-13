using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using IDRASharedModels;
using PimDeWitte.UnityMainThreadDispatcher;
using SwingPlateDr;
using UnityEngine;
using j78BTXhiBI0LPWc8Et;
using sX02IJN7NqxvB7iKPK;
using zLGfTg8qMbPmqnv69o;

namespace GolfInPlugin;

[BepInPlugin("GolfInPlugin", "GolfInPlugin", "1.0.0")]
[BepInProcess("GSPro.exe")]
public class GolfInPlugin : BaseUnityPlugin
{
	[Flags]
	private enum t4c3YBJOOiLUDvY6BB
	{

	}

	[Flags]
	private enum YiQU3ooNnBcYfYjdtx
	{

	}

	private struct YOshP5FPcsd0pU8MVE
	{
		public ushort lwfc0l2VBx;

		public ushort G95cg6DTPd;

		public uint YUTcSYLP3j;

		public uint nK2cEkFhf0;

		public IntPtr o9mcvp9Pnj;
	}

	[StructLayout(LayoutKind.Explicit)]
	private struct vOfWJHjQg73x4KeZJS
	{
		[FieldOffset(0)]
		public O0dHipYpcWD6pWA0jL LcgcfqD9Fu;

		[FieldOffset(0)]
		public YOshP5FPcsd0pU8MVE dkPc77PtQq;

		[FieldOffset(0)]
		public lN2Mo9yTJTySeV7Ce6 WjFcdhrVaV;
	}

	private struct O0dHipYpcWD6pWA0jL
	{
		public int dOOc1Gas1D;

		public int xuvcBF0oP6;

		public uint mNncqp9q93;

		public uint RBwcJ86ZQ1;

		public uint VjgcowcJAm;

		public IntPtr IIdcFZS3Qb;
	}

	private struct lN2Mo9yTJTySeV7Ce6
	{
		public uint c1OcjJ0yaj;

		public ushort BoucYs9oL9;

		public ushort LCfcySmU5T;
	}

	private struct DfX19pbm4NxuKmAxY2
	{
		public int lxScbvvfF4;

		public vOfWJHjQg73x4KeZJS RHQcmH0pto;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public GolfInPlugin lLjcGBkA0p;

		public ushort tt1cLjBrPb;

		public float I4tc2sB1bm;

		public _003C_003Ec__DisplayClass30_0()
		{
			WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
			base._002Ector();
		}

		internal void E2McZnjfoE()
		{
			((MonoBehaviour)lLjcGBkA0p).StartCoroutine(lLjcGBkA0p.vhKhQBNJU(tt1cLjBrPb, I4tc2sB1bm));
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public string cIGcIx4FFf;

		public _003C_003Ec__DisplayClass37_0()
		{
			WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
			base._002Ector();
		}

		internal void EXhcX6DPXB()
		{
			l6UB92DOY.LogInfo((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(4170) + cIGcIx4FFf));
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass43_0
	{
		public GolfInPlugin weUcML4aFA;

		public GspBoothData Js1cp9YWYo;

		public _003C_003Ec__DisplayClass43_0()
		{
			WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
			base._002Ector();
		}

		internal void nqyckKq3Kp()
		{
			weUcML4aFA.xEXqldFbA.mGC.camoffs.enable = Js1cp9YWYo.OffsetEnable;
			if (Js1cp9YWYo.OffsetEnable)
			{
				((BaseUnityPlugin)weUcML4aFA).Logger.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(4212), weUcML4aFA.xEXqldFbA.mGC.AimPoint.x, weUcML4aFA.xEXqldFbA.mGC.AimPoint.y, weUcML4aFA.xEXqldFbA.mGC.AimPoint.z));
				float num = Inch2millimeter(ManagerSettings.Instance.VisualSettings.BaseCenterOffsetInches);
				if (ManagerSettings.Instance.VisualSettings.RightLeftHittingMatOffset == 1)
				{
					num *= -1f;
				}
				if (!ManagerSettings.Instance.VisualSettings.EnableHittingMatOffset)
				{
					num = 0f;
				}
				weUcML4aFA.xEXqldFbA.mGC.camoffs.offset_rh = Feet2millimeter(Js1cp9YWYo.CenterOffset) + num;
				weUcML4aFA.xEXqldFbA.mGC.camoffs.offset_lh = Feet2millimeter(Js1cp9YWYo.CenterOffset) + num;
				weUcML4aFA.xEXqldFbA.mGC.camoffs.width = Inch2millimeter(Js1cp9YWYo.ScreenWidthInch);
				weUcML4aFA.xEXqldFbA.mGC.DrawCameras();
			}
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass45_0
	{
		public GolfInPlugin hikciN8LSo;

		public ClubDataDto gFgcaFDs6j;

		public _003C_003Ec__DisplayClass45_0()
		{
			WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
			base._002Ector();
		}

		internal void NNGcUt6GJl()
		{
			try
			{
				PlayerRunTimeData obj = hikciN8LSo.xEXqldFbA.mGC.player_a[hikciN8LSo.xEXqldFbA.mGC.ActivePlayer];
				if (obj != null)
				{
					obj.hand = gFgcaFDs6j.IsPlayerRightHand;
				}
				if ((Object)(object)hikciN8LSo.xEXqldFbA.mGC.clubsel != (Object)null)
				{
					hikciN8LSo.xEXqldFbA.mGC.clubsel.handIsRight = gFgcaFDs6j.IsPlayerRightHand;
					hikciN8LSo.xEXqldFbA.mGC.clubsel.handTxt.text = (gFgcaFDs6j.IsPlayerRightHand ? Dpdrn94xidrKkBCvWK.vZjKJCNxST(3690) : Dpdrn94xidrKkBCvWK.vZjKJCNxST(3682));
				}
				hikciN8LSo.xEXqldFbA.CopyClubShotData();
			}
			catch (Exception arg)
			{
				l6UB92DOY.LogError((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(4260), arg));
			}
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public string eXlcAKwFfR;

		public _003C_003Ec__DisplayClass46_0()
		{
			WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
			base._002Ector();
		}

		internal void J3fc3VPEnF()
		{
			l6UB92DOY.LogInfo((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(4170) + eXlcAKwFfR));
		}
	}

	internal static ManualLogSource l6UB92DOY;

	internal LMdata xEXqldFbA;

	[CompilerGenerated]
	private static GolfInPlugin BV9JLlMpn;

	[CompilerGenerated]
	private sJ9hssTCYj7GDPnrdy huqoi54HK;

	[CompilerGenerated]
	private SwingPlateDrService RPkF1o01x;

	[CompilerGenerated]
	private AutoTeeService X2kj19bgr;

	private static readonly Harmony wnuY37fNR;

	private ConfigEntry<bool> bqtyahU0V;

	private ConfigFile nWSbFQC6d;

	private UnityMainThreadDispatcher jmZmLfeLK;

	public static GolfInPlugin Instance
	{
		[CompilerGenerated]
		get
		{
			return BV9JLlMpn;
		}
		[CompilerGenerated]
		private set
		{
			BV9JLlMpn = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal sJ9hssTCYj7GDPnrdy cn30UuvSh()
	{
		return huqoi54HK;
	}

	[SpecialName]
	[CompilerGenerated]
	private void R8OgN7KdR(sJ9hssTCYj7GDPnrdy value)
	{
		huqoi54HK = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal SwingPlateDrService nh9EWTXqh()
	{
		return RPkF1o01x;
	}

	[SpecialName]
	[CompilerGenerated]
	private void aGAvrMZEf(SwingPlateDrService value)
	{
		RPkF1o01x = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal AutoTeeService X6v7DG4aW()
	{
		return X2kj19bgr;
	}

	[SpecialName]
	[CompilerGenerated]
	private void P9YdNoV4y(AutoTeeService value)
	{
		X2kj19bgr = value;
	}

	[DllImport("user32.dll", EntryPoint = "SendInput", SetLastError = true)]
	private static extern uint L30OdHFiJ(uint P_0, DfX19pbm4NxuKmAxY2[] P_1, int P_2);

	[DllImport("user32.dll", EntryPoint = "GetMessageExtraInfo")]
	private static extern IntPtr VbFTcgsSZ();

	public void SimulateHeldKey(ushort virtualKey, float holdDurationSeconds = 0.5f)
	{
		_003C_003Ec__DisplayClass30_0 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass30_0();
		CS_0024_003C_003E8__locals7.lLjcGBkA0p = this;
		CS_0024_003C_003E8__locals7.tt1cLjBrPb = virtualKey;
		CS_0024_003C_003E8__locals7.I4tc2sB1bm = holdDurationSeconds;
		UnityMainThreadDispatcher.Instance().Enqueue(delegate
		{
			((MonoBehaviour)CS_0024_003C_003E8__locals7.lLjcGBkA0p).StartCoroutine(CS_0024_003C_003E8__locals7.lLjcGBkA0p.vhKhQBNJU(CS_0024_003C_003E8__locals7.tt1cLjBrPb, CS_0024_003C_003E8__locals7.I4tc2sB1bm));
		});
	}

	private IEnumerator vhKhQBNJU(ushort P_0, float P_1)
	{
		Ihsu1VHl9(P_0, (YiQU3ooNnBcYfYjdtx)1);
		yield return (object)new WaitForSeconds(P_1);
		Ihsu1VHl9(P_0, (YiQU3ooNnBcYfYjdtx)3);
	}

	private void Ihsu1VHl9(ushort P_0, YiQU3ooNnBcYfYjdtx P_1)
	{
		DfX19pbm4NxuKmAxY2[] array = new DfX19pbm4NxuKmAxY2[1];
		array[0].lxScbvvfF4 = 1;
		array[0].RHQcmH0pto.dkPc77PtQq = new YOshP5FPcsd0pU8MVE
		{
			lwfc0l2VBx = P_0,
			G95cg6DTPd = 0,
			YUTcSYLP3j = (uint)P_1,
			o9mcvp9Pnj = VbFTcgsSZ(),
			nK2cEkFhf0 = 0u
		};
		if (L30OdHFiJ(1u, array, Marshal.SizeOf(typeof(DfX19pbm4NxuKmAxY2))) == 0)
		{
			Debug.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(308) + Marshal.GetLastWin32Error()));
		}
	}

	public bool SetOpenLoggingConsole(bool newVal)
	{
		try
		{
			l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(348), newVal));
			l6UB92DOY.LogInfo((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(432) + nWSbFQC6d.ConfigFilePath));
			bqtyahU0V.Value = newVal;
			nWSbFQC6d.Save();
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private void WlglpYv6r()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		Instance = this;
		Logger.Sources.Add((ILogSource)(object)l6UB92DOY);
		((BaseUnityPlugin)this).Logger.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(472));
		nWSbFQC6d = new ConfigFile(Dpdrn94xidrKkBCvWK.vZjKJCNxST(538), false);
		bqtyahU0V = nWSbFQC6d.Bind<bool>(Dpdrn94xidrKkBCvWK.vZjKJCNxST(598), Dpdrn94xidrKkBCvWK.vZjKJCNxST(632), false, (ConfigDescription)null);
		l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(650));
		string result = ManagerSettings.Instance.Reload(checkNewProp: false).Result;
		if (ManagerSettings.Instance.UseSwingPlateDr && nh9EWTXqh() == null)
		{
			l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(720));
			aGAvrMZEf(new SwingPlateDrService(ManagerSettings.Instance.SwingPlateDrPortComNumber, ManagerSettings.Instance.SwingPlateDrMinConsideredAngle));
			SwingPlateDrService swingPlateDrService = nh9EWTXqh();
			swingPlateDrService.DataReceived = (Action<string>)Delegate.Combine(swingPlateDrService.DataReceived, (Action<string>)delegate(string data)
			{
				_003C_003Ec__DisplayClass37_0 _003C_003Ec__DisplayClass37_ = new _003C_003Ec__DisplayClass37_0();
				_003C_003Ec__DisplayClass37_.cIGcIx4FFf = data;
				UnityMainThreadDispatcher.Instance().Enqueue(_003C_003Ec__DisplayClass37_.EXhcX6DPXB);
			});
		}
		if (!string.IsNullOrWhiteSpace(result))
		{
			l6UB92DOY.LogError((object)result);
		}
		kWce8Et9A();
		xEXqldFbA = Object.FindObjectOfType<LMdata>();
		if ((Object)(object)xEXqldFbA == (Object)null)
		{
			l6UB92DOY.LogError((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(826));
			return;
		}
		jmZmLfeLK = ((Component)xEXqldFbA).gameObject.AddComponent<UnityMainThreadDispatcher>();
		if ((Object)(object)jmZmLfeLK == (Object)null)
		{
			l6UB92DOY.LogError((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(874));
		}
		else
		{
			nsC9Yj7GD();
		}
	}

	private void wPWrySJ9h()
	{
		Application.targetFrameRate = 60;
	}

	private void nsC9Yj7GD()
	{
		cn30UuvSh().g1y4Hnb4Q();
		sJ9hssTCYj7GDPnrdy sJ9hssTCYj7GDPnrdy = cn30UuvSh();
		sJ9hssTCYj7GDPnrdy.yaH8e2TOS((Action<BallDataDto>)Delegate.Combine(sJ9hssTCYj7GDPnrdy.tDKVuJCjx(), new Action<BallDataDto>(oLLsaCxQq)));
		sJ9hssTCYj7GDPnrdy sJ9hssTCYj7GDPnrdy2 = cn30UuvSh();
		sJ9hssTCYj7GDPnrdy2.gTowtcIv4c((Action<ClubDataDto>)Delegate.Combine(sJ9hssTCYj7GDPnrdy2.fM0zAP3Se(), new Action<ClubDataDto>(LLqWw9H26)));
		sJ9hssTCYj7GDPnrdy sJ9hssTCYj7GDPnrdy3 = cn30UuvSh();
		sJ9hssTCYj7GDPnrdy3.JU3wKoNnBc((Action<GspBoothData>)Delegate.Combine(sJ9hssTCYj7GDPnrdy3.jvYwc6BBni(), new Action<GspBoothData>(Ap9RQkfgY)));
		sJ9hssTCYj7GDPnrdy sJ9hssTCYj7GDPnrdy4 = cn30UuvSh();
		sJ9hssTCYj7GDPnrdy4.w0pwhU8MVE((Action)Delegate.Combine(sJ9hssTCYj7GDPnrdy4.dshwTP5Pcs(), new Action(xTXPiBI0L)));
		sJ9hssTCYj7GDPnrdy sJ9hssTCYj7GDPnrdy5 = cn30UuvSh();
		sJ9hssTCYj7GDPnrdy5.sI0wrdHipp((Action)Delegate.Combine(sJ9hssTCYj7GDPnrdy5.u3xwl4KeZJ(), new Action(knrDdy978)));
	}

	private void knrDdy978()
	{
		SimulateHeldKey(39, 0.1f);
	}

	private void xTXPiBI0L()
	{
		SimulateHeldKey(37, 0.1f);
	}

	private void kWce8Et9A()
	{
		wnuY37fNR.PatchAll();
		foreach (MethodBase allPatchedMethod in Harmony.GetAllPatchedMethods())
		{
			((BaseUnityPlugin)this).Logger.LogInfo((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(998) + allPatchedMethod.Name));
		}
	}

	private void Ap9RQkfgY(GspBoothData P_0)
	{
		_003C_003Ec__DisplayClass43_0 CS_0024_003C_003E8__locals16 = new _003C_003Ec__DisplayClass43_0();
		CS_0024_003C_003E8__locals16.weUcML4aFA = this;
		CS_0024_003C_003E8__locals16.Js1cp9YWYo = P_0;
		UnityMainThreadDispatcher.Instance().Enqueue(delegate
		{
			CS_0024_003C_003E8__locals16.weUcML4aFA.xEXqldFbA.mGC.camoffs.enable = CS_0024_003C_003E8__locals16.Js1cp9YWYo.OffsetEnable;
			if (CS_0024_003C_003E8__locals16.Js1cp9YWYo.OffsetEnable)
			{
				((BaseUnityPlugin)CS_0024_003C_003E8__locals16.weUcML4aFA).Logger.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(4212), CS_0024_003C_003E8__locals16.weUcML4aFA.xEXqldFbA.mGC.AimPoint.x, CS_0024_003C_003E8__locals16.weUcML4aFA.xEXqldFbA.mGC.AimPoint.y, CS_0024_003C_003E8__locals16.weUcML4aFA.xEXqldFbA.mGC.AimPoint.z));
				float num = Inch2millimeter(ManagerSettings.Instance.VisualSettings.BaseCenterOffsetInches);
				if (ManagerSettings.Instance.VisualSettings.RightLeftHittingMatOffset == 1)
				{
					num *= -1f;
				}
				if (!ManagerSettings.Instance.VisualSettings.EnableHittingMatOffset)
				{
					num = 0f;
				}
				CS_0024_003C_003E8__locals16.weUcML4aFA.xEXqldFbA.mGC.camoffs.offset_rh = Feet2millimeter(CS_0024_003C_003E8__locals16.Js1cp9YWYo.CenterOffset) + num;
				CS_0024_003C_003E8__locals16.weUcML4aFA.xEXqldFbA.mGC.camoffs.offset_lh = Feet2millimeter(CS_0024_003C_003E8__locals16.Js1cp9YWYo.CenterOffset) + num;
				CS_0024_003C_003E8__locals16.weUcML4aFA.xEXqldFbA.mGC.camoffs.width = Inch2millimeter(CS_0024_003C_003E8__locals16.Js1cp9YWYo.ScreenWidthInch);
				CS_0024_003C_003E8__locals16.weUcML4aFA.xEXqldFbA.mGC.DrawCameras();
			}
		});
	}

	private void oLLsaCxQq(BallDataDto P_0)
	{
		xEXqldFbA.shotDataArray[0] = P_0.Speed;
		xEXqldFbA.shotDataArray[1] = P_0.VLA;
		xEXqldFbA.shotDataArray[2] = P_0.HLA;
		xEXqldFbA.shotDataArray[3] = (P_0.SideSpin.HasValue ? P_0.SideSpin.Value : 0f);
		xEXqldFbA.shotDataArray[4] = P_0.TotalSpin;
		xEXqldFbA.shotDataArray[5] = (P_0.BackSpin.HasValue ? P_0.BackSpin.Value : 0f);
		xEXqldFbA.shotDataArray[6] = P_0.SpinAxis;
		xEXqldFbA.shotDataArray[7] = (P_0.CarryDistance.HasValue ? P_0.CarryDistance.Value : 0f);
		UnityMainThreadDispatcher.Instance().Enqueue((Action)xEXqldFbA.CopyshotData);
	}

	private void LLqWw9H26(ClubDataDto P_0)
	{
		_003C_003Ec__DisplayClass45_0 CS_0024_003C_003E8__locals21 = new _003C_003Ec__DisplayClass45_0();
		CS_0024_003C_003E8__locals21.hikciN8LSo = this;
		CS_0024_003C_003E8__locals21.gFgcaFDs6j = P_0;
		xEXqldFbA.ClubShotDataArray[0] = CS_0024_003C_003E8__locals21.gFgcaFDs6j.Speed;
		xEXqldFbA.ClubShotDataArray[1] = CS_0024_003C_003E8__locals21.gFgcaFDs6j.AngleOfAttack;
		xEXqldFbA.ClubShotDataArray[2] = CS_0024_003C_003E8__locals21.gFgcaFDs6j.Path;
		xEXqldFbA.ClubShotDataArray[3] = CS_0024_003C_003E8__locals21.gFgcaFDs6j.FaceToTarget;
		xEXqldFbA.ClubShotDataArray[4] = CS_0024_003C_003E8__locals21.gFgcaFDs6j.Lie;
		xEXqldFbA.ClubShotDataArray[5] = CS_0024_003C_003E8__locals21.gFgcaFDs6j.Loft;
		xEXqldFbA.ClubShotDataArray[6] = CS_0024_003C_003E8__locals21.gFgcaFDs6j.ClosureRate;
		xEXqldFbA.ClubShotDataArray[7] = CS_0024_003C_003E8__locals21.gFgcaFDs6j.SpeedAtImpact;
		xEXqldFbA.ClubShotDataArray[8] = CS_0024_003C_003E8__locals21.gFgcaFDs6j.HorizontalFaceImpact;
		xEXqldFbA.ClubShotDataArray[9] = CS_0024_003C_003E8__locals21.gFgcaFDs6j.VerticalFaceImpact;
		UnityMainThreadDispatcher.Instance().Enqueue(delegate
		{
			try
			{
				PlayerRunTimeData obj = CS_0024_003C_003E8__locals21.hikciN8LSo.xEXqldFbA.mGC.player_a[CS_0024_003C_003E8__locals21.hikciN8LSo.xEXqldFbA.mGC.ActivePlayer];
				if (obj != null)
				{
					obj.hand = CS_0024_003C_003E8__locals21.gFgcaFDs6j.IsPlayerRightHand;
				}
				if ((Object)(object)CS_0024_003C_003E8__locals21.hikciN8LSo.xEXqldFbA.mGC.clubsel != (Object)null)
				{
					CS_0024_003C_003E8__locals21.hikciN8LSo.xEXqldFbA.mGC.clubsel.handIsRight = CS_0024_003C_003E8__locals21.gFgcaFDs6j.IsPlayerRightHand;
					CS_0024_003C_003E8__locals21.hikciN8LSo.xEXqldFbA.mGC.clubsel.handTxt.text = (CS_0024_003C_003E8__locals21.gFgcaFDs6j.IsPlayerRightHand ? Dpdrn94xidrKkBCvWK.vZjKJCNxST(3690) : Dpdrn94xidrKkBCvWK.vZjKJCNxST(3682));
				}
				CS_0024_003C_003E8__locals21.hikciN8LSo.xEXqldFbA.CopyClubShotData();
			}
			catch (Exception arg)
			{
				l6UB92DOY.LogError((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(4260), arg));
			}
		});
	}

	private async void g3mH6QVDx()
	{
		await cn30UuvSh().vI1ABmETr();
		Logger.Sources.Remove((ILogSource)(object)l6UB92DOY);
		sJ9hssTCYj7GDPnrdy sJ9hssTCYj7GDPnrdy = cn30UuvSh();
		sJ9hssTCYj7GDPnrdy.yaH8e2TOS((Action<BallDataDto>)Delegate.Remove(sJ9hssTCYj7GDPnrdy.tDKVuJCjx(), new Action<BallDataDto>(oLLsaCxQq)));
		sJ9hssTCYj7GDPnrdy sJ9hssTCYj7GDPnrdy2 = cn30UuvSh();
		sJ9hssTCYj7GDPnrdy2.gTowtcIv4c((Action<ClubDataDto>)Delegate.Remove(sJ9hssTCYj7GDPnrdy2.fM0zAP3Se(), new Action<ClubDataDto>(LLqWw9H26)));
		if (nh9EWTXqh() != null)
		{
			nh9EWTXqh().Dispose();
			SwingPlateDrService swingPlateDrService = nh9EWTXqh();
			swingPlateDrService.DataReceived = (Action<string>)Delegate.Remove(swingPlateDrService.DataReceived, (Action<string>)delegate(string data)
			{
				_003C_003Ec__DisplayClass46_0 _003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_0();
				_003C_003Ec__DisplayClass46_.eXlcAKwFfR = data;
				UnityMainThreadDispatcher.Instance().Enqueue(_003C_003Ec__DisplayClass46_.J3fc3VPEnF);
			});
		}
		((BaseUnityPlugin)this).Logger.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(4342));
	}

	public static float Feet2millimeter(float ft)
	{
		return ft * 304.8f;
	}

	public static float Inch2millimeter(float inch)
	{
		return inch * 25.4f;
	}

	public GolfInPlugin()
	{
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		huqoi54HK = new sJ9hssTCYj7GDPnrdy();
		((BaseUnityPlugin)this)._002Ector();
	}

	static GolfInPlugin()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		l6UB92DOY = new ManualLogSource(Dpdrn94xidrKkBCvWK.vZjKJCNxST(1034));
		wnuY37fNR = new Harmony(Dpdrn94xidrKkBCvWK.vZjKJCNxST(1034));
	}
}
