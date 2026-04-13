using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using GIToolkit.Services;
using IDRAAutoCalibration.Models;
using IDRAAutoCalibration.Services.Interfaces;
using IodKeMsDBY9RwTYmwo;
using MvCamCtrl.NET;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration.Services;

public class MvsService : IMVSService, IService, IDisposable
{
	[CompilerGenerated]
	private List<HikrobotDevice> GnHkKdIJmA;

	public List<HikrobotDevice> Devices
	{
		[CompilerGenerated]
		get
		{
			return GnHkKdIJmA;
		}
		[CompilerGenerated]
		private set
		{
			GnHkKdIJmA = value;
		}
	}

	public bool AreGrabbing()
	{
		if (Devices.Count >= 2)
		{
			return Devices.All((HikrobotDevice x) => x.IsGrabbing);
		}
		return false;
	}

	public HikrobotDevice? GetMaster()
	{
		return Devices.SingleOrDefault((HikrobotDevice x) => x.Mode == DeviceMode.MASTER);
	}

	public HikrobotDevice? GetSlave()
	{
		return Devices.SingleOrDefault((HikrobotDevice x) => x.Mode == DeviceMode.SLAVE);
	}

	public void OpenDevices()
	{
		EnumerateDevices();
		foreach (HikrobotDevice device in Devices)
		{
			device.OpenDevice();
		}
	}

	public async Task StartLowSpeedAcquisition()
	{
		foreach (HikrobotDevice device in Devices)
		{
			device.StopGrabbing();
			device.StartLowSpeedAcquisition();
			await Task.Delay(50);
			device.StartGrabbing();
			await Task.Delay(50);
		}
	}

	public async Task StartHighSpeedAcquisition()
	{
		foreach (HikrobotDevice device in Devices)
		{
			device.StopGrabbing();
			device.StartHighSpeedAcquisition();
			await Task.Delay(50);
			device.StartGrabbing();
			await Task.Delay(50);
		}
	}

	public void StartGrabbings()
	{
		foreach (HikrobotDevice device in Devices)
		{
			device.StartGrabbing();
		}
	}

	public void StopGrabbings()
	{
		foreach (HikrobotDevice device in Devices)
		{
			device.StopGrabbing();
		}
	}

	public void PrintDevicesProperties()
	{
		foreach (HikrobotDevice device in Devices)
		{
			device.PrintDeviceProperties();
		}
	}

	public Tuple<float, float> GetCamerasResultingFPS()
	{
		return new Tuple<float, float>(GetMaster().GetResultingFPS(), GetSlave().GetResultingFPS());
	}

	public Tuple<float, float> GetCamerasSetFPS()
	{
		return new Tuple<float, float>(GetMaster().GetSetFPS(), GetSlave().GetSetFPS());
	}

	private int v0AkWQXy02(string P_0)
	{
		string text = string.Empty;
		for (int i = 0; i < P_0.Count(); i++)
		{
			try
			{
				if (char.IsDigit(P_0[i]))
				{
					text += char.GetNumericValue(P_0[i]);
				}
			}
			catch (Exception)
			{
			}
		}
		return int.Parse(text);
	}

	public void EnumerateDevices()
	{
		Devices.ForEach(delegate(HikrobotDevice o)
		{
			o.Dispose();
		});
		Devices = new List<HikrobotDevice>();
		MyCamera.MV_CC_DEVICE_INFO_LIST stDevList = default(MyCamera.MV_CC_DEVICE_INFO_LIST);
		if (MyCamera.MV_CC_EnumDevices_NET(4u, ref stDevList) != 0)
		{
			throw new LoadingCameraException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5758));
		}
		if (stDevList.nDeviceNum != 2)
		{
			throw new LoadingCameraException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5808));
		}
		for (int num = 0; num < stDevList.nDeviceNum; num++)
		{
			MyCamera.MV_CC_DEVICE_INFO handle = (MyCamera.MV_CC_DEVICE_INFO)(Marshal.PtrToStructure(stDevList.pDeviceInfo[num], typeof(MyCamera.MV_CC_DEVICE_INFO)) ?? throw new NullReferenceException());
			MyCamera.MV_USB3_DEVICE_INFO mV_USB3_DEVICE_INFO = (MyCamera.MV_USB3_DEVICE_INFO)MyCamera.ByteToStruct(handle.SpecialInfo.stUsb3VInfo, typeof(MyCamera.MV_USB3_DEVICE_INFO));
			Devices.Add(new HikrobotDevice(DeviceMode.UNKNOWN, handle, mV_USB3_DEVICE_INFO.chSerialNumber, mV_USB3_DEVICE_INFO.chModelName));
		}
		string serialNumber = Devices[0].GetSerialNumber();
		int num2 = Devices[0].GetSerialNumber().Length - 8;
		int num3 = v0AkWQXy02(serialNumber.Substring(num2, serialNumber.Length - num2));
		serialNumber = Devices[1].GetSerialNumber();
		num2 = Devices[1].GetSerialNumber().Length - 8;
		int num4 = v0AkWQXy02(serialNumber.Substring(num2, serialNumber.Length - num2));
		if (num3 < num4)
		{
			Devices[0].Mode = DeviceMode.MASTER;
			Devices[1].Mode = DeviceMode.SLAVE;
		}
		else
		{
			Devices[0].Mode = DeviceMode.SLAVE;
			Devices[1].Mode = DeviceMode.MASTER;
		}
	}

	public Tuple<Rect, Rect> GetCamerasCaptureROI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		return new Tuple<Rect, Rect>(GetMaster().GetCurrentImageROI(), GetSlave().GetCurrentImageROI());
	}

	public Tuple<uint, uint> GetCurrentADCBitDepth()
	{
		return new Tuple<uint, uint>(GetMaster().GetAdcBitDepth(), GetSlave().GetAdcBitDepth());
	}

	public Tuple<DeviceInfo, DeviceInfo> GetDeviceInfo()
	{
		return new Tuple<DeviceInfo, DeviceInfo>(GetMaster().GetDeviceInfo(), GetSlave().GetDeviceInfo());
	}

	void IDisposable.Dispose()
	{
		foreach (HikrobotDevice device in Devices)
		{
			device.Dispose();
		}
		Devices.Clear();
	}

	public MvsService()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		GnHkKdIJmA = new List<HikrobotDevice>();
		base._002Ector();
	}
}
