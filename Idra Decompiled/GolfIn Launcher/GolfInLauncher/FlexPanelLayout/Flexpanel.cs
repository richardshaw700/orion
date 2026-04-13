using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using FFwR8R8cQ8WKihZRmV;
using Lmttrs0IQc7UR7Zpt6;
using U9xbeMdbyr6Pactctj;

namespace FlexPanelLayout;

public class Flexpanel : Panel
{
	public static readonly DependencyProperty OrderProperty;

	public static readonly DependencyProperty GrowProperty;

	public static readonly DependencyProperty ShrinkProperty;

	public static readonly DependencyProperty AlignSelfProperty;

	public static readonly DependencyProperty BasisProperty;

	public static readonly DependencyProperty DirectionProperty;

	public static readonly DependencyProperty WrapProperty;

	public static readonly DependencyProperty JustifyContentProperty;

	public static readonly DependencyProperty AlignItemsProperty;

	public static readonly DependencyProperty AlignContentProperty;

	private Func<Point, double> XgvH8iTwb;

	private Func<Point, double> vS3cU9Ik3;

	private Func<Size, double> W1deQfChW;

	private Func<Size, double> KpWbud7l7;

	private Func<Size, double> fxcVxaWBJ;

	private Func<Size, double> HBCwqgmvU;

	private Func<double, double, Size> Wtr0hh4WA;

	private Func<double, double, Point> pQcCgoIEd;

	private double xERdKbGoE;

	private double UkFyBhcVj;

	private Size xAe6ubEVb;

	private DependencyProperty TayTkEwTE;

	private List<FmclLykfbuJhM9fKea> EaHY3YOl6;

	private bool qUGScYcZl;

	private bool JjxNZnXny;

	private double e5tXZ5JEG;

