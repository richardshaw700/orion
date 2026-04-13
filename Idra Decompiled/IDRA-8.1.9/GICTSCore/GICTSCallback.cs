using System;
using System.Reflection;
using System.Runtime.InteropServices;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;
using sGiy9qIumZhjYQCMI7;

public class GICTSCallback : IDisposable
{
	public delegate void SwigDelegateGICTSCallback_0();

	private HandleRef KnbP7WmMb;

	protected bool swigCMemOwn;

	private SwigDelegateGICTSCallback_0 GxOGb5p4j;

	private static Type[] eaWqPYdlB;

	internal GICTSCallback(nint cPtr, bool cMemoryOwn)
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
		swigCMemOwn = cMemoryOwn;
		KnbP7WmMb = new HandleRef(this, cPtr);
	}

	internal static HandleRef sX63eV9Dc(GICTSCallback P_0)
	{
		return P_0?.KnbP7WmMb ?? new HandleRef(null, IntPtr.Zero);
	}

	~GICTSCallback()
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
			if (KnbP7WmMb.Handle != IntPtr.Zero)
			{
				if (swigCMemOwn)
				{
					swigCMemOwn = false;
					mcgGLo2CjNleAwBOso.h4qEHRAW1(KnbP7WmMb);
				}
				KnbP7WmMb = new HandleRef(null, IntPtr.Zero);
			}
		}
	}

	public virtual void run()
	{
		if (vbri1UWFS(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(466), eaWqPYdlB))
		{
			mcgGLo2CjNleAwBOso.emRXC6Lv0(KnbP7WmMb);
		}
		else
		{
			mcgGLo2CjNleAwBOso.ypEoJ7IJp(KnbP7WmMb);
		}
	}

	public GICTSCallback()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		this._002Ector(mcgGLo2CjNleAwBOso.dXreRi7Uq(), cMemoryOwn: true);
		Df9lGVqmS();
	}

	private void Df9lGVqmS()
	{
		if (vbri1UWFS(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(466), eaWqPYdlB))
		{
			GxOGb5p4j = y5nQqX2Gu;
		}
		mcgGLo2CjNleAwBOso.Ekl0InD9i(KnbP7WmMb, GxOGb5p4j);
	}

	private bool vbri1UWFS(string P_0, Type[] P_1)
	{
		return GetType().GetMethod(P_0, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, P_1, null).DeclaringType.IsSubclassOf(typeof(GICTSCallback));
	}

	private void y5nQqX2Gu()
	{
		run();
	}

	static GICTSCallback()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		eaWqPYdlB = new Type[0];
	}
}
