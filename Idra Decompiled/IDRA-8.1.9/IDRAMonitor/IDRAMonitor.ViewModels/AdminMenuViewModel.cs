using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GICTS.Data;
using GICTSCore.Data;
using GICTSCore.Services;
using GIToolkit.Model;
using GIToolkit.Services;
using IDRAMonitor.Auxiliary.Navigation;
using IDRAMonitor.Services;
using MahApps.Metro.Controls.Dialogs;
using hkpxmGISLhTJrZLcmi;
using jBnbmEXkwPOPpPQ9mC;

namespace IDRAMonitor.ViewModels;

public class AdminMenuViewModel : ObservableRecipient, IViewModel
{
	private bool ThM0TpfbZ;

	private string PqfeTcgZl;

	private IdraMode FinlE1C5N;

	private bool mZy8ggJmX;

	private LogRegistration rSJkJr3vT;

	private ObservableCollection<string> Wij4ckNuw;

	private int z0dUC5Jsx;

	private bool i0Xf69h6U;

	private string YA2MEnFKa;

	private readonly IDialogCoordinator IEADWdusn;

	private readonly IMessagingService FC2HyMU2p;

	private readonly IProjectProcessService Q8AasYfEc;

	private readonly INavigationService<VM> rH36mIggU;

	private readonly IIdraModeService l9m5HJWmA;

	private readonly ILocalAPIGameSettings KdkdJdDNH;

	private readonly IGICTSSettings RLuS4I0Yh;

	private readonly ICircularLogService jihnkit5l;

	private readonly IGICTSSettingsWrapper YuXor7EMF;

	private readonly IAzureStorageFileShareService kTEbYtINl;

	private FileProcessCommunication PkDsU2Slp;

