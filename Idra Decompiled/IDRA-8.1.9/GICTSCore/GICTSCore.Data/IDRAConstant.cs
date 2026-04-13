using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using GIToolkit.Services;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;

namespace GICTSCore.Data;

public static class IDRAConstant
{
	public static class ShotXMLModel
	{
		public static class Ref
		{
			public const string BallSpeedXMLNodeName = "SpeedReference";

			public const string BallDirectionXMLNodeName = "DirectionReference";

			public const string BallLaunchAngleXMLNodeName = "LaunchAngleReference";

			public const string BallSideSpinXMLNodeName = "SideSpinReference";

			public const string BallBackSpinXMLNodeName = "BackSpinReference";

			public const string BallSideSpinE6XMLNodeName = "SideSpinCalculated";

			public const string BallBackSpinE6XMLNodeName = "BackSpinCalculated";

			public const string ClubPathXMLNodeName = "PathReference";

			public const string ClubSpeedXMLNodeName = "SpeedReference";

			public const string ClubFaceXMLNodeName = "ClubFaceReference";

			public const string ClubBallHitPercentIDRAXMLNodeName = "ClubBallHitPercentReference";

			public const string TestCaseXMLNodeName = "TestCaseDescription";
		}

		public static class Source
		{
			public const string BallDirectionXPATH = "/Shot/Ball/Direction";

			public const string BallLaunchAngleXPATH = "/Shot/Ball/LaunchAngle";

			public const string BallSpeedXPATH = "/Shot/Ball/Speed";

			public const string ClubAttackAngleXPATH = "/Shot/Club/AttackAngle";

			public const string ClubPathXPATH = "/Shot/Club/Path";

			public const string ClubSpeedXPATH = "/Shot/Club/Speed";

			public const string PlayerHandednessXPATH = "/Shot/Player/Handed";
		}

		public const string BallXPATHParent = "/Shot/Ball";

		public const string ClubXPATHParent = "/Shot/Club";

		public const string ShotXPATHParent = "/Shot";
	}

	public static string IDRACalibrationProgramFolderName;

	public static string GSProProcessName;

	public static string GSProProcess;

	public static string GSProProcessPath;

	public static string GSProFolderPath;

	public static string GSProLauncherProcessName;

	public static string GSProLauncherProcess;

	public static string GSProLauncherProcessPath;

	public static string GSProConnectProcessPath;

	public static string GICTSSettingsFilePath;

	public static string ManagertSettingsFilePath;

	public const string Camera1SNXPATH = "/Configurations/Cameras/Camera1/ID";

	public const string Camera2SNXPATH = "/Configurations/Cameras/Camera2/ID";

	public const string ConfigUseCameras = "/Configurations/Debug/UseCameras";

	public static Version StableSupportedGSProVersion => new Version(3, 1, 6, 20);

	public static double MPS_TO_MPH => 2.2369;

	public static double MPH_TO_MPS => 0.44704;

	public static double MPS_TO_FTPS => 3.281;

	public static double DefaultMaxSmashFactor => 1.52;

	public static double DefaultImpactFactorOnClubFaceAndBallDirection => 0.5;

	public static int AutogainExecuteTimeMs => 5000;

	public static int ResetMaxDelayTimeMs => 8000;

	public static int DelayTimeToOpenIdra => 3500;

	public static int DelayTimeToFactoryReset => 10000;

