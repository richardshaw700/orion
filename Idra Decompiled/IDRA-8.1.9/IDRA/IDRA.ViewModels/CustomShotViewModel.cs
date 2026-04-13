using System.Runtime.CompilerServices;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GICTS.Core;
using GICTS.Data;
using GIToolkit.Services;
using GhU84wwqvI4UZ3pBfu;
using IDRA.Auxiliary.Messages;
using sxB8TYTZ87aKuujytY;

namespace IDRA.ViewModels;

public class CustomShotViewModel : ObservableRecipient, IViewModel
{
	private CTSShotData QqUxo86TlW;

	private readonly IMessagingService xipx5twpDg;

	private readonly IGICTSDirector Ey1xzGYA51;

	private readonly ICircularLogService GSYds4XLKF;

	public CTSShotData Shot
	{
		get
		{
			return QqUxo86TlW;
		}
		set
		{
			SetProperty(ref QqUxo86TlW, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(4136));
		}
	}

	public ICommand SendShotCommand => new RelayCommand(delegate
	{
		GSYds4XLKF.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4148));
		Shot.Ball.BackSpin = (QqUxo86TlW.UseMLSpinCalculationMethod ? 0.0 : Shot.Ball.BackSpin);
		Shot.Ball.SideSpin = (QqUxo86TlW.UseMLSpinCalculationMethod ? 0.0 : Shot.Ball.SideSpin);
		Ey1xzGYA51.SendShot(Shot);
		Shot.Ball.SideSpin *= -1.0;
		OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4136));
	});

	[SpecialName]
	private static CTSShotData dAixfL36ig()
	{
		return new CTSShotData
		{
			Ball = new BallData
			{
				BallSpeed = 125.0,
				LaunchAngle = 10.0,
				LaunchDirection = 0.5,
				BackSpin = 2000.0,
				SideSpin = 800.0
			},
			Club = new ClubData
			{
				ClubAngleFace = 0.0,
				ClubAnglePath = 0.0,
				ClubHeadSpeed = 80.0
			},
			ClubNature = ClubNatureEnum.WOOD_DRIVER,
			PlayerHandedness = PlayerHandednessNatureEnum.Right
		};
	}

	public CustomShotViewModel(IMessagingService messagingService, IGICTSDirector gICTSDirector, ICircularLogService circularLogService)
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		base._002Ector();
		xipx5twpDg = messagingService;
		Ey1xzGYA51 = gICTSDirector;
		GSYds4XLKF = circularLogService;
		xipx5twpDg.Register<FillCustomShotMessages>(this, FillShot);
		Shot = dAixfL36ig();
	}

	public void FillShot(object obj, FillCustomShotMessages param)
	{
		Shot = param.Shot;
		OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4136));
	}

	[CompilerGenerated]
	private void CYfxnNfAgi()
	{
		GSYds4XLKF.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4148));
		Shot.Ball.BackSpin = (QqUxo86TlW.UseMLSpinCalculationMethod ? 0.0 : Shot.Ball.BackSpin);
		Shot.Ball.SideSpin = (QqUxo86TlW.UseMLSpinCalculationMethod ? 0.0 : Shot.Ball.SideSpin);
		Ey1xzGYA51.SendShot(Shot);
		Shot.Ball.SideSpin *= -1.0;
		OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4136));
	}
}
