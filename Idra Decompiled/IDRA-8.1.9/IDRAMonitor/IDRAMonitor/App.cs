using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using GICTS.Data;
using GICTSCore.Data;
using GIToolkit.Services;
using IDRAMonitor.Auxiliary.Helpers;
using IDRAMonitor.Auxiliary.Navigation;
using IDRAMonitor.Internationalization;
using IDRAMonitor.Views;
using hkpxmGISLhTJrZLcmi;
using jBnbmEXkwPOPpPQ9mC;
using r8FF027V5kft9n1ATY;

namespace IDRAMonitor;

public class App : Application
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public Process oPOGJPwmjm;

		public Func<Process, bool> jPaGvBI4iC;

		public _003C_003Ec__DisplayClass10_0()
		{
			sfdIMacorwsONDcXji.p9wJZFvkayjbK();
			base._002Ector();
		}

		internal bool HK2G3fIbL8(Process p)
		{
			return p.ProcessName == oPOGJPwmjm.ProcessName;
		}
	}

	private Jged61jttKo6ryRwn0 RRe3jHI07 = new Jged61jttKo6ryRwn0();

	[CompilerGenerated]
	private bool osFJBCTkC;

	private bool hulvY06GZ;

	public bool IsShuttingDown
	{
		[CompilerGenerated]
		get
		{
			return osFJBCTkC;
		}
		[CompilerGenerated]
		private set
		{
			osFJBCTkC = value;
		}
	}

	protected override void OnExit(ExitEventArgs e)
	{
		RRe3jHI07?.F557bMnqj2()?.LogFileCloseTag();
		((Application)this).OnExit(e);
	}

	protected override void OnStartup(StartupEventArgs e)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			TkfGt9n1A();
			oo67ryRwn();
			Helper.DisableWPFTabletSupport();
			DYg2rN6FS();
			Jgejd61tt();
			((Application)this).OnStartup(e);
		}
		catch (Exception ex)
		{
			if (!IsShuttingDown)
			{
				MessageBox.Show(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(34) + ex.Message + ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(136) + ex.InnerException?.Message);
				EventViewerLogger.LogException(ex);
				((Application)this).Shutdown();
			}
		}
	}

	private void Jgejd61tt()
	{
		ContainerView containerView = new ContainerView();
		((FrameworkElement)containerView).DataContext = RRe3jHI07.i7bFjFhrb8();
		((Window)containerView).Show();
		RRe3jHI07.Fda76JSmXr().NavigateTo(VM.Main);
	}

	private void oo67ryRwn()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		AppDomain.CurrentDomain.UnhandledException += delegate(object P_0, UnhandledExceptionEventArgs P_1)
		{
			IR8FFF02V((Exception)P_1.ExceptionObject, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(456));
		};
		((Application)this).DispatcherUnhandledException += (DispatcherUnhandledExceptionEventHandler)delegate(object P_0, DispatcherUnhandledExceptionEventArgs P_1)
		{
			IR8FFF02V(P_1.Exception, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(544));
			P_1.Handled = true;
		};
		TaskScheduler.UnobservedTaskException += delegate(object? s, UnobservedTaskExceptionEventArgs P_1)
		{
			IR8FFF02V(P_1.Exception, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(644));
			P_1.SetObserved();
		};
	}

	private void IR8FFF02V(Exception P_0, string P_1)
	{
		string text = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(142) + P_1 + ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(188);
		try
		{
			string fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
			text = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(194) + Assembly.GetExecutingAssembly().GetName().Name + ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(274) + fileVersion;
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
		}
		finally
		{
			EventViewerLogger.LogException(P_0);
			EventViewerLogger.LogWarning(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(282) + text);
		}
	}

	private void TkfGt9n1A()
	{
		_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass10_0();
		CS_0024_003C_003E8__locals5.oPOGJPwmjm = Process.GetCurrentProcess();
		try
		{
			foreach (Process item in from p in Process.GetProcesses()
				where p.ProcessName == CS_0024_003C_003E8__locals5.oPOGJPwmjm.ProcessName
				select p)
			{
				if (item.Id != CS_0024_003C_003E8__locals5.oPOGJPwmjm.Id)
				{
					item.Kill();
				}
			}
		}
		finally
		{
			if (CS_0024_003C_003E8__locals5.oPOGJPwmjm != null)
			{
				((IDisposable)CS_0024_003C_003E8__locals5.oPOGJPwmjm).Dispose();
			}
		}
	}

	private void DYg2rN6FS()
	{
		CultureResources cultureResources = new CultureResources();
		CultureInfo culture = new CultureInfo(IDRAConstant.EnglishCulture);
		cultureResources.SetCulture(culture);
		if (RRe3jHI07.Mt47dshSEu().Language == Language.French)
		{
			culture = new CultureInfo(IDRAConstant.FrenchCulture);
			cultureResources.SetCulture(culture);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	public void InitializeComponent()
	{
		if (!hulvY06GZ)
		{
			hulvY06GZ = true;
			Uri uri = new Uri(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(390), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	[STAThread]
	[DebuggerNonUserCode]
	public static void Main()
	{
		App app = new App();
		app.InitializeComponent();
		((Application)app).Run();
	}

	[CompilerGenerated]
	private void m8h9XU7Eg(object P_0, UnhandledExceptionEventArgs P_1)
	{
		IR8FFF02V((Exception)P_1.ExceptionObject, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(456));
	}

	[CompilerGenerated]
	private void QO4q0qay0(object P_0, DispatcherUnhandledExceptionEventArgs P_1)
	{
		IR8FFF02V(P_1.Exception, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(544));
		P_1.Handled = true;
	}

	[CompilerGenerated]
	private void LsttJef0a(object? s, UnobservedTaskExceptionEventArgs P_1)
	{
		IR8FFF02V(P_1.Exception, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(644));
		P_1.SetObserved();
	}
}