	public bool ShowProgress
	{
		get
		{
			return ThM0TpfbZ;
		}
		set
		{
			SetProperty(ref ThM0TpfbZ, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2278));
		}
	}

	public string ProgressionText
	{
		get
		{
			return PqfeTcgZl;
		}
		set
		{
			SetProperty(ref PqfeTcgZl, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2306));
		}
	}

	public IdraMode CurrentMode
	{
		get
		{
			return FinlE1C5N;
		}
		set
		{
			SetProperty(ref FinlE1C5N, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2340));
		}
	}

	public bool IsLoading
	{
		get
		{
			return mZy8ggJmX;
		}
		set
		{
			SetProperty(ref mZy8ggJmX, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2366));
		}
	}

	public LogRegistration NewLogForm
	{
		get
		{
			return rSJkJr3vT;
		}
		set
		{
			SetProperty(ref rSJkJr3vT, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2388));
		}
	}

	public ObservableCollection<string> AllShotNames
	{
		get
		{
			return Wij4ckNuw;
		}
		set
		{
			SetProperty(ref Wij4ckNuw, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2412));
		}
	}

	public int SelectedShotID
	{
		get
		{
			return z0dUC5Jsx;
		}
		set
		{
			SetProperty(ref z0dUC5Jsx, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2440));
		}
	}

	public bool IsIdraSavingShot
	{
		get
		{
			return i0Xf69h6U;
		}
		set
		{
			SetProperty(ref i0Xf69h6U, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2472));
		}
	}

	public string IdraSavingShotUntil
	{
		get
		{
			return YA2MEnFKa;
		}
		set
		{
			SetProperty(ref YA2MEnFKa, value, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2508));
		}
	}

	public ICommand WindowLoadedCommand => new RelayCommand(delegate
	{
		try
		{
			IsLoading = true;
			List<string> list = new DirectoryInfo(IDRAConstant.GICTSSamplesResultsFolder).GetDirectories()?.OrderByDescending((DirectoryInfo x) => x.LastWriteTime)?.Select((DirectoryInfo x) => x.Name).ToList();
			list?.Insert(0, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2706));
			AllShotNames = new ObservableCollection<string>(list ?? new List<string> { ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2724) });
			SelectedShotID = 0;
			(bool, DateTime) tuple = l9m5HJWmA.IsIdraSavingShots();
			IsIdraSavingShot = tuple.Item1;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2762));
			defaultInterpolatedStringHandler.AppendFormatted(tuple.Item2, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2804));
			IdraSavingShotUntil = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		finally
		{
			IsLoading = false;
		}
	});

	public ICommand PlayModeCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		jihnkit5l.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7764));
		ShowProgress = true;
		await l9m5HJWmA.SetMode(IdraMode.Play);
		await Task.Delay(1000);
		l9m5HJWmA.CloseGame(KdkdJdDNH.ProcessName);
		await Q8AasYfEc.CloseApplication();
		ShowProgress = false;
	});

	public ICommand ShotDiagnosticModeCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		jihnkit5l.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7826));
		ShowProgress = true;
		await l9m5HJWmA.SetMode(IdraMode.ShotDiagnostic);
		await Task.Delay(1000);
		l9m5HJWmA.CloseGame(KdkdJdDNH.ProcessName);
		await Q8AasYfEc.CloseApplication();
		ShowProgress = false;
	});

	public ICommand TroubleShootingModeCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		jihnkit5l.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7998));
		ShowProgress = true;
		await l9m5HJWmA.SetMode(IdraMode.TroubleShooting);
		await Task.Delay(1000);
		l9m5HJWmA.CloseGame(KdkdJdDNH.ProcessName);
		await Q8AasYfEc.CloseApplication();
		ShowProgress = false;
	});

	public ICommand ShotRegistrationModeCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		jihnkit5l.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7910));
		ShowProgress = true;
		await l9m5HJWmA.SetMode(IdraMode.ShotRegistration);
		await Task.Delay(1000);
		l9m5HJWmA.CloseGame(KdkdJdDNH.ProcessName);
		await Q8AasYfEc.CloseApplication();
		ShowProgress = false;
	});

	public ICommand ExitCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		jihnkit5l.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7124));
		ShowProgress = true;
		await Q8AasYfEc.CloseApplication();
	});

	public ICommand CancelCommand => new RelayCommand(delegate
	{
		jihnkit5l.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2846));
		rH36mIggU.NavigateTo(VM.Main);
	});

	public ICommand NewLogRegistrationCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		_ = 2;
		try
		{
			jihnkit5l.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7216), NewLogForm);
			ShowProgress = true;
			ProgressionText = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7306);
			string connectionStringName = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7398);
			string fileShareName = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7464);
			kTEbYtINl.SetupServiceConnection(connectionStringName, fileShareName);
			aZLVcmiif();
			if (NewLogForm.ShotName == ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2706))
			{
				LogRegistration newLogForm = NewLogForm;
				string shotName = newLogForm.ShotName;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7500));
				defaultInterpolatedStringHandler.AppendFormatted(Guid.NewGuid());
				newLogForm.ShotName = shotName + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			await kTEbYtINl.UploadShot(NewLogForm);
			await IEADWdusn.ShowMessageAsync(this, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7510), ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7528));
			NewLogForm = new LogRegistration();
			SelectedShotID = 0;
			NewLogForm.ShotName = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2706);
		}
		catch (Exception ex)
		{
			await IEADWdusn.ShowMessageAsync(this, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7576), ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7590) + ex.Message);
			jihnkit5l.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7648) + ex.Message, LogLevel.Error);
		}
		finally
		{
			ShowProgress = false;
		}
	});

	public AdminMenuViewModel(IDialogCoordinator dialogCoordinator, IMessagingService messagingService, IProjectProcessService projectProcessService, INavigationService<VM> navigationService, IIdraModeService idraModeService, ILocalAPIGameSettings localAPIGameSettings, IGICTSSettings gICTSSettings, ICircularLogService circularLogService, IGICTSSettingsWrapper gICTSSettingsWrapper, IAzureStorageFileShareService azureStorageFileShareService)
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		PqfeTcgZl = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2550);
		base._002Ector();
		IEADWdusn = dialogCoordinator;
		FC2HyMU2p = messagingService;
		Q8AasYfEc = projectProcessService;
		rH36mIggU = navigationService;
		l9m5HJWmA = idraModeService;
		KdkdJdDNH = localAPIGameSettings;
		RLuS4I0Yh = gICTSSettings;
		jihnkit5l = circularLogService;
		YuXor7EMF = gICTSSettingsWrapper;
		kTEbYtINl = azureStorageFileShareService;
		CurrentMode = Task.Run((Func<Task<IdraMode>?>)l9m5HJWmA.GetCurrentMode).Result;
		jihnkit5l.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2648) + Enum.GetName(typeof(IdraMode), CurrentMode));
		Task.Run(async delegate
		{
			PkDsU2Slp = await FileProcessCommunication.GetInstanceAsync(new IDRAtoIDRAMCommunication(), jihnkit5l);
		}).Wait();
		NewLogForm = new LogRegistration();
	}

	private void aZLVcmiif()
	{
		NewLogForm.LogsFile = new List<FileInfo>();
		NewLogForm.LogsFile.AddRange(UIMwaorws(IDRAConstant.GICTSCamLogCamerasDirectoryPath, 3));
		NewLogForm.LogsFile.AddRange(UIMwaorws(IDRAConstant.ApiCommGSProLogDirectoryPath, 3));
		NewLogForm.LogsFile.AddRange(UIMwaorws(IDRAConstant.ApiCommLogDirectoryPath, 3));
		NewLogForm.LogsFile.AddRange(UIMwaorws(IDRAConstant.IdraMonitorLogDirectoryPath, 3));
		NewLogForm.LogsFile.AddRange(UIMwaorws(IDRAConstant.IdraLogDirectoryPath, 3));
	}

	private IEnumerable<FileInfo> UIMwaorws(string P_0, int P_1)
	{
		if (!Directory.Exists(P_0))
		{
			return new List<FileInfo>();
		}
		return (from x in new DirectoryInfo(P_0).GetFiles()
			orderby x.LastWriteTime descending
			select x).Take(P_1);
	}

	[CompilerGenerated]
	private async Task? ENDgcXji3()
	{
		PkDsU2Slp = await FileProcessCommunication.GetInstanceAsync(new IDRAtoIDRAMCommunication(), jihnkit5l);
	}

	[CompilerGenerated]
	private void unbLmEkwP()
	{
		try
		{
			IsLoading = true;
			List<string> list = new DirectoryInfo(IDRAConstant.GICTSSamplesResultsFolder).GetDirectories()?.OrderByDescending((DirectoryInfo x) => x.LastWriteTime)?.Select((DirectoryInfo x) => x.Name).ToList();
			list?.Insert(0, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2706));
			AllShotNames = new ObservableCollection<string>(list ?? new List<string> { ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2724) });
			SelectedShotID = 0;
			(bool, DateTime) tuple = l9m5HJWmA.IsIdraSavingShots();
			IsIdraSavingShot = tuple.Item1;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2762));
			defaultInterpolatedStringHandler.AppendFormatted(tuple.Item2, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2804));
			IdraSavingShotUntil = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		finally
		{
			IsLoading = false;
		}
	}

	[CompilerGenerated]
	private async Task EPpxPQ9mC()
	{
		jihnkit5l.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7764));
		ShowProgress = true;
		await l9m5HJWmA.SetMode(IdraMode.Play);
		await Task.Delay(1000);
		l9m5HJWmA.CloseGame(KdkdJdDNH.ProcessName);
		await Q8AasYfEc.CloseApplication();
		ShowProgress = false;
	}

	[CompilerGenerated]
	private async Task Pn2TYqYB5()
	{
		jihnkit5l.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7826));
		ShowProgress = true;
		await l9m5HJWmA.SetMode(IdraMode.ShotDiagnostic);
		await Task.Delay(1000);
		l9m5HJWmA.CloseGame(KdkdJdDNH.ProcessName);
		await Q8AasYfEc.CloseApplication();
		ShowProgress = false;
	}

	[CompilerGenerated]
	private async Task P2LOlJXbx()
	{
		jihnkit5l.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7998));
		ShowProgress = true;
		await l9m5HJWmA.SetMode(IdraMode.TroubleShooting);
		await Task.Delay(1000);
		l9m5HJWmA.CloseGame(KdkdJdDNH.ProcessName);
		await Q8AasYfEc.CloseApplication();
		ShowProgress = false;
	}

	[CompilerGenerated]
	private async Task HdJNhduKq()
	{
		jihnkit5l.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7910));
		ShowProgress = true;
		await l9m5HJWmA.SetMode(IdraMode.ShotRegistration);
		await Task.Delay(1000);
		l9m5HJWmA.CloseGame(KdkdJdDNH.ProcessName);
		await Q8AasYfEc.CloseApplication();
		ShowProgress = false;
	}

	[CompilerGenerated]
	private async Task hhkEBqv7S()
	{
		jihnkit5l.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7124));
		ShowProgress = true;
		await Q8AasYfEc.CloseApplication();
	}

	[CompilerGenerated]
	private void ej3uOckCS()
	{
		jihnkit5l.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2846));
		rH36mIggU.NavigateTo(VM.Main);
	}

	[CompilerGenerated]
	private async Task JW2pfRNgb()
	{
		_ = 2;
		try
		{
			jihnkit5l.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7216), NewLogForm);
			ShowProgress = true;
			ProgressionText = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7306);
			string connectionStringName = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7398);
			string fileShareName = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7464);
			kTEbYtINl.SetupServiceConnection(connectionStringName, fileShareName);
			aZLVcmiif();
			if (NewLogForm.ShotName == ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2706))
			{
				LogRegistration newLogForm = NewLogForm;
				string shotName = newLogForm.ShotName;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7500));
				defaultInterpolatedStringHandler.AppendFormatted(Guid.NewGuid());
				newLogForm.ShotName = shotName + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			await kTEbYtINl.UploadShot(NewLogForm);
			await IEADWdusn.ShowMessageAsync(this, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7510), ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7528));
			NewLogForm = new LogRegistration();
			SelectedShotID = 0;
			NewLogForm.ShotName = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(2706);
		}
		catch (Exception ex)
		{
			await IEADWdusn.ShowMessageAsync(this, ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7576), ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7590) + ex.Message);
			jihnkit5l.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(7648) + ex.Message, LogLevel.Error);
		}
		finally
		{
			ShowProgress = false;
		}
	}
}
