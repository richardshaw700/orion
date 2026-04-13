using System;
using System.Diagnostics;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class CustomStopwatch : Stopwatch, ICustomStopwatch
{
	private TimeSpan RSQxdB9ePi;

	public new TimeSpan Elapsed
	{
		get
		{
			return base.Elapsed + RSQxdB9ePi;
		}
		set
		{
			RSQxdB9ePi = value;
		}
	}

	public new long ElapsedMilliseconds => base.ElapsedMilliseconds + RSQxdB9ePi.Milliseconds;

	public new long ElapsedTicks => base.ElapsedTicks + RSQxdB9ePi.Ticks;

	public CustomStopwatch()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}

	public CustomStopwatch(TimeSpan offset)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		RSQxdB9ePi = offset;
	}

	public void SetOffset(TimeSpan offsetElapsedTimeSpan)
	{
		RSQxdB9ePi = offsetElapsedTimeSpan;
	}

	public void ResetOffset()
	{
		RSQxdB9ePi = new TimeSpan(0, 0, 0);
	}

	void ICustomStopwatch.Start()
	{
		Start();
	}

	void ICustomStopwatch.Stop()
	{
		Stop();
	}
}