	public FlexDirection Direction
	{
		get
		{
			return (FlexDirection)((DependencyObject)this).GetValue(DirectionProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(DirectionProperty, (object)value);
		}
	}

	public FlexWrap Wrap
	{
		get
		{
			return (FlexWrap)((DependencyObject)this).GetValue(WrapProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(WrapProperty, (object)value);
		}
	}

	public FlexJustifyContent JustifyContent
	{
		get
		{
			return (FlexJustifyContent)((DependencyObject)this).GetValue(JustifyContentProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(JustifyContentProperty, (object)value);
		}
	}

	public FlexAlignItems AlignItems
	{
		get
		{
			return (FlexAlignItems)((DependencyObject)this).GetValue(AlignItemsProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(AlignItemsProperty, (object)value);
		}
	}

	public FlexAlignContent AlignContent
	{
		get
		{
			return (FlexAlignContent)((DependencyObject)this).GetValue(AlignContentProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(AlignContentProperty, (object)value);
		}
	}

	public Flexpanel()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		((Panel)this)._002Ector();
		HV03JVVwn(FlexDirection.Row);
	}

	private void HV03JVVwn(FlexDirection P_0)
	{
		switch (P_0)
		{
		case FlexDirection.Row:
		case FlexDirection.RowReverse:
			Wtr0hh4WA = (double p, double s) => new Size(p, s);
			pQcCgoIEd = (double p, double s) => new Point(p, s);
			XgvH8iTwb = (Point p) => ((Point)(ref p)).X;
			vS3cU9Ik3 = (Point p) => ((Point)(ref p)).Y;
			fxcVxaWBJ = (Size p) => ((Size)(ref p)).Width;
			HBCwqgmvU = (Size p) => ((Size)(ref p)).Height;
			TayTkEwTE = FrameworkElement.WidthProperty;
			KpWbud7l7 = (Size p) => ((Size)(ref p)).Width;
			W1deQfChW = (Size p) => ((Size)(ref p)).Height;
			qUGScYcZl = true;
			break;
		case FlexDirection.Column:
		case FlexDirection.ColumnReverse:
			Wtr0hh4WA = (double p, double s) => new Size(s, p);
			pQcCgoIEd = (double p, double s) => new Point(s, p);
			XgvH8iTwb = (Point p) => ((Point)(ref p)).Y;
			vS3cU9Ik3 = (Point p) => ((Point)(ref p)).X;
			fxcVxaWBJ = (Size p) => ((Size)(ref p)).Height;
			HBCwqgmvU = (Size p) => ((Size)(ref p)).Width;
			TayTkEwTE = FrameworkElement.HeightProperty;
			KpWbud7l7 = (Size p) => ((Size)(ref p)).Height;
			W1deQfChW = (Size p) => ((Size)(ref p)).Width;
			qUGScYcZl = false;
			break;
		}
		if (Direction == FlexDirection.ColumnReverse || Direction == FlexDirection.RowReverse)
		{
			JjxNZnXny = true;
		}
		else
		{
			JjxNZnXny = false;
		}
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		foreach (UIElement item in ((IEnumerable)((Panel)this).Children).Cast<UIElement>())
		{
			B3wqDPG4Y(item);
			item.Measure(availableSize);
		}
		if (((Panel)this).Children.Count > 0)
		{
			xAe6ubEVb = Wtr0hh4WA(((IEnumerable)((Panel)this).Children).Cast<UIElement>().Sum((UIElement P_0) => fxcVxaWBJ(P_0.DesiredSize)), ((IEnumerable)((Panel)this).Children).Cast<UIElement>().Max((UIElement P_0) => HBCwqgmvU(P_0.DesiredSize)));
			e5tXZ5JEG = ((IEnumerable)((Panel)this).Children).Cast<UIElement>().Sum((UIElement c) => GetBasis((DependencyObject)(object)c));
			EaHY3YOl6 = (from UIElement P_0 in (IEnumerable)((Panel)this).Children
				select new FmclLykfbuJhM9fKea(P_0, fxcVxaWBJ(P_0.DesiredSize), e5tXZ5JEG, TayTkEwTE, KpWbud7l7, W1deQfChW)).ToList();
		}
		else
		{
			xAe6ubEVb = default(Size);
			EaHY3YOl6 = new List<FmclLykfbuJhM9fKea>();
		}
		return Wtr0hh4WA(fxcVxaWBJ(xAe6ubEVb), HBCwqgmvU(xAe6ubEVb));
	}

	private void QHuskYUox(Size P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		double num = fxcVxaWBJ(P_0);
		while (num > 0.0)
		{
			List<FmclLykfbuJhM9fKea> list = EaHY3YOl6.Where((FmclLykfbuJhM9fKea cc) => cc.dmIraWtsL()).ToList();
			if (list.Count == 0)
			{
				break;
			}
			if (list.Count == 1 || num < 1.0)
			{
				num -= list[0].LBA1M7po1(num);
				continue;
			}
			foreach (FmclLykfbuJhM9fKea item in list)
			{
				num -= item.LBA1M7po1(num * item.uC3Ay8l0p);
			}
		}
		num = fxcVxaWBJ(P_0) - EaHY3YOl6.Sum((FmclLykfbuJhM9fKea e) => e.FUO9GdpPq);
		xERdKbGoE = 0.0;
		UkFyBhcVj = 0.0;
		checked
		{
			if ((JustifyContent == FlexJustifyContent.End && !JjxNZnXny) || (JustifyContent == FlexJustifyContent.Start && JjxNZnXny))
			{
				xERdKbGoE = num;
			}
			else if (JustifyContent == FlexJustifyContent.Center)
			{
				xERdKbGoE = num / 2.0;
			}
			else if (JustifyContent == FlexJustifyContent.SpaceBetween)
			{
				double num2 = num / (double)(((Panel)this).Children.Count + 1);
				UkFyBhcVj = num2 + (num2 + num2) / (double)(((Panel)this).Children.Count - 1);
			}
			else if (JustifyContent == FlexJustifyContent.SpaceAround)
			{
				xERdKbGoE = (UkFyBhcVj = num / (double)(((Panel)this).Children.Count + 1));
			}
		}
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		QHuskYUox(finalSize);
		if (((Panel)this).Children.Count == 0)
		{
			return finalSize;
		}
		Point val = pQcCgoIEd(xERdKbGoE, 0.0);
		IEnumerable<FmclLykfbuJhM9fKea> enumerable;
		if (!JjxNZnXny)
		{
			IEnumerable<FmclLykfbuJhM9fKea> eaHY3YOl = EaHY3YOl6;
			enumerable = eaHY3YOl;
		}
		else
		{
			enumerable = Enumerable.Reverse(EaHY3YOl6);
		}
		foreach (FmclLykfbuJhM9fKea item in enumerable)
		{
			item.U07DImcwl.Arrange(new Rect(val, Wtr0hh4WA(item.FUO9GdpPq, HBCwqgmvU(finalSize))));
			val = pQcCgoIEd(XgvH8iTwb(val) + item.FUO9GdpPq + UkFyBhcVj, 0.0);
		}
		return finalSize;
	}

	private void B3wqDPG4Y(UIElement P_0)
	{
		FlexAlignItems flexAlignItems = GetAlignSelf((DependencyObject)(object)P_0);
		if (flexAlignItems == FlexAlignItems.NotSet)
		{
			flexAlignItems = AlignItems;
		}
		switch (flexAlignItems)
		{
		default:
			if (!qUGScYcZl)
			{
				((DependencyObject)P_0).SetValue(FrameworkElement.HorizontalAlignmentProperty, (object)(HorizontalAlignment)0);
			}
			else
			{
				((DependencyObject)P_0).SetValue(FrameworkElement.VerticalAlignmentProperty, (object)(VerticalAlignment)0);
			}
			break;
		case FlexAlignItems.End:
			if (!qUGScYcZl)
			{
				((DependencyObject)P_0).SetValue(FrameworkElement.HorizontalAlignmentProperty, (object)(HorizontalAlignment)2);
			}
			else
			{
				((DependencyObject)P_0).SetValue(FrameworkElement.VerticalAlignmentProperty, (object)(VerticalAlignment)2);
			}
			break;
		case FlexAlignItems.Center:
		case FlexAlignItems.Baseline:
			if (!qUGScYcZl)
			{
				((DependencyObject)P_0).SetValue(FrameworkElement.HorizontalAlignmentProperty, (object)(HorizontalAlignment)1);
			}
			else
			{
				((DependencyObject)P_0).SetValue(FrameworkElement.VerticalAlignmentProperty, (object)(VerticalAlignment)1);
			}
			break;
		case FlexAlignItems.Stretch:
			if (!qUGScYcZl)
			{
				((DependencyObject)P_0).SetValue(FrameworkElement.HorizontalAlignmentProperty, (object)(HorizontalAlignment)3);
			}
			else
			{
				((DependencyObject)P_0).SetValue(FrameworkElement.VerticalAlignmentProperty, (object)(VerticalAlignment)3);
			}
			break;
		}
	}

	public static int GetOrder(DependencyObject obj)
	{
		return (int)obj.GetValue(OrderProperty);
	}

	public static void SetOrder(DependencyObject obj, int value)
	{
		obj.SetValue(OrderProperty, (object)value);
	}

	public static int GetGrow(DependencyObject obj)
	{
		return (int)obj.GetValue(GrowProperty);
	}

	public static void SetGrow(DependencyObject obj, int value)
	{
		obj.SetValue(GrowProperty, (object)value);
	}

	public static int GetShrink(DependencyObject obj)
	{
		return (int)obj.GetValue(ShrinkProperty);
	}

	public static void SetShrink(DependencyObject obj, int value)
	{
		obj.SetValue(ShrinkProperty, (object)value);
	}

	public static FlexAlignItems GetAlignSelf(DependencyObject obj)
	{
		return (FlexAlignItems)obj.GetValue(AlignSelfProperty);
	}

	public static void SetAlignSelf(DependencyObject obj, FlexAlignItems value)
	{
		obj.SetValue(AlignSelfProperty, (object)value);
	}

	public static double GetBasis(DependencyObject obj)
	{
		return (double)obj.GetValue(BasisProperty);
	}

	public static void SetBasis(DependencyObject obj, double value)
	{
		obj.SetValue(BasisProperty, (object)value);
	}

	static Flexpanel()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		OrderProperty = DependencyProperty.RegisterAttached(aL07ImwcwlxdnyfI30.olMQlwrxmw(222), typeof(int), typeof(Flexpanel), new PropertyMetadata((object)int.MinValue, (PropertyChangedCallback)delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((UIElement)d).InvalidateMeasure();
		}));
		GrowProperty = DependencyProperty.RegisterAttached(aL07ImwcwlxdnyfI30.olMQlwrxmw(236), typeof(int), typeof(Flexpanel), new PropertyMetadata((object)1, (PropertyChangedCallback)delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((UIElement)d).InvalidateMeasure();
		}));
		ShrinkProperty = DependencyProperty.RegisterAttached(aL07ImwcwlxdnyfI30.olMQlwrxmw(248), typeof(int), typeof(Flexpanel), new PropertyMetadata((object)1, (PropertyChangedCallback)delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((UIElement)d).InvalidateMeasure();
		}));
		AlignSelfProperty = DependencyProperty.RegisterAttached(aL07ImwcwlxdnyfI30.olMQlwrxmw(264), typeof(FlexAlignItems), typeof(Flexpanel), new PropertyMetadata((object)FlexAlignItems.NotSet, (PropertyChangedCallback)delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((UIElement)d).InvalidateMeasure();
		}));
		BasisProperty = DependencyProperty.RegisterAttached(aL07ImwcwlxdnyfI30.olMQlwrxmw(286), typeof(double), typeof(Flexpanel), new PropertyMetadata((object)1.0));
		DirectionProperty = DependencyProperty.Register(aL07ImwcwlxdnyfI30.olMQlwrxmw(300), typeof(FlexDirection), typeof(Flexpanel), new PropertyMetadata((object)FlexDirection.Row, (PropertyChangedCallback)delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			((Flexpanel)(object)d).HV03JVVwn((FlexDirection)((DependencyPropertyChangedEventArgs)(ref e)).NewValue);
			((UIElement)d).InvalidateMeasure();
		}));
		WrapProperty = DependencyProperty.Register(aL07ImwcwlxdnyfI30.olMQlwrxmw(322), typeof(FlexWrap), typeof(Flexpanel), new PropertyMetadata((object)FlexWrap.NoWrap, (PropertyChangedCallback)delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((UIElement)d).InvalidateMeasure();
		}));
		JustifyContentProperty = DependencyProperty.Register(aL07ImwcwlxdnyfI30.olMQlwrxmw(334), typeof(FlexJustifyContent), typeof(Flexpanel), new PropertyMetadata((object)FlexJustifyContent.Center, (PropertyChangedCallback)delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((UIElement)d).InvalidateMeasure();
		}));
		AlignItemsProperty = DependencyProperty.Register(aL07ImwcwlxdnyfI30.olMQlwrxmw(366), typeof(FlexAlignItems), typeof(Flexpanel), new PropertyMetadata((object)FlexAlignItems.Center, (PropertyChangedCallback)delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((UIElement)d).InvalidateMeasure();
		}));
		AlignContentProperty = DependencyProperty.Register(aL07ImwcwlxdnyfI30.olMQlwrxmw(390), typeof(FlexAlignContent), typeof(Flexpanel), new PropertyMetadata((object)FlexAlignContent.Center, (PropertyChangedCallback)delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((UIElement)d).InvalidateMeasure();
		}));
	}

	[CompilerGenerated]
	private double B7R5YgKaM(UIElement P_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return fxcVxaWBJ(P_0.DesiredSize);
	}

	[CompilerGenerated]
	private double QX2Q2ODm8(UIElement P_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return HBCwqgmvU(P_0.DesiredSize);
	}

	[CompilerGenerated]
	private FmclLykfbuJhM9fKea fC3xQOpU2(UIElement P_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return new FmclLykfbuJhM9fKea(P_0, fxcVxaWBJ(P_0.DesiredSize), e5tXZ5JEG, TayTkEwTE, KpWbud7l7, W1deQfChW);
	}
}
