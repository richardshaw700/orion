using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GIToolkit.Helpers;
using GIToolkit.Models;
using GIToolkit.Services;
using GolfInLauncher.Messages;
using GolfInLauncher.Model;
using GolfInLauncher.Navigation;
using GolfInLauncher.Services;
using GolfInLauncher.Services.SoftwareUpdate;
using GolfInLauncher.Views;
using Golfin.Dtos;
using Lmttrs0IQc7UR7Zpt6;
using MahApps.Metro.Controls.Dialogs;
using Newtonsoft.Json.Linq;
using Services;
using Tree.Extensions;
using Tree.Structures;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.ViewModels;

public class MainViewModel : ObservableRecipient, IViewModel, IDisposable
{
	public sealed class LauncherTileItem : ObservableObject
	{
		[CompilerGenerated]
		private readonly SerializableCardLeaf fBCqPhMfEK;

		private bool HveqJh1n7V;

		public SerializableCardLeaf Leaf
		{
			[CompilerGenerated]
			get
			{
				return fBCqPhMfEK;
			}
		}

		public LauncherCard Card => Leaf.Card;

		public bool HasUpdate
		{
			get
			{
				return HveqJh1n7V;
			}
			set
			{
				SetProperty(ref HveqJh1n7V, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(17160));
			}
		}

		public LauncherTileItem(SerializableCardLeaf leaf, bool hasUpdate = false)
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
			fBCqPhMfEK = leaf ?? throw new ArgumentNullException(aL07ImwcwlxdnyfI30.olMQlwrxmw(17148));
			HveqJh1n7V = hasUpdate;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass102_0
	{
		public string k5d5k5Tc7t;

		public _003C_003Ec__DisplayClass102_0()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal bool f8i5pfkA2E(SerializableCardLeaf x)
		{
			return x.Card.Name == k5d5k5Tc7t;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass108_0
	{
		public string MQ15ZSv91u;

		public _003C_003Ec__DisplayClass108_0()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal bool vH8583sFcw(string x)
		{
			return x.Contains(MQ15ZSv91u);
		}

		internal bool yda5GkJYR5(string x)
		{
			return x.Contains(MQ15ZSv91u);
		}
	}

	private bool Qpx8dStTyj;

	private bool dt28yiZ1ku;

	private bool lHf86iv0Wm;

	private bool N0H8TCNA1X;

	private bool XUy8YmkPtK;

	private bool ykV8SEinHa;

	private bool zRL8N4kj3B;

	private bool kJA8XjSXPg;

	private string rR981Q4tf9;

	private ObservableCollection<LauncherTileItem> h4o8rTVAvG;

	private ObservableCollection<LauncherTileItem> DpR84hutZN;

	private ObservableCollection<LauncherTileItem> BqE8OytDoM;

	private VerticalAlignment hcR89Ywt9G;

	private string yBp8AWroA1;

	private string xbV8DsUQae;

	private SolidColorBrush r3y8afHOV2;

	private ILauncherSettings hfA8ul3bSp;

	[CompilerGenerated]
	private CardStyle gEL8KJ3I4R;

	private readonly ILauncherConfiguration Wmd82ZX7jA;

	private readonly IIOHelper I6G8jNdBBt;

	private readonly INavigationService<ViewModelNavigationPages> e7t8miE7nV;

	private readonly IDialogCoordinator pFi8I8DSe0;

	private readonly INetworkUtility Epx8EUj1bw;

	private readonly IMessagingService fi68fL1HZT;

	private readonly ILocalCachingServices lYA8lDYciF;

	private readonly IProcessHelper H678i4YbIQ;

	private readonly IThreadHelper e8J8PWq3F9;

	private readonly IExceptionHelper yTd8JjaXp6;

	private readonly IMicrosoftGraphService jnU87pNahG;

	private readonly IZoneGolfInDriveService b8J8v9b55h;

	private readonly IXmlSettingsRecoveryService AmP8Bux0SB;

	private DispatcherTimer zMm8WUrbu1;

	private SerializableCardTree yfF8MPyeo1;

	private SpinnerWindow xCm8FWZXdD;

	public string ApplicationVersion => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

	public bool IsFrench
	{
		get
		{
			return Qpx8dStTyj;
		}
		set
		{
			SetProperty(ref Qpx8dStTyj, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3752));
		}
	}

	public bool IsInvoiceSoftwareAvailable
	{
		get
		{
			return dt28yiZ1ku;
		}
		set
		{
			SetProperty(ref dt28yiZ1ku, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3772));
		}
	}

