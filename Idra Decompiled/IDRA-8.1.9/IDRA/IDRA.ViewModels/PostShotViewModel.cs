using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using E2ss4tufB1n6piMD1F;
using GICTS.Core;
using GICTS.Data;
using GICTSCore.Data;
using GICTSCore.Services;
using GIToolkit.Services;
using GhU84wwqvI4UZ3pBfu;
using IDRA.Auxiliary.Helpers;
using IDRA.Auxiliary.Messages;
using IDRA.Auxiliary.Navigations;
using IDRA.Internationalization;
using IDRA.Models;
using IDRASharedModels;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using sxB8TYTZ87aKuujytY;
using zJ8L6GrwCFaej1bjN0;

namespace IDRA.ViewModels;

public class PostShotViewModel : ObservableRecipient, IViewModel
{
	public static class StatsDirection
	{
		public const string Open = "Open";

		public const string Close = "Close";

		public const string OutIn = "OutIn";

		public const string InOut = "InOut";

		public const string Right = "Right";

		public const string Left = "Left";

		public const string Toe = "Toe";

		public const string Center = "Center";

		public const string Heel = "Heel";

		public const string Unknown = "Unknown";
	}

	private class vJ0qqvtp9ngJf7Gu7q
	{
		[SpecialName]
		public static string Dvh0nbPWI9()
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(14766);
		}

