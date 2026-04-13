using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GICTS.Core;
using GICTSCore.Data;
using GICTSCore.Services;
using GIToolkit.Services;
using GhU84wwqvI4UZ3pBfu;
using IDRA.Auxiliary.Navigations;
using MahApps.Metro.Controls.Dialogs;
using sxB8TYTZ87aKuujytY;

namespace IDRA.ViewModels;

public class SpinDatatableAdjustmentViewModel : ObservableRecipient, IViewModel
{
	private DataSpinConfigModel ikYQUoAdbP;

	private ObservableCollection<ObservableCollection<float>> I6wQV7Z5Bi;

	private ObservableCollection<string> rIKQGx37l7;

	private ObservableCollection<string> qF7QXNtyNI;

	private bool dRiQ9AKyYA;

	private int e6jQLneSmQ;

	private SpinVariableType iGaQT6aAUP;

	private ObservableCollection<string> jDMQNljilV;

	private int Yk4QwqUXfD;

	private SpinClubAjustment X67QYIDxA1;

	private bool a1VQvDrXqo;

	private IDialogCoordinator bLxQhqaM48;

	private readonly IGICTSDirector a3gQSw6paJ;

	private readonly INavigationService<VM> dqSQivciOb;

	private readonly IDataSpinService UU4QnVGxm1;

	private readonly ICircularLogService M0SQfPCasX;

	public DataSpinConfigModel DataSpinModel
	{
		get
		{
			return ikYQUoAdbP;
		}
		set
		{
			SetProperty(ref ikYQUoAdbP, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(3220));
		}
	}

	public ObservableCollection<ObservableCollection<float>> SpinFactorsMap
	{
		get
		{
			return I6wQV7Z5Bi;
		}
		set
		{
			SetProperty(ref I6wQV7Z5Bi, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(7246));
		}
	}

	public ObservableCollection<string> BallSpeedHeaders
	{
		get
		{
			return rIKQGx37l7;
		}
		set
		{
			SetProperty(ref rIKQGx37l7, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(3290));
		}
	}

	public ObservableCollection<string> LaunchAngleHeaders
	{
		get
		{
			return qF7QXNtyNI;
		}
		set
		{
			SetProperty(ref qF7QXNtyNI, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(7278));
		}
	}

	public bool IsMinimized
	{
		get
		{
			return dRiQ9AKyYA;
		}
		set
		{
			SetProperty(ref dRiQ9AKyYA, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(3368));
		}
	}

	public int BulkEditFactor
	{
		get
		{
			return e6jQLneSmQ;
		}
		set
		{
			SetProperty(ref e6jQLneSmQ, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(3394));
		}
	}

	public SpinVariableType CurrentSpinVariable
	{
		get
		{
			return iGaQT6aAUP;
		}
		set
		{
			SetProperty(ref iGaQT6aAUP, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(3426));
			((DispatcherObject)Application.Current).Dispatcher.Invoke((Action)delegate
			{
				if (iGaQT6aAUP == SpinVariableType.LaunchAngle)
				{
					AvailableValues = LaunchAngleHeaders;
				}
				else if (iGaQT6aAUP == SpinVariableType.BallSpeed)
				{
					AvailableValues = BallSpeedHeaders;
				}
			});
		}
	}

	public ObservableCollection<string> AvailableValues
	{
		get
		{
			return jDMQNljilV;
		}
		set
		{
			SetProperty(ref jDMQNljilV, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(3468));
		}
	}

	public int CurrentValueIndex
	{
		get
		{
			return Yk4QwqUXfD;
		}
		set
		{
			SetProperty(ref Yk4QwqUXfD, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(3502));
		}
	}

	public SpinClubAjustment SelectedSpinClubAjustment
	{
		get
		{
			return X67QYIDxA1;
		}
		set
		{
			SetProperty(ref X67QYIDxA1, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(7318));
			((DispatcherObject)Application.Current).Dispatcher.Invoke((Action)delegate
			{
				AOFQ3wytGG();
			});
		}
	}

	public bool UseClientsBackSpin
	{
		get
		{
			return a1VQvDrXqo;
		}
		set
		{
			SetProperty(ref a1VQvDrXqo, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(7372));
		}
	}

