using System;
using System.Runtime.InteropServices;
using lKEAGvFqWp7B16kDoY;
using sGiy9qIumZhjYQCMI7;

public class LightInterface : IDisposable
{
	private HandleRef RSxgXvarQe;

	protected bool swigCMemOwn;

	public bool StartAutoShotMode
	{
		get
		{
			return mcgGLo2CjNleAwBOso.uRegOj5fkQ(RSxgXvarQe);
		}
		set
		{
			mcgGLo2CjNleAwBOso.QUegIGnrtG(RSxgXvarQe, value);
		}
	}

	public RunningModeEnum RunningMode
	{
		get
		{
			return (RunningModeEnum)mcgGLo2CjNleAwBOso.bO1gZNEFGL(RSxgXvarQe);
		}
		set
		{
			mcgGLo2CjNleAwBOso.JJ1gatyOOV(RSxgXvarQe, (int)value);
		}
	}

	public string LOG_FILENAME
	{
		get
		{
			string result = mcgGLo2CjNleAwBOso.y5TgBUkfoF(RSxgXvarQe);
			if (mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.gYOChRE5q7())
			{
				throw mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.elbCBSCuIc();
			}
			return result;
		}
		set
		{
			mcgGLo2CjNleAwBOso.aaPgUw02CS(RSxgXvarQe, value);
			if (mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.gYOChRE5q7())
			{
				throw mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.elbCBSCuIc();
			}
		}
	}

	internal LightInterface(nint cPtr, bool cMemoryOwn)
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
		swigCMemOwn = cMemoryOwn;
		RSxgXvarQe = new HandleRef(this, cPtr);
	}

	internal static HandleRef llFgoGx2UJ(LightInterface P_0)
	{
		return P_0?.RSxgXvarQe ?? new HandleRef(null, IntPtr.Zero);
	}

	~LightInterface()
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
			if (RSxgXvarQe.Handle != IntPtr.Zero)
			{
				if (swigCMemOwn)
				{
					swigCMemOwn = false;
					mcgGLo2CjNleAwBOso.za7gtm2Yc2(RSxgXvarQe);
				}
				RSxgXvarQe = new HandleRef(null, IntPtr.Zero);
			}
		}
	}

	public LightInterface()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		this._002Ector(mcgGLo2CjNleAwBOso.UgcghSk2I2(), cMemoryOwn: true);
	}

	public bool loadMLModel()
	{
		return mcgGLo2CjNleAwBOso.Bopgrts33r(RSxgXvarQe);
	}

	public int main()
	{
		return mcgGLo2CjNleAwBOso.MXrgy5t8iO(RSxgXvarQe);
	}

	public void release()
	{
		mcgGLo2CjNleAwBOso.sbNg94qSDo(RSxgXvarQe);
	}

	public void delCameraCallback()
	{
		mcgGLo2CjNleAwBOso.AdAgA75BsW(RSxgXvarQe);
	}

	public void setCameraCallback(CameraCallback cb)
	{
		mcgGLo2CjNleAwBOso.geugjAQYxj(RSxgXvarQe, CameraCallback.CdUsKhi4K(cb));
	}

	public void resetCameraCallback()
	{
		mcgGLo2CjNleAwBOso.fbOg6v1DwQ(RSxgXvarQe);
	}

	public void OnCameraStateChanged(ShotStatusEnum state)
	{
		mcgGLo2CjNleAwBOso.G1Hg1RpSJj(RSxgXvarQe, (int)state);
	}

	public void OnCameraStateChanged(ShotStatusEnum state, ShotStatusData data)
	{
		mcgGLo2CjNleAwBOso.MIrgk84xeO(RSxgXvarQe, (int)state, ShotStatusData.p8FgeEG2TK(data));
		if (mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.gYOChRE5q7())
		{
			throw mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.elbCBSCuIc();
		}
	}

	public void OnNewShot(GICTSShotData shot)
	{
		mcgGLo2CjNleAwBOso.xiRgdYH4ve(RSxgXvarQe, GICTSShotData.p32FdXM1G(shot));
		if (mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.gYOChRE5q7())
		{
			throw mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.elbCBSCuIc();
		}
	}

	public void OnHasExited(int code)
	{
		mcgGLo2CjNleAwBOso.apigNdf8Oy(RSxgXvarQe, code);
	}

	public void OnCameraErrorCode(int code, string camera_serial_number, bool isSuperSpeed)
	{
		mcgGLo2CjNleAwBOso.uDKg5PVKq3(RSxgXvarQe, code, camera_serial_number, isSuperSpeed);
		if (mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.gYOChRE5q7())
		{
			throw mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.elbCBSCuIc();
		}
	}

	public void OnRefreshIDRAConfig()
	{
		mcgGLo2CjNleAwBOso.bssgcrEkMw(RSxgXvarQe);
	}

	public void ChangeRunningMode(RunningModeEnum newMode)
	{
		mcgGLo2CjNleAwBOso.WOYgWPi5J5(RSxgXvarQe, (int)newMode);
	}

	public void KillWindow()
	{
		mcgGLo2CjNleAwBOso.itBgJAAMHB(RSxgXvarQe);
	}

	public bool LoadParams(string filename)
	{
		bool result = mcgGLo2CjNleAwBOso.CM3g4EecT5(RSxgXvarQe, filename);
		if (mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.gYOChRE5q7())
		{
			throw mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.elbCBSCuIc();
		}
		return result;
	}

	public bool HaveValidCalibration()
	{
		return mcgGLo2CjNleAwBOso.LE3g37ai0E(RSxgXvarQe);
	}

	public string processPriorityToStr(int priority)
	{
		return mcgGLo2CjNleAwBOso.O8KglHcCP6(RSxgXvarQe, priority);
	}

	public int strToPriorityProcess(string priority)
	{
		int result = mcgGLo2CjNleAwBOso.Ifwgiqia8u(RSxgXvarQe, priority);
		if (mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.gYOChRE5q7())
		{
			throw mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.elbCBSCuIc();
		}
		return result;
	}

	public bool saveStressTestsResults(string folder)
	{
		bool result = mcgGLo2CjNleAwBOso.HaagQv2xcf(RSxgXvarQe, folder);
		if (mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.gYOChRE5q7())
		{
			throw mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.elbCBSCuIc();
		}
		return result;
	}

	public bool PauseCameraAcquisition()
	{
		return mcgGLo2CjNleAwBOso.MhwgPTPCeB(RSxgXvarQe);
	}

	public bool ResumeCameraAcquisition()
	{
		return mcgGLo2CjNleAwBOso.MlRgGZYkxb(RSxgXvarQe);
	}

	public void CamFactoryReset()
	{
		mcgGLo2CjNleAwBOso.eV9gqlhdA3(RSxgXvarQe);
	}

	public void SendDebugShot()
	{
		mcgGLo2CjNleAwBOso.SwIgmsWtfZ(RSxgXvarQe);
	}

	public bool ReinitializeSystemCameras(bool raisedByFrameEmpty)
	{
		return mcgGLo2CjNleAwBOso.ruig2s8SgW(RSxgXvarQe, raisedByFrameEmpty);
	}

	public void executeRestartPortsOnCamSN()
	{
		mcgGLo2CjNleAwBOso.LLGgFsHP9q(RSxgXvarQe);
	}
}
