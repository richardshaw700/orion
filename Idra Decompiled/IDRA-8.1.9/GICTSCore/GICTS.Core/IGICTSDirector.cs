using System;
using System.IO;
using System.Threading.Tasks;
using GICTS.Data;
using GICTSCore.Services;
using GIToolkit.Services;
using IDRASharedModels;

namespace GICTS.Core;

public interface IGICTSDirector : IService
{
	GICTSSettings DefaultSettings { get; set; }

	IdraDataOutGame? IdraDataOutGame { get; set; }

	Func<int, Task> IdraHasExited { get; set; }

	Func<int, string, bool, Task> OnCamErrorCode { get; set; }

	Action OnMissingCalibrationForConnectedIDRA { get; set; }

	Action OnRefreshIDRAConfiguration { get; set; }

	Action OnGolfLocalAPIArmed { get; set; }

	Action<bool> OnUIAvailableStatusChange { get; set; }

	Func<CTSShotData, Task> OnNewShotSent { get; set; }

	Func<string, Task> OnFirstTee { get; set; }

	Action<bool> OnGSProScorecardIsVisible { get; set; }

	Action<bool> OnGSPROOSKVisible { get; set; }

	Func<GSProComputeData, Task> OnGameComputeData { get; set; }

	Func<string, int, Task> OnPostShotVideoExported { get; set; }

	Func<Task> OnVideoExported { get; set; }

	Func<SimCommandShotCompletedMsg, Task> OnShotReceiveFromGame { get; set; }

	bool IsCamerasRunning { get; set; }

	SimCommandEnvironmentDataModifiedMsg LastEnvironmentData { get; }

	CTSShotData LastShotSent { get; set; }

	DateTime LastShotDateStamp { get; set; }

	Action<bool> IsReadyNotReadySignal { get; set; }

	GICTSSettings Settings { get; set; }

	ClubTypeEnum CurrentClubType { get; }

	string CurrentPlayerName { get; }

	void GetPlayerData();

	void InitLocalAPI();

	Task<int> Launch();

	void OnCameraStateChanged(ShotStatusEnum state);

	void OnCameraStateChanged(ShotStatusEnum state, ShotStatusData data);

	void OnHasExited(int code);

	void OnLog(string log, CircularLogLevel logLevel);

	void OnNewShot(GICTSShotData shotJson);

	void OnNewTextMessageFromLocalGame(string message);

	void OnSetClubTypeMessageReceive(GICTSMessage.InfoClassEnum subClass, ClubTypeEnum club);

	void OnSetLogLevel(CircularLogLevel logLevel);

	void OnReloadSettings(GICTSSettings newSettings, FileInfo fromFile);

	void OnPostShotVideoAvailable(string shotName, int impactFrame);

	void OnVideoAvailable();

	void PrintGICTSShotData(GICTSShotData shotJson);

	Task<CTSShotData> ReadShot(string shotName, FileInfo shotFile);

	void Release();

	void SendShot(CTSShotData shot);

	ConfigData GetConfigData(CTSShotData shot);

	void SetDefaultClubType(string clubType);

	void SetTrackingStatus(TrackingStatusAction action, string option = "");

	Task SimulateLastShot();

	void SendDebugAnalyseShot();

	Task TryOverwriteSpinSettings();

	Task ReloadSettings();

	Task SaveSettings();

	ICommunicationIDRALocalAPI GetApiGameLaunched();

	void PauseCameraAcquisition();

	void ResumeCameraAcquisition();

	void SendAutoTeeBallMovementLeft();

	void SendAutoTeeBallMovementRight();
}
