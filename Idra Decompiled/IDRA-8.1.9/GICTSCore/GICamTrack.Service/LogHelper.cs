namespace GICamTrack.Service;

public static class LogHelper
{
	private static LogBase wyyLhfLy67;

	public static void Log(LogTarget target, string message)
	{
		switch (target)
		{
		case LogTarget.File:
			wyyLhfLy67 = new FileLogger();
			wyyLhfLy67.Log(message);
			break;
		case LogTarget.Database:
			wyyLhfLy67 = new DBLogger();
			wyyLhfLy67.Log(message);
			break;
		case LogTarget.EventLog:
			wyyLhfLy67 = new EventLogger();
			wyyLhfLy67.Log(message);
			break;
		}
	}
}
