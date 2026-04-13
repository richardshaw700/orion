using System;
using System.Reflection;
using System.Runtime.InteropServices;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;
using sGiy9qIumZhjYQCMI7;

public class CameraCallback : IDisposable
{
	public delegate void SwigDelegateCameraCallback_0(int state);

	public delegate void SwigDelegateCameraCallback_1(int state, nint data);

	public delegate void SwigDelegateCameraCallback_2(nint shot);

	public delegate double SwigDelegateCameraCallback_3(nint shot);

	public delegate string SwigDelegateCameraCallback_4(int club_nature, double ball_speed, double launch_angle, float ball_club_hit_percent);

	public delegate bool SwigDelegateCameraCallback_5(nint shot);

	public delegate void SwigDelegateCameraCallback_6(int code);

	public delegate void SwigDelegateCameraCallback_7(int code, string camera_serial_number, bool isSuperSpeed);

	public delegate void SwigDelegateCameraCallback_8();

	public delegate void SwigDelegateCameraCallback_9(string shotName, int impactFrame);

	public delegate void SwigDelegateCameraCallback_10(string text, int logLevel);

	public delegate void SwigDelegateCameraCallback_11(int logLevel);

	public delegate void SwigDelegateCameraCallback_12();

	private HandleRef NIPu9LXsC;

	protected bool swigCMemOwn;

	private SwigDelegateCameraCallback_0 DS7YiK6Ri;

	private SwigDelegateCameraCallback_1 IM5baMZLx;

	private SwigDelegateCameraCallback_2 iGVfBESyo;

	private SwigDelegateCameraCallback_3 YkfIKeN65;

	private SwigDelegateCameraCallback_4 UDCOMX6iq;

	private SwigDelegateCameraCallback_5 NJbaHCsAo;

	private SwigDelegateCameraCallback_6 kk3ZsCFKa;

	private SwigDelegateCameraCallback_7 ojdUdZsKG;

	private SwigDelegateCameraCallback_8 Mq6B5dfwd;

	private SwigDelegateCameraCallback_9 GNMhFWTkp;

	private SwigDelegateCameraCallback_10 ASBtQYiWj;

	private SwigDelegateCameraCallback_11 puUrY9GHl;

	private SwigDelegateCameraCallback_12 iuPy07dLY;

	private static Type[] E979NPuIO;

	private static Type[] x3TAyD6h1;

	private static Type[] zqhj3o94f;

	private static Type[] F206YmIid;

	private static Type[] KXy13lOBi;

	private static Type[] aIFk2MrcR;

	private static Type[] U8odtU0oo;

	private static Type[] YunN9vEHg;

	private static Type[] zil5JZMTJ;

	private static Type[] g8Qcnjbvw;

	private static Type[] Dv0WcvTc9;

	private static Type[] j7NJyh76l;

	private static Type[] xQl4KMoxq;

