using System.Threading.Tasks;

namespace GIToolkit.Services;

public interface IPowershellService
{
	Task<string> ExecutePowerShellScript(string scriptPlainText, double timeOutMin = 15.0);

	Task<ProductVersionInfo> GetPackageProductVersionInfo(string filePath);

	Task<ProductVersionInfo> GetInstalledPackageProductVersionInfo(string productName);
}
