using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace SimpleLoadingScreen;

public class App : Application
{
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	public void InitializeComponent()
	{
		((Application)this).StartupUri = new Uri("UpdateInProgressWindow.xaml", UriKind.Relative);
	}

	[STAThread]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	public static void Main()
	{
		App app = new App();
		app.InitializeComponent();
		((Application)app).Run();
	}
}
