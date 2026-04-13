using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using GIToolkit.Services;
using GolfInLauncher.Views;
using Lmttrs0IQc7UR7Zpt6;
using NIBCqg5mvUgtrhh4WA;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher;

public class App : Application
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public Process CkYq11vJWy;

		public _003C_003Ec__DisplayClass2_0()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal bool t9LqXl6Cg2(Process p)
		{
			return p.ProcessName == CkYq11vJWy.ProcessName;
		}
	}

	private bool RinllUs06;

	protected override void OnExit(ExitEventArgs e)
	{
		CircularLogService.LogCloseTag();
	}

	protected override void OnStartup(StartupEventArgs e)
	{
		k7UKR7Zpt();
		yA8jZxGcE();
		sem2HjJQH();
	}

	private void k7UKR7Zpt()
	{
		try
		{
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass2_0();
			CS_0024_003C_003E8__locals3.CkYq11vJWy = Process.GetCurrentProcess();
			IEnumerable<Process> enumerable = from p in Process.GetProcesses()
				where p.ProcessName == CS_0024_003C_003E8__locals3.CkYq11vJWy.ProcessName
				select p;
			if (enumerable.Count() <= 1)
			{
				return;
			}
			foreach (Process item in enumerable)
			{
				if (CS_0024_003C_003E8__locals3.CkYq11vJWy.Id != item.Id)
				{
					item.Kill();
					item.Dispose();
				}
			}
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
			CircularLogService.UnsafeLog(ex.Message);
		}
	}

	private void sem2HjJQH()
	{
		ContainerView containerView = new ContainerView();
		((FrameworkElement)containerView).DataContext = new YWlpWuqd7l7sxcxaWB().YSBZ7sCVR1();
		((Window)containerView).ShowDialog();
	}

	private void yA8jZxGcE()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		AppDomain.CurrentDomain.UnhandledException += delegate(object P_0, UnhandledExceptionEventArgs P_1)
		{
			ANLm9xbeM((Exception)P_1.ExceptionObject, aL07ImwcwlxdnyfI30.olMQlwrxmw(944));
		};
		((Application)this).DispatcherUnhandledException += (DispatcherUnhandledExceptionEventHandler)delegate(object P_0, DispatcherUnhandledExceptionEventArgs P_1)
		{
			ANLm9xbeM(P_1.Exception, aL07ImwcwlxdnyfI30.olMQlwrxmw(1032));
			P_1.Handled = true;
		};
		TaskScheduler.UnobservedTaskException += delegate(object? s, UnobservedTaskExceptionEventArgs P_1)
		{
			ANLm9xbeM(P_1.Exception, aL07ImwcwlxdnyfI30.olMQlwrxmw(1132));
			P_1.SetObserved();
		};
	}

	private void ANLm9xbeM(Exception P_0, string P_1)
	{
		string text = aL07ImwcwlxdnyfI30.olMQlwrxmw(676) + P_1 + aL07ImwcwlxdnyfI30.olMQlwrxmw(722);
		try
		{
			AssemblyName name = Assembly.GetExecutingAssembly().GetName();
			text = string.Format(aL07ImwcwlxdnyfI30.olMQlwrxmw(728), name.Name, name.Version);
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
		}
		finally
		{
			EventViewerLogger.LogException(P_0);
			EventViewerLogger.LogWarning(aL07ImwcwlxdnyfI30.olMQlwrxmw(794) + text);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!RinllUs06)
		{
			RinllUs06 = true;
			Uri uri = new Uri(aL07ImwcwlxdnyfI30.olMQlwrxmw(872), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	[STAThread]
	[DebuggerNonUserCode]
	public static void Main()
	{
		App app = new App();
		app.InitializeComponent();
		((Application)app).Run();
	}

	[CompilerGenerated]
	private void myrI6Pact(object P_0, UnhandledExceptionEventArgs P_1)
	{
		ANLm9xbeM((Exception)P_1.ExceptionObject, aL07ImwcwlxdnyfI30.olMQlwrxmw(944));
	}

	[CompilerGenerated]
	private void ktjErbTU9(object P_0, DispatcherUnhandledExceptionEventArgs P_1)
	{
		ANLm9xbeM(P_1.Exception, aL07ImwcwlxdnyfI30.olMQlwrxmw(1032));
		P_1.Handled = true;
	}

	[CompilerGenerated]
	private void P15f4yc66(object? s, UnobservedTaskExceptionEventArgs P_1)
	{
		ANLm9xbeM(P_1.Exception, aL07ImwcwlxdnyfI30.olMQlwrxmw(1132));
		P_1.SetObserved();
	}
}
