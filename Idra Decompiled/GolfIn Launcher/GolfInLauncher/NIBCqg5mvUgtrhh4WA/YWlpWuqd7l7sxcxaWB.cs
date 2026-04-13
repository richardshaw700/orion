using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Autofac;
using GIToolkit;
using GIToolkit.Services;
using GolfInLauncher.Navigation;
using GolfInLauncher.Services;
using GolfInLauncher.ViewModels;
using MahApps.Metro.Controls.Dialogs;
using U9xbeMdbyr6Pactctj;

namespace NIBCqg5mvUgtrhh4WA;

internal class YWlpWuqd7l7sxcxaWB
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public ContainerBuilder YNY5IjcCGN;

		public ILocalCachingServices i2j5ExmYmR;

		public _003C_003Ec__DisplayClass30_0()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal void A7q5mEFkAa()
		{
			YNY5IjcCGN = i2j5ExmYmR.RegisterObjectInstance<LauncherEnv, ILauncherEnv>(ref YNY5IjcCGN, LauncherEnv.LauncherDataKey);
			YNY5IjcCGN = i2j5ExmYmR.RegisterObjectInstance<LauncherSettings, ILauncherSettings>(ref YNY5IjcCGN, LauncherSettings.LauncherSettingsDataKey);
		}
	}

	[CompilerGenerated]
	private readonly INavigationService<ViewModelNavigationPages> IpWZUckshl;

	[CompilerGenerated]
	private readonly MainViewModel X6UZtX9mhu;

	[CompilerGenerated]
	private readonly MaintenanceViewModel VIyZLmPAZi;

	[CompilerGenerated]
	private readonly PasswordViewModel J0PZRRJOMr;

	[CompilerGenerated]
	private readonly SettingsViewModel eaKZnPRZoO;

	[CompilerGenerated]
	private readonly SoftwareUpdateViewModel oaYZgsSOBv;

	[CompilerGenerated]
	private readonly SupportViewModel aGKZorYt0s;

	[CompilerGenerated]
	private readonly ContainerViewModel qkEZhFjk1Z;

	[CompilerGenerated]
	private readonly GolfInWebViewerViewModel IvSZz5HiqJ;

	[CompilerGenerated]
	private readonly WifiPanelViewModel uOj3pIFtA2;

	[SpecialName]
	[CompilerGenerated]
	public INavigationService<ViewModelNavigationPages> k8CZDHFfsq()
	{
		return IpWZUckshl;
	}

	[SpecialName]
	[CompilerGenerated]
	public MainViewModel TAUZuDnEkO()
	{
		return X6UZtX9mhu;
	}

	[SpecialName]
	[CompilerGenerated]
	public MaintenanceViewModel CpHZ2MHLs1()
	{
		return VIyZLmPAZi;
	}

	[SpecialName]
	[CompilerGenerated]
	public PasswordViewModel VyjZmdCG5t()
	{
		return J0PZRRJOMr;
	}

	[SpecialName]
	[CompilerGenerated]
	public SettingsViewModel LxQZE7jkBX()
	{
		return eaKZnPRZoO;
	}

	[SpecialName]
	[CompilerGenerated]
	public SoftwareUpdateViewModel ivlZlOZb9a()
	{
		return oaYZgsSOBv;
	}

	[SpecialName]
	[CompilerGenerated]
	public SupportViewModel UqKZPJo1fa()
	{
		return aGKZorYt0s;
	}

	[SpecialName]
	[CompilerGenerated]
	public ContainerViewModel YSBZ7sCVR1()
	{
		return qkEZhFjk1Z;
	}

	[SpecialName]
	[CompilerGenerated]
	public GolfInWebViewerViewModel v5TZBFnEvx()
	{
		return IvSZz5HiqJ;
	}

	[SpecialName]
	[CompilerGenerated]
	public WifiPanelViewModel UZ2ZMbJmZJ()
	{
		return uOj3pIFtA2;
	}

	public YWlpWuqd7l7sxcxaWB()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
		try
		{
			_003C_003Ec__DisplayClass30_0 CS_0024_003C_003E8__locals15 = new _003C_003Ec__DisplayClass30_0();
			CS_0024_003C_003E8__locals15.YNY5IjcCGN = new ContainerBuilder();
			Assembly[] assemblies = new Assembly[1] { Assembly.GetExecutingAssembly() };
			(from t in CS_0024_003C_003E8__locals15.YNY5IjcCGN.RegisterAssemblyTypes(assemblies)
				where typeof(IService).IsAssignableFrom(t)
				select t).SingleInstance().AsImplementedInterfaces();
			(from t in CS_0024_003C_003E8__locals15.YNY5IjcCGN.RegisterAssemblyTypes(assemblies)
				where typeof(IViewModel).IsAssignableFrom(t)
				select t).SingleInstance().AsSelf();
			IpWZUckshl = new NavigationService<ViewModelNavigationPages>();
			CS_0024_003C_003E8__locals15.YNY5IjcCGN.RegisterInstance(k8CZDHFfsq()).As<INavigationService<ViewModelNavigationPages>>().SingleInstance();
			CS_0024_003C_003E8__locals15.YNY5IjcCGN.RegisterInstance(DialogCoordinator.Instance).As<IDialogCoordinator>().SingleInstance();
			CS_0024_003C_003E8__locals15.i2j5ExmYmR = new LocalCachingServices();
			Task.Run(delegate
			{
				CS_0024_003C_003E8__locals15.YNY5IjcCGN = CS_0024_003C_003E8__locals15.i2j5ExmYmR.RegisterObjectInstance<LauncherEnv, ILauncherEnv>(ref CS_0024_003C_003E8__locals15.YNY5IjcCGN, LauncherEnv.LauncherDataKey);
				CS_0024_003C_003E8__locals15.YNY5IjcCGN = CS_0024_003C_003E8__locals15.i2j5ExmYmR.RegisterObjectInstance<LauncherSettings, ILauncherSettings>(ref CS_0024_003C_003E8__locals15.YNY5IjcCGN, LauncherSettings.LauncherSettingsDataKey);
			}).Wait();
			CS_0024_003C_003E8__locals15.YNY5IjcCGN = ContainerConfig.IntegrateToolkitDependencies(ref CS_0024_003C_003E8__locals15.YNY5IjcCGN);
			using (ILifetimeScope context = CS_0024_003C_003E8__locals15.YNY5IjcCGN.Build().BeginLifetimeScope())
			{
				qkEZhFjk1Z = context.Resolve<ContainerViewModel>();
				X6UZtX9mhu = context.Resolve<MainViewModel>();
				VIyZLmPAZi = context.Resolve<MaintenanceViewModel>();
				J0PZRRJOMr = context.Resolve<PasswordViewModel>();
				eaKZnPRZoO = context.Resolve<SettingsViewModel>();
				oaYZgsSOBv = context.Resolve<SoftwareUpdateViewModel>();
				aGKZorYt0s = context.Resolve<SupportViewModel>();
				IvSZz5HiqJ = context.Resolve<GolfInWebViewerViewModel>();
				uOj3pIFtA2 = context.Resolve<WifiPanelViewModel>();
			}
			k8CZDHFfsq().AddPage(TAUZuDnEkO(), ViewModelNavigationPages.Main);
			k8CZDHFfsq().AddPage(CpHZ2MHLs1(), ViewModelNavigationPages.Maintenance);
			k8CZDHFfsq().AddPage(VyjZmdCG5t(), ViewModelNavigationPages.Password);
			k8CZDHFfsq().AddPage(LxQZE7jkBX(), ViewModelNavigationPages.Settings);
			k8CZDHFfsq().AddPage(ivlZlOZb9a(), ViewModelNavigationPages.SoftwareUpdates);
			k8CZDHFfsq().AddPage(UqKZPJo1fa(), ViewModelNavigationPages.Support);
			k8CZDHFfsq().AddPage(v5TZBFnEvx(), ViewModelNavigationPages.Web);
			k8CZDHFfsq().AddPage(UZ2ZMbJmZJ(), ViewModelNavigationPages.Wifi);
			k8CZDHFfsq().NavigateTo(ViewModelNavigationPages.Main);
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
			throw;
		}
	}
}
