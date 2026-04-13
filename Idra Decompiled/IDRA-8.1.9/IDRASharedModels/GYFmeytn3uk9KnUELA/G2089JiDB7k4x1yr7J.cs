using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using F3frs5SXTsGVtVfuZX;
using RIrlNToRdPZ6Uy0SYo;

namespace GYFmeytn3uk9KnUELA;

internal class G2089JiDB7k4x1yr7J
{
	private enum Jo0kuYXx6APl7GLpOa
	{

	}

	internal class YtBU4T1syJ2qTbbtQH
	{
		private unsafe static uint JDa8qiNTmA(void* P_0, uint P_1)
		{
			uint result = 0u;
			if (BitConverter.IsLittleEndian)
			{
				result = *(uint*)P_0;
			}
			else
			{
				switch (P_1)
				{
				case 4u:
					result = (uint)(*(byte*)P_0 | (((byte*)P_0)[1] << 8) | (((byte*)P_0)[2] << 16) | (((byte*)P_0)[3] << 24));
					break;
				case 3u:
					result = (uint)(*(byte*)P_0 | (((byte*)P_0)[1] << 8) | (((byte*)P_0)[2] << 16));
					break;
				case 2u:
					result = (uint)(*(byte*)P_0 | (((byte*)P_0)[1] << 8));
					break;
				case 1u:
					result = *(byte*)P_0;
					break;
				}
			}
			return result;
		}

		private unsafe static bool X8Q89AQKB8(void* P_0, void* P_1, uint P_2)
		{
			bool flag = true;
			uint num = 0u;
			while (flag && num < P_2)
			{
				flag = ((byte*)P_0)[(int)num] == ((byte*)P_1)[(int)num];
				num++;
			}
			return flag;
		}

		private unsafe static void Mdh8GdDInX(void* P_0, byte P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[(int)num] = (sbyte)P_1;
			}
		}

