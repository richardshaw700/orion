using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Timers;
using GICTS.Data;
using GICTSCore.Data;
using GIToolkit.Services;
using GSProClient;
using IDRASharedModels;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;

namespace GICTSCore.Services.LocalAPI;

public class GSProAPIService : CommunicationIDRALocalAPI
{
	[CompilerGenerated]
	private Action n51TiqQ4Gq;

	[CompilerGenerated]
	private Action<bool> pevTQRJDfg;

	[CompilerGenerated]
	private Action<bool> oicTPbSsRK;

	[CompilerGenerated]
	private Action<GSProComputeData> v1MTGU0pfv;

	[CompilerGenerated]
	private Action<string> tPYTqYBt0B;

	[CompilerGenerated]
	private float? mPoTmgV6Kr;

	private readonly ITcpGSProClient S1nT2rmteJ;

	private readonly IProcessHelper pAXTFiiveF;

	private CTSShotData jwLTxyLW2r;

	private bool aRYTEFcW1b;

	private bool FiMTovL3v9;

	protected Timer _autoClickPlayTimer;

	public Action OnGSProHasExited
	{
		[CompilerGenerated]
		get
		{
			return n51TiqQ4Gq;
		}
		[CompilerGenerated]
		set
		{
			n51TiqQ4Gq = value;
		}
	}

	public Action<bool> OnScoreCardIsVisible
	{
		[CompilerGenerated]
		get
		{
			return pevTQRJDfg;
		}
		[CompilerGenerated]
		set
		{
			pevTQRJDfg = value;
		}
	}

	public Action<bool> OnOSKIsVisible
	{
		[CompilerGenerated]
		get
		{
			return oicTPbSsRK;
		}
		[CompilerGenerated]
		set
		{
			oicTPbSsRK = value;
		}
	}

	public Action<GSProComputeData> OnGameComputeData
	{
		[CompilerGenerated]
		get
		{
			return v1MTGU0pfv;
		}
		[CompilerGenerated]
		set
		{
			v1MTGU0pfv = value;
		}
	}

	public Action<string> OnFirstTeeCall
	{
		[CompilerGenerated]
		get
		{
			return tPYTqYBt0B;
		}
		[CompilerGenerated]
		set
		{
			tPYTqYBt0B = value;
		}
	}

	public override bool IsConnected => S1nT2rmteJ.IsConnectedToServer();

	public override ILocalAPIGameSettings LocalAPIGameSettings => new LocalAPIGSProSettings();

	public float? DistanceToPin
	{
		[CompilerGenerated]
		get
		{
			return mPoTmgV6Kr;
		}
		[CompilerGenerated]
		private set
		{
			mPoTmgV6Kr = value;
		}
	}