		[SpecialName]
		public static string SQG0WoVi8V()
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(14952);
		}

		[SpecialName]
		public static string qhS05HpcQm()
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(15128);
		}

		[SpecialName]
		public static string j8A7soStZ0()
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(15316);
		}

		[SpecialName]
		public static string IbY7dSpafy()
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(15494);
		}

		[SpecialName]
		public static string tib7EeH2T8()
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(15678);
		}

		[SpecialName]
		public static string aOx7awF203()
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(15872);
		}

		[SpecialName]
		public static string XmB7CMEg1D()
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(16058);
		}

		[SpecialName]
		public static string SQI77HKteX()
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(16234);
		}

		[SpecialName]
		public static string GcM78n3eiU()
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(16422);
		}

		[SpecialName]
		public static string DZp7FQ9Oel()
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(16600);
		}

		[SpecialName]
		public static string mmk76imNVs()
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(16784);
		}

		[SpecialName]
		public static string uOc7uSSl7L()
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(16978);
		}

		[SpecialName]
		public static string Eif7OyUu3e()
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(17160);
		}

		[SpecialName]
		public static string h7G7PZQqKU()
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(17332);
		}

		[SpecialName]
		public static string lfA7r1IDTY()
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(17516);
		}

		[SpecialName]
		public static string uBp7ZGpwkJ()
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(17690);
		}

		[SpecialName]
		public static string T4n7kwdWit()
		{
			return QQXBLjLprwI58ya4VR.y8v8TMFOCb(17870);
		}

		public vJ0qqvtp9ngJf7Gu7q()
		{
			RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
			base._002Ector();
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass105_0
	{
		public double[] bDWIs38aZ2;

		public _003C_003Ec__DisplayClass105_0()
		{
			RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
			base._002Ector();
		}

		internal double Yov7z5HU0o(double x)
		{
			return x - bDWIs38aZ2[0];
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass106_0
	{
		public int b49IdLgMme;

		public _003C_003Ec__DisplayClass106_0()
		{
			RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
			base._002Ector();
		}

		internal double tbeIxgjl4P(double p)
		{
			return p * (double)b49IdLgMme;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass72_0
	{
		public PostShotViewModel TPBIC4Sbkw;

		public INavigationService<VM> QLHI0Z0kAa;

		public _003C_003Ec__DisplayClass72_0()
		{
			RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
			base._002Ector();
		}

		internal async Task<(bool, string)>? chIIHV9BWZ()
		{
			return await ManagerSettings.Instance.SaveEnablePostShotSetting(TPBIC4Sbkw.ManagerSettings.UseGolfInPostShotInGame || TPBIC4Sbkw.ManagerSettings.UseGolfInPostShotInPractice);
		}

		internal async Task<IdraMode>? EMXIEHcVm4()
		{
			return await TPBIC4Sbkw.wHIEUmA3ej.GetCurrentMode();
		}

		internal void OaGIQk1ef7(object o, NavigatePostShotViewMessage var)
		{
			TPBIC4Sbkw.XbOENMRYkq = var.DisableAutoContinueTimer;
			TPBIC4Sbkw.tDgEfIpse2.Set();
			if (!TPBIC4Sbkw.eGPEW37Fvk)
			{
				TPBIC4Sbkw.BcnHYoSUm1(_0020: true);
				QLHI0Z0kAa.NavigateTo(VM.PostShot);
			}
			TPBIC4Sbkw.d5pEoTSM7B = true;
			TPBIC4Sbkw.N0jEKLNINE.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18472));
		}

		internal void UjVIaHwG9Q(object o, tDSRbrcOQu5Paq7lMy var)
		{
			TPBIC4Sbkw.N0jEKLNINE.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18574));
			TPBIC4Sbkw.y72H9KjJwj();
		}

		internal async Task tKZIqUNZk7(string s, int i)
		{
			TPBIC4Sbkw.N0jEKLNINE.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(21322));
			TPBIC4Sbkw.tDgEfIpse2.Set();
			await Task.CompletedTask;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass99_0
	{
		public double gADIMhnC6Q;

		public double G9FIPaH8ul;

		public double uFbIcZPFdB;

		public double xSGIrs99qy;

		public double RNOIA0Rk07;

		public double XfTIZqKu3u;

		public double wJRIlxl4Y0;

		public double atOIkvaXW5;

		public double jY6I22CV4h;

		public double JsFIyHhmcj;

		public double W3iIg2VdlE;

		public _003C_003Ec__DisplayClass99_0()
		{
			RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
			base._002Ector();
		}

		internal double ta3I7p2F9d(ShotDataForHistory shot)
		{
			return Math.Pow(shot.CarryDistance - gADIMhnC6Q, 2.0);
		}

		internal double EioIIl91Ej(ShotDataForHistory shot)
		{
			return Math.Pow(shot.CarryRaw - G9FIPaH8ul, 2.0);
		}

		internal double do3I89TPPM(ShotDataForHistory shot)
		{
			return Math.Pow(shot.CarryGame - uFbIcZPFdB, 2.0);
		}

		internal double MOmIR86HxG(ShotDataForHistory shot)
		{
			return Math.Pow(shot.Offline - xSGIrs99qy, 2.0);
		}

		internal double vGQIF9BeF2(ShotDataForHistory shot)
		{
			return Math.Pow(shot.TotalDistance - RNOIA0Rk07, 2.0);
		}

		internal double E1mIbSDVGH(ShotDataForHistory shot)
		{
			return Math.Pow(shot.Deviation - XfTIZqKu3u, 2.0);
		}

		internal double WHOI6g6nmU(ShotDataForHistory shot)
		{
			return Math.Pow(shot.Apex - wJRIlxl4Y0, 2.0);
		}

		internal double WCAImI8Gx0(ShotDataForHistory shot)
		{
			return Math.Pow(shot.ClubSpeed - atOIkvaXW5, 2.0);
		}

		internal double u5qIucGVYx(ShotDataForHistory shot)
		{
			return Math.Pow(shot.BallSpeed - jY6I22CV4h, 2.0);
		}

		internal double ikWIJHmKw4(ShotDataForHistory shot)
		{
			return Math.Pow(shot.SmashFactor - JsFIyHhmcj, 2.0);
		}

		internal double USiIOXMMKv(ShotDataForHistory shot)
		{
			return Math.Pow(shot.Score - W3iIg2VdlE, 2.0);
		}
	}

	[CompilerGenerated]
	private readonly PostShotMediaPlayerViewModel n4CEyPt7Ec;

	[CompilerGenerated]
	private PostShotProperties IZgEgaVsZU;

	[CompilerGenerated]
	private PostShotDataToDisplay TiDE4SWswe;

	[CompilerGenerated]
	private ISeries[] uZEE3gXJ1t;

	[CompilerGenerated]
	private Axis[] jZBEtcPxLn;

	[CompilerGenerated]
	private Axis[] v3REjDk4Ae;

	[CompilerGenerated]
	private ISeries[] GWUEB13GVm;

	[CompilerGenerated]
	private Axis[] HyKEDH6SZZ;

	[CompilerGenerated]
	private Axis[] yNQEeoLdS2;

	private readonly INavigationService<VM> DIQEp3aCaT;

	private readonly IGICTSDirector J8WE1roHDr;

	private readonly ICircularLogService N0jEKLNINE;

	private readonly IIdraModeService wHIEUmA3ej;

	private readonly IMessagingService N0OEVmqe1I;

	private readonly IdraMode uVkEG0UaNH;

	private Timer lNrEXFSv3k;

	private TimeSpan sx9E9aAKl4;

	private DateTime z40ELHSHrf;

	private DateTime USVETtsZG2;

	private bool XbOENMRYkq;

	private CTSShotData fZKEwca882;

	private SimCommandShotCompletedMsg lvtEY0aqwi;

	private GSProStatData KiqEvnl0Uo;

	private GSProStatData cHBEh3B2Ne;

	private Dictionary<string, Dictionary<ClubTypeEnum, List<ShotDataForHistory>>> gD0EScnAKG;

	private bool mUdEi9H8XB;

	private readonly AsyncManualResetEvent co7EnjCC9B;

	private readonly AsyncManualResetEvent tDgEfIpse2;

	private bool eGPEW37Fvk;

	private bool d5pEoTSM7B;

	public ManagerSettings ManagerSettings => ManagerSettings.Instance;

	public PostShotMediaPlayerViewModel PostShotMediaPlayer
	{
		[CompilerGenerated]
		get
		{
			return n4CEyPt7Ec;
		}
	}

	public PostShotProperties PostShotProps
	{
		[CompilerGenerated]
		get
		{
			return IZgEgaVsZU;
		}
		[CompilerGenerated]
		set
		{
			IZgEgaVsZU = value;
		}
	}

	public PostShotDataToDisplay PostShotData
	{
		[CompilerGenerated]
		get
		{
			return TiDE4SWswe;
		}
		[CompilerGenerated]
		set
		{
			TiDE4SWswe = value;
		}
	}

	public ISeries[] TopViewGraphSeries
	{
		[CompilerGenerated]
		get
		{
			return uZEE3gXJ1t;
		}
		[CompilerGenerated]
		set
		{
			uZEE3gXJ1t = value;
		}
	}

	public Axis[] TopViewGraphXAxes
	{
		[CompilerGenerated]
		get
		{
			return jZBEtcPxLn;
		}
		[CompilerGenerated]
		private set
		{
			jZBEtcPxLn = value;
		}
	}

	public Axis[] TopViewGraphYAxes
	{
		[CompilerGenerated]
		get
		{
			return v3REjDk4Ae;
		}
		[CompilerGenerated]
		private set
		{
			v3REjDk4Ae = value;
		}
	}

	public ISeries[] SideViewGraphSeries
	{
		[CompilerGenerated]
		get
		{
			return GWUEB13GVm;
		}
		[CompilerGenerated]
		private set
		{
			GWUEB13GVm = value;
		}
	}

	public Axis[] SideViewGraphXAxes
	{
		[CompilerGenerated]
		get
		{
			return HyKEDH6SZZ;
		}
		[CompilerGenerated]
		private set
		{
			HyKEDH6SZZ = value;
		}
	}

	public Axis[] SideViewGraphYAxes
	{
		[CompilerGenerated]
		get
		{
			return yNQEeoLdS2;
		}
		[CompilerGenerated]
		private set
		{
			yNQEeoLdS2 = value;
		}
	}

	public bool IsPutter
	{
		get
		{
			CTSShotData cTSShotData = fZKEwca882;
			if (cTSShotData == null)
			{
				return false;
			}
			return cTSShotData.ClubNature == ClubNatureEnum.PUTTER;
		}
	}

	public ICommand MouseMovedCommand => new RelayCommand(delegate
	{
		qgOHijMqj1();
	});

	public ICommand LoadedCommand => new RelayCommand(delegate
	{
		if (mUdEi9H8XB)
		{
			if (!XbOENMRYkq)
			{
				Task.Run((Func<Task?>)GOsHn8C3o0);
			}
			else
			{
				PostShotProps.RemainingTimeDisplay = "";
			}
			XbOENMRYkq = false;
			co7EnjCC9B.Reset();
			if (d5pEoTSM7B)
			{
				Task.Run((Func<Task?>)PostShotMediaPlayer.OpenMediaPlayerPostShotVideo);
				d5pEoTSM7B = false;
			}
			qgOHijMqj1();
		}
	});

	public ICommand NavigateToShotHistory => new AsyncRelayCommand((Func<Task>)async delegate
	{
		await QneEqQ1H4V(_0020: false);
		N0OEVmqe1I.Send(new hkynCxmFLwLsNkH4nK(gD0EScnAKG));
		DIQEp3aCaT.NavigateTo(VM.PostShotHistory);
	});

	public ICommand NavigateToSettings => new AsyncRelayCommand((Func<Task>)async delegate
	{
		await QneEqQ1H4V(_0020: false);
		DIQEp3aCaT.NavigateTo(VM.PostShotSettings);
	});

	public ICommand MulliganCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		AutomaticUserInput.SendKey(IDRAConstant.GSProProcessName, 77u, maintain_ctrl: true);
		await QneEqQ1H4V(_0020: true);
		DIQEp3aCaT.NavigateTo(VM.Main);
	});

	public ICommand ContinueCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		await QneEqQ1H4V(_0020: true);
		DIQEp3aCaT.NavigateTo(VM.Main);
	});

	[SpecialName]
	private bool mnqEPJucH7()
	{
		if (!ManagerSettings.Instance.UseGolfInPostShotInPractice)
		{
			return ManagerSettings.Instance.UseGolfInPostShotInGame;
		}
		return true;
	}

	[SpecialName]
	private int JD4ErhDrfc()
	{
		return checked((int)TimeSpan.FromSeconds(2.0).TotalMilliseconds);
	}

	[SpecialName]
	private int FTBEZvZJqp()
	{
		return checked((int)TimeSpan.FromSeconds(15.0).TotalMilliseconds);
	}

	[SpecialName]
	private bool XWJEk5LFpY()
	{
		if (!(DIQEp3aCaT.Current is PostShotViewModel) && !(DIQEp3aCaT.Current is PostShotSettingsViewModel))
		{
			return DIQEp3aCaT.Current is PostShotHistoryViewModel;
		}
		return true;
	}

	public PostShotViewModel(INavigationService<VM> navigationService, IGICTSDirector gICTSDirector, ICircularLogService circularLogService, IIdraModeService idraModeService, IMessagingService messagingService, PostShotMediaPlayerViewModel postShotMediaPlayerViewModel)
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		KiqEvnl0Uo = new GSProStatData();
		cHBEh3B2Ne = new GSProStatData();
		gD0EScnAKG = new Dictionary<string, Dictionary<ClubTypeEnum, List<ShotDataForHistory>>>();
		co7EnjCC9B = new AsyncManualResetEvent();
		tDgEfIpse2 = new AsyncManualResetEvent();
		_003C_003Ec__DisplayClass72_0 CS_0024_003C_003E8__locals17 = new _003C_003Ec__DisplayClass72_0();
		CS_0024_003C_003E8__locals17.QLHI0Z0kAa = navigationService;
		base._002Ector();
		CS_0024_003C_003E8__locals17.TPBIC4Sbkw = this;
		DIQEp3aCaT = CS_0024_003C_003E8__locals17.QLHI0Z0kAa;
		J8WE1roHDr = gICTSDirector;
		N0jEKLNINE = circularLogService;
		wHIEUmA3ej = idraModeService;
		N0OEVmqe1I = messagingService;
		mUdEi9H8XB = J8WE1roHDr.Settings.UseGSPro;
		if (!mUdEi9H8XB)
		{
			Task.Run(async () => await ManagerSettings.Instance.SaveEnablePostShotSetting(savePostShotVideo: false)).Wait();
			return;
		}
		Task.Run(async () => await ManagerSettings.Instance.SaveEnablePostShotSetting(CS_0024_003C_003E8__locals17.TPBIC4Sbkw.ManagerSettings.UseGolfInPostShotInGame || CS_0024_003C_003E8__locals17.TPBIC4Sbkw.ManagerSettings.UseGolfInPostShotInPractice)).Wait();
		uVkEG0UaNH = Task.Run(async () => await CS_0024_003C_003E8__locals17.TPBIC4Sbkw.wHIEUmA3ej.GetCurrentMode()).Result;
		if (uVkEG0UaNH == IdraMode.ShotRegistration)
		{
			return;
		}
		n4CEyPt7Ec = postShotMediaPlayerViewModel;
		PostShotMediaPlayer.ListenOnPostShotEvent(mnqEPJucH7());
		ManagerSettings instance = ManagerSettings.Instance;
		instance.OnManagerSettingsReload = (Action)Delegate.Combine(instance.OnManagerSettingsReload, new Action(y72H9KjJwj));
		N0OEVmqe1I.Register(this, delegate(object o, NavigatePostShotViewMessage var)
		{
			CS_0024_003C_003E8__locals17.TPBIC4Sbkw.XbOENMRYkq = var.DisableAutoContinueTimer;
			CS_0024_003C_003E8__locals17.TPBIC4Sbkw.tDgEfIpse2.Set();
			if (!CS_0024_003C_003E8__locals17.TPBIC4Sbkw.eGPEW37Fvk)
			{
				CS_0024_003C_003E8__locals17.TPBIC4Sbkw.BcnHYoSUm1(_0020: true);
				CS_0024_003C_003E8__locals17.QLHI0Z0kAa.NavigateTo(VM.PostShot);
			}
			CS_0024_003C_003E8__locals17.TPBIC4Sbkw.d5pEoTSM7B = true;
			CS_0024_003C_003E8__locals17.TPBIC4Sbkw.N0jEKLNINE.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18472));
		});
		N0OEVmqe1I.Register<tDSRbrcOQu5Paq7lMy>(this, delegate
		{
			CS_0024_003C_003E8__locals17.TPBIC4Sbkw.N0jEKLNINE.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18574));
			CS_0024_003C_003E8__locals17.TPBIC4Sbkw.y72H9KjJwj();
		});
		IGICTSDirector j8WE1roHDr = J8WE1roHDr;
		j8WE1roHDr.OnShotReceiveFromGame = (Func<SimCommandShotCompletedMsg, Task>)Delegate.Combine(j8WE1roHDr.OnShotReceiveFromGame, new Func<SimCommandShotCompletedMsg, Task>(NMTHSutgjW));
		IGICTSDirector j8WE1roHDr2 = J8WE1roHDr;
		j8WE1roHDr2.OnNewShotSent = (Func<CTSShotData, Task>)Delegate.Combine(j8WE1roHDr2.OnNewShotSent, new Func<CTSShotData, Task>(aFKHwDceZf));
		IGICTSDirector j8WE1roHDr3 = J8WE1roHDr;
		j8WE1roHDr3.OnGameComputeData = (Func<GSProComputeData, Task>)Delegate.Combine(j8WE1roHDr3.OnGameComputeData, new Func<GSProComputeData, Task>(VjSHNQHxSd));
		IGICTSDirector j8WE1roHDr4 = J8WE1roHDr;
		j8WE1roHDr4.OnFirstTee = (Func<string, Task>)Delegate.Combine(j8WE1roHDr4.OnFirstTee, new Func<string, Task>(rGqHLxCvVL));
		IGICTSDirector j8WE1roHDr5 = J8WE1roHDr;
		j8WE1roHDr5.OnPostShotVideoExported = (Func<string, int, Task>)Delegate.Combine(j8WE1roHDr5.OnPostShotVideoExported, (Func<string, int, Task>)async delegate
		{
			CS_0024_003C_003E8__locals17.TPBIC4Sbkw.N0jEKLNINE.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(21322));
			CS_0024_003C_003E8__locals17.TPBIC4Sbkw.tDgEfIpse2.Set();
			await Task.CompletedTask;
		});
		IGICTSDirector j8WE1roHDr6 = J8WE1roHDr;
		j8WE1roHDr6.OnGSProScorecardIsVisible = (Action<bool>)Delegate.Combine(j8WE1roHDr6.OnGSProScorecardIsVisible, new Action<bool>(omIHXXO3mf));
		BcnHYoSUm1();
		lNrEXFSv3k = new Timer(1000.0)
		{
			AutoReset = true,
			Enabled = false
		};
		lNrEXFSv3k.Elapsed += WSjHfvEZbc;
	}

	private void omIHXXO3mf(bool P_0)
	{
		eGPEW37Fvk = P_0;
		if (eGPEW37Fvk && XWJEk5LFpY())
		{
			ContinueCommand?.Execute(null);
		}
	}

	private void y72H9KjJwj()
	{
		Application current = Application.Current;
		if (current == null)
		{
			return;
		}
		Dispatcher dispatcher = ((DispatcherObject)current).Dispatcher;
		if (dispatcher != null)
		{
			dispatcher.Invoke((Action)delegate
			{
				PostShotMediaPlayer.ListenOnPostShotEvent(mnqEPJucH7());
			});
		}
	}

	private async Task rGqHLxCvVL(string P_0)
	{
		XoOHTvxunV();
		await Task.CompletedTask;
	}

	private void XoOHTvxunV()
	{
		gD0EScnAKG = new Dictionary<string, Dictionary<ClubTypeEnum, List<ShotDataForHistory>>>();
		N0OEVmqe1I.Send(new hkynCxmFLwLsNkH4nK(new Dictionary<string, Dictionary<ClubTypeEnum, List<ShotDataForHistory>>>()));
	}

	private async Task VjSHNQHxSd(GSProComputeData P_0)
	{
		KiqEvnl0Uo.CarryRawDistance = P_0.CarryRaw.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592));
		KiqEvnl0Uo.Offline = P_0.OffLine.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592));
		KiqEvnl0Uo.Apex = P_0.PeakHeight.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592));
		KiqEvnl0Uo.CarryGameDistance = P_0.CarryGame.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592));
		KiqEvnl0Uo.TotalDistance = P_0.TotalLength.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592));
		KiqEvnl0Uo.DescentAngle = P_0.DecentAngle.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592));
		KiqEvnl0Uo.DistanceToPin = P_0.DistanceToPinYrds.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592));
		co7EnjCC9B.Set();
		await Task.CompletedTask;
	}

	private async Task aFKHwDceZf(CTSShotData P_0)
	{
		if (P_0 != null && mnqEPJucH7())
		{
			BcnHYoSUm1();
			fZKEwca882 = P_0;
			OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18646));
			PostShotProps.LeftHanded = P_0.PlayerHandedness == PlayerHandednessNatureEnum.Left && P_0.ClubNature != ClubNatureEnum.PUTTER;
			if (XWJEk5LFpY())
			{
				ContinueCommand?.Execute(null);
			}
			await Task.CompletedTask;
		}
	}

	private void BcnHYoSUm1(bool P_0 = false)
	{
		PostShotData = new PostShotDataToDisplay();
		PostShotProps = new PostShotProperties();
		TopViewGraphSeries = new ISeries[3]
		{
			new LineSeries<ObservablePoint>
			{
				Values = Array.Empty<ObservablePoint>()
			},
			new LineSeries<ObservablePoint>
			{
				Values = Array.Empty<ObservablePoint>()
			},
			new LineSeries<ObservablePoint>
			{
				Values = Array.Empty<ObservablePoint>()
			}
		};
		TopViewGraphXAxes = new Axis[1]
		{
			new Axis()
		};
		TopViewGraphYAxes = new Axis[1]
		{
			new Axis()
		};
		SideViewGraphSeries = new ISeries[3]
		{
			new LineSeries<ObservablePoint>
			{
				Values = Array.Empty<ObservablePoint>()
			},
			new LineSeries<ObservablePoint>
			{
				Values = Array.Empty<ObservablePoint>()
			},
			new LineSeries<ObservablePoint>
			{
				Values = Array.Empty<ObservablePoint>()
			}
		};
		SideViewGraphXAxes = new Axis[1]
		{
			new Axis()
		};
		SideViewGraphYAxes = new Axis[1]
		{
			new Axis()
		};
		if (P_0)
		{
			if (fZKEwca882 != null)
			{
				PostShotProps.LeftHanded = fZKEwca882.PlayerHandedness == PlayerHandednessNatureEnum.Left && fZKEwca882.ClubNature != ClubNatureEnum.PUTTER;
			}
			KiqEvnl0Uo = cHBEh3B2Ne;
			gYMEQMrB06(lvtEY0aqwi);
			lPTHvCVRNK();
			T4dEaZoYhi();
			miNEE2hovJ(lvtEY0aqwi);
			I66HWgJhuK();
			NXyHow8LYT();
			LqiEdJryh9(lvtEY0aqwi);
			OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6486));
			OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6516));
		}
	}

	private void lPTHvCVRNK()
	{
		PostShotData.CarryRawDistance = KiqEvnl0Uo.CarryRawDistance;
		PostShotData.Offline = KiqEvnl0Uo.Offline;
		PostShotData.Apex = KiqEvnl0Uo.Apex;
		PostShotData.CarryGameDistance = KiqEvnl0Uo.CarryGameDistance;
		PostShotData.TotalDistance = KiqEvnl0Uo.TotalDistance;
		PostShotData.DescentAngle = KiqEvnl0Uo.DescentAngle;
		PostShotData.DistanceToPin = KiqEvnl0Uo.DistanceToPin;
		cHBEh3B2Ne = KiqEvnl0Uo;
		if (ManagerSettings.PostShotMetricUnit)
		{
			PostShotData.ToMetric();
		}
	}

	private void cnDHhg6cyL()
	{
		KiqEvnl0Uo = new GSProStatData();
		PostShotData = null;
		PostShotProps = null;
		TopViewGraphSeries = null;
		TopViewGraphXAxes = null;
		TopViewGraphYAxes = null;
		SideViewGraphSeries = null;
		SideViewGraphXAxes = null;
		SideViewGraphYAxes = null;
		OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6516));
		OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6486));
		OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6544));
		OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6584));
		OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6622));
		OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6660));
		OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6702));
		OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6742));
	}

	private async Task NMTHSutgjW(SimCommandShotCompletedMsg P_0)
	{
		if (!mnqEPJucH7() || eGPEW37Fvk)
		{
			return;
		}
		if (PostShotData == null || PostShotProps == null)
		{
			BcnHYoSUm1();
		}
		lvtEY0aqwi = P_0;
		CTSShotData cTSShotData = fZKEwca882;
		if (cTSShotData != null && cTSShotData.PlayerHandedness == PlayerHandednessNatureEnum.Left)
		{
			lvtEY0aqwi.ClubData.ClubAnglePath *= -1.0;
		}
		await ((DispatcherObject)Application.Current).Dispatcher.InvokeAsync<Task>((Func<Task>)async delegate
		{
			try
			{
				lNrEXFSv3k?.Stop();
				if ((J8WE1roHDr.CurrentPlayerName != IDRAConstant.GSProPracticeRangePlayerName && !ManagerSettings.UseGolfInPostShotInGame) || (J8WE1roHDr.CurrentPlayerName == IDRAConstant.GSProPracticeRangePlayerName && !ManagerSettings.UseGolfInPostShotInPractice))
				{
					cnDHhg6cyL();
				}
				else if (!(await co7EnjCC9B.WaitAsync(JD4ErhDrfc())))
				{
					N0jEKLNINE.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18060), LogLevel.Warning);
					cnDHhg6cyL();
				}
				else
				{
					gYMEQMrB06(lvtEY0aqwi);
					lPTHvCVRNK();
					T4dEaZoYhi();
					miNEE2hovJ(lvtEY0aqwi);
					I66HWgJhuK();
					YwXExTdNi0(lvtEY0aqwi);
					NXyHow8LYT();
					LqiEdJryh9(lvtEY0aqwi);
					OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6486));
					OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6516));
					DIQEp3aCaT.NavigateTo(VM.PostShot);
				}
			}
			catch (Exception ex)
			{
				cnDHhg6cyL();
				N0jEKLNINE.Log(ex.Message, LogLevel.Error);
			}
		});
	}

	private void qgOHijMqj1()
	{
		z40ELHSHrf = DateTime.Now;
		USVETtsZG2 = z40ELHSHrf + ManagerSettings.PostShotAutoContinueDuration;
	}

	private async Task GOsHn8C3o0()
	{
		await ((DispatcherObject)Application.Current).Dispatcher.InvokeAsync<Task>((Func<Task>)async delegate
		{
			try
			{
				if (!(await tDgEfIpse2.WaitAsync(FTBEZvZJqp())))
				{
					N0jEKLNINE.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18258), LogLevel.Warning);
				}
				else
				{
					PostShotProps.RemainingTimeDisplay = ManagerSettings.PostShotAutoContinueDuration.TotalSeconds.ToString();
					if (ManagerSettings.PostShotAutoContinueDuration <= TimeSpan.FromSeconds(0.0))
					{
						PostShotProps.RemainingTimeDisplay = "";
					}
					else
					{
						qgOHijMqj1();
						lNrEXFSv3k.Enabled = true;
					}
				}
			}
			catch (Exception ex)
			{
				N0jEKLNINE.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18348) + ex.Message, LogLevel.Error);
			}
		});
	}

	private void WSjHfvEZbc(object P_0, ElapsedEventArgs P_1)
	{
		sx9E9aAKl4 = USVETtsZG2 - DateTime.Now;
		if (PostShotProps != null)
		{
			PostShotProps.RemainingTimeDisplay = Math.Round(Math.Max(sx9E9aAKl4.TotalSeconds, 0.0)).ToString();
		}
		if (!(sx9E9aAKl4 > TimeSpan.Zero))
		{
			ContinueCommand.Execute(null);
		}
	}

	private void I66HWgJhuK()
	{
		switch (fZKEwca882?.GetClubNatureCategory() ?? ClubNatureCategoryEnum.IRON)
		{
		case ClubNatureCategoryEnum.IRON:
			PostShotProps.ClubTopImg = (PostShotProps.LeftHanded ? vJ0qqvtp9ngJf7Gu7q.uOc7uSSl7L() : vJ0qqvtp9ngJf7Gu7q.Eif7OyUu3e());
			PostShotProps.ClubSideImg = (PostShotProps.LeftHanded ? vJ0qqvtp9ngJf7Gu7q.h7G7PZQqKU() : vJ0qqvtp9ngJf7Gu7q.lfA7r1IDTY());
			PostShotProps.ClubTopZoomImg = (PostShotProps.LeftHanded ? vJ0qqvtp9ngJf7Gu7q.T4n7kwdWit() : vJ0qqvtp9ngJf7Gu7q.uBp7ZGpwkJ());
			break;
		case ClubNatureCategoryEnum.WOOD:
			PostShotProps.ClubTopImg = (PostShotProps.LeftHanded ? vJ0qqvtp9ngJf7Gu7q.Dvh0nbPWI9() : vJ0qqvtp9ngJf7Gu7q.SQG0WoVi8V());
			PostShotProps.ClubSideImg = (PostShotProps.LeftHanded ? vJ0qqvtp9ngJf7Gu7q.qhS05HpcQm() : vJ0qqvtp9ngJf7Gu7q.j8A7soStZ0());
			PostShotProps.ClubTopZoomImg = (PostShotProps.LeftHanded ? vJ0qqvtp9ngJf7Gu7q.tib7EeH2T8() : vJ0qqvtp9ngJf7Gu7q.IbY7dSpafy());
			break;
		case ClubNatureCategoryEnum.PUTTER:
			PostShotProps.ClubTopImg = (PostShotProps.LeftHanded ? vJ0qqvtp9ngJf7Gu7q.aOx7awF203() : vJ0qqvtp9ngJf7Gu7q.XmB7CMEg1D());
			PostShotProps.ClubSideImg = (PostShotProps.LeftHanded ? vJ0qqvtp9ngJf7Gu7q.SQI77HKteX() : vJ0qqvtp9ngJf7Gu7q.GcM78n3eiU());
			PostShotProps.ClubTopZoomImg = (PostShotProps.LeftHanded ? vJ0qqvtp9ngJf7Gu7q.mmk76imNVs() : vJ0qqvtp9ngJf7Gu7q.DZp7FQ9Oel());
			break;
		}
	}

	private void NXyHow8LYT()
	{
		try
		{
			_003C_003Ec__DisplayClass99_0 CS_0024_003C_003E8__locals31 = new _003C_003Ec__DisplayClass99_0();
			ClubTypeEnum currentClubType = J8WE1roHDr.CurrentClubType;
			string currentPlayerName = J8WE1roHDr.CurrentPlayerName;
			PSOEsosplQ();
			List<ShotDataForHistory> list = gD0EScnAKG[currentPlayerName][currentClubType];
			if (list.Count > 0)
			{
				CS_0024_003C_003E8__locals31.gADIMhnC6Q = list.Average((ShotDataForHistory shot) => shot.CarryDistance);
				Math.Sqrt(list.Sum((ShotDataForHistory shot) => Math.Pow(shot.CarryDistance - CS_0024_003C_003E8__locals31.gADIMhnC6Q, 2.0)) / (double)list.Count);
				CS_0024_003C_003E8__locals31.G9FIPaH8ul = list.Average((ShotDataForHistory shot) => shot.CarryRaw);
				double value = Math.Sqrt(list.Sum((ShotDataForHistory shot) => Math.Pow(shot.CarryRaw - CS_0024_003C_003E8__locals31.G9FIPaH8ul, 2.0)) / (double)list.Count);
				CS_0024_003C_003E8__locals31.uFbIcZPFdB = list.Average((ShotDataForHistory shot) => shot.CarryGame);
				double value2 = Math.Sqrt(list.Sum((ShotDataForHistory shot) => Math.Pow(shot.CarryGame - CS_0024_003C_003E8__locals31.uFbIcZPFdB, 2.0)) / (double)list.Count);
				CS_0024_003C_003E8__locals31.xSGIrs99qy = list.Average((ShotDataForHistory shot) => shot.Offline);
				double value3 = Math.Sqrt(list.Sum((ShotDataForHistory shot) => Math.Pow(shot.Offline - CS_0024_003C_003E8__locals31.xSGIrs99qy, 2.0)) / (double)list.Count);
				CS_0024_003C_003E8__locals31.RNOIA0Rk07 = list.Average((ShotDataForHistory shot) => shot.TotalDistance);
				double value4 = Math.Sqrt(list.Sum((ShotDataForHistory shot) => Math.Pow(shot.TotalDistance - CS_0024_003C_003E8__locals31.RNOIA0Rk07, 2.0)) / (double)list.Count);
				CS_0024_003C_003E8__locals31.XfTIZqKu3u = list.Average((ShotDataForHistory shot) => shot.Deviation);
				double value5 = Math.Sqrt(list.Sum((ShotDataForHistory shot) => Math.Pow(shot.Deviation - CS_0024_003C_003E8__locals31.XfTIZqKu3u, 2.0)) / (double)list.Count);
				CS_0024_003C_003E8__locals31.wJRIlxl4Y0 = Math.Round(list.Average((ShotDataForHistory shot) => shot.Apex), 1);
				double value6 = Math.Round(Math.Sqrt(list.Sum((ShotDataForHistory shot) => Math.Pow(shot.Apex - CS_0024_003C_003E8__locals31.wJRIlxl4Y0, 2.0)) / (double)list.Count), 1);
				CS_0024_003C_003E8__locals31.atOIkvaXW5 = list.Average((ShotDataForHistory shot) => shot.ClubSpeed);
				double value7 = Math.Sqrt(list.Sum((ShotDataForHistory shot) => Math.Pow(shot.ClubSpeed - CS_0024_003C_003E8__locals31.atOIkvaXW5, 2.0)) / (double)list.Count);
				CS_0024_003C_003E8__locals31.jY6I22CV4h = list.Average((ShotDataForHistory shot) => shot.BallSpeed);
				double value8 = Math.Sqrt(list.Sum((ShotDataForHistory shot) => Math.Pow(shot.BallSpeed - CS_0024_003C_003E8__locals31.jY6I22CV4h, 2.0)) / (double)list.Count);
				CS_0024_003C_003E8__locals31.JsFIyHhmcj = list.Average((ShotDataForHistory shot) => shot.SmashFactor);
				double value9 = Math.Sqrt(list.Sum((ShotDataForHistory shot) => Math.Pow(shot.SmashFactor - CS_0024_003C_003E8__locals31.JsFIyHhmcj, 2.0)) / (double)list.Count);
				CS_0024_003C_003E8__locals31.W3iIg2VdlE = list.Average((ShotDataForHistory shot) => shot.Score);
				Math.Sqrt(list.Sum((ShotDataForHistory shot) => Math.Pow(shot.Score - CS_0024_003C_003E8__locals31.W3iIg2VdlE, 2.0)) / (double)list.Count);
				if (currentClubType == ClubTypeEnum.Wood1 || currentPlayerName == IDRAConstant.GSProPracticeRangePlayerName)
				{
					PostShotData.CarryRawAvgStats = Math.Round(CS_0024_003C_003E8__locals31.G9FIPaH8ul, 1).ToString();
					PostShotData.CarryRawStdStats = Math.Round(value, 1).ToString();
					PostShotData.CarryGameAvgStats = Math.Round(CS_0024_003C_003E8__locals31.uFbIcZPFdB, 1).ToString();
					PostShotData.CarryGameStdStats = Math.Round(value2, 1).ToString();
					PostShotData.OfflineStdStats = Math.Round(value3, 1).ToString();
					PostShotData.OfflineAvgStats = Math.Round(CS_0024_003C_003E8__locals31.xSGIrs99qy, 1).ToString();
					PostShotData.TotalAvgStats = Math.Round(CS_0024_003C_003E8__locals31.RNOIA0Rk07, 1).ToString();
					PostShotData.TotalStdStats = Math.Round(value4, 1).ToString();
					PostShotData.DeviationAvgStats = Math.Round(CS_0024_003C_003E8__locals31.XfTIZqKu3u, 1).ToString();
					PostShotData.DeviationStdStats = Math.Round(value5, 1).ToString();
					PostShotData.ApexAvgStats = Math.Round(CS_0024_003C_003E8__locals31.wJRIlxl4Y0, 1).ToString();
					PostShotData.ApexStdStats = Math.Round(value6, 1).ToString();
					PostShotData.ClubSpeedAvgStats = Math.Round(CS_0024_003C_003E8__locals31.atOIkvaXW5, 1).ToString();
					PostShotData.ClubSpeedStdStats = Math.Round(value7, 1).ToString();
					PostShotData.BallSpeedAvgStats = Math.Round(CS_0024_003C_003E8__locals31.jY6I22CV4h, 1).ToString();
					PostShotData.BallSpeedStdStats = Math.Round(value8, 1).ToString();
					PostShotData.SmashFactorAvgStats = Math.Round(CS_0024_003C_003E8__locals31.JsFIyHhmcj, 1).ToString();
					PostShotData.SmashFactorStdStats = Math.Round(value9, 1).ToString();
				}
				pEvH5cnPQK(currentClubType, currentPlayerName);
			}
		}
		catch (KeyNotFoundException ex)
		{
			qUGHzqXVpV();
			Console.WriteLine(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6782) + ex.Message);
		}
		catch (Exception ex2)
		{
			N0jEKLNINE.Log(ex2.Message, LogLevel.Error);
		}
	}

	private void pEvH5cnPQK(ClubTypeEnum P_0, string P_1)
	{
		if (P_0 != ClubTypeEnum.Wood1 && P_1 != IDRAConstant.GSProPracticeRangePlayerName)
		{
			PostShotProps.StdChar = '\0';
			PostShotProps.AvgString = "";
			qUGHzqXVpV();
		}
		else
		{
			PostShotProps.StdChar = '±';
			PostShotProps.AvgString = QQXBLjLprwI58ya4VR.y8v8TMFOCb(6824);
		}
	}

	private void qUGHzqXVpV()
	{
		PostShotData.EraseShotData();
	}

	private void PSOEsosplQ()
	{
		checked
		{
			try
			{
				string currentPlayerName = J8WE1roHDr.CurrentPlayerName;
				ClubTypeEnum currentClubType = J8WE1roHDr.CurrentClubType;
				double num = 0.0;
				double num2 = 0.0;
				double num3 = 0.0;
				double num4 = 0.0;
				double num5 = 0.0;
				double num6 = 0.0;
				double num7 = 0.0;
				foreach (ShotDataForHistory item in gD0EScnAKG[currentPlayerName][currentClubType])
				{
					num4 += 1.0;
					if (item.ClubBallHitPercent < (float)ManagerSettings.PostShotConsideredCenter && item.ClubBallHitPercent > (float)(-ManagerSettings.PostShotConsideredCenter))
					{
						num2 += 1.0;
					}
					else if (item.ClubBallHitPercent < (float)(-ManagerSettings.PostShotConsideredCenter))
					{
						num3 += 1.0;
					}
					else
					{
						num += 1.0;
					}
				}
				if (num4 < 1.0)
				{
					num5 = 0.0;
					num6 = 0.0;
					num7 = 0.0;
				}
				else
				{
					num5 = Math.Round(num / num4 * 100.0, 1);
					num6 = Math.Round(num2 / num4 * 100.0, 1);
					num7 = Math.Round(num3 / num4 * 100.0, 1);
				}
				PostShotData.AvgBallZoneToe = num5.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5650)) + QQXBLjLprwI58ya4VR.y8v8TMFOCb(6842);
				PostShotData.AvgBallZoneMid = num6.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5650)) + QQXBLjLprwI58ya4VR.y8v8TMFOCb(6842);
				PostShotData.AvgBallZoneHeel = num7.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5650)) + QQXBLjLprwI58ya4VR.y8v8TMFOCb(6842);
			}
			catch (Exception ex)
			{
				N0jEKLNINE.Log(ex.Message, LogLevel.Error);
			}
		}
	}

	private void YwXExTdNi0(SimCommandShotCompletedMsg P_0)
	{
		ShotDataForHistory shotDataForHistory = new ShotDataForHistory
		{
			HideFromAverage = false,
			ClubBallHitPercent = Math.Clamp(fZKEwca882?.ClubBallHitPercent ?? 0f, -100f, 100f),
			CarryGame = double.Parse(PostShotData.CarryGameDistance, CultureInfo.InvariantCulture),
			CarryRaw = double.Parse(PostShotData.CarryRawDistance, CultureInfo.InvariantCulture),
			Offline = double.Parse(PostShotData.Offline, CultureInfo.InvariantCulture),
			TotalDistance = double.Parse(PostShotData.TotalDistance, CultureInfo.InvariantCulture),
			BallSpeed = double.Parse(PostShotData.BallSpeed, CultureInfo.InvariantCulture),
			ClubSpeed = double.Parse(PostShotData.ClubSpeed, CultureInfo.InvariantCulture),
			SmashFactor = double.Parse(PostShotData.SmashFactor, CultureInfo.InvariantCulture),
			LaunchDirection = P_0.BallData.LaunchDirection,
			BallDirectionSide = PostShotData.BallDirectionSide,
			LaunchAngle = double.Parse(PostShotData.LaunchAngle, CultureInfo.InvariantCulture),
			ClubPath = P_0.ClubData.ClubAnglePath,
			ClubPathSide = PostShotData.ClubPathSide,
			FaceAngle = P_0.ClubData.ClubAngleFace,
			ClubFaceSide = PostShotData.ClubFaceSide,
			Apex = double.Parse(PostShotData.Apex, CultureInfo.InvariantCulture),
			DescentAngle = double.Parse(PostShotData.DescentAngle, CultureInfo.InvariantCulture),
			BackSpin = double.Parse(PostShotData.BackSpin, CultureInfo.InvariantCulture),
			SideSpin = P_0.BallData.SideSpin,
			SideSpinSide = PostShotData.SideSpinSide,
			PlayerName = J8WE1roHDr.CurrentPlayerName,
			ShotTime = DateTime.Now
		};
		ClubTypeEnum currentClubType = J8WE1roHDr.CurrentClubType;
		List<ShotDataForHistory> value4;
		if (!gD0EScnAKG.TryGetValue(shotDataForHistory.PlayerName, out var value))
		{
			int num = 1;
			List<ShotDataForHistory> list = new List<ShotDataForHistory>(num);
			CollectionsMarshal.SetCount(list, num);
			CollectionsMarshal.AsSpan(list)[0] = shotDataForHistory;
			List<ShotDataForHistory> value2 = list;
			Dictionary<ClubTypeEnum, List<ShotDataForHistory>> value3 = new Dictionary<ClubTypeEnum, List<ShotDataForHistory>> { { currentClubType, value2 } };
			gD0EScnAKG.Add(shotDataForHistory.PlayerName, value3);
		}
		else if (!value.TryGetValue(currentClubType, out value4))
		{
			int num = 1;
			List<ShotDataForHistory> list2 = new List<ShotDataForHistory>(num);
			CollectionsMarshal.SetCount(list2, num);
			CollectionsMarshal.AsSpan(list2)[0] = shotDataForHistory;
			List<ShotDataForHistory> value5 = list2;
			value.Add(currentClubType, value5);
		}
		else
		{
			value4.Add(shotDataForHistory);
		}
	}

	private void LqiEdJryh9(SimCommandShotCompletedMsg P_0)
	{
		PostShotProps.SideSpinArrowDir = ((!(P_0.BallData.SideSpin < 0.0)) ? 1 : (-1));
		PostShotProps.SideSpinArrowOffset = ((P_0.BallData.SideSpin < 0.0) ? 1 : 0);
	}

	private static double[] etFEH2G4p8(double[] P_0)
	{
		_003C_003Ec__DisplayClass105_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass105_0();
		CS_0024_003C_003E8__locals3.bDWIs38aZ2 = P_0;
		return CS_0024_003C_003E8__locals3.bDWIs38aZ2.Select((double x) => x - CS_0024_003C_003E8__locals3.bDWIs38aZ2[0]).ToArray();
	}

	private void miNEE2hovJ(SimCommandShotCompletedMsg P_0)
	{
		_003C_003Ec__DisplayClass106_0 CS_0024_003C_003E8__locals11 = new _003C_003Ec__DisplayClass106_0();
		CS_0024_003C_003E8__locals11.b49IdLgMme = 1;
		if (PostShotProps.LeftHanded)
		{
			CS_0024_003C_003E8__locals11.b49IdLgMme = -1;
		}
		double[] array2;
		double[] array3;
		double[] array;
		if (fZKEwca882?.Points3D == null)
		{
			array = new double[2]
			{
				0.0,
				(double)CS_0024_003C_003E8__locals11.b49IdLgMme * 0.2
			};
			array2 = new double[2];
			array3 = new double[2];
		}
		else
		{
			array = fZKEwca882.Points3D.Select((Point3D p) => p.x).ToArray();
			array2 = fZKEwca882.Points3D.Select((Point3D p) => p.y).ToArray();
			array3 = fZKEwca882.Points3D.Select((Point3D p) => p.z).ToArray();
		}
		array = etFEH2G4p8(array);
		array2 = etFEH2G4p8(array2);
		array3 = etFEH2G4p8(array3);
		array = array.Select((double p) => p * (double)CS_0024_003C_003E8__locals11.b49IdLgMme).ToArray();
		ObservablePoint[] array4 = new ObservablePoint[array.Length];
		checked
		{
			for (int num = 0; num < array.Length; num++)
			{
				array4[num] = new ObservablePoint(array[num], (double)CS_0024_003C_003E8__locals11.b49IdLgMme * array2[num]);
			}
			ObservablePoint[] array5 = new ObservablePoint[array.Length];
			for (int num2 = 0; num2 < array.Length; num2++)
			{
				array5[num2] = new ObservablePoint(array[num2], array3[num2]);
			}
			TopViewGraphSeries[0] = new LineSeries<ObservablePoint>
			{
				Values = array4,
				Fill = null,
				GeometrySize = 0.0
			};
			ObservablePoint[] array6 = new ObservablePoint[2];
			array6 = ((!PostShotProps.LeftHanded) ? new ObservablePoint[2]
			{
				new ObservablePoint(0.0, 0.0),
				new ObservablePoint(0.0 - Math.Cos(Helper.Deg2Rad(P_0.ClubData.ClubAnglePath)), Math.Sin(Helper.Deg2Rad(P_0.ClubData.ClubAnglePath)))
			} : new ObservablePoint[2]
			{
				new ObservablePoint(0.0, 0.0),
				new ObservablePoint(0.0 - Math.Cos(Helper.Deg2Rad(P_0.ClubData.ClubAnglePath + 180.0)), Math.Sin(Helper.Deg2Rad(P_0.ClubData.ClubAnglePath)))
			});
			TopViewGraphSeries[1] = new LineSeries<ObservablePoint>
			{
				Values = array6,
				Fill = null,
				GeometrySize = 0.0
			};
			ObservablePoint[] array7 = new ObservablePoint[2];
			array7 = new ObservablePoint[2]
			{
				new ObservablePoint(0.0 - Math.Cos(Helper.Deg2Rad(90.0 - P_0.ClubData.ClubAngleFace)), 0.0 - Math.Sin(Helper.Deg2Rad(90.0 - P_0.ClubData.ClubAngleFace))),
				new ObservablePoint(Math.Cos(Helper.Deg2Rad(90.0 - P_0.ClubData.ClubAngleFace)), Math.Sin(Helper.Deg2Rad(90.0 - P_0.ClubData.ClubAngleFace)))
			};
			TopViewGraphSeries[2] = new LineSeries<ObservablePoint>
			{
				Values = array7,
				Fill = null,
				GeometrySize = 0.0
			};
			double? minLimit = (double)CS_0024_003C_003E8__locals11.b49IdLgMme * (0.0 - array4[array4.Length - 1].X);
			double? maxLimit = (double)CS_0024_003C_003E8__locals11.b49IdLgMme * array4[array4.Length - 1].X;
			TopViewGraphXAxes[0] = new Axis
			{
				CustomSeparators = new double[1],
				LabelsPaint = null,
				ShowSeparatorLines = true,
				MaxLimit = maxLimit,
				MinLimit = minLimit,
				SeparatorsPaint = new SolidColorPaint(SKColors.White.WithAlpha(150))
			};
			TopViewGraphYAxes[0] = new Axis
			{
				CustomSeparators = new double[1],
				LabelsPaint = null,
				ShowSeparatorLines = true,
				MaxLimit = maxLimit,
				MinLimit = minLimit,
				SeparatorsPaint = new SolidColorPaint(SKColors.White.WithAlpha(150))
			};
			PostShotProps.ClubAngleTopRotation = P_0.ClubData.ClubAngleFace;
			SideViewGraphSeries[0] = new LineSeries<ObservablePoint>
			{
				Values = array5,
				Fill = null,
				GeometrySize = 0.0
			};
			SideViewGraphXAxes[0] = new Axis
			{
				CustomSeparators = new double[1],
				LabelsPaint = null,
				ShowSeparatorLines = true,
				MinLimit = minLimit,
				MaxLimit = maxLimit,
				SeparatorsPaint = new SolidColorPaint(SKColors.White.WithAlpha(150))
			};
			SideViewGraphYAxes[0] = new Axis
			{
				CustomSeparators = new double[1],
				LabelsPaint = null,
				ShowSeparatorLines = true,
				MinLimit = minLimit,
				MaxLimit = maxLimit,
				SeparatorsPaint = new SolidColorPaint(SKColors.White.WithAlpha(150))
			};
			PostShotProps.GolfBallTopX = (double)CS_0024_003C_003E8__locals11.b49IdLgMme * 105.0;
			PostShotProps.GolfBallTopY = (double)CS_0024_003C_003E8__locals11.b49IdLgMme * (0.0 - array4[array4.Length - 1].Y.Value) / array4[array4.Length - 1].X.Value * 105.0;
			PostShotProps.GolfBallSideX = (double)CS_0024_003C_003E8__locals11.b49IdLgMme * 105.0;
			PostShotProps.GolfBallSideY = (double)CS_0024_003C_003E8__locals11.b49IdLgMme * (0.0 - array5[array5.Length - 1].Y.Value) / array5[array5.Length - 1].X.Value * 105.0;
			OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6486));
		}
	}

	private void gYMEQMrB06(SimCommandShotCompletedMsg P_0)
	{
		PostShotData.LaunchAngle = Math.Abs(Math.Round(P_0.BallData.LaunchAngle, 1)).ToString();
		PostShotData.BackSpin = Math.Abs(Math.Round(P_0.BallData.BackSpin)).ToString();
		PostShotData.ClubFace = Math.Abs(Math.Round(P_0.ClubData.ClubAngleFace, 1)).ToString();
		PostShotData.ClubPath = Math.Abs(Math.Round(P_0.ClubData.ClubAnglePath, 1)).ToString();
		PostShotData.SideSpin = Math.Abs(Math.Round(P_0.BallData.SideSpin)).ToString();
		PostShotData.BallDirection = Math.Abs(Math.Round(P_0.BallData.LaunchDirection, 1)).ToString();
		PostShotData.Deviation = Math.Round(Helper.FeetToYard(P_0.TotalDeviationFeet), 1).ToString();
		PostShotData.ClubSpeed = Math.Round(P_0.ClubData.ClubHeadSpeed, 1).ToString();
		PostShotData.BallSpeed = Math.Round(P_0.BallData.BallSpeed, 1).ToString();
		PostShotData.SmashFactor = Math.Round(P_0.ClubData.SmashFactor, 1).ToString();
		CTSShotData cTSShotData = fZKEwca882;
		if (cTSShotData == null || cTSShotData.ClubNature != ClubNatureEnum.PUTTER)
		{
			PostShotData.SideSpinSide = ((Math.Sign(P_0.BallData.SideSpin) == 1) ? CultureResources.GetValue(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6860)) : CultureResources.GetValue(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6848)));
			PostShotData.BallDirectionSide = ((Math.Sign(P_0.BallData.LaunchDirection) == 1) ? CultureResources.GetValue(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6860)) : CultureResources.GetValue(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6848)));
			PostShotData.ClubPathSide = ((P_0.ClubData.ClubAnglePath > 0.0) ? CultureResources.GetValue(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6888)) : CultureResources.GetValue(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6874)));
			PostShotData.ClubFaceSide = ((!(P_0.ClubData.ClubAngleFace < 0.0)) ? (PostShotProps.LeftHanded ? CultureResources.GetValue(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6914)) : CultureResources.GetValue(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6902))) : (PostShotProps.LeftHanded ? CultureResources.GetValue(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6902)) : CultureResources.GetValue(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6914))));
		}
	}

	private void T4dEaZoYhi()
	{
		PostShotProps.ToeHeeltext = QQXBLjLprwI58ya4VR.y8v8TMFOCb(4478);
		PostShotProps.ClubHitZone = 55.0;
		if (fZKEwca882 == null || fZKEwca882.ClubBallHitPercent == -1f)
		{
			PostShotProps.ToeHeeltext = QQXBLjLprwI58ya4VR.y8v8TMFOCb(4478);
			return;
		}
		if (fZKEwca882.ClubBallHitPercent < (float)ManagerSettings.PostShotConsideredCenter && fZKEwca882.ClubBallHitPercent > (float)checked(-ManagerSettings.PostShotConsideredCenter))
		{
			PostShotProps.ToeHeeltext = CultureResources.GetValue(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6928)) ?? "";
			PostShotProps.BallPositionPercent = string.Empty;
		}
		else
		{
			PostShotProps.ToeHeeltext = ((fZKEwca882.ClubBallHitPercent > 0f) ? (QQXBLjLprwI58ya4VR.y8v8TMFOCb(6944) + CultureResources.GetValue(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6964))) : (QQXBLjLprwI58ya4VR.y8v8TMFOCb(6944) + CultureResources.GetValue(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6952))));
			PostShotProps.BallPositionPercent = $"{Math.Abs(Math.Round(fZKEwca882.ClubBallHitPercent))}";
		}
		PostShotProps.BallPosition = (double)fZKEwca882.ClubBallHitPercent / 100.0;
	}

	private async Task QneEqQ1H4V(bool P_0)
	{
		tDgEfIpse2.Reset();
		await PostShotMediaPlayer.ClosePostShotVideo();
		lNrEXFSv3k?.Stop();
		if (P_0)
		{
			cnDHhg6cyL();
		}
	}

	[CompilerGenerated]
	private void TSUECSfeuc()
	{
		PostShotMediaPlayer.ListenOnPostShotEvent(mnqEPJucH7());
	}

	[CompilerGenerated]
	private void qsUE0YgtS5()
	{
		qgOHijMqj1();
	}

	[CompilerGenerated]
	private void RaXE7pR6uX()
	{
		if (mUdEi9H8XB)
		{
			if (!XbOENMRYkq)
			{
				Task.Run((Func<Task?>)GOsHn8C3o0);
			}
			else
			{
				PostShotProps.RemainingTimeDisplay = "";
			}
			XbOENMRYkq = false;
			co7EnjCC9B.Reset();
			if (d5pEoTSM7B)
			{
				Task.Run((Func<Task?>)PostShotMediaPlayer.OpenMediaPlayerPostShotVideo);
				d5pEoTSM7B = false;
			}
			qgOHijMqj1();
		}
	}

	[CompilerGenerated]
	private async Task QOBEIZcV3t()
	{
		await QneEqQ1H4V(_0020: false);
		N0OEVmqe1I.Send(new hkynCxmFLwLsNkH4nK(gD0EScnAKG));
		DIQEp3aCaT.NavigateTo(VM.PostShotHistory);
	}

	[CompilerGenerated]
	private async Task Y7nE8MvEUF()
	{
		await QneEqQ1H4V(_0020: false);
		DIQEp3aCaT.NavigateTo(VM.PostShotSettings);
	}

	[CompilerGenerated]
	private async Task OkIERxMhva()
	{
		AutomaticUserInput.SendKey(IDRAConstant.GSProProcessName, 77u, maintain_ctrl: true);
		await QneEqQ1H4V(_0020: true);
		DIQEp3aCaT.NavigateTo(VM.Main);
	}

	[CompilerGenerated]
	private async Task QroEF2FiCW()
	{
		await QneEqQ1H4V(_0020: true);
		DIQEp3aCaT.NavigateTo(VM.Main);
	}

	[CompilerGenerated]
	private async Task upSEb5LF7h()
	{
		try
		{
			lNrEXFSv3k?.Stop();
			if ((J8WE1roHDr.CurrentPlayerName != IDRAConstant.GSProPracticeRangePlayerName && !ManagerSettings.UseGolfInPostShotInGame) || (J8WE1roHDr.CurrentPlayerName == IDRAConstant.GSProPracticeRangePlayerName && !ManagerSettings.UseGolfInPostShotInPractice))
			{
				cnDHhg6cyL();
				return;
			}
			if (!(await co7EnjCC9B.WaitAsync(JD4ErhDrfc())))
			{
				N0jEKLNINE.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18060), LogLevel.Warning);
				cnDHhg6cyL();
				return;
			}
			gYMEQMrB06(lvtEY0aqwi);
			lPTHvCVRNK();
			T4dEaZoYhi();
			miNEE2hovJ(lvtEY0aqwi);
			I66HWgJhuK();
			YwXExTdNi0(lvtEY0aqwi);
			NXyHow8LYT();
			LqiEdJryh9(lvtEY0aqwi);
			OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6486));
			OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(6516));
			DIQEp3aCaT.NavigateTo(VM.PostShot);
		}
		catch (Exception ex)
		{
			cnDHhg6cyL();
			N0jEKLNINE.Log(ex.Message, LogLevel.Error);
		}
	}

	[CompilerGenerated]
	private async Task waSE6njOM9()
	{
		try
		{
			if (!(await tDgEfIpse2.WaitAsync(FTBEZvZJqp())))
			{
				N0jEKLNINE.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18258), LogLevel.Warning);
				return;
			}
			PostShotProps.RemainingTimeDisplay = ManagerSettings.PostShotAutoContinueDuration.TotalSeconds.ToString();
			if (ManagerSettings.PostShotAutoContinueDuration <= TimeSpan.FromSeconds(0.0))
			{
				PostShotProps.RemainingTimeDisplay = "";
				return;
			}
			qgOHijMqj1();
			lNrEXFSv3k.Enabled = true;
		}
		catch (Exception ex)
		{
			N0jEKLNINE.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18348) + ex.Message, LogLevel.Error);
		}
	}
}
