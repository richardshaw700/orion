using System;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using F3frs5SXTsGVtVfuZX;
using GYFmeytn3uk9KnUELA;
using RIrlNToRdPZ6Uy0SYo;

namespace IDRASharedModels;

public class BaseComPortService : CriticalFinalizerObject, IDisposable
{
	public class PortComConfig
	{
		public static int ReadTimeout => 1000;

		public static int WriteTimeout => 1000;

		public static int BaudRate => 2400;

		public static int DataBits => 8;

		public static StopBits StopBits => StopBits.One;

		public static Parity Parity => Parity.None;

		public static bool DtrEnable => true;

		public static bool RtsEnable => true;

		public PortComConfig()
		{
			l26t3npZsnUe1qbsCU.vf2WGHkzGx201();
			base._002Ector();
		}

		static PortComConfig()
		{
			G2089JiDB7k4x1yr7J.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	protected const int MAX_COM_PORT_NO = 16;

	[CompilerGenerated]
	private Action<string> VYfjdH7gO;

	protected string _outputLog;

	protected readonly SerialPort _serialPort;

	public Action<string> DataReceived
	{
		[CompilerGenerated]
		get
		{
			return VYfjdH7gO;
		}
		[CompilerGenerated]
		set
		{
			VYfjdH7gO = value;
		}
	}

	public BaseComPortService(int portNb)
	{
		l26t3npZsnUe1qbsCU.vf2WGHkzGx201();
		_outputLog = "";
		_serialPort = new SerialPort();
		base._002Ector();
		InitStdPortParams();
		SetPortName(portNb);
		SetListener();
	}

	public void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
	{
		try
		{
			DataReceived?.Invoke(_serialPort.ReadExisting());
		}
		catch (Exception ex)
		{
			DataReceived?.Invoke(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(78) + ex.Message + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(72));
		}
	}

	public void Port_DataErrorReceived(object sender, SerialErrorReceivedEventArgs e)
	{
		try
		{
			DataReceived?.Invoke(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(184) + Enum.GetName(typeof(SerialError), e.EventType) + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(46) + _serialPort.ReadExisting() + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(72));
		}
		catch (Exception ex)
		{
			DataReceived?.Invoke(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(232) + ex.Message + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(72));
		}
	}

	public string GetLog()
	{
		return _outputLog;
	}

	public bool IsTMPDeviceAttached()
	{
		bool result = TryOpenPort();
		_serialPort.Close();
		return result;
	}

	public void SendToPort(string cmd)
	{
		try
		{
			if (TryOpenPort())
			{
				_outputLog = _outputLog + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(422) + cmd + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(72);
				_serialPort.WriteLine(cmd);
			}
			else
			{
				_outputLog = _outputLog + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(482) + _serialPort.PortName + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(72);
			}
		}
		catch (Exception ex)
		{
			_outputLog = _outputLog + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(526) + _serialPort.PortName + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(592) + ex.Message + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(72);
		}
	}

	protected void InitStdPortParams()
	{
		_serialPort.ReadTimeout = PortComConfig.ReadTimeout;
		_serialPort.WriteTimeout = PortComConfig.WriteTimeout;
		_serialPort.BaudRate = PortComConfig.BaudRate;
		_serialPort.DataBits = PortComConfig.DataBits;
		_serialPort.StopBits = PortComConfig.StopBits;
		_serialPort.Parity = PortComConfig.Parity;
		_serialPort.DtrEnable = PortComConfig.DtrEnable;
		_serialPort.RtsEnable = PortComConfig.RtsEnable;
	}

	protected void SetPortName(int portNb)
	{
		if (portNb == -1)
		{
			FindCOMPort();
		}
		else
		{
			_serialPort.PortName = string.Format(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(616), portNb);
		}
	}

	protected void SetListener()
	{
		_serialPort.DataReceived += Port_DataReceived;
		_serialPort.ErrorReceived += Port_DataErrorReceived;
	}

	protected void FindCOMPort()
	{
		int num = 1;
		while (num++ < 16 && !_serialPort.IsOpen)
		{
			_serialPort.PortName = string.Format(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(616), num);
			_outputLog += string.Format(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(632), num);
			TryOpenPort();
		}
		if (_serialPort.IsOpen)
		{
			_serialPort.Close();
		}
	}

	public bool TryOpenPort()
	{
		try
		{
			SerialPort serialPort = _serialPort;
			if (serialPort != null && serialPort.IsOpen)
			{
				_outputLog += mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(682);
				return true;
			}
			_outputLog += mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(738);
			_serialPort.Open();
		}
		catch (Exception ex)
		{
			_outputLog = _outputLog + ex.Message + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(72);
			return false;
		}
		return _serialPort.IsOpen;
	}

	public void Dispose()
	{
		try
		{
			_serialPort.Close();
			_serialPort.DataReceived -= Port_DataReceived;
			_serialPort.ErrorReceived -= Port_DataErrorReceived;
			((IDisposable)_serialPort).Dispose();
		}
		catch
		{
		}
	}

	static BaseComPortService()
	{
		G2089JiDB7k4x1yr7J.kLjw4iIsCLsZtxc4lksN0j();
	}
}