	public GSProAPIService(ITcpGSProClient gsproClient, IProcessHelper processHelper)
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
		S1nT2rmteJ = gsproClient;
		pAXTFiiveF = processHelper;
		ITcpGSProClient s1nT2rmteJ = S1nT2rmteJ;
		s1nT2rmteJ.OnConnectedToServer = (Action)Delegate.Combine(s1nT2rmteJ.OnConnectedToServer, new Action(qZRTjxL8h7));
		ITcpGSProClient s1nT2rmteJ2 = S1nT2rmteJ;
		s1nT2rmteJ2.OnDisconnectedFromServer = (Action)Delegate.Combine(s1nT2rmteJ2.OnDisconnectedFromServer, new Action(pqWT1QlD3K));
		ITcpGSProClient s1nT2rmteJ3 = S1nT2rmteJ;
		s1nT2rmteJ3.OnRoundHasEnded = (Action)Delegate.Combine(s1nT2rmteJ3.OnRoundHasEnded, new Action(jxvTkwldTO));
		ITcpGSProClient s1nT2rmteJ4 = S1nT2rmteJ;
		s1nT2rmteJ4.OnReadyReceiveShot = (Action)Delegate.Combine(s1nT2rmteJ4.OnReadyReceiveShot, new Action(DfFTdlUCL3));
		ITcpGSProClient s1nT2rmteJ5 = S1nT2rmteJ;
		s1nT2rmteJ5.OnPlayerDataReceived = (Action<PlayerDataDto>)Delegate.Combine(s1nT2rmteJ5.OnPlayerDataReceived, new Action<PlayerDataDto>(p4aTNkI2PC));
		ITcpGSProClient s1nT2rmteJ6 = S1nT2rmteJ;
		s1nT2rmteJ6.OnShotReceived = (Action<ShotDataDto>)Delegate.Combine(s1nT2rmteJ6.OnShotReceived, new Action<ShotDataDto>(YAyTcsLEIN));
		ITcpGSProClient s1nT2rmteJ7 = S1nT2rmteJ;
		s1nT2rmteJ7.OnFirstTeeReceived = (Action<string>)Delegate.Combine(s1nT2rmteJ7.OnFirstTeeReceived, new Action<string>(y1XT4kNn1L));
		ITcpGSProClient s1nT2rmteJ8 = S1nT2rmteJ;
		s1nT2rmteJ8.OnGameComputeDataReceived = (Action<GSProComputeData>)Delegate.Combine(s1nT2rmteJ8.OnGameComputeDataReceived, new Action<GSProComputeData>(rJST3BLdKn));
		ITcpGSProClient s1nT2rmteJ9 = S1nT2rmteJ;
		s1nT2rmteJ9.OnScoreCardVisible = (Action<bool>)Delegate.Combine(s1nT2rmteJ9.OnScoreCardVisible, new Action<bool>(X6aTWo03Kn));
		ITcpGSProClient s1nT2rmteJ10 = S1nT2rmteJ;
		s1nT2rmteJ10.OnOSKVisible = (Action<bool>)Delegate.Combine(s1nT2rmteJ10.OnOSKVisible, new Action<bool>(C3TTJyXMlb));
		wRXTraFF0J();
		gpRT9C9V0Q();
	}

	private void wRXTraFF0J()
	{
		_autoClickPlayTimer = new Timer
		{
			AutoReset = false,
			Enabled = true
		};
		_autoClickPlayTimer.Elapsed += OlFTykj4kL;
		_autoClickPlayTimer.Interval = TimeSpan.FromSeconds(1.0).TotalMilliseconds;
	}

	private void OlFTykj4kL(object? sender, ElapsedEventArgs P_1)
	{
		(sender as Timer).Enabled = false;
		try
		{
			using Process process = pAXTFiiveF.GetProcessByName(IDRAConstant.GSProProcessName);
			if (process?.MainWindowTitle == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16918))
			{
				AutomaticUserInput.ClickButton(process.ProcessName, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16960));
			}
		}
		catch (Exception ex)
		{
			S1nT2rmteJ.Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16974) + ex.Message);
		}
		finally
		{
			(sender as Timer).Enabled = true;
		}
	}

	private void gpRT9C9V0Q()
	{
		if (!FiMTovL3v9)
		{
			Process processByName = pAXTFiiveF.GetProcessByName(IDRAConstant.GSProProcessName);
			if (processByName != null)
			{
				processByName.Exited += bwxTAmcBtq;
				S1nT2rmteJ.Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17090));
				FiMTovL3v9 = true;
			}
		}
	}

	private void bwxTAmcBtq(object? sender, EventArgs P_1)
	{
		S1nT2rmteJ.CloseTCPConnection().Wait();
		OnGSProHasExited?.Invoke();
	}

	private void qZRTjxL8h7()
	{
		OnClientConnected?.Invoke(obj: true);
		qslT6OvyiA().Wait();
		OnArmed?.Invoke(string.Empty);
	}

	private async Task qslT6OvyiA()
	{
		try
		{
			await S1nT2rmteJ.SendOpenGSProWithLoggingSystem(val: false);
		}
		catch (Exception ex)
		{
			S1nT2rmteJ.Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(23094) + ex.Message);
		}
	}

	private void pqWT1QlD3K()
	{
		OnClientDisconnected?.Invoke(obj: true);
	}

	private void jxvTkwldTO()
	{
	}

	private void DfFTdlUCL3()
	{
		if (aRYTEFcW1b)
		{
			SimCommandShotCompletedMsg simCommandShotCompletedMsg = new SimCommandShotCompletedMsg(jwLTxyLW2r);
			simCommandShotCompletedMsg.ClubData.ClubType = Enum.GetName(typeof(ClubTypeEnum), CurrentClubType) ?? YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17154);
			simCommandShotCompletedMsg.DistanceToPin = DistanceToPin ?? (-1f);
			OnShotCompleted?.Invoke(simCommandShotCompletedMsg);
			aRYTEFcW1b = false;
		}
	}

	private void p4aTNkI2PC(PlayerDataDto P_0)
	{
		LastCommand = GICTSMessage.InfoSubClassEnum.PlayerDataModified;
		_ = P_0.Club;
		CurrentClubType = jOUT5M6enH(P_0.Club);
		CurrentPlayerName = P_0.PlayerName;
		CurrentPlayerHandedness = ((P_0.Handed == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17172)) ? PlayerHandednessNatureEnum.Right : PlayerHandednessNatureEnum.Left);
		DistanceToPin = P_0.DistanceToTarget;
		OnPlayerDataModified?.Invoke(CurrentPlayerHandedness, CurrentClubType, CurrentPlayerName);
	}

	private ClubTypeEnum jOUT5M6enH(string P_0)
	{
		if (P_0 != null)
		{
			int length = P_0.Length;
			if (length == 2)
			{
				switch (P_0[1])
				{
				case 'R':
					if (!(P_0 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16806)))
					{
						break;
					}
					return ClubTypeEnum.Wood1;
				case '3':
					if (!(P_0 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16814)))
					{
						if (!(P_0 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16838)))
						{
							break;
						}
						return ClubTypeEnum.Hybrid3;
					}
					return ClubTypeEnum.Wood3;
				case '4':
					if (!(P_0 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17180)))
					{
						break;
					}
					return ClubTypeEnum.Iron4;
				case '5':
					if (!(P_0 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17188)))
					{
						break;
					}
					return ClubTypeEnum.Iron5;
				case '6':
					if (!(P_0 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17196)))
					{
						break;
					}
					return ClubTypeEnum.Iron6;
				case '7':
					if (!(P_0 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17204)))
					{
						break;
					}
					return ClubTypeEnum.Iron7;
				case '8':
					if (!(P_0 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17212)))
					{
						break;
					}
					return ClubTypeEnum.Iron8;
				case '9':
					if (!(P_0 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17220)))
					{
						break;
					}
					return ClubTypeEnum.Iron9;
				case 'W':
					if (!(P_0 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16878)))
					{
						if (!(P_0 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16886)))
						{
							if (!(P_0 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16894)))
							{
								if (!(P_0 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16902)))
								{
									break;
								}
								return ClubTypeEnum.LobWedge;
							}
							return ClubTypeEnum.SandWedge;
						}
						return ClubTypeEnum.GapWedge;
					}
					return ClubTypeEnum.PitchingWedge;
				case 'T':
					if (!(P_0 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16910)))
					{
						break;
					}
					return ClubTypeEnum.Putter;
				}
			}
		}
		if (GSProClubConstant.IsWood(P_0))
		{
			CurrentClubType = ClubTypeEnum.Wood1;
		}
		else if (GSProClubConstant.IsIron(P_0))
		{
			CurrentClubType = ClubTypeEnum.Iron6;
		}
		else if (GSProClubConstant.IsWedge(P_0))
		{
			CurrentClubType = ClubTypeEnum.PitchingWedge;
		}
		else if (GSProClubConstant.IsPutter(P_0))
		{
			CurrentClubType = ClubTypeEnum.Putter;
		}
		else
		{
			CurrentClubType = ClubTypeEnum.Unknow;
		}
		return CurrentClubType;
	}

	private void YAyTcsLEIN(ShotDataDto P_0)
	{
		LastCommand = GICTSMessage.InfoSubClassEnum.Arm;
		OnArmed?.Invoke(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17228));
		aRYTEFcW1b = true;
	}

	private void X6aTWo03Kn(bool P_0)
	{
		OnScoreCardIsVisible?.Invoke(P_0);
	}

	private void C3TTJyXMlb(bool P_0)
	{
		OnOSKIsVisible?.Invoke(P_0);
	}

	private void y1XT4kNn1L(string P_0)
	{
		LastCommand = GICTSMessage.InfoSubClassEnum.FirstTee;
		OnFirstTeeCall?.Invoke(P_0);
	}

	private void rJST3BLdKn(GSProComputeData P_0)
	{
		LastCommand = GICTSMessage.InfoSubClassEnum.ComputeData;
		OnGameComputeData?.Invoke(new GSProComputeData
		{
			CarryRaw = P_0.CarryRaw,
			OffLine = P_0.OffLine,
			PeakHeight = P_0.PeakHeight,
			TotalLength = P_0.TotalLength,
			CarryGame = P_0.CarryGame,
			DecentAngle = P_0.DecentAngle,
			DistanceToPinYrds = P_0.DistanceToPinYrds
		});
	}

	public override void SendBoothDataMessage(GspBoothData msg)
	{
		S1nT2rmteJ.SendBallPositionToGsp(msg);
	}

	public override void Connect()
	{
		S1nT2rmteJ.ConnectToGSPro().Wait();
	}

	public override void Disconnect()
	{
		S1nT2rmteJ.CloseTCPConnection().Wait();
	}

	public override void Dispose()
	{
		base.Dispose();
		if (S1nT2rmteJ != null)
		{
			ITcpGSProClient s1nT2rmteJ = S1nT2rmteJ;
			s1nT2rmteJ.OnConnectedToServer = (Action)Delegate.Remove(s1nT2rmteJ.OnConnectedToServer, new Action(qZRTjxL8h7));
			ITcpGSProClient s1nT2rmteJ2 = S1nT2rmteJ;
			s1nT2rmteJ2.OnDisconnectedFromServer = (Action)Delegate.Remove(s1nT2rmteJ2.OnDisconnectedFromServer, new Action(pqWT1QlD3K));
			ITcpGSProClient s1nT2rmteJ3 = S1nT2rmteJ;
			s1nT2rmteJ3.OnRoundHasEnded = (Action)Delegate.Remove(s1nT2rmteJ3.OnRoundHasEnded, new Action(jxvTkwldTO));
			ITcpGSProClient s1nT2rmteJ4 = S1nT2rmteJ;
			s1nT2rmteJ4.OnReadyReceiveShot = (Action)Delegate.Remove(s1nT2rmteJ4.OnReadyReceiveShot, new Action(DfFTdlUCL3));
			ITcpGSProClient s1nT2rmteJ5 = S1nT2rmteJ;
			s1nT2rmteJ5.OnPlayerDataReceived = (Action<PlayerDataDto>)Delegate.Remove(s1nT2rmteJ5.OnPlayerDataReceived, new Action<PlayerDataDto>(p4aTNkI2PC));
			ITcpGSProClient s1nT2rmteJ6 = S1nT2rmteJ;
			s1nT2rmteJ6.OnShotReceived = (Action<ShotDataDto>)Delegate.Remove(s1nT2rmteJ6.OnShotReceived, new Action<ShotDataDto>(YAyTcsLEIN));
			S1nT2rmteJ.Dispose();
		}
	}

	public override void GetEnvironmentDataMessage()
	{
	}

	public override void GetPlayerDataMessage()
	{
	}

	public async Task SendOpenGSProWithLoggingSystem(bool newValue)
	{
		await S1nT2rmteJ.SendOpenGSProWithLoggingSystem(newValue);
	}

	public override void SendBallOnTeeDisplacementLeft()
	{
		S1nT2rmteJ.SendAutoTeeMoveBallLeft();
	}

	public override void SendBallOnTeeDisplacementRight()
	{
		S1nT2rmteJ.SendAutoTeeMoveBallRight();
	}

	public override void SendShot(CTSShotData shot)
	{
		aRYTEFcW1b = false;
		OnDisarmed?.Invoke(string.Empty);
		BallDataDto ballDataDto = new BallDataDto
		{
			Speed = Convert.ToSingle(shot.Ball.BallSpeed),
			HLA = Convert.ToSingle(shot.Ball.LaunchDirection),
			VLA = Convert.ToSingle(shot.Ball.LaunchAngle)
		};
		ClubDataDto clubDataDto = new ClubDataDto
		{
			Speed = Convert.ToSingle(shot.Club.ClubHeadSpeed),
			FaceToTarget = Convert.ToSingle(shot.Club.ClubAngleFace),
			Path = Convert.ToSingle(shot.Club.ClubAnglePath),
			IsPlayerRightHand = (shot.PlayerHandedness == PlayerHandednessNatureEnum.Right)
		};
		float num = 0f;
		float num2 = 0f;
		double value = 0.0;
		double value2 = 0.0;
		float num3 = 100f;
		float num4 = 0f;
		bool flag = Math.Abs(shot.Ball.BackSpin) > 0.0 && Math.Abs(shot.Ball.SideSpin) > 0.0;
		if (!shot.UseMLSpinCalculationMethod || flag)
		{
			num = Convert.ToSingle(shot.Ball.BackSpin);
			num2 = Convert.ToSingle(shot.Ball.SideSpin);
		}
		else if (shot.GetClubNatureCategory() == ClubNatureCategoryEnum.WOOD)
		{
			num4 = shot.ConfigData?.OffsetClubFaceWood ?? 0f;
			num4 *= (float)((shot.PlayerHandedness != PlayerHandednessNatureEnum.Left) ? 1 : (-1));
			num = WoodBackspinModelPrediction.Predict(new WoodBackspinModelPrediction.ModelInput
			{
				BallSpeed = ballDataDto.Speed,
				LaunchAngle = ballDataDto.VLA,
				ClubFace = clubDataDto.FaceToTarget,
				ClubPath = clubDataDto.Path
			}).Score;
			value = num;
			num2 = WoodSidespinModelPrediction.Predict(new WoodSidespinModelPrediction.ModelInput
			{
				BallSpeed = ballDataDto.Speed,
				LaunchAngle = ballDataDto.VLA,
				ClubFace = clubDataDto.FaceToTarget + num4,
				ClubPath = clubDataDto.Path
			}).Score;
			value2 = WoodSidespinModelPrediction.Predict(new WoodSidespinModelPrediction.ModelInput
			{
				BallSpeed = ballDataDto.Speed,
				LaunchAngle = ballDataDto.VLA,
				ClubFace = clubDataDto.FaceToTarget,
				ClubPath = clubDataDto.Path
			}).Score;
			num3 = shot.ConfigData?.PercentBackSpinWood ?? 1f;
			num *= num3 / 100f;
		}
		else
		{
			num4 = shot.ConfigData?.OffsetClubFaceIron ?? 0f;
			num4 *= (float)((shot.PlayerHandedness != PlayerHandednessNatureEnum.Left) ? 1 : (-1));
			num = IronBackspinModelPrediction.Predict(new IronBackspinModelPrediction.ModelInput
			{
				BallSpeed = ballDataDto.Speed,
				LaunchAngle = ballDataDto.VLA,
				ClubFace = clubDataDto.FaceToTarget,
				ClubPath = clubDataDto.Path
			}).Score;
			value = num;
			num2 = IronSidespinModelPrediction.Predict(new IronSidespinModelPrediction.ModelInput
			{
				BallSpeed = ballDataDto.Speed,
				LaunchAngle = ballDataDto.VLA,
				ClubFace = clubDataDto.FaceToTarget + num4,
				ClubPath = clubDataDto.Path
			}).Score;
			value2 = IronSidespinModelPrediction.Predict(new IronSidespinModelPrediction.ModelInput
			{
				BallSpeed = ballDataDto.Speed,
				LaunchAngle = ballDataDto.VLA,
				ClubFace = clubDataDto.FaceToTarget,
				ClubPath = clubDataDto.Path
			}).Score;
			num3 = shot.ConfigData?.PercentBackSpinIron ?? 1f;
			num *= num3 / 100f;
		}
		ICircularLogService logger = S1nT2rmteJ.Logger;
		if (logger != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(82, 3);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17256));
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17352));
			defaultInterpolatedStringHandler.AppendFormatted(num);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17382));
			defaultInterpolatedStringHandler.AppendFormatted(num3);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2034));
			logger.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		ICircularLogService logger2 = S1nT2rmteJ.Logger;
		if (logger2 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(166, 5);
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17430));
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17560));
			defaultInterpolatedStringHandler2.AppendFormatted(value2);
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17352));
			defaultInterpolatedStringHandler2.AppendFormatted(num2);
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17608));
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17620));
			defaultInterpolatedStringHandler2.AppendFormatted(clubDataDto.FaceToTarget);
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17668));
			defaultInterpolatedStringHandler2.AppendFormatted(clubDataDto.FaceToTarget + num4);
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17706));
			defaultInterpolatedStringHandler2.AppendFormatted(num4);
			defaultInterpolatedStringHandler2.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17744));
			logger2.Log(defaultInterpolatedStringHandler2.ToStringAndClear());
		}
		ballDataDto.BackSpin = num;
		ballDataDto.SideSpin = 0f - num2;
		ballDataDto.TotalSpin = MathF.Sqrt(MathF.Pow(num, 2f) + MathF.Pow(num2, 2f));
		ballDataDto.SpinAxis = 0f - MathF.Atan2(num2, num) * (180f / (float)Math.PI);
		shot.Ball.BackSpin = Convert.ToDouble(ballDataDto.BackSpin);
		shot.Ball.SideSpin = Convert.ToDouble(ballDataDto.SideSpin);
		shot.Ball.TotalSpin = Convert.ToDouble(ballDataDto.TotalSpin);
		shot.Ball.SpinAxis = Convert.ToDouble(ballDataDto.SpinAxis);
		jwLTxyLW2r = shot;
		S1nT2rmteJ.SendBallAndClubData(ballDataDto, clubDataDto);
	}
}