	public bool IsE6ConnectAvailable
	{
		get
		{
			return lHf86iv0Wm;
		}
		set
		{
			SetProperty(ref lHf86iv0Wm, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3828));
		}
	}

	public bool IsE6GolfAvailable
	{
		get
		{
			return N0H8TCNA1X;
		}
		set
		{
			SetProperty(ref N0H8TCNA1X, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3872));
		}
	}

	public bool IsSupportAvailable
	{
		get
		{
			return true;
		}
		set
		{
			SetProperty(ref XUy8YmkPtK, newValue: true, aL07ImwcwlxdnyfI30.olMQlwrxmw(3910));
		}
	}

	public bool IsInvoiceSoftwareInstalled
	{
		get
		{
			return ykV8SEinHa;
		}
		set
		{
			SetProperty(ref ykV8SEinHa, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3950));
		}
	}

	public bool IsE6ConnectInstalled
	{
		get
		{
			return zRL8N4kj3B;
		}
		set
		{
			SetProperty(ref zRL8N4kj3B, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(4006));
		}
	}

	public bool IsE6GolfInstalled
	{
		get
		{
			return kJA8XjSXPg;
		}
		set
		{
			SetProperty(ref kJA8XjSXPg, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(4050));
		}
	}

	public string WindowsUpdateNeedToBeInstalled
	{
		get
		{
			return rR981Q4tf9;
		}
		set
		{
			SetProperty(ref rR981Q4tf9, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(4088));
		}
	}

	public ObservableCollection<LauncherTileItem> LauncherCardList
	{
		get
		{
			return h4o8rTVAvG;
		}
		set
		{
			SetProperty(ref h4o8rTVAvG, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(4152));
		}
	}

	public ObservableCollection<LauncherTileItem> FirstRowLauncherCardList
	{
		get
		{
			return DpR84hutZN;
		}
		set
		{
			SetProperty(ref DpR84hutZN, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3592));
		}
	}

	public ObservableCollection<LauncherTileItem> SecondRowLauncherCardList
	{
		get
		{
			return BqE8OytDoM;
		}
		set
		{
			SetProperty(ref BqE8OytDoM, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3644));
		}
	}

	public VerticalAlignment FirstRowVerticalAlignment
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return hcR89Ywt9G;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			SetProperty(ref hcR89Ywt9G, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3698));
		}
	}

	public string TextTest
	{
		get
		{
			return yBp8AWroA1;
		}
		set
		{
			SetProperty(ref yBp8AWroA1, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(4188));
		}
	}

	public string IsConnectedText
	{
		get
		{
			return xbV8DsUQae;
		}
		set
		{
			SetProperty(ref xbV8DsUQae, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(4208));
		}
	}

	public SolidColorBrush IsConnectedTextColor
	{
		get
		{
			return r3y8afHOV2;
		}
		set
		{
			SetProperty(ref r3y8afHOV2, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(4242));
		}
	}

	public ILauncherSettings LauncherSettings
	{
		get
		{
			return hfA8ul3bSp;
		}
		set
		{
			SetProperty(ref hfA8ul3bSp, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(4286));
		}
	}

	public CardStyle CardStyle
	{
		[CompilerGenerated]
		get
		{
			return gEL8KJ3I4R;
		}
		[CompilerGenerated]
		set
		{
			gEL8KJ3I4R = value;
		}
	}

	public ICommand OpenSettingsWindowCommand => new RelayCommand(delegate
	{
		if (hfA8ul3bSp.CustomerPin.Length == 0)
		{
			hfA8ul3bSp.IsInAdminMode = false;
			e7t8miE7nV.NavigateTo(ViewModelNavigationPages.Settings);
		}
		else
		{
			fi68fL1HZT.Send(new RedirectToView(ViewModelNavigationPages.Settings));
			e7t8miE7nV.NavigateTo(ViewModelNavigationPages.Password);
		}
	});

	public ICommand CloseLauncherCommand => new RelayCommand(delegate
	{
		if (hfA8ul3bSp.CustomerPin.Length > 0)
		{
			fi68fL1HZT.Send(new RedirectToView(ViewModelNavigationPages.ExitSoftware));
			e7t8miE7nV.NavigateTo(ViewModelNavigationPages.Password);
		}
		else
		{
			fi68fL1HZT.Send(new CloseApplicationMessage(100));
		}
	});

	public MainViewModel(ILauncherConfiguration launcherConfiguration, IIOHelper iOHelper, INavigationService<ViewModelNavigationPages> navigationService, ICultureHelper cultureHelper, IDialogCoordinator dialogCoordinator, INetworkUtility networkUtility, IMessagingService messagingService, IProcessHelper processHelper, IThreadHelper threadHelper, IExceptionHelper exceptionHelper, IMicrosoftGraphService microsoftGraphService, IZoneGolfInDriveService zoneGolfInDriveFile, ILocalCachingServices localCachingServices, ILauncherSettings launcherSettings, IXmlSettingsRecoveryService xmlService)
	{
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		gEL8KJ3I4R = new CardStyle();
		base._002Ector();
		Wmd82ZX7jA = launcherConfiguration;
		I6G8jNdBBt = iOHelper;
		e7t8miE7nV = navigationService;
		pFi8I8DSe0 = dialogCoordinator;
		Epx8EUj1bw = networkUtility;
		fi68fL1HZT = messagingService;
		H678i4YbIQ = processHelper;
		e8J8PWq3F9 = threadHelper;
		yTd8JjaXp6 = exceptionHelper;
		jnU87pNahG = microsoftGraphService;
		b8J8v9b55h = zoneGolfInDriveFile;
		lYA8lDYciF = localCachingServices;
		LauncherSettings = launcherSettings;
		AmP8Bux0SB = xmlService;
		fi68fL1HZT.Send(new SendContainerConfigMessage(new SendContainerConfigMessageArguments
		{
			TopMost = true
		}));
		jnU87pNahG.LoadGraphService(new AuthenticationConfig(LauncherConstant.Graph.Tenant, LauncherConstant.Graph.ClientId, LauncherConstant.Graph.ClientSecret));
		Dwp83du0Jo();
		IsFrench = cultureHelper.GetCurrentLanguage() == Language.French;
		Wmd82ZX7jA.GetOrSetAllLaucherCard();
		cultureHelper.ChangeCultureLanguage(LauncherSettings.AssignedCulture);
		if (I6G8jNdBBt.FileCanBeUse(GIConstant.PathToLauncherCardConfigJsonFile))
		{
			RefreshCardList();
		}
		zMm8WUrbu1 = new DispatcherTimer
		{
			Interval = TimeSpan.FromSeconds(1.0)
		};
		zMm8WUrbu1.Tick += K0u8ZeQEma;
		zMm8WUrbu1.Start();
	}

	private void K0u8ZeQEma(object P_0, EventArgs P_1)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		IsConnectedText = (Epx8EUj1bw.IsNetworkAvailable(0L) ? aL07ImwcwlxdnyfI30.olMQlwrxmw(4376) : aL07ImwcwlxdnyfI30.olMQlwrxmw(4322));
		IsConnectedTextColor = (Epx8EUj1bw.IsNetworkAvailable(0L) ? new SolidColorBrush((Color)ColorConverter.ConvertFromString(aL07ImwcwlxdnyfI30.olMQlwrxmw(4438))) : new SolidColorBrush((Color)ColorConverter.ConvertFromString(aL07ImwcwlxdnyfI30.olMQlwrxmw(4420))));
	}

	private void Dwp83du0Jo()
	{
		fi68fL1HZT.Register(this, delegate(object P_0, OnLanguageChangeMessage P_1)
		{
			IsFrench = P_1.NewLanguage == Language.French;
		});
		fi68fL1HZT.Register<MainLaunchProgramMessage>(this, LaunchProgram);
		fi68fL1HZT.Register<RefreshCardListMessage>(this, s3h8sLLCwW);
	}

	private void s3h8sLLCwW(object P_0, RefreshCardListMessage P_1)
	{
		RefreshCardList();
		fi68fL1HZT.Send(new RefreshAllChildList(yfF8MPyeo1));
	}

	public async Task RefreshCardList()
	{
		yfF8MPyeo1 = Wmd82ZX7jA.GetOrSetAllLaucherCard().LauncherCards;
		List<LauncherTileItem> list = (from x in yfF8MPyeo1.Root.FindCardLeaves((SerializableCardLeaf x) => x.ParentCardName == aL07ImwcwlxdnyfI30.olMQlwrxmw(8102)).ToList()
			orderby x.Card.OrderToDisplay
			select new LauncherTileItem(x)).ToList();
		LauncherCardList = new ObservableCollection<LauncherTileItem>(list);
		int index = checked(LauncherCardList.Where((LauncherTileItem x) => x.Card.IsSoftwareAvailable).ToList().Count - 1);
		(int, int) tuple = GolfinUtils.GetPositionLists()[index];
		FirstRowVerticalAlignment = (VerticalAlignment)(tuple.Item2 == 0);
		CardStyle.SetCardDimensions(tuple.Item1);
		FirstRowLauncherCardList = new ObservableCollection<LauncherTileItem>(LauncherCardList.Where((LauncherTileItem x) => x.Card.IsSoftwareAvailable).Take(tuple.Item1));
		SecondRowLauncherCardList = new ObservableCollection<LauncherTileItem>(LauncherCardList.Where((LauncherTileItem x) => x.Card.IsSoftwareAvailable).Reverse().Take(tuple.Item2)
			.Reverse());
		LauncherTileItem launcherTileItem = list.Where((LauncherTileItem o) => o.Card.Name == ProgramName.Support).First();
		launcherTileItem.HasUpdate = await SoftwareVersionsService.HasAnyNewVersionAvailableAsync(LauncherSettings.LaunchOptions == LaunchOptions.UseRemoteInvoiceSoftware);
	}

	public async void LaunchProgram(object r, MainLaunchProgramMessage program)
	{
		try
		{
			_003C_003Ec__DisplayClass102_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass102_0();
			CS_0024_003C_003E8__locals3.k5d5k5Tc7t = program.ProgramName;
			LauncherCard launcherCard = Wmd82ZX7jA.GetOrSetAllLaucherCard().LauncherCards.Root.FindCardLeaves((SerializableCardLeaf x) => x.Card.Name == CS_0024_003C_003E8__locals3.k5d5k5Tc7t).FirstOrDefault()?.Card;
			if ((launcherCard.Name == ProgramName.IDRA || launcherCard.Name == ProgramName.IDRAGSPro) && GIConstant.UsingSSCInstallPath && SoftwareVersionsService.ConfigurationFileExists())
			{
				FileInfo fileInfo = new FileInfo(SoftwareVersionsService.GetMainExecutablePath(Software.IDRA));
				launcherCard.ExeFolderPath = fileInfo.DirectoryName;
				launcherCard.ExePath = fileInfo.FullName;
			}
			if (CS_0024_003C_003E8__locals3.k5d5k5Tc7t == ProgramName.Support)
			{
				e7t8miE7nV.NavigateTo(ViewModelNavigationPages.Support);
				return;
			}
			if (!I6G8jNdBBt.FileExists(launcherCard.ExePath))
			{
				await pFi8I8DSe0.ShowMessageAsync(this, aL07ImwcwlxdnyfI30.olMQlwrxmw(17274), aL07ImwcwlxdnyfI30.olMQlwrxmw(17328) + launcherCard.ExePath);
				return;
			}
			H678i4YbIQ.DeleteUnusedCredentialManagement();
			if (uiW85NY5Tf(launcherCard))
			{
				return;
			}
			MJi8cknPft();
			if (launcherCard.Name == ProgramName.IDRA)
			{
				COh8qQ3ubw(_0020: false);
			}
			else if (launcherCard.Name == ProgramName.IDRAGSPro)
			{
				COh8qQ3ubw(_0020: true);
			}
			Process process = H678i4YbIQ.CreateProcess(launcherCard.ExePath, launcherCard.ExeFolderPath, launcherCard.ExeParams);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 2);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(17182));
			defaultInterpolatedStringHandler.AppendFormatted(launcherCard.Name);
			EventViewerLogger.LogInformation(defaultInterpolatedStringHandler.ToStringAndClear(), 200);
			H678i4YbIQ.StartProcess(process);
			H678i4YbIQ.ModifyWindowState(process.ProcessName, ShowWindowEnum.ShowMaximized, setFocus: true);
			fi68fL1HZT.Send(new SendContainerConfigMessage(new SendContainerConfigMessageArguments
			{
				TopMost = false,
				WindowState = (WindowState)1
			}));
			await cdc8QfRnMX(launcherCard, process);
		}
		catch (Exception ex)
		{
			fi68fL1HZT.Send(new SendContainerConfigMessage(new SendContainerConfigMessageArguments
			{
				TopMost = true,
				WindowState = (WindowState)2
			}));
			string lastFrameMessage = yTd8JjaXp6.GetLastFrameMessage(ex);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(68, 3);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(17520));
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(17594));
			defaultInterpolatedStringHandler.AppendFormatted(ex.InnerException?.Message);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(17630));
			defaultInterpolatedStringHandler.AppendFormatted(lastFrameMessage);
			EventViewerLogger.LogWarning(defaultInterpolatedStringHandler.ToStringAndClear());
			zco8bvagE1((Window)(object)xCm8FWZXdD);
			IDialogCoordinator dialogCoordinator = pFi8I8DSe0;
			MainViewModel context = this;
			string title = aL07ImwcwlxdnyfI30.olMQlwrxmw(17668);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(68, 3);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(12260));
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(17594));
			defaultInterpolatedStringHandler.AppendFormatted(ex.InnerException?.Message);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(17630));
			defaultInterpolatedStringHandler.AppendFormatted(lastFrameMessage);
			await dialogCoordinator.ShowMessageAsync(context, title, defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	private void COh8qQ3ubw(bool P_0)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(LauncherConstant.IDRA.GICTSSettingsFilePath);
			if (!fileInfo.Exists)
			{
				EventViewerLogger.LogWarning(aL07ImwcwlxdnyfI30.olMQlwrxmw(4456));
				return;
			}
			JObject jObject = JObject.Parse(fileInfo.ReadAllTextWithBackup());
			JToken? jToken = jObject[LauncherConstant.IDRA.UseGsProPropName];
			if (jToken == null || jToken.Value<bool>() != P_0)
			{
				jObject[LauncherConstant.IDRA.UseGsProPropName] = P_0;
				jObject[LauncherConstant.IDRA.UseE6ConnectPropName] = !P_0;
				string contents = jObject.ToString();
				fileInfo.WriteAllTextWithBackup(contents);
			}
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
		}
	}

	private bool uiW85NY5Tf(LauncherCard P_0)
	{
		Match match = new Regex(aL07ImwcwlxdnyfI30.olMQlwrxmw(4556), RegexOptions.IgnoreCase).Match(P_0.ExePath);
		string text = string.Empty;
		if (match.Success && match.Groups.Count > 1)
		{
			text = match.Groups[1].Value;
		}
		Process processByName = H678i4YbIQ.GetProcessByName(text);
		if (processByName != null)
		{
			if (processByName.ProcessName == aL07ImwcwlxdnyfI30.olMQlwrxmw(4592))
			{
				H678i4YbIQ.BringWindowToFront(aL07ImwcwlxdnyfI30.olMQlwrxmw(4618));
			}
			fi68fL1HZT.Send(new SendContainerConfigMessage(new SendContainerConfigMessageArguments
			{
				TopMost = false,
				WindowState = (WindowState)1
			}));
			H678i4YbIQ.BringWindowToFront(text);
			H678i4YbIQ.AttachListenerOnExited(processByName, Process_Exited);
			return true;
		}
		return false;
	}

	private async Task cdc8QfRnMX(LauncherCard P_0, Process P_1)
	{
		if (H678i4YbIQ.ProcessIsSetAndHasNotExited(P_1))
		{
			Flj8xUwtKt(P_0);
			H678i4YbIQ.AttachListenerOnExited(P_1, Process_Exited);
			return;
		}
		await pFi8I8DSe0.ShowMessageAsync(this, aL07ImwcwlxdnyfI30.olMQlwrxmw(17702), aL07ImwcwlxdnyfI30.olMQlwrxmw(17732));
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(129, 2);
		defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(17794));
		defaultInterpolatedStringHandler.AppendFormatted(P_0.Name);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(17944));
		EventViewerLogger.LogWarning(defaultInterpolatedStringHandler.ToStringAndClear(), 200);
		zco8bvagE1((Window)(object)xCm8FWZXdD);
	}

	private async void Flj8xUwtKt(LauncherCard P_0)
	{
		LaunchOptions launchOptions = LauncherSettings.LaunchOptions;
		Tuple<string, string> tuple = new Tuple<string, string>("", "");
		switch (launchOptions)
		{
		case LaunchOptions.None:
			return;
		case LaunchOptions.UseOldInvoiceSoftware:
			tuple = ggp8Hx3EMl(Environment.GetFolderPath(Environment.SpecialFolder.Programs), LauncherConstant.OldZGISInvoiceSoftwareName);
			break;
		case LaunchOptions.UseRemoteInvoiceSoftware:
			if (GIConstant.UsingSSCInstallPath && SoftwareVersionsService.ConfigurationFileExists())
			{
				string mainExecutablePath = SoftwareVersionsService.GetMainExecutablePath(Software.ZGISRemote);
				if (string.IsNullOrWhiteSpace(mainExecutablePath) || !I6G8jNdBBt.FileExists(mainExecutablePath))
				{
					throw new FileNotFoundException(aL07ImwcwlxdnyfI30.olMQlwrxmw(18060));
				}
				FileInfo fileInfo = new FileInfo(mainExecutablePath);
				tuple = new Tuple<string, string>(fileInfo.Name, fileInfo.DirectoryName);
			}
			else
			{
				string text = (GIConstant.UsingSSCInstallPath ? (GIConstant.SSCInstallPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(18246)) : GIConstant.OldProgramFilesPath);
				tuple = ggp8Hx3EMl(text, LauncherConstant.ZGISRemoteInvoiceSoftwareName);
				if (string.IsNullOrWhiteSpace(tuple.Item1) || string.IsNullOrWhiteSpace(tuple.Item2))
				{
					throw new FileNotFoundException(aL07ImwcwlxdnyfI30.olMQlwrxmw(18274) + text + aL07ImwcwlxdnyfI30.olMQlwrxmw(2680));
				}
			}
			break;
		}
		string item = tuple.Item1;
		string item2 = tuple.Item2;
		Process process = H678i4YbIQ.CreateProcess(item, item2, P_0.ExeParams);
		process.StartInfo.UseShellExecute = true;
		H678i4YbIQ.StartProcess(process);
	}

	public void Process_Exited(object sender, EventArgs e)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
		defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now);
		defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(4640));
		EventViewerLogger.LogInformation(defaultInterpolatedStringHandler.ToStringAndClear(), 200);
		fi68fL1HZT.Send(new SendContainerConfigMessage(new SendContainerConfigMessageArguments
		{
			TopMost = true,
			WindowState = (WindowState)0
		}));
		fi68fL1HZT.Send(new SendContainerConfigMessage(new SendContainerConfigMessageArguments
		{
			TopMost = true,
			WindowState = (WindowState)2
		}));
		e8J8PWq3F9.StartTaskAsyncFunc(async delegate
		{
			await e8J8PWq3F9.Delay(500);
			zco8bvagE1((Window)(object)xCm8FWZXdD);
		});
	}

	private Tuple<string, string> ggp8Hx3EMl(string P_0, string P_1)
	{
		_003C_003Ec__DisplayClass108_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass108_0();
		CS_0024_003C_003E8__locals4.MQ15ZSv91u = P_1;
		string[] files = Directory.GetFiles(P_0, CS_0024_003C_003E8__locals4.MQ15ZSv91u, SearchOption.AllDirectories);
		if (files.Length == 0)
		{
			return new Tuple<string, string>(string.Empty, string.Empty);
		}
		string obj = (files.Any((string x) => x.Contains(CS_0024_003C_003E8__locals4.MQ15ZSv91u)) ? files.FirstOrDefault((string x) => x.Contains(CS_0024_003C_003E8__locals4.MQ15ZSv91u)) : string.Empty);
		string fullName = (new DirectoryInfo(obj) ?? throw new ArgumentNullException(aL07ImwcwlxdnyfI30.olMQlwrxmw(4698))).Parent.FullName;
		return new Tuple<string, string>(obj, fullName);
	}

	private void MJi8cknPft()
	{
		if (xCm8FWZXdD != null)
		{
			zco8bvagE1((Window)(object)xCm8FWZXdD);
		}
		Thread thread = new Thread(Sj98eMVDwV);
		thread.SetApartmentState(ApartmentState.STA);
		thread.IsBackground = true;
		thread.Start();
	}

	private void Sj98eMVDwV()
	{
		xCm8FWZXdD = new SpinnerWindow();
		((Window)xCm8FWZXdD).Show();
		Dispatcher.Run();
	}

	private void zco8bvagE1(Window P_0)
	{
		if (P_0 != null)
		{
			if (((DispatcherObject)P_0).Dispatcher.CheckAccess())
			{
				P_0.Close();
			}
			else
			{
				((DispatcherObject)P_0).Dispatcher.Invoke((DispatcherPriority)9, (Delegate)new ThreadStart(P_0.Close));
			}
		}
	}

	public void Dispose()
	{
		zco8bvagE1((Window)(object)xCm8FWZXdD);
	}

	[CompilerGenerated]
	private void lIr8VojLv0(object P_0, OnLanguageChangeMessage P_1)
	{
		IsFrench = P_1.NewLanguage == Language.French;
	}

	[CompilerGenerated]
	private void d0I8wPOfUh()
	{
		if (hfA8ul3bSp.CustomerPin.Length == 0)
		{
			hfA8ul3bSp.IsInAdminMode = false;
			e7t8miE7nV.NavigateTo(ViewModelNavigationPages.Settings);
		}
		else
		{
			fi68fL1HZT.Send(new RedirectToView(ViewModelNavigationPages.Settings));
			e7t8miE7nV.NavigateTo(ViewModelNavigationPages.Password);
		}
	}

	[CompilerGenerated]
	private void Rhm80DuJwA()
	{
		if (hfA8ul3bSp.CustomerPin.Length > 0)
		{
			fi68fL1HZT.Send(new RedirectToView(ViewModelNavigationPages.ExitSoftware));
			e7t8miE7nV.NavigateTo(ViewModelNavigationPages.Password);
		}
		else
		{
			fi68fL1HZT.Send(new CloseApplicationMessage(100));
		}
	}

	[CompilerGenerated]
	private async Task X2X8Crnndd()
	{
		await e8J8PWq3F9.Delay(500);
		zco8bvagE1((Window)(object)xCm8FWZXdD);
	}
}
