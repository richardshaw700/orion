using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading;
using Dj53wpDm4kAP8dsJHT;
using GICTS.Data;
using JdN3qlxpK1fXeWoSKd;
using LuZvDVYU1IGYu9N133;
using W21NMea2lkvYjfH5WM;
using lKEAGvFqWp7B16kDoY;
using lj1ccm0Up9Vk0KnTtj;

namespace w51ddNTrxy51GwXxPV;

internal class UNfueTvIXSsMOJnqF9
{
	public class q0MRGg621cZAGllpbI
	{
		public Socket TfxKScob6p;

		public byte[] q5qKVVjFWm;

		public b2Z1dn4xuco55PqC2r BM6KvPVu0W;

		public yNLqcpRhj3mMNiYIMt JeEKHjZcdE;

		public Fadf5cLJMjaj9UYVoG Gc1KDdkZPZ;

		public IAsyncResult lMkKTL6gpF;

		public int nOsKCS3HDe;

		public bool iqNKM13NeD;

		public bool KXFKKPE6mQ;

		public bool onwKp4erbx;

		public UNfueTvIXSsMOJnqF9 E3uK7Lemtj;

		public q0MRGg621cZAGllpbI()
		{
			fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
			q5qKVVjFWm = new byte[32768];
			base._002Ector();
		}
	}

	public delegate void MOlN8VchoDIl8EdJpa(string message);

	public delegate void b2Z1dn4xuco55PqC2r(string message);

	public delegate void Fadf5cLJMjaj9UYVoG(bool success);

	public delegate void yNLqcpRhj3mMNiYIMt(string message);

	public delegate void xrI2YXn1QJUVnShCCM(bool success);

	private static readonly object o40DzgeHC5;

	private Socket? CFDTwrCrOn;

	private IPEndPoint sibTsnGCoG;

	private q0MRGg621cZAGllpbI GKETg9NuDx;

	private MOlN8VchoDIl8EdJpa JLsTLxvDyw;

	private b2Z1dn4xuco55PqC2r VZbTntWj7I;

	private Fadf5cLJMjaj9UYVoG q1tTSCfjKd;

	private yNLqcpRhj3mMNiYIMt ik9TVoaSCk;

	private xrI2YXn1QJUVnShCCM KwATv8ONCk;

	private readonly TruSimData wcQTHmUUd5;

	private int NunTDqUM6d;

	private string vvgTTT9lVd;

	private RijndaelManaged gopTC7bBKq;

	private Guid GpBTM9VvrS;

	private string yFuTKTZqUf;

	private readonly bool Ig5TpLCaeO;

	private wy5C4NJpMAOGeuBGBL pUwT70nNUO;

	private readonly bool ArnT8NVrCV;

	private bool x5ETu2DBPf;

	private bool QfwTYhdLjf;

	[SpecialName]
	public int ETtDoaibsV()
	{
		return NunTDqUM6d;
	}

	[SpecialName]
	public void QaiDXBY7AB(int P_0)
	{
		NunTDqUM6d = P_0;
	}

	public void EMyDOT0ADm(MOlN8VchoDIl8EdJpa P_0)
	{
		JLsTLxvDyw = P_0;
	}

	public void B2ZDaLX340(b2Z1dn4xuco55PqC2r P_0)
	{
		VZbTntWj7I = P_0;
	}

	public void RqsDZO4rLu(Fadf5cLJMjaj9UYVoG P_0)
	{
		q1tTSCfjKd = P_0;
	}

	public void s6kDUmZhT1(yNLqcpRhj3mMNiYIMt P_0)
	{
		ik9TVoaSCk = P_0;
	}

	public void zH1DBxil5f(xrI2YXn1QJUVnShCCM P_0)
	{
		KwATv8ONCk = P_0;
	}

