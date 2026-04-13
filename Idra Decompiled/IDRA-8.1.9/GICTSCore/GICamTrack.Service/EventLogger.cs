using System.Diagnostics;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;

namespace GICamTrack.Service;

public class EventLogger : LogBase
{
	public override void Log(string message)
	{
		lock (lockObj)
		{
			EventLog eventLog = new EventLog(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(648));
			eventLog.Source = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(680);
			eventLog.WriteEntry(message);
		}
	}

	public EventLogger()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
	}
}
