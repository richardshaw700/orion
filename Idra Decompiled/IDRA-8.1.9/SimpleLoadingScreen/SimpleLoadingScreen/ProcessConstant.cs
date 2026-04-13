using GIToolkit.Services;

namespace SimpleLoadingScreen;

public class ProcessConstant
{
	public static int AutogainExecuteTimeMs => 5000;

	public static int ResetDelayTimeMs => 1500;

	public static string AdminPassword => "7272";

	public static string E6ProcessPath => "C:\\Program Files\\E6 Golf\\E6 Connect";

	public static string E6Process => "E6Connect.exe";

	public static string E6ProcessName => "E6Connect";

	public static string LoadingScreenProcessPath => GIConstant.SSCInstallPath + "\\IDRA";

	public static string LoadingScreenProcess => "SimpleLoadingScreen.exe";

	public static string LoadingScreenProcessName => "SimpleLoadingScreen";

	public static string IdraProcessPath => GIConstant.SSCInstallPath + "\\IDRA";

	public static string IdraProcess => "IDRA.exe";

	public static string IdraProcessName => "IDRA";

	public static string IdraDLL => "IDRA.dll";

	public static string IdraMonitorProcess => "IDRAMonitor.exe";

	public static string IdraMonitorProcessName => "IDRAMonitor";

	public static string IdraProgramDataPath => GIConstant.SSCProgramDataPath + "\\IDRA";

	public static string IdraProgramDataPathConfig => GIConstant.SSCProgramDataPath + "\\IDRA\\config";

	public static string IdraProgramDataPathCalib => GIConstant.SSCProgramDataPath + "\\IDRA\\config\\calibrations";

	public static string IdraProgramDataPathSamples => GIConstant.SSCProgramDataPath + "\\IDRA\\samples";

	public static string IdraProgramDataPathResults => GIConstant.SSCProgramDataPath + "\\IDRA\\samples\\Results";

	public static string IdraProgramDataPathGroundTruth => GIConstant.SSCProgramDataPath + "\\IDRA\\samples\\GroundTruth";

	public static string IdraProgramDataPathShots => GIConstant.SSCProgramDataPath + "\\IDRA\\samples\\Shots";
}
