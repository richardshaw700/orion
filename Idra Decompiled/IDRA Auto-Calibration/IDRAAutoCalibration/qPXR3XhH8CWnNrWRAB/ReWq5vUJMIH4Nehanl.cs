using System;
using System.Runtime.CompilerServices;
using mMWtJPWctee66WM7q3;

namespace qPXR3XhH8CWnNrWRAB;

internal sealed class ReWq5vUJMIH4Nehanl
{
	[CompilerGenerated]
	private int k7yJ5Yk9EN;

	[CompilerGenerated]
	private int xQbJAYhTXH;

	private readonly int[,] BgZJZI3bXS;

	public ReWq5vUJMIH4Nehanl(int P_0 = 8, int P_1 = 6)
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		k7yJ5Yk9EN = P_0;
		xQbJAYhTXH = P_1;
		BgZJZI3bXS = new int[xQbJAYhTXH, k7yJ5Yk9EN];
		base._002Ector();
	}

	[SpecialName]
	public int mKsJfWMK4R()
	{
		return k7yJ5Yk9EN;
	}

	[SpecialName]
	public int q7NJVWK0Ha()
	{
		return xQbJAYhTXH;
	}

	public void AlgJxw4rCK()
	{
		Array.Clear(BgZJZI3bXS, 0, BgZJZI3bXS.Length);
	}

	public void mhrJsy86aR(double P_0, double P_1)
	{
		int num = Math.Clamp((int)Math.Floor(P_0 * (double)k7yJ5Yk9EN), 0, k7yJ5Yk9EN - 1);
		int num2 = Math.Clamp((int)Math.Floor(P_1 * (double)xQbJAYhTXH), 0, xQbJAYhTXH - 1);
		BgZJZI3bXS[num2, num]++;
	}

	public double XEGJqf6Qtb(int P_0 = 1)
	{
		int num = 0;
		int num2 = xQbJAYhTXH * k7yJ5Yk9EN;
		for (int i = 0; i < xQbJAYhTXH; i++)
		{
			for (int j = 0; j < k7yJ5Yk9EN; j++)
			{
				if (BgZJZI3bXS[i, j] >= P_0)
				{
					num++;
				}
			}
		}
		if (num2 != 0)
		{
			return (double)num / (double)num2;
		}
		return 0.0;
	}

	public (int r, int c) ATJJWEqPKH()
	{
		int item = 0;
		int item2 = 0;
		int num = int.MaxValue;
		for (int i = 0; i < xQbJAYhTXH; i++)
		{
			for (int j = 0; j < k7yJ5Yk9EN; j++)
			{
				if (BgZJZI3bXS[i, j] < num)
				{
					num = BgZJZI3bXS[i, j];
					item = i;
					item2 = j;
				}
			}
		}
		return (r: item, c: item2);
	}
}
