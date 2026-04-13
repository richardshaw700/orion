using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Threading;
using GIToolkit.Services;

namespace SimpleLoadingScreen;

public class MainWindow : Window, IComponentConnector
{
	private Process? _idraProcessMonitor;

	private readonly IProcessHelper _processHelper;

	private Version _oldVersion;

	private double _maxCheckingTime = TimeSpan.FromMinutes(2.0).TotalMilliseconds;

	internal Button btn_close;

	private bool _contentLoaded;

	private string IDRAMonitorExePath => ProcessConstant.IdraProcessPath + "\\" + ProcessConstant.IdraMonitorProcess;

	public MainWindow()
	{
		InitializeComponent();
		((UIElement)btn_close).Visibility = (Visibility)2;
		_processHelper = new ProcessHelper();
		_oldVersion = GetFileVersionInfo(ProcessConstant.IdraProcessPath + "\\" + ProcessConstant.IdraProcess);
		EventViewerLogger.LogInformation($"{DateTime.Now} - Old IDRA version was : {_oldVersion}", 210);
		Task.Run(async delegate
		{
			DateTime now = DateTime.Now;
			while (true)
			{
				try
				{
					bool flag = (DateTime.Now - now).TotalMilliseconds > _maxCheckingTime;
					if (flag)
					{
						((DispatcherObject)Application.Current).Dispatcher.Invoke<Visibility>((Func<Visibility>)delegate
						{
							//IL_0008: Unknown result type (might be due to invalid IL or missing references)
							//IL_000e: Unknown result type (might be due to invalid IL or missing references)
							Button obj = btn_close;
							Visibility result = (Visibility)0;
							((UIElement)obj).Visibility = (Visibility)0;
							return result;
						});
					}
					Version fileVersionInfo = GetFileVersionInfo(ProcessConstant.IdraProcessPath + "\\" + ProcessConstant.IdraProcess);
					bool flag2 = File.Exists(IDRAMonitorExePath);
					if ((fileVersionInfo != new Version() && _oldVersion != fileVersionInfo && flag2) || flag)
					{
						EventViewerLogger.LogInformation($"{DateTime.Now} - Launching IDRA monitor old version : {_oldVersion} new version : {fileVersionInfo}. Here from exceed time ?: {flag}", 210);
						await Task.Delay((int)TimeSpan.FromSeconds(20.0).TotalMilliseconds);
						await LaunchIdraMonitor();
						await Task.Delay((int)TimeSpan.FromSeconds(5.0).TotalMilliseconds);
						CloseApplication();
						break;
					}
					await Task.Delay(1000);
				}
				catch (Exception ex)
				{
					EventViewerLogger.LogException(ex);
					CloseApplication();
					break;
				}
			}
		});
	}

	public Version GetFileVersionInfo(string pathToFile)
	{
		if (!File.Exists(pathToFile))
		{
			return new Version();
		}
		FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(pathToFile);
		if (versionInfo == null || versionInfo.FileVersion == null)
		{
			return new Version();
		}
		return new Version(versionInfo.FileVersion);
	}

	public async Task LaunchIdraMonitor()
	{
		if (_idraProcessMonitor != null)
		{
			if (!_idraProcessMonitor.HasExited)
			{
				EventViewerLogger.LogInformation($"{DateTime.Now} - SimpleLoadingScreen has to kill IDRA before launching it", 210);
				_idraProcessMonitor.Kill();
			}
			_idraProcessMonitor.Dispose();
			_idraProcessMonitor = null;
		}
		Process processByName = _processHelper.GetProcessByName(ProcessConstant.IdraMonitorProcess);
		bool flag = processByName != null;
		_idraProcessMonitor = (flag ? processByName : _processHelper.CreateProcess(IDRAMonitorExePath, ProcessConstant.IdraProcessPath, null));
		if (!flag && _idraProcessMonitor != null)
		{
			try
			{
				_idraProcessMonitor.Start();
				EventViewerLogger.LogInformation($"{DateTime.Now} - SimpleLoadingScreen has launch IDRA Monitor", 210);
			}
			catch (Exception ex)
			{
				EventViewerLogger.LogException(ex);
				await Task.Delay(1000);
				_idraProcessMonitor.Start();
			}
		}
		_processHelper.ModifyWindowState(_idraProcessMonitor?.ProcessName, ShowWindowEnum.Restore, setFocus: true);
	}

	private void Close_Click(object sender, RoutedEventArgs e)
	{
		CloseApplication();
	}

	private void CloseApplication()
	{
		try
		{
			((DispatcherObject)Application.Current).Dispatcher.Invoke((Action)delegate
			{
				((Window)this).Close();
			});
		}
		catch (Exception)
		{
			Environment.Exit(0);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/SimpleLoadingScreen;component/mainwindow.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		if (connectionId == 1)
		{
			btn_close = (Button)target;
			((ButtonBase)btn_close).Click += new RoutedEventHandler(Close_Click);
		}
		else
		{
			_contentLoaded = true;
		}
	}
}
