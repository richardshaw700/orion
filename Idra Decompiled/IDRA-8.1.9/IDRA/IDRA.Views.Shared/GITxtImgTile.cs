using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using GhU84wwqvI4UZ3pBfu;
using MahApps.Metro.Controls;
using sxB8TYTZ87aKuujytY;

namespace IDRA.Views.Shared;

public class GITxtImgTile : UserControl, IComponentConnector
{
	public static readonly DependencyProperty TileWidthProperty;

	public static readonly DependencyProperty TileHeightProperty;

	public static readonly DependencyProperty TileTextProperty;

	public static readonly DependencyProperty ImageSourceProperty;

	internal Tile ctUnplug;

	private bool p8Lw6GwCF;

	public double TileWidth
	{
		get
		{
			return (double)((DependencyObject)this).GetValue(TileWidthProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(TileWidthProperty, (object)value);
		}
	}

	public double TileHeight
	{
		get
		{
			return (double)((DependencyObject)this).GetValue(TileHeightProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(TileHeightProperty, (object)value);
		}
	}

	public string TileText
	{
		get
		{
			return (string)((DependencyObject)this).GetValue(TileTextProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(TileTextProperty, (object)value);
		}
	}

	public ImageSource ImageSource
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			return (ImageSource)((DependencyObject)this).GetValue(ImageSourceProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(ImageSourceProperty, (object)value);
		}
	}

	public GITxtImgTile()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		((UserControl)this)._002Ector();
		InitializeComponent();
	}

	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!p8Lw6GwCF)
		{
			p8Lw6GwCF = true;
			Uri uri = new Uri(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2518), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			ctUnplug = (Tile)target;
		}
		else
		{
			p8Lw6GwCF = true;
		}
	}

	static GITxtImgTile()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		TileWidthProperty = DependencyProperty.Register(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2638), typeof(double), typeof(GITxtImgTile), new PropertyMetadata((object)360.0));
		TileHeightProperty = DependencyProperty.Register(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2660), typeof(double), typeof(GITxtImgTile), new PropertyMetadata((object)360.0));
		TileTextProperty = DependencyProperty.Register(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2684), typeof(string), typeof(GITxtImgTile), new PropertyMetadata((object)""));
		ImageSourceProperty = DependencyProperty.Register(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2704), typeof(ImageSource), typeof(GITxtImgTile), new PropertyMetadata((PropertyChangedCallback)null));
	}
}
