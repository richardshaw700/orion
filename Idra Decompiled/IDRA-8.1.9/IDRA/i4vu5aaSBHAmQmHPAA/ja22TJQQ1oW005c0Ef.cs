using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Autofac;
using Autofac.Core;
using GICTS.Core;
using GICTSCore.Data;
using GIToolkit;
using GIToolkit.Services;
using GhU84wwqvI4UZ3pBfu;
using IDRA.Auxiliary.Navigations;
using IDRA.ViewModels;
using MahApps.Metro.Controls.Dialogs;
using sxB8TYTZ87aKuujytY;

namespace i4vu5aaSBHAmQmHPAA;

internal class ja22TJQQ1oW005c0Ef
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public Type hWEILPETS9;

		public _003C_003Ec__DisplayClass46_0()
		{
			RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
			base._002Ector();
		}

		internal bool idMI9yg8th(IComponentRegistration cr)
		{
			return cr.Activator.LimitType != hWEILPETS9;
		}
	}

	[CompilerGenerated]
	private readonly INavigationService<VM> ql5akM5wsE;

	[CompilerGenerated]
	private readonly IGICTSDirector FJea2rsMIf;

	[CompilerGenerated]
	private readonly ICircularLogService AWNaybhAaw;

	[CompilerGenerated]
	private readonly ContainerViewModel GTFagSsyZO;

	[CompilerGenerated]
	private readonly MainViewModel sJTa4ldvjo;

	[CompilerGenerated]
	private readonly CustomShotViewModel UXEa3CBRSd;

	[CompilerGenerated]
	private readonly PasswordViewModel ACDatnuKlr;

	[CompilerGenerated]
	private readonly ClubFaceCorrectionDatatableAdjustmentViewModel fCxajOgO2n;

	[CompilerGenerated]
	private readonly SpinDatatableAdjustmentViewModel QObaB5SntJ;

	[CompilerGenerated]
	private readonly ShotRegistrationViewModel geYaDm2ii4;

	[CompilerGenerated]
	private readonly PostShotViewModel NkqaeGjeny;

	[CompilerGenerated]
	private readonly PostShotHistoryViewModel iyKapYTIXe;

	[CompilerGenerated]
	private readonly PostShotSettingsViewModel AMma1G8kJo;

	[CompilerGenerated]
	private readonly PostShotMediaPlayerViewModel vfZaKjOwyx;

	[CompilerGenerated]
	private readonly CamerasTroubleshootingViewModel mx8aUjLZDM;

	[SpecialName]
	[CompilerGenerated]
	public INavigationService<VM> WXwQ59MLcU()
	{
		return ql5akM5wsE;
	}

	[SpecialName]
	[CompilerGenerated]
	public IGICTSDirector T14asET399()
	{
		return FJea2rsMIf;
	}

	[SpecialName]
	[CompilerGenerated]
	public ICircularLogService CeWadYohCQ()
	{
		return AWNaybhAaw;
	}

	[SpecialName]
	[CompilerGenerated]
	public ContainerViewModel jPfaEPK6a5()
	{
		return GTFagSsyZO;
	}

	[SpecialName]
	[CompilerGenerated]
	public MainViewModel nipaam1PUm()
	{
		return sJTa4ldvjo;
	}

	[SpecialName]
	[CompilerGenerated]
	public CustomShotViewModel C3OaCe6EC7()
	{
		return UXEa3CBRSd;
	}

	[SpecialName]
	[CompilerGenerated]
	public PasswordViewModel Miya7fIUB9()
	{
		return ACDatnuKlr;
	}

	[SpecialName]
	[CompilerGenerated]
	public ClubFaceCorrectionDatatableAdjustmentViewModel FAba83boKC()
	{
		return fCxajOgO2n;
	}

	[SpecialName]
	[CompilerGenerated]
	public SpinDatatableAdjustmentViewModel PZiaFDqJTI()
	{
		return QObaB5SntJ;
	}

	[SpecialName]
	[CompilerGenerated]
	public ShotRegistrationViewModel B4ga607I3Z()
	{
		return geYaDm2ii4;
	}

	[SpecialName]
	[CompilerGenerated]
	public PostShotViewModel SSlauA8abg()
	{
		return NkqaeGjeny;
	}

	[SpecialName]
	[CompilerGenerated]
	public PostShotHistoryViewModel cCbaOmudIm()
	{
		return iyKapYTIXe;
	}

	[SpecialName]
	[CompilerGenerated]
	public PostShotSettingsViewModel Y5gaP2LBgs()
	{
		return AMma1G8kJo;
	}

	[SpecialName]
	[CompilerGenerated]
	public PostShotMediaPlayerViewModel c1DarRD7Wv()
	{
		return vfZaKjOwyx;
	}

	[SpecialName]
	[CompilerGenerated]
	public CamerasTroubleshootingViewModel EWiaZ9O4lu()
	{
		return mx8aUjLZDM;
	}

	public ja22TJQQ1oW005c0Ef(string[] P_0)
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		base._002Ector();
		ContainerBuilder builder = new ContainerBuilder();
		Assembly[] assemblies = (from x in AppDomain.CurrentDomain.GetAssemblies()
			where x.FullName.Contains(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20810)) || x.FullName.Contains(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20822))
			select x).ToArray();
		(from t in builder.RegisterAssemblyTypes(assemblies)
			where typeof(IService).IsAssignableFrom(t)
			select t).SingleInstance().AsImplementedInterfaces();
		(from t in builder.RegisterAssemblyTypes(assemblies)
			where typeof(IViewModel).IsAssignableFrom(t)
			select t).SingleInstance().AsSelf();
		ql5akM5wsE = new NavigationService<VM>();
		builder.RegisterInstance(WXwQ59MLcU()).As<INavigationService<VM>>().SingleInstance();
		builder.RegisterInstance(DialogCoordinator.Instance).As<IDialogCoordinator>().SingleInstance();
		builder = ContainerConfig.IntegrateToolkitDependencies(ref builder);
		builder = t2UQWXr5UH(builder, typeof(ICircularLogService));
		AWNaybhAaw = new CircularLogService();
		CeWadYohCQ().SetupLogFile(IDRAConstant.IdraLogDirectoryPath, QQXBLjLprwI58ya4VR.y8v8TMFOCb(7512), useTraceLoggingMethod: true, 30, 1048576L);
		CeWadYohCQ().SetLogLevel(LogLevel.Debug);
		builder.RegisterInstance(CeWadYohCQ()).As<ICircularLogService>().SingleInstance();
		using (ILifetimeScope context = builder.Build().BeginLifetimeScope())
		{
			FJea2rsMIf = context.Resolve<IGICTSDirector>();
			GTFagSsyZO = context.Resolve<ContainerViewModel>();
			sJTa4ldvjo = context.Resolve<MainViewModel>();
			UXEa3CBRSd = context.Resolve<CustomShotViewModel>();
			ACDatnuKlr = context.Resolve<PasswordViewModel>();
			fCxajOgO2n = context.Resolve<ClubFaceCorrectionDatatableAdjustmentViewModel>();
			QObaB5SntJ = context.Resolve<SpinDatatableAdjustmentViewModel>();
			geYaDm2ii4 = context.Resolve<ShotRegistrationViewModel>();
			NkqaeGjeny = context.Resolve<PostShotViewModel>();
			iyKapYTIXe = context.Resolve<PostShotHistoryViewModel>();
			AMma1G8kJo = context.Resolve<PostShotSettingsViewModel>();
			vfZaKjOwyx = context.Resolve<PostShotMediaPlayerViewModel>();
			mx8aUjLZDM = context.Resolve<CamerasTroubleshootingViewModel>();
		}
		WXwQ59MLcU().AddPage(nipaam1PUm(), VM.Main);
		WXwQ59MLcU().AddPage(Miya7fIUB9(), VM.Password);
		WXwQ59MLcU().AddPage(FAba83boKC(), VM.ClubFaceCorrectionDatatableAdjustment);
		WXwQ59MLcU().AddPage(PZiaFDqJTI(), VM.SpinDatatableAdjustment);
		WXwQ59MLcU().AddPage(B4ga607I3Z(), VM.ShotRegistration);
		WXwQ59MLcU().AddPage(SSlauA8abg(), VM.PostShot);
		WXwQ59MLcU().AddPage(cCbaOmudIm(), VM.PostShotHistory);
		WXwQ59MLcU().AddPage(Y5gaP2LBgs(), VM.PostShotSettings);
		WXwQ59MLcU().AddPage(EWiaZ9O4lu(), VM.CameraTroubleshooting);
	}

	private static ContainerBuilder t2UQWXr5UH(ContainerBuilder P_0, Type P_1)
	{
		_003C_003Ec__DisplayClass46_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass46_0();
		CS_0024_003C_003E8__locals2.hWEILPETS9 = P_1;
		IContainer container = P_0.Build();
		ContainerBuilder containerBuilder = new ContainerBuilder();
		foreach (IComponentRegistration item in container.ComponentRegistry.Registrations.Where((IComponentRegistration cr) => cr.Activator.LimitType != CS_0024_003C_003E8__locals2.hWEILPETS9))
		{
			containerBuilder.RegisterComponent(item);
		}
		foreach (IRegistrationSource source in container.ComponentRegistry.Sources)
		{
			containerBuilder.RegisterSource(source);
		}
		return containerBuilder;
	}

	public void HhlQoi4be0()
	{
		B4ga607I3Z()?.Dispose();
		c1DarRD7Wv()?.Dispose();
	}
}
