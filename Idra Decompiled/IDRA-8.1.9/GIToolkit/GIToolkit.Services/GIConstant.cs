using System;
using System.IO;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public static class GIConstant
{
	public static string OldProgramFilesPath;

	public static string PathToE6Folder => so95DAFNMfktfjp4Dm.An6v7kuCGg(8728);

	public static string E6ConnectExecutable => so95DAFNMfktfjp4Dm.An6v7kuCGg(8804);

	public static string PathToTruTrackXml => so95DAFNMfktfjp4Dm.An6v7kuCGg(8834);

	public static string E6UpdateWebsite => so95DAFNMfktfjp4Dm.An6v7kuCGg(8938);

	public static string E6VersionXPath => so95DAFNMfktfjp4Dm.An6v7kuCGg(9016);

	public static string ProgramDataPath => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	public static string GolfInFolder => so95DAFNMfktfjp4Dm.An6v7kuCGg(9162);

	public static string LauncherCardConfigJsonFile => so95DAFNMfktfjp4Dm.An6v7kuCGg(9186);

	public static string PathToGolfInFolder => ProgramDataPath + so95DAFNMfktfjp4Dm.An6v7kuCGg(9246);

	public static string PathToLauncherCardConfigJsonFile => ProgramDataPath + so95DAFNMfktfjp4Dm.An6v7kuCGg(9246) + LauncherCardConfigJsonFile;

	public static string PathToFRDocuments => PathToGolfInFolder + so95DAFNMfktfjp4Dm.An6v7kuCGg(9266);

	public static string PathToENDocuments => PathToGolfInFolder + so95DAFNMfktfjp4Dm.An6v7kuCGg(9276);

	public static bool UsingSSCInstallPath => Environment.GetEnvironmentVariable(so95DAFNMfktfjp4Dm.An6v7kuCGg(9286)) != null;

	public static string SSCInstallPath => Environment.GetEnvironmentVariable(so95DAFNMfktfjp4Dm.An6v7kuCGg(9286)) ?? OldProgramFilesPath;

	public static string SSCIDRAInstallPath
	{
		get
		{
			if (!UsingSSCInstallPath)
			{
				return OldProgramFilesPath;
			}
			return SSCInstallPath + so95DAFNMfktfjp4Dm.An6v7kuCGg(3272);
		}
	}

	public static string SSCProgramDataPath
	{
		get
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + so95DAFNMfktfjp4Dm.An6v7kuCGg(9322);
			if (!UsingSSCInstallPath || !Directory.Exists(text))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + so95DAFNMfktfjp4Dm.An6v7kuCGg(9372);
			}
			return text;
		}
	}

	public static string IDRAPostShotVideoFilePath => SSCProgramDataPath + so95DAFNMfktfjp4Dm.An6v7kuCGg(9434);

	static GIConstant()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		OldProgramFilesPath = so95DAFNMfktfjp4Dm.An6v7kuCGg(9510);
	}
}
