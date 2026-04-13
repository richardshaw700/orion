using System.Threading;
using System.Threading.Tasks;
using GhU84wwqvI4UZ3pBfu;

namespace IDRA.Auxiliary.Helpers;

public class AsyncManualResetEvent
{
	private TaskCompletionSource<bool> GkPCT4CiXP;

	public async Task<bool> WaitAsync(int timeoutMilliseconds = -1)
	{
		TaskCompletionSource<bool> tcsSnapshot = GkPCT4CiXP;
		if (timeoutMilliseconds == -1)
		{
			await tcsSnapshot.Task;
			return true;
		}
		return await Task.WhenAny(tcsSnapshot.Task, Task.Delay(timeoutMilliseconds)) == tcsSnapshot.Task;
	}

	public void Set()
	{
		GkPCT4CiXP.TrySetResult(result: true);
	}

	public void Reset()
	{
		TaskCompletionSource<bool> taskCompletionSource;
		TaskCompletionSource<bool> taskCompletionSource2;
		do
		{
			taskCompletionSource = new TaskCompletionSource<bool>();
			taskCompletionSource2 = Interlocked.Exchange(ref GkPCT4CiXP, taskCompletionSource);
		}
		while (taskCompletionSource2.Task.IsCompleted && taskCompletionSource2.Task != taskCompletionSource.Task);
	}

	public AsyncManualResetEvent()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		GkPCT4CiXP = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
		base._002Ector();
	}
}
