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

public class ClubFaceCorrectionDatatableAdjustmentViewModel : ObservableRecipient, IViewModel
{
	private DataSpinConfigModel wPvxtcfQxo;

	private ObservableCollection<ObservableCollection<float>> goNxjRTngo;

	private ObservableCollection<string> N2UxByQSwQ;

	private ObservableCollection<string> LBLxDjprwI;

	private bool Y8yxea4VRP;

	private int bB8xpTYZ87;

	private SpinVariableType fKux1ujytY;

	private ObservableCollection<string> RggxKQeDtl;

	private int OAVxUQmKw9;

	private ClubFaceAjustment KehxVU84wq;

	private bool SI4xGUZ3pB;

	private IDialogCoordinator Wu0xX56OHJ;

	private readonly IMessagingService zbix9NhoFc;

	private readonly IGICTSDirector DtJxL2WvRj;

	private readonly INavigationService<VM> ql9xTCZvUX;

	private readonly IDataSpinService EKkxNjK4LP;

	private readonly ICircularLogService kX0xw5RByS;

	public DataSpinConfigModel DataSpinModel
	{
		get
		{
			return wPvxtcfQxo;
		}
		set
		{
			SetProperty(ref wPvxtcfQxo, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(3220));
		}
	}

	public ObservableCollection<ObservableCollection<float>> ClubFaceFactorsMap
	{
		get
		{
			return goNxjRTngo;
		}
		set
		{
			SetProperty(ref goNxjRTngo, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(3250));
		}
	}

	public ObservableCollection<string> BallSpeedHeaders
	{
		get
		{
			return N2UxByQSwQ;
		}
		set
		{
			SetProperty(ref N2UxByQSwQ, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(3290));
		}
	}

	public ObservableCollection<string> BallPositionHeaders
	{
		get
		{
			return LBLxDjprwI;
		}
		set
		{
			SetProperty(ref LBLxDjprwI, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(3326));
		}
	}

	public bool IsMinimized
	{
		get
		{
			return Y8yxea4VRP;
		}
		set
		{
			SetProperty(ref Y8yxea4VRP, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(3368));
		}
	}

	public int BulkEditFactor
	{
		get
		{
			return bB8xpTYZ87;
		}
		set
		{
			SetProperty(ref bB8xpTYZ87, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(3394));
		}
	}

	public SpinVariableType CurrentSpinVariable
	{
		get
		{
			return fKux1ujytY;
		}
		set
		{
			SetProperty(ref fKux1ujytY, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(3426));
			((DispatcherObject)Application.Current).Dispatcher.Invoke((Delegate)(Action)delegate
			{
				if (fKux1ujytY == SpinVariableType.BallPosition)
				{
					AvailableValues = BallPositionHeaders;
				}
				else if (fKux1ujytY == SpinVariableType.BallSpeed)
				{
					AvailableValues = BallSpeedHeaders;
				}
			}, Array.Empty<object>());
		}
	}

	public ObservableCollection<string> AvailableValues
	{
		get
		{
			return RggxKQeDtl;
		}
		set
		{
			SetProperty(ref RggxKQeDtl, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(3468));
		}
	}

	public int CurrentValueIndex
	{
		get
		{
			return OAVxUQmKw9;
		}
		set
		{
			SetProperty(ref OAVxUQmKw9, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(3502));
		}
	}

	public ClubFaceAjustment SelectedClubFaceAjustment
	{
		get
		{
			return KehxVU84wq;
		}
		set
		{
			SetProperty(ref KehxVU84wq, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(3540));
			((DispatcherObject)Application.Current).Dispatcher.Invoke((Action)delegate
			{
				SVbxAYKy5I();
			});
		}
	}

	public bool UseClientsClubFace
	{
		get
		{
			return SI4xGUZ3pB;
		}
		set
		{
			SetProperty(ref SI4xGUZ3pB, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(3594));
		}
	}

