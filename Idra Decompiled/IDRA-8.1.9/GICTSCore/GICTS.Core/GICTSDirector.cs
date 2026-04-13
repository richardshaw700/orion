using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GICTS.Data;
using GICTSCore.Data;
using GICTSCore.Services;
using GICTSCore.Services.LocalAPI;
using GIToolkit.Helpers;
using GIToolkit.Services;
using GSProClient;
using IDRASharedModels;
using JdN3qlxpK1fXeWoSKd;
using Newtonsoft.Json;
using PNUjqgod2XBUUTKRSy;
using lKEAGvFqWp7B16kDoY;

namespace GICTS.Core;

public class GICTSDirector : CameraCallback, IGICTSDirector, IService
{
	private enum q02STxSWGDvVqGYBLH
	{

	}

	[CompilerGenerated]
	private Func<int, Task> suMn8N3tVa;

	[CompilerGenerated]
	private Func<int, string, bool, Task> sNinusGKeR;

	[CompilerGenerated]
	private Func<CTSShotData, Task> G7rnYLDIEE;

	[CompilerGenerated]
	private Func<string, int, Task> QZ3nbclXPw;

	[CompilerGenerated]
	private Func<Task> EF4nfSQJuJ;

	[CompilerGenerated]
	private Func<string, Task> MFSnIeDGE2;

	[CompilerGenerated]
	private Func<GSProComputeData, Task> AIOnOMtuyU;

	[CompilerGenerated]
	private Action<bool> cUjnabJ91n;

	[CompilerGenerated]
	private Action<bool> kpqnZwXOAj;

	[CompilerGenerated]
	private Func<SimCommandShotCompletedMsg, Task> qV2nUiQQLN;

	[CompilerGenerated]
	private Action<bool> lZCnBOCOdW;

	[CompilerGenerated]
	private Action I1MnhdI8oP;

	[CompilerGenerated]
	private Action<bool> Ifynt9JabE;

	[CompilerGenerated]
	private Action SJUnrn5b7M;

	[CompilerGenerated]
	private Action Y3JnyVSgjL;

	private string bvgn9mWAZE;

	private PlayerHandednessNatureEnum OkwnAqWG3R;

	private LightInterface cXEnjuqwOq;

	private nrmItuhBbXIG6jxvoO GIhn6OsBuM;

	private List<nrmItuhBbXIG6jxvoO> Qd7n10S6EB;

	[CompilerGenerated]
	private IdraDataOutGame? D3tnkqr4OE;

	[CompilerGenerated]
	private GICTSSettings GFundsLnEm;

	[CompilerGenerated]
	private GICTSSettings YBCnNrWj5C;

	[CompilerGenerated]
	private bool O9Jn5ifigL;

	[CompilerGenerated]
	private bool Hlsncsqu43;

	[CompilerGenerated]
	private bool flLnWq83Zr;

	[CompilerGenerated]
	private double T45nJ2MkH0;

	[CompilerGenerated]
	private SimCommandEnvironmentDataModifiedMsg LOTn4uvEw1;

	[CompilerGenerated]
	private CTSShotData mLVn3uIjr6;

	[CompilerGenerated]
	private DateTime OynnlnX6O7;

	[CompilerGenerated]
	private ClubTypeEnum Cm7niYcjUS;

	[CompilerGenerated]
	private string bb1nQusI4U;

	private q02STxSWGDvVqGYBLH JC4nPIfLpW;

	private bool s1dnGTvBid;

	private bool Uo0nqLtsJC;

	private readonly ICircularLogService O9xnmQaZBJ;

	private readonly ICircularLogService k6On2yqTS7;

	private readonly IDataSpinService gsJnFH17UD;

	private readonly ICommunicationIDRALocalAPI woCnxOBZen;

	private readonly ISpaceCleanUpService kdUnEFq6qj;

	private readonly IGICTSSettingsWrapper wMGnoqajvY;

	private readonly IIdraModeService zK1nXLdVSd;

	private readonly IXmlHelper TLsnexHrM5;

	private readonly IProcessHelper I9Sn09o2Bp;

	public Func<int, Task> IdraHasExited
	{
		[CompilerGenerated]
		get
		{
			return suMn8N3tVa;
		}
		[CompilerGenerated]
		set
		{
			suMn8N3tVa = value;
		}
	}

	public Func<int, string, bool, Task> OnCamErrorCode
	{
		[CompilerGenerated]
		get
		{
			return sNinusGKeR;
		}
		[CompilerGenerated]
		set
		{
			sNinusGKeR = value;
		}
	}

	public Func<CTSShotData, Task> OnNewShotSent
	{
		[CompilerGenerated]
		get
		{
			return G7rnYLDIEE;
		}
		[CompilerGenerated]
		set
		{
			G7rnYLDIEE = value;
		}
	}

	public Func<string, int, Task> OnPostShotVideoExported
	{
		[CompilerGenerated]
		get
		{
			return QZ3nbclXPw;
		}
		[CompilerGenerated]
		set
		{
			QZ3nbclXPw = value;
		}
	}

	public Func<Task> OnVideoExported
	{
		[CompilerGenerated]
		get
		{
			return EF4nfSQJuJ;
		}
		[CompilerGenerated]
		set
		{
			EF4nfSQJuJ = value;
		}
	}

	public Func<string, Task> OnFirstTee
	{
		[CompilerGenerated]
		get
		{
			return MFSnIeDGE2;
		}
		[CompilerGenerated]
		set
		{
			MFSnIeDGE2 = value;
		}
	}

	public Func<GSProComputeData, Task> OnGameComputeData
	{
		[CompilerGenerated]
		get
		{
			return AIOnOMtuyU;
		}
		[CompilerGenerated]
		set
		{
			AIOnOMtuyU = value;
		}
	}

	public Action<bool> OnGSProScorecardIsVisible
	{
		[CompilerGenerated]
		get
		{
			return cUjnabJ91n;
		}
		[CompilerGenerated]
		set
		{
			cUjnabJ91n = value;
		}
	}

	public Action<bool> OnGSPROOSKVisible
	{
		[CompilerGenerated]
		get
		{
			return kpqnZwXOAj;
		}
		[CompilerGenerated]
		set
		{
			kpqnZwXOAj = value;
		}
	}

	public Func<SimCommandShotCompletedMsg, Task> OnShotReceiveFromGame
	{
		[CompilerGenerated]
		get
		{
			return qV2nUiQQLN;
		}
		[CompilerGenerated]
		set
		{
			qV2nUiQQLN = value;
		}
	}

	public Action<bool> OnUIAvailableStatusChange
	{
		[CompilerGenerated]
		get
		{
			return lZCnBOCOdW;
		}
		[CompilerGenerated]
		set
		{
			lZCnBOCOdW = value;
		}
	}

	public Action OnGolfLocalAPIArmed
	{
		[CompilerGenerated]
		get
		{
			return I1MnhdI8oP;
		}
		[CompilerGenerated]
		set
		{
			I1MnhdI8oP = value;
		}
	}

	public Action<bool> IsReadyNotReadySignal
	{
		[CompilerGenerated]
		get
		{
			return Ifynt9JabE;
		}
		[CompilerGenerated]
		set
		{
			Ifynt9JabE = value;
		}
	}

	public Action OnRefreshIDRAConfiguration
	{
		[CompilerGenerated]
		get
		{
			return SJUnrn5b7M;
		}
		[CompilerGenerated]
		set
		{
			SJUnrn5b7M = value;
		}
	}

	public Action OnMissingCalibrationForConnectedIDRA
	{
		[CompilerGenerated]
		get
		{
			return Y3JnyVSgjL;
		}
		[CompilerGenerated]
		set
		{
			Y3JnyVSgjL = value;
		}
	}

	public IdraDataOutGame? IdraDataOutGame
	{
		[CompilerGenerated]
		get
		{
			return D3tnkqr4OE;
		}
		[CompilerGenerated]
		set
		{
			D3tnkqr4OE = value;
		}
	}

	public GICTSSettings Settings
	{
		[CompilerGenerated]
		get
		{
			return GFundsLnEm;
		}
		[CompilerGenerated]
		set
		{
			GFundsLnEm = value;
		}
	}

