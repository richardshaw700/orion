using System.Threading.Tasks;
using GIToolkit.Services;

namespace GolfInLauncher.Services.SoftwareUpdate;

public interface IChocolateyLatestVersionFinder : IService
{
	public enum Environment
	{
		Internal,
		Prod,
		ProdBeta,
		Unknown
	}

	Task<string> FindPackageLatestVersionNumber(string packageId);

	Task<Environment> GetEnvironmentFromUsedChocolateySourceAsync();
}
