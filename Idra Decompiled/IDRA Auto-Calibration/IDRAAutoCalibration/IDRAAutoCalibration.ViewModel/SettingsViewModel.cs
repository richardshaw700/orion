using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using IDRAAutoCalibration.DTO;
using IDRAAutoCalibration.Services;
using IodKeMsDBY9RwTYmwo;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration.ViewModel;

public class SettingsViewModel : INotifyPropertyChanged
{
	private float IMSMsq4dqI;

	private int wpMMqJeBBY;

	private int LPVMWEsv7e;

	private int vaVMf40C89;

	private bool SBIMKMWbDI;

	private string x3BMVl7fF9;

	private string FiRMIc1syx;

	[CompilerGenerated]
	private readonly ICommand PlAM5BycbL;

	[CompilerGenerated]
	private readonly ICommand oTTMAS7jbj;

	private readonly MvsService p9GMZ3rwtu;

	public float Gain
	{
		get
		{
			return IMSMsq4dqI;
		}
		set
		{
			SetProperty(ref IMSMsq4dqI, (float)Math.Round(value, 2), xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3504));
		}
	}

	public int Exposure
	{
		get
		{
			return wpMMqJeBBY;
		}
		set
		{
			SetProperty(ref wpMMqJeBBY, value, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3516));
		}
	}

	public string MasterCameraId
	{
		get
		{
			return x3BMVl7fF9;
		}
		set
		{
			SetProperty(ref x3BMVl7fF9, value, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(214));
		}
	}

	public string SlaveCameraId
	{
		get
		{
			return FiRMIc1syx;
		}
		set
		{
			SetProperty(ref FiRMIc1syx, value, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(246));
		}
	}

	public bool IsKeypadOpen
	{
		get
		{
			return SBIMKMWbDI;
		}
		set
		{
			SetProperty(ref SBIMKMWbDI, value, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3536));
		}
	}

	public ICommand SaveCommand
	{
		[CompilerGenerated]
		get
		{
			return PlAM5BycbL;
		}
	}

	public ICommand CancelCommand
	{
		[CompilerGenerated]
		get
		{
			return oTTMAS7jbj;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	public SettingsViewModel()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		x3BMVl7fF9 = string.Empty;
		FiRMIc1syx = string.Empty;
		base._002Ector();
		Gain = ApplicationSettings.Current.Gain;
		Exposure = ApplicationSettings.Current.Exposure;
		PlAM5BycbL = new RelayCommand(WjvMSFkGym);
		oTTMAS7jbj = new RelayCommand(OHJMxHXkZV);
		p9GMZ3rwtu = new MvsService();
		p9GMZ3rwtu.EnumerateDevices();
		x3BMVl7fF9 = p9GMZ3rwtu.GetMaster().GetSerialNumber();
		FiRMIc1syx = p9GMZ3rwtu.GetSlave().GetSerialNumber();
	}

	private void WjvMSFkGym(object P_0)
	{
		Window val = (Window)((P_0 is Window) ? P_0 : null);
		if (val != null)
		{
			ApplicationSettings.Current = new AppSettings
			{
				Gain = Gain,
				Exposure = Exposure
			};
			ApplicationSettings.Save();
			val.DialogResult = true;
			val.Close();
		}
	}

	private void OHJMxHXkZV(object P_0)
	{
		Window val = (Window)((P_0 is Window) ? P_0 : null);
		if (val != null)
		{
			val.DialogResult = false;
			val.Close();
		}
	}

	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
	{
		if (EqualityComparer<T>.Default.Equals(field, value))
		{
			return false;
		}
		field = value;
		OnPropertyChanged(propertyName);
		return true;
	}
}
