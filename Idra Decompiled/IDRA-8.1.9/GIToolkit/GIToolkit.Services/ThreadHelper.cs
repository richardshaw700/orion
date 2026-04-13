using System;
using System.Threading;
using System.Threading.Tasks;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class ThreadHelper : IThreadHelper
{
	public void StartTaskAsyncFunc(Func<Task> asyncTaskToPerform)
	{
		Task.Run(asyncTaskToPerform);
	}

	public void StartTaskAcion(Action syncTaskToPerform)
	{
		Task.Run(syncTaskToPerform);
	}

	public async Task Delay(int ms)
	{
		await Task.Delay(ms);
	}

	public Thread StartBackgroundThread(ThreadStart threadStart = null)
	{
		Thread thread = new Thread(threadStart);
		thread.SetApartmentState(ApartmentState.STA);
		thread.IsBackground = true;
		thread.Start();
		return thread;
	}

	public ThreadHelper()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
