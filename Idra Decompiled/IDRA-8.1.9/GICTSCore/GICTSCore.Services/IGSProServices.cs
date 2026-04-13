using System;
using System.Threading.Tasks;
using GIToolkit.Model;
using GIToolkit.Services;

namespace GICTSCore.Services;

public interface IGSProServices : IService
{
	Task<ErrorCode> ApplyGolfInMod();

	Task<bool> VerifyNewGSProVersion();

	void UninstallGSProLauncher();

	Task<bool> InstallNewGSProVersion(Version version, Action<long, long> onProgress, Action onCompleted);

	Task<Version> GetGSProStableVersion();
}
