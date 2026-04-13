using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GIToolkit.Models;
using GIToolkit.Services;
using GolfInLauncher.Messages;
using GolfInLauncher.Navigation;
using GolfInLauncher.Services;
using Golfin.Dtos;
using Lmttrs0IQc7UR7Zpt6;
using Microsoft.CSharp.RuntimeBinder;
using Tree.Extensions;
using Tree.Structures;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.ViewModels;

public class SettingsViewModel : ObservableRecipient, IViewModel
{
	[CompilerGenerated]
	private static class _003C_003Eo__52
	{
		public static CallSite<Func<CallSite, object, string, object>> Rla5qEPRuR;

		public static CallSite<Func<CallSite, object, string, object>> CGX55DFeVJ;

		public static CallSite<Func<CallSite, object, string, object>> TyF5QB9if6;

		public static CallSite<Func<CallSite, object, int, object>> z0y5x7Gjkl;

		public static CallSite<Func<CallSite, object, string, object>> PgY5HM9ubI;

		public static CallSite<Action<CallSite, object>> hlG5cXUlmZ;
	}

	private BusinessType qKqG4vnigr;

	private LaunchOptions VP6GOD7u1M;

	private Language A4IG9TL671;

	private bool fXKGAB4PrV;

	private ObservableCollection<SerializableCardLeaf> cBsGD3QLqV;

	private string IfNGaHXqtT;

	private bool QITGuJXO4X;

	private readonly ICultureHelper C2wGKdPMps;

	private readonly ILauncherConfiguration iE8G2VKoPw;

	private readonly INavigationService<ViewModelNavigationPages> ylhGjq6dM8;

	private readonly ILauncherSettings pcXGmQNCUe;

	private readonly IMessagingService B0iGInnbCn;

	private readonly ILocalCachingServices YJ3GEO6p8P;

	private readonly ICircularLogService oDBGfC26fV;

	private SerializableCardTree s9RGlwTMRk;

	public BusinessType BusinessType
	{
		get
		{
			return qKqG4vnigr;
		}
		set
		{
			SetProperty(ref qKqG4vnigr, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(528));
		}
	}

	public LaunchOptions LaunchOptions
	{
		get
		{
			return VP6GOD7u1M;
		}
		set
		{
			SetProperty(ref VP6GOD7u1M, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(646));
		}
	}

	public Language Language
	{
		get
		{
			return A4IG9TL671;
		}
		set
		{
			SetProperty(ref A4IG9TL671, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(4920));
		}
	}

	public bool StartLauncherOnComputerStartup
	{
		get
		{
			return fXKGAB4PrV;
		}
		set
		{
			SetProperty(ref fXKGAB4PrV, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(582));
		}
	}

	public ObservableCollection<SerializableCardLeaf> FlattenLauncherCardList
	{
		get
		{
			return cBsGD3QLqV;
		}
		set
		{
			SetProperty(ref cBsGD3QLqV, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(4940));
		}
	}

	public string CustomerPin
	{
		get
		{
			return IfNGaHXqtT;
		}
		set
		{
			SetProperty(ref IfNGaHXqtT, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(556));
		}
	}

	public bool IsAdminMode
	{
		get
		{
			return QITGuJXO4X;
		}
		set
		{
			SetProperty(ref QITGuJXO4X, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(4990));
		}
	}

	public ICommand CancelCommand => new RelayCommand(delegate
	{
		ylhGjq6dM8.NavigateTo(ViewModelNavigationPages.Main);
	});

	public ICommand ExitCommand => new RelayCommand(delegate
	{
		B0iGInnbCn.Send(new CloseApplicationMessage(100));
	});

	public ICommand WindowLoadCommand => new RelayCommand(delegate
	{
		B0iGInnbCn.Send(new RefreshCardListMessage(0));
		LaunchOptions = pcXGmQNCUe.LaunchOptions;
		CustomerPin = pcXGmQNCUe.CustomerPin;
		StartLauncherOnComputerStartup = pcXGmQNCUe.StartLauncherOnComputerStartup;
		BusinessType = pcXGmQNCUe.BusinessType;
		Language = ((pcXGmQNCUe.AssignedCulture == pcXGmQNCUe.FrenchCulture) ? Language.French : Language.English);
		IsAdminMode = pcXGmQNCUe.IsInAdminMode;
		oDBGfC26fV.Log(aL07ImwcwlxdnyfI30.olMQlwrxmw(5738) + pcXGmQNCUe.ToString());
	});

	public ICommand ShowAdminSettingsCommand => new RelayCommand(async delegate
	{
		await grCGy9E3bX();
	});

	public ICommand ChangeLanguageCommand => new RelayCommand<string>(delegate(string? P_0)
	{
		if (!string.IsNullOrWhiteSpace(P_0) && Enum.TryParse<Language>(P_0, ignoreCase: true, out var result))
		{
			Language = result;
			if (result == Language.French)
			{
				C2wGKdPMps.ChangeCultureLanguage(pcXGmQNCUe.FrenchCulture);
			}
			else
			{
				C2wGKdPMps.ChangeCultureLanguage(pcXGmQNCUe.EnglishCulture);
			}
		}
	});

