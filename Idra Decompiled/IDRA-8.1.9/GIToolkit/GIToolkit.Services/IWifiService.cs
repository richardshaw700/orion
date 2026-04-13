using System;
using System.Collections.Generic;
using GIToolkit.Model;

namespace GIToolkit.Services;

public interface IWifiService
{
	Action<string> OnConnectionStatusUpdate { get; set; }

	Action<bool> OnSuccessConnected { get; set; }

	bool ConnectToWifi(ConnectionModel selectedWifi);

	List<ConnectionModel> GetAvalaibleWifiNetwork();
}
