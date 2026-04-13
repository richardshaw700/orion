using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class GameProcessService
{
	public static Process[] GetCurrentGamesOpen()
	{
		List<Process> list = new List<Process>();
		Process[] processesByName = Process.GetProcessesByName(so95DAFNMfktfjp4Dm.An6v7kuCGg(8480));
		Process[] processesByName2 = Process.GetProcessesByName(so95DAFNMfktfjp4Dm.An6v7kuCGg(8502));
		Process[] processesByName3 = Process.GetProcessesByName(so95DAFNMfktfjp4Dm.An6v7kuCGg(8518));
		Process[] processesByName4 = Process.GetProcessesByName(so95DAFNMfktfjp4Dm.An6v7kuCGg(8546));
		Process[] processesByName5 = Process.GetProcessesByName(so95DAFNMfktfjp4Dm.An6v7kuCGg(8588));
		list.AddRange(processesByName);
		list.AddRange(processesByName2);
		list.AddRange(processesByName3);
		list.AddRange(processesByName4);
		list.AddRange(processesByName5);
		return list.ToArray();
	}

	public static string GetCurrentGameName()
	{
		Process[] processesByName = Process.GetProcessesByName(so95DAFNMfktfjp4Dm.An6v7kuCGg(8480));
		Process[] processesByName2 = Process.GetProcessesByName(so95DAFNMfktfjp4Dm.An6v7kuCGg(8502));
		Process[] processesByName3 = Process.GetProcessesByName(so95DAFNMfktfjp4Dm.An6v7kuCGg(8518));
		Process[] processesByName4 = Process.GetProcessesByName(so95DAFNMfktfjp4Dm.An6v7kuCGg(8588));
		if (processesByName.Any())
		{
			return so95DAFNMfktfjp4Dm.An6v7kuCGg(8602);
		}
		if (processesByName4.Any())
		{
			return so95DAFNMfktfjp4Dm.An6v7kuCGg(8626);
		}
		if (processesByName2.Any())
		{
			return so95DAFNMfktfjp4Dm.An6v7kuCGg(8640);
		}
		if (processesByName3.Any())
		{
			Match match = new Regex(so95DAFNMfktfjp4Dm.An6v7kuCGg(8666), RegexOptions.IgnoreCase).Match(processesByName3[0]?.MainModule?.FileName);
			string result = so95DAFNMfktfjp4Dm.An6v7kuCGg(8704);
			if (match.Success && match.Groups.Count > 1)
			{
				result = match.Groups[1].Value;
			}
			return result;
		}
		return string.Empty;
	}

	public GameProcessService()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
