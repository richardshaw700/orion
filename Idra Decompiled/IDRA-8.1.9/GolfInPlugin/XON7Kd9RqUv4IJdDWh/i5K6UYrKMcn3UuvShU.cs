using System;
using GolfInPlugin;
using HarmonyLib;
using IDRASharedModels;
using sX02IJN7NqxvB7iKPK;
using zLGfTg8qMbPmqnv69o;

namespace XON7Kd9RqUv4IJdDWh;

[HarmonyPatch(typeof(DataPanels))]
internal class i5K6UYrKMcn3UuvShU
{
	[HarmonyPostfix]
	[HarmonyPatch("updateLateData")]
	public static void hKkwvBCvWK(DataPanels P_0)
	{
		try
		{
			global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(1746));
			float carryGame = P_0.imperialData[0];
			float carryRaw = P_0.imperialData[1];
			float totalLength = P_0.imperialData[3];
			float peakHeight = P_0.imperialData[4];
			float offLine = P_0.imperialData[5];
			float decentAngle = P_0.imperialData[7];
			float distanceToPinYrds = P_0.imperialData[15];
			global::GolfInPlugin.GolfInPlugin.Instance.cn30UuvSh().Mb9Xa82QP(new GSProComputeData
			{
				CarryRaw = carryRaw,
				PeakHeight = peakHeight,
				OffLine = offLine,
				CarryGame = carryGame,
				TotalLength = totalLength,
				DecentAngle = decentAngle,
				DistanceToPinYrds = distanceToPinYrds
			}).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (Exception ex)
		{
			global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(1818) + ex.Message));
		}
	}

	public i5K6UYrKMcn3UuvShU()
	{
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		base._002Ector();
	}
}
