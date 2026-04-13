using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;
using GhU84wwqvI4UZ3pBfu;
using IDRA.Auxiliary.Helpers;
using sxB8TYTZ87aKuujytY;

namespace IDRA.Views.Shared;

public class GICustomMessage : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private Action etLV6YjLZ;

	[CompilerGenerated]
	private Action dbKGtQvrX;

	[CompilerGenerated]
	private Action XmOXGN7yK;

	public static readonly DependencyProperty TitleProperty;

	public static readonly DependencyProperty MessageProperty;

	public static readonly DependencyProperty AffirmativeTextProperty;

	public static readonly DependencyProperty AffirmativeBtnVisibilityProperty;

	public static readonly DependencyProperty NegativeTextProperty;

	public static readonly DependencyProperty AffirmativeBtnColorProperty;

	public static readonly DependencyProperty NegativeBtnColorProperty;

	public static readonly DependencyProperty AffirmativeBtnIsEnabledProperty;

	private Timer qNp9olZjh;

	private double inULXSIcD;

	internal ScaleTransform TRbTrOQu5;

	internal Grid mainGrid;

	internal Viewbox modalViewBox;

	internal Grid main_grid;

	internal TextBlock tb_title;

	internal Button btn_affirmative;

	internal Button btn_negative;

	internal Button btn_language;

	private bool saqN7lMyy;

	public Action OnAffirmativeClick
	{
		[CompilerGenerated]
		get
		{
			return etLV6YjLZ;
		}
		[CompilerGenerated]
		set
		{
			etLV6YjLZ = value;
		}
	}

	public Action OnNegativeClick
	{
		[CompilerGenerated]
		get
		{
			return dbKGtQvrX;
		}
		[CompilerGenerated]
		set
		{
			dbKGtQvrX = value;
		}
	}

	public Action OnChangeLanguage
	{
		[CompilerGenerated]
		get
		{
			return XmOXGN7yK;
		}
		[CompilerGenerated]
		set
		{
			XmOXGN7yK = value;
		}
	}

	public double WindowWidth => SystemParameters.FullPrimaryScreenWidth / 2.4;

	public double WindowHeight => SystemParameters.FullPrimaryScreenHeight / 2.7;

	public double BaseFontSize => SystemParameters.FullPrimaryScreenWidth / 160.0;

	public string Title
	{
		get
		{
			return (string)((DependencyObject)this).GetValue(TitleProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(TitleProperty, (object)value);
		}
	}

	public string Message
	{
		get
		{
			return (string)((DependencyObject)this).GetValue(MessageProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(MessageProperty, (object)value);
		}
	}

	public string AffirmativeText
	{
		get
		{
			return (string)((DependencyObject)this).GetValue(AffirmativeTextProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(AffirmativeTextProperty, (object)value);
		}
	}

	public Visibility AffirmativeBtnVisibility
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			return (Visibility)((DependencyObject)this).GetValue(AffirmativeBtnVisibilityProperty);
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			((DependencyObject)this).SetValue(AffirmativeBtnVisibilityProperty, (object)value);
		}
	}

	public string NegativeText
	{
		get
		{
			return (string)((DependencyObject)this).GetValue(NegativeTextProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(NegativeTextProperty, (object)value);
		}
	}

	public SolidColorBrush AffirmativeBtnColor
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			return (SolidColorBrush)((DependencyObject)this).GetValue(AffirmativeBtnColorProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(AffirmativeBtnColorProperty, (object)value);
		}
	}

	public SolidColorBrush NegativeBtnColor
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			return (SolidColorBrush)((DependencyObject)this).GetValue(NegativeBtnColorProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(NegativeBtnColorProperty, (object)value);
		}
	}

	public bool AffirmativeBtnIsEnabled
	{
		get
		{
			return (bool)((DependencyObject)this).GetValue(AffirmativeBtnIsEnabledProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(AffirmativeBtnIsEnabledProperty, (object)value);
		}
	}

	public GICustomMessage(int hideAutomaticallyDialogTimeMs = 0)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		((UserControl)this)._002Ector();
		((FrameworkElement)this).DataContext = this;
		InitializeComponent();
		((ContentControl)btn_language).Content = Helper.GetReverseCulture();
		if (hideAutomaticallyDialogTimeMs <= 0)
		{
			return;
		}
		inULXSIcD = ((Panel)mainGrid).Background.Opacity;
		qNp9olZjh = new Timer(hideAutomaticallyDialogTimeMs);
		qNp9olZjh.Elapsed += delegate
		{
			((DispatcherObject)this).Dispatcher.Invoke((Action)delegate
			{
				((Panel)mainGrid).Background.Opacity = 0.1;
				((UIElement)modalViewBox).Visibility = (Visibility)2;
			});
		};
		qNp9olZjh.Start();
		((FrameworkElement)this).Unloaded += (RoutedEventHandler)delegate
		{
			qNp9olZjh.Stop();
			qNp9olZjh.Dispose();
			qNp9olZjh = null;
		};
	}

	private void QLsBNkH4n(object P_0, RoutedEventArgs P_1)
	{
		OnAffirmativeClick?.Invoke();
	}

	private void IB2Dss4tf(object P_0, RoutedEventArgs P_1)
	{
		OnNegativeClick?.Invoke();
	}

	private void E1ne6piMD(object P_0, RoutedEventArgs P_1)
	{
		Helper.ToggleUILanguage();
		((ContentControl)btn_language).Content = Helper.GetReverseCulture();
		OnChangeLanguage?.Invoke();
	}

	private void IF3pcKwZQ(object P_0, MouseButtonEventArgs P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if ((int)((UIElement)modalViewBox).Visibility != 0)
		{
			((Panel)mainGrid).Background.Opacity = inULXSIcD;
			((UIElement)modalViewBox).Visibility = (Visibility)0;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	public void InitializeComponent()
	{
		if (!saqN7lMyy)
		{
			saqN7lMyy = true;
			Uri uri = new Uri(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2118), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			TRbTrOQu5 = (ScaleTransform)target;
			break;
		case 2:
			mainGrid = (Grid)target;
			((UIElement)mainGrid).MouseLeftButtonDown += new MouseButtonEventHandler(IF3pcKwZQ);
			break;
		case 3:
			modalViewBox = (Viewbox)target;
			break;
		case 4:
			main_grid = (Grid)target;
			break;
		case 5:
			tb_title = (TextBlock)target;
			break;
		case 6:
			btn_affirmative = (Button)target;
			((ButtonBase)btn_affirmative).Click += new RoutedEventHandler(QLsBNkH4n);
			break;
		case 7:
			btn_negative = (Button)target;
			((ButtonBase)btn_negative).Click += new RoutedEventHandler(IB2Dss4tf);
			break;
		case 8:
			btn_language = (Button)target;
			((ButtonBase)btn_language).Click += new RoutedEventHandler(E1ne6piMD);
			break;
		default:
			saqN7lMyy = true;
			break;
		}
	}

	static GICustomMessage()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		TitleProperty = DependencyProperty.Register(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2244), typeof(string), typeof(GICustomMessage), new PropertyMetadata((object)""));
		MessageProperty = DependencyProperty.Register(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2258), typeof(string), typeof(GICustomMessage), new PropertyMetadata((object)""));
		AffirmativeTextProperty = DependencyProperty.Register(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2276), typeof(string), typeof(GICustomMessage), new PropertyMetadata((object)""));
		AffirmativeBtnVisibilityProperty = DependencyProperty.Register(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2310), typeof(Visibility), typeof(GICustomMessage), new PropertyMetadata((object)(Visibility)0));
		NegativeTextProperty = DependencyProperty.Register(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2362), typeof(string), typeof(GICustomMessage), new PropertyMetadata((object)""));
		AffirmativeBtnColorProperty = DependencyProperty.Register(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2390), typeof(SolidColorBrush), typeof(GICustomMessage), new PropertyMetadata((PropertyChangedCallback)null));
		NegativeBtnColorProperty = DependencyProperty.Register(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2432), typeof(SolidColorBrush), typeof(GICustomMessage), new PropertyMetadata((PropertyChangedCallback)null));
		AffirmativeBtnIsEnabledProperty = DependencyProperty.Register(QQXBLjLprwI58ya4VR.y8v8TMFOCb(2468), typeof(bool), typeof(GICustomMessage), new PropertyMetadata((object)false));
	}

	[CompilerGenerated]
	private void PLk16OcZD(object? s, ElapsedEventArgs P_1)
	{
		((DispatcherObject)this).Dispatcher.Invoke((Action)delegate
		{
			((Panel)mainGrid).Background.Opacity = 0.1;
			((UIElement)modalViewBox).Visibility = (Visibility)2;
		});
	}

	[CompilerGenerated]
	private void NLBKkffi3()
	{
		((Panel)mainGrid).Background.Opacity = 0.1;
		((UIElement)modalViewBox).Visibility = (Visibility)2;
	}

	[CompilerGenerated]
	private void vjEUKFP5h(object P_0, RoutedEventArgs P_1)
	{
		qNp9olZjh.Stop();
		qNp9olZjh.Dispose();
		qNp9olZjh = null;
	}
}
