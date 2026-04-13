using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using IodKeMsDBY9RwTYmwo;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration;

public class MainWindow : Window, IComponentConnector
{
	internal ToggleButton ToolsToggle;

	private bool BbHMjBpp8B;

	public MainWindow()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		((Window)this)._002Ector();
		InitializeComponent();
		((FrameworkElement)this).DataContext = new MainWindowViewModel();
	}

	private void HL0MOuVuR7(object P_0, RoutedEventArgs P_1)
	{
		Button val = (Button)((P_0 is Button) ? P_0 : null);
		if (val != null && ((FrameworkElement)val).ContextMenu != null)
		{
			((FrameworkElement)val).ContextMenu.PlacementTarget = (UIElement)(object)val;
			((FrameworkElement)val).ContextMenu.Placement = (PlacementMode)2;
			((FrameworkElement)val).ContextMenu.HorizontalOffset = 0.0;
			((FrameworkElement)val).ContextMenu.VerticalOffset = 2.0;
			((FrameworkElement)val).ContextMenu.IsOpen = true;
		}
	}

	private void OKCM6vhH4u(object P_0, RoutedEventArgs P_1)
	{
		ToolsToggle.IsChecked = false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "8.0.24.0")]
	public void InitializeComponent()
	{
		if (!BbHMjBpp8B)
		{
			BbHMjBpp8B = true;
			Uri uri = new Uri(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3060), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "8.0.24.0")]
	[DebuggerNonUserCode]
	internal Delegate jvQMH6mqRH(Type P_0, string P_1)
	{
		return Delegate.CreateDelegate(P_0, this, P_1);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "8.0.24.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			ToolsToggle = (ToggleButton)target;
			break;
		case 2:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(OKCM6vhH4u);
			break;
		case 3:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(OKCM6vhH4u);
			break;
		case 4:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(OKCM6vhH4u);
			break;
		case 5:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(OKCM6vhH4u);
			break;
		default:
			BbHMjBpp8B = true;
			break;
		}
	}
}
