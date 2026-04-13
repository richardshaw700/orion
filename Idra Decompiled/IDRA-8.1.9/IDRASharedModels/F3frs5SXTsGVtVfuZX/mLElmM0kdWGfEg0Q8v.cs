using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using GYFmeytn3uk9KnUELA;
using RIrlNToRdPZ6Uy0SYo;

namespace F3frs5SXTsGVtVfuZX;

internal class mLElmM0kdWGfEg0Q8v
{
	private delegate void NMoii9def53ZKQ2D0v(object o);

	internal class M0Se8Ayw9NYfdH7gOm : Attribute
	{
		internal class Sguirw31AwiKeBmSAY<q11wDCg9EhSj3myGXO>
		{
			public Sguirw31AwiKeBmSAY()
			{
				l26t3npZsnUe1qbsCU.vf2WGHkzGx201();
				base._002Ector();
			}

			static Sguirw31AwiKeBmSAY()
			{
				G2089JiDB7k4x1yr7J.kLjw4iIsCLsZtxc4lksN0j();
			}
		}

		[M0Se8Ayw9NYfdH7gOm(typeof(Sguirw31AwiKeBmSAY<object>[]))]
		public M0Se8Ayw9NYfdH7gOm(object P_0)
		{
		}

		static M0Se8Ayw9NYfdH7gOm()
		{
			G2089JiDB7k4x1yr7J.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	internal class XbTHnQD74wsDxDqRbL
	{
		[M0Se8Ayw9NYfdH7gOm(typeof(M0Se8Ayw9NYfdH7gOm.Sguirw31AwiKeBmSAY<object>[]))]
		internal static string TLe8xwEs5Q(string P_0, string P_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(P_0);
			byte[] array = bytes;
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = cCUB4bVwKr(Encoding.Unicode.GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = cdLBDDJbDP();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		static XbTHnQD74wsDxDqRbL()
		{
			G2089JiDB7k4x1yr7J.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint cQAMtgPahUEePHT6K6(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr tdvYEM4MvG6DhOELy9();

	internal struct xaNJ3SemVYYxhIyRRT
	{
		internal bool J9b8FlxWS5;

		internal byte[] cWB8in18wh;
	}

	internal class ah0POMuVPMgXQZ6p2t
	{
		private BinaryReader WJo8hKQCVH;

		public ah0POMuVPMgXQZ6p2t(Stream P_0)
		{
			WJo8hKQCVH = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return WJo8hKQCVH.BaseStream;
		}

		internal byte[] yxt8tS5NNP(int P_0)
		{
			return WJo8hKQCVH.ReadBytes(P_0);
		}

		internal int vvd8XULv33(byte[] P_0, int P_1, int P_2)
		{
			return WJo8hKQCVH.Read(P_0, P_1, P_2);
		}

		internal int sRd81oC08d()
		{
			return WJo8hKQCVH.ReadInt32();
		}

		internal void hPv8wiKMtK()
		{
			WJo8hKQCVH.Close();
		}

		static ah0POMuVPMgXQZ6p2t()
		{
			G2089JiDB7k4x1yr7J.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr ULHcHqUxU8b63TwLxO(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr qQvY5rYOIfCvWyTNg4(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int wgFcGpjpaF8uPKThXj(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int wojL9iCvat9uiCKoq7(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr zFSQ3IZmyQp85LOItd(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int EuoowW2ghTnnFnM0AM(IntPtr ptr);

	[Flags]
	private enum DNFwsHcGU46UHfxRmX
	{

	}

	internal static Assembly JkKBr6NVUo;

	private static uint[] j5bBnoprtn;

	private static byte[] AdyBMiepug;

	private static Dictionary<int, int> nrLBTFcfM2;

	private static byte[] eTYBzWBHw2;

	private static object YSN8BCmgOq;

	private static bool Fx48vjb1OR;

	internal static cQAMtgPahUEePHT6K6 wfZ8yP6kfs;

	internal static cQAMtgPahUEePHT6K6 Wie830kKRU;

	private static long qgy8geV2dl;

	private static bool hFu84wQFi7;

	private static int P2T8erBrxc;

	private static IntPtr Yvl8ulbhlQ;

	private static ULHcHqUxU8b63TwLxO HUF8j2GUdE;

	private static zFSQ3IZmyQp85LOItd E2F8cmK9Ex;

	private static EuoowW2ghTnnFnM0AM m5n8pULltW;

	private static IntPtr iFd8ovhJfB;

	private static IntPtr skD8RDnHYA;

	private static bool sywBlAqLpd;

	private static qQvY5rYOIfCvWyTNg4 yrK8CYKqOl;

	private static int HJD8DZsVN4;

	private static object VNJBAQf9Vn;

	private static bool EMgB7XUntr;

	private static int tAX8SEHRC0;

	[M0Se8Ayw9NYfdH7gOm(typeof(M0Se8Ayw9NYfdH7gOm.Sguirw31AwiKeBmSAY<object>[]))]
	private static bool d338UE5bhQ;

	private static wojL9iCvat9uiCKoq7 woU828LW5X;

	private static long iZh8dOFN48;

	private static byte[] XP3BaXgCjR;

	internal static RSACryptoServiceProvider Cf4BN2cXyM;

	internal static Hashtable UwO8Yrb4O2;

	private static bool bb18P6rHxi;

	private static wgFcGpjpaF8uPKThXj xMV8Zr70pJ;

	private static int upL8samCqc;

	private static SortedList Tv9803ZlwB;

	private static int[] CK088qLEKs;

	private static IntPtr VDU8V6feDR;

	private static bool jroBW6pRKg;

	static mLElmM0kdWGfEg0Q8v()
	{
		G2089JiDB7k4x1yr7J.kLjw4iIsCLsZtxc4lksN0j();
		EMgB7XUntr = false;
		JkKBr6NVUo = typeof(mLElmM0kdWGfEg0Q8v).Assembly;
		j5bBnoprtn = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		jroBW6pRKg = false;
		sywBlAqLpd = false;
		AdyBMiepug = new byte[0];
		Cf4BN2cXyM = null;
		nrLBTFcfM2 = null;
		VNJBAQf9Vn = new object();
		XP3BaXgCjR = new byte[0];
		eTYBzWBHw2 = new byte[0];
		skD8RDnHYA = IntPtr.Zero;
		VDU8V6feDR = IntPtr.Zero;
		YSN8BCmgOq = new string[0];
		CK088qLEKs = new int[0];
		upL8samCqc = 1;
		Fx48vjb1OR = false;
		Tv9803ZlwB = new SortedList();
		tAX8SEHRC0 = 0;
		iZh8dOFN48 = 0L;
		wfZ8yP6kfs = null;
		Wie830kKRU = null;
		qgy8geV2dl = 0L;
		HJD8DZsVN4 = 0;
		bb18P6rHxi = false;
		hFu84wQFi7 = false;
		P2T8erBrxc = 0;
		Yvl8ulbhlQ = IntPtr.Zero;
		d338UE5bhQ = false;
		UwO8Yrb4O2 = new Hashtable();
		HUF8j2GUdE = null;
		yrK8CYKqOl = null;
		xMV8Zr70pJ = null;
		woU828LW5X = null;
		E2F8cmK9Ex = null;
		m5n8pULltW = null;
		iFd8ovhJfB = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void nsdWGHkwiVfJr()
	{
	}

	internal static byte[] syKBvEgIbI(byte[] P_0)
	{
		uint[] array = new uint[16];
		int num = 448 - P_0.Length * 8 % 512;
		uint num2 = (uint)((num + 512) % 512);
		if (num2 == 0)
		{
			num2 = 512u;
		}
		uint num3 = (uint)(P_0.Length + num2 / 8 + 8);
		ulong num4 = (ulong)P_0.Length * 8uL;
		byte[] array2 = new byte[num3];
		for (int i = 0; i < P_0.Length; i++)
		{
			array2[i] = P_0[i];
		}
		array2[P_0.Length] |= 128;
		for (int num5 = 8; num5 > 0; num5--)
		{
			array2[num3 - num5] = (byte)((num4 >> (8 - num5) * 8) & 0xFF);
		}
		uint num6 = (uint)(array2.Length * 8) / 32u;
		uint num7 = 1732584193u;
		uint num8 = 4023233417u;
		uint num9 = 2562383102u;
		uint num10 = 271733878u;
		for (uint num11 = 0u; num11 < num6 / 16; num11++)
		{
			uint num12 = num11 << 6;
			for (uint num13 = 0u; num13 < 61; num13 += 4)
			{
				array[num13 >> 2] = (uint)((array2[num12 + (num13 + 3)] << 24) | (array2[num12 + (num13 + 2)] << 16) | (array2[num12 + (num13 + 1)] << 8) | array2[num12 + num13]);
			}
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			uint num17 = num10;
			k58B0hAbEi(ref num7, num8, num9, num10, 0u, 7, 1u, array);
			k58B0hAbEi(ref num10, num7, num8, num9, 1u, 12, 2u, array);
			k58B0hAbEi(ref num9, num10, num7, num8, 2u, 17, 3u, array);
			k58B0hAbEi(ref num8, num9, num10, num7, 3u, 22, 4u, array);
			k58B0hAbEi(ref num7, num8, num9, num10, 4u, 7, 5u, array);
			k58B0hAbEi(ref num10, num7, num8, num9, 5u, 12, 6u, array);
			k58B0hAbEi(ref num9, num10, num7, num8, 6u, 17, 7u, array);
			k58B0hAbEi(ref num8, num9, num10, num7, 7u, 22, 8u, array);
			k58B0hAbEi(ref num7, num8, num9, num10, 8u, 7, 9u, array);
			k58B0hAbEi(ref num10, num7, num8, num9, 9u, 12, 10u, array);
			k58B0hAbEi(ref num9, num10, num7, num8, 10u, 17, 11u, array);
			k58B0hAbEi(ref num8, num9, num10, num7, 11u, 22, 12u, array);
			k58B0hAbEi(ref num7, num8, num9, num10, 12u, 7, 13u, array);
			k58B0hAbEi(ref num10, num7, num8, num9, 13u, 12, 14u, array);
			k58B0hAbEi(ref num9, num10, num7, num8, 14u, 17, 15u, array);
			k58B0hAbEi(ref num8, num9, num10, num7, 15u, 22, 16u, array);
			IJ2BSimpeR(ref num7, num8, num9, num10, 1u, 5, 17u, array);
			IJ2BSimpeR(ref num10, num7, num8, num9, 6u, 9, 18u, array);
			IJ2BSimpeR(ref num9, num10, num7, num8, 11u, 14, 19u, array);
			IJ2BSimpeR(ref num8, num9, num10, num7, 0u, 20, 20u, array);
			IJ2BSimpeR(ref num7, num8, num9, num10, 5u, 5, 21u, array);
			IJ2BSimpeR(ref num10, num7, num8, num9, 10u, 9, 22u, array);
			IJ2BSimpeR(ref num9, num10, num7, num8, 15u, 14, 23u, array);
			IJ2BSimpeR(ref num8, num9, num10, num7, 4u, 20, 24u, array);
			IJ2BSimpeR(ref num7, num8, num9, num10, 9u, 5, 25u, array);
			IJ2BSimpeR(ref num10, num7, num8, num9, 14u, 9, 26u, array);
			IJ2BSimpeR(ref num9, num10, num7, num8, 3u, 14, 27u, array);
			IJ2BSimpeR(ref num8, num9, num10, num7, 8u, 20, 28u, array);
			IJ2BSimpeR(ref num7, num8, num9, num10, 13u, 5, 29u, array);
			IJ2BSimpeR(ref num10, num7, num8, num9, 2u, 9, 30u, array);
			IJ2BSimpeR(ref num9, num10, num7, num8, 7u, 14, 31u, array);
			IJ2BSimpeR(ref num8, num9, num10, num7, 12u, 20, 32u, array);
			CdhBdbXMYh(ref num7, num8, num9, num10, 5u, 4, 33u, array);
			CdhBdbXMYh(ref num10, num7, num8, num9, 8u, 11, 34u, array);
			CdhBdbXMYh(ref num9, num10, num7, num8, 11u, 16, 35u, array);
			CdhBdbXMYh(ref num8, num9, num10, num7, 14u, 23, 36u, array);
			CdhBdbXMYh(ref num7, num8, num9, num10, 1u, 4, 37u, array);
			CdhBdbXMYh(ref num10, num7, num8, num9, 4u, 11, 38u, array);
			CdhBdbXMYh(ref num9, num10, num7, num8, 7u, 16, 39u, array);
			CdhBdbXMYh(ref num8, num9, num10, num7, 10u, 23, 40u, array);
			CdhBdbXMYh(ref num7, num8, num9, num10, 13u, 4, 41u, array);
			CdhBdbXMYh(ref num10, num7, num8, num9, 0u, 11, 42u, array);
			CdhBdbXMYh(ref num9, num10, num7, num8, 3u, 16, 43u, array);
			CdhBdbXMYh(ref num8, num9, num10, num7, 6u, 23, 44u, array);
			CdhBdbXMYh(ref num7, num8, num9, num10, 9u, 4, 45u, array);
			CdhBdbXMYh(ref num10, num7, num8, num9, 12u, 11, 46u, array);
			CdhBdbXMYh(ref num9, num10, num7, num8, 15u, 16, 47u, array);
			CdhBdbXMYh(ref num8, num9, num10, num7, 2u, 23, 48u, array);
			AtCBy6PjkA(ref num7, num8, num9, num10, 0u, 6, 49u, array);
			AtCBy6PjkA(ref num10, num7, num8, num9, 7u, 10, 50u, array);
			AtCBy6PjkA(ref num9, num10, num7, num8, 14u, 15, 51u, array);
			AtCBy6PjkA(ref num8, num9, num10, num7, 5u, 21, 52u, array);
			AtCBy6PjkA(ref num7, num8, num9, num10, 12u, 6, 53u, array);
			AtCBy6PjkA(ref num10, num7, num8, num9, 3u, 10, 54u, array);
			AtCBy6PjkA(ref num9, num10, num7, num8, 10u, 15, 55u, array);
			AtCBy6PjkA(ref num8, num9, num10, num7, 1u, 21, 56u, array);
			AtCBy6PjkA(ref num7, num8, num9, num10, 8u, 6, 57u, array);
			AtCBy6PjkA(ref num10, num7, num8, num9, 15u, 10, 58u, array);
			AtCBy6PjkA(ref num9, num10, num7, num8, 6u, 15, 59u, array);
			AtCBy6PjkA(ref num8, num9, num10, num7, 13u, 21, 60u, array);
			AtCBy6PjkA(ref num7, num8, num9, num10, 4u, 6, 61u, array);
			AtCBy6PjkA(ref num10, num7, num8, num9, 11u, 10, 62u, array);
			AtCBy6PjkA(ref num9, num10, num7, num8, 2u, 15, 63u, array);
			AtCBy6PjkA(ref num8, num9, num10, num7, 9u, 21, 64u, array);
			num7 += num14;
			num8 += num15;
			num9 += num16;
			num10 += num17;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num7), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(num10), 0, array3, 12, 4);
		return array3;
	}

	private static void k58B0hAbEi(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + XqrB3oQv6g(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + j5bBnoprtn[P_6 - 1], P_5);
	}

	private static void IJ2BSimpeR(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + XqrB3oQv6g(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + j5bBnoprtn[P_6 - 1], P_5);
	}

	private static void CdhBdbXMYh(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + XqrB3oQv6g(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + j5bBnoprtn[P_6 - 1], P_5);
	}

	private static void AtCBy6PjkA(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + XqrB3oQv6g(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + j5bBnoprtn[P_6 - 1], P_5);
	}

	private static uint XqrB3oQv6g(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool REuBgoN4BR()
	{
		if (!jroBW6pRKg)
		{
			Xu8BPhnDcP();
			jroBW6pRKg = true;
		}
		return sywBlAqLpd;
	}

	internal static SymmetricAlgorithm cdLBDDJbDP()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (REuBgoN4BR())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
		}
	}

	internal static void Xu8BPhnDcP()
	{
		try
		{
			sywBlAqLpd = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] cCUB4bVwKr(byte[] P_0)
	{
		if (!REuBgoN4BR())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return syKBvEgIbI(P_0);
	}

	internal static void OWfBefFXWr(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			qMDBun4cax(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void qMDBun4cax(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint pk2BUNltN7(uint P_0, int P_1, long P_2, BinaryReader P_3)
	{
		for (int i = 0; i < P_1; i++)
		{
			P_3.BaseStream.Position = P_2 + (i * 40 + 8);
			uint num = P_3.ReadUInt32();
			uint num2 = P_3.ReadUInt32();
			P_3.ReadUInt32();
			uint num3 = P_3.ReadUInt32();
			if (num2 <= P_0 && P_0 < num2 + num)
			{
				return num3 + P_0 - num2;
			}
		}
		return 0u;
	}

	public static void ySFBYVGP8M(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (nrLBTFcfM2 == null)
			{
				lock (VNJBAQf9Vn)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(mLElmM0kdWGfEg0Q8v).Assembly.GetManifestResourceStream("gLn5S3Lq3JNx8vpFAa.WIK2rOmiPTKd3D3pSK"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length > 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0u;
						uint num4 = 0u;
						if (num > 0)
						{
							num2++;
						}
						uint num5 = 0u;
						for (int i = 0; i < num2; i++)
						{
							int num6 = i * 4;
							uint num7 = 255u;
							int num8 = 0;
							if (i == num2 - 1 && num > 0)
							{
								num4 = 0u;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num4 <<= 8;
									}
									num4 |= array[^(1 + j)];
								}
							}
							else
							{
								num5 = (uint)num6;
								num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + 1] << 8) | array[num5]);
							}
							num3 = num3;
							num3 += yH8BZuyRmX(num3);
							if (i == num2 - 1 && num > 0)
							{
								uint num9 = num3 ^ num4;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + k] = (byte)((num9 & num7) >> num8);
								}
							}
							else
							{
								uint num10 = num3 ^ num4;
								array2[num6] = (byte)(num10 & 0xFF);
								array2[num6 + 1] = (byte)((num10 & 0xFF00) >> 8);
								array2[num6 + 2] = (byte)((num10 & 0xFF0000) >> 16);
								array2[num6 + 3] = (byte)((num10 & 0xFF000000u) >> 24);
							}
						}
						array = array2;
						array2 = null;
						int num11 = array.Length / 8;
						ah0POMuVPMgXQZ6p2t ah0POMuVPMgXQZ6p2t = new ah0POMuVPMgXQZ6p2t(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = ah0POMuVPMgXQZ6p2t.sRd81oC08d();
							int value = ah0POMuVPMgXQZ6p2t.sRd81oC08d();
							dictionary.Add(key, value);
						}
						ah0POMuVPMgXQZ6p2t.hPv8wiKMtK();
					}
					nrLBTFcfM2 = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = nrLBTFcfM2[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)typeof(mLElmM0kdWGfEg0Q8v).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
				if (methodInfo.IsStatic)
				{
					fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
					continue;
				}
				ParameterInfo[] parameters = methodInfo.GetParameters();
				int num13 = parameters.Length + 1;
				Type[] array3 = new Type[num13];
				if (methodInfo.DeclaringType.IsValueType)
				{
					array3[0] = methodInfo.DeclaringType.MakeByRefType();
				}
				else
				{
					array3[0] = typeof(object);
				}
				for (int n = 0; n < parameters.Length; n++)
				{
					array3[n + 1] = parameters[n].ParameterType;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				for (int num14 = 0; num14 < num13; num14++)
				{
					switch (num14)
					{
					case 0:
						iLGenerator.Emit(OpCodes.Ldarg_0);
						break;
					case 1:
						iLGenerator.Emit(OpCodes.Ldarg_1);
						break;
					case 2:
						iLGenerator.Emit(OpCodes.Ldarg_2);
						break;
					case 3:
						iLGenerator.Emit(OpCodes.Ldarg_3);
						break;
					default:
						iLGenerator.Emit(OpCodes.Ldarg_S, num14);
						break;
					}
				}
				iLGenerator.Emit(OpCodes.Tailcall);
				iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
				iLGenerator.Emit(OpCodes.Ret);
				fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
			}
		}
		catch (Exception)
		{
		}
	}

	private static uint kqcBCVmiL1(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint yH8BZuyRmX(uint P_0)
	{
		return 0u;
	}

	internal static void J4eB22hHNg()
	{
	}

	[M0Se8Ayw9NYfdH7gOm(typeof(M0Se8Ayw9NYfdH7gOm.Sguirw31AwiKeBmSAY<object>[]))]
	internal static string f9XBcmGxgX(int P_0)
	{
		int num = 245;
		int num15 = default(int);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		int num14 = default(int);
		int num21 = default(int);
		int num34 = default(int);
		ICryptoTransform transform = default(ICryptoTransform);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		byte[] array5 = default(byte[]);
		byte[] array3 = default(byte[]);
		uint num17 = default(uint);
		uint num4 = default(uint);
		byte[] array7 = default(byte[]);
		uint num24 = default(uint);
		uint num18 = default(uint);
		uint num32 = default(uint);
		int num23 = default(int);
		byte[] array6 = default(byte[]);
		uint num33 = default(uint);
		int num20 = default(int);
		int num35 = default(int);
		int num25 = default(int);
		uint num16 = default(uint);
		uint num31 = default(uint);
		int num22 = default(int);
		ah0POMuVPMgXQZ6p2t ah0POMuVPMgXQZ6p2t = default(ah0POMuVPMgXQZ6p2t);
		byte[] array4 = default(byte[]);
		int num36 = default(int);
		CryptoStream cryptoStream = default(CryptoStream);
		Stream stream = default(Stream);
		int num26 = default(int);
		int num29 = default(int);
		int num19 = default(int);
		int num28 = default(int);
		string result = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 125:
					num15 = 133 - 44;
					num2 = 351;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 356:
					array[5] = 166;
					num2 = 420;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 358:
					array2[21] = 48;
					num = 422;
					break;
				case 106:
					array[1] = (byte)num15;
					num = 286;
					break;
				case 114:
					array[3] = (byte)num15;
					num2 = 55;
					continue;
				case 18:
					array2[25] = 138;
					num2 = 264;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 218:
					num14 = 99 + 95;
					num2 = 140;
					continue;
				case 262:
					num14 = 97 - 64;
					num2 = 404;
					continue;
				case 173:
					num14 = 105 + 118;
					num2 = 91;
					continue;
				case 252:
					array2[19] = (byte)num14;
					num2 = 226;
					continue;
				case 130:
				case 297:
					if (num21 >= num34)
					{
						num2 = 365;
						continue;
					}
					goto case 148;
				case 70:
					array[4] = 222;
					num = 33;
					break;
				case 160:
					num14 = 62 + 37;
					num2 = 295;
					continue;
				case 68:
					array[12] = (byte)num15;
					num2 = 426;
					continue;
				case 73:
					array2[29] = 107;
					num2 = 369;
					continue;
				case 72:
					array[11] = (byte)num15;
					num2 = 231;
					continue;
				case 102:
					array[14] = (byte)num15;
					num2 = 357;
					continue;
				case 374:
					array[9] = 93;
					num = 209;
					break;
				case 260:
					array2[27] = 226;
					num2 = 17;
					continue;
				case 37:
					array2[15] = (byte)num14;
					num2 = 436;
					continue;
				case 239:
					array[2] = 6;
					num2 = 47;
					continue;
				case 439:
					array[9] = (byte)num15;
					num2 = 101;
					continue;
				case 228:
					array2[15] = (byte)num14;
					num2 = 305;
					continue;
				case 348:
					num14 = 8 + 10;
					num2 = 37;
					continue;
				case 323:
					transform = (ICryptoTransform)knFrtMcGUkXJv1dPrA(symmetricAlgorithm, array5, array3);
					num2 = 334;
					continue;
				case 222:
					array2[24] = 130;
					num2 = 58;
					if (!kAcYtDSAiNAi9P0eZt())
					{
						num2 = 0;
					}
					continue;
				case 87:
					num17 = num4;
					num2 = 224;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 95:
					array2[0] = (byte)num14;
					num2 = 419;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 128:
					num15 = 72 + 74;
					num = 68;
					break;
				case 362:
					num14 = 124 + 54;
					num2 = 274;
					continue;
				case 191:
					array2[20] = (byte)num14;
					num2 = 273;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 80:
					array[4] = (byte)num15;
					num2 = 431;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 248:
					array7 = XP3BaXgCjR;
					num2 = 107;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 347:
					array[2] = 134;
					num2 = 386;
					continue;
				case 115:
					array2[27] = (byte)num14;
					num2 = 57;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 401:
					array[10] = (byte)num15;
					num2 = 376;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 82:
					array2[19] = (byte)num14;
					num2 = 235;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 195:
					array2[7] = 187;
					num2 = 173;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 53:
					array2[17] = (byte)num14;
					num2 = 76;
					if (kAcYtDSAiNAi9P0eZt())
					{
						num2 = 149;
					}
					continue;
				case 395:
					array[10] = 136;
					num2 = 31;
					continue;
				case 147:
					array[7] = (byte)num15;
					num2 = 340;
					if (!kAcYtDSAiNAi9P0eZt())
					{
						num2 = 268;
					}
					continue;
				case 344:
					array[7] = 210;
					num2 = 432;
					continue;
				case 309:
					num15 = 128 - 24;
					num2 = 72;
					continue;
				case 6:
					array[1] = (byte)num15;
					num2 = 347;
					if (!kAcYtDSAiNAi9P0eZt())
					{
						num2 = 2;
					}
					continue;
				case 171:
					num24 = num17 ^ num18;
					num2 = 318;
					continue;
				case 48:
					array2 = new byte[32];
					num2 = 320;
					continue;
				case 21:
					num32 = (uint)num23;
					num2 = 60;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 434:
					array2[17] = 196;
					num2 = 92;
					continue;
				case 359:
					array2[13] = (byte)num14;
					num2 = 296;
					continue;
				case 364:
					num14 = 151 - 50;
					num2 = 203;
					continue;
				case 286:
					array[1] = 140;
					num2 = 326;
					continue;
				case 79:
					array6[num23 + 3] = (byte)((num24 & 0xFF000000u) >> 24);
					num2 = 42;
					continue;
				case 204:
					array[2] = (byte)num15;
					num2 = 341;
					continue;
				case 236:
					array[8] = (byte)num15;
					num2 = 133;
					continue;
				case 189:
					num14 = 166 - 55;
					num2 = 8;
					continue;
				case 17:
					num14 = 106 + 90;
					num2 = 411;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 190:
					array6[num23 + 2] = (byte)((num24 & 0xFF0000) >> 16);
					num2 = 63;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						num2 = 79;
					}
					continue;
				case 84:
					num14 = 51 + 0;
					num2 = 59;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 234:
					array[0] = 168;
					num = 182;
					break;
				case 179:
					array = new byte[16];
					num = 50;
					break;
				case 259:
					array2[31] = (byte)num14;
					num2 = 155;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 308:
					array2[11] = (byte)num14;
					num2 = 212;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 326:
					num15 = 18 + 98;
					num2 = 408;
					continue;
				case 184:
					array2[15] = (byte)num14;
					num2 = 392;
					continue;
				case 411:
					array2[28] = (byte)num14;
					num2 = 170;
					if (kAcYtDSAiNAi9P0eZt())
					{
						num2 = 225;
					}
					continue;
				case 240:
					array[6] = 99;
					num2 = 355;
					if (WiV98MGb48GT3d9IUM() != null)
					{
						num2 = 85;
					}
					continue;
				case 274:
					array2[4] = (byte)num14;
					num = 406;
					break;
				case 400:
					array2[8] = (byte)num14;
					num2 = 262;
					continue;
				case 113:
					num17 += num33;
					num2 = 21;
					continue;
				case 76:
					num14 = 71 + 60;
					num2 = 294;
					continue;
				case 165:
					array[14] = 133;
					num2 = 5;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						num2 = 116;
					}
					continue;
				case 320:
					num14 = 139 - 46;
					num2 = 27;
					continue;
				case 420:
					num15 = 29 + 21;
					num2 = 393;
					continue;
				case 288:
					array2[12] = (byte)num14;
					num2 = 354;
					continue;
				case 137:
					num14 = 44 + 59;
					num2 = 115;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 86:
					num14 = 131 - 43;
					num2 = 45;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 66:
					num14 = 59 + 0;
					num2 = 312;
					continue;
				case 414:
					num20 = 0;
					num2 = 135;
					continue;
				case 5:
					array[13] = (byte)num15;
					num2 = 275;
					if (WiV98MGb48GT3d9IUM() != null)
					{
						num2 = 86;
					}
					continue;
				case 210:
					num15 = 228 - 76;
					num2 = 204;
					continue;
				case 93:
					array2[10] = (byte)num14;
					num2 = 336;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						num2 = 371;
					}
					continue;
				case 377:
					return "";
				case 104:
					array2[27] = (byte)num14;
					num2 = 328;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 176:
					array2[1] = (byte)num14;
					num2 = 218;
					continue;
				case 266:
					num33 = 0u;
					num2 = 370;
					continue;
				case 237:
					array2[25] = (byte)num14;
					num2 = 18;
					continue;
				case 100:
					array6[num23 + 1] = (byte)((num24 & 0xFF00) >> 8);
					num2 = 190;
					continue;
				case 328:
					array2[27] = 42;
					num2 = 0;
					if (kAcYtDSAiNAi9P0eZt())
					{
						num2 = 1;
					}
					continue;
				case 212:
					num14 = 28 - 11;
					num2 = 103;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 336:
					array2[31] = 122;
					num2 = 134;
					continue;
				case 272:
					num35 = 0;
					num2 = 97;
					continue;
				case 341:
					array[2] = 138;
					num2 = 123;
					continue;
				case 394:
					array[1] = (byte)num15;
					num = 277;
					break;
				case 385:
					num15 = 30 + 63;
					num2 = 143;
					continue;
				case 101:
					array[9] = 97;
					num2 = 197;
					if (kAcYtDSAiNAi9P0eZt())
					{
						num2 = 374;
					}
					continue;
				case 4:
					num18 <<= 8;
					num = 283;
					break;
				case 35:
					num14 = 207 - 69;
					num2 = 104;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 269:
					array2[18] = 88;
					num2 = 76;
					continue;
				case 319:
					num15 = 79 + 93;
					num2 = 418;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 153:
					array6[num23 + num25] = (byte)((num16 & num31) >> num22);
					num2 = 440;
					continue;
				case 220:
					array2[25] = (byte)num14;
					num2 = 205;
					continue;
				case 192:
					array2[24] = (byte)num14;
					num2 = 425;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 324:
					array2[4] = 150;
					num2 = 362;
					continue;
				case 211:
					num18 = 0u;
					num = 367;
					break;
				case 249:
					num14 = 184 - 61;
					num2 = 285;
					continue;
				case 281:
					num15 = 117 + 72;
					num2 = 102;
					continue;
				case 50:
					num15 = 139 - 46;
					num2 = 142;
					continue;
				case 313:
					array2[30] = (byte)num14;
					num2 = 129;
					continue;
				case 208:
					G6FENHMaJuughEdJiE(ah0POMuVPMgXQZ6p2t);
					num2 = 48;
					continue;
				case 246:
					num14 = 53 + 77;
					num = 93;
					break;
				case 117:
					num15 = 166 - 85;
					num2 = 261;
					continue;
				case 156:
					array2[23] = 132;
					num2 = 221;
					continue;
				case 94:
					num14 = 99 + 107;
					num2 = 335;
					continue;
				case 105:
					num14 = 32 + 99;
					num2 = 237;
					continue;
				case 225:
					num14 = 45 + 75;
					num2 = 138;
					continue;
				case 131:
					num14 = 233 - 77;
					num2 = 163;
					continue;
				case 230:
					num14 = 139 - 46;
					num2 = 127;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 292:
					array2[10] = (byte)num14;
					num2 = 364;
					continue;
				case 276:
					array2[16] = (byte)num14;
					num2 = 49;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 425:
					array2[24] = 201;
					num2 = 162;
					continue;
				case 305:
					num14 = 209 - 69;
					num2 = 92;
					if (kAcYtDSAiNAi9P0eZt())
					{
						num2 = 276;
					}
					continue;
				case 25:
					array[8] = (byte)num15;
					num2 = 301;
					continue;
				case 182:
					num15 = 57 + 42;
					num2 = 4;
					if (kAcYtDSAiNAi9P0eZt())
					{
						num2 = 159;
					}
					continue;
				case 290:
					array2[7] = 149;
					num = 30;
					break;
				case 424:
					array[12] = (byte)num15;
					num2 = 174;
					continue;
				case 15:
					array2[21] = 150;
					num2 = 63;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 354:
					num14 = 220 - 73;
					num2 = 109;
					continue;
				case 270:
					num15 = 251 - 83;
					num2 = 114;
					continue;
				case 310:
					if (array4.Length > 0)
					{
						num2 = 197;
						if (kAcYtDSAiNAi9P0eZt())
						{
							continue;
						}
						break;
					}
					goto case 414;
				case 140:
					array2[2] = (byte)num14;
					num2 = 375;
					continue;
				case 1:
					array2[27] = 85;
					num2 = 260;
					continue;
				case 365:
					XP3BaXgCjR = array6;
					num2 = 317;
					continue;
				case 283:
					num18 |= array7[^(1 + num35)];
					num2 = 363;
					continue;
				case 64:
					array2[18] = 217;
					num2 = 112;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 142:
					array[0] = (byte)num15;
					num2 = 234;
					if (WiV98MGb48GT3d9IUM() != null)
					{
						num2 = 159;
					}
					continue;
				case 346:
					num15 = 167 - 55;
					num2 = 439;
					continue;
				case 340:
					array[7] = 138;
					num2 = 119;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 159:
					array[0] = (byte)num15;
					num2 = 311;
					continue;
				case 361:
					num32 = (uint)(num36 * 4);
					num2 = 175;
					continue;
				case 379:
					array[7] = (byte)num15;
					num = 344;
					break;
				case 181:
					array2[22] = (byte)num14;
					num2 = 150;
					continue;
				case 416:
					array2[17] = 81;
					num2 = 434;
					continue;
				case 186:
					PRMHepH8Fwj3r9SABw(cryptoStream, array7, 0, array7.Length);
					num2 = 438;
					continue;
				case 3:
					array5 = array2;
					num2 = 55;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						num2 = 179;
					}
					continue;
				case 31:
					array[11] = 147;
					num2 = 407;
					continue;
				case 98:
					array2[31] = (byte)num14;
					num2 = 189;
					continue;
				case 376:
					array[10] = 181;
					num2 = 395;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 188:
					array[10] = (byte)num15;
					num2 = 316;
					continue;
				case 83:
					num14 = 202 - 67;
					num = 339;
					break;
				case 302:
					array2[29] = (byte)num14;
					num2 = 73;
					continue;
				case 141:
					num14 = 218 - 72;
					num = 373;
					break;
				case 34:
					array2[0] = (byte)num14;
					num2 = 170;
					continue;
				case 138:
					array2[28] = (byte)num14;
					num2 = 415;
					continue;
				case 175:
					num33 = (uint)((array5[num32 + 3] << 24) | (array5[num32 + 2] << 16) | (array5[num32 + 1] << 8) | array5[num32]);
					num2 = 77;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 373:
					array2[20] = (byte)num14;
					num2 = 372;
					continue;
				case 170:
					array2[1] = 152;
					num2 = 249;
					continue;
				case 226:
					num14 = 130 - 112;
					num2 = 82;
					continue;
				case 381:
					num14 = 188 + 59;
					num2 = 176;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 36:
					array2[15] = 144;
					num2 = 433;
					continue;
				case 250:
					array2[12] = (byte)num14;
					num2 = 437;
					if (!kAcYtDSAiNAi9P0eZt())
					{
						num2 = 256;
					}
					continue;
				case 155:
					array2[31] = 2;
					num2 = 3;
					continue;
				case 278:
					array2[26] = (byte)num14;
					num2 = 67;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 164:
					num14 = 55 + 30;
					num2 = 288;
					continue;
				case 419:
					array2[0] = 113;
					num2 = 213;
					continue;
				case 8:
					array2[31] = (byte)num14;
					num2 = 7;
					continue;
				case 205:
					array2[26] = 189;
					num2 = 85;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 206:
					array6 = new byte[array7.Length];
					num2 = 349;
					continue;
				case 202:
				case 263:
					num4 = num17;
					num2 = 199;
					continue;
				case 307:
					array[11] = 100;
					num2 = 309;
					continue;
				case 61:
					num14 = 247 - 82;
					num2 = 111;
					continue;
				case 303:
					array2[22] = (byte)num14;
					num2 = 156;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 255:
					num14 = 226 - 75;
					num2 = 144;
					if (!kAcYtDSAiNAi9P0eZt())
					{
						num2 = 96;
					}
					continue;
				case 26:
					array2[17] = (byte)num14;
					num2 = 94;
					continue;
				case 265:
					array2[19] = 139;
					num2 = 429;
					continue;
				case 196:
					array[3] = 69;
					num2 = 96;
					continue;
				case 408:
					array[1] = (byte)num15;
					num2 = 247;
					continue;
				case 16:
					num34++;
					num = 88;
					break;
				case 126:
					NsO5VHhtZcHSCodLyp(array3);
					num2 = 353;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 295:
					array2[7] = (byte)num14;
					num2 = 290;
					continue;
				case 119:
					num15 = 22 + 80;
					num2 = 379;
					continue;
				case 417:
					num14 = 157 - 52;
					num2 = 308;
					continue;
				case 224:
					if (num21 == num34 - 1)
					{
						num2 = 253;
						if (!kAcYtDSAiNAi9P0eZt())
						{
							num2 = 142;
						}
						continue;
					}
					goto case 171;
				case 294:
					array2[19] = (byte)num14;
					num2 = 255;
					continue;
				case 124:
					array2[5] = (byte)num14;
					num = 360;
					break;
				case 427:
					array2[26] = 29;
					num2 = 137;
					continue;
				case 13:
					array2[15] = (byte)num14;
					num2 = 348;
					continue;
				case 91:
					array2[8] = (byte)num14;
					num = 388;
					break;
				case 166:
					array[15] = 86;
					num2 = 158;
					continue;
				case 154:
					if (array4 != null)
					{
						num2 = 143;
						if (WiV98MGb48GT3d9IUM() == null)
						{
							num2 = 310;
						}
						continue;
					}
					goto case 414;
				case 62:
					num15 = 189 - 63;
					num2 = 188;
					continue;
				case 172:
					symmetricAlgorithm = (SymmetricAlgorithm)js696OrRKE3SJc3tkg();
					num2 = 185;
					continue;
				case 284:
					if (num35 > 0)
					{
						num2 = 4;
						if (!kAcYtDSAiNAi9P0eZt())
						{
							num2 = 2;
						}
						continue;
					}
					goto case 283;
				case 285:
					array2[1] = (byte)num14;
					num2 = 180;
					continue;
				case 209:
					num15 = 72 + 98;
					num2 = 19;
					continue;
				case 14:
					array[9] = 93;
					num2 = 34;
					if (kAcYtDSAiNAi9P0eZt())
					{
						num2 = 39;
					}
					continue;
				case 372:
					array2[20] = 137;
					num2 = 201;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 177:
					C8dmVAwtQwKwvnuTlc(stream);
					num = 396;
					break;
				case 293:
					array[3] = (byte)num15;
					num2 = 196;
					continue;
				case 92:
					array2[17] = 42;
					num2 = 20;
					continue;
				case 421:
					array2[13] = (byte)num14;
					num = 230;
					break;
				case 306:
					array[12] = (byte)num15;
					num2 = 128;
					if (WiV98MGb48GT3d9IUM() != null)
					{
						num2 = 77;
					}
					continue;
				case 59:
					array2[25] = (byte)num14;
					num2 = 105;
					continue;
				case 43:
					array3[3] = array4[1];
					num = 383;
					break;
				case 20:
					num14 = 134 - 87;
					num2 = 53;
					continue;
				case 389:
					num14 = 207 - 115;
					num2 = 124;
					continue;
				case 353:
					array4 = (byte[])JQ7Nqae9KmTKf9wCcG(ntOTmqY1PoVpK0t9l9(JkKBr6NVUo));
					num2 = 154;
					continue;
				case 10:
					array2[12] = 74;
					num2 = 164;
					continue;
				case 387:
					array3[9] = array4[4];
					num2 = 256;
					continue;
				case 393:
					array[6] = (byte)num15;
					num2 = 164;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						num2 = 240;
					}
					continue;
				case 30:
					array2[7] = 143;
					num2 = 267;
					continue;
				case 203:
					array2[10] = (byte)num14;
					num2 = 187;
					if (!kAcYtDSAiNAi9P0eZt())
					{
						num2 = 182;
					}
					continue;
				case 67:
					array2[26] = 149;
					num2 = 378;
					continue;
				case 112:
					array2[18] = 184;
					num2 = 298;
					continue;
				case 254:
					array[2] = (byte)num15;
					num2 = 210;
					continue;
				case 232:
					array2[5] = 123;
					num2 = 423;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 334:
					stream = (Stream)b4S4nu1R70s7HkQGCq();
					num2 = 215;
					continue;
				case 151:
					num23 = num21 * 4;
					num2 = 361;
					if (!kAcYtDSAiNAi9P0eZt())
					{
						num2 = 140;
					}
					continue;
				default:
					array2[23] = 28;
					num2 = 90;
					if (WiV98MGb48GT3d9IUM() != null)
					{
						num2 = 50;
					}
					continue;
				case 403:
					array[14] = 120;
					num2 = 281;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 162:
					num14 = 53 + 96;
					num2 = 78;
					continue;
				case 123:
					array[2] = 116;
					num2 = 239;
					continue;
				case 380:
					num14 = 81 - 1;
					num = 303;
					break;
				case 215:
					cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num2 = 186;
					continue;
				case 382:
					array2[18] = (byte)num14;
					num2 = 68;
					if (kAcYtDSAiNAi9P0eZt())
					{
						num2 = 168;
					}
					continue;
				case 390:
					if (num21 == num34 - 1)
					{
						num2 = 38;
						continue;
					}
					goto case 113;
				case 422:
					num14 = 84 + 86;
					num2 = 109;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						num2 = 132;
					}
					continue;
				case 418:
					array[5] = (byte)num15;
					num = 56;
					break;
				case 430:
					num25 = 0;
					num2 = 329;
					continue;
				case 370:
					num18 = 0u;
					num2 = 108;
					continue;
				case 74:
					array2[3] = (byte)num14;
					num = 315;
					break;
				case 318:
					array6[num23] = (byte)(num24 & 0xFF);
					num2 = 100;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 321:
					array2[14] = 99;
					num2 = 36;
					continue;
				case 88:
					num32 = 0u;
					num2 = 280;
					continue;
				case 194:
					num22 += 8;
					num2 = 153;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 431:
					array[4] = 102;
					num2 = 319;
					continue;
				case 322:
					array[15] = 84;
					num2 = 29;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 213:
					array2[0] = 145;
					num2 = 200;
					continue;
				case 301:
					array[8] = 151;
					num2 = 117;
					continue;
				case 363:
					num35++;
					num2 = 40;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 247:
					num15 = 250 - 83;
					num2 = 118;
					continue;
				case 40:
				case 97:
					if (num35 >= num26)
					{
						num2 = 263;
						continue;
					}
					goto case 284;
				case 343:
					array2[25] = (byte)num14;
					num2 = 131;
					continue;
				case 129:
					array2[30] = 102;
					num2 = 51;
					if (WiV98MGb48GT3d9IUM() != null)
					{
						num2 = 17;
					}
					continue;
				case 152:
					array2[21] = (byte)num14;
					num2 = 358;
					continue;
				case 332:
					array2[12] = 216;
					num2 = 287;
					continue;
				case 317:
					num29 = NwfNTNpfwKLO10EbLy(XP3BaXgCjR, P_0);
					num = 223;
					break;
				case 378:
					array2[26] = 96;
					num2 = 28;
					if (kAcYtDSAiNAi9P0eZt())
					{
						num2 = 427;
					}
					continue;
				case 149:
					num14 = 78 + 67;
					num2 = 54;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 47:
					array[3] = 94;
					num2 = 44;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 243:
					array2[9] = 47;
					num = 327;
					break;
				case 169:
					PIQ2sHvsGIIKEn9Z0I(FVDL3hxoRoc9Rbtenr(ah0POMuVPMgXQZ6p2t), 0L);
					num2 = 241;
					continue;
				case 435:
					num15 = 131 - 43;
					num2 = 236;
					continue;
				case 338:
					array2[1] = 159;
					num2 = 381;
					continue;
				case 44:
					array[3] = 109;
					num2 = 270;
					continue;
				case 180:
					array2[1] = 98;
					num2 = 338;
					continue;
				case 109:
					array2[12] = (byte)num14;
					num2 = 332;
					continue;
				case 27:
					array2[0] = (byte)num14;
					num2 = 350;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 396:
					C8dmVAwtQwKwvnuTlc(cryptoStream);
					num2 = 248;
					continue;
				case 233:
					array[8] = (byte)num15;
					num2 = 435;
					continue;
				case 163:
					array2[25] = (byte)num14;
					num2 = 25;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						num2 = 84;
					}
					continue;
				case 111:
					array2[29] = (byte)num14;
					num = 368;
					break;
				case 325:
					num14 = 33 + 26;
					num2 = 278;
					continue;
				case 287:
					num14 = 24 + 86;
					num2 = 359;
					continue;
				case 357:
					num15 = 100 + 81;
					num2 = 22;
					continue;
				case 28:
					array[5] = (byte)num15;
					num2 = 356;
					continue;
				case 65:
					if (num25 > 0)
					{
						num2 = 71;
						continue;
					}
					goto case 153;
				case 399:
					array2[6] = (byte)num14;
					num2 = 146;
					continue;
				case 71:
					num31 <<= 8;
					num2 = 194;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 429:
					num14 = 30 + 34;
					num2 = 252;
					continue;
				case 267:
					num14 = 173 - 57;
					num2 = 251;
					continue;
				case 183:
					num34 = array7.Length / 4;
					num2 = 206;
					continue;
				case 216:
					if (P_0 == -1)
					{
						num = 172;
						break;
					}
					goto case 107;
				case 311:
					array[0] = 159;
					num2 = 330;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 42:
				case 300:
					num21++;
					num2 = 130;
					continue;
				case 54:
					array2[18] = (byte)num14;
					num2 = 64;
					continue;
				case 143:
					array[10] = (byte)num15;
					num2 = 62;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 426:
					num15 = 54 + 54;
					num2 = 5;
					continue;
				case 257:
					num14 = 191 - 63;
					num2 = 279;
					if (!kAcYtDSAiNAi9P0eZt())
					{
						num2 = 274;
					}
					continue;
				case 371:
					num14 = 28 + 81;
					num2 = 292;
					continue;
				case 409:
					num14 = 70 + 72;
					num2 = 228;
					continue;
				case 436:
					array2[15] = 196;
					num2 = 409;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 200:
					num14 = 112 - 82;
					num2 = 34;
					continue;
				case 386:
					num15 = 19 + 103;
					num2 = 254;
					continue;
				case 316:
					num15 = 77 + 14;
					num2 = 401;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 135:
				case 167:
					if (num20 >= array3.Length)
					{
						num2 = 216;
						if (WiV98MGb48GT3d9IUM() == null)
						{
							continue;
						}
						break;
					}
					goto case 110;
				case 406:
					array2[5] = 109;
					num = 232;
					break;
				case 219:
					array2[28] = (byte)num14;
					num2 = 61;
					continue;
				case 333:
					array2[14] = 108;
					num2 = 321;
					continue;
				case 229:
					num14 = 98 - 9;
					num2 = 161;
					if (!kAcYtDSAiNAi9P0eZt())
					{
						num2 = 156;
					}
					continue;
				case 432:
					num15 = 187 - 62;
					num2 = 398;
					continue;
				case 168:
					array2[18] = 96;
					num2 = 269;
					continue;
				case 38:
					if (num26 > 0)
					{
						num2 = 211;
						continue;
					}
					goto case 113;
				case 146:
					num14 = 101 + 25;
					num2 = 391;
					continue;
				case 178:
					array2[22] = (byte)num14;
					num2 = 304;
					continue;
				case 299:
					array2[10] = 162;
					num = 268;
					break;
				case 90:
					num14 = 148 - 49;
					num = 207;
					break;
				case 96:
					array[3] = 185;
					num2 = 70;
					continue;
				case 245:
					if (XP3BaXgCjR.Length == 0)
					{
						num2 = 244;
						continue;
					}
					goto case 317;
				case 55:
					num15 = 209 - 69;
					num2 = 293;
					continue;
				case 85:
					array2[26] = 191;
					num2 = 325;
					if (WiV98MGb48GT3d9IUM() != null)
					{
						num2 = 148;
					}
					continue;
				case 57:
					num14 = 11 + 32;
					num2 = 271;
					continue;
				case 251:
					array2[7] = (byte)num14;
					num2 = 195;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 221:
					array2[23] = 151;
					num2 = 0;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 402:
					num15 = 187 - 62;
					num2 = 147;
					continue;
				case 312:
					array2[5] = (byte)num14;
					num2 = 389;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 46:
					num14 = 9 + 77;
					num = 250;
					break;
				case 291:
					array2[10] = (byte)num14;
					num2 = 246;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 367:
					num17 += num33;
					num = 272;
					break;
				case 350:
					num14 = 122 + 119;
					num2 = 95;
					continue;
				case 148:
					num36 = num21 % num19;
					num2 = 151;
					continue;
				case 433:
					num14 = 209 - 69;
					num2 = 184;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 60:
					num18 = (uint)((array7[num32 + 3] << 24) | (array7[num32 + 2] << 16) | (array7[num32 + 1] << 8) | array7[num32]);
					num2 = 202;
					if (!kAcYtDSAiNAi9P0eZt())
					{
						num2 = 22;
					}
					continue;
				case 437:
					num14 = 63 + 83;
					num = 366;
					break;
				case 58:
					num14 = 194 - 64;
					num2 = 192;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 384:
					array[13] = (byte)num15;
					num2 = 337;
					continue;
				case 89:
					array[15] = 135;
					num2 = 144;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						num2 = 166;
					}
					continue;
				case 296:
					num14 = 102 + 54;
					num2 = 421;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 440:
					num25++;
					num2 = 11;
					continue;
				case 108:
					if (num26 > 0)
					{
						num2 = 16;
						continue;
					}
					goto case 88;
				case 253:
					if (num26 > 0)
					{
						num2 = 289;
						continue;
					}
					goto case 171;
				case 256:
					array3[11] = array4[5];
					num2 = 217;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 33:
					num15 = 125 - 41;
					num2 = 80;
					continue;
				case 264:
					num14 = 143 + 106;
					num2 = 220;
					continue;
				case 315:
					array2[3] = 130;
					num2 = 24;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 116:
					num15 = 63 + 57;
					num2 = 428;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 29:
					array[15] = 152;
					num2 = 89;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 282:
					array2[11] = 152;
					num2 = 417;
					continue;
				case 352:
					array2[3] = (byte)num14;
					num2 = 412;
					continue;
				case 428:
					array[15] = (byte)num15;
					num2 = 322;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 107:
					num26 = array7.Length % 4;
					num2 = 183;
					continue;
				case 127:
					array2[13] = (byte)num14;
					num2 = 120;
					if (!kAcYtDSAiNAi9P0eZt())
					{
						num2 = 120;
					}
					continue;
				case 235:
					array2[20] = 155;
					num2 = 141;
					if (WiV98MGb48GT3d9IUM() != null)
					{
						num2 = 109;
					}
					continue;
				case 330:
					num15 = 174 - 58;
					num2 = 394;
					continue;
				case 78:
					array2[24] = (byte)num14;
					num2 = 99;
					continue;
				case 227:
					num15 = 203 - 67;
					num2 = 306;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 314:
					array2[29] = 18;
					num2 = 198;
					continue;
				case 157:
					array2[5] = (byte)num14;
					num2 = 66;
					continue;
				case 45:
					array2[9] = (byte)num14;
					num2 = 257;
					continue;
				case 122:
					num17 = 0u;
					num2 = 103;
					if (kAcYtDSAiNAi9P0eZt())
					{
						num2 = 266;
					}
					continue;
				case 438:
					DMjoJ7lgWC7SwrAFqV(cryptoStream);
					num2 = 12;
					continue;
				case 258:
					array[14] = 98;
					num2 = 34;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						num2 = 165;
					}
					continue;
				case 77:
					num31 = 255u;
					num2 = 397;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 404:
					array2[8] = (byte)num14;
					num2 = 86;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 134:
					num14 = 222 - 74;
					num2 = 259;
					continue;
				case 185:
					a21BY3mp9t2dnQUqmH(symmetricAlgorithm, CipherMode.CBC);
					num2 = 323;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 271:
					array2[27] = (byte)num14;
					num2 = 35;
					continue;
				case 392:
					num14 = 53 + 20;
					num2 = 13;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 144:
					array2[19] = (byte)num14;
					num2 = 413;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 7:
					array2[31] = 95;
					num2 = 336;
					if (WiV98MGb48GT3d9IUM() != null)
					{
						num2 = 87;
					}
					continue;
				case 337:
					array[13] = 142;
					num = 136;
					break;
				case 193:
					num14 = 74 + 94;
					num2 = 74;
					continue;
				case 279:
					array2[9] = (byte)num14;
					num2 = 243;
					continue;
				case 63:
					num14 = 235 - 78;
					num2 = 152;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 415:
					num14 = 160 + 34;
					num2 = 219;
					continue;
				case 388:
					num14 = 141 - 47;
					num2 = 400;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 198:
					num14 = 39 + 50;
					num2 = 313;
					if (WiV98MGb48GT3d9IUM() != null)
					{
						num2 = 77;
					}
					continue;
				case 261:
					array[8] = (byte)num15;
					num2 = 14;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 223:
					try
					{
						b4x2fIkVw19mmmv8nx();
						int num27 = 1;
						if (WiV98MGb48GT3d9IUM() != null)
						{
							goto IL_30c0;
						}
						goto IL_30c4;
						IL_30c0:
						num27 = num28;
						goto IL_30c4;
						IL_30c4:
						while (true)
						{
							switch (num27)
							{
							case 1:
								goto IL_30d6;
							case 0:
								break;
							}
							break;
							IL_30d6:
							result = (string)biYbEZO0fDo1931gQx(o7Wpg00DgBmMia64bd(), XP3BaXgCjR, P_0 + 4, num29);
							num27 = 0;
							if (WiV98MGb48GT3d9IUM() == null)
							{
								continue;
							}
							goto IL_30c0;
						}
					}
					catch
					{
						int num30 = 0;
						if (WiV98MGb48GT3d9IUM() == null)
						{
							num30 = 0;
						}
						switch (num30)
						{
						}
						goto case 377;
					}
					return result;
				case 423:
					num14 = 241 - 80;
					num2 = 157;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 366:
					array2[12] = (byte)num14;
					num2 = 10;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 410:
					num15 = 190 - 100;
					num2 = 0;
					if (kAcYtDSAiNAi9P0eZt())
					{
						num2 = 6;
					}
					continue;
				case 268:
					array2[11] = 102;
					num2 = 282;
					continue;
				case 150:
					num14 = 245 - 81;
					num2 = 178;
					continue;
				case 187:
					num14 = 230 - 76;
					num2 = 342;
					continue;
				case 39:
					array[9] = 157;
					num2 = 346;
					continue;
				case 201:
					num14 = 0 + 26;
					num2 = 191;
					continue;
				case 375:
					array2[2] = 157;
					num2 = 229;
					continue;
				case 369:
					array2[29] = 65;
					num2 = 314;
					continue;
				case 197:
					array3[1] = array4[0];
					num2 = 43;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 351:
					array[14] = (byte)num15;
					num2 = 403;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 241:
					array7 = (byte[])TTXBuqVhiRPQ1GlanK(ah0POMuVPMgXQZ6p2t, (int)iAxvgP2Q44WZ1YXJ8X(FVDL3hxoRoc9Rbtenr(ah0POMuVPMgXQZ6p2t)));
					num2 = 208;
					continue;
				case 413:
					array2[19] = 167;
					num2 = 265;
					continue;
				case 2:
					num14 = 221 - 73;
					num2 = 181;
					if (!kAcYtDSAiNAi9P0eZt())
					{
						num2 = 52;
					}
					continue;
				case 51:
					array2[30] = 74;
					num2 = 23;
					continue;
				case 207:
					array2[24] = (byte)num14;
					num2 = 222;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 331:
					array2[4] = (byte)num14;
					num2 = 324;
					continue;
				case 304:
					array2[22] = 194;
					num2 = 380;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 9:
					array2[20] = (byte)num14;
					num2 = 15;
					continue;
				case 75:
					num15 = 85 + 64;
					num2 = 233;
					continue;
				case 103:
					array2[11] = (byte)num14;
					num = 46;
					break;
				case 345:
					array3[15] = array4[7];
					num2 = 414;
					if (WiV98MGb48GT3d9IUM() != null)
					{
						num2 = 107;
					}
					continue;
				case 11:
				case 329:
					if (num25 >= num26)
					{
						num2 = 300;
						continue;
					}
					goto case 65;
				case 145:
					num14 = 149 + 63;
					num2 = 238;
					continue;
				case 52:
					array2[6] = 73;
					num2 = 139;
					if (!kAcYtDSAiNAi9P0eZt())
					{
						num2 = 59;
					}
					continue;
				case 56:
					num15 = 74 + 101;
					num2 = 28;
					continue;
				case 360:
					num14 = 93 + 46;
					num2 = 399;
					continue;
				case 405:
					array[13] = (byte)num15;
					num2 = 121;
					continue;
				case 19:
					array[10] = (byte)num15;
					num2 = 385;
					continue;
				case 391:
					array2[6] = (byte)num14;
					num2 = 52;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 383:
					array3[5] = array4[2];
					num2 = 5;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						num2 = 69;
					}
					continue;
				case 397:
					num22 = 0;
					num2 = 390;
					continue;
				case 139:
					array2[7] = 98;
					num2 = 160;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 23:
					num14 = 164 - 54;
					num2 = 98;
					continue;
				case 199:
					num17 = 0u;
					num2 = 214;
					continue;
				case 244:
					ah0POMuVPMgXQZ6p2t = new ah0POMuVPMgXQZ6p2t((Stream)lZUrpWbhOm4Bs1DvDx(JkKBr6NVUo, "BrsECjoDmZFjJI2D7A.VgJyWD3T1qRBXCaJEX"));
					num2 = 169;
					continue;
				case 99:
					num14 = 70 + 30;
					num2 = 343;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 133:
					num15 = 64 + 5;
					num2 = 25;
					continue;
				case 118:
					array[1] = (byte)num15;
					num2 = 34;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						num2 = 410;
					}
					continue;
				case 24:
					num14 = 60 - 55;
					num2 = 352;
					continue;
				case 121:
					array[13] = 135;
					num2 = 125;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 174:
					array[12] = 171;
					num2 = 227;
					continue;
				case 339:
					array2[14] = (byte)num14;
					num2 = 333;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 298:
					num14 = 236 - 78;
					num2 = 382;
					continue;
				case 280:
					num21 = 0;
					num2 = 297;
					if (!kAcYtDSAiNAi9P0eZt())
					{
						num2 = 187;
					}
					continue;
				case 161:
					array2[2] = (byte)num14;
					num2 = 193;
					if (WiV98MGb48GT3d9IUM() != null)
					{
						num2 = 74;
					}
					continue;
				case 231:
					num15 = 151 - 50;
					num2 = 424;
					continue;
				case 335:
					array2[17] = (byte)num14;
					num2 = 416;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 32:
					num14 = 111 + 0;
					num2 = 26;
					continue;
				case 273:
					array2[20] = 105;
					num2 = 242;
					continue;
				case 49:
					array2[16] = 77;
					num2 = 145;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 368:
					num14 = 111 + 116;
					num2 = 302;
					continue;
				case 242:
					num14 = 79 + 56;
					num2 = 9;
					continue;
				case 136:
					num15 = 47 + 53;
					num2 = 405;
					if (!kAcYtDSAiNAi9P0eZt())
					{
						num2 = 313;
					}
					continue;
				case 355:
					num15 = 178 - 94;
					num2 = 81;
					continue;
				case 275:
					num15 = 252 - 84;
					num2 = 384;
					if (kAcYtDSAiNAi9P0eZt())
					{
						continue;
					}
					break;
				case 398:
					array[8] = (byte)num15;
					num2 = 75;
					continue;
				case 81:
					array[6] = (byte)num15;
					num2 = 402;
					continue;
				case 342:
					array2[10] = (byte)num14;
					num2 = 299;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						continue;
					}
					break;
				case 158:
					array3 = array;
					num2 = 126;
					continue;
				case 12:
					XP3BaXgCjR = (byte[])kiynfmAHvfblVM8mqB(stream);
					num2 = 177;
					if (!kAcYtDSAiNAi9P0eZt())
					{
						num2 = 83;
					}
					continue;
				case 120:
					array2[13] = 205;
					num2 = 83;
					continue;
				case 110:
					array5[num20] ^= array3[num20];
					num2 = 41;
					continue;
				case 69:
					array3[7] = array4[3];
					num2 = 376;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						num2 = 387;
					}
					continue;
				case 238:
					array2[16] = (byte)num14;
					num2 = 32;
					continue;
				case 41:
					num20++;
					num2 = 167;
					continue;
				case 412:
					num14 = 58 + 30;
					num2 = 331;
					if (!kAcYtDSAiNAi9P0eZt())
					{
						num2 = 311;
					}
					continue;
				case 327:
					num14 = 97 + 102;
					num2 = 88;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						num2 = 291;
					}
					continue;
				case 407:
					array[11] = 104;
					num2 = 269;
					if (kAcYtDSAiNAi9P0eZt())
					{
						num2 = 307;
					}
					continue;
				case 349:
					num19 = array5.Length / 4;
					num2 = 122;
					continue;
				case 217:
					array3[13] = array4[6];
					num2 = 345;
					continue;
				case 132:
					array2[22] = (byte)num14;
					num2 = 0;
					if (WiV98MGb48GT3d9IUM() == null)
					{
						num2 = 2;
					}
					continue;
				case 289:
					num16 = num17 ^ num18;
					num2 = 430;
					continue;
				case 22:
					array[14] = (byte)num15;
					num2 = 258;
					continue;
				case 277:
					num15 = 239 - 79;
					num2 = 106;
					continue;
				case 214:
				{
					uint num3 = num4;
					uint num5 = num4;
					uint num6 = 487939823u;
					uint num7 = 1467926667u;
					uint num8 = 750732109u;
					uint num9 = 34411092u;
					uint num10 = num5;
					uint num11 = 1551476204u;
					num9 = 292050207 * (num9 & 7) + (num9 >> 3);
					num7 = 57441676 * (num7 & 7) + (num7 >> 3);
					num8 = 48390 * num8 + num6;
					ulong num12 = num9 * num9;
					num12 |= 1;
					num6 = (uint)(num6 * num6 % num12);
					num6 = 16828840 * (num6 & 0x7F) - (num6 >> 7);
					num7 = 28019338 * (num7 & 0x7F) + (num7 >> 7);
					num7 = 38557 * num7 + num6;
					ulong num13 = num7 * 799792916;
					if (num13 == 0)
					{
						num13--;
					}
					num9 = (uint)(num9 * num9 % num13);
					num6 = 10739785 * (num6 & 0x7F) + (num6 >> 7);
					num7 = 18341064 * (num7 & 0x7F) - (num7 >> 7);
					num7 = 37336 * num7 - num6;
					num10 ^= num10 << 18;
					num10 += num8;
					num10 ^= num10 >> 1;
					num10 += num9;
					num10 ^= num10 << 7;
					num10 += num11;
					num10 = (((num8 << 18) - num9) ^ num8) - num10;
					num4 = num3 + (uint)(double)num10;
					num2 = 87;
					continue;
				}
				}
				break;
			}
		}
	}

	[M0Se8Ayw9NYfdH7gOm(typeof(M0Se8Ayw9NYfdH7gOm.Sguirw31AwiKeBmSAY<object>[]))]
	internal static string JRJBp66GlQ(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int mZcBo1jDlY()
	{
		return 5;
	}

	private static void PWNBxwr8iS()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate BknBFqEgvm(IntPtr P_0, Type P_1)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object a6VBilW09q(object P_0)
	{
		try
		{
			if (File.Exists(((Assembly)P_0).Location))
			{
				return ((Assembly)P_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
				.ToString()))
			{
				return P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[DllImport("kernel32", EntryPoint = "LoadLibrary")]
	public static extern IntPtr pv9Bt4xsNF(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr S3RBXoeDSN(IntPtr P_0, string P_1);

	private static IntPtr v1yB1Y1EX0(IntPtr P_0, string P_1, uint P_2)
	{
		if (HUF8j2GUdE == null)
		{
			IntPtr ptr = S3RBXoeDSN(umLocehuEC(), "Find ".Trim() + "ResourceA");
			HUF8j2GUdE = (ULHcHqUxU8b63TwLxO)Marshal.GetDelegateForFunctionPointer(ptr, typeof(ULHcHqUxU8b63TwLxO));
		}
		return HUF8j2GUdE(P_0, P_1, P_2);
	}

	private static IntPtr McDBwTtt3D(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (yrK8CYKqOl == null)
		{
			IntPtr ptr = S3RBXoeDSN(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			yrK8CYKqOl = (qQvY5rYOIfCvWyTNg4)Marshal.GetDelegateForFunctionPointer(ptr, typeof(qQvY5rYOIfCvWyTNg4));
		}
		return yrK8CYKqOl(P_0, P_1, P_2, P_3);
	}

	private static int fNUBhamuOQ(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (xMV8Zr70pJ == null)
		{
			IntPtr ptr = S3RBXoeDSN(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			xMV8Zr70pJ = (wgFcGpjpaF8uPKThXj)Marshal.GetDelegateForFunctionPointer(ptr, typeof(wgFcGpjpaF8uPKThXj));
		}
		return xMV8Zr70pJ(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int bQPBf8Fggp(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (woU828LW5X == null)
		{
			IntPtr ptr = S3RBXoeDSN(umLocehuEC(), "Virtual ".Trim() + "Protect");
			woU828LW5X = (wojL9iCvat9uiCKoq7)Marshal.GetDelegateForFunctionPointer(ptr, typeof(wojL9iCvat9uiCKoq7));
		}
		return woU828LW5X(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr DbjBJufmKZ(uint P_0, int P_1, uint P_2)
	{
		if (E2F8cmK9Ex == null)
		{
			IntPtr ptr = S3RBXoeDSN(umLocehuEC(), "Open ".Trim() + "Process");
			E2F8cmK9Ex = (zFSQ3IZmyQp85LOItd)Marshal.GetDelegateForFunctionPointer(ptr, typeof(zFSQ3IZmyQp85LOItd));
		}
		return E2F8cmK9Ex(P_0, P_1, P_2);
	}

	private static int AGVBLbgXOG(IntPtr P_0)
	{
		if (m5n8pULltW == null)
		{
			IntPtr ptr = S3RBXoeDSN(umLocehuEC(), "Close ".Trim() + "Handle");
			m5n8pULltW = (EuoowW2ghTnnFnM0AM)Marshal.GetDelegateForFunctionPointer(ptr, typeof(EuoowW2ghTnnFnM0AM));
		}
		return m5n8pULltW(P_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (iFd8ovhJfB == IntPtr.Zero)
		{
			iFd8ovhJfB = pv9Bt4xsNF("kernel ".Trim() + "32.dll");
		}
		return iFd8ovhJfB;
	}

	[M0Se8Ayw9NYfdH7gOm(typeof(M0Se8Ayw9NYfdH7gOm.Sguirw31AwiKeBmSAY<object>[]))]
	private static byte[] H9bB5IXnYB(string P_0)
	{
		using FileStream fileStream = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		long length = fileStream.Length;
		int num2 = (int)length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	internal static Stream wF7BkWLyDh()
	{
		return new MemoryStream();
	}

	internal static byte[] GFWBEOpdoi(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	[M0Se8Ayw9NYfdH7gOm(typeof(M0Se8Ayw9NYfdH7gOm.Sguirw31AwiKeBmSAY<object>[]))]
	private static byte[] cjRBImVGGW(byte[] P_0)
	{
		Stream stream = wF7BkWLyDh();
		SymmetricAlgorithm symmetricAlgorithm = cdLBDDJbDP();
		symmetricAlgorithm.Key = new byte[32]
		{
			4, 77, 63, 216, 83, 7, 224, 42, 177, 69,
			180, 156, 233, 72, 22, 243, 212, 26, 21, 237,
			254, 245, 62, 230, 224, 140, 30, 33, 157, 107,
			96, 210
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			132, 152, 202, 65, 171, 34, 34, 129, 170, 30,
			55, 125, 182, 165, 53, 102
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = GFWBEOpdoi(stream);
		l26t3npZsnUe1qbsCU.vf2WGHkzGx201();
		return result;
	}

	private byte[] fZrBQn4e3s()
	{
		return null;
	}

	private byte[] BK4B6FDGBD()
	{
		return null;
	}

	private byte[] serBqZFnIi()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] fVZB9bXZMX()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] XbjBGv9BSe()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] eZZBbES3FI()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] RrwBOuiWE0()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] tqkBHjKq2v()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] VeTBKf6H5E()
	{
		return null;
	}

	internal byte[] SlRBmpqK3B()
	{
		return null;
	}

	internal static object lZUrpWbhOm4Bs1DvDx(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object FVDL3hxoRoc9Rbtenr(object P_0)
	{
		return ((ah0POMuVPMgXQZ6p2t)P_0).KDikMXewCI();
	}

	internal static void PIQ2sHvsGIIKEn9Z0I(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long iAxvgP2Q44WZ1YXJ8X(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object TTXBuqVhiRPQ1GlanK(object P_0, int P_1)
	{
		return ((ah0POMuVPMgXQZ6p2t)P_0).yxt8tS5NNP(P_1);
	}

	internal static void G6FENHMaJuughEdJiE(object P_0)
	{
		((ah0POMuVPMgXQZ6p2t)P_0).hPv8wiKMtK();
	}

	internal static void NsO5VHhtZcHSCodLyp(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object ntOTmqY1PoVpK0t9l9(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object JQ7Nqae9KmTKf9wCcG(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	internal static object js696OrRKE3SJc3tkg()
	{
		return cdLBDDJbDP();
	}

	internal static void a21BY3mp9t2dnQUqmH(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object knFrtMcGUkXJv1dPrA(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[]?)P_2);
	}

	internal static object b4S4nu1R70s7HkQGCq()
	{
		return wF7BkWLyDh();
	}

	internal static void PRMHepH8Fwj3r9SABw(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void DMjoJ7lgWC7SwrAFqV(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object kiynfmAHvfblVM8mqB(object P_0)
	{
		return GFWBEOpdoi((Stream)P_0);
	}

	internal static void C8dmVAwtQwKwvnuTlc(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static int NwfNTNpfwKLO10EbLy(object P_0, int P_1)
	{
		return BitConverter.ToInt32((byte[])P_0, P_1);
	}

	internal static void b4x2fIkVw19mmmv8nx()
	{
		l26t3npZsnUe1qbsCU.vf2WGHkzGx201();
	}

	internal static object o7Wpg00DgBmMia64bd()
	{
		return Encoding.Unicode;
	}

	internal static object biYbEZO0fDo1931gQx(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Encoding)P_0).GetString((byte[])P_1, P_2, P_3);
	}

	internal static bool kAcYtDSAiNAi9P0eZt()
	{
		return (object)null == null;
	}

	internal static object WiV98MGb48GT3d9IUM()
	{
		return null;
	}
}
