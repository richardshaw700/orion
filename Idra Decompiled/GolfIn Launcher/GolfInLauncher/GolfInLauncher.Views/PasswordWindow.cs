using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using GolfInLauncher.ViewModels;
using Lmttrs0IQc7UR7Zpt6;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Views;

public class PasswordWindow : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public PasswordWindow kA3q42UXoG;

		public PasswordViewModel FFvqOKB3qT;

		public _003C_003Ec__DisplayClass5_0()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal void buYqrSOr4d()
		{
			kA3q42UXoG.txtInput.Password = FFvqOKB3qT.Password ?? string.Empty;
			((UIElement)kA3q42UXoG.txtInput).Focus();
		}
	}

	internal Button btn_7;

	internal Button btn_8;

	internal Button btn_9;

	internal Button btn_4;

	internal Button btn_5;

	internal Button btn_6;

	internal Button btn_1;

	internal Button btn_2;

	internal Button btn_3;

	internal Button btn_0;

	internal PasswordBox txtInput;

	internal Button btn_enter;

	private bool GQlkGdqnt3;

	public PasswordWindow()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		((UserControl)this)._002Ector();
		InitializeComponent();
		((FrameworkElement)this).Loaded += new RoutedEventHandler(buboYn6SF);
		((FrameworkElement)this).DataContextChanged += new DependencyPropertyChangedEventHandler(Qtrh0qRt1);
	}

	private void buboYn6SF(object P_0, RoutedEventArgs P_1)
	{
		Keyboard.Focus((IInputElement)(object)txtInput);
		W1szw6aoH(((FrameworkElement)this).DataContext as PasswordViewModel);
	}

	private void Qtrh0qRt1(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		MZvkpujWUZ(((DependencyPropertyChangedEventArgs)(ref P_1)).OldValue as PasswordViewModel);
		W1szw6aoH(((DependencyPropertyChangedEventArgs)(ref P_1)).NewValue as PasswordViewModel);
	}

	private void W1szw6aoH(PasswordViewModel? P_0)
	{
		if (P_0 != null)
		{
			P_0.PropertyChanged += Dq7kkATQwO;
			txtInput.Password = P_0.Password ?? string.Empty;
		}
	}

	private void MZvkpujWUZ(PasswordViewModel? P_0)
	{
		if (P_0 != null)
		{
			P_0.PropertyChanged -= Dq7kkATQwO;
		}
	}

	private void Dq7kkATQwO(object? sender, PropertyChangedEventArgs P_1)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals6.kA3q42UXoG = this;
		CS_0024_003C_003E8__locals6.FFvqOKB3qT = sender as PasswordViewModel;
		if (CS_0024_003C_003E8__locals6.FFvqOKB3qT != null && P_1.PropertyName == aL07ImwcwlxdnyfI30.olMQlwrxmw(2118))
		{
			((DispatcherObject)this).Dispatcher.Invoke((Action)delegate
			{
				CS_0024_003C_003E8__locals6.kA3q42UXoG.txtInput.Password = CS_0024_003C_003E8__locals6.FFvqOKB3qT.Password ?? string.Empty;
				((UIElement)CS_0024_003C_003E8__locals6.kA3q42UXoG.txtInput).Focus();
			});
		}
	}

	private void X9Sk8Qwuif(object P_0, MouseButtonEventArgs P_1)
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	public void InitializeComponent()
	{
		if (!GQlkGdqnt3)
		{
			GQlkGdqnt3 = true;
			Uri uri = new Uri(aL07ImwcwlxdnyfI30.olMQlwrxmw(2138), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			((UIElement)(PasswordWindow)target).MouseDown += new MouseButtonEventHandler(X9Sk8Qwuif);
			break;
		case 2:
			btn_7 = (Button)target;
			break;
		case 3:
			btn_8 = (Button)target;
			break;
		case 4:
			btn_9 = (Button)target;
			break;
		case 5:
			btn_4 = (Button)target;
			break;
		case 6:
			btn_5 = (Button)target;
			break;
		case 7:
			btn_6 = (Button)target;
			break;
		case 8:
			btn_1 = (Button)target;
			break;
		case 9:
			btn_2 = (Button)target;
			break;
		case 10:
			btn_3 = (Button)target;
			break;
		case 11:
			btn_0 = (Button)target;
			break;
		case 12:
			txtInput = (PasswordBox)target;
			break;
		case 13:
			btn_enter = (Button)target;
			break;
		default:
			GQlkGdqnt3 = true;
			break;
		}
	}
}
