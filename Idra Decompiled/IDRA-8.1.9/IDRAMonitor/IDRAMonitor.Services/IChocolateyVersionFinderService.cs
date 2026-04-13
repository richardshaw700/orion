using System.Threading.Tasks;
using GIToolkit.Services;

namespace IDRAMonitor.Services;

public interface IChocolateyVersionFinderService : IService
{
	public enum Environment
	{
		Internal,
		Prod
	}

	Task<string> FindLatestProductionVersion(string packageId, Environment environment);

	Task<bool> IsUsingProductionChocolateyRepository();
}
