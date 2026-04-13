using System;
using System.Windows;
using FlexPanelLayout;
using U9xbeMdbyr6Pactctj;

namespace FFwR8R8cQ8WKihZRmV;

internal class FmclLykfbuJhM9fKea
{
	public double YPD4FW3YA;

	public double W2QOv2imA;

	public double FUO9GdpPq;

	public double uC3Ay8l0p;

	public UIElement U07DImcwl;

	public FmclLykfbuJhM9fKea(UIElement P_0, double P_1, double P_2, DependencyProperty P_3, Func<Size, double> P_4, Func<Size, double> P_5)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		FUO9GdpPq = -1.0;
		base._002Ector();
		U07DImcwl = P_0;
		uC3Ay8l0p = Flexpanel.GetBasis((DependencyObject)(object)U07DImcwl) / P_2;
		W2QOv2imA = P_4(U07DImcwl.DesiredSize);
		if (double.IsNaN(W2QOv2imA))
		{
			W2QOv2imA = P_4(U07DImcwl.DesiredSize);
			if (double.IsNaN(W2QOv2imA))
			{
				W2QOv2imA = P_1;
			}
			YPD4FW3YA = P_5(U07DImcwl.DesiredSize);
			if (double.IsNaN(YPD4FW3YA))
			{
				YPD4FW3YA = P_1;
			}
		}
		else
		{
			YPD4FW3YA = W2QOv2imA;
		}
	}

	public double LBA1M7po1(double P_0)
	{
		if (YPD4FW3YA == W2QOv2imA || FUO9GdpPq == -1.0)
		{
			FUO9GdpPq = YPD4FW3YA;
			return FUO9GdpPq;
		}
		double num = W2QOv2imA - FUO9GdpPq;
		if (P_0 > num)
		{
			FUO9GdpPq = W2QOv2imA;
			return num;
		}
		FUO9GdpPq += P_0;
		return P_0;
	}

	public bool dmIraWtsL()
	{
		return FUO9GdpPq < W2QOv2imA;
	}
}
