using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using F3frs5SXTsGVtVfuZX;
using GYFmeytn3uk9KnUELA;
using RIrlNToRdPZ6Uy0SYo;

namespace SwingPlateDr;

public class SwingPlateDrService : CriticalFinalizerObject, IDisposable
{
	public class TerrainLiesAngles
	{
		public float LeftRightAngle;

		public float UpDownAngle;

		public TerrainLiesAngles()
		{
			l26t3npZsnUe1qbsCU.vf2WGHkzGx201();
			base._002Ector();
		}

		static TerrainLiesAngles()
		{
			G2089JiDB7k4x1yr7J.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	public class SwingDrAngles
	{
		public int Direction;

		public int Angle;

		public SwingDrAngles()
		{
			l26t3npZsnUe1qbsCU.vf2WGHkzGx201();
			base._002Ector();
		}

		static SwingDrAngles()
		{
			G2089JiDB7k4x1yr7J.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

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

	public enum Direction
	{
		UP,
		UPRIGHT,
		RIGHT,
		DOWNRIGHT,
		DOWN,
		DOWNLEFT,
		LEFT,
		UPLEFT
	}

	private readonly Dictionary<Direction, (int, int)> Drs45XTsG;

	[CompilerGenerated]
	private Action<string> btVefuZXO;

	private string Voiui9ef5;

	private readonly SerialPort jZKUQ2D0v;

	private readonly double M0SYe8Aw9;

	public static Dictionary<Direction, int> DirectionSectorMapping => new Dictionary<Direction, int>
	{
		{
			Direction.UP,
			1
		},
		{
			Direction.UPRIGHT,
			2
		},
		{
			Direction.RIGHT,
			3
		},
		{
			Direction.DOWNRIGHT,
			4
		},
		{
			Direction.DOWN,
			5
		},
		{
			Direction.DOWNLEFT,
			6
		},
		{
			Direction.LEFT,
			7
		},
		{
			Direction.UPLEFT,
			8
		}
	};

	public Action<string> DataReceived
	{
		[CompilerGenerated]
		get
		{
			return btVefuZXO;
		}
		[CompilerGenerated]
		set
		{
			btVefuZXO = value;
		}
	}

	public SwingPlateDrService(int portNb, double minConsideredAngle = 2.0)
	{
		l26t3npZsnUe1qbsCU.vf2WGHkzGx201();
		Drs45XTsG = new Dictionary<Direction, (int, int)>
		{
			{
				Direction.UP,
				(0, 1)
			},
			{
				Direction.UPRIGHT,
				(1, 1)
			},
			{
				Direction.RIGHT,
				(1, 0)
			},
			{
				Direction.DOWNRIGHT,
				(0, -1)
			},
			{
				Direction.DOWN,
				(0, -1)
			},
			{
				Direction.DOWNLEFT,
				(-1, -1)
			},
			{
				Direction.LEFT,
				(-1, 0)
			},
			{
				Direction.UPLEFT,
				(-1, 1)
			}
		};
		Voiui9ef5 = "";
		jZKUQ2D0v = new SerialPort();
		base._002Ector();
		M0SYe8Aw9 = minConsideredAngle;
		kD0VFfOgZ();
		lEHByQH4v(portNb);
		MjJ8IKRlP();
	}

	public void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
	{
		try
		{
			DataReceived?.Invoke(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(0) + Enum.GetName(typeof(SerialError), e.EventType) + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(46) + jZKUQ2D0v.ReadExisting() + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(72));
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
			DataReceived?.Invoke(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(184) + Enum.GetName(typeof(SerialError), e.EventType) + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(46) + jZKUQ2D0v.ReadExisting() + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(72));
		}
		catch (Exception ex)
		{
			DataReceived?.Invoke(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(232) + ex.Message + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(72));
		}
	}

	public string GetLog()
	{
		return Voiui9ef5;
	}

	public bool IsTMPDeviceAttached()
	{
		bool result = G45vO9NpG();
		jZKUQ2D0v.Close();
		return result;
	}

	public void SetAngles(TerrainLiesAngles values)
	{
		Voiui9ef5 = string.Empty;
		SwingDrAngles swingDrAngles = ConvertGSProAngleToSwingPlateAngle(values);
		string text = string.Format(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(348), swingDrAngles.Direction, swingDrAngles.Angle * 10);
		Voiui9ef5 = Voiui9ef5 + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(378) + text + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(72);
		SendToPort(text);
	}

	public void SendToPort(string cmd)
	{
		try
		{
			if (G45vO9NpG())
			{
				Voiui9ef5 = Voiui9ef5 + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(422) + cmd + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(72);
				jZKUQ2D0v.WriteLine(cmd);
			}
			else
			{
				Voiui9ef5 = Voiui9ef5 + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(482) + jZKUQ2D0v.PortName + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(72);
			}
		}
		catch (Exception ex)
		{
			Voiui9ef5 = Voiui9ef5 + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(526) + jZKUQ2D0v.PortName + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(592) + ex.Message + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(72);
		}
	}

	private void kD0VFfOgZ()
	{
		jZKUQ2D0v.ReadTimeout = PortComConfig.ReadTimeout;
		jZKUQ2D0v.WriteTimeout = PortComConfig.WriteTimeout;
		jZKUQ2D0v.BaudRate = PortComConfig.BaudRate;
		jZKUQ2D0v.DataBits = PortComConfig.DataBits;
		jZKUQ2D0v.StopBits = PortComConfig.StopBits;
		jZKUQ2D0v.Parity = PortComConfig.Parity;
		jZKUQ2D0v.DtrEnable = PortComConfig.DtrEnable;
		jZKUQ2D0v.RtsEnable = PortComConfig.RtsEnable;
	}

	private void lEHByQH4v(int P_0)
	{
		if (P_0 == -1)
		{
			pXPs65Yna();
		}
		else
		{
			jZKUQ2D0v.PortName = string.Format(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(616), P_0);
		}
	}

	private void MjJ8IKRlP()
	{
		jZKUQ2D0v.DataReceived += Port_DataReceived;
		jZKUQ2D0v.ErrorReceived += Port_DataErrorReceived;
	}

	private void pXPs65Yna()
	{
		int num = 1;
		while (num++ < 16 && !jZKUQ2D0v.IsOpen)
		{
			jZKUQ2D0v.PortName = string.Format(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(616), num);
			Voiui9ef5 += string.Format(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(632), num);
			G45vO9NpG();
		}
		if (jZKUQ2D0v.IsOpen)
		{
			jZKUQ2D0v.Close();
		}
	}

	private bool G45vO9NpG()
	{
		try
		{
			SerialPort serialPort = jZKUQ2D0v;
			if (serialPort != null && serialPort.IsOpen)
			{
				Voiui9ef5 += mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(682);
				return true;
			}
			Voiui9ef5 += mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(738);
			jZKUQ2D0v.Open();
		}
		catch
		{
		}
		return jZKUQ2D0v.IsOpen;
	}

	public SwingDrAngles ConvertGSProAngleToSwingPlateAngle(TerrainLiesAngles terrainData)
	{
		Voiui9ef5 += string.Format(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(786), terrainData.LeftRightAngle, terrainData.UpDownAngle);
		if ((double)Math.Abs(terrainData.LeftRightAngle) < M0SYe8Aw9 && (double)Math.Abs(terrainData.UpDownAngle) < M0SYe8Aw9)
		{
			Voiui9ef5 += mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(876);
			return new SwingDrAngles
			{
				Angle = 0,
				Direction = 1
			};
		}
		double num = (double)terrainData.UpDownAngle * Math.PI / 180.0;
		double num2 = (double)terrainData.LeftRightAngle * Math.PI / 180.0;
		double[,] array = pALS0jlBq(num);
		double[,] array2 = ye8dBiwHQ(num2);
		double[,] array3 = wMLy8WvMS(array, array2);
		Direction key = dhp0H6kMx(terrainData);
		double[] array4 = new double[3]
		{
			Drs45XTsG[key].Item1,
			Drs45XTsG[key].Item2,
			0.0
		};
		double[] array5 = oYj3vOoRn(array3, array4);
		double arg = Hg0PQ8v53(array4, array5);
		arg = ((Func<double, double, double, double>)((double val, double min, double max) => Math.Min(Math.Max(val, min), max)))(arg, 0.0, 12.0);
		SwingDrAngles swingDrAngles = new SwingDrAngles
		{
			Angle = (int)Math.Round(arg, 2),
			Direction = DirectionSectorMapping[key]
		};
		Voiui9ef5 += string.Format(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(1012), swingDrAngles.Direction, Enum.GetName(typeof(Direction), swingDrAngles.Direction - 1), swingDrAngles.Angle);
		return swingDrAngles;
	}

	private Direction dhp0H6kMx(TerrainLiesAngles P_0)
	{
		double num = P_0.UpDownAngle;
		double num2 = P_0.LeftRightAngle;
		if (num > M0SYe8Aw9)
		{
			if (num2 > M0SYe8Aw9)
			{
				return Direction.UPLEFT;
			}
			if (num2 < 0.0 - M0SYe8Aw9)
			{
				return Direction.UPRIGHT;
			}
			return Direction.UP;
		}
		if (num < 0.0 - M0SYe8Aw9)
		{
			if (num2 > M0SYe8Aw9)
			{
				return Direction.DOWNLEFT;
			}
			if (num2 < 0.0 - M0SYe8Aw9)
			{
				return Direction.DOWNRIGHT;
			}
			return Direction.DOWN;
		}
		if (num2 > M0SYe8Aw9)
		{
			return Direction.LEFT;
		}
		if (num2 < 0.0 - M0SYe8Aw9)
		{
			return Direction.RIGHT;
		}
		return Direction.UP;
	}

	private static double[,] pALS0jlBq(double P_0)
	{
		return new double[3, 3]
		{
			{ 1.0, 0.0, 0.0 },
			{
				0.0,
				Math.Cos(P_0),
				0.0 - Math.Sin(P_0)
			},
			{
				0.0,
				Math.Sin(P_0),
				Math.Cos(P_0)
			}
		};
	}

	private static double[,] ye8dBiwHQ(double P_0)
	{
		return new double[3, 3]
		{
			{
				Math.Cos(P_0),
				0.0 - Math.Sin(P_0),
				0.0
			},
			{
				Math.Sin(P_0),
				Math.Cos(P_0),
				0.0
			},
			{ 0.0, 0.0, 1.0 }
		};
	}

	private static double[,] wMLy8WvMS(double[,] P_0, double[,] P_1)
	{
		double[,] array = new double[3, 3];
		for (int i = 0; i < 3; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				array[i, j] = 0.0;
				for (int k = 0; k < 3; k++)
				{
					array[i, j] += P_0[i, k] * P_1[k, j];
				}
			}
		}
		return array;
	}

	private static double[] oYj3vOoRn(double[,] P_0, double[] P_1)
	{
		double[] array = new double[3];
		for (int i = 0; i < 3; i++)
		{
			array[i] = 0.0;
			for (int j = 0; j < 3; j++)
			{
				array[i] += P_0[i, j] * P_1[j];
			}
		}
		return array;
	}

	private static double UO4gFreLE(double[] P_0, double[] P_1)
	{
		return P_0[0] * P_1[0] + P_0[1] * P_1[1] + P_0[2] * P_1[2];
	}

	private static double UmMDkdWGf(double[] P_0)
	{
		return Math.Sqrt(P_0[0] * P_0[0] + P_0[1] * P_0[1] + P_0[2] * P_0[2]);
	}

	private static double Hg0PQ8v53(double[] P_0, double[] P_1)
	{
		double num = UO4gFreLE(P_0, P_1);
		double num2 = UmMDkdWGf(P_0);
		double num3 = UmMDkdWGf(P_1);
		return Math.Acos(num / (num2 * num3)) * (180.0 / Math.PI);
	}

	public void Dispose()
	{
		try
		{
			jZKUQ2D0v.Close();
			jZKUQ2D0v.DataReceived -= Port_DataReceived;
			jZKUQ2D0v.ErrorReceived -= Port_DataErrorReceived;
			((IDisposable)jZKUQ2D0v).Dispose();
		}
		catch
		{
		}
	}

	static SwingPlateDrService()
	{
		G2089JiDB7k4x1yr7J.kLjw4iIsCLsZtxc4lksN0j();
	}
}
