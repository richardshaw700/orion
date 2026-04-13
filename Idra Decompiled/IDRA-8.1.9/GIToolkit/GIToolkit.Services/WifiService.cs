using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using GIToolkit.Model;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class WifiService : IWifiService
{
	[CompilerGenerated]
	private Action<string> qv76Fq8VhA;

	[CompilerGenerated]
	private Action<bool> TMi6phfDvI;

	private bool BGQ6WwANru;

	public Action<string> OnConnectionStatusUpdate
	{
		[CompilerGenerated]
		get
		{
			return qv76Fq8VhA;
		}
		[CompilerGenerated]
		set
		{
			qv76Fq8VhA = value;
		}
	}

	public Action<bool> OnSuccessConnected
	{
		[CompilerGenerated]
		get
		{
			return TMi6phfDvI;
		}
		[CompilerGenerated]
		set
		{
			TMi6phfDvI = value;
		}
	}

	public bool ConnectToWifi(ConnectionModel selectedWifi)
	{
		if (selectedWifi.IsConnected)
		{
			OnConnectionStatusUpdate?.Invoke(so95DAFNMfktfjp4Dm.An6v7kuCGg(6506) + selectedWifi.DisplayName);
			return false;
		}
		string name = selectedWifi.Name;
		string profileXml = selectedWifi.XmlProfile;
		string text = BitConverter.ToString(Encoding.Default.GetBytes(name));
		text = text.Replace(so95DAFNMfktfjp4Dm.An6v7kuCGg(2182), "");
		if (!selectedWifi.EventHasBeenRegister)
		{
			selectedWifi.Interface.WlanConnectionNotification += aG56aX766F;
			selectedWifi.EventHasBeenRegister = true;
		}
		if (string.IsNullOrEmpty(selectedWifi.XmlProfile) || BGQ6WwANru)
		{
			string password = selectedWifi.Password;
			profileXml = string.Format(so95DAFNMfktfjp4Dm.An6v7kuCGg(6570), name, text, password);
		}
		try
		{
			selectedWifi.Interface.SetProfile(Wlan.WlanProfileFlags.AllUser, profileXml, overwrite: true);
			selectedWifi.Interface.Connect(Wlan.WlanConnectionMode.Profile, Wlan.Dot11BssType.Any, name);
			if (BGQ6WwANru)
			{
				BGQ6WwANru = false;
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			OnConnectionStatusUpdate?.Invoke(so95DAFNMfktfjp4Dm.An6v7kuCGg(7808) + ex.Message);
			return false;
		}
	}

	private void aG56aX766F(Wlan.WlanNotificationData P_0, Wlan.WlanConnectionNotificationData P_1)
	{
		if (P_0.NotificationCode.ToString() == so95DAFNMfktfjp4Dm.An6v7kuCGg(7854))
		{
			OnConnectionStatusUpdate?.Invoke(so95DAFNMfktfjp4Dm.An6v7kuCGg(7900));
			BGQ6WwANru = true;
		}
		else if (P_0.NotificationCode.ToString() == so95DAFNMfktfjp4Dm.An6v7kuCGg(7938))
		{
			OnSuccessConnected?.Invoke(obj: true);
		}
		Action<string> onConnectionStatusUpdate = OnConnectionStatusUpdate;
		if (onConnectionStatusUpdate != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(7960));
			defaultInterpolatedStringHandler.AppendFormatted<object>(P_0.NotificationCode);
			onConnectionStatusUpdate(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	public List<ConnectionModel> GetAvalaibleWifiNetwork()
	{
		List<ConnectionModel> list = new List<ConnectionModel>();
		WlanClient.WlanInterface[] interfaces = new WlanClient().Interfaces;
		foreach (WlanClient.WlanInterface wlanInterface in interfaces)
		{
			Wlan.WlanAvailableNetwork[] availableNetworkList = wlanInterface.GetAvailableNetworkList((Wlan.WlanGetAvailableNetworkFlags)0);
			for (int j = 0; j < availableNetworkList.Length; j++)
			{
				Wlan.WlanAvailableNetwork wlanAvailableNetwork = availableNetworkList[j];
				string text = vA06XvByGY(wlanAvailableNetwork.dot11Ssid);
				ConnectionModel connectionModel = new ConnectionModel();
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(8006));
				defaultInterpolatedStringHandler.AppendFormatted(wlanAvailableNetwork.wlanSignalQuality);
				defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(8028));
				connectionModel.DisplayName = defaultInterpolatedStringHandler.ToStringAndClear();
				connectionModel.IsConnected = wlanAvailableNetwork.flags.HasFlag(Wlan.WlanAvailableNetworkFlags.Connected);
				connectionModel.SSID = wlanAvailableNetwork.dot11Ssid.SSID;
				connectionModel.ProfileName = wlanAvailableNetwork.profileName;
				connectionModel.Name = text;
				connectionModel.Interface = wlanInterface;
				ConnectionModel connectionModel2 = connectionModel;
				if (wlanAvailableNetwork.flags.HasFlag(Wlan.WlanAvailableNetworkFlags.HasProfile))
				{
					connectionModel2.XmlProfile = wlanInterface.GetProfileXml(connectionModel2.ProfileName);
				}
				connectionModel2.IsRemembered = wlanAvailableNetwork.flags == Wlan.WlanAvailableNetworkFlags.HasProfile;
				list.Add(connectionModel2);
			}
		}
		return list;
	}

	private string vA06XvByGY(Wlan.Dot11Ssid P_0)
	{
		return Encoding.ASCII.GetString(P_0.SSID, 0, (int)P_0.SSIDLength);
	}

	public WifiService()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
