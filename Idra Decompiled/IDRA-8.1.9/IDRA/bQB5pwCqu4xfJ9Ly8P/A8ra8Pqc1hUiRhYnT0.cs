using System;
using System.Runtime.CompilerServices;
using GICTSCore.Data;
using GICTSCore.Services;
using GIToolkit.Services;
using GhU84wwqvI4UZ3pBfu;
using IDRA.Services;
using IDRASharedModels;
using sxB8TYTZ87aKuujytY;

namespace bQB5pwCqu4xfJ9Ly8P;

internal class A8ra8Pqc1hUiRhYnT0
{
	[CompilerGenerated]
	private ICircularLogService KY4aXSeyHR;

	private AutoTeeService eSQa94jUCI;

	private string kxhaLxPxYv;

	public Action<AutoTeeMoveSide> xT5aTL9PoE;

	public A8ra8Pqc1hUiRhYnT0(ICircularLogService P_0)
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		KY4aXSeyHR = P_0;
		kxhaLxPxYv = string.Empty;
		base._002Ector();
	}

	public void bQyaVRKmTe()
	{
		if (!ManagerSettings.Instance.UseAutoTee)
		{
			KY4aXSeyHR.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(7542));
			return;
		}
		eSQa94jUCI = new AutoTeeService(ManagerSettings.Instance.AutoTeeComPortNumber);
		eSQa94jUCI.DataReceived = wigaGZFO05;
		if (!eSQa94jUCI.TryOpenPort())
		{
			KY4aXSeyHR.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(7724));
		}
		else
		{
			KY4aXSeyHR.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(7800));
		}
	}

	public void wigaGZFO05(string P_0)
	{
		kxhaLxPxYv += P_0;
		if (kxhaLxPxYv.Length > 256)
		{
			kxhaLxPxYv = kxhaLxPxYv.Substring(checked(kxhaLxPxYv.Length - 256));
		}
		while (kxhaLxPxYv.Length >= 2)
		{
			string text = kxhaLxPxYv.Substring(0, 2);
			if (!(text == QQXBLjLprwI58ya4VR.y8v8TMFOCb(7854)))
			{
				if (!(text == QQXBLjLprwI58ya4VR.y8v8TMFOCb(7862)))
				{
					if (!(text == QQXBLjLprwI58ya4VR.y8v8TMFOCb(7870)))
					{
						kxhaLxPxYv = kxhaLxPxYv.Substring(1);
						continue;
					}
					KY4aXSeyHR.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(8044));
					xT5aTL9PoE?.Invoke(AutoTeeMoveSide.Right);
				}
				else
				{
					KY4aXSeyHR.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(7942));
					xT5aTL9PoE?.Invoke(AutoTeeMoveSide.Left);
				}
			}
			else
			{
				KY4aXSeyHR.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(7878));
				AutomaticUserInput.SendKey(IDRAConstant.GSProProcessName, 77u, maintain_ctrl: true);
			}
			kxhaLxPxYv = kxhaLxPxYv.Substring(2);
		}
	}
}
