using Autofac;
using GIToolkit.Services;

namespace GIToolkit;

public static class ContainerConfig
{
	public static ContainerBuilder IntegrateToolkitDependencies(ref ContainerBuilder builder)
	{
		builder.RegisterType<HtmlNodeReader>().As<IHtmlNodeReader>();
		builder.RegisterType<IOHelper>().As<IIOHelper>();
		builder.RegisterType<JsonHelper>().As<IJsonHelper>();
		builder.RegisterType<E6ConnectServices>().As<IE6ConnectServices>();
		builder.RegisterType<GIEnvironnement>().As<IGIEnvironnement>();
		builder.RegisterType<LauncherServices>().As<ILauncherServices>();
		builder.RegisterType<NetworkUtility>().As<INetworkUtility>();
		builder.RegisterType<ProcessHelper>().As<IProcessHelper>();
		builder.RegisterType<LocalCachingServices>().As<ILocalCachingServices>();
		builder.RegisterType<ThreadHelper>().As<IThreadHelper>();
		builder.RegisterType<ExceptionHelper>().As<IExceptionHelper>();
		builder.RegisterType<MicrosoftGraphService>().As<IMicrosoftGraphService>();
		builder.RegisterType<ZoneGolfInDriveService>().As<IZoneGolfInDriveService>();
		builder.RegisterType<ZoneGolfInApi>().As<IZoneGolfInApi>();
		builder.RegisterType<PowershellService>().As<IPowershellService>();
		builder.RegisterType<WifiService>().As<IWifiService>();
		builder.RegisterType<CustomStopwatch>().As<ICustomStopwatch>();
		builder.RegisterType<SoftwareUpdaterBase>().As<ISoftwareUpdaterBase>();
		builder.RegisterType<MessagingService>().As<IMessagingService>();
		builder.RegisterType<SoftwareAzureBlobUpdater>().As<ISoftwareAzureBlobUpdater>();
		builder.RegisterType<AzureStorageFileShareService>().As<IAzureStorageFileShareService>();
		builder.RegisterType<ConfigurationHelper>().As<IConfigurationHelper>();
		builder.RegisterType<CircularLogService>().As<ICircularLogService>().SingleInstance();
		builder.RegisterType<XmlHelper>().As<IXmlHelper>();
		return builder;
	}
}
