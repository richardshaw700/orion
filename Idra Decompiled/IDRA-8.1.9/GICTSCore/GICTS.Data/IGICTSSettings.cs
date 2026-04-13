namespace GICTS.Data;

public interface IGICTSSettings
{
	int CamerasStartRunningMode { get; set; }

	ClubSettings ClubSettings { get; set; }

	E6ConfigsSettings E6ConfigsSettings { get; set; }

	E6LimitsSettings E6LimitsSettings { get; set; }

	InsertSettings InsertSettings { get; set; }

	Language Language { get; set; }

	string LanguageKK { get; }

	int MinimumFreeSpaceToKeepGb { get; set; }

	int MinimumNumberOfShotsToKeep { get; set; }

	ShotAdsjustementSettings ShotAdsjustementSettings { get; set; }

	bool StartAutoShotMode { get; set; }

	bool StartWithGame { get; set; }

	bool UseGSPro { get; set; }

	bool UseE6Connect { get; set; }

	string StableGSProVersion { get; set; }
}
