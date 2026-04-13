using System;
using System.Runtime.InteropServices;
using lKEAGvFqWp7B16kDoY;
using sGiy9qIumZhjYQCMI7;

public class ShotStatusData : IDisposable
{
	private HandleRef QOZg0eopk5;

	protected bool swigCMemOwn;

	public double OffsetBallX
	{
		get
		{
			return mcgGLo2CjNleAwBOso.z3msS1foCd(QOZg0eopk5);
		}
		set
		{
			mcgGLo2CjNleAwBOso.wJisnEr3qP(QOZg0eopk5, value);
		}
	}

	public double OffsetBallY
	{
		get
		{
			return mcgGLo2CjNleAwBOso.bItsvtXadq(QOZg0eopk5);
		}
		set
		{
			mcgGLo2CjNleAwBOso.rh8sVja7e1(QOZg0eopk5, value);
		}
	}

	public double OffsetBallZ
	{
		get
		{
			return mcgGLo2CjNleAwBOso.qnrsDDgt4N(QOZg0eopk5);
		}
		set
		{
			mcgGLo2CjNleAwBOso.JWVsHyowH6(QOZg0eopk5, value);
		}
	}

	public ShotStatusMoveBallDirectionEnum MoveBallDirection
	{
		get
		{
			return (ShotStatusMoveBallDirectionEnum)mcgGLo2CjNleAwBOso.g9xsCMIjjP(QOZg0eopk5);
		}
		set
		{
			mcgGLo2CjNleAwBOso.EDgsTM3wrV(QOZg0eopk5, (int)value);
		}
	}

	public ClubFunctionEnum clubType
	{
		get
		{
			return (ClubFunctionEnum)mcgGLo2CjNleAwBOso.b3usKIotOm(QOZg0eopk5);
		}
		set
		{
			mcgGLo2CjNleAwBOso.hoosMqnEDh(QOZg0eopk5, (int)value);
		}
	}

	internal ShotStatusData(nint cPtr, bool cMemoryOwn)
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
		swigCMemOwn = cMemoryOwn;
		QOZg0eopk5 = new HandleRef(this, cPtr);
	}

	internal static HandleRef p8FgeEG2TK(ShotStatusData P_0)
	{
		return P_0?.QOZg0eopk5 ?? new HandleRef(null, IntPtr.Zero);
	}

	~ShotStatusData()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		lock (this)
		{
			if (QOZg0eopk5.Handle != IntPtr.Zero)
			{
				if (swigCMemOwn)
				{
					swigCMemOwn = false;
					mcgGLo2CjNleAwBOso.COrs7ZrjfZ(QOZg0eopk5);
				}
				QOZg0eopk5 = new HandleRef(null, IntPtr.Zero);
			}
		}
	}

	public ShotStatusData()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		this._002Ector(mcgGLo2CjNleAwBOso.wKOspxnHYT(), cMemoryOwn: true);
	}
}
