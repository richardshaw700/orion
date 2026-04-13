using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using Lmttrs0IQc7UR7Zpt6;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Views;

public class SettingsWindow : UserControl, IComponentConnector, IStyleConnector
{
	private readonly TouchNumericKeypad RbBkqD56Na;

	internal SettingsWindow Root;

	private bool CSYk54HU59;

	public SettingsWindow()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		((UserControl)this)._002Ector();
		InitializeComponent();
		RbBkqD56Na = ((FrameworkElement)this).FindName(aL07ImwcwlxdnyfI30.olMQlwrxmw(2244)) as TouchNumericKeypad;
	}

	private void zNVkZG9tyJ(object P_0, RoutedEventArgs P_1)
	{
		TextBox val = (TextBox)((P_0 is TextBox) ? P_0 : null);
		if (val != null)
		{
			TouchNumericKeypad touchNumericKeypad = WVGk3aCAqU<TouchNumericKeypad>((DependencyObject)(object)val);
			if (touchNumericKeypad != null)
			{
				touchNumericKeypad.IsOpen = true;
			}
		}
	}

	private static zDm8sC33QOpU2ogv8i? WVGk3aCAqU<zDm8sC33QOpU2ogv8i>(DependencyObject P_0) where zDm8sC33QOpU2ogv8i : DependencyObject
	{
		zDm8sC33QOpU2ogv8i val = ndXks8hlRD<zDm8sC33QOpU2ogv8i>(P_0);
		if (val != null)
		{
			return val;
		}
		DependencyObject val2 = P_0;
		while (val2 != null)
		{
			DependencyObject parent = VisualTreeHelper.GetParent(val2);
			if (parent == null)
			{
				break;
			}
			zDm8sC33QOpU2ogv8i val3 = ndXks8hlRD<zDm8sC33QOpU2ogv8i>(parent);
			if (val3 != null)
			{
				return val3;
			}
			val2 = parent;
		}
		return default(zDm8sC33QOpU2ogv8i);
	}

	private static swbXS3sU9Ik3g1dQfC? ndXks8hlRD<swbXS3sU9Ik3g1dQfC>(DependencyObject P_0) where swbXS3sU9Ik3g1dQfC : DependencyObject
	{
		int childrenCount = VisualTreeHelper.GetChildrenCount(P_0);
		for (int i = 0; i < childrenCount; i = checked(i + 1))
		{
			DependencyObject child = VisualTreeHelper.GetChild(P_0, i);
			swbXS3sU9Ik3g1dQfC val = (swbXS3sU9Ik3g1dQfC)(object)((child is swbXS3sU9Ik3g1dQfC) ? child : null);
			if (val != null)
			{
				return val;
			}
			swbXS3sU9Ik3g1dQfC val2 = ndXks8hlRD<swbXS3sU9Ik3g1dQfC>(child);
			if (val2 != null)
			{
				return val2;
			}
		}
		return default(swbXS3sU9Ik3g1dQfC);
	}

	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!CSYk54HU59)
		{
			CSYk54HU59 = true;
			Uri uri = new Uri(aL07ImwcwlxdnyfI30.olMQlwrxmw(2260), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			Root = (SettingsWindow)target;
		}
		else
		{
			CSYk54HU59 = true;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		if (connectionId == 2)
		{
			((UIElement)(TextBox)target).GotFocus += new RoutedEventHandler(zNVkZG9tyJ);
		}
	}
}
