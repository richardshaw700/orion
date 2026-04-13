using System.IO;

namespace GIToolkit.Services;

public interface ICircularLogService
{
	int MinimumDayBeforeSuppressionDefault => 30;

	long MaximumFileSizeDefault => 1048576L;

	FileInfo CurrentLogFile { get; }

	FileInfo SetupLogFile(string directoryPath, string logFileName, bool useTraceLoggingMethod = true, int minimumDayBeforeSuppression = 30, long maximumFileSize = 1048576L);

	string GetCurrentLogFileDirectory();

	void Log(string text, LogLevel level = LogLevel.Info);

	void Log<T>(string text, T logObject, LogLevel level = LogLevel.Info);

	void LogFileCloseTag();

	void LogFileOpenTag();

	void SetLogLevel(LogLevel logLevel);
}
