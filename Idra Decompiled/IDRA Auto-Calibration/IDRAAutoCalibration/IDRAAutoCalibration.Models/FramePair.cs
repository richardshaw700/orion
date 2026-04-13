using System;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration.Models;

public struct FramePair
{
	private readonly Frame? KnVJah4dmP;

	private readonly Frame? tB0JBsTqYw;

	public FramePair(Frame master, Frame slave)
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		KnVJah4dmP = null;
		tB0JBsTqYw = null;
		KnVJah4dmP = master;
		tB0JBsTqYw = slave;
	}

	public Tuple<Frame, Frame> GetFrames()
	{
		return new Tuple<Frame, Frame>(KnVJah4dmP, tB0JBsTqYw);
	}

	public bool HasFrames()
	{
		if (KnVJah4dmP != null)
		{
			return tB0JBsTqYw != null;
		}
		return false;
	}
}
