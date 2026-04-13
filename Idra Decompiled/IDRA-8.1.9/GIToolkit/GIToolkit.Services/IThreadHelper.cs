using System;
using System.Threading;
using System.Threading.Tasks;

namespace GIToolkit.Services;

public interface IThreadHelper
{
	void StartTaskAsyncFunc(Func<Task> asyncTaskToPerform);

	void StartTaskAcion(Action syncTaskToPerform);

	Task Delay(int ms);

	Thread StartBackgroundThread(ThreadStart threadStart = null);
}
