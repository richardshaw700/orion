using System;
using System.Runtime.InteropServices;
using lKEAGvFqWp7B16kDoY;
using sGiy9qIumZhjYQCMI7;

public class GICTSCaller : IDisposable
{
	private HandleRef rrS2UcSqf;

	protected bool swigCMemOwn;

	internal GICTSCaller(nint cPtr, bool cMemoryOwn)
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
		swigCMemOwn = cMemoryOwn;
		rrS2UcSqf = new HandleRef(this, cPtr);
	}

	internal static HandleRef kL4mtLmFt(GICTSCaller P_0)
	{
		return P_0?.rrS2UcSqf ?? new HandleRef(null, IntPtr.Zero);
	}

	~GICTSCaller()
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
			if (rrS2UcSqf.Handle != IntPtr.Zero)
			{
				if (swigCMemOwn)
				{
					swigCMemOwn = false;
					mcgGLo2CjNleAwBOso.NFbzeZSPC(rrS2UcSqf);
				}
				rrS2UcSqf = new HandleRef(null, IntPtr.Zero);
			}
		}
	}

	public GICTSCaller()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		this._002Ector(mcgGLo2CjNleAwBOso.lP9RA238o(), cMemoryOwn: true);
	}

	public void delGICTSCallback()
	{
		mcgGLo2CjNleAwBOso.ekNswe8jJT(rrS2UcSqf);
	}

	public void setGICTSCallback(GICTSCallback cb)
	{
		mcgGLo2CjNleAwBOso.tsvssRdqfs(rrS2UcSqf, GICTSCallback.sX63eV9Dc(cb));
	}

	public void resetGICTSCallback()
	{
		mcgGLo2CjNleAwBOso.eREsgnSIAQ(rrS2UcSqf);
	}

	public void call()
	{
		mcgGLo2CjNleAwBOso.Um2sLmyrRy(rrS2UcSqf);
	}
}