	public UNfueTvIXSsMOJnqF9(TruSimData P_0, bool P_1 = true)
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		GKETg9NuDx = new q0MRGg621cZAGllpbI();
		NunTDqUM6d = 15000;
		yFuTKTZqUf = "";
		pUwT70nNUO = (wy5C4NJpMAOGeuBGBL)2;
		ArnT8NVrCV = true;
		base._002Ector();
		ArnT8NVrCV = P_1;
		n3mDhaoeLD();
		wcQTHmUUd5 = P_0;
	}

	public UNfueTvIXSsMOJnqF9(string P_0)
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		GKETg9NuDx = new q0MRGg621cZAGllpbI();
		NunTDqUM6d = 15000;
		yFuTKTZqUf = "";
		pUwT70nNUO = (wy5C4NJpMAOGeuBGBL)2;
		ArnT8NVrCV = true;
		base._002Ector();
		yFuTKTZqUf = P_0;
	}

	private void n3mDhaoeLD()
	{
		FeJDrSqB1L();
		woSDt1lno1();
		CFDTwrCrOn = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
		{
			Blocking = false
		};
		GKETg9NuDx.E3uK7Lemtj = this;
	}

	private void woSDt1lno1()
	{
		gopTC7bBKq = new RijndaelManaged
		{
			BlockSize = 128
		};
		byte[] array = new byte[16];
		byte[] array2 = new byte[32];
		char[] src = vvgTTT9lVd.ToCharArray();
		Buffer.BlockCopy(src, 0, array2, 0, array2.Length);
		Buffer.BlockCopy(src, 32, array, 0, array.Length);
		gopTC7bBKq.IV = array;
		gopTC7bBKq.Key = array2;
		gopTC7bBKq.Mode = CipherMode.CBC;
		gopTC7bBKq.Padding = PaddingMode.Zeros;
	}

	private void FeJDrSqB1L()
	{
		if (ArnT8NVrCV)
		{
			GpBTM9VvrS = new Guid(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13730));
			vvgTTT9lVd = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13806);
		}
		else
		{
			GpBTM9VvrS = new Guid(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13906));
			vvgTTT9lVd = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13982);
		}
	}

	[SpecialName]
	public bool hO5D0pfh98()
	{
		if (CFDTwrCrOn != null && CFDTwrCrOn.Connected)
		{
			return GKETg9NuDx.onwKp4erbx;
		}
		return false;
	}

	public void m3eDy3OeHO()
	{
		LjrD4LKY6Q();
		if (CFDTwrCrOn != null)
		{
			if (CFDTwrCrOn.Connected)
			{
				CFDTwrCrOn.Disconnect(reuseSocket: false);
			}
			CFDTwrCrOn = null;
		}
	}

	private void r1rD9hIX7o(object P_0, EventArgs P_1)
	{
		if (!GKETg9NuDx.KXFKKPE6mQ && !hO5D0pfh98())
		{
			m3eDy3OeHO();
		}
	}

	public void ykgDAH314t(IPEndPoint P_0)
	{
		if (GKETg9NuDx.KXFKKPE6mQ)
		{
			return;
		}
		sibTsnGCoG = P_0;
		GKETg9NuDx.KXFKKPE6mQ = true;
		Console.WriteLine(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14082));
		if (CFDTwrCrOn == null)
		{
			n3mDhaoeLD();
		}
		else if (CFDTwrCrOn.Connected)
		{
			CFDTwrCrOn.Disconnect(reuseSocket: false);
			CFDTwrCrOn.Shutdown(SocketShutdown.Both);
			CFDTwrCrOn.Close();
			n3mDhaoeLD();
		}
		try
		{
			GKETg9NuDx.TfxKScob6p = CFDTwrCrOn;
			GKETg9NuDx.iqNKM13NeD = false;
			GKETg9NuDx.onwKp4erbx = false;
			GKETg9NuDx.JeEKHjZcdE = ik9TVoaSCk;
			GKETg9NuDx.BM6KvPVu0W = VZbTntWj7I;
			GKETg9NuDx.Gc1KDdkZPZ = q1tTSCfjKd;
			CFDTwrCrOn.BeginConnect(sibTsnGCoG, FVsDjWu469, GKETg9NuDx);
		}
		catch (SocketException ex)
		{
			Console.WriteLine(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14128) + ex.Message);
			m3eDy3OeHO();
			GKETg9NuDx.KXFKKPE6mQ = false;
		}
		catch (Exception ex2)
		{
			Console.WriteLine(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14128) + ex2.Message);
			m3eDy3OeHO();
			GKETg9NuDx.KXFKKPE6mQ = false;
		}
	}

	private static void FVsDjWu469(IAsyncResult P_0)
	{
		q0MRGg621cZAGllpbI q0MRGg621cZAGllpbI = (q0MRGg621cZAGllpbI)P_0.AsyncState;
		bool success = false;
		if (q0MRGg621cZAGllpbI == null)
		{
			return;
		}
		if (q0MRGg621cZAGllpbI.TfxKScob6p != null)
		{
			try
			{
				success = true;
				q0MRGg621cZAGllpbI.TfxKScob6p.EndConnect(P_0);
				q0MRGg621cZAGllpbI.lMkKTL6gpF = q0MRGg621cZAGllpbI.TfxKScob6p.BeginReceive(q0MRGg621cZAGllpbI.q5qKVVjFWm, 0, 32768, SocketFlags.None, cTwD6g9Th8, q0MRGg621cZAGllpbI);
				Thread.Sleep(500);
				xiuDclkbWs(q0MRGg621cZAGllpbI);
			}
			catch (Exception ex)
			{
				Console.WriteLine(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14170) + ex.Message);
				success = false;
			}
		}
		q0MRGg621cZAGllpbI.Gc1KDdkZPZ?.Invoke(success);
		q0MRGg621cZAGllpbI.KXFKKPE6mQ = false;
	}

	private static void cTwD6g9Th8(IAsyncResult P_0)
	{
		checked
		{
			lock (o40DzgeHC5)
			{
				q0MRGg621cZAGllpbI q0MRGg621cZAGllpbI = (q0MRGg621cZAGllpbI)P_0.AsyncState;
				if (q0MRGg621cZAGllpbI == null || q0MRGg621cZAGllpbI.TfxKScob6p == null)
				{
					return;
				}
				if (!q0MRGg621cZAGllpbI.TfxKScob6p.Connected)
				{
					Console.WriteLine(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14228));
					return;
				}
				bool flag = false;
				try
				{
					int num = q0MRGg621cZAGllpbI.TfxKScob6p.EndReceive(P_0);
					if (num > 0)
					{
						q0MRGg621cZAGllpbI.nOsKCS3HDe += num;
						int num2 = 0;
						int num3 = 0;
						for (num3 = 0; num3 < q0MRGg621cZAGllpbI.nOsKCS3HDe; num3++)
						{
							if (q0MRGg621cZAGllpbI.q5qKVVjFWm[num3] == 0)
							{
								string text = Encoding.ASCII.GetString(q0MRGg621cZAGllpbI.q5qKVVjFWm, num2, num3 - num2);
								q0MRGg621cZAGllpbI.BM6KvPVu0W?.Invoke(text);
								if (!q0MRGg621cZAGllpbI.onwKp4erbx)
								{
									q0MRGg621cZAGllpbI.E3uK7Lemtj.Ie0DGvDcjG(text);
								}
								else
								{
									q0MRGg621cZAGllpbI.E3uK7Lemtj.laCDqAusGI(text);
								}
								num2 = num3 + 1;
							}
						}
						if (q0MRGg621cZAGllpbI.nOsKCS3HDe == num3 && num2 != 0)
						{
							int num4 = q0MRGg621cZAGllpbI.nOsKCS3HDe - num2;
							for (int i = 0; i < num4; i++)
							{
								q0MRGg621cZAGllpbI.q5qKVVjFWm[i] = q0MRGg621cZAGllpbI.q5qKVVjFWm[i + num2];
							}
							q0MRGg621cZAGllpbI.nOsKCS3HDe = num4;
						}
						if (q0MRGg621cZAGllpbI.nOsKCS3HDe + 32768 > q0MRGg621cZAGllpbI.q5qKVVjFWm.Length)
						{
							byte[] array = new byte[q0MRGg621cZAGllpbI.q5qKVVjFWm.Length * 2];
							q0MRGg621cZAGllpbI.q5qKVVjFWm.CopyTo(array, 0);
							q0MRGg621cZAGllpbI.q5qKVVjFWm = array;
						}
					}
					else if (num == 0)
					{
						q0MRGg621cZAGllpbI.JeEKHjZcdE?.Invoke(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14298));
						flag = true;
					}
				}
				catch (ArgumentException ex)
				{
					Console.WriteLine(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14354) + ex.Message);
					q0MRGg621cZAGllpbI.JeEKHjZcdE?.Invoke(ex.Message);
					flag = true;
				}
				catch (SocketException ex2)
				{
					Console.WriteLine(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14354) + ex2.Message);
					q0MRGg621cZAGllpbI.JeEKHjZcdE?.Invoke(ex2.Message);
					flag = true;
				}
				if (flag)
				{
					q0MRGg621cZAGllpbI.E3uK7Lemtj.m3eDy3OeHO();
					q0MRGg621cZAGllpbI.nOsKCS3HDe = 0;
					q0MRGg621cZAGllpbI.q5qKVVjFWm.Initialize();
					return;
				}
				try
				{
					q0MRGg621cZAGllpbI.lMkKTL6gpF = q0MRGg621cZAGllpbI.TfxKScob6p.BeginReceive(q0MRGg621cZAGllpbI.q5qKVVjFWm, q0MRGg621cZAGllpbI.nOsKCS3HDe, 32768, SocketFlags.None, cTwD6g9Th8, q0MRGg621cZAGllpbI);
				}
				catch (Exception ex3)
				{
					Console.WriteLine(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14354) + ex3.Message);
				}
			}
		}
	}

	public int jNmD1AkuP6(string P_0)
	{
		int result = 0;
		Thread.Sleep(10);
		if (CFDTwrCrOn != null && CFDTwrCrOn.Connected)
		{
			try
			{
				B5SwJpMR70AGGOQRMt b5SwJpMR70AGGOQRMt = new B5SwJpMR70AGGOQRMt(checked(P_0.Length + 1));
				b5SwJpMR70AGGOQRMt.Write(P_0);
				result = CFDTwrCrOn.Send(b5SwJpMR70AGGOQRMt.f8BDIGyqsD());
				JLsTLxvDyw?.Invoke(P_0);
			}
			catch (SocketException ex)
			{
				RZuwqeOU57xyubHr8i rZuwqeOU57xyubHr8i = new RZuwqeOU57xyubHr8i();
				rZuwqeOU57xyubHr8i.d51DT2tPes(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14406) + ex.Message);
				sg4LwRQ21l7yHf0fgM.Jb8DuJVfmR(rZuwqeOU57xyubHr8i);
				Console.WriteLine(sg4LwRQ21l7yHf0fgM.SE0Dbpem6N());
			}
		}
		else
		{
			RZuwqeOU57xyubHr8i rZuwqeOU57xyubHr8i2 = new RZuwqeOU57xyubHr8i();
			rZuwqeOU57xyubHr8i2.d51DT2tPes(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14482));
			sg4LwRQ21l7yHf0fgM.Jb8DuJVfmR(rZuwqeOU57xyubHr8i2);
			Console.WriteLine(sg4LwRQ21l7yHf0fgM.SE0Dbpem6N());
		}
		return result;
	}

	public bool tlXDk7vvuM(TruSimData P_0)
	{
		int num = 0;
		checked
		{
			if (P_0 != null)
			{
				string ballDataJSON = P_0.GetBallDataJSON();
				string text = JljDlHJb23(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14552), ballDataJSON);
				num += jNmD1AkuP6(text);
				ballDataJSON = P_0.GetClubDataJSON();
				text = JljDlHJb23(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14572), ballDataJSON);
				num += jNmD1AkuP6(text);
				num += jNmD1AkuP6(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14592));
			}
			return num != 0;
		}
	}

	public bool SendShot(TruSimData simData)
	{
		int num = 0;
		checked
		{
			if (simData != null)
			{
				string ballDataJSON = simData.GetBallDataJSON();
				string text = JljDlHJb23(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14552), ballDataJSON);
				num += jNmD1AkuP6(text);
				ballDataJSON = simData.GetClubDataJSON();
				text = JljDlHJb23(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14572), ballDataJSON);
				num += jNmD1AkuP6(text);
				num += jNmD1AkuP6(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14646));
			}
			return num != 0;
		}
	}

	public void vhlDdbJqcd()
	{
		string trackingDataJSON = wcQTHmUUd5.GetTrackingDataJSON();
		string text = JljDlHJb23(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14688), trackingDataJSON);
		Console.Write(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14728));
		Console.WriteLine(text);
		jNmD1AkuP6(text);
	}

	public void dYWDNcx6LM()
	{
		string configDataJSON = wcQTHmUUd5.GetConfigDataJSON();
		string text = JljDlHJb23(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14772), configDataJSON);
		Console.Write(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14796));
		Console.WriteLine(text);
		jNmD1AkuP6(text);
	}

	public void OsuD5qJG8w(string P_0)
	{
		P_0 = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14836) + P_0 + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14836);
		string text = JljDlHJb23(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14842), P_0);
		Console.Write(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14868));
		Console.WriteLine(text);
		jNmD1AkuP6(text);
	}

	private static void xiuDclkbWs(q0MRGg621cZAGllpbI P_0)
	{
		P_0.E3uK7Lemtj.jNmD1AkuP6(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14914));
	}

	public void LqmDWqSgcv()
	{
		jNmD1AkuP6(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14958));
	}

	public void GBEDJrfaWQ()
	{
		jNmD1AkuP6(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14992));
	}

	private void LjrD4LKY6Q()
	{
		jNmD1AkuP6(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15026));
	}

	public string JpFD3sUrA2(string P_0, string P_1)
	{
		return string.Concat(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15072) + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14836) + P_0 + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15092), P_1, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15100));
	}

	public string JljDlHJb23(string P_0, string P_1)
	{
		return string.Concat(string.Concat(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15106) + P_0 + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15134), YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14836), P_0, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15092)), P_1, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15100));
	}

	public string cXsDiIGQsh(string P_0)
	{
		MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(P_0);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i = checked(i + 1))
		{
			stringBuilder.Append(array[i].ToString(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15142)));
		}
		return stringBuilder.ToString();
	}

	public static string C3kDQ8kpIc(string P_0)
	{
		SHA256 sHA = SHA256.Create();
		byte[] bytes = Encoding.UTF8.GetBytes(P_0);
		return PbIDPrhFxf(sHA.ComputeHash(bytes));
	}

	private static string PbIDPrhFxf(byte[] P_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < P_0.Length; i = checked(i + 1))
		{
			stringBuilder.Append(P_0[i].ToString(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15150)));
		}
		return stringBuilder.ToString();
	}

	public void Ie0DGvDcjG(string P_0)
	{
		JsonElement rootElement = JsonDocument.Parse(P_0).RootElement;
		string text = rootElement.GetProperty(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15158)).GetString();
		if (!(text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15170)))
		{
			if (!(text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15192)))
			{
				if (text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1306) && rootElement.GetProperty(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15224)).GetString() == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15170))
				{
					m3eDy3OeHO();
					Thread.Sleep(500);
					GKETg9NuDx = new q0MRGg621cZAGllpbI();
					ykgDAH314t(sibTsnGCoG);
				}
			}
			else
			{
				K6dDFPye15(rootElement);
			}
		}
		else
		{
			BirDmDOuDF(rootElement);
		}
	}

	public void laCDqAusGI(string P_0)
	{
		try
		{
			JsonElement rootElement = JsonDocument.Parse(P_0).RootElement;
			string text = rootElement.GetProperty(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15224)).GetString();
			if (text == null)
			{
				return;
			}
			switch (text.Length)
			{
			case 12:
				switch (text[0])
				{
				case 'D':
					if (text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15278))
					{
						DYTDEiNEKM(rootElement);
					}
					break;
				case 'S':
					if (text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15306))
					{
					}
					break;
				}
				break;
			case 11:
				switch (text[3])
				{
				case 'B':
					if (text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15450))
					{
					}
					break;
				case 'C':
					if (!(text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15476)) && text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14842))
					{
					}
					break;
				}
				break;
			case 4:
				if (text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15242))
				{
					GBEDJrfaWQ();
				}
				break;
			case 14:
				if (text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15192))
				{
					K6dDFPye15(rootElement);
				}
				break;
			case 10:
				if (text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15254))
				{
					BaGDxkXihu(rootElement);
				}
				break;
			case 6:
				if (text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15334))
				{
				}
				break;
			case 3:
				if (text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15350))
				{
				}
				break;
			case 23:
				if (text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15360))
				{
				}
				break;
			case 18:
				if (text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15410))
				{
				}
				break;
			case 13:
				if (text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15502))
				{
				}
				break;
			case 8:
				if (text == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13650))
				{
				}
				break;
			case 5:
			case 7:
			case 9:
			case 15:
			case 16:
			case 17:
			case 19:
			case 20:
			case 21:
			case 22:
				break;
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15532) + P_0 + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15610) + ex.Message);
			throw ex;
		}
	}

	public void BirDmDOuDF(JsonElement P_0)
	{
		yFuTKTZqUf = P_0.GetProperty(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15658)).GetString();
		string arg = C3kDQ8kpIc(yFuTKTZqUf + vvgTTT9lVd);
		string text = string.Format(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15680), GpBTM9VvrS.ToString(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15790)), arg);
		jNmD1AkuP6(text);
	}

	public wy5C4NJpMAOGeuBGBL PifD2fmEyl()
	{
		int num = (int)pUwT70nNUO;
		pUwT70nNUO = (wy5C4NJpMAOGeuBGBL)((num = checked(num + 1)) % 3);
		return pUwT70nNUO;
	}

	private void K6dDFPye15(JsonElement P_0)
	{
		GKETg9NuDx.onwKp4erbx = bool.Parse(P_0.GetProperty(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2404)).GetString());
		if (!GKETg9NuDx.onwKp4erbx)
		{
			m3eDy3OeHO();
			q1tTSCfjKd(success: false);
		}
		KwATv8ONCk?.Invoke(GKETg9NuDx.onwKp4erbx);
	}

	private void BaGDxkXihu(JsonElement P_0)
	{
		if (P_0.GetProperty(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15796)).GetString() == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15350) && Ig5TpLCaeO)
		{
			if (x5ETu2DBPf)
			{
				_ = QfwTYhdLjf;
			}
			QfwTYhdLjf = (x5ETu2DBPf = false);
		}
	}

	private void DYTDEiNEKM(JsonElement P_0)
	{
		if (P_0.GetProperty(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15814)).ValueKind != JsonValueKind.Undefined)
		{
			x5ETu2DBPf = true;
		}
		else if (P_0.GetProperty(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15848)).ValueKind != JsonValueKind.Undefined)
		{
			QfwTYhdLjf = true;
		}
	}

	static UNfueTvIXSsMOJnqF9()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		o40DzgeHC5 = new object();
	}
}
