using System.Threading.Tasks;
using GIToolkit.Services;

namespace Services;

public interface IXmlSettingsRecoveryService : IService
{
	string FindSettingPath();

	void FetchLocalSettings();

	Task SaveLocalSettings();
}