	public ICommand GenerateDataSpinGridCommand => new RelayCommand(delegate
	{
		SpinFactorsMap = new ObservableCollection<ObservableCollection<float>>(UU4QnVGxm1.ToObservableCollection(UU4QnVGxm1.GenerateBackSpinFactorList(DataSpinModel)));
		LaunchAngleHeaders = UU4QnVGxm1.GetLaunchAngleHeaders(DataSpinModel);
		BallSpeedHeaders = UU4QnVGxm1.GetBallSpeedHeaders(DataSpinModel);
		M0SQfPCasX.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(7412));
		CurrentSpinVariable = SpinVariableType.BallSpeed;
	});

	public ICommand SaveCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		if (SelectedSpinClubAjustment == SpinClubAjustment.IRON)
		{
			a3gQSw6paJ.Settings.E6ConfigsSettings.DataSpinConfigModelIron = DataSpinModel;
			a3gQSw6paJ.Settings.E6ConfigsSettings.PercentBackSpinIrons = UU4QnVGxm1.ToList(SpinFactorsMap);
		}
		else if (SelectedSpinClubAjustment == SpinClubAjustment.WOOD)
		{
			a3gQSw6paJ.Settings.E6ConfigsSettings.DataSpinConfigModelWood = DataSpinModel;
			a3gQSw6paJ.Settings.E6ConfigsSettings.PercentBackSpinWoods = UU4QnVGxm1.ToList(SpinFactorsMap);
		}
		else if (SelectedSpinClubAjustment == SpinClubAjustment.FW_HYBRID_WEDGE)
		{
			a3gQSw6paJ.Settings.E6ConfigsSettings.DataSpinConfigModelFWHybridWedges = DataSpinModel;
			a3gQSw6paJ.Settings.E6ConfigsSettings.PercentBackSpinFWHybridWedges = UU4QnVGxm1.ToList(SpinFactorsMap);
		}
		a3gQSw6paJ.Settings.E6ConfigsSettings.UseGolfInBackSpinFactor = !UseClientsBackSpin;
		try
		{
			await a3gQSw6paJ.SaveSettings();
			await bLxQhqaM48.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12838), QQXBLjLprwI58ya4VR.y8v8TMFOCb(12856));
			M0SQfPCasX.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(12890));
		}
		catch (Exception ex)
		{
			await bLxQhqaM48.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12418), QQXBLjLprwI58ya4VR.y8v8TMFOCb(12958));
			M0SQfPCasX.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13016) + ex.Message, LogLevel.Error);
			EventViewerLogger.LogException(ex);
		}
	});

	public ICommand ExitCommand => new RelayCommand(delegate
	{
		M0SQfPCasX.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3744));
		dqSQivciOb.NavigateTo(VM.Main);
	});

	public ICommand MinimizeCommand => new RelayCommand(delegate
	{
		M0SQfPCasX.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3806));
		IsMinimized = !IsMinimized;
	});

	public ICommand MouseDownCommand => new RelayCommand(delegate
	{
		if (IsMinimized)
		{
			M0SQfPCasX.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3874));
			IsMinimized = false;
		}
	});

	public ICommand BulkEditFactorsCommand => new RelayCommand(delegate
	{
		ICircularLogService m0SQfPCasX = M0SQfPCasX;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(58, 3);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3942));
		defaultInterpolatedStringHandler.AppendFormatted(CurrentSpinVariable);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4012));
		defaultInterpolatedStringHandler.AppendFormatted(AvailableValues[CurrentValueIndex]);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4038));
		defaultInterpolatedStringHandler.AppendFormatted(BulkEditFactor);
		m0SQfPCasX.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		UU4QnVGxm1.BulkEdit(CurrentSpinVariable, CurrentValueIndex, BulkEditFactor, SpinFactorsMap);
	});

	public SpinDatatableAdjustmentViewModel(IDialogCoordinator dialogCoordinator, IGICTSDirector gICTSDirector, INavigationService<VM> navigationService, IDataSpinService dataSpinService, ICircularLogService circularLogService)
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		ikYQUoAdbP = new DataSpinConfigModel();
		jDMQNljilV = new ObservableCollection<string>();
		base._002Ector();
		bLxQhqaM48 = dialogCoordinator;
		a3gQSw6paJ = gICTSDirector;
		dqSQivciOb = navigationService;
		UU4QnVGxm1 = dataSpinService;
		M0SQfPCasX = circularLogService;
		IsMinimized = false;
		DataSpinModel.FillDefault();
		a3gQSw6paJ.ReloadSettings();
		SelectedSpinClubAjustment = SpinClubAjustment.IRON;
		CurrentSpinVariable = SpinVariableType.BallSpeed;
		AOFQ3wytGG();
	}

	private void AOFQ3wytGG()
	{
		if (SelectedSpinClubAjustment == SpinClubAjustment.IRON)
		{
			if (a3gQSw6paJ.Settings.E6ConfigsSettings.DataSpinConfigModelIron.IsInitialized())
			{
				DataSpinModel = a3gQSw6paJ.Settings.E6ConfigsSettings.DataSpinConfigModelIron;
			}
			else
			{
				DataSpinModel.FillDefault();
			}
			SpinFactorsMap = ((!a3gQSw6paJ.Settings.E6ConfigsSettings.PercentBackSpinIrons.Any()) ? new ObservableCollection<ObservableCollection<float>>(UU4QnVGxm1.ToObservableCollection(UU4QnVGxm1.GenerateBackSpinFactorList(DataSpinModel))) : new ObservableCollection<ObservableCollection<float>>(UU4QnVGxm1.ToObservableCollection(a3gQSw6paJ.Settings.E6ConfigsSettings.PercentBackSpinIrons)));
		}
		else if (SelectedSpinClubAjustment == SpinClubAjustment.WOOD)
		{
			if (a3gQSw6paJ.Settings.E6ConfigsSettings.DataSpinConfigModelWood.IsInitialized())
			{
				DataSpinModel = a3gQSw6paJ.Settings.E6ConfigsSettings.DataSpinConfigModelWood;
			}
			else
			{
				DataSpinModel.FillDefault();
			}
			SpinFactorsMap = ((!a3gQSw6paJ.Settings.E6ConfigsSettings.PercentBackSpinWoods.Any()) ? new ObservableCollection<ObservableCollection<float>>(UU4QnVGxm1.ToObservableCollection(UU4QnVGxm1.GenerateBackSpinFactorList(DataSpinModel))) : new ObservableCollection<ObservableCollection<float>>(UU4QnVGxm1.ToObservableCollection(a3gQSw6paJ.Settings.E6ConfigsSettings.PercentBackSpinWoods)));
		}
		else if (SelectedSpinClubAjustment == SpinClubAjustment.FW_HYBRID_WEDGE)
		{
			if (a3gQSw6paJ.Settings.E6ConfigsSettings.DataSpinConfigModelFWHybridWedges.IsInitialized())
			{
				DataSpinModel = a3gQSw6paJ.Settings.E6ConfigsSettings.DataSpinConfigModelFWHybridWedges;
			}
			else
			{
				DataSpinModel.FillDefault();
			}
			SpinFactorsMap = ((!a3gQSw6paJ.Settings.E6ConfigsSettings.PercentBackSpinFWHybridWedges.Any()) ? new ObservableCollection<ObservableCollection<float>>(UU4QnVGxm1.ToObservableCollection(UU4QnVGxm1.GenerateBackSpinFactorList(DataSpinModel))) : new ObservableCollection<ObservableCollection<float>>(UU4QnVGxm1.ToObservableCollection(a3gQSw6paJ.Settings.E6ConfigsSettings.PercentBackSpinFWHybridWedges)));
		}
		LaunchAngleHeaders = UU4QnVGxm1.GetLaunchAngleHeaders(DataSpinModel);
		BallSpeedHeaders = UU4QnVGxm1.GetBallSpeedHeaders(DataSpinModel);
		UseClientsBackSpin = !a3gQSw6paJ.Settings.E6ConfigsSettings.UseGolfInBackSpinFactor;
	}

	[CompilerGenerated]
	private void o3iQtwpfaX()
	{
		if (iGaQT6aAUP == SpinVariableType.LaunchAngle)
		{
			AvailableValues = LaunchAngleHeaders;
		}
		else if (iGaQT6aAUP == SpinVariableType.BallSpeed)
		{
			AvailableValues = BallSpeedHeaders;
		}
	}

	[CompilerGenerated]
	private void JTMQjZw9BA()
	{
		AOFQ3wytGG();
	}

	[CompilerGenerated]
	private void tEDQB1GKbd()
	{
		SpinFactorsMap = new ObservableCollection<ObservableCollection<float>>(UU4QnVGxm1.ToObservableCollection(UU4QnVGxm1.GenerateBackSpinFactorList(DataSpinModel)));
		LaunchAngleHeaders = UU4QnVGxm1.GetLaunchAngleHeaders(DataSpinModel);
		BallSpeedHeaders = UU4QnVGxm1.GetBallSpeedHeaders(DataSpinModel);
		M0SQfPCasX.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(7412));
		CurrentSpinVariable = SpinVariableType.BallSpeed;
	}

	[CompilerGenerated]
	private async Task SSbQDlM0ML()
	{
		if (SelectedSpinClubAjustment == SpinClubAjustment.IRON)
		{
			a3gQSw6paJ.Settings.E6ConfigsSettings.DataSpinConfigModelIron = DataSpinModel;
			a3gQSw6paJ.Settings.E6ConfigsSettings.PercentBackSpinIrons = UU4QnVGxm1.ToList(SpinFactorsMap);
		}
		else if (SelectedSpinClubAjustment == SpinClubAjustment.WOOD)
		{
			a3gQSw6paJ.Settings.E6ConfigsSettings.DataSpinConfigModelWood = DataSpinModel;
			a3gQSw6paJ.Settings.E6ConfigsSettings.PercentBackSpinWoods = UU4QnVGxm1.ToList(SpinFactorsMap);
		}
		else if (SelectedSpinClubAjustment == SpinClubAjustment.FW_HYBRID_WEDGE)
		{
			a3gQSw6paJ.Settings.E6ConfigsSettings.DataSpinConfigModelFWHybridWedges = DataSpinModel;
			a3gQSw6paJ.Settings.E6ConfigsSettings.PercentBackSpinFWHybridWedges = UU4QnVGxm1.ToList(SpinFactorsMap);
		}
		a3gQSw6paJ.Settings.E6ConfigsSettings.UseGolfInBackSpinFactor = !UseClientsBackSpin;
		try
		{
			await a3gQSw6paJ.SaveSettings();
			await bLxQhqaM48.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12838), QQXBLjLprwI58ya4VR.y8v8TMFOCb(12856));
			M0SQfPCasX.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(12890));
		}
		catch (Exception ex)
		{
			await bLxQhqaM48.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12418), QQXBLjLprwI58ya4VR.y8v8TMFOCb(12958));
			M0SQfPCasX.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13016) + ex.Message, LogLevel.Error);
			EventViewerLogger.LogException(ex);
		}
	}

	[CompilerGenerated]
	private void gjBQeFE2Iw()
	{
		M0SQfPCasX.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3744));
		dqSQivciOb.NavigateTo(VM.Main);
	}

	[CompilerGenerated]
	private void sdIQpkgGKV()
	{
		M0SQfPCasX.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3806));
		IsMinimized = !IsMinimized;
	}

	[CompilerGenerated]
	private void nndQ1VZtan()
	{
		if (IsMinimized)
		{
			M0SQfPCasX.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3874));
			IsMinimized = false;
		}
	}

	[CompilerGenerated]
	private void bZ3QKutAqn()
	{
		ICircularLogService m0SQfPCasX = M0SQfPCasX;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(58, 3);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3942));
		defaultInterpolatedStringHandler.AppendFormatted(CurrentSpinVariable);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4012));
		defaultInterpolatedStringHandler.AppendFormatted(AvailableValues[CurrentValueIndex]);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4038));
		defaultInterpolatedStringHandler.AppendFormatted(BulkEditFactor);
		m0SQfPCasX.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		UU4QnVGxm1.BulkEdit(CurrentSpinVariable, CurrentValueIndex, BulkEditFactor, SpinFactorsMap);
	}
}
