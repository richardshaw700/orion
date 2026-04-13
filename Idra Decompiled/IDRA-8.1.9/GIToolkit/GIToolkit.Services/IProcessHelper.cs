using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GIToolkit.Services;

public interface IProcessHelper
{
	[Obsolete("Use InstallProductPackages instead")]
	void StartDownloadProcessSilentlyAsAdmin(string fileName);

	void AutoResetPC(bool underCondition);

	Process CreateProcess(string fileName, string arguments = "", bool enableRaisingEvent = true);

	[Obsolete]
	Process CreateProcess(string fileName, string workingDirectory, string arguments, bool enableRaisingEvent = true);

	Process GetProcessByName(string name, bool enableRaisingEvent = true);

	bool IsProcessRunning(string processName);

	void StartProcess(Process processToStart, int maxRetries = 3);

	bool ProcessIsSetAndHasNotExited(Process processToCheck);

	void AttachListenerOnExited(Process process, EventHandler actionToPerformOnExit);

	void DetachListenerOnExited(Process process, EventHandler actionToPerformOnExit);

	void DeleteUnusedCredentialManagement();

	[Obsolete]
	void BringWindowToFront(string processName);

	void ModifyWindowState(string processName, ShowWindowEnum state, bool setFocus = false);

	Task<bool> InstallProductPackages(string filePath, double timeOutMin = 15.0);

	Task<bool> WaitProcessExitedTimeOut(Process process, double timeOutMin);
}