	internal CameraCallback(nint cPtr, bool cMemoryOwn)
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
		swigCMemOwn = cMemoryOwn;
		NIPu9LXsC = new HandleRef(this, cPtr);
	}

	internal static HandleRef CdUsKhi4K(CameraCallback P_0)
	{
		return P_0?.NIPu9LXsC ?? new HandleRef(null, IntPtr.Zero);
	}

	~CameraCallback()
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
			if (NIPu9LXsC.Handle != IntPtr.Zero)
			{
				if (swigCMemOwn)
				{
					swigCMemOwn = false;
					mcgGLo2CjNleAwBOso.WoMsx9hc1b(NIPu9LXsC);
				}
				NIPu9LXsC = new HandleRef(null, IntPtr.Zero);
			}
		}
	}

	public virtual void OnCameraStateChanged(ShotStatusEnum state)
	{
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(66), E979NPuIO))
		{
			mcgGLo2CjNleAwBOso.yAIsoUk6rV(NIPu9LXsC, (int)state);
		}
		else
		{
			mcgGLo2CjNleAwBOso.kpbsEZGbUx(NIPu9LXsC, (int)state);
		}
	}

	public virtual void OnCameraStateChanged(ShotStatusEnum state, ShotStatusData data)
	{
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(66), x3TAyD6h1))
		{
			mcgGLo2CjNleAwBOso.cxise1ZYIS(NIPu9LXsC, (int)state, ShotStatusData.p8FgeEG2TK(data));
		}
		else
		{
			mcgGLo2CjNleAwBOso.SOesXALb75(NIPu9LXsC, (int)state, ShotStatusData.p8FgeEG2TK(data));
		}
		if (mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.gYOChRE5q7())
		{
			throw mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.elbCBSCuIc();
		}
	}

	public virtual void OnNewShot(GICTSShotData shot)
	{
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(110), zqhj3o94f))
		{
			mcgGLo2CjNleAwBOso.EjisRNDfXk(NIPu9LXsC, GICTSShotData.p32FdXM1G(shot));
		}
		else
		{
			mcgGLo2CjNleAwBOso.JPws0p6qJj(NIPu9LXsC, GICTSShotData.p32FdXM1G(shot));
		}
		if (mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.gYOChRE5q7())
		{
			throw mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.elbCBSCuIc();
		}
	}

	public virtual double OnComputeClubFace(GICTSShotData shot)
	{
		double result = (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(132), F206YmIid) ? mcgGLo2CjNleAwBOso.OjZgwbj5tg(NIPu9LXsC, GICTSShotData.p32FdXM1G(shot)) : mcgGLo2CjNleAwBOso.woFszyjkiB(NIPu9LXsC, GICTSShotData.p32FdXM1G(shot)));
		if (mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.gYOChRE5q7())
		{
			throw mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.elbCBSCuIc();
		}
		return result;
	}

	public virtual string OnGetSpinConfig(int club_nature, double ball_speed, double launch_angle, float ball_club_hit_percent)
	{
		if (!zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(170), KXy13lOBi))
		{
			return mcgGLo2CjNleAwBOso.lakgsSiOCO(NIPu9LXsC, club_nature, ball_speed, launch_angle, ball_club_hit_percent);
		}
		return mcgGLo2CjNleAwBOso.pUuggYHlbQ(NIPu9LXsC, club_nature, ball_speed, launch_angle, ball_club_hit_percent);
	}

	public virtual bool OnIsPutter(GICTSShotData shot)
	{
		bool result = (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(204), aIFk2MrcR) ? mcgGLo2CjNleAwBOso.OBhgndSX9f(NIPu9LXsC, GICTSShotData.p32FdXM1G(shot)) : mcgGLo2CjNleAwBOso.MaggLtPwZM(NIPu9LXsC, GICTSShotData.p32FdXM1G(shot)));
		if (mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.gYOChRE5q7())
		{
			throw mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.elbCBSCuIc();
		}
		return result;
	}

	public virtual void OnHasExited(int code)
	{
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(228), U8odtU0oo))
		{
			mcgGLo2CjNleAwBOso.jLQgVSxkm2(NIPu9LXsC, code);
		}
		else
		{
			mcgGLo2CjNleAwBOso.LsggSuswqf(NIPu9LXsC, code);
		}
	}

	public virtual void OnCameraErrorCode(int code, string camera_serial_number, bool isSuperSpeed)
	{
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(254), YunN9vEHg))
		{
			mcgGLo2CjNleAwBOso.MBqgHe89p1(NIPu9LXsC, code, camera_serial_number, isSuperSpeed);
		}
		else
		{
			mcgGLo2CjNleAwBOso.TJAgvf5UOA(NIPu9LXsC, code, camera_serial_number, isSuperSpeed);
		}
		if (mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.gYOChRE5q7())
		{
			throw mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.elbCBSCuIc();
		}
	}

	public virtual void OnVideoAvailable()
	{
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(292), zil5JZMTJ))
		{
			mcgGLo2CjNleAwBOso.DtygTrYEbE(NIPu9LXsC);
		}
		else
		{
			mcgGLo2CjNleAwBOso.JyygDskgEe(NIPu9LXsC);
		}
	}

	public virtual void OnPostShotVideoAvailable(string shotName, int impactFrame)
	{
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(328), g8Qcnjbvw))
		{
			mcgGLo2CjNleAwBOso.VEDgMxHXp5(NIPu9LXsC, shotName, impactFrame);
		}
		else
		{
			mcgGLo2CjNleAwBOso.SpegCu8QE7(NIPu9LXsC, shotName, impactFrame);
		}
		if (mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.gYOChRE5q7())
		{
			throw mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.elbCBSCuIc();
		}
	}

	public virtual void OnLog(string text, CircularLogLevel logLevel)
	{
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(380), Dv0WcvTc9))
		{
			mcgGLo2CjNleAwBOso.jXjgpo5ten(NIPu9LXsC, text, (int)logLevel);
		}
		else
		{
			mcgGLo2CjNleAwBOso.UysgK7cXqM(NIPu9LXsC, text, (int)logLevel);
		}
		if (mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.gYOChRE5q7())
		{
			throw mcgGLo2CjNleAwBOso.ambOGvEhHO9eaxGHUb.elbCBSCuIc();
		}
	}

	public virtual void OnSetLogLevel(CircularLogLevel logLevel)
	{
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(394), j7NJyh76l))
		{
			mcgGLo2CjNleAwBOso.OCBg8NfrDh(NIPu9LXsC, (int)logLevel);
		}
		else
		{
			mcgGLo2CjNleAwBOso.VRpg7c6DuG(NIPu9LXsC, (int)logLevel);
		}
	}

	public virtual void OnRefreshIDRAConfig()
	{
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(424), xQl4KMoxq))
		{
			mcgGLo2CjNleAwBOso.Y48gYsaV5u(NIPu9LXsC);
		}
		else
		{
			mcgGLo2CjNleAwBOso.TZZguSiD5B(NIPu9LXsC);
		}
	}

	public CameraCallback()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		this._002Ector(mcgGLo2CjNleAwBOso.DG5gbC6bWS(), cMemoryOwn: true);
		p0Rgg24wV();
	}

	private void p0Rgg24wV()
	{
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(66), E979NPuIO))
		{
			DS7YiK6Ri = qxlnJ90aS;
		}
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(66), x3TAyD6h1))
		{
			IM5baMZLx = aK8SVs5TE;
		}
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(110), zqhj3o94f))
		{
			iGVfBESyo = Lh7VdC9EU;
		}
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(132), F206YmIid))
		{
			YkfIKeN65 = omXvyjlUN;
		}
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(170), KXy13lOBi))
		{
			UDCOMX6iq = DR4H8HgZJ;
		}
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(204), aIFk2MrcR))
		{
			NJbaHCsAo = ejqDH3Fqm;
		}
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(228), U8odtU0oo))
		{
			kk3ZsCFKa = zQhT0cMjP;
		}
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(254), YunN9vEHg))
		{
			ojdUdZsKG = R69CxDLvG;
		}
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(292), zil5JZMTJ))
		{
			Mq6B5dfwd = XZAMljZ4v;
		}
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(328), g8Qcnjbvw))
		{
			GNMhFWTkp = W5cK72ZmF;
		}
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(380), Dv0WcvTc9))
		{
			ASBtQYiWj = wJGpeBU6E;
		}
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(394), j7NJyh76l))
		{
			puUrY9GHl = woj7aXpKY;
		}
		if (zbLLR6vA3(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(424), xQl4KMoxq))
		{
			iuPy07dLY = gKr8jc7Xg;
		}
		mcgGLo2CjNleAwBOso.XnNgfvy4pg(NIPu9LXsC, DS7YiK6Ri, IM5baMZLx, iGVfBESyo, YkfIKeN65, UDCOMX6iq, NJbaHCsAo, kk3ZsCFKa, ojdUdZsKG, Mq6B5dfwd, GNMhFWTkp, ASBtQYiWj, puUrY9GHl, iuPy07dLY);
	}

	private bool zbLLR6vA3(string P_0, Type[] P_1)
	{
		return GetType().GetMethod(P_0, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, P_1, null).DeclaringType.IsSubclassOf(typeof(CameraCallback));
	}

	private void qxlnJ90aS(int P_0)
	{
		OnCameraStateChanged((ShotStatusEnum)P_0);
	}

	private void aK8SVs5TE(int P_0, nint P_1)
	{
		OnCameraStateChanged((ShotStatusEnum)P_0, new ShotStatusData(P_1, cMemoryOwn: true));
	}

	private void Lh7VdC9EU(nint P_0)
	{
		OnNewShot(new GICTSShotData(P_0, cMemoryOwn: true));
	}

	private double omXvyjlUN(nint P_0)
	{
		return OnComputeClubFace(new GICTSShotData(P_0, cMemoryOwn: true));
	}

	private string DR4H8HgZJ(int P_0, double P_1, double P_2, float P_3)
	{
		return OnGetSpinConfig(P_0, P_1, P_2, P_3);
	}

	private bool ejqDH3Fqm(nint P_0)
	{
		return OnIsPutter(new GICTSShotData(P_0, cMemoryOwn: true));
	}

	private void zQhT0cMjP(int P_0)
	{
		OnHasExited(P_0);
	}

	private void R69CxDLvG(int P_0, string P_1, bool P_2)
	{
		OnCameraErrorCode(P_0, P_1, P_2);
	}

	private void XZAMljZ4v()
	{
		OnVideoAvailable();
	}

	private void W5cK72ZmF(string P_0, int P_1)
	{
		OnPostShotVideoAvailable(P_0, P_1);
	}

	private void wJGpeBU6E(string P_0, int P_1)
	{
		OnLog(P_0, (CircularLogLevel)P_1);
	}

	private void woj7aXpKY(int P_0)
	{
		OnSetLogLevel((CircularLogLevel)P_0);
	}

	private void gKr8jc7Xg()
	{
		OnRefreshIDRAConfig();
	}

	static CameraCallback()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		E979NPuIO = new Type[1] { typeof(ShotStatusEnum) };
		x3TAyD6h1 = new Type[2]
		{
			typeof(ShotStatusEnum),
			typeof(ShotStatusData)
		};
		zqhj3o94f = new Type[1] { typeof(GICTSShotData) };
		F206YmIid = new Type[1] { typeof(GICTSShotData) };
		KXy13lOBi = new Type[4]
		{
			typeof(int),
			typeof(double),
			typeof(double),
			typeof(float)
		};
		aIFk2MrcR = new Type[1] { typeof(GICTSShotData) };
		U8odtU0oo = new Type[1] { typeof(int) };
		YunN9vEHg = new Type[3]
		{
			typeof(int),
			typeof(string),
			typeof(bool)
		};
		zil5JZMTJ = new Type[0];
		g8Qcnjbvw = new Type[2]
		{
			typeof(string),
			typeof(int)
		};
		Dv0WcvTc9 = new Type[2]
		{
			typeof(string),
			typeof(CircularLogLevel)
		};
		j7NJyh76l = new Type[1] { typeof(CircularLogLevel) };
		xQl4KMoxq = new Type[0];
	}
}
