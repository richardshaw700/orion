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
using GhU84wwqvI4UZ3pBfu;
using IDRA.Auxiliary.Helpers;
using IDRA.Auxiliary.Navigations;
using IDRA.Internationalization;
using IDRA.Views;
using i4vu5aaSBHAmQmHPAA;
using sxB8TYTZ87aKuujytY;

namespace IDRA;

public class App : Application
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public Process j1ZC5UW4Pc;

		public Func<Process, bool> Ev9Cz7GWsj;

		public _003C_003Ec__DisplayClass11_0()
		{
			RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
			base._002Ector();
		}

		internal bool ElhCoJ1Iff(Process p)
		{
			return p.ProcessName == j1ZC5UW4Pc.ProcessName;
		}
	}

	private ja22TJQQ1oW005c0Ef Yc0IEf74v;

	[CompilerGenerated]
	private bool p5a8SBHAm;

	private bool emHRPAA48;

	public bool IsShuttingDown
	{
		[CompilerGenerated]
		get
		{
			return p5a8SBHAm;
		}
		[CompilerGenerated]
		private set
		{
			p5a8SBHAm = value;
		}
	}

	protected override void OnExit(ExitEventArgs e)
	{
		Yc0IEf74v?.CeWadYohCQ()?.LogFileCloseTag();
		Yc0IEf74v?.HhlQoi4be0();
		((Application)this).OnExit(e);
	}

	protected override void OnStartup(StartupEventArgs e)
	{
		try
		{
			H5AQktUCH();
			JjRHn49vR();
			Helper.DisableWPFTabletSupport();
			Yc0IEf74v = new ja22TJQQ1oW005c0Ef(e.Args);
			J9FaK94Hs();
			N7DdIFVle();
			((Application)this).OnStartup(e);
		}
		catch (Exception ex)
		{
			if (!IsShuttingDown)
			{
				EventViewerLogger.LogException(ex);
				Yc0IEf74v?.CeWadYohCQ().Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(34) + ex.Message, LogLevel.Error);
				((Application)this).Shutdown();
			}
		}
	}

	private void Bc1xoFQb4(object P_0, ExitEventArgs P_1)
	{
		Yc0IEf74v.T14asET399().Release();
	}

	private void N7DdIFVle()
	{
		ContainerView containerView = new ContainerView();
		((FrameworkElement)containerView).DataContext = Yc0IEf74v.jPfaEPK6a5();
		((Window)containerView).Show();
		Yc0IEf74v.WXwQ59MLcU().NavigateTo(VM.Main);
		Yc0IEf74v.CeWadYohCQ().Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(114));
	}

	private void JjRHn49vR()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		AppDomain.CurrentDomain.UnhandledException += delegate(object P_0, UnhandledExceptionEventArgs P_1)
		{
			NT7Ee1qC6((Exception)P_1.ExceptionObject, QQXBLjLprwI58ya4VR.y8v8TMFOCb(432));
		};
		((Application)this).DispatcherUnhandledException += (DispatcherUnhandledExceptionEventHandler)delegate(object P_0, DispatcherUnhandledExceptionEventArgs P_1)
		{
			NT7Ee1qC6(P_1.Exception, QQXBLjLprwI58ya4VR.y8v8TMFOCb(520));
			P_1.Handled = true;
		};
		TaskScheduler.UnobservedTaskException += delegate(object? s, UnobservedTaskExceptionEventArgs P_1)
		{
			NT7Ee1qC6(P_1.Exception, QQXBLjLprwI58ya4VR.y8v8TMFOCb(620));
			P_1.SetObserved();
		};
	}

	private void NT7Ee1qC6(Exception P_0, string P_1)
	{
		string text = QQXBLjLprwI58ya4VR.y8v8TMFOCb(140) + P_1 + QQXBLjLprwI58ya4VR.y8v8TMFOCb(186);
		try
		{
			string fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
			text = QQXBLjLprwI58ya4VR.y8v8TMFOCb(192) + Assembly.GetExecutingAssembly().GetName().Name + QQXBLjLprwI58ya4VR.y8v8TMFOCb(256) + fileVersion;
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
		}
		finally
		{
			EventViewerLogger.LogException(P_0);
			EventViewerLogger.LogWarning(QQXBLjLprwI58ya4VR.y8v8TMFOCb(264) + text);
		}
	}

	private void H5AQktUCH()
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals5.j1ZC5UW4Pc = Process.GetCurrentProcess();
		try
		{
			foreach (Process item in from p in Process.GetProcesses()
				where p.ProcessName == CS_0024_003C_003E8__locals5.j1ZC5UW4Pc.ProcessName
				select p)
			{
				if (item.Id != CS_0024_003C_003E8__locals5.j1ZC5UW4Pc.Id)
				{
					item.Kill();
				}
			}
		}
		finally
		{
			if (CS_0024_003C_003E8__locals5.j1ZC5UW4Pc != null)
			{
				((IDisposable)CS_0024_003C_003E8__locals5.j1ZC5UW4Pc).Dispose();
			}
		}
	}

	private void J9FaK94Hs()
	{
		CultureResources cultureResources = new CultureResources();
		CultureInfo culture = new CultureInfo(IDRAConstant.EnglishCulture);
		cultureResources.SetCulture(culture);
		if (Yc0IEf74v.T14asET399().Settings.Language == Language.French)
		{
			culture = new CultureInfo(IDRAConstant.FrenchCulture);
			cultureResources.SetCulture(culture);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	public void InitializeComponent()
	{
		if (!emHRPAA48)
		{
			emHRPAA48 = true;
			Uri uri = new Uri(QQXBLjLprwI58ya4VR.y8v8TMFOCb(356), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[STAThread]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	public static void Main()
	{
		App app = new App();
		app.InitializeComponent();
		((Application)app).Run();
	}

	[CompilerGenerated]
	private void lQnqh98uh(object P_0, UnhandledExceptionEventArgs P_1)
	{
		NT7Ee1qC6((Exception)P_1.ExceptionObject, QQXBLjLprwI58ya4VR.y8v8TMFOCb(432));
	}

	[CompilerGenerated]
	private void XvqCVrQYC(object P_0, DispatcherUnhandledExceptionEventArgs P_1)
	{
		NT7Ee1qC6(P_1.Exception, QQXBLjLprwI58ya4VR.y8v8TMFOCb(520));
		P_1.Handled = true;
	}

	[CompilerGenerated]
	private void FMf0IIa22(object? s, UnobservedTaskExceptionEventArgs P_1)
	{
		NT7Ee1qC6(P_1.Exception, QQXBLjLprwI58ya4VR.y8v8TMFOCb(620));
		P_1.SetObserved();
	}
}
