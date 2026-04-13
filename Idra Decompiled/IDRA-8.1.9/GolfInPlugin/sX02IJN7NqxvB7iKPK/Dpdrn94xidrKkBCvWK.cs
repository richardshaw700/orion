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
using zLGfTg8qMbPmqnv69o;

namespace sX02IJN7NqxvB7iKPK;

internal class Dpdrn94xidrKkBCvWK
{
	private delegate void q9ctJLQKonHG1nMJqn(object o);

	internal class jZwF7eZM4Ls3JOyEtA : Attribute
	{
		internal class JnHgVCGgtt1dM2uLQy<erugwdLuKPVQccoqRA>
		{
			public JnHgVCGgtt1dM2uLQy()
			{
				WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
				base._002Ector();
			}
		}

		[jZwF7eZM4Ls3JOyEtA(typeof(JnHgVCGgtt1dM2uLQy<object>[]))]
		public jZwF7eZM4Ls3JOyEtA(object P_0)
		{
		}
	}

	internal class JCFA1G2lGgD62Bth6o
	{
		[jZwF7eZM4Ls3JOyEtA(typeof(jZwF7eZM4Ls3JOyEtA.JnHgVCGgtt1dM2uLQy<object>[]))]
		internal static string B5yOjGO3Rg(string P_0, string P_1)
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
			byte[] iV = ddfKSAbCui(Encoding.Unicode.GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = edXK0DYd4A();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint iNqBuUXhDuhnFqKlYb(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr YhQZHqIbyaJ76KCp26();

	internal struct UCeRFRkQq4inOsKuSf
	{
		internal bool PDfOY7Q7kK;

		internal byte[] mUROyq8Zv0;
	}

	internal class IlQh2dMwmIoEkWkbwL
	{
		private BinaryReader Rk6O4qfCJm;

		public IlQh2dMwmIoEkWkbwL(Stream P_0)
		{
			Rk6O4qfCJm = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream vPnH8m8TvR()
		{
			return Rk6O4qfCJm.BaseStream;
		}

		internal byte[] J6PObPLUuS(int P_0)
		{
			return Rk6O4qfCJm.ReadBytes(P_0);
		}

		internal int sY6Om7QWlk(byte[] P_0, int P_1, int P_2)
		{
			return Rk6O4qfCJm.Read(P_0, P_1, P_2);
		}

		internal int t18OCJOTro()
		{
			return Rk6O4qfCJm.ReadInt32();
		}

		internal void xNmO5PLwsQ()
		{
			Rk6O4qfCJm.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr VSen7Rp4q4bhAyEN4X(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr kmBwB0UuJwVdtxBg14(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int eIgI9wi9h1FmQKIV3t(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int i0EVdgaR44y2NDSC6b(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr nCfcFQ3NJq4fbykbb6(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int AKhhRkAniycj1w7TcO(IntPtr ptr);

	[Flags]
	private enum yG6L2q6EqvlsCAgidW
	{

	}

	private static bool dbtKVhaL7O;

	internal static RSACryptoServiceProvider R5iOcs3pGa;

	private static Dictionary<int, int> dGWOKXBBHI;

	private static byte[] HoHOhGHSs4;

	private static object TwFOrK3qhF;

	private static int mlkODWNZvU;

	private static SortedList NYNOeivyN8;

	internal static iNqBuUXhDuhnFqKlYb MlyOHn2Wdx;

	private static bool cKdOgma5bB;

	private static bool blvOSMsSIN;

	private static int C3ROEt9Gf7;

	private static int[] fZNO9byH4g;

	private static IntPtr nAJOvoxUVN;

	internal static Hashtable YIwO7OpfOd;

	private static long KqOOs1tJYa;

	private static eIgI9wi9h1FmQKIV3t cKVOBCafcA;

	private static int IjEORVZusQ;

	private static byte[] zWnOwrHHms;

	private static bool YULOPp2gab;

	private static kmBwB0UuJwVdtxBg14 ICAO1M7JN3;

	private static IntPtr A8GOljh6mT;

	[jZwF7eZM4Ls3JOyEtA(typeof(jZwF7eZM4Ls3JOyEtA.JnHgVCGgtt1dM2uLQy<object>[]))]
	private static bool EfIOfID59T;

	private static uint[] b5vKnrFCJ8;

	internal static iNqBuUXhDuhnFqKlYb cbSOWrooI5;

	private static IntPtr jYDOuHCT79;

	private static VSen7Rp4q4bhAyEN4X WQFOdeHKH8;

	private static bool yUnOtBkI7t;

	private static int HnFO0UcIOE;

	internal static Assembly HbqK8OFd3R;

	private static IntPtr MpPOFdW2yN;

	private static AKhhRkAniycj1w7TcO ho7OoJeuVC;

	private static i0EVdgaR44y2NDSC6b PUoOqoo5Lt;

	private static byte[] su1OTpmidA;

	private static long QIhOxDP16w;

	private static nCfcFQ3NJq4fbykbb6 l4BOJMlAlS;

	private static object NCMOOnp7w8;

	private static bool MvCKzlw1oF;

	static Dpdrn94xidrKkBCvWK()
	{
		dbtKVhaL7O = false;
		HbqK8OFd3R = typeof(Dpdrn94xidrKkBCvWK).Assembly;
		b5vKnrFCJ8 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		MvCKzlw1oF = false;
		yUnOtBkI7t = false;
		zWnOwrHHms = new byte[0];
		R5iOcs3pGa = null;
		dGWOKXBBHI = null;
		NCMOOnp7w8 = new object();
		su1OTpmidA = new byte[0];
		HoHOhGHSs4 = new byte[0];
		jYDOuHCT79 = IntPtr.Zero;
		A8GOljh6mT = IntPtr.Zero;
		TwFOrK3qhF = new string[0];
		fZNO9byH4g = new int[0];
		mlkODWNZvU = 1;
		YULOPp2gab = false;
		NYNOeivyN8 = new SortedList();
		IjEORVZusQ = 0;
		KqOOs1tJYa = 0L;
		cbSOWrooI5 = null;
		MlyOHn2Wdx = null;
		QIhOxDP16w = 0L;
		HnFO0UcIOE = 0;
		cKdOgma5bB = false;
		blvOSMsSIN = false;
		C3ROEt9Gf7 = 0;
		nAJOvoxUVN = IntPtr.Zero;
		EfIOfID59T = false;
		YIwO7OpfOd = new Hashtable();
		WQFOdeHKH8 = null;
		ICAO1M7JN3 = null;
		cKVOBCafcA = null;
		PUoOqoo5Lt = null;
		l4BOJMlAlS = null;
		ho7OoJeuVC = null;
		MpPOFdW2yN = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void v42Xwo8lIYePj()
	{
	}

	internal static byte[] LImKPNE6rK(byte[] P_0)
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
			vxMKekEZiX(ref num7, num8, num9, num10, 0u, 7, 1u, array);
			vxMKekEZiX(ref num10, num7, num8, num9, 1u, 12, 2u, array);
			vxMKekEZiX(ref num9, num10, num7, num8, 2u, 17, 3u, array);
			vxMKekEZiX(ref num8, num9, num10, num7, 3u, 22, 4u, array);
			vxMKekEZiX(ref num7, num8, num9, num10, 4u, 7, 5u, array);
			vxMKekEZiX(ref num10, num7, num8, num9, 5u, 12, 6u, array);
			vxMKekEZiX(ref num9, num10, num7, num8, 6u, 17, 7u, array);
			vxMKekEZiX(ref num8, num9, num10, num7, 7u, 22, 8u, array);
			vxMKekEZiX(ref num7, num8, num9, num10, 8u, 7, 9u, array);
			vxMKekEZiX(ref num10, num7, num8, num9, 9u, 12, 10u, array);
			vxMKekEZiX(ref num9, num10, num7, num8, 10u, 17, 11u, array);
			vxMKekEZiX(ref num8, num9, num10, num7, 11u, 22, 12u, array);
			vxMKekEZiX(ref num7, num8, num9, num10, 12u, 7, 13u, array);
			vxMKekEZiX(ref num10, num7, num8, num9, 13u, 12, 14u, array);
			vxMKekEZiX(ref num9, num10, num7, num8, 14u, 17, 15u, array);
			vxMKekEZiX(ref num8, num9, num10, num7, 15u, 22, 16u, array);
			Lf5KRVdVg2(ref num7, num8, num9, num10, 1u, 5, 17u, array);
			Lf5KRVdVg2(ref num10, num7, num8, num9, 6u, 9, 18u, array);
			Lf5KRVdVg2(ref num9, num10, num7, num8, 11u, 14, 19u, array);
			Lf5KRVdVg2(ref num8, num9, num10, num7, 0u, 20, 20u, array);
			Lf5KRVdVg2(ref num7, num8, num9, num10, 5u, 5, 21u, array);
			Lf5KRVdVg2(ref num10, num7, num8, num9, 10u, 9, 22u, array);
			Lf5KRVdVg2(ref num9, num10, num7, num8, 15u, 14, 23u, array);
			Lf5KRVdVg2(ref num8, num9, num10, num7, 4u, 20, 24u, array);
			Lf5KRVdVg2(ref num7, num8, num9, num10, 9u, 5, 25u, array);
			Lf5KRVdVg2(ref num10, num7, num8, num9, 14u, 9, 26u, array);
			Lf5KRVdVg2(ref num9, num10, num7, num8, 3u, 14, 27u, array);
			Lf5KRVdVg2(ref num8, num9, num10, num7, 8u, 20, 28u, array);
			Lf5KRVdVg2(ref num7, num8, num9, num10, 13u, 5, 29u, array);
			Lf5KRVdVg2(ref num10, num7, num8, num9, 2u, 9, 30u, array);
			Lf5KRVdVg2(ref num9, num10, num7, num8, 7u, 14, 31u, array);
			Lf5KRVdVg2(ref num8, num9, num10, num7, 12u, 20, 32u, array);
			ILLKslRHCv(ref num7, num8, num9, num10, 5u, 4, 33u, array);
			ILLKslRHCv(ref num10, num7, num8, num9, 8u, 11, 34u, array);
			ILLKslRHCv(ref num9, num10, num7, num8, 11u, 16, 35u, array);
			ILLKslRHCv(ref num8, num9, num10, num7, 14u, 23, 36u, array);
			ILLKslRHCv(ref num7, num8, num9, num10, 1u, 4, 37u, array);
			ILLKslRHCv(ref num10, num7, num8, num9, 4u, 11, 38u, array);
			ILLKslRHCv(ref num9, num10, num7, num8, 7u, 16, 39u, array);
			ILLKslRHCv(ref num8, num9, num10, num7, 10u, 23, 40u, array);
			ILLKslRHCv(ref num7, num8, num9, num10, 13u, 4, 41u, array);
			ILLKslRHCv(ref num10, num7, num8, num9, 0u, 11, 42u, array);
			ILLKslRHCv(ref num9, num10, num7, num8, 3u, 16, 43u, array);
			ILLKslRHCv(ref num8, num9, num10, num7, 6u, 23, 44u, array);
			ILLKslRHCv(ref num7, num8, num9, num10, 9u, 4, 45u, array);
			ILLKslRHCv(ref num10, num7, num8, num9, 12u, 11, 46u, array);
			ILLKslRHCv(ref num9, num10, num7, num8, 15u, 16, 47u, array);
			ILLKslRHCv(ref num8, num9, num10, num7, 2u, 23, 48u, array);
			TVUKWk0PPc(ref num7, num8, num9, num10, 0u, 6, 49u, array);
			TVUKWk0PPc(ref num10, num7, num8, num9, 7u, 10, 50u, array);
			TVUKWk0PPc(ref num9, num10, num7, num8, 14u, 15, 51u, array);
			TVUKWk0PPc(ref num8, num9, num10, num7, 5u, 21, 52u, array);
			TVUKWk0PPc(ref num7, num8, num9, num10, 12u, 6, 53u, array);
			TVUKWk0PPc(ref num10, num7, num8, num9, 3u, 10, 54u, array);
			TVUKWk0PPc(ref num9, num10, num7, num8, 10u, 15, 55u, array);
			TVUKWk0PPc(ref num8, num9, num10, num7, 1u, 21, 56u, array);
			TVUKWk0PPc(ref num7, num8, num9, num10, 8u, 6, 57u, array);
			TVUKWk0PPc(ref num10, num7, num8, num9, 15u, 10, 58u, array);
			TVUKWk0PPc(ref num9, num10, num7, num8, 6u, 15, 59u, array);
			TVUKWk0PPc(ref num8, num9, num10, num7, 13u, 21, 60u, array);
			TVUKWk0PPc(ref num7, num8, num9, num10, 4u, 6, 61u, array);
			TVUKWk0PPc(ref num10, num7, num8, num9, 11u, 10, 62u, array);
			TVUKWk0PPc(ref num9, num10, num7, num8, 2u, 15, 63u, array);
			TVUKWk0PPc(ref num8, num9, num10, num7, 9u, 21, 64u, array);
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

	private static void vxMKekEZiX(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + lgFKHottVK(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + b5vKnrFCJ8[P_6 - 1], P_5);
	}

	private static void Lf5KRVdVg2(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + lgFKHottVK(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + b5vKnrFCJ8[P_6 - 1], P_5);
	}

	private static void ILLKslRHCv(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + lgFKHottVK(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + b5vKnrFCJ8[P_6 - 1], P_5);
	}

	private static void TVUKWk0PPc(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + lgFKHottVK(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + b5vKnrFCJ8[P_6 - 1], P_5);
	}

	private static uint lgFKHottVK(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool hKvKxHyKBw()
	{
		if (!MvCKzlw1oF)
		{
			hEgKgoycv5();
			MvCKzlw1oF = true;
		}
		return yUnOtBkI7t;
	}

	internal static SymmetricAlgorithm edXK0DYd4A()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (hKvKxHyKBw())
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

	internal static void hEgKgoycv5()
	{
		try
		{
			yUnOtBkI7t = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] ddfKSAbCui(byte[] P_0)
	{
		if (!hKvKxHyKBw())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return LImKPNE6rK(P_0);
	}

	internal static void wsWKES4f3H(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			WIsKvPFB3o(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void WIsKvPFB3o(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint Cg1KfuoM1I(uint P_0, int P_1, long P_2, BinaryReader P_3)
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

	public static void t0xK7B3c8C(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (dGWOKXBBHI == null)
			{
				lock (NCMOOnp7w8)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(Dpdrn94xidrKkBCvWK).Assembly.GetManifestResourceStream("TxQ4oAqB0COCRbCVRl.qZVlncEfAVV2wrXVcU"));
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
							num3 += kHBKBkKnxK(num3);
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
						IlQh2dMwmIoEkWkbwL ilQh2dMwmIoEkWkbwL = new IlQh2dMwmIoEkWkbwL(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = ilQh2dMwmIoEkWkbwL.t18OCJOTro();
							int value = ilQh2dMwmIoEkWkbwL.t18OCJOTro();
							dictionary.Add(key, value);
						}
						ilQh2dMwmIoEkWkbwL.xNmO5PLwsQ();
					}
					dGWOKXBBHI = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = dGWOKXBBHI[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)typeof(Dpdrn94xidrKkBCvWK).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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

	private static uint D4YK1g7DG0(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint kHBKBkKnxK(uint P_0)
	{
		return 0u;
	}

	internal static void QfcKqq78fX()
	{
	}

	[jZwF7eZM4Ls3JOyEtA(typeof(jZwF7eZM4Ls3JOyEtA.JnHgVCGgtt1dM2uLQy<object>[]))]
	internal static string vZjKJCNxST(int P_0)
	{
		int num = 344;
		uint num27 = default(uint);
		Stream stream = default(Stream);
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		int num14 = default(int);
		int num28 = default(int);
		int num15 = default(int);
		uint num17 = default(uint);
		byte[] array3 = default(byte[]);
		byte[] publicKeyToken = default(byte[]);
		int num19 = default(int);
		int num23 = default(int);
		int num24 = default(int);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] array4 = default(byte[]);
		int num31 = default(int);
		byte[] array5 = default(byte[]);
		int num21 = default(int);
		uint num22 = default(uint);
		int count = default(int);
		int num35 = default(int);
		IlQh2dMwmIoEkWkbwL ilQh2dMwmIoEkWkbwL = default(IlQh2dMwmIoEkWkbwL);
		int num18 = default(int);
		uint num32 = default(uint);
		int num25 = default(int);
		uint num20 = default(uint);
		byte[] array6 = default(byte[]);
		int num16 = default(int);
		uint num30 = default(uint);
		uint num4 = default(uint);
		int num26 = default(int);
		CryptoStream cryptoStream = default(CryptoStream);
		uint num29 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 57:
					num27 = 255u;
					num2 = 120;
					continue;
				case 36:
					stream.Close();
					num2 = 210;
					continue;
				case 405:
					array2[7] = 105;
					num2 = 12;
					continue;
				case 408:
					array[14] = 176;
					num2 = 306;
					continue;
				case 152:
					array[22] = 129;
					num2 = 393;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 7:
					array[15] = 134;
					num2 = 205;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 279:
					array[29] = (byte)num14;
					num2 = 348;
					continue;
				case 249:
					if (num28 > 0)
					{
						num2 = 117;
						continue;
					}
					goto case 325;
				case 410:
					num15 = 216 - 72;
					num2 = 185;
					continue;
				case 266:
					return "";
				case 409:
					num17 = 0u;
					num2 = 201;
					continue;
				case 372:
					array3[9] = publicKeyToken[4];
					num2 = 361;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 226:
					array2[13] = (byte)num15;
					num = 377;
					break;
				case 95:
					array2[11] = 155;
					num2 = 251;
					if (raoPcGVL00A5HYKgEA() != null)
					{
						num2 = 28;
					}
					continue;
				case 261:
					if (num28 > 0)
					{
						num2 = 368;
						if (!sLxgdhBqqHGrrg8AYE())
						{
							num2 = 353;
						}
						continue;
					}
					goto case 106;
				case 275:
					if (num19 > 0)
					{
						num2 = 336;
						if (sLxgdhBqqHGrrg8AYE())
						{
							continue;
						}
						break;
					}
					goto case 206;
				case 287:
					num15 = 213 - 71;
					num2 = 15;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 316:
					array[8] = 230;
					num = 23;
					break;
				case 286:
					num15 = 154 - 51;
					num = 193;
					break;
				case 89:
					array2[10] = 199;
					num2 = 307;
					continue;
				case 75:
					array[22] = 100;
					num2 = 140;
					continue;
				case 293:
					array3[3] = publicKeyToken[1];
					num2 = 44;
					continue;
				case 173:
					num15 = 36 + 115;
					num2 = 87;
					continue;
				case 191:
					array[0] = (byte)num14;
					num2 = 236;
					continue;
				case 62:
					num14 = 164 - 54;
					num2 = 17;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 15:
					array2[15] = (byte)num15;
					num2 = 123;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 256:
					num14 = 51 + 68;
					num2 = 4;
					if (raoPcGVL00A5HYKgEA() != null)
					{
						num2 = 3;
					}
					continue;
				case 394:
					array[16] = 162;
					num2 = 74;
					continue;
				case 71:
					array2[1] = (byte)num15;
					num2 = 387;
					continue;
				case 378:
					array[29] = 169;
					num2 = 62;
					continue;
				case 244:
					array[25] = 114;
					num2 = 128;
					continue;
				case 147:
					num14 = 143 - 47;
					num2 = 412;
					continue;
				case 110:
					array[5] = (byte)num14;
					num2 = 322;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 85:
					num19 = 0;
					num2 = 51;
					continue;
				case 344:
					if (su1OTpmidA.Length == 0)
					{
						num2 = 343;
						continue;
					}
					goto case 288;
				case 73:
					array[3] = 84;
					num2 = 65;
					if (!sLxgdhBqqHGrrg8AYE())
					{
						num2 = 10;
					}
					continue;
				case 66:
					num14 = 35 + 4;
					num2 = 200;
					continue;
				case 79:
					array[27] = 114;
					num2 = 39;
					continue;
				case 379:
					array[1] = (byte)num14;
					num2 = 3;
					continue;
				case 251:
					array2[11] = 43;
					num2 = 61;
					continue;
				case 397:
					array2[8] = 106;
					num2 = 111;
					continue;
				case 395:
					array[27] = (byte)num14;
					num2 = 43;
					continue;
				case 49:
					array[24] = (byte)num14;
					num2 = 339;
					if (!sLxgdhBqqHGrrg8AYE())
					{
						num2 = 249;
					}
					continue;
				case 370:
					num14 = 156 - 80;
					num = 216;
					break;
				case 183:
					array[12] = 133;
					num2 = 203;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 91:
					num14 = 110 + 88;
					num2 = 267;
					if (!sLxgdhBqqHGrrg8AYE())
					{
						num2 = 197;
					}
					continue;
				case 354:
					array[4] = (byte)num14;
					num2 = 180;
					continue;
				case 329:
					array[18] = 111;
					num2 = 181;
					continue;
				case 263:
				case 400:
					if (num23 >= num24)
					{
						num2 = 1;
						if (sLxgdhBqqHGrrg8AYE())
						{
							continue;
						}
						break;
					}
					goto case 231;
				case 67:
					array2[7] = (byte)num15;
					num2 = 221;
					continue;
				case 390:
					num15 = 10 + 35;
					num2 = 388;
					continue;
				case 133:
					array[1] = 91;
					num2 = 373;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 204:
					symmetricAlgorithm.Mode = CipherMode.CBC;
					num2 = 27;
					if (sLxgdhBqqHGrrg8AYE())
					{
						num2 = 45;
					}
					continue;
				case 45:
					transform = symmetricAlgorithm.CreateDecryptor(array4, array3);
					num2 = 334;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 366:
					array[28] = (byte)num14;
					num = 70;
					break;
				case 48:
					num14 = 180 - 60;
					num = 413;
					break;
				case 291:
					array2[7] = 158;
					num2 = 405;
					continue;
				case 238:
					array[31] = (byte)num14;
					num2 = 118;
					continue;
				case 138:
					array[15] = 60;
					num2 = 370;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 232:
					array[3] = 82;
					num2 = 230;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 139:
					array[6] = (byte)num14;
					num2 = 173;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						num2 = 184;
					}
					continue;
				case 326:
					array2[0] = 144;
					num2 = 18;
					if (sLxgdhBqqHGrrg8AYE())
					{
						num2 = 59;
					}
					continue;
				case 100:
					array[23] = (byte)num14;
					num2 = 302;
					continue;
				case 401:
					publicKeyToken = HbqK8OFd3R.GetName().GetPublicKeyToken();
					num2 = 385;
					continue;
				case 254:
					num14 = 33 + 95;
					num2 = 276;
					continue;
				case 9:
				case 51:
					if (num19 >= num28)
					{
						num2 = 190;
						if (raoPcGVL00A5HYKgEA() == null)
						{
							continue;
						}
						break;
					}
					goto case 275;
				case 59:
					num15 = 29 + 55;
					num2 = 225;
					continue;
				case 332:
					array[19] = 119;
					num2 = 376;
					continue;
				case 153:
					array[13] = 174;
					num2 = 61;
					if (sLxgdhBqqHGrrg8AYE())
					{
						num2 = 256;
					}
					continue;
				case 157:
					num14 = 240 - 80;
					num2 = 311;
					continue;
				case 6:
					array2[6] = (byte)num15;
					num2 = 303;
					continue;
				case 268:
					array[28] = (byte)num14;
					num2 = 77;
					if (raoPcGVL00A5HYKgEA() != null)
					{
						num2 = 8;
					}
					continue;
				case 330:
					array[1] = (byte)num14;
					num2 = 294;
					continue;
				case 220:
					array2[5] = (byte)num15;
					num2 = 314;
					continue;
				case 381:
					array2[4] = 82;
					num2 = 115;
					continue;
				case 399:
					array[22] = (byte)num14;
					num2 = 152;
					continue;
				case 164:
					if (num28 > 0)
					{
						num2 = 69;
						continue;
					}
					goto case 167;
				case 18:
					array[12] = (byte)num14;
					num2 = 300;
					continue;
				case 142:
					array3[1] = publicKeyToken[0];
					num2 = 293;
					continue;
				case 132:
					num14 = 57 + 106;
					num2 = 366;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 137:
					array2[13] = 129;
					num2 = 84;
					if (sLxgdhBqqHGrrg8AYE())
					{
						num2 = 144;
					}
					continue;
				case 245:
					array2 = new byte[16];
					num2 = 10;
					continue;
				case 117:
					num24++;
					num2 = 325;
					continue;
				case 35:
					array[17] = (byte)num14;
					num2 = 341;
					continue;
				case 181:
					num14 = 23 + 115;
					num2 = 47;
					continue;
				case 120:
					num31 = 0;
					num2 = 278;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 114:
					array3 = array2;
					num2 = 41;
					continue;
				case 124:
					num14 = 89 + 82;
					num2 = 396;
					continue;
				case 250:
					array2[1] = (byte)num15;
					num2 = 298;
					continue;
				case 113:
					array5[num21 + 1] = (byte)((num22 & 0xFF00) >> 8);
					num2 = 72;
					continue;
				case 294:
					num14 = 59 + 7;
					num2 = 379;
					continue;
				case 112:
					num14 = 104 - 76;
					num2 = 208;
					continue;
				case 361:
					array3[11] = publicKeyToken[5];
					num2 = 315;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 83:
					num15 = 16 + 63;
					num2 = 229;
					continue;
				case 385:
					if (publicKeyToken != null)
					{
						num2 = 22;
						if (!sLxgdhBqqHGrrg8AYE())
						{
							num2 = 1;
						}
						continue;
					}
					goto case 353;
				case 40:
				{
					string result;
					try
					{
						result = Encoding.Unicode.GetString(su1OTpmidA, P_0 + 4, count);
						int num33 = 0;
						if (!sLxgdhBqqHGrrg8AYE())
						{
							num33 = 0;
						}
						switch (num33)
						{
						case 0:
							break;
						}
					}
					catch
					{
						int num34 = 0;
						if (!sLxgdhBqqHGrrg8AYE())
						{
							num34 = num35;
						}
						switch (num34)
						{
						}
						goto case 266;
					}
					return result;
				}
				case 174:
					num14 = 166 - 99;
					num2 = 354;
					continue;
				case 375:
					array[21] = (byte)num14;
					num2 = 14;
					continue;
				case 143:
					array2[2] = (byte)num15;
					num2 = 145;
					continue;
				case 349:
					array[26] = 111;
					num2 = 29;
					continue;
				case 202:
					num14 = 219 - 73;
					num2 = 325;
					if (sLxgdhBqqHGrrg8AYE())
					{
						num2 = 375;
					}
					continue;
				case 230:
					array[3] = 147;
					num2 = 2;
					continue;
				case 384:
					num14 = 169 - 56;
					num2 = 156;
					continue;
				case 207:
					array2[6] = 203;
					num2 = 352;
					continue;
				case 196:
					num15 = 229 - 76;
					num2 = 369;
					continue;
				case 236:
					num14 = 55 + 87;
					num2 = 295;
					continue;
				case 307:
					array2[10] = 121;
					num2 = 212;
					continue;
				case 414:
					array[25] = 109;
					num2 = 131;
					continue;
				case 358:
					array[12] = (byte)num14;
					num2 = 284;
					if (raoPcGVL00A5HYKgEA() != null)
					{
						num2 = 137;
					}
					continue;
				case 31:
					array[8] = (byte)num14;
					num2 = 177;
					continue;
				case 192:
					num14 = 135 - 45;
					num2 = 86;
					continue;
				case 338:
					ilQh2dMwmIoEkWkbwL.xNmO5PLwsQ();
					num2 = 363;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 76:
					array2[15] = (byte)num15;
					num2 = 247;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 84:
					num14 = 171 - 57;
					num2 = 292;
					continue;
				case 187:
					num15 = 70 + 107;
					num = 54;
					break;
				case 127:
				case 342:
					if (num18 >= num28)
					{
						num2 = 171;
						continue;
					}
					goto case 290;
				case 68:
					num32 = (uint)(num25 * 4);
					num2 = 146;
					continue;
				case 184:
					array[6] = 199;
					num2 = 124;
					continue;
				case 12:
					num15 = 25 + 27;
					num2 = 67;
					continue;
				case 311:
					array[12] = (byte)num14;
					num2 = 15;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						num2 = 151;
					}
					continue;
				case 299:
					num32 = (uint)num21;
					num2 = 64;
					if (!sLxgdhBqqHGrrg8AYE())
					{
						num2 = 51;
					}
					continue;
				case 64:
					num20 = (uint)((array6[num32 + 3] << 24) | (array6[num32 + 2] << 16) | (array6[num32 + 1] << 8) | array6[num32]);
					num2 = 98;
					continue;
				case 392:
					array[10] = (byte)num14;
					num2 = 30;
					continue;
				case 198:
					array2[15] = (byte)num15;
					num2 = 274;
					continue;
				case 109:
					num15 = 130 - 43;
					num2 = 282;
					continue;
				case 25:
					array[14] = (byte)num14;
					num2 = 7;
					continue;
				case 193:
					array2[8] = (byte)num15;
					num = 257;
					break;
				case 371:
					array[2] = 143;
					num2 = 99;
					continue;
				case 125:
					array[9] = 144;
					num2 = 217;
					if (!sLxgdhBqqHGrrg8AYE())
					{
						num2 = 106;
					}
					continue;
				case 292:
					array[23] = (byte)num14;
					num2 = 351;
					continue;
				case 43:
					num14 = 150 - 87;
					num2 = 242;
					continue;
				case 63:
					num15 = 236 - 78;
					num2 = 250;
					continue;
				case 5:
					array[5] = (byte)num14;
					num2 = 243;
					continue;
				case 21:
					num28 = array6.Length % 4;
					num2 = 121;
					continue;
				case 22:
					if (publicKeyToken.Length > 0)
					{
						num = 142;
						break;
					}
					goto case 353;
				case 195:
					array[31] = (byte)num14;
					num2 = 160;
					continue;
				case 360:
					array[28] = 91;
					num2 = 169;
					continue;
				case 353:
					num16 = 0;
					num2 = 252;
					continue;
				case 52:
					num15 = 193 - 64;
					num2 = 6;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 178:
					num14 = 33 + 123;
					num2 = 374;
					continue;
				case 219:
					array[7] = 97;
					num2 = 28;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 55:
					num15 = 124 + 85;
					num2 = 176;
					continue;
				case 38:
					array[3] = 211;
					num2 = 232;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 351:
					num14 = 37 + 2;
					num2 = 126;
					continue;
				case 239:
					array[15] = (byte)num14;
					num2 = 192;
					continue;
				case 14:
					num14 = 251 - 83;
					num = 197;
					break;
				case 260:
					array[0] = 98;
					num2 = 102;
					continue;
				case 303:
					num15 = 8 + 58;
					num2 = 333;
					continue;
				case 94:
					array2[10] = (byte)num15;
					num2 = 356;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 221:
					array2[7] = 48;
					num2 = 286;
					continue;
				case 208:
					array[29] = (byte)num14;
					num2 = 253;
					continue;
				case 380:
					array5 = new byte[array6.Length];
					num2 = 357;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 333:
					array2[6] = (byte)num15;
					num2 = 207;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 289:
					array[18] = 37;
					num2 = 147;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 217:
					num14 = 213 - 71;
					num2 = 50;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 105:
					num15 = 112 + 103;
					num2 = 163;
					continue;
				case 150:
					array2[3] = (byte)num15;
					num2 = 196;
					continue;
				case 206:
					array5[num21 + num19] = (byte)((num30 & num27) >> num31);
					num2 = 237;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 98:
				case 171:
					num4 = num17;
					num2 = 27;
					continue;
				case 301:
					array2[1] = 132;
					num2 = 227;
					if (raoPcGVL00A5HYKgEA() != null)
					{
						num2 = 50;
					}
					continue;
				case 273:
					array6 = su1OTpmidA;
					num2 = 21;
					continue;
				case 156:
					array[24] = (byte)num14;
					num2 = 355;
					if (!sLxgdhBqqHGrrg8AYE())
					{
						num2 = 309;
					}
					continue;
				case 411:
					array[23] = (byte)num14;
					num2 = 170;
					continue;
				case 357:
					num26 = array4.Length / 4;
					num2 = 409;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 47:
					array[18] = (byte)num14;
					num2 = 228;
					continue;
				case 42:
					cryptoStream.Write(array6, 0, array6.Length);
					num2 = 246;
					continue;
				case 334:
					stream = IkaKLCcoeq();
					num2 = 335;
					if (raoPcGVL00A5HYKgEA() != null)
					{
						num2 = 274;
					}
					continue;
				case 321:
					num14 = 191 - 63;
					num2 = 296;
					continue;
				case 257:
					array2[8] = 140;
					num2 = 397;
					continue;
				case 54:
					array2[12] = (byte)num15;
					num2 = 189;
					continue;
				case 215:
					array[4] = (byte)num14;
					num2 = 174;
					continue;
				case 388:
					array2[9] = (byte)num15;
					num2 = 173;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 281:
					num14 = 70 + 107;
					num2 = 116;
					continue;
				case 229:
					array2[9] = (byte)num15;
					num2 = 263;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						num2 = 390;
					}
					continue;
				case 367:
					array3[7] = publicKeyToken[3];
					num2 = 372;
					continue;
				case 396:
					array[6] = (byte)num14;
					num2 = 272;
					continue;
				case 228:
					array[18] = 60;
					num2 = 289;
					continue;
				case 347:
					num20 = 0u;
					num2 = 249;
					continue;
				case 259:
					array[2] = 112;
					num2 = 136;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 391:
					num17 += num29;
					num2 = 88;
					continue;
				case 90:
					num14 = 119 + 112;
					num2 = 215;
					continue;
				case 46:
					array[26] = 101;
					num2 = 254;
					if (!sLxgdhBqqHGrrg8AYE())
					{
						num2 = 60;
					}
					continue;
				case 129:
					array[13] = (byte)num14;
					num2 = 337;
					continue;
				case 37:
					array[13] = (byte)num14;
					num = 166;
					break;
				case 180:
					array[5] = 179;
					num2 = 58;
					continue;
				case 81:
					array[10] = (byte)num14;
					num2 = 146;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						num2 = 264;
					}
					continue;
				case 140:
					array[22] = 83;
					num2 = 84;
					continue;
				case 240:
					num14 = 140 + 112;
					num2 = 389;
					continue;
				case 369:
					array2[3] = (byte)num15;
					num = 350;
					break;
				case 352:
					array2[6] = 176;
					num2 = 291;
					continue;
				case 412:
					array[19] = (byte)num14;
					num2 = 104;
					continue;
				case 65:
					num14 = 160 - 53;
					num2 = 168;
					if (raoPcGVL00A5HYKgEA() != null)
					{
						num2 = 78;
					}
					continue;
				case 278:
					if (num23 == num24 - 1)
					{
						num2 = 164;
						continue;
					}
					goto case 167;
				case 197:
					array[21] = (byte)num14;
					num2 = 310;
					continue;
				case 19:
					if (num23 == num24 - 1)
					{
						num2 = 261;
						if (sLxgdhBqqHGrrg8AYE())
						{
							continue;
						}
						break;
					}
					goto case 106;
				case 80:
					array[28] = 94;
					num2 = 360;
					continue;
				case 39:
					num14 = 36 + 117;
					num = 395;
					break;
				case 188:
					array[29] = (byte)num14;
					num = 378;
					break;
				case 413:
					array[27] = (byte)num14;
					num2 = 22;
					if (sLxgdhBqqHGrrg8AYE())
					{
						num2 = 79;
					}
					continue;
				case 325:
					num32 = 0u;
					num2 = 269;
					continue;
				case 88:
					num18 = 0;
					num2 = 342;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 146:
					num29 = (uint)((array4[num32 + 3] << 24) | (array4[num32 + 2] << 16) | (array4[num32 + 1] << 8) | array4[num32]);
					num2 = 57;
					continue;
				case 234:
					num20 |= array6[^(1 + num18)];
					num2 = 186;
					continue;
				case 309:
					array2[4] = 19;
					num = 345;
					break;
				case 341:
					array[17] = 101;
					num2 = 214;
					continue;
				case 151:
					num14 = 81 + 41;
					num2 = 18;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 96:
					array2[0] = (byte)num15;
					num2 = 326;
					continue;
				case 320:
					num14 = 167 - 124;
					num2 = 386;
					continue;
				case 284:
					num14 = 150 - 50;
					num2 = 277;
					continue;
				case 148:
					num14 = 16 + 25;
					num2 = 139;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 135:
					array[19] = (byte)num14;
					num2 = 211;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 324:
					array[9] = 51;
					num2 = 281;
					continue;
				case 335:
					cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num2 = 42;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 134:
					array[1] = 14;
					num2 = 415;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 56:
					array2[4] = 98;
					num2 = 304;
					continue;
				case 288:
					count = BitConverter.ToInt32(su1OTpmidA, P_0);
					num2 = 40;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 30:
					num14 = 94 + 120;
					num2 = 406;
					continue;
				case 253:
					array[30] = 152;
					num2 = 404;
					continue;
				case 319:
					num14 = 254 - 84;
					num2 = 35;
					continue;
				case 185:
					array2[4] = (byte)num15;
					num2 = 309;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 78:
					array3[15] = publicKeyToken[7];
					num2 = 353;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 104:
					array[19] = 140;
					num2 = 66;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 241:
					array[0] = (byte)num14;
					num2 = 133;
					continue;
				case 337:
					num14 = 100 + 55;
					num2 = 37;
					continue;
				case 170:
					num14 = 151 - 29;
					num2 = 43;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						num2 = 100;
					}
					continue;
				case 377:
					array2[14] = 162;
					num2 = 107;
					continue;
				case 70:
					num14 = 23 + 117;
					num2 = 258;
					continue;
				case 205:
					array[15] = 148;
					num2 = 53;
					if (!sLxgdhBqqHGrrg8AYE())
					{
						num2 = 49;
					}
					continue;
				case 77:
					num14 = 68 + 49;
					num2 = 191;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						num2 = 297;
					}
					continue;
				case 365:
					array[24] = (byte)num14;
					num2 = 384;
					continue;
				case 10:
					num15 = 155 - 51;
					num2 = 96;
					continue;
				case 223:
					array[7] = (byte)num14;
					num = 320;
					break;
				case 115:
					num15 = 25 + 122;
					num2 = 175;
					continue;
				case 398:
					num15 = 83 + 50;
					num2 = 198;
					continue;
				case 177:
					array[9] = 108;
					num2 = 125;
					continue;
				default:
					num15 = 106 + 27;
					num2 = 383;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 258:
					array[28] = (byte)num14;
					num2 = 318;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 13:
					num14 = 16 + 42;
					num2 = 34;
					continue;
				case 58:
					num14 = 58 + 103;
					num2 = 5;
					if (raoPcGVL00A5HYKgEA() != null)
					{
						num2 = 4;
					}
					continue;
				case 387:
					num15 = 10 + 64;
					num2 = 97;
					if (raoPcGVL00A5HYKgEA() != null)
					{
						num2 = 73;
					}
					continue;
				case 373:
					num14 = 26 + 107;
					num2 = 330;
					continue;
				case 355:
					num14 = 177 + 33;
					num2 = 49;
					if (!sLxgdhBqqHGrrg8AYE())
					{
						num2 = 6;
					}
					continue;
				case 211:
					array[20] = 26;
					num2 = 93;
					if (raoPcGVL00A5HYKgEA() != null)
					{
						num2 = 33;
					}
					continue;
				case 101:
					num31 += 8;
					num2 = 206;
					continue;
				case 107:
					array2[14] = 112;
					num2 = 105;
					continue;
				case 179:
					array2[15] = 100;
					num2 = 398;
					continue;
				case 359:
					array[6] = 75;
					num2 = 148;
					continue;
				case 364:
					num14 = 230 - 76;
					num2 = 399;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 29:
					array[26] = 194;
					num2 = 46;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 169:
					num14 = 0 + 59;
					num2 = 279;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 141:
					array[2] = (byte)num14;
					num2 = 259;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 154:
					num15 = 158 + 48;
					num2 = 159;
					continue;
				case 262:
					array[0] = 104;
					num2 = 218;
					continue;
				case 69:
					num20 = 0u;
					num2 = 391;
					continue;
				case 53:
					num14 = 11 + 80;
					num2 = 239;
					continue;
				case 269:
					num23 = 0;
					num2 = 263;
					continue;
				case 283:
					num14 = 126 - 106;
					num2 = 31;
					continue;
				case 402:
					num15 = 77 - 3;
					num2 = 226;
					continue;
				case 313:
					array[14] = 145;
					num2 = 161;
					if (raoPcGVL00A5HYKgEA() != null)
					{
						num2 = 19;
					}
					continue;
				case 252:
				case 271:
					if (num16 >= array3.Length)
					{
						num2 = 20;
						continue;
					}
					goto case 248;
				case 4:
					array[14] = (byte)num14;
					num2 = 233;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 376:
					num14 = 100 + 66;
					num2 = 135;
					if (!sLxgdhBqqHGrrg8AYE())
					{
						num2 = 97;
					}
					continue;
				case 345:
					array2[5] = 136;
					num2 = 60;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 343:
					ilQh2dMwmIoEkWkbwL = new IlQh2dMwmIoEkWkbwL(HbqK8OFd3R.GetManifestResourceStream("hraeVEO4ESf0M6EN1V.rKmUXY0c425tgtibgP"));
					num2 = 82;
					continue;
				case 306:
					num14 = 32 - 27;
					num2 = 25;
					continue;
				case 176:
					array2[10] = (byte)num15;
					num = 89;
					break;
				case 172:
					array[8] = 223;
					num2 = 317;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 86:
					array[15] = (byte)num14;
					num2 = 138;
					continue;
				case 242:
					array[27] = (byte)num14;
					num2 = 132;
					if (!sLxgdhBqqHGrrg8AYE())
					{
						num2 = 47;
					}
					continue;
				case 386:
					array[7] = (byte)num14;
					num2 = 172;
					continue;
				case 99:
					num14 = 59 + 29;
					num2 = 141;
					continue;
				case 214:
					array[17] = 168;
					num = 155;
					break;
				case 41:
					Array.Reverse((Array)array3);
					num = 401;
					break;
				case 368:
					num30 = num17 ^ num20;
					num2 = 85;
					if (raoPcGVL00A5HYKgEA() != null)
					{
						num2 = 54;
					}
					continue;
				case 123:
					array2[15] = 142;
					num2 = 114;
					continue;
				case 235:
					array2[12] = 193;
					num2 = 403;
					if (raoPcGVL00A5HYKgEA() != null)
					{
						num2 = 189;
					}
					continue;
				case 119:
					array[5] = (byte)num14;
					num2 = 356;
					if (sLxgdhBqqHGrrg8AYE())
					{
						num2 = 359;
					}
					continue;
				case 247:
					array2[15] = 152;
					num2 = 287;
					continue;
				case 340:
					array2[13] = (byte)num15;
					num2 = 402;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 103:
					num15 = 168 - 56;
					num2 = 150;
					continue;
				case 23:
					array[8] = 220;
					num2 = 283;
					continue;
				case 305:
					array6 = ilQh2dMwmIoEkWkbwL.J6PObPLUuS((int)ilQh2dMwmIoEkWkbwL.vPnH8m8TvR().Length);
					num2 = 338;
					continue;
				case 121:
					num24 = array6.Length / 4;
					num2 = 380;
					continue;
				case 356:
					array2[10] = 104;
					num2 = 0;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 130:
					array[14] = (byte)num14;
					num2 = 408;
					continue;
				case 102:
					num14 = 114 - 14;
					num2 = 241;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 1:
					su1OTpmidA = array5;
					num = 288;
					break;
				case 265:
					array[30] = 30;
					num2 = 199;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 87:
					array2[9] = (byte)num15;
					num2 = 8;
					continue;
				case 404:
					array[30] = 134;
					num2 = 265;
					continue;
				case 11:
					num21 = num23 * 4;
					num2 = 68;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 72:
					array5[num21 + 2] = (byte)((num22 & 0xFF0000) >> 16);
					num2 = 16;
					continue;
				case 218:
					num14 = 87 + 103;
					num2 = 191;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 302:
					num14 = 147 - 49;
					num2 = 365;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 331:
					array[29] = 110;
					num2 = 112;
					continue;
				case 216:
					array[15] = (byte)num14;
					num2 = 91;
					continue;
				case 362:
					array4 = array;
					num2 = 245;
					continue;
				case 310:
					array[21] = 148;
					num2 = 255;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 315:
					array3[13] = publicKeyToken[6];
					num2 = 78;
					continue;
				case 363:
					array = new byte[32];
					num2 = 262;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 3:
					array[1] = 98;
					num2 = 134;
					continue;
				case 304:
					array2[4] = 146;
					num2 = 381;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 160:
					num14 = 160 + 75;
					num2 = 149;
					continue;
				case 318:
					num14 = 158 - 52;
					num2 = 268;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 167:
					num17 += num29;
					num2 = 299;
					continue;
				case 389:
					array[11] = (byte)num14;
					num2 = 157;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 415:
					array[2] = 121;
					num2 = 371;
					continue;
				case 168:
					array[4] = (byte)num14;
					num2 = 90;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 272:
					num14 = 178 + 32;
					num = 194;
					break;
				case 339:
					num14 = 11 + 122;
					num2 = 213;
					continue;
				case 201:
					num29 = 0u;
					num2 = 60;
					if (sLxgdhBqqHGrrg8AYE())
					{
						num2 = 347;
					}
					continue;
				case 2:
					array[3] = 159;
					num2 = 73;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 20:
					if (P_0 == -1)
					{
						num2 = 280;
						continue;
					}
					goto case 21;
				case 350:
					array2[3] = 171;
					num2 = 56;
					continue;
				case 383:
					array2[11] = (byte)num15;
					num2 = 95;
					continue;
				case 50:
					array[9] = (byte)num14;
					num2 = 324;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 74:
					array[16] = 143;
					num2 = 256;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						num2 = 319;
					}
					continue;
				case 24:
					num15 = 194 - 99;
					num = 323;
					break;
				case 222:
					array2[10] = (byte)num15;
					num2 = 55;
					continue;
				case 131:
					array[25] = 76;
					num2 = 349;
					if (!sLxgdhBqqHGrrg8AYE())
					{
						num2 = 170;
					}
					continue;
				case 106:
					num22 = num17 ^ num20;
					num2 = 346;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 248:
					array4[num16] ^= array3[num16];
					num2 = 33;
					continue;
				case 128:
					array[25] = 140;
					num2 = 171;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						num2 = 414;
					}
					continue;
				case 144:
					num15 = 212 - 70;
					num2 = 340;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 97:
					array2[1] = (byte)num15;
					num2 = 63;
					if (raoPcGVL00A5HYKgEA() != null)
					{
						num2 = 3;
					}
					continue;
				case 277:
					array[12] = (byte)num14;
					num2 = 183;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 243:
					num14 = 252 - 84;
					num2 = 110;
					continue;
				case 16:
					array5[num21 + 3] = (byte)((num22 & 0xFF000000u) >> 24);
					num2 = 224;
					continue;
				case 336:
					num27 <<= 8;
					num2 = 89;
					if (sLxgdhBqqHGrrg8AYE())
					{
						num2 = 101;
					}
					continue;
				case 8:
					num15 = 194 - 64;
					num2 = 222;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 231:
					num25 = num23 % num26;
					num2 = 11;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 190:
				case 224:
					num23++;
					num2 = 400;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 108:
					num15 = 89 + 32;
					num2 = 143;
					continue;
				case 212:
					num15 = 94 + 102;
					num2 = 94;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 225:
					array2[0] = (byte)num15;
					num2 = 142;
					if (sLxgdhBqqHGrrg8AYE())
					{
						num2 = 154;
					}
					continue;
				case 308:
					num14 = 78 + 67;
					num2 = 143;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						num2 = 223;
					}
					continue;
				case 406:
					array[11] = (byte)num14;
					num = 122;
					break;
				case 246:
					cryptoStream.FlushFinalBlock();
					num2 = 312;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 126:
					array[23] = (byte)num14;
					num2 = 407;
					if (!sLxgdhBqqHGrrg8AYE())
					{
						num2 = 347;
					}
					continue;
				case 203:
					array[12] = 80;
					num2 = 182;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 348:
					num14 = 157 - 52;
					num2 = 188;
					continue;
				case 346:
					array5[num21] = (byte)(num22 & 0xFF);
					num2 = 113;
					continue;
				case 264:
					num14 = 131 + 64;
					num2 = 392;
					continue;
				case 276:
					array[26] = (byte)num14;
					num2 = 209;
					if (raoPcGVL00A5HYKgEA() != null)
					{
						num2 = 58;
					}
					continue;
				case 227:
					num15 = 170 - 56;
					num = 71;
					break;
				case 34:
					array[31] = (byte)num14;
					num2 = 32;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 149:
					array[31] = (byte)num14;
					num = 362;
					break;
				case 194:
					array[6] = (byte)num14;
					num2 = 219;
					continue;
				case 116:
					array[10] = (byte)num14;
					num2 = 162;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 393:
					array[22] = 129;
					num = 75;
					break;
				case 182:
					num14 = 71 + 111;
					num2 = 129;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 407:
					num14 = 27 + 122;
					num2 = 411;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 111:
					array2[8] = 94;
					num2 = 83;
					continue;
				case 27:
					num17 = 0u;
					num2 = 270;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 274:
					num15 = 22 + 71;
					num2 = 76;
					continue;
				case 92:
					array2[5] = (byte)num15;
					num2 = 158;
					continue;
				case 82:
					ilQh2dMwmIoEkWkbwL.vPnH8m8TvR().Position = 0L;
					num2 = 305;
					if (raoPcGVL00A5HYKgEA() != null)
					{
						num2 = 138;
					}
					continue;
				case 328:
					num20 <<= 8;
					num2 = 234;
					continue;
				case 403:
					array2[13] = 214;
					num2 = 83;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						num2 = 137;
					}
					continue;
				case 161:
					num14 = 154 - 51;
					num2 = 130;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 297:
					array[28] = (byte)num14;
					num2 = 80;
					continue;
				case 323:
					array2[1] = (byte)num15;
					num2 = 109;
					continue;
				case 285:
					array[3] = 163;
					num2 = 38;
					continue;
				case 374:
					array[20] = (byte)num14;
					num2 = 202;
					continue;
				case 237:
					num19++;
					num2 = 9;
					continue;
				case 298:
					array2[1] = 125;
					num2 = 24;
					continue;
				case 314:
					num15 = 200 - 66;
					num2 = 92;
					continue;
				case 93:
					array[20] = 156;
					num2 = 178;
					continue;
				case 312:
					su1OTpmidA = oSPK2fjEsr(stream);
					num2 = 36;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 296:
					array[7] = (byte)num14;
					num2 = 308;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 26:
					array2[3] = 88;
					num = 103;
					break;
				case 282:
					array2[2] = (byte)num15;
					num = 108;
					break;
				case 60:
					num15 = 248 - 82;
					num2 = 220;
					continue;
				case 295:
					array[0] = (byte)num14;
					num2 = 260;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 28:
					array[7] = 102;
					num2 = 321;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 300:
					num14 = 232 - 77;
					num = 358;
					break;
				case 17:
					array[29] = (byte)num14;
					num2 = 331;
					continue;
				case 280:
					symmetricAlgorithm = edXK0DYd4A();
					num2 = 204;
					continue;
				case 186:
					num18++;
					num2 = 127;
					continue;
				case 118:
					num14 = 150 - 50;
					num2 = 195;
					continue;
				case 175:
					array2[4] = (byte)num15;
					num = 410;
					break;
				case 267:
					array[16] = (byte)num14;
					num2 = 394;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 163:
					array2[14] = (byte)num15;
					num2 = 179;
					continue;
				case 327:
					num17 = num4;
					num2 = 19;
					continue;
				case 189:
					array2[12] = 170;
					num2 = 235;
					if (raoPcGVL00A5HYKgEA() != null)
					{
						num2 = 181;
					}
					continue;
				case 213:
					array[25] = (byte)num14;
					num2 = 121;
					if (sLxgdhBqqHGrrg8AYE())
					{
						num2 = 244;
					}
					continue;
				case 233:
					num14 = 123 + 25;
					num2 = 382;
					continue;
				case 145:
					array2[2] = 165;
					num2 = 76;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						num2 = 165;
					}
					continue;
				case 155:
					array[18] = 204;
					num2 = 222;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						num2 = 329;
					}
					continue;
				case 210:
					cryptoStream.Close();
					num2 = 225;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						num2 = 273;
					}
					continue;
				case 33:
					num16++;
					num2 = 271;
					continue;
				case 158:
					array2[5] = 187;
					num2 = 52;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 165:
					array2[3] = 151;
					num2 = 26;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 322:
					num14 = 39 - 33;
					num2 = 119;
					continue;
				case 209:
					array[27] = 64;
					num2 = 48;
					continue;
				case 136:
					array[2] = 124;
					num2 = 285;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 159:
					array2[0] = (byte)num15;
					num2 = 301;
					if (!sLxgdhBqqHGrrg8AYE())
					{
						num2 = 13;
					}
					continue;
				case 162:
					num14 = 228 - 76;
					num = 81;
					break;
				case 122:
					array[11] = 102;
					num = 240;
					break;
				case 44:
					array3[5] = publicKeyToken[2];
					num2 = 367;
					continue;
				case 199:
					array[31] = 101;
					num2 = 13;
					continue;
				case 382:
					array[14] = (byte)num14;
					num2 = 313;
					if (sLxgdhBqqHGrrg8AYE())
					{
						continue;
					}
					break;
				case 32:
					num14 = 161 - 53;
					num2 = 238;
					continue;
				case 166:
					array[13] = 97;
					num2 = 153;
					continue;
				case 61:
					array2[12] = 133;
					num = 187;
					break;
				case 290:
					if (num18 > 0)
					{
						num2 = 328;
						if (raoPcGVL00A5HYKgEA() != null)
						{
							num2 = 139;
						}
						continue;
					}
					goto case 234;
				case 317:
					array[8] = 91;
					num2 = 316;
					continue;
				case 255:
					array[21] = 97;
					num = 364;
					break;
				case 200:
					array[19] = (byte)num14;
					num2 = 332;
					if (raoPcGVL00A5HYKgEA() == null)
					{
						continue;
					}
					break;
				case 270:
				{
					uint num3 = num4;
					uint num5 = num4;
					uint num6 = 429026890u;
					uint num7 = 1005502539u;
					uint num8 = 995539397u;
					uint num9 = 2063364847u;
					uint num10 = num5;
					uint num11 = 2096094476u;
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
					num2 = 327;
					continue;
				}
				}
				break;
			}
		}
	}

