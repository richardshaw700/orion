using GIToolkit.Services;

namespace GolfInLauncher.Services;

public interface ICultureResourcesService : IService
{
	void SetCulture(string name);
}
