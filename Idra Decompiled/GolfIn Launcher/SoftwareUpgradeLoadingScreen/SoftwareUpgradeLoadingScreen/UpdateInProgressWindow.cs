using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;

namespace SoftwareUpgradeLoadingScreen;

public class UpdateInProgressWindow : Window, INotifyPropertyChanged, IComponentConnector
{
	public delegate void UpdateCancelled();

	private readonly ChocoOutputNormalizer _chocoNormalizer = new ChocoOutputNormalizer();

	private double _progressPercent;

	private bool _updateDownloadStarted = true;

	private bool _isCancelConfirmVisible;

	private bool _isCancelEnabled = true;

	private readonly UpdateCancelled _updateCancelledEvent;

	internal Grid ProgressHost;

	internal Border ProgressFill;

	internal TranslateTransform IndeterminateTransform;

	internal TextBlock CurrentStepText;

	internal Button BtnCancel;

	private bool _contentLoaded;

	public double ProgressPercent
	{
		get
		{
			return _progressPercent;
		}
		private set
		{
			double num = Math.Max(0.0, Math.Min(100.0, value));
			if (!(Math.Abs(_progressPercent - num) < 0.001))
			{
				_progressPercent = num;
				OnPropertyChanged("ProgressPercent");
			}
		}
	}

	public bool UpdateDownloadStarted
	{
		get
		{
			return _updateDownloadStarted;
		}
		private set
		{
			if (_updateDownloadStarted != value)
			{
				_updateDownloadStarted = value;
				OnPropertyChanged("UpdateDownloadStarted");
			}
		}
	}

	public bool IsCancelConfirmVisible
	{
		get
		{
			return _isCancelConfirmVisible;
		}
		set
		{
			if (_isCancelConfirmVisible != value)
			{
				_isCancelConfirmVisible = value;
				OnPropertyChanged("IsCancelConfirmVisible");
			}
		}
	}

	public bool IsCancelEnabled
	{
		get
		{
			return _isCancelEnabled;
		}
		set
		{
			if (_isCancelEnabled != value)
			{
				_isCancelEnabled = value;
				OnPropertyChanged("IsCancelEnabled");
			}
		}
	}

	public event PropertyChangedEventHandler? PropertyChanged;

	public UpdateInProgressWindow(UpdateCancelled eventParam)
	{
		InitializeComponent();
		((FrameworkElement)this).DataContext = this;
		UpdateDownloadStarted = false;
		ProgressPercent = 0.0;
		_updateCancelledEvent = eventParam;
	}

	public void AppendDetailLine(string rawLine)
	{
		if (string.IsNullOrWhiteSpace(rawLine))
		{
			return;
		}
		((DispatcherObject)this).Dispatcher.Invoke((Action)delegate
		{
			var (text, flag) = _chocoNormalizer.Normalize(rawLine);
			if (!string.IsNullOrWhiteSpace(text))
			{
				if (flag && ProgressPercent < 100.0)
				{
					CurrentStepText.Text = "Downloading update...";
				}
				else if (Math.Abs(ProgressPercent - 100.0) < 1.0)
				{
					CurrentStepText.Text = "Finalizing update...";
				}
				if (TryExtractPercent(text, out var percent) || TryExtractPercent(rawLine, out percent))
				{
					UpdateDownloadStarted = true;
					ProgressPercent = percent;
					if (text.Contains("installed", StringComparison.OrdinalIgnoreCase))
					{
						ProgressPercent = 100.0;
					}
				}
			}
		});
	}

	private static bool TryExtractPercent(string line, out double percent)
	{
		percent = 0.0;
		if (string.IsNullOrWhiteSpace(line))
		{
			return false;
		}
		Match match = Regex.Match(line, "(?<!\\d)(\\d{1,3}(?:[.,]\\d{1,2})?)\\s*%");
		if (!match.Success)
		{
			return false;
		}
		if (!double.TryParse(match.Groups[1].Value.Replace(',', '.'), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out percent))
		{
			return false;
		}
		if (percent >= 0.0)
		{
			return percent <= 100.0;
		}
		return false;
	}

	private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	private void Cancel_Click(object sender, RoutedEventArgs e)
	{
		IsCancelConfirmVisible = true;
	}

	private void ConfirmCancel_Click(object sender, RoutedEventArgs e)
	{
		IsCancelConfirmVisible = false;
		_updateCancelledEvent();
	}

	private void DismissCancel_Click(object sender, RoutedEventArgs e)
	{
		IsCancelConfirmVisible = false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/SoftwareUpgradeLoadingScreen;component/updateinprogresswindow.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "8.0.25.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			ProgressHost = (Grid)target;
			break;
		case 2:
			ProgressFill = (Border)target;
			break;
		case 3:
			IndeterminateTransform = (TranslateTransform)target;
			break;
		case 4:
			CurrentStepText = (TextBlock)target;
			break;
		case 5:
			BtnCancel = (Button)target;
			((ButtonBase)BtnCancel).Click += new RoutedEventHandler(Cancel_Click);
			break;
		case 6:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(DismissCancel_Click);
			break;
		case 7:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(ConfirmCancel_Click);
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}
}
