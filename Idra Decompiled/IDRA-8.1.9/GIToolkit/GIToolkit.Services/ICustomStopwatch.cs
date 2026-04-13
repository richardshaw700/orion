using System;

namespace GIToolkit.Services;

public interface ICustomStopwatch
{
	TimeSpan Elapsed { get; set; }

	long ElapsedMilliseconds { get; }

	long ElapsedTicks { get; }

	void ResetOffset();

	void SetOffset(TimeSpan offsetElapsedTimeSpan);

	void Start();

	void Stop();
}
