using System;
using System.Text.Json;
using GICTS.Data;
using GIToolkit.Services;
using IDRASharedModels;

namespace GICTSCore.Services;

public interface ICommunicationIDRALocalAPI : IService, IDisposable
{
	ClubTypeEnum CurrentClubType { get; }

	string CurrentPlayerName { get; }

	PlayerHandednessNatureEnum CurrentPlayerHandedness { get; }

	bool IsConnected { get; }

	GICTSMessage.InfoSubClassEnum LastCommand { get; }

	ILocalAPIGameSettings LocalAPIGameSettings { get; }

	Action<SimCommandShotCompletedMsg> OnShotCompleted { get; set; }

	Action<DateTime> OnPing { get; set; }

	Action<string> OnArmed { get; set; }

	Action<string> OnDisarmed { get; set; }

	Action<PlayerHandednessNatureEnum, ClubTypeEnum, string> OnPlayerDataModified { get; set; }

	Action<SimCommandEnvironmentDataModifiedMsg> OnEnvironmentDataModified { get; set; }

	Action<GICTSMessage.InfoClassEnum, ClubTypeEnum> OnSetClubType { get; set; }

	Action OnTrackingStatusData { get; set; }

	Action<string> OnNewTextMessage { get; set; }

	Action<bool> OnClientConnected { get; set; }

	Action<bool> OnClientDisconnected { get; set; }

	Action<bool> OnAuthenticated { get; set; }

	Action<bool> OnGameProcessReady { get; set; }

	void Connect();

	void Disconnect();

	void GetPlayerDataMessage();

	void RequestGameSettings();

	bool IsAvailableForConnection(string processName);

	void SendAnyMessage(string msg);

	void SendShot(CTSShotData shot);

	string PrettyJson(string unPrettyJson, ref JsonElement toJsonObj, bool logIntdented = true);

	void GetEnvironmentDataMessage();

	void SendBoothDataMessage(BoothData msg);

	void SendBoothDataMessage(GspBoothData msg);

	void SendConfigDataMessage(ConfigData msg);

	void SendStatusMessage(TrackingStatusData msg);

	void SendUpdateShot(CTSShotData shot);

	void SendMulliganLastShot();

	void SetClubTypeMessage(SetClubTypeData msg);

	void SendBallOnTeeDisplacementLeft();

	void SendBallOnTeeDisplacementRight();
}
