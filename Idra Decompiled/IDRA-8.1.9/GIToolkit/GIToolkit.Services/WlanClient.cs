using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class WlanClient : IDisposable
{
	public class WlanInterface
	{
		public delegate void WlanNotificationEventHandler(Wlan.WlanNotificationData notifyData);

		public delegate void WlanConnectionNotificationEventHandler(Wlan.WlanNotificationData notifyData, Wlan.WlanConnectionNotificationData connNotifyData);

		public delegate void WlanReasonNotificationEventHandler(Wlan.WlanNotificationData notifyData, Wlan.WlanReasonCode reasonCode);

		private struct waOL4Na8GID53dM0bI
		{
			public Wlan.WlanNotificationData i4b6UbjWI7;

			public Wlan.WlanConnectionNotificationData klv6mbTEg6;
		}

		private struct hd0k5tXrg0VMetr34J
		{
			public Wlan.WlanNotificationData PGN6jsuEZc;

			public Wlan.WlanReasonCode wd66fGeFmL;
		}

		private readonly WlanClient e98643ex6P;

		private Wlan.WlanInterfaceInfo jvF6rPHq8p;

		[CompilerGenerated]
		private WlanNotificationEventHandler rPY683ys4A;

		[CompilerGenerated]
		private WlanConnectionNotificationEventHandler sXA6lBceeW;

		[CompilerGenerated]
		private WlanReasonNotificationEventHandler wU36nfQkCA;

		private bool WSJ61A0I27;

		private readonly AutoResetEvent pnY6bBSPr0;

		private readonly Queue<object> fj265BC5MN;

		public bool Autoconf
		{
			get
			{
				return Wg86tMTZqC(Wlan.WlanIntfOpcode.AutoconfEnabled) != 0;
			}
			set
			{
				eRa6od9n6h(Wlan.WlanIntfOpcode.AutoconfEnabled, value ? 1 : 0);
			}
		}

		public Wlan.Dot11BssType BssType
		{
			get
			{
				return (Wlan.Dot11BssType)Wg86tMTZqC(Wlan.WlanIntfOpcode.BssType);
			}
			set
			{
				eRa6od9n6h(Wlan.WlanIntfOpcode.BssType, (int)value);
			}
		}

		public Wlan.WlanInterfaceState InterfaceState => (Wlan.WlanInterfaceState)Wg86tMTZqC(Wlan.WlanIntfOpcode.InterfaceState);

		public int Channel => Wg86tMTZqC(Wlan.WlanIntfOpcode.ChannelNumber);

		public int RSSI => Wg86tMTZqC(Wlan.WlanIntfOpcode.RSSI);

		public Wlan.WlanRadioState RadioState
		{
			get
			{
				Wlan.AcQxMlYEKl(Wlan.WlanQueryInterface(e98643ex6P.StX6EcRx5j, jvF6rPHq8p.interfaceGuid, Wlan.WlanIntfOpcode.RadioState, IntPtr.Zero, out var _, out var ppData, out var _));
				try
				{
					return (Wlan.WlanRadioState)Marshal.PtrToStructure(ppData, typeof(Wlan.WlanRadioState));
				}
				finally
				{
					Wlan.WlanFreeMemory(ppData);
				}
			}
		}

		public Wlan.Dot11OperationMode CurrentOperationMode => (Wlan.Dot11OperationMode)Wg86tMTZqC(Wlan.WlanIntfOpcode.CurrentOperationMode);

		public Wlan.WlanConnectionAttributes CurrentConnection
		{
			get
			{
				Wlan.AcQxMlYEKl(Wlan.WlanQueryInterface(e98643ex6P.StX6EcRx5j, jvF6rPHq8p.interfaceGuid, Wlan.WlanIntfOpcode.CurrentConnection, IntPtr.Zero, out var _, out var ppData, out var _));
				try
				{
					return (Wlan.WlanConnectionAttributes)Marshal.PtrToStructure(ppData, typeof(Wlan.WlanConnectionAttributes));
				}
				finally
				{
					Wlan.WlanFreeMemory(ppData);
				}
			}
		}

		public NetworkInterface NetworkInterface
		{
			get
			{
				NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
				foreach (NetworkInterface networkInterface in allNetworkInterfaces)
				{
					if (new Guid(networkInterface.Id).Equals(jvF6rPHq8p.interfaceGuid))
					{
						return networkInterface;
					}
				}
				return null;
			}
		}

		public Guid InterfaceGuid => jvF6rPHq8p.interfaceGuid;

		public string InterfaceDescription => jvF6rPHq8p.interfaceDescription;

		public string InterfaceName => NetworkInterface.Name;

		public event WlanNotificationEventHandler WlanNotification
		{
			[CompilerGenerated]
			add
			{
				WlanNotificationEventHandler wlanNotificationEventHandler = rPY683ys4A;
				WlanNotificationEventHandler wlanNotificationEventHandler2;
				do
				{
					wlanNotificationEventHandler2 = wlanNotificationEventHandler;
					WlanNotificationEventHandler value2 = (WlanNotificationEventHandler)Delegate.Combine(wlanNotificationEventHandler2, value);
					wlanNotificationEventHandler = Interlocked.CompareExchange(ref rPY683ys4A, value2, wlanNotificationEventHandler2);
				}
				while ((object)wlanNotificationEventHandler != wlanNotificationEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				WlanNotificationEventHandler wlanNotificationEventHandler = rPY683ys4A;
				WlanNotificationEventHandler wlanNotificationEventHandler2;
				do
				{
					wlanNotificationEventHandler2 = wlanNotificationEventHandler;
					WlanNotificationEventHandler value2 = (WlanNotificationEventHandler)Delegate.Remove(wlanNotificationEventHandler2, value);
					wlanNotificationEventHandler = Interlocked.CompareExchange(ref rPY683ys4A, value2, wlanNotificationEventHandler2);
				}
				while ((object)wlanNotificationEventHandler != wlanNotificationEventHandler2);
			}
		}

		public event WlanConnectionNotificationEventHandler WlanConnectionNotification
		{
			[CompilerGenerated]
			add
			{
				WlanConnectionNotificationEventHandler wlanConnectionNotificationEventHandler = sXA6lBceeW;
				WlanConnectionNotificationEventHandler wlanConnectionNotificationEventHandler2;
				do
				{
					wlanConnectionNotificationEventHandler2 = wlanConnectionNotificationEventHandler;
					WlanConnectionNotificationEventHandler value2 = (WlanConnectionNotificationEventHandler)Delegate.Combine(wlanConnectionNotificationEventHandler2, value);
					wlanConnectionNotificationEventHandler = Interlocked.CompareExchange(ref sXA6lBceeW, value2, wlanConnectionNotificationEventHandler2);
				}
				while ((object)wlanConnectionNotificationEventHandler != wlanConnectionNotificationEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				WlanConnectionNotificationEventHandler wlanConnectionNotificationEventHandler = sXA6lBceeW;
				WlanConnectionNotificationEventHandler wlanConnectionNotificationEventHandler2;
				do
				{
					wlanConnectionNotificationEventHandler2 = wlanConnectionNotificationEventHandler;
					WlanConnectionNotificationEventHandler value2 = (WlanConnectionNotificationEventHandler)Delegate.Remove(wlanConnectionNotificationEventHandler2, value);
					wlanConnectionNotificationEventHandler = Interlocked.CompareExchange(ref sXA6lBceeW, value2, wlanConnectionNotificationEventHandler2);
				}
				while ((object)wlanConnectionNotificationEventHandler != wlanConnectionNotificationEventHandler2);
			}
		}

		public event WlanReasonNotificationEventHandler WlanReasonNotification
		{
			[CompilerGenerated]
			add
			{
				WlanReasonNotificationEventHandler wlanReasonNotificationEventHandler = wU36nfQkCA;
				WlanReasonNotificationEventHandler wlanReasonNotificationEventHandler2;
				do
				{
					wlanReasonNotificationEventHandler2 = wlanReasonNotificationEventHandler;
					WlanReasonNotificationEventHandler value2 = (WlanReasonNotificationEventHandler)Delegate.Combine(wlanReasonNotificationEventHandler2, value);
					wlanReasonNotificationEventHandler = Interlocked.CompareExchange(ref wU36nfQkCA, value2, wlanReasonNotificationEventHandler2);
				}
				while ((object)wlanReasonNotificationEventHandler != wlanReasonNotificationEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				WlanReasonNotificationEventHandler wlanReasonNotificationEventHandler = wU36nfQkCA;
				WlanReasonNotificationEventHandler wlanReasonNotificationEventHandler2;
				do
				{
					wlanReasonNotificationEventHandler2 = wlanReasonNotificationEventHandler;
					WlanReasonNotificationEventHandler value2 = (WlanReasonNotificationEventHandler)Delegate.Remove(wlanReasonNotificationEventHandler2, value);
					wlanReasonNotificationEventHandler = Interlocked.CompareExchange(ref wU36nfQkCA, value2, wlanReasonNotificationEventHandler2);
				}
				while ((object)wlanReasonNotificationEventHandler != wlanReasonNotificationEventHandler2);
			}
		}

		internal WlanInterface(WlanClient client, Wlan.WlanInterfaceInfo info)
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			pnY6bBSPr0 = new AutoResetEvent(initialState: false);
			fj265BC5MN = new Queue<object>();
			base._002Ector();
			e98643ex6P = client;
			jvF6rPHq8p = info;
		}

		private void eRa6od9n6h(Wlan.WlanIntfOpcode P_0, int P_1)
		{
			nint num = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(num, P_1);
			try
			{
				Wlan.AcQxMlYEKl(Wlan.WlanSetInterface(e98643ex6P.StX6EcRx5j, jvF6rPHq8p.interfaceGuid, P_0, 4u, num, IntPtr.Zero));
			}
			finally
			{
				Marshal.FreeHGlobal(num);
			}
		}

		private int Wg86tMTZqC(Wlan.WlanIntfOpcode P_0)
		{
			Wlan.AcQxMlYEKl(Wlan.WlanQueryInterface(e98643ex6P.StX6EcRx5j, jvF6rPHq8p.interfaceGuid, P_0, IntPtr.Zero, out var _, out var ppData, out var _));
			try
			{
				return Marshal.ReadInt32(ppData);
			}
			finally
			{
				Wlan.WlanFreeMemory(ppData);
			}
		}

		public void Scan()
		{
			Wlan.AcQxMlYEKl(Wlan.WlanScan(e98643ex6P.StX6EcRx5j, jvF6rPHq8p.interfaceGuid, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero));
		}

		private static Wlan.WlanAvailableNetwork[] kgn6DhOfnE(nint P_0)
		{
			Wlan.o9dMYRVbt2EHHdbvay o9dMYRVbt2EHHdbvay = (Wlan.o9dMYRVbt2EHHdbvay)Marshal.PtrToStructure(P_0, typeof(Wlan.o9dMYRVbt2EHHdbvay));
			long num = ((IntPtr)P_0).ToInt64() + Marshal.SizeOf(typeof(Wlan.o9dMYRVbt2EHHdbvay));
			Wlan.WlanAvailableNetwork[] array = new Wlan.WlanAvailableNetwork[o9dMYRVbt2EHHdbvay.u0BxSTZcic];
			for (int i = 0; i < o9dMYRVbt2EHHdbvay.u0BxSTZcic; i++)
			{
				array[i] = (Wlan.WlanAvailableNetwork)Marshal.PtrToStructure(new IntPtr(num), typeof(Wlan.WlanAvailableNetwork));
				num += Marshal.SizeOf(typeof(Wlan.WlanAvailableNetwork));
			}
			return array;
		}

		public Wlan.WlanAvailableNetwork[] GetAvailableNetworkList(Wlan.WlanGetAvailableNetworkFlags flags)
		{
			Wlan.AcQxMlYEKl(Wlan.WlanGetAvailableNetworkList(e98643ex6P.StX6EcRx5j, jvF6rPHq8p.interfaceGuid, flags, IntPtr.Zero, out var availableNetworkListPtr));
			try
			{
				return kgn6DhOfnE(availableNetworkListPtr);
			}
			finally
			{
				Wlan.WlanFreeMemory(availableNetworkListPtr);
			}
		}

		private static Wlan.WlanBssEntry[] FML6vmBo4N(nint P_0)
		{
			Wlan.ILuWLWRJDYm9oUEJBL luWLWRJDYm9oUEJBL = (Wlan.ILuWLWRJDYm9oUEJBL)Marshal.PtrToStructure(P_0, typeof(Wlan.ILuWLWRJDYm9oUEJBL));
			long num = ((IntPtr)P_0).ToInt64() + Marshal.SizeOf(typeof(Wlan.ILuWLWRJDYm9oUEJBL));
			Wlan.WlanBssEntry[] array = new Wlan.WlanBssEntry[luWLWRJDYm9oUEJBL.TBcxPgROub];
			for (int i = 0; i < luWLWRJDYm9oUEJBL.TBcxPgROub; i++)
			{
				array[i] = (Wlan.WlanBssEntry)Marshal.PtrToStructure(new IntPtr(num), typeof(Wlan.WlanBssEntry));
				num += Marshal.SizeOf(typeof(Wlan.WlanBssEntry));
			}
			return array;
		}

		public Wlan.WlanBssEntry[] GetNetworkBssList()
		{
			Wlan.AcQxMlYEKl(Wlan.WlanGetNetworkBssList(e98643ex6P.StX6EcRx5j, jvF6rPHq8p.interfaceGuid, IntPtr.Zero, Wlan.Dot11BssType.Any, securityEnabled: false, IntPtr.Zero, out var wlanBssList));
			try
			{
				return FML6vmBo4N(wlanBssList);
			}
			finally
			{
				Wlan.WlanFreeMemory(wlanBssList);
			}
		}

		public Wlan.WlanBssEntry[] GetNetworkBssList(Wlan.Dot11Ssid ssid, Wlan.Dot11BssType bssType, bool securityEnabled)
		{
			nint num = Marshal.AllocHGlobal(Marshal.SizeOf(ssid));
			Marshal.StructureToPtr(ssid, num, fDeleteOld: false);
			try
			{
				Wlan.AcQxMlYEKl(Wlan.WlanGetNetworkBssList(e98643ex6P.StX6EcRx5j, jvF6rPHq8p.interfaceGuid, num, bssType, securityEnabled, IntPtr.Zero, out var wlanBssList));
				try
				{
					return FML6vmBo4N(wlanBssList);
				}
				finally
				{
					Wlan.WlanFreeMemory(wlanBssList);
				}
			}
			finally
			{
				Marshal.FreeHGlobal(num);
			}
		}

		protected void Connect(Wlan.WlanConnectionParameters connectionParams)
		{
			Wlan.AcQxMlYEKl(Wlan.WlanConnect(e98643ex6P.StX6EcRx5j, jvF6rPHq8p.interfaceGuid, ref connectionParams, IntPtr.Zero));
		}

		public void Connect(Wlan.WlanConnectionMode connectionMode, Wlan.Dot11BssType bssType, string profile)
		{
			Connect(new Wlan.WlanConnectionParameters
			{
				wlanConnectionMode = connectionMode,
				profile = profile,
				dot11BssType = bssType,
				flags = (Wlan.WlanConnectionFlags)0
			});
		}

		public bool ConnectSynchronously(Wlan.WlanConnectionMode connectionMode, Wlan.Dot11BssType bssType, string profile, int connectTimeout)
		{
			WSJ61A0I27 = true;
			try
			{
				Connect(connectionMode, bssType, profile);
				while (WSJ61A0I27 && pnY6bBSPr0.WaitOne(connectTimeout, exitContext: true))
				{
					lock (fj265BC5MN)
					{
						while (fj265BC5MN.Count != 0)
						{
							if (fj265BC5MN.Dequeue() is waOL4Na8GID53dM0bI waOL4Na8GID53dM0bI)
							{
								if (waOL4Na8GID53dM0bI.i4b6UbjWI7.notificationSource == Wlan.WlanNotificationSource.ACM && waOL4Na8GID53dM0bI.i4b6UbjWI7.notificationCode == 10 && waOL4Na8GID53dM0bI.klv6mbTEg6.profileName == profile)
								{
									return true;
								}
								break;
							}
						}
					}
				}
			}
			finally
			{
				WSJ61A0I27 = false;
				fj265BC5MN.Clear();
			}
			return false;
		}

		public void Connect(Wlan.WlanConnectionMode connectionMode, Wlan.Dot11BssType bssType, Wlan.Dot11Ssid ssid, Wlan.WlanConnectionFlags flags)
		{
			Wlan.WlanConnectionParameters connectionParams = new Wlan.WlanConnectionParameters
			{
				wlanConnectionMode = connectionMode,
				dot11SsidPtr = Marshal.AllocHGlobal(Marshal.SizeOf(ssid))
			};
			Marshal.StructureToPtr(ssid, connectionParams.dot11SsidPtr, fDeleteOld: false);
			connectionParams.dot11BssType = bssType;
			connectionParams.flags = flags;
			Connect(connectionParams);
			Marshal.DestroyStructure(connectionParams.dot11SsidPtr, ssid.GetType());
			Marshal.FreeHGlobal(connectionParams.dot11SsidPtr);
		}

		public void DeleteProfile(string profileName)
		{
			Wlan.AcQxMlYEKl(Wlan.WlanDeleteProfile(e98643ex6P.StX6EcRx5j, jvF6rPHq8p.interfaceGuid, profileName, IntPtr.Zero));
		}

		public Wlan.WlanReasonCode SetProfile(Wlan.WlanProfileFlags flags, string profileXml, bool overwrite)
		{
			Wlan.AcQxMlYEKl(Wlan.WlanSetProfile(e98643ex6P.StX6EcRx5j, jvF6rPHq8p.interfaceGuid, flags, profileXml, null, overwrite, IntPtr.Zero, out var reasonCode));
			return reasonCode;
		}

		public string GetProfileXml(string profileName)
		{
			Wlan.AcQxMlYEKl(Wlan.WlanGetProfile(e98643ex6P.StX6EcRx5j, jvF6rPHq8p.interfaceGuid, profileName, IntPtr.Zero, out var profileXml, out var _, out var _));
			try
			{
				return Marshal.PtrToStringUni(profileXml);
			}
			finally
			{
				Wlan.WlanFreeMemory(profileXml);
			}
		}

		public Wlan.WlanProfileInfo[] GetProfiles()
		{
			Wlan.AcQxMlYEKl(Wlan.WlanGetProfileList(e98643ex6P.StX6EcRx5j, jvF6rPHq8p.interfaceGuid, IntPtr.Zero, out var profileList));
			try
			{
				Wlan.n0QCQ7kTdSKSPpInHn structure = (Wlan.n0QCQ7kTdSKSPpInHn)Marshal.PtrToStructure(profileList, typeof(Wlan.n0QCQ7kTdSKSPpInHn));
				Wlan.WlanProfileInfo[] array = new Wlan.WlanProfileInfo[structure.vH26RrDpAH];
				long num = ((IntPtr)profileList).ToInt64() + Marshal.SizeOf(structure);
				for (int i = 0; i < structure.vH26RrDpAH; i++)
				{
					num += Marshal.SizeOf(array[i] = (Wlan.WlanProfileInfo)Marshal.PtrToStructure(new IntPtr(num), typeof(Wlan.WlanProfileInfo)));
				}
				return array;
			}
			finally
			{
				Wlan.WlanFreeMemory(profileList);
			}
		}

		internal void tdS6Ju86UQ(Wlan.WlanNotificationData P_0, Wlan.WlanConnectionNotificationData P_1)
		{
			if (sXA6lBceeW != null)
			{
				sXA6lBceeW(P_0, P_1);
			}
			if (WSJ61A0I27)
			{
				T2e67IRE1F(new waOL4Na8GID53dM0bI
				{
					i4b6UbjWI7 = P_0,
					klv6mbTEg6 = P_1
				});
			}
		}

		internal void A4F6e2fWVb(Wlan.WlanNotificationData P_0, Wlan.WlanReasonCode P_1)
		{
			if (wU36nfQkCA != null)
			{
				wU36nfQkCA(P_0, P_1);
			}
			if (WSJ61A0I27)
			{
				T2e67IRE1F(new hd0k5tXrg0VMetr34J
				{
					PGN6jsuEZc = P_0,
					wd66fGeFmL = P_1
				});
			}
		}

		internal void VPp6Kanhrd(Wlan.WlanNotificationData P_0)
		{
			if (rPY683ys4A != null)
			{
				rPY683ys4A(P_0);
			}
		}

		private void T2e67IRE1F(object P_0)
		{
			lock (fj265BC5MN)
			{
				fj265BC5MN.Enqueue(P_0);
			}
			pnY6bBSPr0.Set();
		}
	}

	private nint StX6EcRx5j;

	private uint hiR6Bjhtnb;

	private readonly Wlan.WlanNotificationCallbackDelegate pdb63ypOSp;

	private readonly Dictionary<Guid, WlanInterface> Hyv624D0eD;

	public WlanInterface[] Interfaces
	{
		get
		{
			Wlan.AcQxMlYEKl(Wlan.WlanEnumInterfaces(StX6EcRx5j, IntPtr.Zero, out var ppInterfaceList));
			try
			{
				Wlan.yFrBNPAOw6BkivSbLq structure = (Wlan.yFrBNPAOw6BkivSbLq)Marshal.PtrToStructure(ppInterfaceList, typeof(Wlan.yFrBNPAOw6BkivSbLq));
				long num = ((IntPtr)ppInterfaceList).ToInt64() + Marshal.SizeOf(structure);
				WlanInterface[] array = new WlanInterface[structure.s5q6uDA7IU];
				List<Guid> list = new List<Guid>();
				for (int i = 0; i < structure.s5q6uDA7IU; i++)
				{
					Wlan.WlanInterfaceInfo wlanInterfaceInfo = (Wlan.WlanInterfaceInfo)Marshal.PtrToStructure(new IntPtr(num), typeof(Wlan.WlanInterfaceInfo));
					num += Marshal.SizeOf(wlanInterfaceInfo);
					list.Add(wlanInterfaceInfo.interfaceGuid);
					if (!Hyv624D0eD.TryGetValue(wlanInterfaceInfo.interfaceGuid, out var value))
					{
						value = new WlanInterface(this, wlanInterfaceInfo);
						Hyv624D0eD[wlanInterfaceInfo.interfaceGuid] = value;
					}
					array[i] = value;
				}
				Queue<Guid> queue = new Queue<Guid>();
				foreach (Guid key2 in Hyv624D0eD.Keys)
				{
					if (!list.Contains(key2))
					{
						queue.Enqueue(key2);
					}
				}
				while (queue.Count != 0)
				{
					Guid key = queue.Dequeue();
					Hyv624D0eD.Remove(key);
				}
				return array;
			}
			finally
			{
				Wlan.WlanFreeMemory(ppInterfaceList);
			}
		}
	}

	public WlanClient()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		Hyv624D0eD = new Dictionary<Guid, WlanInterface>();
		base._002Ector();
		Wlan.AcQxMlYEKl(Wlan.WlanOpenHandle(1u, IntPtr.Zero, out hiR6Bjhtnb, out StX6EcRx5j));
		try
		{
			pdb63ypOSp = S3v66VZyks;
			Wlan.AcQxMlYEKl(Wlan.WlanRegisterNotification(StX6EcRx5j, Wlan.WlanNotificationSource.All, ignoreDuplicate: false, pdb63ypOSp, IntPtr.Zero, IntPtr.Zero, out var _));
		}
		catch
		{
			oQ16YvQt4u();
			throw;
		}
	}

	void IDisposable.Dispose()
	{
		GC.SuppressFinalize(this);
		oQ16YvQt4u();
	}

	~WlanClient()
	{
		oQ16YvQt4u();
	}

	private void oQ16YvQt4u()
	{
		if (StX6EcRx5j != IntPtr.Zero)
		{
			Wlan.WlanCloseHandle(StX6EcRx5j, IntPtr.Zero);
			StX6EcRx5j = IntPtr.Zero;
		}
	}

	private static Wlan.WlanConnectionNotificationData? TIM6x0n1MY(ref Wlan.WlanNotificationData P_0)
	{
		int num = Marshal.SizeOf(typeof(Wlan.WlanConnectionNotificationData));
		if (P_0.dataSize < num)
		{
			return null;
		}
		Wlan.WlanConnectionNotificationData value = (Wlan.WlanConnectionNotificationData)Marshal.PtrToStructure(P_0.dataPtr, typeof(Wlan.WlanConnectionNotificationData));
		if (value.wlanReasonCode == Wlan.WlanReasonCode.Success)
		{
			nint ptr = new IntPtr(((IntPtr)P_0.dataPtr).ToInt64() + ((IntPtr)Marshal.OffsetOf(typeof(Wlan.WlanConnectionNotificationData), so95DAFNMfktfjp4Dm.An6v7kuCGg(8034))).ToInt64());
			value.profileXml = Marshal.PtrToStringUni(ptr);
		}
		return value;
	}

	private void S3v66VZyks(ref Wlan.WlanNotificationData P_0, nint P_1)
	{
		Hyv624D0eD.TryGetValue(P_0.interfaceGuid, out var value);
		switch (P_0.notificationSource)
		{
		case Wlan.WlanNotificationSource.ACM:
			switch ((Wlan.WlanNotificationCodeAcm)P_0.notificationCode)
			{
			case Wlan.WlanNotificationCodeAcm.ConnectionStart:
			case Wlan.WlanNotificationCodeAcm.ConnectionComplete:
			case Wlan.WlanNotificationCodeAcm.ConnectionAttemptFail:
			case Wlan.WlanNotificationCodeAcm.Disconnecting:
			case Wlan.WlanNotificationCodeAcm.Disconnected:
			{
				Wlan.WlanConnectionNotificationData? wlanConnectionNotificationData2 = TIM6x0n1MY(ref P_0);
				if (wlanConnectionNotificationData2.HasValue)
				{
					value?.tdS6Ju86UQ(P_0, wlanConnectionNotificationData2.Value);
				}
				break;
			}
			case Wlan.WlanNotificationCodeAcm.ScanFail:
			{
				int num = Marshal.SizeOf(typeof(int));
				if (P_0.dataSize >= num)
				{
					Wlan.WlanReasonCode wlanReasonCode = (Wlan.WlanReasonCode)Marshal.ReadInt32(P_0.dataPtr);
					value?.A4F6e2fWVb(P_0, wlanReasonCode);
				}
				break;
			}
			}
			break;
		case Wlan.WlanNotificationSource.MSM:
		{
			Wlan.WlanNotificationCodeMsm notificationCode = (Wlan.WlanNotificationCodeMsm)P_0.notificationCode;
			if ((uint)(notificationCode - 1) <= 5u || (uint)(notificationCode - 9) <= 4u)
			{
				Wlan.WlanConnectionNotificationData? wlanConnectionNotificationData = TIM6x0n1MY(ref P_0);
				if (wlanConnectionNotificationData.HasValue)
				{
					value?.tdS6Ju86UQ(P_0, wlanConnectionNotificationData.Value);
				}
			}
			break;
		}
		}
		value?.VPp6Kanhrd(P_0);
	}

	public string GetStringForReasonCode(Wlan.WlanReasonCode reasonCode)
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		Wlan.AcQxMlYEKl(Wlan.WlanReasonCodeToString(reasonCode, stringBuilder.Capacity, stringBuilder, IntPtr.Zero));
		return stringBuilder.ToString();
	}
}
