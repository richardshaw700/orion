using System.Threading.Tasks;
using GIToolkit.Model;
using GIToolkit.Services;

namespace GolfInLauncher.Services;

public interface ILauncherDataApi : IService
{
	Task<ErrorCode> FetchMinimumDataForLauncher();
}