	public GICTSSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return YBCnNrWj5C;
		}
		[CompilerGenerated]
		set
		{
			YBCnNrWj5C = value;
		}
	}

	public bool IsCamerasRunning
	{
		[CompilerGenerated]
		get
		{
			return O9Jn5ifigL;
		}
		[CompilerGenerated]
		set
		{
			O9Jn5ifigL = value;
		}
	}

	public SimCommandEnvironmentDataModifiedMsg LastEnvironmentData
	{
		[CompilerGenerated]
		get
		{
			return LOTn4uvEw1;
		}
		[CompilerGenerated]
		private set
		{
			LOTn4uvEw1 = value;
		}
	}

	public CTSShotData LastShotSent
	{
		[CompilerGenerated]
		get
		{
			return mLVn3uIjr6;
		}
		[CompilerGenerated]
		set
		{
			mLVn3uIjr6 = value;
		}
	}

	public DateTime LastShotDateStamp
	{
		[CompilerGenerated]
		get
		{
			return OynnlnX6O7;
		}
		[CompilerGenerated]
		set
		{
			OynnlnX6O7 = value;
		}
	}

	public ClubTypeEnum CurrentClubType
	{
		[CompilerGenerated]
		get
		{
			return Cm7niYcjUS;
		}
		[CompilerGenerated]
		private set
		{
			Cm7niYcjUS = value;
		}
	}

	public string CurrentPlayerName
	{
		[CompilerGenerated]
		get
		{
			return bb1nQusI4U;
		}
		[CompilerGenerated]
		private set
		{
			bb1nQusI4U = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private bool UjHnsvu2nN()
	{
		return Hlsncsqu43;
	}

	[SpecialName]
	[CompilerGenerated]
	private void sgcngAEv55(bool value)
	{
		Hlsncsqu43 = value;
	}

	[SpecialName]
	[CompilerGenerated]
	private bool ILMnnSAVPC()
	{
		return flLnWq83Zr;
	}

	[SpecialName]
	[CompilerGenerated]
	private void ThvnSHRJIb(bool value)
	{
		flLnWq83Zr = value;
	}

	[SpecialName]
	[CompilerGenerated]
	private double HBOnvn1oZs()
	{
		return T45nJ2MkH0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void KlonHghO7Z(double value)
	{
		T45nJ2MkH0 = value;
	}

	[SpecialName]
	private q02STxSWGDvVqGYBLH yXinKySZXV()
	{
		return JC4nPIfLpW;
	}

	[SpecialName]
	private void PKVnpC3Cgd(q02STxSWGDvVqGYBLH value)
	{
		ICircularLogService circularLogService = k6On2yqTS7;
		if (circularLogService != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 2);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(824));
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(878));
			defaultInterpolatedStringHandler.AppendFormatted(JC4nPIfLpW);
			circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		JC4nPIfLpW = value;
	}

	public GICTSDirector(IDataSpinService dataSpinService, ISpaceCleanUpService spaceCleanUpService, IGICTSSettingsWrapper gICTSSettingsWrapper, ITcpGSProClient gsproClient, IProcessHelper processHelper, IIdraModeService idraModeService)
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		OkwnAqWG3R = PlayerHandednessNatureEnum.Right;
		Hlsncsqu43 = true;
		flLnWq83Zr = true;
		Cm7niYcjUS = ClubTypeEnum.Unknow;
		bb1nQusI4U = "";
		base._002Ector();
		O9xnmQaZBJ = new CircularLogService();
		O9xnmQaZBJ.SetupLogFile(IDRAConstant.GICTSCamLogCamerasDirectoryPath, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(900), useTraceLoggingMethod: false, 30, 1048576L);
		O9xnmQaZBJ.SetLogLevel(LogLevel.Debug);
		k6On2yqTS7 = new CircularLogService();
		k6On2yqTS7.SetupLogFile(IDRAConstant.ApiCommLogDirectoryPath, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(928), useTraceLoggingMethod: false, 30, 1048576L);
		k6On2yqTS7.SetLogLevel(LogLevel.Debug);
		gsJnFH17UD = dataSpinService;
		kdUnEFq6qj = spaceCleanUpService;
		wMGnoqajvY = gICTSSettingsWrapper;
		zK1nXLdVSd = idraModeService;
		TLsnexHrM5 = new XmlHelper(k6On2yqTS7);
		wMGnoqajvY.SetLogger(k6On2yqTS7);
		I9Sn09o2Bp = processHelper;
		Directory.CreateDirectory(IDRAConstant.GICTSDataFolder);
		Qd7n10S6EB = new List<nrmItuhBbXIG6jxvoO>();
		Task.Run(async delegate
		{
			DefaultSettings = await wMGnoqajvY.LoadSettings(IDRAConstant.GICTSDefaultSettingsFilePath);
			Settings = await wMGnoqajvY.LoadSettings(IDRAConstant.GICTSSettingsFilePath);
			f1FLyPIF7N();
			if (!GIToolkit.Services.JsonPropertyComparer.IsJsonPropSameAsSavedFile(DefaultSettings, IDRAConstant.GICTSDefaultSettingsFilePath))
			{
				await wMGnoqajvY.SaveSettings(DefaultSettings, IDRAConstant.GICTSDefaultSettingsFilePath);
			}
			if (!GIToolkit.Services.JsonPropertyComparer.IsJsonPropSameAsSavedFile(Settings, IDRAConstant.GICTSSettingsFilePath))
			{
				await wMGnoqajvY.SaveSettings(Settings, IDRAConstant.GICTSSettingsFilePath);
			}
			await TryOverwriteSpinSettings();
			await wMGnoqajvY.MonitorSettings(IDRAConstant.GICTSSettingsFilePath);
			IGICTSSettingsWrapper iGICTSSettingsWrapper = wMGnoqajvY;
			iGICTSSettingsWrapper.OnSettingsModified = (Action<GICTSSettings, FileInfo>)Delegate.Combine(iGICTSSettingsWrapper.OnSettingsModified, new Action<GICTSSettings, FileInfo>(OnReloadSettings));
		}).Wait();
		bvgn9mWAZE = IDRAConstant.IdraConfigurationFilePath();
		ICommunicationIDRALocalAPI communicationIDRALocalAPI2;
		if (!Settings.UseGSPro || Settings.UseE6Connect)
		{
			ICommunicationIDRALocalAPI communicationIDRALocalAPI = new TruSimE6APIService();
			communicationIDRALocalAPI2 = communicationIDRALocalAPI;
		}
		else
		{
			ICommunicationIDRALocalAPI communicationIDRALocalAPI = new GSProAPIService(gsproClient, processHelper);
			communicationIDRALocalAPI2 = communicationIDRALocalAPI;
		}
		woCnxOBZen = communicationIDRALocalAPI2;
	}

	private void f1FLyPIF7N()
	{
		DefaultSettings.ClubSettings.ClubFaceAngleOffsetAdjustmentIron = 1.0;
		DefaultSettings.ClubSettings.ClubFaceAngleOffsetAdjustmentWood = 0.0;
		Settings.ClubSettings.ClubFaceAngleOffsetAdjustmentIron = 1.0;
		Settings.ClubSettings.ClubFaceAngleOffsetAdjustmentWood = 0.0;
	}

	public LightInterface GetSafelyLightInterface()
	{
		if (cXEnjuqwOq != null && !Uo0nqLtsJC)
		{
			return cXEnjuqwOq;
		}
		return null;
	}

	public async Task<int> Launch()
	{
		InitLocalAPI();
		using (cXEnjuqwOq = new LightInterface())
		{
			cXEnjuqwOq.LOG_FILENAME = IDRAConstant.GICTSDataFolder + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12190) + IDRAConstant.CamerasLogFilename;
			cXEnjuqwOq.setCameraCallback(this);
			cXEnjuqwOq.StartAutoShotMode = Settings.StartAutoShotMode;
			RunningModeEnum camerasStartRunningMode = (RunningModeEnum)Settings.CamerasStartRunningMode;
			cXEnjuqwOq.ChangeRunningMode(camerasStartRunningMode);
			try
			{
				await TLsnexHrM5.LoadXmlDocument(bvgn9mWAZE);
				IsCamerasRunning = TLsnexHrM5.ReadNodeValue<bool>(IDRAConstant.UseCameraXPath);
			}
			catch (Exception ex) when (((ex is FileNotFoundException || ex is FileLoadException) ? 1 : 0) != 0)
			{
				k6On2yqTS7.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(19370) + ex.Message + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(19414), LogLevel.Warning);
				IsCamerasRunning = true;
			}
			cXEnjuqwOq.main();
			Uo0nqLtsJC = true;
			IsCamerasRunning = false;
			cXEnjuqwOq.resetCameraCallback();
			k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(19502));
		}
		return 0;
	}

	public ICommunicationIDRALocalAPI GetApiGameLaunched()
	{
		if (woCnxOBZen == null)
		{
			throw new Exception(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(970));
		}
		return woCnxOBZen;
	}

	public void InitLocalAPI()
	{
		if (s1dnGTvBid)
		{
			return;
		}
		ICommunicationIDRALocalAPI communicationIDRALocalAPI = woCnxOBZen;
		communicationIDRALocalAPI.OnNewTextMessage = (Action<string>)Delegate.Combine(communicationIDRALocalAPI.OnNewTextMessage, new Action<string>(OnNewTextMessageFromLocalGame));
		ICommunicationIDRALocalAPI communicationIDRALocalAPI2 = woCnxOBZen;
		communicationIDRALocalAPI2.OnArmed = (Action<string>)Delegate.Combine(communicationIDRALocalAPI2.OnArmed, new Action<string>(xTqL9NkOb9));
		ICommunicationIDRALocalAPI communicationIDRALocalAPI3 = woCnxOBZen;
		communicationIDRALocalAPI3.OnDisarmed = (Action<string>)Delegate.Combine(communicationIDRALocalAPI3.OnDisarmed, new Action<string>(prJLA29GtS));
		ICommunicationIDRALocalAPI communicationIDRALocalAPI4 = woCnxOBZen;
		communicationIDRALocalAPI4.OnShotCompleted = (Action<SimCommandShotCompletedMsg>)Delegate.Combine(communicationIDRALocalAPI4.OnShotCompleted, new Action<SimCommandShotCompletedMsg>(g75Lj3IfVB));
		ICommunicationIDRALocalAPI communicationIDRALocalAPI5 = woCnxOBZen;
		communicationIDRALocalAPI5.OnEnvironmentDataModified = (Action<SimCommandEnvironmentDataModifiedMsg>)Delegate.Combine(communicationIDRALocalAPI5.OnEnvironmentDataModified, (Action<SimCommandEnvironmentDataModifiedMsg>)delegate(SimCommandEnvironmentDataModifiedMsg P_0)
		{
			LastEnvironmentData = P_0;
		});
		ICommunicationIDRALocalAPI communicationIDRALocalAPI6 = woCnxOBZen;
		communicationIDRALocalAPI6.OnPlayerDataModified = (Action<PlayerHandednessNatureEnum, ClubTypeEnum, string>)Delegate.Combine(communicationIDRALocalAPI6.OnPlayerDataModified, (Action<PlayerHandednessNatureEnum, ClubTypeEnum, string>)delegate(PlayerHandednessNatureEnum P_0, ClubTypeEnum P_1, string P_2)
		{
			OkwnAqWG3R = P_0;
			CurrentClubType = P_1;
			CurrentPlayerName = P_2;
		});
		ICommunicationIDRALocalAPI communicationIDRALocalAPI7 = woCnxOBZen;
		communicationIDRALocalAPI7.OnSetClubType = (Action<GICTSMessage.InfoClassEnum, ClubTypeEnum>)Delegate.Combine(communicationIDRALocalAPI7.OnSetClubType, new Action<GICTSMessage.InfoClassEnum, ClubTypeEnum>(OnSetClubTypeMessageReceive));
		ICommunicationIDRALocalAPI communicationIDRALocalAPI8 = woCnxOBZen;
		communicationIDRALocalAPI8.OnClientConnected = (Action<bool>)Delegate.Combine(communicationIDRALocalAPI8.OnClientConnected, new Action<bool>(g2PLkPt3s0));
		ICommunicationIDRALocalAPI communicationIDRALocalAPI9 = woCnxOBZen;
		communicationIDRALocalAPI9.OnClientDisconnected = (Action<bool>)Delegate.Combine(communicationIDRALocalAPI9.OnClientDisconnected, new Action<bool>(MvlL1d3FMy));
		ICommunicationIDRALocalAPI communicationIDRALocalAPI10 = woCnxOBZen;
		communicationIDRALocalAPI10.OnAuthenticated = (Action<bool>)Delegate.Combine(communicationIDRALocalAPI10.OnAuthenticated, new Action<bool>(OnReady));
		ICommunicationIDRALocalAPI communicationIDRALocalAPI11 = woCnxOBZen;
		communicationIDRALocalAPI11.OnGameProcessReady = (Action<bool>)Delegate.Combine(communicationIDRALocalAPI11.OnGameProcessReady, new Action<bool>(MDjL6H8dQg));
		if (woCnxOBZen is GSProAPIService)
		{
			GSProAPIService obj = woCnxOBZen as GSProAPIService;
			obj.OnGameComputeData = (Action<GSProComputeData>)Delegate.Combine(obj.OnGameComputeData, (Action<GSProComputeData>)async delegate(GSProComputeData P_0)
			{
				if (OnGameComputeData != null)
				{
					await OnGameComputeData(P_0);
				}
			});
			GSProAPIService obj2 = woCnxOBZen as GSProAPIService;
			obj2.OnFirstTeeCall = (Action<string>)Delegate.Combine(obj2.OnFirstTeeCall, (Action<string>)async delegate(string P_0)
			{
				if (OnFirstTee != null)
				{
					await OnFirstTee(P_0);
				}
			});
			GSProAPIService obj3 = woCnxOBZen as GSProAPIService;
			obj3.OnScoreCardIsVisible = (Action<bool>)Delegate.Combine(obj3.OnScoreCardIsVisible, (Action<bool>)delegate(bool P_0)
			{
				OnGSProScorecardIsVisible?.Invoke(P_0);
			});
			GSProAPIService obj4 = woCnxOBZen as GSProAPIService;
			obj4.OnOSKIsVisible = (Action<bool>)Delegate.Combine(obj4.OnOSKIsVisible, (Action<bool>)delegate(bool P_0)
			{
				OnGSPROOSKVisible?.Invoke(P_0);
			});
		}
		woCnxOBZen.Connect();
		s1dnGTvBid = true;
	}

	public void SendShot(CTSShotData shot)
	{
		if (shot.Ball.BallSpeed > Settings.E6LimitsSettings.LimitBallSpeedLinkedBackSpin && shot.Ball.BackSpin > Settings.E6LimitsSettings.LimitBackSpinLinkedBallSpeed)
		{
			ICircularLogService circularLogService = k6On2yqTS7;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(78, 2);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1022));
			defaultInterpolatedStringHandler.AppendFormatted(Settings.E6LimitsSettings.LimitBallSpeedLinkedBackSpin);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1154));
			defaultInterpolatedStringHandler.AppendFormatted(Settings.E6LimitsSettings.LimitBackSpinLinkedBallSpeed);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1176));
			circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear(), LogLevel.Error);
		}
		else
		{
			LastShotSent = shot;
			LastShotDateStamp = DateTime.Now;
			k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1190), shot);
			k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1214) + ((yXinKySZXV() == (q02STxSWGDvVqGYBLH)2) ? YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1256) : YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1248)));
			if (yXinKySZXV() == (q02STxSWGDvVqGYBLH)2)
			{
				woCnxOBZen.SendShot(shot);
			}
			k6On2yqTS7?.Log(new string('*', 70) + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1266) + new string('*', 70));
		}
	}

	public void PauseCameraAcquisition()
	{
		GetSafelyLightInterface()?.PauseCameraAcquisition();
	}

	public void ResumeCameraAcquisition()
	{
		GetSafelyLightInterface()?.ResumeCameraAcquisition();
	}

	public void SendAutoTeeBallMovementLeft()
	{
		woCnxOBZen.SendBallOnTeeDisplacementLeft();
	}

	public void SendAutoTeeBallMovementRight()
	{
		woCnxOBZen.SendBallOnTeeDisplacementRight();
	}

	public void OnSetClubTypeMessageReceive(GICTSMessage.InfoClassEnum subClass, ClubTypeEnum club)
	{
		if (subClass == GICTSMessage.InfoClassEnum.ACK)
		{
			if (yXinKySZXV() != (q02STxSWGDvVqGYBLH)2)
			{
				xTqL9NkOb9();
			}
		}
		else if (yXinKySZXV() == (q02STxSWGDvVqGYBLH)2)
		{
			prJLA29GtS();
		}
	}

	public void SetTrackingStatus(TrackingStatusAction action, string option = "")
	{
		TrackingStatusData trackingStatusData = new TrackingStatusData();
		switch (action)
		{
		case TrackingStatusAction.OK:
			trackingStatusData.ShowStatus = true;
			trackingStatusData.StatusType = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1292);
			if (option != "")
			{
				trackingStatusData.BallCenterOfProjection = double.Parse(option, CultureInfo.InvariantCulture);
			}
			IsReadyNotReadySignal?.Invoke(obj: true);
			break;
		case TrackingStatusAction.NOTREADY:
			trackingStatusData.ShowStatus = true;
			trackingStatusData.StatusType = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1306);
			IsReadyNotReadySignal?.Invoke(obj: false);
			break;
		case TrackingStatusAction.MOVE:
			trackingStatusData.ShowStatus = true;
			trackingStatusData.StatusType = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1306);
			IsReadyNotReadySignal?.Invoke(obj: false);
			break;
		case TrackingStatusAction.ERROR:
			trackingStatusData.ShowStatus = true;
			trackingStatusData.StatusType = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1324);
			IsReadyNotReadySignal?.Invoke(obj: false);
			break;
		}
		woCnxOBZen.SendStatusMessage(trackingStatusData);
	}

	public static string GetEnumName(Enum value)
	{
		return (value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(EnumMemberAttribute), inherit: false)[0] as EnumMemberAttribute).Value;
	}

	public void SetDefaultClubType(string clubType)
	{
		string text = clubType.ToLower();
		if (!(text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1338)))
		{
			if (!(text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1350)))
			{
				if (text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1362))
				{
					clubType = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1406);
				}
			}
			else
			{
				clubType = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1392);
			}
		}
		else
		{
			clubType = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1378);
		}
		SetClubTypeData clubTypeMessage = new SetClubTypeData
		{
			ClubType = clubType
		};
		if (yXinKySZXV() == (q02STxSWGDvVqGYBLH)2)
		{
			woCnxOBZen.SetClubTypeMessage(clubTypeMessage);
		}
		k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1422) + clubType + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1462) + ((yXinKySZXV() == (q02STxSWGDvVqGYBLH)2) ? YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1256) : YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1248)));
	}

	public ConfigData GetConfigData(CTSShotData shot)
	{
		ConfigData configData = new ConfigData
		{
			PercentBackSpinIron = Settings.E6ConfigsSettings.DefaultPercentBackSpinIron,
			PercentBackSpinWood = Settings.E6ConfigsSettings.DefaultPercentBackSpinWood,
			OffsetClubFaceIron = Settings.E6ConfigsSettings.DefaultOffsetClubFaceIron,
			OffsetClubFaceWood = Settings.E6ConfigsSettings.DefaultOffsetClubFaceWood
		};
		if (shot == null)
		{
			k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1504), configData);
			woCnxOBZen.SendConfigDataMessage(configData);
			return configData;
		}
		Tuple<float, float> spinConfig = GetSpinConfig(shot.ClubNature, shot.Ball.BallSpeed, shot.Ball.LaunchAngle, shot.ClubBallHitPercent);
		switch (shot.GetClubNatureCategory())
		{
		case ClubNatureCategoryEnum.IRON:
			configData.PercentBackSpinIron = spinConfig.Item1;
			configData.OffsetClubFaceIron = spinConfig.Item2;
			break;
		case ClubNatureCategoryEnum.WOOD:
			configData.PercentBackSpinWood = spinConfig.Item1;
			configData.OffsetClubFaceWood = spinConfig.Item2;
			break;
		}
		return configData;
	}

	public Tuple<float, float> GetSpinConfig(ClubNatureEnum club, double ballSpeed, double launchAngle, float clubBallHitPercent)
	{
		float num = 0f;
		float num2 = 0f;
		ClubNatureCategoryEnum clubNatureCategory = CTSShotData.GetClubNatureCategory(club);
		switch (clubNatureCategory)
		{
		case ClubNatureCategoryEnum.IRON:
			num = Settings.E6ConfigsSettings.DefaultPercentBackSpinIron;
			num2 = Settings.E6ConfigsSettings.DefaultOffsetClubFaceIron;
			break;
		case ClubNatureCategoryEnum.WOOD:
			num = Settings.E6ConfigsSettings.DefaultPercentBackSpinWood;
			num2 = Settings.E6ConfigsSettings.DefaultOffsetClubFaceWood;
			break;
		case ClubNatureCategoryEnum.PUTTER:
			return new Tuple<float, float>(0f, 0f);
		}
		checked
		{
			try
			{
				DataSpinConfigModel dataSpinConfigModel = null;
				if (Settings.E6ConfigsSettings.DataSpinConfigModelWood.IsEmpty() || Settings.E6ConfigsSettings.DataSpinConfigModelIron.IsEmpty())
				{
					TryOverwriteSpinSettings().Wait();
				}
				if (club == ClubNatureEnum.IRON_WEDGE || club == ClubNatureEnum.WOOD_FAIRWAY_SMALL)
				{
					dataSpinConfigModel = Settings.E6ConfigsSettings.DataSpinConfigModelFWHybridWedges;
				}
				else
				{
					switch (clubNatureCategory)
					{
					case ClubNatureCategoryEnum.IRON:
						dataSpinConfigModel = Settings.E6ConfigsSettings.DataSpinConfigModelIron;
						break;
					case ClubNatureCategoryEnum.WOOD:
						dataSpinConfigModel = Settings.E6ConfigsSettings.DataSpinConfigModelWood;
						break;
					}
				}
				if (dataSpinConfigModel == null)
				{
					return new Tuple<float, float>(num, num2);
				}
				k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1630), dataSpinConfigModel);
				List<int> ballSpeedRangeBracket = gsJnFH17UD.GetBallSpeedRangeBracket(dataSpinConfigModel);
				List<int> launchAngleRangeBracket = gsJnFH17UD.GetLaunchAngleRangeBracket(dataSpinConfigModel);
				List<int> ballPositionRangeBracket = gsJnFH17UD.GetBallPositionRangeBracket(dataSpinConfigModel);
				int closestIndexToValueFromList = GIUtils.GetClosestIndexToValueFromList((int)ballSpeed, ballSpeedRangeBracket);
				int closestIndexToValueFromList2 = GIUtils.GetClosestIndexToValueFromList((int)launchAngle, launchAngleRangeBracket);
				int closestIndexToValueFromList3 = GIUtils.GetClosestIndexToValueFromList((int)(100f + clubBallHitPercent), ballPositionRangeBracket);
				if (club == ClubNatureEnum.IRON_WEDGE || club == ClubNatureEnum.WOOD_FAIRWAY_SMALL)
				{
					bool num3 = club == ClubNatureEnum.IRON_WEDGE;
					float num4 = (Settings.UseGSPro ? Settings.E6ConfigsSettings.PercentBackSpinFWHybridWedges[closestIndexToValueFromList][closestIndexToValueFromList2] : E6BackSpinFactorConstant.PercentBackSpinIrons[closestIndexToValueFromList2][closestIndexToValueFromList]);
					float num5 = (num3 ? Settings.E6ConfigsSettings.OffsetClubFaceIrons[0][closestIndexToValueFromList3] : Settings.E6ConfigsSettings.OffsetClubFaceWoods[0][closestIndexToValueFromList3]);
					num = num4;
					num2 = num5;
				}
				else
				{
					switch (clubNatureCategory)
					{
					case ClubNatureCategoryEnum.IRON:
						num = (Settings.UseGSPro ? Settings.E6ConfigsSettings.PercentBackSpinIrons[closestIndexToValueFromList][closestIndexToValueFromList2] : E6BackSpinFactorConstant.PercentBackSpinIrons[closestIndexToValueFromList2][closestIndexToValueFromList]);
						num2 = Settings.E6ConfigsSettings.OffsetClubFaceIrons[0][closestIndexToValueFromList3];
						break;
					case ClubNatureCategoryEnum.WOOD:
						num = (Settings.UseGSPro ? Settings.E6ConfigsSettings.PercentBackSpinWoods[closestIndexToValueFromList][closestIndexToValueFromList2] : E6BackSpinFactorConstant.PercentBackSpinWoods[closestIndexToValueFromList2][closestIndexToValueFromList]);
						num2 = Settings.E6ConfigsSettings.OffsetClubFaceWoods[0][closestIndexToValueFromList3];
						break;
					}
				}
				ICircularLogService circularLogService = k6On2yqTS7;
				if (circularLogService != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(99, 4);
					defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1674));
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1734));
					defaultInterpolatedStringHandler.AppendFormatted(CTSShotData.GetClubNatureToString(club));
					defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1758));
					defaultInterpolatedStringHandler.AppendFormatted(ballSpeed);
					defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1830));
					defaultInterpolatedStringHandler.AppendFormatted(launchAngle);
					defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1886));
					circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				ICircularLogService circularLogService2 = k6On2yqTS7;
				if (circularLogService2 != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(100, 4);
					defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1892));
					defaultInterpolatedStringHandler2.AppendFormatted(num2);
					defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1954));
					defaultInterpolatedStringHandler2.AppendFormatted(CTSShotData.GetClubNatureToString(club));
					defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1758));
					defaultInterpolatedStringHandler2.AppendFormatted(ballSpeed);
					defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1976));
					defaultInterpolatedStringHandler2.AppendFormatted(clubBallHitPercent);
					defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2034));
					circularLogService2.Log(defaultInterpolatedStringHandler2.ToStringAndClear());
				}
			}
			catch (Exception ex)
			{
				k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2040) + ex.Message);
			}
			return new Tuple<float, float>(num, num2);
		}
	}

	public void SetDefaultConfigData()
	{
		ConfigData msg = new ConfigData
		{
			PercentBackSpinIron = Settings.E6ConfigsSettings.DefaultPercentBackSpinIron,
			PercentBackSpinWood = Settings.E6ConfigsSettings.DefaultPercentBackSpinWood,
			OffsetClubFaceIron = Settings.E6ConfigsSettings.DefaultOffsetClubFaceIron,
			OffsetClubFaceWood = Settings.E6ConfigsSettings.DefaultOffsetClubFaceWood,
			ShowPostShot = true
		};
		woCnxOBZen.SendConfigDataMessage(msg);
	}

	private void xTqL9NkOb9(string P_0 = "")
	{
		PKVnpC3Cgd((q02STxSWGDvVqGYBLH)2);
		woCnxOBZen.GetPlayerDataMessage();
		woCnxOBZen.GetEnvironmentDataMessage();
		if (IsCamerasRunning)
		{
			nrmItuhBbXIG6jxvoO gIhn6OsBuM = GIhn6OsBuM;
			if (gIhn6OsBuM != null && gIhn6OsBuM.r8nnR4FxJR == ShotStatusEnum.WaitForShot)
			{
				OnCameraStateChanged(ShotStatusEnum.WaitForShot, GIhn6OsBuM.xqTSsOtAK4);
			}
		}
		OnGolfLocalAPIArmed?.Invoke();
		if (!(IdraDataOutGame == null))
		{
			if (IdraDataOutGame.hasWaitForShot)
			{
				SetTrackingStatus(TrackingStatusAction.OK, IdraDataOutGame.offsetBallY);
			}
			else
			{
				SetTrackingStatus(TrackingStatusAction.NOTREADY);
			}
			IdraDataOutGame = null;
		}
	}

	private void prJLA29GtS(string P_0 = "")
	{
		PKVnpC3Cgd((q02STxSWGDvVqGYBLH)3);
	}

	private void g75Lj3IfVB(SimCommandShotCompletedMsg P_0)
	{
		OnShotReceiveFromGame?.Invoke(P_0);
		sgcngAEv55(value: true);
		UeXLdpJa9O(_0020: true, 0.0);
	}

	private void MDjL6H8dQg(bool P_0)
	{
		OnUIAvailableStatusChange?.Invoke(P_0);
	}

	public void Release()
	{
		if (!s1dnGTvBid)
		{
			return;
		}
		s1dnGTvBid = false;
		k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2222));
		ICommunicationIDRALocalAPI communicationIDRALocalAPI = woCnxOBZen;
		communicationIDRALocalAPI.OnNewTextMessage = (Action<string>)Delegate.Remove(communicationIDRALocalAPI.OnNewTextMessage, new Action<string>(OnNewTextMessageFromLocalGame));
		ICommunicationIDRALocalAPI communicationIDRALocalAPI2 = woCnxOBZen;
		communicationIDRALocalAPI2.OnArmed = (Action<string>)Delegate.Remove(communicationIDRALocalAPI2.OnArmed, new Action<string>(xTqL9NkOb9));
		ICommunicationIDRALocalAPI communicationIDRALocalAPI3 = woCnxOBZen;
		communicationIDRALocalAPI3.OnDisarmed = (Action<string>)Delegate.Remove(communicationIDRALocalAPI3.OnDisarmed, new Action<string>(prJLA29GtS));
		ICommunicationIDRALocalAPI communicationIDRALocalAPI4 = woCnxOBZen;
		communicationIDRALocalAPI4.OnShotCompleted = (Action<SimCommandShotCompletedMsg>)Delegate.Remove(communicationIDRALocalAPI4.OnShotCompleted, new Action<SimCommandShotCompletedMsg>(g75Lj3IfVB));
		ICommunicationIDRALocalAPI communicationIDRALocalAPI5 = woCnxOBZen;
		communicationIDRALocalAPI5.OnEnvironmentDataModified = (Action<SimCommandEnvironmentDataModifiedMsg>)Delegate.Remove(communicationIDRALocalAPI5.OnEnvironmentDataModified, (Action<SimCommandEnvironmentDataModifiedMsg>)delegate(SimCommandEnvironmentDataModifiedMsg P_0)
		{
			LastEnvironmentData = P_0;
		});
		ICommunicationIDRALocalAPI communicationIDRALocalAPI6 = woCnxOBZen;
		communicationIDRALocalAPI6.OnPlayerDataModified = (Action<PlayerHandednessNatureEnum, ClubTypeEnum, string>)Delegate.Remove(communicationIDRALocalAPI6.OnPlayerDataModified, (Action<PlayerHandednessNatureEnum, ClubTypeEnum, string>)delegate(PlayerHandednessNatureEnum P_0, ClubTypeEnum P_1, string P_2)
		{
			OkwnAqWG3R = P_0;
		});
		ICommunicationIDRALocalAPI communicationIDRALocalAPI7 = woCnxOBZen;
		communicationIDRALocalAPI7.OnSetClubType = (Action<GICTSMessage.InfoClassEnum, ClubTypeEnum>)Delegate.Remove(communicationIDRALocalAPI7.OnSetClubType, new Action<GICTSMessage.InfoClassEnum, ClubTypeEnum>(OnSetClubTypeMessageReceive));
		ICommunicationIDRALocalAPI communicationIDRALocalAPI8 = woCnxOBZen;
		communicationIDRALocalAPI8.OnClientConnected = (Action<bool>)Delegate.Remove(communicationIDRALocalAPI8.OnClientConnected, new Action<bool>(g2PLkPt3s0));
		ICommunicationIDRALocalAPI communicationIDRALocalAPI9 = woCnxOBZen;
		communicationIDRALocalAPI9.OnAuthenticated = (Action<bool>)Delegate.Remove(communicationIDRALocalAPI9.OnAuthenticated, new Action<bool>(OnReady));
		ICommunicationIDRALocalAPI communicationIDRALocalAPI10 = woCnxOBZen;
		communicationIDRALocalAPI10.OnGameProcessReady = (Action<bool>)Delegate.Remove(communicationIDRALocalAPI10.OnGameProcessReady, new Action<bool>(MDjL6H8dQg));
		if (woCnxOBZen is GSProAPIService)
		{
			GSProAPIService obj = woCnxOBZen as GSProAPIService;
			obj.OnGameComputeData = (Action<GSProComputeData>)Delegate.Remove(obj.OnGameComputeData, (Action<GSProComputeData>)async delegate(GSProComputeData P_0)
			{
				if (OnGameComputeData != null)
				{
					await OnGameComputeData(P_0);
				}
			});
			GSProAPIService obj2 = woCnxOBZen as GSProAPIService;
			obj2.OnFirstTeeCall = (Action<string>)Delegate.Remove(obj2.OnFirstTeeCall, (Action<string>)async delegate(string P_0)
			{
				if (OnFirstTee != null)
				{
					await OnFirstTee(P_0);
				}
			});
			GSProAPIService obj3 = woCnxOBZen as GSProAPIService;
			obj3.OnScoreCardIsVisible = (Action<bool>)Delegate.Remove(obj3.OnScoreCardIsVisible, (Action<bool>)delegate(bool P_0)
			{
				OnGSProScorecardIsVisible?.Invoke(P_0);
			});
			GSProAPIService obj4 = woCnxOBZen as GSProAPIService;
			obj4.OnOSKIsVisible = (Action<bool>)Delegate.Remove(obj4.OnOSKIsVisible, (Action<bool>)delegate(bool P_0)
			{
				OnGSPROOSKVisible?.Invoke(P_0);
			});
		}
		if (IsCamerasRunning)
		{
			SetTrackingStatus(TrackingStatusAction.NOTREADY, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2274));
		}
		if (woCnxOBZen.IsConnected)
		{
			woCnxOBZen.SendStatusMessage(new TrackingStatusData
			{
				ShowStatus = false,
				StatusType = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1306)
			});
			woCnxOBZen.Disconnect();
		}
		ICommunicationIDRALocalAPI communicationIDRALocalAPI11 = woCnxOBZen;
		communicationIDRALocalAPI11.OnClientDisconnected = (Action<bool>)Delegate.Remove(communicationIDRALocalAPI11.OnClientDisconnected, new Action<bool>(MvlL1d3FMy));
		woCnxOBZen.Dispose();
		O9xnmQaZBJ?.LogFileCloseTag();
		k6On2yqTS7?.LogFileCloseTag();
	}

	public void OnNewTextMessageFromLocalGame(string message)
	{
		k6On2yqTS7?.Log(message);
	}

	private void MvlL1d3FMy(bool P_0)
	{
		PKVnpC3Cgd((q02STxSWGDvVqGYBLH)0);
		k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2292));
	}

	private void g2PLkPt3s0(bool P_0)
	{
		k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2358) + (P_0 ? YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2404) : YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2392)));
	}

	private void OnReady(bool success)
	{
		PKVnpC3Cgd((q02STxSWGDvVqGYBLH)1);
		k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2422));
		SetDefaultConfigData();
		Thread.Sleep(100);
		woCnxOBZen.SetClubTypeMessage(new SetClubTypeData
		{
			ClubType = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1378)
		});
	}

	public void GetPlayerData()
	{
		woCnxOBZen.GetPlayerDataMessage();
	}

	public async Task TryOverwriteSpinSettings()
	{
		if (Settings == null || DefaultSettings == null)
		{
			return;
		}
		bool num = GIUtils.SequenceChildEqual(Settings.E6ConfigsSettings.PercentBackSpinIrons, DefaultSettings.E6ConfigsSettings.PercentBackSpinIrons);
		bool flag = GIUtils.SequenceChildEqual(Settings.E6ConfigsSettings.PercentBackSpinWoods, DefaultSettings.E6ConfigsSettings.PercentBackSpinWoods);
		bool flag2 = GIUtils.SequenceChildEqual(Settings.E6ConfigsSettings.PercentBackSpinFWHybridWedges, DefaultSettings.E6ConfigsSettings.PercentBackSpinFWHybridWedges);
		bool flag3 = GIUtils.SequenceChildEqual(Settings.E6ConfigsSettings.OffsetClubFaceIrons, DefaultSettings.E6ConfigsSettings.OffsetClubFaceIrons);
		bool flag4 = GIUtils.SequenceChildEqual(Settings.E6ConfigsSettings.OffsetClubFaceWoods, DefaultSettings.E6ConfigsSettings.OffsetClubFaceWoods);
		bool num2 = !Settings.E6ConfigsSettings.DefaultPercentBackSpinIron.Equals(DefaultSettings.E6ConfigsSettings.DefaultPercentBackSpinIron);
		bool flag5 = !Settings.E6ConfigsSettings.DefaultPercentBackSpinWood.Equals(DefaultSettings.E6ConfigsSettings.DefaultPercentBackSpinWood);
		bool flag6 = !Settings.E6ConfigsSettings.DefaultOffsetClubFaceIron.Equals(DefaultSettings.E6ConfigsSettings.DefaultOffsetClubFaceIron);
		bool flag7 = !Settings.E6ConfigsSettings.DefaultOffsetClubFaceWood.Equals(DefaultSettings.E6ConfigsSettings.DefaultOffsetClubFaceWood);
		bool flag8 = num2 || flag5 || flag6 || flag7;
		bool flag9 = Settings.E6ConfigsSettings.DataSpinConfigModelWood == null || Settings.E6ConfigsSettings.DataSpinConfigModelWood.IsEmpty();
		bool flag10 = Settings.E6ConfigsSettings.DataSpinConfigModelIron == null || Settings.E6ConfigsSettings.DataSpinConfigModelIron.IsEmpty();
		bool flag11 = Settings.E6ConfigsSettings.DataSpinConfigModelFWHybridWedges == null || Settings.E6ConfigsSettings.DataSpinConfigModelFWHybridWedges.IsEmpty();
		if (!(!num || !flag || !flag2 || !flag3 || !flag4 || flag9 || flag10 || flag11 || flag8))
		{
			return;
		}
		if (Settings.E6ConfigsSettings.UseGolfInBackSpinFactor)
		{
			k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(20614));
			Settings.E6ConfigsSettings.PercentBackSpinIrons = DefaultSettings.E6ConfigsSettings.PercentBackSpinIrons;
			Settings.E6ConfigsSettings.PercentBackSpinWoods = DefaultSettings.E6ConfigsSettings.PercentBackSpinWoods;
			Settings.E6ConfigsSettings.PercentBackSpinFWHybridWedges = DefaultSettings.E6ConfigsSettings.PercentBackSpinFWHybridWedges;
			Settings.E6ConfigsSettings.DefaultPercentBackSpinIron = DefaultSettings.E6ConfigsSettings.DefaultPercentBackSpinIron;
			Settings.E6ConfigsSettings.DefaultPercentBackSpinWood = DefaultSettings.E6ConfigsSettings.DefaultPercentBackSpinWood;
		}
		if (Settings.E6ConfigsSettings.UseGolfInClubFaceOffset)
		{
			k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(20738));
			Settings.E6ConfigsSettings.OffsetClubFaceIrons = DefaultSettings.E6ConfigsSettings.OffsetClubFaceIrons;
			Settings.E6ConfigsSettings.OffsetClubFaceWoods = DefaultSettings.E6ConfigsSettings.OffsetClubFaceWoods;
			Settings.E6ConfigsSettings.DefaultOffsetClubFaceIron = DefaultSettings.E6ConfigsSettings.DefaultOffsetClubFaceIron;
			Settings.E6ConfigsSettings.DefaultOffsetClubFaceWood = DefaultSettings.E6ConfigsSettings.DefaultOffsetClubFaceWood;
		}
		if (Settings.E6ConfigsSettings.UseGolfInBackSpinFactor || Settings.E6ConfigsSettings.UseGolfInClubFaceOffset)
		{
			Settings.E6ConfigsSettings.DataSpinConfigModelWood = DefaultSettings.E6ConfigsSettings.DataSpinConfigModelWood;
			Settings.E6ConfigsSettings.DataSpinConfigModelIron = DefaultSettings.E6ConfigsSettings.DataSpinConfigModelIron;
			Settings.E6ConfigsSettings.DataSpinConfigModelFWHybridWedges = DefaultSettings.E6ConfigsSettings.DataSpinConfigModelFWHybridWedges;
		}
		try
		{
			await wMGnoqajvY.SaveSettings(Settings, IDRAConstant.GICTSSettingsFilePath);
		}
		catch (Exception ex)
		{
			k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(20886));
			EventViewerLogger.LogException(ex);
		}
	}

	public void OnReloadSettings(GICTSSettings newSettings, FileInfo fromFile)
	{
		if (fromFile.FullName == IDRAConstant.GICTSSettingsFilePath)
		{
			Settings = newSettings;
		}
		else if (fromFile.FullName == IDRAConstant.GICTSDefaultSettingsFilePath)
		{
			DefaultSettings = newSettings;
		}
	}

	public async Task ReloadSettings()
	{
		Settings = await wMGnoqajvY.LoadSettings(IDRAConstant.GICTSSettingsFilePath);
	}

	public async Task SaveSettings()
	{
		await wMGnoqajvY.SaveSettings(Settings, IDRAConstant.GICTSSettingsFilePath);
	}

	public override void OnLog(string log, CircularLogLevel logLevel)
	{
		O9xnmQaZBJ?.Log(log, (LogLevel)logLevel);
	}

	public override void OnSetLogLevel(CircularLogLevel logLevel)
	{
		O9xnmQaZBJ?.SetLogLevel((LogLevel)logLevel);
	}

	public override void OnCameraStateChanged(ShotStatusEnum state)
	{
		OnCameraStateChanged(state, new ShotStatusData());
	}

	public override void OnCameraStateChanged(ShotStatusEnum state, ShotStatusData data)
	{
		if ((Debugger.IsAttached && state == ShotStatusEnum.BallNotFound) || state == ShotStatusEnum.MoveTheBall)
		{
			return;
		}
		nrmItuhBbXIG6jxvoO nrmItuhBbXIG6jxvoO = new nrmItuhBbXIG6jxvoO
		{
			r8nnR4FxJR = state,
			xqTSsOtAK4 = data,
			GAGnzRCw05 = ((GIhn6OsBuM != null) ? GIhn6OsBuM.r8nnR4FxJR : ShotStatusEnum.Idle),
			rk3SgVUSS0 = ((GIhn6OsBuM == null) ? null : GIhn6OsBuM.xqTSsOtAK4)
		};
		if (GIhn6OsBuM != null && nrmItuhBbXIG6jxvoO.r8nnR4FxJR == nrmItuhBbXIG6jxvoO.GAGnzRCw05 && (nrmItuhBbXIG6jxvoO.r8nnR4FxJR != ShotStatusEnum.MoveTheBall || nrmItuhBbXIG6jxvoO.xqTSsOtAK4.MoveBallDirection == nrmItuhBbXIG6jxvoO.rk3SgVUSS0.MoveBallDirection))
		{
			return;
		}
		Qd7n10S6EB.Add(nrmItuhBbXIG6jxvoO);
		if (Qd7n10S6EB.Count > 5)
		{
			Qd7n10S6EB.RemoveAt(0);
		}
		string value = ((nrmItuhBbXIG6jxvoO.r8nnR4FxJR == ShotStatusEnum.MoveTheBall) ? nrmItuhBbXIG6jxvoO.xqTSsOtAK4.MoveBallDirection.ToString() : "");
		ICircularLogService circularLogService = k6On2yqTS7;
		if (circularLogService != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(65, 4);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2440));
			defaultInterpolatedStringHandler.AppendFormatted(nrmItuhBbXIG6jxvoO.r8nnR4FxJR);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2484));
			defaultInterpolatedStringHandler.AppendFormatted(nrmItuhBbXIG6jxvoO.GAGnzRCw05);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2516));
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2548));
			defaultInterpolatedStringHandler.AppendFormatted((yXinKySZXV() == (q02STxSWGDvVqGYBLH)2) ? YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1256) : YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1248));
			circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		if (yXinKySZXV() >= (q02STxSWGDvVqGYBLH)1)
		{
			switch (state)
			{
			case ShotStatusEnum.Idle:
			case ShotStatusEnum.BallNotFound:
				SetTrackingStatus(TrackingStatusAction.NOTREADY, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2274));
				break;
			case ShotStatusEnum.MoveTheBall:
				SetTrackingStatus(TrackingStatusAction.MOVE, data.MoveBallDirection.ToString());
				break;
			case ShotStatusEnum.WaitForShot:
				SetTrackingStatus(TrackingStatusAction.OK, wnhLlOowI2(data.OffsetBallY).ToString());
				UeXLdpJa9O(_0020: false, data.OffsetBallY);
				break;
			}
		}
		else
		{
			switch (state)
			{
			case ShotStatusEnum.Idle:
			case ShotStatusEnum.MoveTheBall:
			case ShotStatusEnum.BallNotFound:
			case ShotStatusEnum.BallDetected:
				IdraDataOutGame = new IdraDataOutGame(hasWaitForShot: false, string.Empty);
				break;
			case ShotStatusEnum.WaitForShot:
				IdraDataOutGame = new IdraDataOutGame(hasWaitForShot: true, wnhLlOowI2(data.OffsetBallY).ToString());
				break;
			}
		}
		GIhn6OsBuM = nrmItuhBbXIG6jxvoO;
	}

	private void UeXLdpJa9O(bool P_0, double P_1)
	{
		try
		{
			if (!UjHnsvu2nN())
			{
				return;
			}
			if (!ManagerSettings.Instance.VisualSettings.EnableTeeOffset)
			{
				if (ILMnnSAVPC())
				{
					woCnxOBZen.SendBoothDataMessage(new GspBoothData
					{
						ScreenWidthInch = 0f,
						CenterOffset = 0f,
						OffsetEnable = false
					});
					ThvnSHRJIb(value: false);
				}
			}
			else
			{
				double num = (P_0 ? HBOnvn1oZs() : wnhLlOowI2(P_1));
				woCnxOBZen.SendBoothDataMessage(new GspBoothData
				{
					ScreenWidthInch = ManagerSettings.Instance.VisualSettings.ScreenWidthInches,
					CenterOffset = (float)num,
					OffsetEnable = ManagerSettings.Instance.VisualSettings.EnableTeeOffset
				});
				ThvnSHRJIb(value: true);
			}
		}
		catch (Exception)
		{
			k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2586), LogLevel.Error);
		}
	}

	public override async void OnRefreshIDRAConfig()
	{
		_ = 2;
		try
		{
			await dxqLN1Cews();
			try
			{
				await zK1nXLdVSd.RefreshDocuments();
			}
			catch (Exception ex)
			{
				k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(19536) + ex.Message, LogLevel.Error);
			}
			try
			{
				await TLsnexHrM5.LoadXmlDocument(bvgn9mWAZE);
				IsCamerasRunning = TLsnexHrM5.ReadNodeValue<bool>(IDRAConstant.UseCameraXPath);
			}
			catch (Exception ex2) when (((ex2 is FileNotFoundException || ex2 is FileLoadException) ? 1 : 0) != 0)
			{
				k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(19688) + ex2.Message, LogLevel.Error);
				IsCamerasRunning = true;
			}
			OnRefreshIDRAConfiguration?.Invoke();
		}
		catch (Exception ex3)
		{
			k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(19906) + ex3.Message, LogLevel.Error);
			IsCamerasRunning = true;
		}
	}

	private async Task dxqLN1Cews()
	{
		bool isCurrentModePlayMode = true;
		try
		{
			isCurrentModePlayMode = await zK1nXLdVSd.GetCurrentMode() == IdraMode.Play;
		}
		catch (Exception ex)
		{
			k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(21092) + ex.Message, LogLevel.Error);
		}
		if (isCurrentModePlayMode)
		{
			LightInterface safelyLightInterface = GetSafelyLightInterface();
			if (safelyLightInterface != null && !safelyLightInterface.HaveValidCalibration())
			{
				OnMissingCalibrationForConnectedIDRA?.Invoke();
			}
		}
	}

	public override void OnNewShot(GICTSShotData shotJson)
	{
		PrintGICTSShotData(shotJson);
		k6On2yqTS7?.Log(new string('*', 30) + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2664) + new string('*', 30));
		OnNewShot(C2bL5elyi3(shotJson));
	}

	private CTSShotData C2bL5elyi3(GICTSShotData P_0)
	{
		dDdL3HadyU(ref P_0);
		CTSShotData cTSShotData = new CTSShotData
		{
			Ball = new BallData
			{
				BallSpeed = (double)P_0.ball_speed_ * IDRAConstant.MPS_TO_MPH,
				LaunchAngle = P_0.ball_launch_angle_,
				LaunchDirection = P_0.ball_direction_,
				BackSpin = P_0.ball_back_spin_,
				SideSpin = P_0.ball_side_spin_
			},
			Club = new ClubData
			{
				ClubAnglePath = P_0.club_path_,
				ClubHeadSpeed = (double)P_0.club_speed_ * IDRAConstant.MPS_TO_MPH,
				ClubAngleOfAttack = P_0.club_attack_angle_
			},
			PlayerHandedness = ((!(P_0.player_handed_.ToLower() == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2688))) ? PlayerHandednessNatureEnum.Right : PlayerHandednessNatureEnum.Left),
			ClubBallHitPercent = P_0.club_ball_impact_percent_,
			ShotName = P_0.shot_name_,
			ClubNature = (ClubNatureEnum)P_0.clubType,
			Points3D = JsonConvert.DeserializeObject<List<Point3D>>(P_0.ball_trajectory_.ToUpper())
		};
		cTSShotData.Club.ClubAnglePath *= ((cTSShotData.PlayerHandedness != PlayerHandednessNatureEnum.Left) ? 1 : (-1));
		if (cTSShotData.PlayerHandedness == PlayerHandednessNatureEnum.Unknown)
		{
			cTSShotData.PlayerHandedness = OkwnAqWG3R;
		}
		return cTSShotData;
	}

	public override double OnComputeClubFace(GICTSShotData shotJson)
	{
		CTSShotData cTSShotData = C2bL5elyi3(shotJson);
		return vlKLJJqEvg(cTSShotData.Ball.LaunchAngle, cTSShotData.Ball.LaunchDirection, cTSShotData.PlayerHandedness, cTSShotData.Club.ClubAnglePath, cTSShotData.ClubNature);
	}

	public override string OnGetSpinConfig(int club_nature, double ball_speed, double launch_angle, float ball_club_hit_percent)
	{
		Tuple<float, float> spinConfig = GetSpinConfig((ClubNatureEnum)club_nature, ball_speed, launch_angle, ball_club_hit_percent);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted(spinConfig.Item1);
		defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2700));
		defaultInterpolatedStringHandler.AppendFormatted(spinConfig.Item2);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public override bool OnIsPutter(GICTSShotData shot)
	{
		CTSShotData cTSShotData = C2bL5elyi3(shot);
		if (!(cTSShotData.Ball.LaunchAngle < Settings.ClubSettings.ForcePutterPathAndFaceDirectionWhenBallLaunchAngleLowerThan) || !(cTSShotData.Ball.BallSpeed < Settings.ClubSettings.ForcePutterPathAndFaceDirectionWhenBallSpeedLowerThan))
		{
			return cTSShotData.Ball.BallSpeed < Settings.ClubSettings.ForcePutterPathAndFaceDirectionWhenBallSpeedLowerThanAbsolute;
		}
		return true;
	}

	public override void OnHasExited(int code)
	{
		if (IdraHasExited == null || !s1dnGTvBid)
		{
			return;
		}
		try
		{
			GetSafelyLightInterface()?.resetCameraCallback();
			ICircularLogService circularLogService = k6On2yqTS7;
			if (circularLogService != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 1);
				defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2706));
				defaultInterpolatedStringHandler.AppendFormatted(code);
				circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			Release();
		}
		catch (Exception ex)
		{
			k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2796) + ex.Message, LogLevel.Error);
		}
		finally
		{
			IdraHasExited(code);
		}
	}

	public override void OnCameraErrorCode(int code, string camSerialNumber, bool isSuperSpeed)
	{
		if (s1dnGTvBid)
		{
			OnCamErrorCode?.Invoke(code, camSerialNumber, isSuperSpeed);
		}
	}

	public override void OnPostShotVideoAvailable(string shotName, int impactFrame)
	{
		string iDRAPostShotVideoFilePath = GIConstant.IDRAPostShotVideoFilePath;
		if (File.Exists(iDRAPostShotVideoFilePath))
		{
			OnPostShotVideoExported?.Invoke(shotName, impactFrame);
		}
		k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2844) + iDRAPostShotVideoFilePath);
	}

	public override void OnVideoAvailable()
	{
		OnVideoExported?.Invoke();
	}

	private bool OnNewShot(CTSShotData shot)
	{
		try
		{
			CTSShotData cTSShotData = Gk1LWersXM(shot);
			l8IL4PKocR(cTSShotData);
			cTSShotData.ConfigData = GetConfigData(cTSShotData);
			SendShot(cTSShotData);
			if (Settings.E6ConfigsSettings.GenerateTruTrackDebugDisplayFile)
			{
				N5xLiAH1LL();
			}
			kdUnEFq6qj.KeepFreeSpace(Settings.MinimumFreeSpaceToKeepGb, Settings.MinimumNumberOfShotsToKeep);
			W6wLQ2HvWH(cTSShotData);
			atdLc2ry0F();
			OnNewShotSent?.Invoke(cTSShotData);
		}
		finally
		{
			sgcngAEv55(value: false);
		}
		return true;
	}

	private void atdLc2ry0F()
	{
		k6On2yqTS7.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2906));
		Task.Run(async delegate
		{
			await (await FileProcessCommunication.GetInstanceAsync(new IDRAZGISCommunication(), k6On2yqTS7)).WriteMessage(IDRAZGISCommunication.CommunicationCode.IDRAOnNewShot);
		}).Wait();
	}

	private CTSShotData Gk1LWersXM(CTSShotData P_0)
	{
		k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3004));
		k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3048), P_0);
		CTSShotData cTSShotData = P_0.Copy();
		if (Settings.ShotAdsjustementSettings.BallDirectionAdjustmentDegree != 0.0)
		{
			cTSShotData.Ball.LaunchDirection += Settings.ShotAdsjustementSettings.BallDirectionAdjustmentDegree;
			List<string> log = cTSShotData.Log;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3140));
			defaultInterpolatedStringHandler.AppendFormatted(Settings.ShotAdsjustementSettings.BallDirectionAdjustmentDegree, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3194));
			log.Add(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		List<string> list = new List<string>();
		cTSShotData.Club.ClubAngleFace = vlKLJJqEvg(cTSShotData.Ball.LaunchAngle, cTSShotData.Ball.LaunchDirection, cTSShotData.PlayerHandedness, cTSShotData.Club.ClubAnglePath, cTSShotData.ClubNature, list);
		cTSShotData.Log.AddRange(list);
		cTSShotData.Ball.BallSpeed = cTSShotData.Ball.BallSpeed + cTSShotData.Ball.BallSpeed * Settings.ShotAdsjustementSettings.BallSpeedAdjustmentPct;
		cTSShotData.Ball.LaunchAngle = cTSShotData.Ball.LaunchAngle + Settings.ShotAdsjustementSettings.BallLaunchAngleAdjustmentDegree;
		cTSShotData.Club.ClubAnglePath = cTSShotData.Club.ClubAnglePath + cTSShotData.Club.ClubAnglePath * Settings.ShotAdsjustementSettings.ClubAnglePathAdjustmentPct;
		cTSShotData.Club.ClubAngleOfAttack = cTSShotData.Club.ClubAngleOfAttack + cTSShotData.Club.ClubAngleOfAttack * Settings.ShotAdsjustementSettings.ClubAngleOfAttackAdjustmentPct;
		cTSShotData.Club.ClubHeadSpeed = cTSShotData.Club.ClubHeadSpeed + cTSShotData.Club.ClubHeadSpeed * Settings.ShotAdsjustementSettings.ClubSpeedAdjustmentPct;
		double num = cTSShotData.Ball.BallSpeed / ((cTSShotData.Club.ClubHeadSpeed == 0.0) ? 1.0 : cTSShotData.Club.ClubHeadSpeed);
		if (num < Settings.ShotAdsjustementSettings.LimitClubSpeedAdjustmentSmashFactorMin)
		{
			cTSShotData.Club.ClubHeadSpeed = cTSShotData.Ball.BallSpeed / Settings.ShotAdsjustementSettings.LimitClubSpeedAdjustmentSmashFactorMin;
		}
		else if (num > Settings.ShotAdsjustementSettings.LimitClubSpeedAdjustmentSmashFactorMax)
		{
			cTSShotData.Club.ClubHeadSpeed = cTSShotData.Ball.BallSpeed / ((Settings.ShotAdsjustementSettings.LimitClubSpeedAdjustmentSmashFactorMax == 0.0) ? IDRAConstant.DefaultMaxSmashFactor : Settings.ShotAdsjustementSettings.LimitClubSpeedAdjustmentSmashFactorMax);
		}
		if (LastEnvironmentData != null)
		{
			cTSShotData.Log.Add(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3220) + (LastEnvironmentData.TerrainType ?? YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3252)));
		}
		k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3262), cTSShotData);
		return cTSShotData;
	}

	private double vlKLJJqEvg(double P_0, double P_1, PlayerHandednessNatureEnum P_2, double P_3, ClubNatureEnum P_4, List<string> P_5 = null)
	{
		if (Settings == null || Settings.ClubSettings == null)
		{
			throw new Exception(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3352));
		}
		double num = 0.0;
		if (P_0 <= (double)Settings.ClubSettings.ClubWoodMaxLaunchAngle)
		{
			num = Settings.ClubSettings.ClubWoodFaceAngleImpactOnBallDirectionPct;
		}
		else if (P_0 <= (double)Settings.ClubSettings.ClubIronMaxLaunchAngle)
		{
			num = Settings.ClubSettings.ClubIronFaceAngleImpactOnBallDirectionPct;
		}
		else if (P_0 <= (double)Settings.ClubSettings.ClubWedgeMaxLaunchAngle)
		{
			num = Settings.ClubSettings.ClubWedgeFaceAngleImpactOnBallDirectionPct;
		}
		double num2 = P_3 * (1.0 - num);
		double num3 = num2 - P_1;
		num = ((num == 0.0) ? IDRAConstant.DefaultImpactFactorOnClubFaceAndBallDirection : num);
		double num4 = num3 / num * -1.0;
		if (P_5 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(62, 3);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3436));
			defaultInterpolatedStringHandler.AppendFormatted(P_4);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3466));
			defaultInterpolatedStringHandler.AppendFormatted(Math.Round(num * 100.0, 2));
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3524));
			defaultInterpolatedStringHandler.AppendFormatted(Math.Round(P_1, 2));
			P_5.Add(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		double num5 = ((CTSShotData.GetClubNatureCategory(P_4) == ClubNatureCategoryEnum.WOOD) ? Settings.ClubSettings.ClubFaceAngleOffsetAdjustmentWood : Settings.ClubSettings.ClubFaceAngleOffsetAdjustmentIron);
		num4 += ((P_2 == PlayerHandednessNatureEnum.Left) ? (0.0 - num5) : num5);
		if (P_5 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(45, 2);
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3572));
			defaultInterpolatedStringHandler2.AppendFormatted(Math.Round(num4, 2));
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3630));
			defaultInterpolatedStringHandler2.AppendFormatted(Math.Round(num5, 2));
			P_5.Add(defaultInterpolatedStringHandler2.ToStringAndClear());
		}
		if (P_5 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(64, 2);
			defaultInterpolatedStringHandler3.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3670));
			defaultInterpolatedStringHandler3.AppendFormatted(Math.Round(num2, 2));
			defaultInterpolatedStringHandler3.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3768));
			defaultInterpolatedStringHandler3.AppendFormatted(Math.Round(num3, 2));
			P_5.Add(defaultInterpolatedStringHandler3.ToStringAndClear());
		}
		return num4;
	}

	private void l8IL4PKocR(CTSShotData P_0)
	{
		CTSShotData cTSShotData = P_0.Copy();
		P_0.Ball.BallSpeed = Math.Min(P_0.Ball.BallSpeed, Settings.E6LimitsSettings.LimitBallSpeedMax);
		P_0.Ball.BallSpeed = Math.Max(P_0.Ball.BallSpeed, Settings.E6LimitsSettings.LimitBallSpeedMin);
		if (P_0.Ball.BallSpeed != cTSShotData.Ball.BallSpeed)
		{
			List<string> log = P_0.Log;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(71, 3);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3806));
			defaultInterpolatedStringHandler.AppendFormatted(Settings.E6LimitsSettings.LimitBallSpeedMin);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3948));
			defaultInterpolatedStringHandler.AppendFormatted(Settings.E6LimitsSettings.LimitBallSpeedMax);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3948));
			defaultInterpolatedStringHandler.AppendFormatted(cTSShotData.Ball.BallSpeed);
			log.Add(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		P_0.Ball.LaunchDirection = Math.Min(P_0.Ball.LaunchDirection, Settings.E6LimitsSettings.LimitBallDirectionMax);
		P_0.Ball.LaunchDirection = Math.Max(P_0.Ball.LaunchDirection, Settings.E6LimitsSettings.LimitBallDirectionMin);
		if (P_0.Ball.LaunchDirection != cTSShotData.Ball.LaunchDirection)
		{
			List<string> log2 = P_0.Log;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(75, 3);
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3954));
			defaultInterpolatedStringHandler2.AppendFormatted(Settings.E6LimitsSettings.LimitBallDirectionMin);
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3948));
			defaultInterpolatedStringHandler2.AppendFormatted(Settings.E6LimitsSettings.LimitBallDirectionMax);
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3948));
			defaultInterpolatedStringHandler2.AppendFormatted(cTSShotData.Ball.LaunchDirection);
			log2.Add(defaultInterpolatedStringHandler2.ToStringAndClear());
		}
		P_0.Ball.LaunchAngle = Math.Min(P_0.Ball.LaunchAngle, Settings.E6LimitsSettings.LimitBallLaunchMax);
		P_0.Ball.LaunchAngle = Math.Max(P_0.Ball.LaunchAngle, Settings.E6LimitsSettings.LimitBallLaunchMin);
		if (P_0.Ball.LaunchAngle != cTSShotData.Ball.LaunchAngle)
		{
			List<string> log3 = P_0.Log;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(72, 3);
			defaultInterpolatedStringHandler3.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(4104));
			defaultInterpolatedStringHandler3.AppendFormatted(Settings.E6LimitsSettings.LimitBallLaunchMin);
			defaultInterpolatedStringHandler3.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3948));
			defaultInterpolatedStringHandler3.AppendFormatted(Settings.E6LimitsSettings.LimitBallLaunchMax);
			defaultInterpolatedStringHandler3.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3948));
			defaultInterpolatedStringHandler3.AppendFormatted(cTSShotData.Ball.LaunchAngle);
			log3.Add(defaultInterpolatedStringHandler3.ToStringAndClear());
		}
		P_0.Ball.BackSpin = Math.Clamp(P_0.Ball.BackSpin, Settings.E6LimitsSettings.LimitBackSpinMin, Settings.E6LimitsSettings.LimitBackSpinMax);
		if (P_0.Ball.BackSpin != cTSShotData.Ball.BackSpin)
		{
			List<string> log4 = P_0.Log;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(74, 3);
			defaultInterpolatedStringHandler4.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(4248));
			defaultInterpolatedStringHandler4.AppendFormatted(Settings.E6LimitsSettings.LimitBackSpinMin);
			defaultInterpolatedStringHandler4.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3948));
			defaultInterpolatedStringHandler4.AppendFormatted(Settings.E6LimitsSettings.LimitBackSpinMax);
			defaultInterpolatedStringHandler4.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3948));
			defaultInterpolatedStringHandler4.AppendFormatted(cTSShotData.Ball.BackSpin);
			log4.Add(defaultInterpolatedStringHandler4.ToStringAndClear());
		}
		P_0.Club.ClubHeadSpeed = Math.Min(P_0.Club.ClubHeadSpeed, Settings.E6LimitsSettings.LimitClubHeadSpeedMax);
		P_0.Club.ClubHeadSpeed = Math.Max(P_0.Club.ClubHeadSpeed, Settings.E6LimitsSettings.LimitClubHeadSpeedMin);
		if (P_0.Club.ClubHeadSpeed != cTSShotData.Club.ClubHeadSpeed)
		{
			List<string> log5 = P_0.Log;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler5 = new DefaultInterpolatedStringHandler(71, 3);
			defaultInterpolatedStringHandler5.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(4396));
			defaultInterpolatedStringHandler5.AppendFormatted(Settings.E6LimitsSettings.LimitClubHeadSpeedMin);
			defaultInterpolatedStringHandler5.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3948));
			defaultInterpolatedStringHandler5.AppendFormatted(Settings.E6LimitsSettings.LimitClubHeadSpeedMax);
			defaultInterpolatedStringHandler5.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3948));
			defaultInterpolatedStringHandler5.AppendFormatted(cTSShotData.Club.ClubHeadSpeed);
			log5.Add(defaultInterpolatedStringHandler5.ToStringAndClear());
		}
		P_0.Club.ClubAnglePath = Math.Min(P_0.Club.ClubAnglePath, Settings.E6LimitsSettings.LimitClubAnglePathMax);
		P_0.Club.ClubAnglePath = Math.Max(P_0.Club.ClubAnglePath, Settings.E6LimitsSettings.LimitClubAnglePathMin);
		if (P_0.Club.ClubAnglePath != cTSShotData.Club.ClubAnglePath)
		{
			List<string> log6 = P_0.Log;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler6 = new DefaultInterpolatedStringHandler(70, 3);
			defaultInterpolatedStringHandler6.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(4538));
			defaultInterpolatedStringHandler6.AppendFormatted(Settings.E6LimitsSettings.LimitClubAnglePathMin);
			defaultInterpolatedStringHandler6.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3948));
			defaultInterpolatedStringHandler6.AppendFormatted(Settings.E6LimitsSettings.LimitClubAnglePathMax);
			defaultInterpolatedStringHandler6.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3948));
			defaultInterpolatedStringHandler6.AppendFormatted(cTSShotData.Club.ClubAnglePath);
			log6.Add(defaultInterpolatedStringHandler6.ToStringAndClear());
		}
		P_0.Club.ClubAngleFace = Math.Min(P_0.Club.ClubAngleFace, Settings.E6LimitsSettings.LimitClubFaceAngleMax);
		P_0.Club.ClubAngleFace = Math.Max(P_0.Club.ClubAngleFace, Settings.E6LimitsSettings.LimitClubFaceAngleMin);
		if (P_0.Club.ClubAngleFace != cTSShotData.Club.ClubAngleFace)
		{
			List<string> log7 = P_0.Log;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler7 = new DefaultInterpolatedStringHandler(70, 3);
			defaultInterpolatedStringHandler7.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(4678));
			defaultInterpolatedStringHandler7.AppendFormatted(Settings.E6LimitsSettings.LimitClubFaceAngleMin);
			defaultInterpolatedStringHandler7.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3948));
			defaultInterpolatedStringHandler7.AppendFormatted(Settings.E6LimitsSettings.LimitClubFaceAngleMax);
			defaultInterpolatedStringHandler7.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(3948));
			defaultInterpolatedStringHandler7.AppendFormatted(cTSShotData.Club.ClubAngleFace);
			log7.Add(defaultInterpolatedStringHandler7.ToStringAndClear());
		}
		string defaultClubType = ((CTSShotData.GetClubNatureCategory(P_0.ClubNature) == ClubNatureCategoryEnum.IRON) ? YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(4830) : YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(4818));
		if ((P_0.Ball.LaunchAngle < Settings.ClubSettings.ForcePutterPathAndFaceDirectionWhenBallLaunchAngleLowerThan && P_0.Ball.BallSpeed < Settings.ClubSettings.ForcePutterPathAndFaceDirectionWhenBallSpeedLowerThan) || P_0.Ball.BallSpeed < Settings.ClubSettings.ForcePutterPathAndFaceDirectionWhenBallSpeedLowerThanAbsolute)
		{
			string value = ((LastEnvironmentData == null) ? string.Empty : LastEnvironmentData.TerrainType);
			if (P_0.Ball.BallSpeed < Settings.ClubSettings.ForcePutterPathAndFaceDirectionWhenBallSpeedLowerThanAbsolute)
			{
				List<string> log8 = P_0.Log;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler8 = new DefaultInterpolatedStringHandler(89, 2);
				defaultInterpolatedStringHandler8.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(4842));
				defaultInterpolatedStringHandler8.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(4938));
				defaultInterpolatedStringHandler8.AppendFormatted(Settings.ClubSettings.ForcePutterPathAndFaceDirectionWhenBallSpeedLowerThanAbsolute);
				defaultInterpolatedStringHandler8.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(4998));
				defaultInterpolatedStringHandler8.AppendFormatted(value);
				log8.Add(defaultInterpolatedStringHandler8.ToStringAndClear());
			}
			else
			{
				List<string> log9 = P_0.Log;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler9 = new DefaultInterpolatedStringHandler(106, 3);
				defaultInterpolatedStringHandler9.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(5032));
				defaultInterpolatedStringHandler9.AppendFormatted(Settings.ClubSettings.ForcePutterPathAndFaceDirectionWhenBallLaunchAngleLowerThan);
				defaultInterpolatedStringHandler9.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(5170));
				defaultInterpolatedStringHandler9.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(5184));
				defaultInterpolatedStringHandler9.AppendFormatted(Settings.ClubSettings.ForcePutterPathAndFaceDirectionWhenBallSpeedLowerThan);
				defaultInterpolatedStringHandler9.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(4998));
				defaultInterpolatedStringHandler9.AppendFormatted(value);
				log9.Add(defaultInterpolatedStringHandler9.ToStringAndClear());
			}
			defaultClubType = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1406);
			P_0.ClubNature = ClubNatureEnum.PUTTER;
			P_0.Log.Add(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(5226));
			P_0.Ball.LaunchAngle = 0.0;
			P_0.Log.Add(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(5360));
			P_0.Club.ClubAngleFace = P_0.Ball.LaunchDirection;
			List<string> log10 = P_0.Log;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler10 = new DefaultInterpolatedStringHandler(84, 1);
			defaultInterpolatedStringHandler10.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(5524));
			defaultInterpolatedStringHandler10.AppendFormatted(P_0.Club.ClubAngleFace);
			log10.Add(defaultInterpolatedStringHandler10.ToStringAndClear());
			P_0.Club.ClubAnglePath = ((P_0.PlayerHandedness == PlayerHandednessNatureEnum.Right) ? P_0.Ball.LaunchDirection : (0.0 - P_0.Ball.LaunchDirection));
			List<string> log11 = P_0.Log;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler11 = new DefaultInterpolatedStringHandler(84, 1);
			defaultInterpolatedStringHandler11.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(5696));
			defaultInterpolatedStringHandler11.AppendFormatted(P_0.Club.ClubAnglePath);
			log11.Add(defaultInterpolatedStringHandler11.ToStringAndClear());
		}
		SetDefaultClubType(defaultClubType);
	}

	private void dDdL3HadyU(ref GICTSShotData P_0)
	{
		P_0.ball_back_spin_ = (float.IsNaN(P_0.ball_back_spin_) ? 0f : P_0.ball_back_spin_);
		P_0.ball_direction_ = (float.IsNaN(P_0.ball_direction_) ? 0f : P_0.ball_direction_);
		P_0.ball_launch_angle_ = (float.IsNaN(P_0.ball_launch_angle_) ? 0f : P_0.ball_launch_angle_);
		P_0.ball_side_spin_ = (float.IsNaN(P_0.ball_side_spin_) ? 0f : P_0.ball_side_spin_);
		P_0.ball_speed_ = (float.IsNaN(P_0.ball_speed_) ? 0f : P_0.ball_speed_);
		P_0.ball_spin_axis_ = (float.IsNaN(P_0.ball_spin_axis_) ? 0f : P_0.ball_spin_axis_);
		P_0.ball_total_spin_ = (float.IsNaN(P_0.ball_total_spin_) ? 0f : P_0.ball_total_spin_);
		P_0.club_attack_angle_ = (float.IsNaN(P_0.club_attack_angle_) ? 0f : P_0.club_attack_angle_);
		P_0.club_path_ = (float.IsNaN(P_0.club_path_) ? 0f : P_0.club_path_);
		P_0.club_speed_ = (float.IsNaN(P_0.club_speed_) ? 0f : P_0.club_speed_);
		P_0.tee_height_ = (float.IsNaN(P_0.tee_height_) ? 0f : P_0.tee_height_);
	}

	private double wnhLlOowI2(double P_0)
	{
		double num = Math.Abs(Settings.InsertSettings.RightHandedInsertPositionFromCenter) + Math.Abs(Settings.InsertSettings.LeftHandedInsertPositionFromCenter);
		double num2 = Settings.InsertSettings.RightHandedInsertPositionFromCenter + num / 2.0;
		double num3 = Settings.InsertSettings.DistanceBetweenInsertsInch / 12.0 / num;
		double value = Settings.InsertSettings.DistanceBetweenInsertsInch / 12.0 / 2.0;
		double num4 = num2 - P_0;
		double num5 = num4 * num3;
		KlonHghO7Z(num5);
		ICircularLogService circularLogService = k6On2yqTS7;
		if (circularLogService != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(123, 7);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(5868));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(5904));
			defaultInterpolatedStringHandler.AppendFormatted(num5);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(5930));
			defaultInterpolatedStringHandler.AppendFormatted(num);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(5952));
			defaultInterpolatedStringHandler.AppendFormatted(num2);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(5982));
			defaultInterpolatedStringHandler.AppendFormatted(num3);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6016));
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6068));
			defaultInterpolatedStringHandler.AppendFormatted(num4);
			circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return num5;
	}

	private void N5xLiAH1LL()
	{
		k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6142));
		string simulatorAppShotLogFilenameE6Connect = IDRAConstant.SimulatorAppShotLogFilenameE6Connect;
		try
		{
			Directory.CreateDirectory(Path.GetDirectoryName(simulatorAppShotLogFilenameE6Connect));
			using FileStream fileStream = File.Open(simulatorAppShotLogFilenameE6Connect, FileMode.Create, FileAccess.Write, FileShare.Write);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6202));
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6244));
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			fileStream.Write(Encoding.ASCII.GetBytes(text), 0, text.Length);
			text = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6252);
			fileStream.Write(Encoding.ASCII.GetBytes(text), 0, text.Length);
			fileStream.Close();
			k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6316));
		}
		catch (Exception ex)
		{
			k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6366) + ex.Message);
		}
	}

	private void W6wLQ2HvWH(CTSShotData P_0)
	{
		double value = Math.Round(P_0.Club.ClubHeadSpeed / P_0.Ball.BallSpeed * 100.0, 0);
		ICircularLogService circularLogService = k6On2yqTS7;
		if (circularLogService != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 3);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6472));
			defaultInterpolatedStringHandler.AppendFormatted(Math.Round(P_0.Ball.LaunchDirection, 2));
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6522));
			defaultInterpolatedStringHandler.AppendFormatted(Math.Round(P_0.Ball.LaunchAngle, 2));
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6556));
			defaultInterpolatedStringHandler.AppendFormatted(Math.Round(P_0.Ball.BallSpeed, 2));
			circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		ICircularLogService circularLogService2 = k6On2yqTS7;
		if (circularLogService2 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(49, 5);
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6576));
			defaultInterpolatedStringHandler2.AppendFormatted(Math.Round(P_0.Club.ClubAngleFace, 2));
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6628));
			defaultInterpolatedStringHandler2.AppendFormatted(Math.Round(P_0.Club.ClubAnglePath, 2));
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6556));
			defaultInterpolatedStringHandler2.AppendFormatted(Math.Round(P_0.Club.ClubHeadSpeed, 2));
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6646));
			defaultInterpolatedStringHandler2.AppendFormatted(value);
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6654));
			defaultInterpolatedStringHandler2.AppendFormatted(Math.Round(P_0.Club.ClubAngleOfAttack, 2));
			circularLogService2.Log(defaultInterpolatedStringHandler2.ToStringAndClear());
		}
		P_0.Log.ForEach(delegate(string text)
		{
			k6On2yqTS7?.Log(text ?? "");
		});
	}

	public void PrintGICTSShotData(GICTSShotData shotJson)
	{
		ICircularLogService circularLogService = k6On2yqTS7;
		if (circularLogService != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6674));
			defaultInterpolatedStringHandler.AppendFormatted(shotJson.ball_direction_);
			circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		ICircularLogService circularLogService2 = k6On2yqTS7;
		if (circularLogService2 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(19, 1);
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6710));
			defaultInterpolatedStringHandler2.AppendFormatted(shotJson.ball_launch_angle_);
			circularLogService2.Log(defaultInterpolatedStringHandler2.ToStringAndClear());
		}
		ICircularLogService circularLogService3 = k6On2yqTS7;
		if (circularLogService3 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(12, 1);
			defaultInterpolatedStringHandler3.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6752));
			defaultInterpolatedStringHandler3.AppendFormatted(shotJson.ball_speed_);
			circularLogService3.Log(defaultInterpolatedStringHandler3.ToStringAndClear());
		}
		ICircularLogService circularLogService4 = k6On2yqTS7;
		if (circularLogService4 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(19, 1);
			defaultInterpolatedStringHandler4.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6780));
			defaultInterpolatedStringHandler4.AppendFormatted(shotJson.club_attack_angle_);
			circularLogService4.Log(defaultInterpolatedStringHandler4.ToStringAndClear());
		}
		ICircularLogService circularLogService5 = k6On2yqTS7;
		if (circularLogService5 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler5 = new DefaultInterpolatedStringHandler(11, 1);
			defaultInterpolatedStringHandler5.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6822));
			defaultInterpolatedStringHandler5.AppendFormatted(shotJson.club_path_);
			circularLogService5.Log(defaultInterpolatedStringHandler5.ToStringAndClear());
		}
		ICircularLogService circularLogService6 = k6On2yqTS7;
		if (circularLogService6 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler6 = new DefaultInterpolatedStringHandler(12, 1);
			defaultInterpolatedStringHandler6.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(6848));
			defaultInterpolatedStringHandler6.AppendFormatted(shotJson.club_speed_);
			circularLogService6.Log(defaultInterpolatedStringHandler6.ToStringAndClear());
		}
	}

	public async Task SimulateLastShot()
	{
		InitLocalAPI();
		DirectoryInfo lastShotDirectory = kdUnEFq6qj.GetLastShotDirectory(IDRAConstant.GICTSSamplesResultsFolder);
		FileInfo fileInfo = lastShotDirectory.GetFiles(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(20468)).FirstOrDefault();
		if (fileInfo == null)
		{
			k6On2yqTS7.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(20492), LogLevel.Warning);
			return;
		}
		string name = lastShotDirectory.Name;
		CTSShotData cTSShotData = await ReadShot(name, fileInfo);
		if (cTSShotData != null)
		{
			k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(20576));
			OnNewShot(cTSShotData);
		}
	}

	public void SendDebugAnalyseShot()
	{
		GetSafelyLightInterface()?.SendDebugShot();
	}

	public async Task<CTSShotData> ReadShot(string shotName, FileInfo shotPath)
	{
		CTSShotData shot = new CTSShotData
		{
			FullFilename = shotPath.FullName,
			ShotName = shotName
		};
		k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(20030) + shot.FullFilename);
		try
		{
			await TLsnexHrM5.LoadXmlDocument(shotPath.FullName);
			shot.Ball = new BallData
			{
				LaunchDirection = TLsnexHrM5.ReadNodeValue<double>(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(20062)),
				LaunchAngle = TLsnexHrM5.ReadNodeValue<double>(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(20106)),
				BallSpeed = TLsnexHrM5.ReadNodeValue<double>(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(20154))
			};
			shot.Club = new ClubData
			{
				ClubAngleOfAttack = TLsnexHrM5.ReadNodeValue<double>(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(20190)),
				ClubAnglePath = TLsnexHrM5.ReadNodeValue<double>(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(20238)),
				ClubHeadSpeed = TLsnexHrM5.ReadNodeValue<double>(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(20272))
			};
			string text = TLsnexHrM5.ReadNodeValue<string>(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(20308));
			if (!(text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2688)))
			{
				if (text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(20350))
				{
					shot.PlayerHandedness = PlayerHandednessNatureEnum.Right;
				}
				else
				{
					shot.PlayerHandedness = PlayerHandednessNatureEnum.Unknown;
				}
			}
			else
			{
				shot.PlayerHandedness = PlayerHandednessNatureEnum.Left;
			}
			k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(20364));
		}
		catch (Exception ex)
		{
			k6On2yqTS7?.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(20398) + ex.Message, LogLevel.Error);
			return null;
		}
		return shot;
	}

	[CompilerGenerated]
	private async Task? mxtLPrBrUB()
	{
		DefaultSettings = await wMGnoqajvY.LoadSettings(IDRAConstant.GICTSDefaultSettingsFilePath);
		Settings = await wMGnoqajvY.LoadSettings(IDRAConstant.GICTSSettingsFilePath);
		f1FLyPIF7N();
		if (!GIToolkit.Services.JsonPropertyComparer.IsJsonPropSameAsSavedFile(DefaultSettings, IDRAConstant.GICTSDefaultSettingsFilePath))
		{
			await wMGnoqajvY.SaveSettings(DefaultSettings, IDRAConstant.GICTSDefaultSettingsFilePath);
		}
		if (!GIToolkit.Services.JsonPropertyComparer.IsJsonPropSameAsSavedFile(Settings, IDRAConstant.GICTSSettingsFilePath))
		{
			await wMGnoqajvY.SaveSettings(Settings, IDRAConstant.GICTSSettingsFilePath);
		}
		await TryOverwriteSpinSettings();
		await wMGnoqajvY.MonitorSettings(IDRAConstant.GICTSSettingsFilePath);
		IGICTSSettingsWrapper iGICTSSettingsWrapper = wMGnoqajvY;
		iGICTSSettingsWrapper.OnSettingsModified = (Action<GICTSSettings, FileInfo>)Delegate.Combine(iGICTSSettingsWrapper.OnSettingsModified, new Action<GICTSSettings, FileInfo>(OnReloadSettings));
	}

	[CompilerGenerated]
	private void UwTLGt1wNe(SimCommandEnvironmentDataModifiedMsg P_0)
	{
		LastEnvironmentData = P_0;
	}

	[CompilerGenerated]
	private void aEhLqxTFGt(PlayerHandednessNatureEnum P_0, ClubTypeEnum P_1, string P_2)
	{
		OkwnAqWG3R = P_0;
		CurrentClubType = P_1;
		CurrentPlayerName = P_2;
	}

	[CompilerGenerated]
	private async void OoOLmBh1c5(GSProComputeData P_0)
	{
		if (OnGameComputeData != null)
		{
			await OnGameComputeData(P_0);
		}
	}

	[CompilerGenerated]
	private async void HwBL2p7TDL(string P_0)
	{
		if (OnFirstTee != null)
		{
			await OnFirstTee(P_0);
		}
	}

	[CompilerGenerated]
	private void yMcLFVUtJ5(bool P_0)
	{
		OnGSProScorecardIsVisible?.Invoke(P_0);
	}

	[CompilerGenerated]
	private void V29LxCJgem(bool P_0)
	{
		OnGSPROOSKVisible?.Invoke(P_0);
	}

	[CompilerGenerated]
	private void iStLEqRs6X(SimCommandEnvironmentDataModifiedMsg P_0)
	{
		LastEnvironmentData = P_0;
	}

	[CompilerGenerated]
	private void x9ZLo23MQD(PlayerHandednessNatureEnum P_0, ClubTypeEnum P_1, string P_2)
	{
		OkwnAqWG3R = P_0;
	}

	[CompilerGenerated]
	private async void iWSLX9BIrJ(GSProComputeData P_0)
	{
		if (OnGameComputeData != null)
		{
			await OnGameComputeData(P_0);
		}
	}

	[CompilerGenerated]
	private async void vNtLeSjktw(string P_0)
	{
		if (OnFirstTee != null)
		{
			await OnFirstTee(P_0);
		}
	}

	[CompilerGenerated]
	private void QwpL0cP2hL(bool P_0)
	{
		OnGSProScorecardIsVisible?.Invoke(P_0);
	}

	[CompilerGenerated]
	private void CRULRNudop(bool P_0)
	{
		OnGSPROOSKVisible?.Invoke(P_0);
	}

	[CompilerGenerated]
	private async Task? nMZLzwb6PS()
	{
		await (await FileProcessCommunication.GetInstanceAsync(new IDRAZGISCommunication(), k6On2yqTS7)).WriteMessage(IDRAZGISCommunication.CommunicationCode.IDRAOnNewShot);
	}

	[CompilerGenerated]
	private void iKhnwCwj2Y(string P_0)
	{
		k6On2yqTS7?.Log(P_0 ?? "");
	}
}
