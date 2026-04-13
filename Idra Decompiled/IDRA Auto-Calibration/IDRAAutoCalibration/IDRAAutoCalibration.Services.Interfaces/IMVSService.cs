using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using GIToolkit.Services;
using IDRAAutoCalibration.Models;

namespace IDRAAutoCalibration.Services.Interfaces;

public interface IMVSService : IService, IDisposable
{
	List<HikrobotDevice> Devices { get; }

	void OpenDevices();

	void PrintDevicesProperties();

	void StartGrabbings();

	void StopGrabbings();

	Task StartLowSpeedAcquisition();

	Task StartHighSpeedAcquisition();

	Tuple<float, float> GetCamerasResultingFPS();

	Tuple<float, float> GetCamerasSetFPS();

	HikrobotDevice? GetMaster();

	HikrobotDevice? GetSlave();

	Tuple<Rect, Rect> GetCamerasCaptureROI();

	Tuple<uint, uint> GetCurrentADCBitDepth();

	Tuple<DeviceInfo, DeviceInfo> GetDeviceInfo();

	bool AreGrabbing();
}
