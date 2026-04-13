using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Autofac;
using Autofac.Core;
using GICTS.Data;
using GICTSCore.Data;
using GICTSCore.Services;
using GIToolkit;
using GIToolkit.Services;
using IDRAMonitor.Auxiliary.Navigation;
using IDRAMonitor.ViewModels;
using MahApps.Metro.Controls.Dialogs;
using hkpxmGISLhTJrZLcmi;
using jBnbmEXkwPOPpPQ9mC;

namespace r8FF027V5kft9n1ATY;

internal class Jged61jttKo6ryRwn0
{
	[CompilerGenerated]
	private readonly INavigationService<VM> a19FcmmHSh;

	[CompilerGenerated]
	private readonly IGICTSSettings LLOFXT3rXd;

	[CompilerGenerated]
	private readonly ISoftwareAzureBlobUpdater RxLFKmthIt;

	[CompilerGenerated]
	private readonly ICircularLogService esUFyfWjKm;

	[CompilerGenerated]
	private readonly ILocalAPIGameSettings pAEFZ22Jap;

	[CompilerGenerated]
	private readonly ContainerViewModel aWIFRSmV4a;

	[CompilerGenerated]
	private readonly MainViewModel rs0FmeiJFe;

	[CompilerGenerated]
	private readonly OptionDialogViewModel XPfFiN7bM3;

	[CompilerGenerated]
	private readonly PasswordViewModel I8vFh1uwiv;

	[CompilerGenerated]
	private readonly AdminMenuViewModel Yq7FBoTsfv;

	[CompilerGenerated]
	private readonly GSProOptionMenuViewModel jiKFAty2Zj;

	[CompilerGenerated]
	private readonly ManagerSettingsMenuViewModel DPKFYStaDZ;

	[SpecialName]
	[CompilerGenerated]
	public INavigationService<VM> Fda76JSmXr()
	{
		return a19FcmmHSh;
	}

	[SpecialName]
	[CompilerGenerated]
	public IGICTSSettings Mt47dshSEu()
	{
		return LLOFXT3rXd;
	}

	[SpecialName]
	[CompilerGenerated]
	public ISoftwareAzureBlobUpdater Vi07n230Sn()
	{
		return RxLFKmthIt;
	}

	[SpecialName]
	[CompilerGenerated]
	public ICircularLogService F557bMnqj2()
	{
		return esUFyfWjKm;
	}

	[SpecialName]
	[CompilerGenerated]
	public ILocalAPIGameSettings ipQ7zsITn3()
	{
		return pAEFZ22Jap;
	}

	[SpecialName]
	[CompilerGenerated]
	public ContainerViewModel i7bFjFhrb8()
	{
		return aWIFRSmV4a;
	}

	[SpecialName]
	[CompilerGenerated]
	public MainViewModel btTFF2wRqy()
	{
		return rs0FmeiJFe;
	}

	[SpecialName]
	[CompilerGenerated]
	public OptionDialogViewModel aUCF2IjcyA()
	{
		return XPfFiN7bM3;
	}

	[SpecialName]
	[CompilerGenerated]
	public PasswordViewModel slXFqs1LYb()
	{
		return I8vFh1uwiv;
	}

	[SpecialName]
	[CompilerGenerated]
	public AdminMenuViewModel RfiFWJFPqL()
	{
		return Yq7FBoTsfv;
	}

	[SpecialName]
	[CompilerGenerated]
	public GSProOptionMenuViewModel Sj7FJssV6M()
	{
		return jiKFAty2Zj;
	}

	[SpecialName]
	[CompilerGenerated]
	public ManagerSettingsMenuViewModel bjkF1gXIXx()
	{
		return DPKFYStaDZ;
	}

