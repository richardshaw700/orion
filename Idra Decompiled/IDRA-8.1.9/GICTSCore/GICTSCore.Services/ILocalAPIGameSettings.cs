namespace GICTSCore.Services;

public interface ILocalAPIGameSettings
{
	string HostName { get; }

	int PortNo { get; }

	string ProcessName { get; }

	string ProcessPath { get; }
}
