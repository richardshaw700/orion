using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Timers;
using GICTS.Data;
using GIToolkit.Services;
using IDRASharedModels;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;

namespace GICTSCore.Services;

public abstract class CommunicationIDRALocalAPI : ICommunicationIDRALocalAPI, IService, IDisposable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass86_0
	{
		public string wWUMi3B4Tc;

		public _003C_003Ec__DisplayClass86_0()
		{
			fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
			base._002Ector();
		}

		internal bool SafMl8lBWU(Process x)
		{
			return x.ProcessName == wWUMi3B4Tc;
		}
	}

	[CompilerGenerated]
	private ClubTypeEnum qLfHVS9sV6;

	[CompilerGenerated]
	private string hdSHvKVbZf;

	[CompilerGenerated]
	private PlayerHandednessNatureEnum bAgHHOmSiA;

	[CompilerGenerated]
	private GICTSMessage.InfoSubClassEnum bfsHDWZrmn;

	[CompilerGenerated]
	private readonly bool S0hHTsIBZA;

	[CompilerGenerated]
	private Action<SimCommandShotCompletedMsg> E9bHCh1RxP;

	[CompilerGenerated]
	private Action<DateTime> d9yHM24CgZ;

	[CompilerGenerated]
	private Action<string> fwOHKVTvvB;

	[CompilerGenerated]
	private Action<string> A84HpCRMGd;

	[CompilerGenerated]
	private Action<PlayerHandednessNatureEnum, ClubTypeEnum, string> y74H7K8uWy;

	[CompilerGenerated]
	private Action<SimCommandEnvironmentDataModifiedMsg> suJH8lXiCh;

	[CompilerGenerated]
	private Action<GICTSMessage.InfoClassEnum, ClubTypeEnum> U1vHurlvVq;

	[CompilerGenerated]
	private Action tsCHYIRKfv;

	[CompilerGenerated]
	private Action<string> PRwHbVWUIO;

	[CompilerGenerated]
	private Action<bool> JhQHfruGY5;

	[CompilerGenerated]
	private Action<bool> UABHISVplD;

	[CompilerGenerated]
	private Action<bool> O6nHOCUEYu;

	[CompilerGenerated]
	private Action<bool> Lw2HaNqVvq;

	[CompilerGenerated]
	private readonly ILocalAPIGameSettings rDEHZqrvP4;

	private Timer FnEHUMyasd;

	protected DateTime lastPingPong;

	private bool? BsfHB31MS0;

	public virtual ClubTypeEnum CurrentClubType
	{
		[CompilerGenerated]
		get
		{
			return qLfHVS9sV6;
		}
		[CompilerGenerated]
		protected set
		{
			qLfHVS9sV6 = value;
		}
	}

	public virtual string CurrentPlayerName
	{
		[CompilerGenerated]
		get
		{
			return hdSHvKVbZf;
		}
		[CompilerGenerated]
		protected set
		{
			hdSHvKVbZf = value;
		}
	}

	public virtual PlayerHandednessNatureEnum CurrentPlayerHandedness
	{
		[CompilerGenerated]
		get
		{
			return bAgHHOmSiA;
		}
		[CompilerGenerated]
		protected set
		{
			bAgHHOmSiA = value;
		}
	}

	public virtual GICTSMessage.InfoSubClassEnum LastCommand
	{
		[CompilerGenerated]
		get
		{
			return bfsHDWZrmn;
		}
		[CompilerGenerated]
		protected set
		{
			bfsHDWZrmn = value;
		}
	}

	public virtual bool IsConnected
	{
		[CompilerGenerated]
		get
		{
			return S0hHTsIBZA;
		}
	}

	public virtual Action<SimCommandShotCompletedMsg> OnShotCompleted
	{
		[CompilerGenerated]
		get
		{
			return E9bHCh1RxP;
		}
		[CompilerGenerated]
		set
		{
			E9bHCh1RxP = value;
		}
	}

	public virtual Action<DateTime> OnPing
	{
		[CompilerGenerated]
		get
		{
			return d9yHM24CgZ;
		}
		[CompilerGenerated]
		set
		{
			d9yHM24CgZ = value;
		}
	}

	public virtual Action<string> OnArmed
	{
		[CompilerGenerated]
		get
		{
			return fwOHKVTvvB;
		}
		[CompilerGenerated]
		set
		{
			fwOHKVTvvB = value;
		}
	}

	public virtual Action<string> OnDisarmed
	{
		[CompilerGenerated]
		get
		{
			return A84HpCRMGd;
		}
		[CompilerGenerated]
		set
		{
			A84HpCRMGd = value;
		}
	}

	public virtual Action<PlayerHandednessNatureEnum, ClubTypeEnum, string> OnPlayerDataModified
	{
		[CompilerGenerated]
		get
		{
			return y74H7K8uWy;
		}
		[CompilerGenerated]
		set
		{
			y74H7K8uWy = value;
		}
	}

	public virtual Action<SimCommandEnvironmentDataModifiedMsg> OnEnvironmentDataModified
	{
		[CompilerGenerated]
		get
		{
			return suJH8lXiCh;
		}
		[CompilerGenerated]
		set
		{
			suJH8lXiCh = value;
		}
	}

	public virtual Action<GICTSMessage.InfoClassEnum, ClubTypeEnum> OnSetClubType
	{
		[CompilerGenerated]
		get
		{
			return U1vHurlvVq;
		}
		[CompilerGenerated]
		set
		{
			U1vHurlvVq = value;
		}
	}

	public virtual Action OnTrackingStatusData
	{
		[CompilerGenerated]
		get
		{
			return tsCHYIRKfv;
		}
		[CompilerGenerated]
		set
		{
			tsCHYIRKfv = value;
		}
	}

	public virtual Action<string> OnNewTextMessage
	{
		[CompilerGenerated]
		get
		{
			return PRwHbVWUIO;
		}
		[CompilerGenerated]
		set
		{
			PRwHbVWUIO = value;
		}
	}

	public virtual Action<bool> OnClientConnected
	{
		[CompilerGenerated]
		get
		{
			return JhQHfruGY5;
		}
		[CompilerGenerated]
		set
		{
			JhQHfruGY5 = value;
		}
	}

	public virtual Action<bool> OnClientDisconnected
	{
		[CompilerGenerated]
		get
		{
			return UABHISVplD;
		}
		[CompilerGenerated]
		set
		{
			UABHISVplD = value;
		}
	}

	public virtual Action<bool> OnAuthenticated
	{
		[CompilerGenerated]
		get
		{
			return O6nHOCUEYu;
		}
		[CompilerGenerated]
		set
		{
			O6nHOCUEYu = value;
		}
	}

	public virtual Action<bool> OnGameProcessReady
	{
		[CompilerGenerated]
		get
		{
			return Lw2HaNqVvq;
		}
		[CompilerGenerated]
		set
		{
			Lw2HaNqVvq = value;
		}
	}

	public virtual ILocalAPIGameSettings LocalAPIGameSettings
	{
		[CompilerGenerated]
		get
		{
			return rDEHZqrvP4;
		}
	}

	public CommunicationIDRALocalAPI()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		hdSHvKVbZf = "";
		bAgHHOmSiA = PlayerHandednessNatureEnum.Right;
		lastPingPong = DateTime.Now;
		base._002Ector();
		FnEHUMyasd = new Timer
		{
			AutoReset = false,
			Enabled = true
		};
		FnEHUMyasd.Elapsed += XQMHSpb1t8;
		FnEHUMyasd.Interval = TimeSpan.FromSeconds(10.0).TotalMilliseconds;
	}

	private void XQMHSpb1t8(object P_0, ElapsedEventArgs P_1)
	{
		try
		{
			(P_0 as Timer).Enabled = false;
			if (string.IsNullOrWhiteSpace(LocalAPIGameSettings.ProcessName))
			{
				OnNewTextMessage?.Invoke(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12256));
			}
			else if (IsAvailableForConnection(LocalAPIGameSettings.ProcessName))
			{
				if ((!BsfHB31MS0) ?? true)
				{
					OnGameProcessReady?.Invoke(obj: true);
				}
				BsfHB31MS0 = true;
				if (!IsConnected)
				{
					Connect();
				}
			}
			else if (BsfHB31MS0.HasValue)
			{
				BsfHB31MS0 = false;
			}
		}
		catch (Exception ex)
		{
			OnNewTextMessage?.Invoke(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12412) + ex.Message);
			EventViewerLogger.LogException(ex);
		}
		finally
		{
			(P_0 as Timer).Enabled = true;
		}
	}

	public virtual void Connect()
	{
	}

	public virtual void Disconnect()
	{
		FnEHUMyasd.Stop();
	}

	public virtual void RequestGameSettings()
	{
	}

	public virtual void GetPlayerDataMessage()
	{
	}

	public virtual void SendAnyMessage(string msg)
	{
	}

	public virtual void SendShot(CTSShotData shot)
	{
	}

	public virtual void SendMulliganLastShot()
	{
	}

	public bool IsAvailableForConnection(string processName)
	{
		_003C_003Ec__DisplayClass86_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass86_0();
		CS_0024_003C_003E8__locals2.wWUMi3B4Tc = processName;
		using Process process = Process.GetProcesses().ToList().FirstOrDefault((Process x) => x.ProcessName == CS_0024_003C_003E8__locals2.wWUMi3B4Tc);
		return process?.Responding ?? false;
	}

	public string PrettyJson(string unPrettyJson, ref JsonElement toJsonObj, bool logIntdented = true)
	{
		string result = "";
		try
		{
			JsonSerializerOptions options = new JsonSerializerOptions
			{
				WriteIndented = logIntdented
			};
			toJsonObj = JsonSerializer.Deserialize<JsonElement>(unPrettyJson);
			result = JsonSerializer.Serialize(toJsonObj, options);
		}
		catch (Exception ex)
		{
			OnNewTextMessage(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12468) + unPrettyJson + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12496) + ex.Message);
		}
		return result;
	}

	public virtual void GetEnvironmentDataMessage()
	{
	}

	public virtual void SendBoothDataMessage(BoothData msg)
	{
	}

	public virtual void SendBoothDataMessage(GspBoothData msg)
	{
	}

	public virtual void SendConfigDataMessage(ConfigData msg)
	{
	}

	public virtual void SendStatusMessage(TrackingStatusData msg)
	{
	}

	public virtual void SendUpdateShot(CTSShotData shot)
	{
	}

	public virtual void SetClubTypeMessage(SetClubTypeData msg)
	{
	}

	public virtual void SendBallOnTeeDisplacementLeft()
	{
	}

	public virtual void SendBallOnTeeDisplacementRight()
	{
	}

	public virtual void Dispose()
	{
	}
}
