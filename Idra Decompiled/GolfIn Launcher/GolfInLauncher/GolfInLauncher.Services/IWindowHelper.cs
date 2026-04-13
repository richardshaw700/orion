using System.Windows;
using GIToolkit.Services;

namespace GolfInLauncher.Services;

public interface IWindowHelper : IService
{
	bool IsWindowOpen<T>(string name = "") where T : Window;
}