		private unsafe static void PbU8b6osd3(void* P_0, void* P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[(int)num] = ((sbyte*)P_1)[(int)num];
			}
		}

		private unsafe static void AdN8ORT6JB(byte* P_0, byte* P_1, uint P_2)
		{
			if (BitConverter.IsLittleEndian)
			{
				if (P_2 < 5)
				{
					*(int*)P_0 = *(int*)P_1;
					return;
				}
				byte* ptr = P_0 + (int)P_2;
				while (P_0 < ptr)
				{
					*(int*)P_0 = *(int*)P_1;
					P_0 += 4;
					P_1 += 4;
				}
			}
			else if (P_2 > 8 && P_1 + (int)P_2 < P_0)
			{
				PbU8b6osd3(P_0, P_1, P_2);
			}
			else
			{
				byte* ptr2 = P_0 + (int)P_2;
				while (P_0 < ptr2)
				{
					*P_0 = *P_1;
					P_0++;
					P_1++;
				}
			}
		}

		private unsafe static uint ms98H32PlL(byte[] P_0, uint P_1, Jo0kuYXx6APl7GLpOa P_2)
		{
			uint num = 0u;
			fixed (byte* ptr = P_0)
			{
				num = ((uint*)(ptr + (int)P_1))[(int)P_2];
			}
			return num;
		}

		public static uint hWs8KIorTf(byte[] P_0, uint P_1)
		{
			return ms98H32PlL(P_0, P_1, (Jo0kuYXx6APl7GLpOa)3);
		}

		private unsafe static uint iHq8m8maOd(byte[] P_0, uint P_1, byte[] P_2)
		{
			fixed (byte* ptr = P_0)
			{
				fixed (byte* ptr2 = P_2)
				{
					byte* ptr3 = ptr + (int)P_1;
					uint num = 32u;
					byte* ptr4 = ptr3 + (int)num;
					byte* ptr5 = ptr2;
					uint* ptr6 = (uint*)ptr3;
					byte* ptr7 = ptr2 + (int)JDa8qiNTmA(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16]
					{
						4u, 0u, 1u, 0u, 2u, 0u, 1u, 0u, 3u, 0u,
						1u, 0u, 2u, 0u, 1u, 0u
					};
					byte* ptr8 = ptr7 - 4;
					if (JDa8qiNTmA(ptr6 + 4, 4u) != 1)
					{
						PbU8b6osd3(ptr2, ptr3 + (int)num, JDa8qiNTmA(ptr6 + 3, 4u));
						return JDa8qiNTmA(ptr6 + 3, 4u);
					}
					if (ptr5 >= ptr8)
					{
						ptr4 += 4;
						while (ptr5 < ptr7)
						{
							*ptr5 = *ptr4;
							ptr5++;
							ptr4++;
						}
						return (uint)(ptr5 - ptr2);
					}
					while (true)
					{
						if (num2 == 1)
						{
							num2 = JDa8qiNTmA(ptr4, 4u);
							ptr4 += 4;
						}
						uint num3 = JDa8qiNTmA(ptr4, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								AdN8ORT6JB(ptr5, ptr5 - (int)num4, 3u);
								ptr5 += 3;
								ptr4++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								AdN8ORT6JB(ptr5, ptr5 - (int)num4, 3u);
								ptr5 += 3;
								ptr4 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								AdN8ORT6JB(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr4 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								AdN8ORT6JB(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr4 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								AdN8ORT6JB(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr4 += 4;
							}
							else
							{
								byte b = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFF;
								Mdh8GdDInX(ptr5, b, num5);
								ptr5 += (int)num5;
								ptr4 += 3;
							}
						}
						else
						{
							AdN8ORT6JB(ptr5, ptr4, 4u);
							ptr5 += (int)array[num2 & 0xF];
							ptr4 += (int)array[num2 & 0xF];
							num2 >>= (int)(byte)array[num2 & 0xF];
							if (ptr5 >= ptr8)
							{
								break;
							}
						}
					}
					while (ptr5 < ptr7)
					{
						if (num2 == 1)
						{
							ptr4 += 4;
							num2 = 2147483648u;
						}
						*ptr5 = *ptr4;
						ptr5++;
						ptr4++;
						num2 >>= 1;
					}
					return (uint)(ptr5 - ptr2);
				}
			}
		}

		internal static object AVv87raHw5(byte[] P_0)
		{
			return typeof(Assembly).GetMethod(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(3326), new Type[1] { typeof(byte[]) }).Invoke(null, new object[1] { P_0 });
		}

		public static byte[] QAT8ruR58h(byte[] P_0, uint P_1)
		{
			uint num = hWs8KIorTf(P_0, P_1);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				iHq8m8maOd(P_0, P_1, array);
			}
			return array;
		}
	}

	private static string[] z858Ek74Ko = new string[0];

	private static object R8p8IcS6dU = null;

	private static bool Ask8QBDCW2 = false;

	private static bool gQR863oryx = false;

	private static void rWJ8L0yBfx()
	{
		int num = 390;
		byte[] array = default(byte[]);
		int num19 = default(int);
		byte[] array3 = default(byte[]);
		uint num15 = default(uint);
		uint num16 = default(uint);
		byte[] array5 = default(byte[]);
		int num30 = default(int);
		uint num31 = default(uint);
		byte[] array7 = default(byte[]);
		mLElmM0kdWGfEg0Q8v.ah0POMuVPMgXQZ6p2t ah0POMuVPMgXQZ6p2t = default(mLElmM0kdWGfEg0Q8v.ah0POMuVPMgXQZ6p2t);
		int num14 = default(int);
		int num22 = default(int);
		int num23 = default(int);
		uint num17 = default(uint);
		uint num33 = default(uint);
		int num20 = default(int);
		int num29 = default(int);
		byte[] array8 = default(byte[]);
		int num25 = default(int);
		int num34 = default(int);
		byte[] array2 = default(byte[]);
		int num28 = default(int);
		uint num18 = default(uint);
		byte[] array4 = default(byte[]);
		uint num4 = default(uint);
		int num27 = default(int);
		byte[] array6 = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		DeflateStream deflateStream = default(DeflateStream);
		int num36 = default(int);
		int num21 = default(int);
		uint num32 = default(uint);
		int num24 = default(int);
		int num26 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 349:
					array[14] = (byte)num19;
					num2 = 326;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 172:
					array3[4] = 175;
					num2 = 204;
					if (yPXmQb3kUJi35enawA() != null)
					{
						num2 = 149;
					}
					continue;
				case 8:
					num15 += num16;
					num2 = 116;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 101:
					array[3] = (byte)num19;
					num2 = 312;
					continue;
				case 15:
					array[7] = (byte)num19;
					num2 = 342;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 240:
					num19 = 44 + 67;
					num2 = 277;
					continue;
				case 390:
					if (Ask8QBDCW2)
					{
						num2 = 389;
						continue;
					}
					goto case 64;
				case 314:
					array[11] = 157;
					num2 = 215;
					continue;
				case 174:
					array[27] = (byte)num19;
					num2 = 395;
					continue;
				case 139:
					array[11] = 161;
					num = 94;
					break;
				case 19:
					array5[num30] = (byte)(num31 & 0xFF);
					num2 = 127;
					continue;
				case 168:
					array[11] = (byte)num19;
					num2 = 316;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 320:
					array7 = (byte[])CPLedTMBdcv04hxeQI(ah0POMuVPMgXQZ6p2t, (int)mMMdFkOnpgeVmDOgYi(Odnp7Yc976FvhO5TEi(ah0POMuVPMgXQZ6p2t)));
					num2 = 117;
					continue;
				case 27:
					array3[10] = (byte)num14;
					num2 = 284;
					continue;
				case 364:
					if (num22 == num23 - 1)
					{
						num2 = 343;
						if (yPXmQb3kUJi35enawA() == null)
						{
							continue;
						}
						break;
					}
					goto case 108;
				case 94:
					array[11] = 143;
					num2 = 314;
					continue;
				case 275:
					array3[5] = 71;
					num2 = 115;
					continue;
				case 152:
					num17 = 0u;
					num2 = 28;
					continue;
				case 149:
				case 163:
				case 398:
					z858Ek74Ko = (string[])EkYPEKVvcq8T7jrSWY((Assembly)R8p8IcS6dU);
					num2 = 82;
					continue;
				case 350:
					num14 = 15 + 46;
					num2 = 173;
					continue;
				case 88:
					array[1] = (byte)num19;
					num2 = 216;
					continue;
				case 225:
					num14 = 128 - 11;
					num2 = 55;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 197:
					array3[15] = (byte)num14;
					num = 153;
					break;
				case 238:
					num15 = 0u;
					num2 = 63;
					if (yPXmQb3kUJi35enawA() != null)
					{
						num2 = 42;
					}
					continue;
				case 301:
					array[31] = (byte)num19;
					num2 = 244;
					continue;
				case 185:
					num19 = 62 + 72;
					num2 = 301;
					continue;
				case 208:
					array[15] = 168;
					num = 353;
					break;
				case 110:
					num19 = 221 + 25;
					num2 = 396;
					if (yPXmQb3kUJi35enawA() != null)
					{
						num2 = 389;
					}
					continue;
				case 246:
					array3[7] = 136;
					num2 = 171;
					continue;
				case 35:
					array[6] = 121;
					num2 = 107;
					if (!Gq1cgVIiKUhADNpwwm())
					{
						num2 = 91;
					}
					continue;
				case 45:
					num19 = 145 - 48;
					num2 = 20;
					continue;
				case 176:
					num19 = 91 + 8;
					num2 = 36;
					if (yPXmQb3kUJi35enawA() == null)
					{
						num2 = 405;
					}
					continue;
				case 373:
					num19 = 216 + 10;
					num2 = 288;
					continue;
				case 190:
					array3[14] = 161;
					num2 = 370;
					continue;
				case 181:
					array[27] = (byte)num19;
					num2 = 344;
					continue;
				case 151:
					array[9] = (byte)num19;
					num2 = 146;
					continue;
				case 22:
					array3[13] = 122;
					num2 = 211;
					continue;
				case 339:
					num33 <<= 8;
					num2 = 279;
					continue;
				case 226:
					array[13] = (byte)num19;
					num2 = 141;
					continue;
				case 233:
					array[18] = (byte)num19;
					num2 = 388;
					if (!Gq1cgVIiKUhADNpwwm())
					{
						num2 = 275;
					}
					continue;
				case 239:
					array[23] = (byte)num19;
					num2 = 407;
					continue;
				case 122:
					array[16] = (byte)num19;
					num2 = 201;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 278:
					array[6] = (byte)num19;
					num2 = 70;
					continue;
				case 78:
					array[27] = (byte)num19;
					num2 = 71;
					continue;
				case 213:
					num19 = 130 - 43;
					num2 = 245;
					continue;
				case 392:
					num19 = 142 - 79;
					num2 = 177;
					if (Gq1cgVIiKUhADNpwwm())
					{
						num2 = 257;
					}
					continue;
				case 79:
				case 293:
					num22++;
					num2 = 47;
					continue;
				case 316:
					array[11] = 253;
					num2 = 159;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 48:
					array[30] = 43;
					num2 = 110;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 204:
					array3[4] = 151;
					num2 = 182;
					continue;
				case 384:
					array3[0] = 180;
					num2 = 350;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 220:
					iiPMBlhqNIIRW1F2Co(Odnp7Yc976FvhO5TEi(ah0POMuVPMgXQZ6p2t), 0L);
					num2 = 274;
					if (!Gq1cgVIiKUhADNpwwm())
					{
						num2 = 157;
					}
					continue;
				case 216:
					num19 = 31 + 25;
					num2 = 254;
					continue;
				case 61:
					array3[2] = (byte)num14;
					num2 = 91;
					continue;
				case 230:
					array3[3] = (byte)num14;
					num2 = 131;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 184:
					num14 = 58 + 104;
					num2 = 311;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 68:
					num20 = 0;
					num2 = 129;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 305:
					num14 = 181 - 60;
					num2 = 328;
					continue;
				case 297:
					num19 = 156 - 52;
					num2 = 176;
					if (Gq1cgVIiKUhADNpwwm())
					{
						num2 = 219;
					}
					continue;
				case 277:
					array[7] = (byte)num19;
					num2 = 118;
					continue;
				case 120:
					array3[6] = 88;
					num2 = 200;
					continue;
				case 65:
					array3[14] = 135;
					num2 = 167;
					continue;
				case 70:
					array[6] = 99;
					num2 = 373;
					continue;
				case 401:
					array[10] = 142;
					num2 = 136;
					continue;
				case 343:
					if (num29 > 0)
					{
						num2 = 169;
						continue;
					}
					goto case 108;
				case 10:
					array8 = array;
					num2 = 332;
					if (!Gq1cgVIiKUhADNpwwm())
					{
						num2 = 125;
					}
					continue;
				case 140:
					array[22] = 116;
					num2 = 270;
					continue;
				case 232:
					array[12] = (byte)num19;
					num2 = 371;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 83:
					array3[12] = (byte)num14;
					num2 = 75;
					continue;
				case 137:
					array[29] = (byte)num19;
					num2 = 260;
					continue;
				case 363:
					array[19] = (byte)num19;
					num2 = 33;
					continue;
				case 381:
					array[29] = (byte)num19;
					num2 = 87;
					continue;
				case 18:
					num14 = 228 - 76;
					num2 = 93;
					continue;
				case 366:
					array3[7] = 160;
					num2 = 246;
					continue;
				case 109:
					num19 = 67 + 62;
					num2 = 151;
					continue;
				case 92:
					num25 = 0;
					num2 = 248;
					continue;
				case 103:
					num14 = 254 - 84;
					num2 = 261;
					continue;
				case 386:
					array[21] = 145;
					num2 = 297;
					continue;
				case 254:
					array[1] = (byte)num19;
					num2 = 3;
					continue;
				case 324:
					array[29] = (byte)num19;
					num2 = 192;
					continue;
				case 119:
					num34 = array8.Length / 4;
					num2 = 238;
					continue;
				case 17:
					num19 = 195 - 65;
					num2 = 363;
					continue;
				case 141:
					num19 = 163 - 54;
					num2 = 51;
					continue;
				case 52:
					array[29] = (byte)num19;
					num2 = 287;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 362:
					num19 = 116 - 96;
					num2 = 359;
					if (yPXmQb3kUJi35enawA() != null)
					{
						num2 = 338;
					}
					continue;
				case 217:
					array[9] = (byte)num19;
					num2 = 213;
					continue;
				case 404:
					array[18] = (byte)num19;
					num = 45;
					break;
				case 63:
					num16 = 0u;
					num2 = 152;
					continue;
				case 194:
					array[1] = 182;
					num2 = 25;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 345:
					num17 |= array2[^(1 + num28)];
					num2 = 237;
					if (!Gq1cgVIiKUhADNpwwm())
					{
						num2 = 38;
					}
					continue;
				case 1:
					array[17] = 166;
					num = 391;
					break;
				case 298:
					array[4] = 213;
					num2 = 294;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 376:
					num16 = (uint)((array8[num18 + 3] << 24) | (array8[num18 + 2] << 16) | (array8[num18 + 1] << 8) | array8[num18]);
					num2 = 403;
					continue;
				case 150:
					num19 = 75 - 10;
					num2 = 340;
					continue;
				case 286:
					if (num22 == num23 - 1)
					{
						num2 = 66;
						if (yPXmQb3kUJi35enawA() == null)
						{
							continue;
						}
						break;
					}
					goto case 13;
				case 125:
					array[13] = 109;
					num2 = 408;
					continue;
				case 2:
					array8[num25] ^= array4[num25];
					num2 = 382;
					continue;
				case 263:
				case 283:
					num4 = num15;
					num2 = 300;
					continue;
				case 97:
					if (num28 > 0)
					{
						num2 = 14;
						continue;
					}
					goto case 345;
				case 54:
					num27 = 1;
					num2 = 92;
					continue;
				case 41:
					array3[11] = (byte)num14;
					num2 = 304;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 351:
					array[26] = 162;
					num2 = 402;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 31:
					array[24] = (byte)num19;
					num2 = 187;
					continue;
				case 313:
					array[5] = 202;
					num2 = 379;
					continue;
				case 173:
					array3[1] = (byte)num14;
					num2 = 256;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 295:
					array[2] = 88;
					num2 = 394;
					continue;
				case 371:
					num19 = 84 + 19;
					num2 = 60;
					continue;
				case 242:
					num19 = 27 + 108;
					num2 = 210;
					continue;
				case 306:
					num19 = 88 + 114;
					num2 = 9;
					continue;
				case 74:
					num14 = 44 + 81;
					num2 = 212;
					continue;
				case 14:
					num17 <<= 8;
					num2 = 345;
					continue;
				case 383:
					array[25] = (byte)num19;
					num2 = 154;
					if (yPXmQb3kUJi35enawA() != null)
					{
						num2 = 7;
					}
					continue;
				case 319:
					num14 = 34 + 118;
					num2 = 83;
					continue;
				case 336:
					array[20] = 146;
					num2 = 360;
					continue;
				case 391:
					num19 = 55 + 36;
					num2 = 126;
					continue;
				case 167:
					array3[14] = 62;
					num2 = 190;
					continue;
				case 189:
					array3[6] = (byte)num14;
					num2 = 120;
					continue;
				case 182:
					num14 = 150 + 16;
					num2 = 229;
					continue;
				case 235:
					array[23] = 249;
					num2 = 6;
					continue;
				case 143:
					num19 = 83 + 60;
					num2 = 381;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 206:
					num19 = 90 + 43;
					num2 = 348;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 395:
					num19 = 143 - 47;
					num2 = 78;
					continue;
				case 271:
					array[3] = 164;
					num2 = 202;
					continue;
				case 274:
					array6 = new byte[0];
					num2 = 296;
					if (Gq1cgVIiKUhADNpwwm())
					{
						num2 = 320;
					}
					continue;
				case 272:
					array[7] = 217;
					num2 = 240;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 6:
					num19 = 248 - 82;
					num2 = 224;
					continue;
				case 30:
					num19 = 218 - 72;
					num = 217;
					break;
				case 39:
					num19 = 233 - 77;
					num2 = 114;
					continue;
				case 325:
					array[28] = (byte)num19;
					num2 = 177;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 95:
					array[20] = 123;
					num2 = 352;
					if (yPXmQb3kUJi35enawA() != null)
					{
						num2 = 44;
					}
					continue;
				case 244:
					array[31] = 58;
					num2 = 296;
					continue;
				case 344:
					array[28] = 190;
					num2 = 84;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 266:
					num19 = 193 - 64;
					num2 = 183;
					if (!Gq1cgVIiKUhADNpwwm())
					{
						num2 = 106;
					}
					continue;
				case 124:
					num19 = 7 + 92;
					num2 = 378;
					continue;
				case 5:
					num19 = 49 + 76;
					num2 = 372;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 107:
					array[6] = 109;
					num2 = 155;
					if (!Gq1cgVIiKUhADNpwwm())
					{
						num2 = 109;
					}
					continue;
				case 250:
					array3[3] = 102;
					num2 = 77;
					continue;
				case 262:
					array[3] = (byte)num19;
					num2 = 271;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 91:
					array3[2] = 222;
					num2 = 85;
					continue;
				case 60:
					array[12] = (byte)num19;
					num2 = 362;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 12:
					R8p8IcS6dU = jtZ36tT2mnoeymZNxn(SM1byl0o4IP9asUD4m(memoryStream));
					num2 = 368;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 260:
					num19 = 239 - 79;
					num2 = 198;
					if (Gq1cgVIiKUhADNpwwm())
					{
						num2 = 268;
					}
					continue;
				case 200:
					array3[6] = 170;
					num2 = 205;
					if (yPXmQb3kUJi35enawA() == null)
					{
						num2 = 258;
					}
					continue;
				case 380:
					num14 = 90 + 55;
					num2 = 61;
					continue;
				case 372:
					array[15] = (byte)num19;
					num = 208;
					break;
				case 209:
					array[5] = (byte)num19;
					num2 = 313;
					continue;
				case 300:
					num15 = 255u;
					num2 = 369;
					if (!Gq1cgVIiKUhADNpwwm())
					{
						num2 = 349;
					}
					continue;
				case 108:
					num18 = (uint)num30;
					num2 = 8;
					continue;
				case 112:
					array[4] = (byte)num19;
					num2 = 150;
					continue;
				case 394:
					array[2] = 121;
					num2 = 111;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 396:
					array[30] = (byte)num19;
					num2 = 166;
					continue;
				case 42:
					array[18] = (byte)num19;
					num2 = 367;
					continue;
				case 264:
					array[23] = 134;
					num2 = 206;
					continue;
				case 382:
					num25++;
					num2 = 354;
					continue;
				case 205:
					num19 = 234 - 78;
					num2 = 226;
					continue;
				case 353:
					array[16] = 126;
					num2 = 38;
					continue;
				case 196:
					array3[15] = (byte)num14;
					num = 285;
					break;
				case 338:
					array[9] = (byte)num19;
					num2 = 30;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 210:
					array[18] = (byte)num19;
					num2 = 53;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 346:
					array2 = array7;
					num2 = 100;
					continue;
				case 245:
					array[9] = (byte)num19;
					num = 265;
					break;
				case 123:
					num14 = 86 + 66;
					num2 = 230;
					continue;
				case 332:
					array3 = new byte[16];
					num2 = 7;
					if (yPXmQb3kUJi35enawA() != null)
					{
						num2 = 2;
					}
					continue;
				case 33:
					array[19] = 27;
					num2 = 95;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 191:
					num19 = 222 - 74;
					num2 = 40;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 145:
					array[15] = 99;
					num2 = 191;
					if (!Gq1cgVIiKUhADNpwwm())
					{
						num2 = 122;
					}
					continue;
				case 322:
					array[25] = 126;
					num2 = 165;
					continue;
				case 321:
					array[8] = 148;
					num = 180;
					break;
				case 258:
					num14 = 57 + 79;
					num2 = 81;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 361:
					num19 = 207 - 69;
					num2 = 349;
					continue;
				case 114:
					array[11] = (byte)num19;
					num2 = 139;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 131:
					num14 = 54 + 5;
					num2 = 148;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 323:
					num19 = 65 + 65;
					num2 = 239;
					if (yPXmQb3kUJi35enawA() != null)
					{
						num2 = 171;
					}
					continue;
				case 280:
					array[2] = (byte)num19;
					num2 = 113;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 337:
					num30 = num22 * 4;
					num2 = 228;
					continue;
				case 59:
					array[26] = (byte)num19;
					num2 = 160;
					continue;
				case 87:
					num19 = 26 + 116;
					num2 = 324;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 105:
					num19 = 209 - 69;
					num2 = 39;
					if (Gq1cgVIiKUhADNpwwm())
					{
						num2 = 101;
					}
					continue;
				case 57:
					array[22] = (byte)num19;
					num2 = 72;
					continue;
				case 156:
					array[8] = (byte)num19;
					num2 = 164;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 268:
					array[30] = (byte)num19;
					num2 = 307;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 370:
					num14 = 69 + 11;
					num2 = 251;
					continue;
				case 203:
					num19 = 81 + 115;
					num2 = 400;
					continue;
				case 219:
					array[21] = (byte)num19;
					num2 = 58;
					continue;
				case 89:
					num14 = 205 - 68;
					num2 = 98;
					if (Gq1cgVIiKUhADNpwwm())
					{
						num2 = 189;
					}
					continue;
				case 388:
					num19 = 207 - 69;
					num = 135;
					break;
				case 72:
					num19 = 137 + 62;
					num2 = 132;
					continue;
				case 175:
					array3[8] = (byte)num14;
					num2 = 282;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 267:
					num19 = 142 + 28;
					num2 = 44;
					if (Gq1cgVIiKUhADNpwwm())
					{
						num2 = 325;
					}
					continue;
				case 352:
					array[20] = 158;
					num2 = 336;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 265:
					array[9] = 119;
					num2 = 109;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 20:
					array[18] = (byte)num19;
					num2 = 242;
					continue;
				case 180:
					array[8] = 68;
					num2 = 99;
					continue;
				case 309:
					array[16] = (byte)num19;
					num2 = 385;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 32:
					array[30] = 52;
					num2 = 48;
					continue;
				case 207:
					array3[9] = 139;
					num2 = 310;
					continue;
				case 144:
					array[0] = 112;
					num = 29;
					break;
				case 303:
					array[29] = (byte)num19;
					num2 = 143;
					if (!Gq1cgVIiKUhADNpwwm())
					{
						num2 = 3;
					}
					continue;
				case 406:
					array5[num30 + 3] = (byte)((num31 & 0xFF000000u) >> 24);
					num2 = 293;
					continue;
				case 307:
					array[30] = 84;
					num2 = 32;
					continue;
				case 252:
					num23++;
					num = 44;
					break;
				case 37:
					array[26] = 118;
					num2 = 351;
					continue;
				case 403:
					num33 = 255u;
					num2 = 204;
					if (yPXmQb3kUJi35enawA() == null)
					{
						num2 = 334;
					}
					continue;
				case 100:
					num29 = array2.Length % 4;
					num2 = 49;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 329:
					array3[13] = 141;
					num = 234;
					break;
				case 365:
					num19 = 247 + 4;
					num2 = 104;
					if (yPXmQb3kUJi35enawA() == null)
					{
						num2 = 156;
					}
					continue;
				case 3:
					array[1] = 114;
					num2 = 69;
					continue;
				case 348:
					array[23] = (byte)num19;
					num2 = 188;
					if (Gq1cgVIiKUhADNpwwm())
					{
						num2 = 323;
					}
					continue;
				case 299:
					array[14] = 41;
					num2 = 361;
					continue;
				case 113:
					array[2] = 64;
					num2 = 295;
					continue;
				case 25:
					num19 = 218 - 72;
					num2 = 280;
					continue;
				case 261:
					array3[5] = (byte)num14;
					num2 = 106;
					if (Gq1cgVIiKUhADNpwwm())
					{
						num2 = 275;
					}
					continue;
				case 69:
					num19 = 55 + 75;
					num2 = 130;
					continue;
				case 40:
					array[15] = (byte)num19;
					num2 = 5;
					continue;
				case 165:
					num19 = 30 - 0;
					num2 = 383;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 400:
					array[25] = (byte)num19;
					num2 = 290;
					continue;
				case 84:
					array[28] = 119;
					num2 = 267;
					if (!Gq1cgVIiKUhADNpwwm())
					{
						num2 = 98;
					}
					continue;
				case 4:
					num19 = 189 - 85;
					num2 = 162;
					continue;
				case 247:
					num14 = 56 + 67;
					num2 = 333;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 98:
					num14 = 215 - 71;
					num = 197;
					break;
				case 357:
					array[7] = (byte)num19;
					num2 = 321;
					continue;
				case 142:
					array[14] = (byte)num19;
					num = 145;
					break;
				case 291:
					array3[8] = 202;
					num = 73;
					break;
				case 408:
					array[13] = 135;
					num = 299;
					break;
				case 347:
					array3[14] = 153;
					num2 = 65;
					if (yPXmQb3kUJi35enawA() != null)
					{
						num2 = 35;
					}
					continue;
				case 335:
					array[18] = 72;
					num2 = 253;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 255:
					array[13] = 131;
					num2 = 205;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 296:
					array[31] = 227;
					num2 = 10;
					continue;
				case 360:
					array[20] = 13;
					num2 = 222;
					if (yPXmQb3kUJi35enawA() != null)
					{
						num2 = 200;
					}
					continue;
				case 377:
					try
					{
						JxTIJYeUt032U7wDuY(deflateStream, memoryStream);
						int num35 = 0;
						if (yPXmQb3kUJi35enawA() != null)
						{
							num35 = num36;
						}
						switch (num35)
						{
						case 0:
							break;
						}
					}
					finally
					{
						if (deflateStream != null)
						{
							int num37 = 0;
							if (yPXmQb3kUJi35enawA() == null)
							{
								num37 = 0;
							}
							while (true)
							{
								switch (num37)
								{
								default:
									cSJUrGmWn3EfsbFeJR(deflateStream);
									num37 = 0;
									if (yPXmQb3kUJi35enawA() == null)
									{
										num37 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 12;
				case 212:
					array3[12] = (byte)num14;
					num2 = 22;
					continue;
				case 223:
					array3[7] = (byte)num14;
					num2 = 291;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 385:
					num19 = 157 - 75;
					num2 = 122;
					if (yPXmQb3kUJi35enawA() != null)
					{
						num2 = 32;
					}
					continue;
				case 128:
					num14 = 89 + 9;
					num2 = 41;
					if (!Gq1cgVIiKUhADNpwwm())
					{
						num2 = 26;
					}
					continue;
				case 102:
					array[10] = (byte)num19;
					num2 = 401;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 330:
					num21 = num22 % num34;
					num2 = 337;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 199:
					array6 = array5;
					num2 = 86;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 276:
					array[14] = (byte)num19;
					num2 = 188;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 93:
					array3[5] = (byte)num14;
					num2 = 103;
					continue;
				case 178:
					num14 = 93 + 103;
					num2 = 161;
					continue;
				case 253:
					num19 = 239 - 79;
					num2 = 404;
					continue;
				case 44:
					num18 = 0u;
					num2 = 317;
					continue;
				case 342:
					num19 = 174 - 69;
					num2 = 357;
					continue;
				case 106:
					array3[0] = (byte)num14;
					num2 = 384;
					continue;
				case 269:
					array3[13] = (byte)num14;
					num2 = 318;
					continue;
				case 16:
					array[5] = 134;
					num2 = 249;
					continue;
				case 28:
					if (num29 > 0)
					{
						num2 = 252;
						continue;
					}
					goto case 44;
				case 171:
					num14 = 105 - 10;
					num2 = 119;
					if (Gq1cgVIiKUhADNpwwm())
					{
						num2 = 223;
					}
					continue;
				case 407:
					array[23] = 136;
					num = 235;
					break;
				case 82:
					Ask8QBDCW2 = true;
					num2 = 54;
					if (Gq1cgVIiKUhADNpwwm())
					{
						num2 = 358;
					}
					continue;
				case 340:
					array[4] = (byte)num19;
					num2 = 12;
					if (yPXmQb3kUJi35enawA() == null)
					{
						num2 = 76;
					}
					continue;
				case 26:
					array[3] = (byte)num19;
					num2 = 298;
					continue;
				case 231:
					array5[num30 + num20] = (byte)((num32 & num33) >> num24);
					num2 = 218;
					continue;
				case 333:
					array3[11] = (byte)num14;
					num2 = 179;
					continue;
				case 34:
					array3[8] = 208;
					num2 = 56;
					continue;
				case 331:
					array[27] = 168;
					num2 = 23;
					continue;
				case 58:
					array[21] = 102;
					num2 = 392;
					continue;
				case 310:
					num14 = 6 + 68;
					num2 = 157;
					continue;
				case 77:
					num14 = 174 - 58;
					num = 292;
					break;
				case 90:
					array3[5] = 132;
					num2 = 18;
					continue;
				case 67:
					R8p8IcS6dU = jtZ36tT2mnoeymZNxn(array6);
					num2 = 163;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 73:
					array3[8] = 217;
					num = 341;
					break;
				case 147:
				case 193:
					R8p8IcS6dU = jtZ36tT2mnoeymZNxn(sBQQGaKxMFCxoVIiVc(array6, 0u));
					num2 = 398;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 36:
					array3[11] = 101;
					num = 225;
					break;
				case 387:
					num19 = 27 + 108;
					num2 = 15;
					continue;
				case 133:
					array3[12] = 177;
					num2 = 74;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 99:
					array[8] = 162;
					num2 = 365;
					continue;
				case 64:
					ah0POMuVPMgXQZ6p2t = new mLElmM0kdWGfEg0Q8v.ah0POMuVPMgXQZ6p2t((Stream)y1tQ9bPalwdvUMNWmq(GZqJFXyLbpkxP9RSNH(typeof(mLElmM0kdWGfEg0Q8v).TypeHandle).Assembly, mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(3248)));
					num2 = 220;
					continue;
				case 121:
					num28 = 0;
					num = 281;
					break;
				case 162:
					array[17] = (byte)num19;
					num = 335;
					break;
				case 118:
					array[7] = 123;
					num2 = 387;
					continue;
				default:
					array5 = new byte[array2.Length];
					num2 = 119;
					continue;
				case 115:
					array3[6] = 140;
					num2 = 89;
					continue;
				case 379:
					array[5] = 57;
					num2 = 12;
					if (yPXmQb3kUJi35enawA() == null)
					{
						num2 = 35;
					}
					continue;
				case 304:
					array3[11] = 65;
					num2 = 247;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 292:
					array3[3] = (byte)num14;
					num2 = 123;
					continue;
				case 136:
					array[10] = 221;
					num2 = 39;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 29:
					array[0] = 121;
					num2 = 50;
					continue;
				case 312:
					num19 = 93 + 36;
					num2 = 262;
					continue;
				case 397:
					if (num20 > 0)
					{
						num2 = 17;
						if (yPXmQb3kUJi35enawA() == null)
						{
							num2 = 339;
						}
						continue;
					}
					goto case 231;
				case 326:
					num19 = 134 - 44;
					num2 = 276;
					if (!Gq1cgVIiKUhADNpwwm())
					{
						num2 = 105;
					}
					continue;
				case 132:
					array[22] = (byte)num19;
					num2 = 264;
					continue;
				case 279:
					num24 += 8;
					num2 = 231;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 341:
					num14 = 44 + 67;
					num2 = 175;
					continue;
				case 356:
					array[10] = 134;
					num2 = 11;
					continue;
				case 9:
					array[7] = (byte)num19;
					num2 = 272;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 127:
					array5[num30 + 1] = (byte)((num31 & 0xFF00) >> 8);
					num2 = 24;
					continue;
				case 201:
					num19 = 67 + 64;
					num2 = 374;
					continue;
				case 51:
					array[13] = (byte)num19;
					num2 = 125;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 405:
					array[25] = (byte)num19;
					num2 = 322;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 111:
					array[2] = 36;
					num2 = 105;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 23:
					array[27] = 61;
					num2 = 266;
					continue;
				case 117:
					array = new byte[32];
					num2 = 144;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 187:
					array[24] = 249;
					num2 = 203;
					continue;
				case 177:
					num19 = 233 - 77;
					num2 = 303;
					if (yPXmQb3kUJi35enawA() != null)
					{
						num2 = 91;
					}
					continue;
				case 46:
					array3[1] = 215;
					num2 = 134;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 259:
					num19 = 69 + 102;
					num2 = 26;
					continue;
				case 164:
					num19 = 209 - 69;
					num2 = 338;
					continue;
				case 155:
					num19 = 218 - 72;
					num2 = 278;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 315:
					array[17] = 113;
					num2 = 1;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 358:
					return;
				case 389:
					return;
				case 317:
					num22 = 0;
					num2 = 104;
					continue;
				case 290:
					array[25] = 102;
					num2 = 176;
					continue;
				case 257:
					array[21] = (byte)num19;
					num2 = 80;
					continue;
				case 153:
					num14 = 143 + 36;
					num2 = 196;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 126:
					array[17] = (byte)num19;
					num2 = 4;
					continue;
				case 13:
					num31 = num15 ^ num17;
					num2 = 19;
					continue;
				case 166:
					array[31] = 152;
					num = 185;
					break;
				case 378:
					array[22] = (byte)num19;
					num2 = 140;
					continue;
				case 7:
					array3[0] = 112;
					num2 = 319;
					if (yPXmQb3kUJi35enawA() == null)
					{
						num2 = 375;
					}
					continue;
				case 289:
					deflateStream = new DeflateStream(new MemoryStream(array6), CompressionMode.Decompress);
					num = 377;
					break;
				case 227:
					switch (num26)
					{
					case 0:
						break;
					default:
						goto IL_2cfa;
					case 1:
						goto IL_33e6;
					}
					goto case 67;
				case 134:
					array3[2] = 84;
					num2 = 380;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 55:
					array3[11] = (byte)num14;
					num2 = 319;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 221:
					num19 = 175 - 58;
					num2 = 19;
					if (yPXmQb3kUJi35enawA() == null)
					{
						num2 = 31;
					}
					continue;
				case 159:
					num19 = 184 - 61;
					num2 = 232;
					continue;
				case 308:
					array3[15] = 113;
					num2 = 98;
					continue;
				case 62:
					num32 = num15 ^ num17;
					num2 = 68;
					continue;
				case 129:
				case 241:
					if (num20 >= num29)
					{
						num = 79;
						break;
					}
					goto case 397;
				case 24:
					array5[num30 + 2] = (byte)((num31 & 0xFF0000) >> 16);
					num = 406;
					break;
				case 282:
					array3[8] = 123;
					num = 34;
					break;
				case 281:
				case 399:
					if (num28 >= num29)
					{
						num2 = 263;
						continue;
					}
					goto case 97;
				case 49:
					num23 = array2.Length / 4;
					num2 = 0;
					if (!Gq1cgVIiKUhADNpwwm())
					{
						num2 = 0;
					}
					continue;
				case 66:
					if (num29 > 0)
					{
						num2 = 62;
						continue;
					}
					goto case 13;
				case 251:
					array3[15] = (byte)num14;
					num2 = 308;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 158:
					array[20] = (byte)num19;
					num = 386;
					break;
				case 249:
					num19 = 251 - 83;
					num2 = 209;
					continue;
				case 43:
					num19 = 95 + 34;
					num2 = 102;
					continue;
				case 138:
					num14 = 4 + 15;
					num2 = 27;
					continue;
				case 311:
					array3[10] = (byte)num14;
					num2 = 138;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 71:
					num19 = 174 - 115;
					num2 = 181;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 287:
					num19 = 195 - 102;
					num2 = 137;
					continue;
				case 256:
					num14 = 82 + 109;
					num2 = 355;
					continue;
				case 157:
					array3[9] = (byte)num14;
					num2 = 46;
					if (Gq1cgVIiKUhADNpwwm())
					{
						num2 = 170;
					}
					continue;
				case 135:
					array[19] = (byte)num19;
					num2 = 17;
					continue;
				case 318:
					array3[13] = 160;
					num2 = 186;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 169:
					num17 = 0u;
					num2 = 302;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 96:
					num15 = num4;
					num2 = 286;
					continue;
				case 161:
					array3[7] = (byte)num14;
					num2 = 305;
					continue;
				case 224:
					array[24] = (byte)num19;
					num2 = 161;
					if (yPXmQb3kUJi35enawA() == null)
					{
						num2 = 221;
					}
					continue;
				case 160:
					array[26] = 72;
					num2 = 37;
					continue;
				case 56:
					num14 = 108 + 92;
					num2 = 195;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 359:
					array[12] = (byte)num19;
					num2 = 255;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 11:
					num19 = 193 - 64;
					num2 = 243;
					continue;
				case 273:
					array[0] = (byte)num19;
					num2 = 236;
					continue;
				case 237:
					num28++;
					num2 = 399;
					continue;
				case 218:
					num20++;
					num2 = 241;
					continue;
				case 288:
					array[6] = (byte)num19;
					num2 = 306;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 284:
					array3[10] = 232;
					num2 = 128;
					continue;
				case 183:
					array[27] = (byte)num19;
					num2 = 393;
					continue;
				case 375:
					num14 = 155 - 51;
					num2 = 106;
					continue;
				case 86:
					num26 = num27;
					num2 = 227;
					if (yPXmQb3kUJi35enawA() != null)
					{
						num2 = 146;
					}
					continue;
				case 327:
					array3[12] = (byte)num14;
					num2 = 133;
					continue;
				case 75:
					num14 = 233 - 77;
					num2 = 327;
					continue;
				case 215:
					num19 = 88 + 111;
					num = 168;
					break;
				case 130:
					array[1] = (byte)num19;
					num2 = 194;
					if (yPXmQb3kUJi35enawA() != null)
					{
						num2 = 151;
					}
					continue;
				case 195:
					array3[9] = (byte)num14;
					num2 = 207;
					continue;
				case 80:
					array[22] = 149;
					num2 = 124;
					continue;
				case 374:
					array[17] = (byte)num19;
					num2 = 315;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 50:
					num19 = 175 + 15;
					num2 = 273;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 248:
				case 354:
					if (num25 >= array4.Length)
					{
						num2 = 346;
						continue;
					}
					goto case 2;
				case 211:
					num14 = 105 + 117;
					num2 = 269;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 198:
					array[26] = (byte)num19;
					num2 = 331;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 170:
					array3[9] = 29;
					num2 = 184;
					if (yPXmQb3kUJi35enawA() != null)
					{
						num2 = 91;
					}
					continue;
				case 334:
					num24 = 0;
					num2 = 364;
					continue;
				case 367:
					num19 = 147 + 13;
					num2 = 214;
					if (yPXmQb3kUJi35enawA() == null)
					{
						num2 = 233;
					}
					continue;
				case 81:
					array3[6] = (byte)num14;
					num2 = 178;
					if (yPXmQb3kUJi35enawA() != null)
					{
						num2 = 58;
					}
					continue;
				case 234:
					array3[14] = 103;
					num2 = 347;
					continue;
				case 47:
				case 104:
					if (num22 >= num23)
					{
						num2 = 199;
						continue;
					}
					goto case 330;
				case 53:
					num19 = 33 + 3;
					num2 = 42;
					continue;
				case 186:
					array3[13] = 119;
					num2 = 329;
					continue;
				case 85:
					array3[2] = 83;
					num2 = 250;
					continue;
				case 21:
					goto IL_33e6;
				case 294:
					num19 = 162 - 54;
					num2 = 112;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 243:
					array[10] = (byte)num19;
					num2 = 43;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 76:
					array[5] = 25;
					num2 = 16;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 228:
					num18 = (uint)(num21 * 4);
					num2 = 376;
					continue;
				case 229:
					array3[4] = (byte)num14;
					num2 = 90;
					if (!Gq1cgVIiKUhADNpwwm())
					{
						num2 = 81;
					}
					continue;
				case 285:
					array4 = array3;
					num2 = 54;
					continue;
				case 368:
					a7LxXJ1HXyEtCXGnhF(memoryStream);
					num2 = 149;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 154:
					num19 = 1 + 54;
					num2 = 59;
					continue;
				case 236:
					num19 = 23 + 82;
					num2 = 88;
					if (yPXmQb3kUJi35enawA() != null)
					{
						num2 = 88;
					}
					continue;
				case 202:
					array[3] = 119;
					num2 = 259;
					continue;
				case 222:
					num19 = 167 - 59;
					num2 = 158;
					continue;
				case 148:
					array3[4] = (byte)num14;
					num2 = 172;
					if (!Gq1cgVIiKUhADNpwwm())
					{
						num2 = 84;
					}
					continue;
				case 192:
					num19 = 117 + 70;
					num2 = 52;
					continue;
				case 270:
					num19 = 188 - 62;
					num2 = 57;
					continue;
				case 328:
					array3[7] = (byte)num14;
					num2 = 214;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 393:
					num19 = 235 - 78;
					num2 = 174;
					if (yPXmQb3kUJi35enawA() == null)
					{
						continue;
					}
					break;
				case 188:
					num19 = 93 + 41;
					num2 = 142;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 214:
					array3[7] = 109;
					num2 = 366;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 402:
					num19 = 125 + 104;
					num2 = 198;
					continue;
				case 38:
					num19 = 114 + 10;
					num2 = 309;
					if (!Gq1cgVIiKUhADNpwwm())
					{
						num2 = 7;
					}
					continue;
				case 355:
					array3[1] = (byte)num14;
					num2 = 46;
					continue;
				case 179:
					array3[11] = 114;
					num2 = 36;
					continue;
				case 116:
					num17 = (uint)((array2[num18 + 3] << 24) | (array2[num18 + 2] << 16) | (array2[num18 + 1] << 8) | array2[num18]);
					num2 = 283;
					continue;
				case 146:
					array[9] = 45;
					num = 356;
					break;
				case 302:
					num15 += num16;
					num2 = 121;
					if (Gq1cgVIiKUhADNpwwm())
					{
						continue;
					}
					break;
				case 369:
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
						num2 = 96;
						continue;
					}
					IL_33e6:
					memoryStream = new MemoryStream();
					num2 = 289;
					continue;
					IL_2cfa:
					num2 = 193;
					continue;
				}
				break;
			}
		}
	}

	internal static string[] cQq8502403(Assembly P_0)
	{
		if (P_0 == typeof(G2089JiDB7k4x1yr7J).Assembly)
		{
			if (!Ask8QBDCW2)
			{
				rWJ8L0yBfx();
			}
			List<string> list = new List<string>();
			list.AddRange(P_0.GetManifestResourceNames());
			list.AddRange(((Assembly)R8p8IcS6dU).GetManifestResourceNames());
			return list.ToArray();
		}
		return P_0.GetManifestResourceNames();
	}

	private static Assembly oRo8kAlR1V(object P_0, ResolveEventArgs P_1)
	{
		if (!Ask8QBDCW2)
		{
			rWJ8L0yBfx();
		}
		string name = P_1.Name;
		for (int i = 0; i < z858Ek74Ko.Length; i++)
		{
			if (z858Ek74Ko[i] == name)
			{
				return (Assembly)R8p8IcS6dU;
			}
		}
		return null;
	}

	public G2089JiDB7k4x1yr7J()
	{
		AppDomain.CurrentDomain.ResourceResolve += oRo8kAlR1V;
		l26t3npZsnUe1qbsCU.vf2WGHkzGx201();
	}

	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!gQR863oryx)
		{
			gQR863oryx = true;
			new G2089JiDB7k4x1yr7J();
		}
	}

	internal static Type GZqJFXyLbpkxP9RSNH(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object y1tQ9bPalwdvUMNWmq(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object Odnp7Yc976FvhO5TEi(object P_0)
	{
		return ((mLElmM0kdWGfEg0Q8v.ah0POMuVPMgXQZ6p2t)P_0).KDikMXewCI();
	}

	internal static void iiPMBlhqNIIRW1F2Co(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long mMMdFkOnpgeVmDOgYi(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object CPLedTMBdcv04hxeQI(object P_0, int P_1)
	{
		return ((mLElmM0kdWGfEg0Q8v.ah0POMuVPMgXQZ6p2t)P_0).yxt8tS5NNP(P_1);
	}

	internal static object jtZ36tT2mnoeymZNxn(object P_0)
	{
		return YtBU4T1syJ2qTbbtQH.AVv87raHw5((byte[])P_0);
	}

	internal static void JxTIJYeUt032U7wDuY(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static void cSJUrGmWn3EfsbFeJR(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object SM1byl0o4IP9asUD4m(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static void a7LxXJ1HXyEtCXGnhF(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	internal static object sBQQGaKxMFCxoVIiVc(object P_0, uint P_1)
	{
		return YtBU4T1syJ2qTbbtQH.QAT8ruR58h((byte[])P_0, P_1);
	}

	internal static object EkYPEKVvcq8T7jrSWY(object P_0)
	{
		return ((Assembly)P_0).GetManifestResourceNames();
	}

	internal static bool Gq1cgVIiKUhADNpwwm()
	{
		return (object)null == null;
	}

	internal static object yPXmQb3kUJi35enawA()
	{
		return null;
	}
}