	public ICommand SaveViewStateCommand => new RelayCommand(async delegate
	{
		iE8G2VKoPw.SaveSettings(new LauncherCardSettings
		{
			LauncherCards = s9RGlwTMRk
		});
		pcXGmQNCUe.BusinessType = BusinessType;
		pcXGmQNCUe.LaunchOptions = LaunchOptions;
		pcXGmQNCUe.CustomerPin = CustomerPin;
		pcXGmQNCUe.StartLauncherOnComputerStartup = StartLauncherOnComputerStartup;
		if (StartLauncherOnComputerStartup)
		{
			DvFGT5Nqtu();
		}
		else
		{
			S2RG6yQf4H();
		}
		await YJ3GEO6p8P.CacheAsync(LauncherSettings.LauncherSettingsDataKey, pcXGmQNCUe as LauncherSettings);
		B0iGInnbCn.Send(new RefreshCardListMessage(0));
		B0iGInnbCn.Send(new OnDisplayExitButton(newValue: true));
		ylhGjq6dM8.NavigateTo(ViewModelNavigationPages.Main);
	});

	public SettingsViewModel(ICultureHelper cultureHelper, ILauncherConfiguration launcherConfiguration, INavigationService<ViewModelNavigationPages> navigationService, ILauncherSettings launcherSettings, IMessagingService messagingService, ILocalCachingServices localCachingServices, ICircularLogService circularLogService)
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
		C2wGKdPMps = cultureHelper;
		iE8G2VKoPw = launcherConfiguration;
		ylhGjq6dM8 = navigationService;
		pcXGmQNCUe = launcherSettings;
		B0iGInnbCn = messagingService;
		B0iGInnbCn.Register<RefreshAllChildList>(this, yFpGdWjOiB);
		YJ3GEO6p8P = localCachingServices;
		oDBGfC26fV = circularLogService;
	}

	private void yFpGdWjOiB(object P_0, RefreshAllChildList P_1)
	{
		ObservableCollection<SerializableCardLeaf> flattenLauncherCardList = new ObservableCollection<SerializableCardLeaf>(P_1.LauncherCardTree.FlattenCardTree());
		s9RGlwTMRk = P_1.LauncherCardTree;
		FlattenLauncherCardList = flattenLauncherCardList;
	}

	private async Task grCGy9E3bX()
	{
		B0iGInnbCn.Send(new RedirectToView(ViewModelNavigationPages.Settings));
		ylhGjq6dM8.NavigateTo(ViewModelNavigationPages.Password);
		IsAdminMode = true;
	}

	private void S2RG6yQf4H()
	{
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), aL07ImwcwlxdnyfI30.olMQlwrxmw(5016));
		if (File.Exists(path))
		{
			File.Delete(path);
		}
	}

	private void DvFGT5Nqtu()
	{
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		string environmentVariable = Environment.GetEnvironmentVariable(aL07ImwcwlxdnyfI30.olMQlwrxmw(5058), EnvironmentVariableTarget.Machine);
		if (string.IsNullOrWhiteSpace(environmentVariable))
		{
			return;
		}
		string text = Path.Combine(environmentVariable, aL07ImwcwlxdnyfI30.olMQlwrxmw(5094), aL07ImwcwlxdnyfI30.olMQlwrxmw(5128));
		if (!File.Exists(text))
		{
			return;
		}
		try
		{
			string arg = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), aL07ImwcwlxdnyfI30.olMQlwrxmw(5016));
			object arg2 = Activator.CreateInstance(Type.GetTypeFromProgID(aL07ImwcwlxdnyfI30.olMQlwrxmw(5168)));
			if (_003C_003Eo__52.Rla5qEPRuR == null)
			{
				_003C_003Eo__52.Rla5qEPRuR = CallSite<Func<CallSite, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, aL07ImwcwlxdnyfI30.olMQlwrxmw(5198), null, typeof(SettingsViewModel), new CSharpArgumentInfo[2]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			object arg3 = _003C_003Eo__52.Rla5qEPRuR.Target(_003C_003Eo__52.Rla5qEPRuR, arg2, arg);
			if (_003C_003Eo__52.CGX55DFeVJ == null)
			{
				_003C_003Eo__52.CGX55DFeVJ = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, aL07ImwcwlxdnyfI30.olMQlwrxmw(5230), typeof(SettingsViewModel), new CSharpArgumentInfo[2]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			_003C_003Eo__52.CGX55DFeVJ.Target(_003C_003Eo__52.CGX55DFeVJ, arg3, text);
			if (_003C_003Eo__52.TyF5QB9if6 == null)
			{
				_003C_003Eo__52.TyF5QB9if6 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, aL07ImwcwlxdnyfI30.olMQlwrxmw(5254), typeof(SettingsViewModel), new CSharpArgumentInfo[2]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			_003C_003Eo__52.TyF5QB9if6.Target(_003C_003Eo__52.TyF5QB9if6, arg3, Path.GetDirectoryName(text));
			if (_003C_003Eo__52.z0y5x7Gjkl == null)
			{
				_003C_003Eo__52.z0y5x7Gjkl = CallSite<Func<CallSite, object, int, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, aL07ImwcwlxdnyfI30.olMQlwrxmw(3166), typeof(SettingsViewModel), new CSharpArgumentInfo[2]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			_003C_003Eo__52.z0y5x7Gjkl.Target(_003C_003Eo__52.z0y5x7Gjkl, arg3, 1);
			if (_003C_003Eo__52.PgY5HM9ubI == null)
			{
				_003C_003Eo__52.PgY5HM9ubI = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, aL07ImwcwlxdnyfI30.olMQlwrxmw(5290), typeof(SettingsViewModel), new CSharpArgumentInfo[2]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			_003C_003Eo__52.PgY5HM9ubI.Target(_003C_003Eo__52.PgY5HM9ubI, arg3, aL07ImwcwlxdnyfI30.olMQlwrxmw(5316));
			if (_003C_003Eo__52.hlG5cXUlmZ == null)
			{
				_003C_003Eo__52.hlG5cXUlmZ = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, aL07ImwcwlxdnyfI30.olMQlwrxmw(5362), null, typeof(SettingsViewModel), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
			}
			_003C_003Eo__52.hlG5cXUlmZ.Target(_003C_003Eo__52.hlG5cXUlmZ, arg3);
		}
		catch (Exception ex)
		{
			oDBGfC26fV.Log(aL07ImwcwlxdnyfI30.olMQlwrxmw(5374) + ex.Message);
			MessageBox.Show(aL07ImwcwlxdnyfI30.olMQlwrxmw(5562));
		}
	}

	[CompilerGenerated]
	private void wMgGYmxRJL()
	{
		ylhGjq6dM8.NavigateTo(ViewModelNavigationPages.Main);
	}

	[CompilerGenerated]
	private void UJfGSnZ583()
	{
		B0iGInnbCn.Send(new CloseApplicationMessage(100));
	}

	[CompilerGenerated]
	private void f81GNpkf1E()
	{
		B0iGInnbCn.Send(new RefreshCardListMessage(0));
		LaunchOptions = pcXGmQNCUe.LaunchOptions;
		CustomerPin = pcXGmQNCUe.CustomerPin;
		StartLauncherOnComputerStartup = pcXGmQNCUe.StartLauncherOnComputerStartup;
		BusinessType = pcXGmQNCUe.BusinessType;
		Language = ((pcXGmQNCUe.AssignedCulture == pcXGmQNCUe.FrenchCulture) ? Language.French : Language.English);
		IsAdminMode = pcXGmQNCUe.IsInAdminMode;
		oDBGfC26fV.Log(aL07ImwcwlxdnyfI30.olMQlwrxmw(5738) + pcXGmQNCUe.ToString());
	}

	[CompilerGenerated]
	private async void ri6GX9Kb7E()
	{
		await grCGy9E3bX();
	}

	[CompilerGenerated]
	private void bQEG1eMr7Q(string? P_0)
	{
		if (!string.IsNullOrWhiteSpace(P_0) && Enum.TryParse<Language>(P_0, ignoreCase: true, out var result))
		{
			Language = result;
			if (result == Language.French)
			{
				C2wGKdPMps.ChangeCultureLanguage(pcXGmQNCUe.FrenchCulture);
			}
			else
			{
				C2wGKdPMps.ChangeCultureLanguage(pcXGmQNCUe.EnglishCulture);
			}
		}
	}

	[CompilerGenerated]
	private async void Lk3Grqn5Gl()
	{
		iE8G2VKoPw.SaveSettings(new LauncherCardSettings
		{
			LauncherCards = s9RGlwTMRk
		});
		pcXGmQNCUe.BusinessType = BusinessType;
		pcXGmQNCUe.LaunchOptions = LaunchOptions;
		pcXGmQNCUe.CustomerPin = CustomerPin;
		pcXGmQNCUe.StartLauncherOnComputerStartup = StartLauncherOnComputerStartup;
		if (StartLauncherOnComputerStartup)
		{
			DvFGT5Nqtu();
		}
		else
		{
			S2RG6yQf4H();
		}
		await YJ3GEO6p8P.CacheAsync(LauncherSettings.LauncherSettingsDataKey, pcXGmQNCUe as LauncherSettings);
		B0iGInnbCn.Send(new RefreshCardListMessage(0));
		B0iGInnbCn.Send(new OnDisplayExitButton(newValue: true));
		ylhGjq6dM8.NavigateTo(ViewModelNavigationPages.Main);
	}
}