	public ICommand GenerateDataClubFaceGridCommand => new RelayCommand(delegate
	{
		ClubFaceFactorsMap = new ObservableCollection<ObservableCollection<float>>(EKkxNjK4LP.ToObservableCollection(EKkxNjK4LP.GenerateSideSpinFactorList(DataSpinModel)));
		BallPositionHeaders = EKkxNjK4LP.GetBallPositionHeaders(DataSpinModel);
		BallSpeedHeaders = EKkxNjK4LP.GetBallSpeedHeaders(DataSpinModel);
		kX0xw5RByS.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3634));
		CurrentSpinVariable = SpinVariableType.BallSpeed;
	});

	public ICommand SaveCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		if (SelectedClubFaceAjustment == ClubFaceAjustment.IRON)
		{
			DtJxL2WvRj.Settings.E6ConfigsSettings.DataSpinConfigModelIron = DataSpinModel;
			DtJxL2WvRj.Settings.E6ConfigsSettings.OffsetClubFaceIrons = EKkxNjK4LP.ToList(ClubFaceFactorsMap);
		}
		else if (SelectedClubFaceAjustment == ClubFaceAjustment.WOOD)
		{
			DtJxL2WvRj.Settings.E6ConfigsSettings.DataSpinConfigModelWood = DataSpinModel;
			DtJxL2WvRj.Settings.E6ConfigsSettings.OffsetClubFaceWoods = EKkxNjK4LP.ToList(ClubFaceFactorsMap);
		}
		DtJxL2WvRj.Settings.E6ConfigsSettings.UseGolfInClubFaceOffset = !UseClientsClubFace;
		try
		{
			await DtJxL2WvRj.SaveSettings();
			await Wu0xX56OHJ.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12838), QQXBLjLprwI58ya4VR.y8v8TMFOCb(12856));
			kX0xw5RByS.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(12890));
		}
		catch (Exception ex)
		{
			await Wu0xX56OHJ.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12418), QQXBLjLprwI58ya4VR.y8v8TMFOCb(12958));
			kX0xw5RByS.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13016) + ex.Message, LogLevel.Error);
			EventViewerLogger.LogException(ex);
		}
	});

	public ICommand ExitCommand => new RelayCommand(delegate
	{
		kX0xw5RByS.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3744));
		ql9xTCZvUX.NavigateTo(VM.Main);
	});

	public ICommand MinimizeCommand => new RelayCommand(delegate
	{
		kX0xw5RByS.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3806));
		IsMinimized = !IsMinimized;
	});

	public ICommand MouseDownCommand => new RelayCommand(delegate
	{
		if (IsMinimized)
		{
			kX0xw5RByS.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3874));
			IsMinimized = false;
		}
	});

	public ICommand BulkEditFactorsCommand => new RelayCommand(delegate
	{
		ICircularLogService circularLogService = kX0xw5RByS;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(58, 3);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3942));
		defaultInterpolatedStringHandler.AppendFormatted(CurrentSpinVariable);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4012));
		defaultInterpolatedStringHandler.AppendFormatted(AvailableValues[CurrentValueIndex]);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4038));
		defaultInterpolatedStringHandler.AppendFormatted(BulkEditFactor);
		circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		EKkxNjK4LP.BulkEdit(CurrentSpinVariable, CurrentValueIndex, BulkEditFactor, ClubFaceFactorsMap);
	});

	public ClubFaceCorrectionDatatableAdjustmentViewModel(IDialogCoordinator dialogCoordinator, IMessagingService messagingService, IGICTSDirector gICTSDirector, INavigationService<VM> navigationService, IDataSpinService dataSpinService, ICircularLogService circularLogService)
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		wPvxtcfQxo = new DataSpinConfigModel();
		RggxKQeDtl = new ObservableCollection<string>();
		base._002Ector();
		Wu0xX56OHJ = dialogCoordinator;
		zbix9NhoFc = messagingService;
		DtJxL2WvRj = gICTSDirector;
		ql9xTCZvUX = navigationService;
		EKkxNjK4LP = dataSpinService;
		kX0xw5RByS = circularLogService;
		IsMinimized = false;
		DataSpinModel.FillDefault();
		DtJxL2WvRj.ReloadSettings();
		SelectedClubFaceAjustment = ClubFaceAjustment.IRON;
		CurrentSpinVariable = SpinVariableType.BallSpeed;
		SVbxAYKy5I();
	}

	private void SVbxAYKy5I()
	{
		if (SelectedClubFaceAjustment == ClubFaceAjustment.IRON)
		{
			if (DtJxL2WvRj.Settings.E6ConfigsSettings.DataSpinConfigModelIron.IsInitialized())
			{
				DataSpinModel = DtJxL2WvRj.Settings.E6ConfigsSettings.DataSpinConfigModelIron;
			}
			else
			{
				DataSpinModel.FillDefault();
			}
			ClubFaceFactorsMap = ((!DtJxL2WvRj.Settings.E6ConfigsSettings.OffsetClubFaceIrons.Any()) ? new ObservableCollection<ObservableCollection<float>>(EKkxNjK4LP.ToObservableCollection(EKkxNjK4LP.GenerateSideSpinFactorList(DataSpinModel))) : new ObservableCollection<ObservableCollection<float>>(EKkxNjK4LP.ToObservableCollection(DtJxL2WvRj.Settings.E6ConfigsSettings.OffsetClubFaceIrons)));
			BallPositionHeaders = EKkxNjK4LP.GetBallPositionHeaders(DataSpinModel);
			BallSpeedHeaders = EKkxNjK4LP.GetBallSpeedHeaders(DataSpinModel);
		}
		else if (SelectedClubFaceAjustment == ClubFaceAjustment.WOOD)
		{
			if (DtJxL2WvRj.Settings.E6ConfigsSettings.DataSpinConfigModelWood.IsInitialized())
			{
				DataSpinModel = DtJxL2WvRj.Settings.E6ConfigsSettings.DataSpinConfigModelWood;
			}
			else
			{
				DataSpinModel.FillDefault();
			}
			ClubFaceFactorsMap = ((!DtJxL2WvRj.Settings.E6ConfigsSettings.OffsetClubFaceWoods.Any()) ? new ObservableCollection<ObservableCollection<float>>(EKkxNjK4LP.ToObservableCollection(EKkxNjK4LP.GenerateSideSpinFactorList(DataSpinModel))) : new ObservableCollection<ObservableCollection<float>>(EKkxNjK4LP.ToObservableCollection(DtJxL2WvRj.Settings.E6ConfigsSettings.OffsetClubFaceWoods)));
			BallPositionHeaders = EKkxNjK4LP.GetBallPositionHeaders(DataSpinModel);
			BallSpeedHeaders = EKkxNjK4LP.GetBallSpeedHeaders(DataSpinModel);
		}
		UseClientsClubFace = !DtJxL2WvRj.Settings.E6ConfigsSettings.UseGolfInClubFaceOffset;
	}

	[CompilerGenerated]
	private void HFXxZc2mnE()
	{
		if (fKux1ujytY == SpinVariableType.BallPosition)
		{
			AvailableValues = BallPositionHeaders;
		}
		else if (fKux1ujytY == SpinVariableType.BallSpeed)
		{
			AvailableValues = BallSpeedHeaders;
		}
	}

	[CompilerGenerated]
	private void TbrxlvslLC()
	{
		SVbxAYKy5I();
	}

	[CompilerGenerated]
	private void BaGxkLnvhI()
	{
		ClubFaceFactorsMap = new ObservableCollection<ObservableCollection<float>>(EKkxNjK4LP.ToObservableCollection(EKkxNjK4LP.GenerateSideSpinFactorList(DataSpinModel)));
		BallPositionHeaders = EKkxNjK4LP.GetBallPositionHeaders(DataSpinModel);
		BallSpeedHeaders = EKkxNjK4LP.GetBallSpeedHeaders(DataSpinModel);
		kX0xw5RByS.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3634));
		CurrentSpinVariable = SpinVariableType.BallSpeed;
	}

	[CompilerGenerated]
	private async Task iBwx24uJJP()
	{
		if (SelectedClubFaceAjustment == ClubFaceAjustment.IRON)
		{
			DtJxL2WvRj.Settings.E6ConfigsSettings.DataSpinConfigModelIron = DataSpinModel;
			DtJxL2WvRj.Settings.E6ConfigsSettings.OffsetClubFaceIrons = EKkxNjK4LP.ToList(ClubFaceFactorsMap);
		}
		else if (SelectedClubFaceAjustment == ClubFaceAjustment.WOOD)
		{
			DtJxL2WvRj.Settings.E6ConfigsSettings.DataSpinConfigModelWood = DataSpinModel;
			DtJxL2WvRj.Settings.E6ConfigsSettings.OffsetClubFaceWoods = EKkxNjK4LP.ToList(ClubFaceFactorsMap);
		}
		DtJxL2WvRj.Settings.E6ConfigsSettings.UseGolfInClubFaceOffset = !UseClientsClubFace;
		try
		{
			await DtJxL2WvRj.SaveSettings();
			await Wu0xX56OHJ.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12838), QQXBLjLprwI58ya4VR.y8v8TMFOCb(12856));
			kX0xw5RByS.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(12890));
		}
		catch (Exception ex)
		{
			await Wu0xX56OHJ.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12418), QQXBLjLprwI58ya4VR.y8v8TMFOCb(12958));
			kX0xw5RByS.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(13016) + ex.Message, LogLevel.Error);
			EventViewerLogger.LogException(ex);
		}
	}

	[CompilerGenerated]
	private void MDmxyvHMHk()
	{
		kX0xw5RByS.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3744));
		ql9xTCZvUX.NavigateTo(VM.Main);
	}

	[CompilerGenerated]
	private void qCrxgnoCGH()
	{
		kX0xw5RByS.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3806));
		IsMinimized = !IsMinimized;
	}

	[CompilerGenerated]
	private void Rr6x49Yj0a()
	{
		if (IsMinimized)
		{
			kX0xw5RByS.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3874));
			IsMinimized = false;
		}
	}

	[CompilerGenerated]
	private void RN4x3lxYOb()
	{
		ICircularLogService circularLogService = kX0xw5RByS;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(58, 3);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(3942));
		defaultInterpolatedStringHandler.AppendFormatted(CurrentSpinVariable);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4012));
		defaultInterpolatedStringHandler.AppendFormatted(AvailableValues[CurrentValueIndex]);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4038));
		defaultInterpolatedStringHandler.AppendFormatted(BulkEditFactor);
		circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		EKkxNjK4LP.BulkEdit(CurrentSpinVariable, CurrentValueIndex, BulkEditFactor, ClubFaceFactorsMap);
	}
}
