namespace GIToolkit.Services;

public interface IConfigurationHelper : IService
{
	void ToggleConfigEncryption(string exeFile, bool protectSection);

	string GetConnectionStringByName(string name);
}