	[jZwF7eZM4Ls3JOyEtA(typeof(jZwF7eZM4Ls3JOyEtA.JnHgVCGgtt1dM2uLQy<object>[]))]
	internal static string yMIKocBuIP(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int wCqKFejh8P()
	{
		return 5;
	}

	private static void f9dKjrknpL()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate KMnKY6LkdD(IntPtr P_0, Type P_1)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object bugKytNhuS(object P_0)
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
	public static extern IntPtr NWUKbxQS8a(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr PnOKmTEU37(IntPtr P_0, string P_1);

	private static IntPtr TMPKC6Ynkv(IntPtr P_0, string P_1, uint P_2)
	{
		if (WQFOdeHKH8 == null)
		{
			IntPtr ptr = PnOKmTEU37(gabMJLhLG1(), "Find ".Trim() + "ResourceA");
			WQFOdeHKH8 = (VSen7Rp4q4bhAyEN4X)Marshal.GetDelegateForFunctionPointer(ptr, typeof(VSen7Rp4q4bhAyEN4X));
		}
		return WQFOdeHKH8(P_0, P_1, P_2);
	}

	private static IntPtr AWbK527OCS(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (ICAO1M7JN3 == null)
		{
			IntPtr ptr = PnOKmTEU37(gabMJLhLG1(), "Virtual ".Trim() + "Alloc");
			ICAO1M7JN3 = (kmBwB0UuJwVdtxBg14)Marshal.GetDelegateForFunctionPointer(ptr, typeof(kmBwB0UuJwVdtxBg14));
		}
		return ICAO1M7JN3(P_0, P_1, P_2, P_3);
	}

	private static int uTpK43MHed(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (cKVOBCafcA == null)
		{
			IntPtr ptr = PnOKmTEU37(gabMJLhLG1(), "Write ".Trim() + "Process ".Trim() + "Memory");
			cKVOBCafcA = (eIgI9wi9h1FmQKIV3t)Marshal.GetDelegateForFunctionPointer(ptr, typeof(eIgI9wi9h1FmQKIV3t));
		}
		return cKVOBCafcA(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int i6kKNNn7Wq(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (PUoOqoo5Lt == null)
		{
			IntPtr ptr = PnOKmTEU37(gabMJLhLG1(), "Virtual ".Trim() + "Protect");
			PUoOqoo5Lt = (i0EVdgaR44y2NDSC6b)Marshal.GetDelegateForFunctionPointer(ptr, typeof(i0EVdgaR44y2NDSC6b));
		}
		return PUoOqoo5Lt(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr ljSKQSttmF(uint P_0, int P_1, uint P_2)
	{
		if (l4BOJMlAlS == null)
		{
			IntPtr ptr = PnOKmTEU37(gabMJLhLG1(), "Open ".Trim() + "Process");
			l4BOJMlAlS = (nCfcFQ3NJq4fbykbb6)Marshal.GetDelegateForFunctionPointer(ptr, typeof(nCfcFQ3NJq4fbykbb6));
		}
		return l4BOJMlAlS(P_0, P_1, P_2);
	}

	private static int LR2KZKihcF(IntPtr P_0)
	{
		if (ho7OoJeuVC == null)
		{
			IntPtr ptr = PnOKmTEU37(gabMJLhLG1(), "Close ".Trim() + "Handle");
			ho7OoJeuVC = (AKhhRkAniycj1w7TcO)Marshal.GetDelegateForFunctionPointer(ptr, typeof(AKhhRkAniycj1w7TcO));
		}
		return ho7OoJeuVC(P_0);
	}

	[SpecialName]
	private static IntPtr gabMJLhLG1()
	{
		if (MpPOFdW2yN == IntPtr.Zero)
		{
			MpPOFdW2yN = NWUKbxQS8a("kernel ".Trim() + "32.dll");
		}
		return MpPOFdW2yN;
	}

	[jZwF7eZM4Ls3JOyEtA(typeof(jZwF7eZM4Ls3JOyEtA.JnHgVCGgtt1dM2uLQy<object>[]))]
	private static byte[] QpOKG2eUol(string P_0)
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

	internal static Stream IkaKLCcoeq()
	{
		return new MemoryStream();
	}

	internal static byte[] oSPK2fjEsr(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	[jZwF7eZM4Ls3JOyEtA(typeof(jZwF7eZM4Ls3JOyEtA.JnHgVCGgtt1dM2uLQy<object>[]))]
	private static byte[] sPQKXFd3kZ(byte[] P_0)
	{
		Stream stream = IkaKLCcoeq();
		SymmetricAlgorithm symmetricAlgorithm = edXK0DYd4A();
		symmetricAlgorithm.Key = new byte[32]
		{
			76, 88, 173, 86, 193, 165, 216, 179, 46, 132,
			2, 199, 214, 189, 74, 176, 216, 171, 155, 90,
			103, 187, 223, 118, 201, 167, 192, 8, 236, 30,
			32, 21
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			155, 133, 212, 94, 156, 60, 19, 158, 99, 12,
			6, 96, 3, 119, 206, 185
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		return oSPK2fjEsr(stream);
	}

	private byte[] d77KIZMGjn()
	{
		return null;
	}

	private byte[] akFKkHwmf0()
	{
		return null;
	}

	private byte[] ldsKMiG2Bh()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] G2PKphyb97()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] nWvKUtCbIG()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] o3tKifV5or()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] BfRKaAZcQV()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] MIIK3HkibT()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] Tk6KAYqZLE()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] tgLK6lUIMt()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static bool sLxgdhBqqHGrrg8AYE()
	{
		return (object)null == null;
	}

	internal static object raoPcGVL00A5HYKgEA()
	{
		return null;
	}
}
