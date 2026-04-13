namespace GIToolkit.Services;

public interface IZoneGolfInDriveFile
{
	string DownloadUrl { get; }

	string FileName { get; }

	long FileSize { get; }

	string ScriptToExecute { get; }

	SoftwareType SoftwareType { get; }

	bool UseThisVersionInProduction { get; }

	bool UseLatestVersion { get; }

	bool CanBeInstall();
}
