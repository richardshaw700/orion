using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using GIToolkit.Services;

namespace IDRAMonitor.Services;

public interface IProjectProcessService : IService
{
	bool IsDesiredExit { get; set; }

	bool IdraHasCloseSuccessfully { get; set; }

	bool LaunchBackIdra { get; set; }

	Task LaunchIdra([CallerMemberName] string caller = "");

	Task CloseIdra(int closeCode);

	Task CloseApplication();

	Task ResetIdra();
}
