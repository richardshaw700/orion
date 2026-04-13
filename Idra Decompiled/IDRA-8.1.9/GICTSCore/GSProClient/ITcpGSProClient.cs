using System;
using System.Threading.Tasks;
using GIToolkit.Services;
using IDRASharedModels;

namespace GSProClient;

public interface ITcpGSProClient : IDisposable, IService
{
	Action<PlayerDataDto> OnDistanceToPinReceived { get; set; }

	Action<PlayerDataDto> OnPlayerDataReceived { get; set; }

	Action<string> OnFirstTeeReceived { get; set; }

	Action<GSProComputeData> OnGameComputeDataReceived { get; set; }

	Action<bool> OnScoreCardVisible { get; set; }

	Action<bool> OnOSKVisible { get; set; }

	Action OnReadyReceiveShot { get; set; }

	Action OnRoundHasEnded { get; set; }

	Action OnConnectedToServer { get; set; }

	Action OnDisconnectedFromServer { get; set; }

	Action<ShotDataDto> OnShotReceived { get; set; }

	ICircularLogService Logger { get; }

	Task CloseTCPConnection();

	Task<bool> ConnectToGSPro();

	void DisconnectFromServer();

	bool IsConnectedToServer();

	Task<bool> SendBallAndClubData(BallDataDto ballData, ClubDataDto clubData);

	Task<bool> SendBallData(BallDataDto ballData);

	Task<bool> SendClubData(ClubDataDto clubData);

	Task<bool> SendOpenGSProWithLoggingSystem(bool val);

	Task<bool> SendBallPositionToGsp(GspBoothData data);

	Task<bool> SendAutoTeeMoveBallLeft();

	Task<bool> SendAutoTeeMoveBallRight();
}