	public Jged61jttKo6ryRwn0()
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		base._002Ector();
		ContainerBuilder builder = new ContainerBuilder();
		Assembly[] assemblies = (from x in AppDomain.CurrentDomain.GetAssemblies()
			where x.FullName.Contains(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12044)) || x.FullName.Contains(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12070))
			select x).ToArray();
		(from t in builder.RegisterAssemblyTypes(assemblies)
			where typeof(IService).IsAssignableFrom(t)
			select t).SingleInstance().AsImplementedInterfaces();
		(from t in builder.RegisterAssemblyTypes(assemblies)
			where typeof(IViewModel).IsAssignableFrom(t)
			select t).SingleInstance().AsSelf();
		a19FcmmHSh = new NavigationService<VM>();
		LLOFXT3rXd = new GICTSSettingsWrapper().LoadSettings(IDRAConstant.GICTSSettingsFilePath).Result;
		ILocalAPIGameSettings localAPIGameSettings2;
		if (!Mt47dshSEu().UseGSPro || Mt47dshSEu().UseE6Connect)
		{
			ILocalAPIGameSettings localAPIGameSettings = new LocalAPITruSimSettings();
			localAPIGameSettings2 = localAPIGameSettings;
		}
		else
		{
			ILocalAPIGameSettings localAPIGameSettings = new LocalAPIGSProSettings();
			localAPIGameSettings2 = localAPIGameSettings;
		}
		pAEFZ22Jap = localAPIGameSettings2;
		builder.RegisterInstance(Fda76JSmXr()).As<INavigationService<VM>>().SingleInstance();
		builder.RegisterInstance(Mt47dshSEu()).As<IGICTSSettings>().SingleInstance();
		builder.RegisterInstance(ipQ7zsITn3()).As<ILocalAPIGameSettings>().SingleInstance();
		builder.RegisterInstance(DialogCoordinator.Instance).As<IDialogCoordinator>().SingleInstance();
		builder = ContainerConfig.IntegrateToolkitDependencies(ref builder);
		builder = MXm7H1QZOC(builder);
		esUFyfWjKm = new CircularLogService();
		F557bMnqj2().SetupLogFile(IDRAConstant.IdraMonitorLogDirectoryPath, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5226), useTraceLoggingMethod: false, 30, 1048576L);
		F557bMnqj2().SetLogLevel(LogLevel.Debug);
		builder.RegisterInstance(F557bMnqj2()).As<ICircularLogService>().SingleInstance();
		using (ILifetimeScope context = builder.Build().BeginLifetimeScope())
		{
			aWIFRSmV4a = context.Resolve<ContainerViewModel>();
			rs0FmeiJFe = context.Resolve<MainViewModel>();
			XPfFiN7bM3 = context.Resolve<OptionDialogViewModel>();
			I8vFh1uwiv = context.Resolve<PasswordViewModel>();
			Yq7FBoTsfv = context.Resolve<AdminMenuViewModel>();
			jiKFAty2Zj = context.Resolve<GSProOptionMenuViewModel>();
			DPKFYStaDZ = context.Resolve<ManagerSettingsMenuViewModel>();
			RxLFKmthIt = context.Resolve<ISoftwareAzureBlobUpdater>();
		}
		Fda76JSmXr().AddPage(btTFF2wRqy(), VM.Main);
		Fda76JSmXr().AddPage(aUCF2IjcyA(), VM.OptionDialog);
		Fda76JSmXr().AddPage(slXFqs1LYb(), VM.PasswordWindow);
		Fda76JSmXr().AddPage(RfiFWJFPqL(), VM.AdminMenu);
		Fda76JSmXr().AddPage(Sj7FJssV6M(), VM.GSProOptionMenu);
		Fda76JSmXr().AddPage(bjkF1gXIXx(), VM.ManagerSettingMenu);
	}

	private static ContainerBuilder MXm7H1QZOC(ContainerBuilder P_0)
	{
		IContainer container = P_0.Build();
		ContainerBuilder containerBuilder = new ContainerBuilder();
		foreach (IComponentRegistration item in container.ComponentRegistry.Registrations.Where((IComponentRegistration cr) => cr.Activator.LimitType != typeof(ICircularLogService)))
		{
			containerBuilder.RegisterComponent(item);
		}
		foreach (IRegistrationSource source in container.ComponentRegistry.Sources)
		{
			containerBuilder.RegisterSource(source);
		}
		return containerBuilder;
	}

	public static void OF07ad7VOo()
	{
	}
}