	public static string AdminPassword => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8394);

	public static string AdminManagerPassword => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8406);

	public static string DefaultManagerPin => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8418);

	public static int AutoSaveShotForXHour => 24;

	public static string E6ProcessName => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8430);

	public static string E6Process => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8452);

	public static string E6ProcessPath => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8482) + E6Process;

	public static string GSProConnectProcessName => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8558);

	public static string GSProConnectProcess => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8582);

	public static int GSProBufferReadSize => 1024;

	public static int ReceiveBuffer => 2048;

	public static int SendBuffer => 2048;

	public static string LauncherCardConfigJsonFile => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8614);

	public static string StoragePath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8674));

	public static string PathToGolfInLauncherJsonSettings => Path.Combine(StoragePath, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8688));

	public static string GolfInLauncherName => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8766);

	public static string LoadingScreenProcessPath
	{
		get
		{
			if (!GIConstant.UsingSSCInstallPath)
			{
				return YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8798);
			}
			return GIConstant.SSCInstallPath + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8892);
		}
	}

	public static string LoadingScreenProcess => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8906);

	public static string LoadingScreenProcessName => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8956);

	public static string IDRACalibrationProcess => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8998);

	public static string IdraProcessPath
	{
		get
		{
			if (!GIConstant.UsingSSCInstallPath)
			{
				return YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8798);
			}
			return GIConstant.SSCInstallPath + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8892);
		}
	}

	public static string IdraProcessPathRelease => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(9048);

	public static string IdraProcess => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(9152);

	public static string IdraProcessName => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(9172);

	public static string IdraMonitorProcess => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(9184);

	public static string IdraProgramDataPath
	{
		get
		{
			if (!GIConstant.UsingSSCInstallPath)
			{
				return YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(9218);
			}
			return GIConstant.SSCProgramDataPath + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8892);
		}
	}

	public static string IdraProgramDataPathConfig
	{
		get
		{
			if (!GIConstant.UsingSSCInstallPath)
			{
				return YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(9318);
			}
			return GIConstant.SSCProgramDataPath + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(9432);
		}
	}

	public static string IdraProgramDataPathCalib
	{
		get
		{
			if (!GIConstant.UsingSSCInstallPath)
			{
				return YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(9556);
			}
			return GIConstant.SSCProgramDataPath + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(9696);
		}
	}

	public static string CustomIDRALogoFilePath => IdraProgramDataPath + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(9750);

	public static string SimulatorAppShotLogFilenameE6Connect => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(9796);

	public static string GICTSSettingsFilename => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(9932);

	public static string GICTSDefaultSettingsFilename => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(9956);

	public static string ExecutingAssembyDirectoryPath => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

	public static string GICTSDefaultSettingsFilePath => Path.Combine(GICTSDataFolder, GICTSDefaultSettingsFilename);

	public static string GICTSDefaultInstallationFilePath => Path.Combine(ExecutingAssembyDirectoryPath, GICTSDefaultSettingsFilename);

	public static string[] FilterGSProLog => new string[1] { YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(9996) };

	public static string GICTSDataFolder => GIConstant.SSCProgramDataPath + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8892);

	public static string GICTSCamLogDirectoryPath => GICTSDataFolder + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10030);

	public static string GICTSCamLogCamerasDirectoryPath => GICTSDataFolder + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10044);

	public static string ApiCommLogDirectoryPath => GICTSDataFolder + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10074);

	public static string ApiCommGSProLogDirectoryPath => GICTSDataFolder + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10124);

	public static string IdraLogDirectoryPath => GICTSDataFolder + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10200);

	public static string IdraMonitorLogDirectoryPath => GICTSDataFolder + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10224);

	public static string GICTSLogFilename => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10264);

	public static string CamerasLogFilename => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10292);

	public static string GICTSSamplesFolder => GICTSDataFolder + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10328);

	public static string GICTSSamplesResultsFolder => GICTSSamplesFolder + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10348);

	public static string GICTSSamplesShotsFolder => GICTSSamplesFolder + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10368);

	public static string GICTSSamplePostShotVideo => GICTSSamplesFolder + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10384);

	public static string GICTSSamplesGroundTruthFolder => GICTSSamplesFolder + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10434);

	public static double PostShotVideoFPS => 30.0;

	public static double PostShotVideoLengthSec => 5.0;

	public static string FrenchCulture => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10462);

	public static string EnglishCulture => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10476);

	public static string E6ConnectProcessName => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8430);

	public static string GolfInPluginModFilesFolderPath => ExecutingAssembyDirectoryPath + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10490);

	public static string NewBepInExGIPluginDllFilePath => ExecutingAssembyDirectoryPath + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10536);

	public static string PathToGSProHostFolder => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10648);

	public static string BepInExGSProFolderPath => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10672);

	public static string CurrentBepInExGIPluginDllFilePath => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10730);

	public static string CurrentBepInExGIPluginDllFolderPath => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10672);

	public static string GSProRegistryUninstallDisplayNameV1 => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10838);

	public static string GSProRegistryUninstallDisplayNameV3 => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10856);

	public static string GSProPracticeRangePlayerName => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10870);

	public static string[] GSPLauncherFilePathDelete => new string[4]
	{
		YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10890),
		YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10946),
		YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(11016),
		YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(11162)
	};

	public static string GSProVersionFilePath => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(11218);

	public static string GSProTempDownloadZipName => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(11266);

	public static string GSProInstalledDirectoryPath => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(11292);

	public static string DebugLevelNodeXPath => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(11334);

	public static string UseCameraXPath => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(11402);

	public static string ShowInterfaceNodeXPath => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(11470);

	public static string AutoSaveShotUntilTimestampXPath => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(11548);

	public static string ExportPostShotVideoXPATH => YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(11648);

	public static int NbPossibleSegmentClub => 9;

	public static string SuccessSoundPath => ExecutingAssembyDirectoryPath + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(11734);

	[SpecialName]
	private static string vMMvPKx6Zt()
	{
		return YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(9460);
	}

	[SpecialName]
	private static string ROivqLDvsk()
	{
		return YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(9500);
	}

	[SpecialName]
	private static string vJTv2FAloF()
	{
		return Path.Combine(IdraProgramDataPathConfig, vMMvPKx6Zt());
	}

	[SpecialName]
	private static string zOrvxLk3s3()
	{
		return Path.Combine(IdraProgramDataPathConfig, ROivqLDvsk());
	}

	public static bool UseDynamicConfig()
	{
		if (!File.Exists(zOrvxLk3s3()))
		{
			return !File.Exists(vJTv2FAloF());
		}
		return true;
	}

	public static string IdraConfigurationFilePath()
	{
		if (!UseDynamicConfig())
		{
			return vJTv2FAloF();
		}
		return zOrvxLk3s3();
	}

	static IDRAConstant()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		IDRACalibrationProgramFolderName = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(11828);
		GSProProcessName = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(10856);
		GSProProcess = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(11874);
		GSProProcessPath = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(11896) + GSProProcess;
		GSProFolderPath = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(11292);
		GSProLauncherProcessName = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(11940);
		GSProLauncherProcess = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(11940);
		GSProLauncherProcessPath = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(11974) + GSProLauncherProcess;
		GSProConnectProcessPath = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12000);
		GICTSSettingsFilePath = Path.Combine(GICTSDataFolder, GICTSSettingsFilename);
		ManagertSettingsFilePath = Path.Combine(GICTSDataFolder, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12074));
	}
}
