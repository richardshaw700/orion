using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using GIToolkit.Services;
using HMqMpMdBXjjpY9APqB;
using IDRAAutoCalibration.DTO.Calibration;
using IDRAAutoCalibration.Models;
using IDRAAutoCalibration.Services;
using IDRAAutoCalibration.Services.Calibration;
using IDRAAutoCalibration.Services.Calibration.ValidationMetrics;
using IDRAAutoCalibration.Services.Serialization;
using IodKeMsDBY9RwTYmwo;
using lC3eu0Mx2LvMnHxMwp;
using mMWtJPWctee66WM7q3;
using pgfqOKHc7YGvlOHApI;
using t6xQp4RsrFjWHDL9m5;

namespace IDRAAutoCalibration;

public class MainWindowViewModel : ObservableRecipient, IDisposable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass102_0
	{
		public MainWindowViewModel RWN4Em5jyU;

		public string G4c4QrQvBn;

		public _003C_003Ec__DisplayClass102_0()
		{
			edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
			base._002Ector();
		}

		internal void BIW4PfxMSf()
		{
			RWN4Em5jyU.L6bXbeSx47.AppendLine(G4c4QrQvBn);
			RWN4Em5jyU.LogString = RWN4Em5jyU.L6bXbeSx47.ToString();
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass103_0
	{
		public MainWindowViewModel PeQ4BTjgyH;

		public string bbf4CHPV47;

		public _003C_003Ec__DisplayClass103_0()
		{
			edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
			base._002Ector();
		}

		internal void sxx4aEkEA5()
		{
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			PeQ4BTjgyH.LogString = PeQ4BTjgyH.LogString + bbf4CHPV47 + Environment.NewLine;
			MessageBox.Show(bbf4CHPV47, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(14432), (MessageBoxButton)0, (MessageBoxImage)16);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass106_0
	{
		public StereoCalibrator gfb4TxFTyp;

		public MainWindowViewModel KNK4c7Vqna;

		public _003C_003Ec__DisplayClass106_0()
		{
			edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
			base._002Ector();
		}

		internal StereoCalibrationResult Xwg4yjlfEF()
		{
			return gfb4TxFTyp.CalibrateFromFiles(KNK4c7Vqna.UIFXdFp5he, KNK4c7Vqna.wvdXrPFxNt, KNK4c7Vqna.RceXJbomhk, KNK4c7Vqna.nKTX4c0fOX);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass108_0
	{
		public Mat J0l4GOfoui;

		public Mat K3Q4FKmTv7;

		public MainWindowViewModel LXu4NXw8fH;

		public _003C_003Ec__DisplayClass108_0()
		{
			edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
			base._002Ector();
		}

		internal void hbb42FcaYk()
		{
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			LXu4NXw8fH.IjJugyukQ(J0l4GOfoui.Width, J0l4GOfoui.Height);
			Int32Rect val = default(Int32Rect);
			((Int32Rect)(ref val))._002Ector(0, 0, J0l4GOfoui.Width, J0l4GOfoui.Height);
			int step = J0l4GOfoui.Step;
			int step2 = K3Q4FKmTv7.Step;
			LXu4NXw8fH.DQ0XvIFbFu.WritePixels(val, (IntPtr)J0l4GOfoui.DataPointer, step * J0l4GOfoui.Height, step);
			LXu4NXw8fH.D6ZX98ZXnQ.WritePixels(val, (IntPtr)K3Q4FKmTv7.DataPointer, step2 * K3Q4FKmTv7.Height, step2);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass110_0
	{
		public StereoCalibrator edo4zCQmHP;

		public List<Mat> Ekkn3iBGmv;

		public List<Mat> RSunXJE5fE;

		public MainWindowViewModel op3nMXekHn;

		public _003C_003Ec__DisplayClass110_0()
		{
			edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
			base._002Ector();
		}

		internal StereoCalibrationResult KNy4bOOD7H()
		{
			return edo4zCQmHP.CalibrateFromMats(Ekkn3iBGmv, RSunXJE5fE, op3nMXekHn.uDgXhjWisv[0].Clone(), op3nMXekHn.Lc4Xecsr2q[0].Clone());
		}

		internal void iQx4iTHMFv()
		{
			op3nMXekHn.IsCalibrationCalculationInProgress = false;
			op3nMXekHn.IsCalibrationComplete = true;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass95_0
	{
		public MainWindowViewModel hwwndD2Zmq;

		public CalibrationGuidanceState sbUnr3p8t9;

		public _003C_003Ec__DisplayClass95_0()
		{
			edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
			base._002Ector();
		}

		internal void c45nk9okV9()
		{
			hwwndD2Zmq.GuidanceInstructionText = sbUnr3p8t9.InstructionText;
			hwwndD2Zmq.GuidanceOverall01 = sbUnr3p8t9.Overall01;
			hwwndD2Zmq.GuidanceCoverage01 = sbUnr3p8t9.Coverage01;
			hwwndD2Zmq.GuidanceDepth01 = sbUnr3p8t9.Depth01;
			hwwndD2Zmq.GuidancePitch01 = sbUnr3p8t9.Pitch01;
			hwwndD2Zmq.GuidanceRoll01 = sbUnr3p8t9.Roll01;
			hwwndD2Zmq.GuidanceYaw01 = sbUnr3p8t9.Yaw01;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass98_0
	{
		public StereoCalibrator LPTn4Y6Pg4;

		public CancellationToken N9snnyhdhc;

		public MainWindowViewModel k30n1EKTlu;

		public _003C_003Ec__DisplayClass98_0()
		{
			edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
			base._002Ector();
		}

		internal Task? WumnJX2heR()
		{
			return k30n1EKTlu.Ac7SYGvlO(LPTn4Y6Pg4, k30n1EKTlu.yUwTkSv6y, N9snnyhdhc);
		}
	}

	private readonly Size yUwTkSv6y;

	private readonly Size LsvcOBE7Z;

	private readonly float QPJ25BZrY;

	private readonly int jDlGodKeM;

	private readonly double LBYF9RwTY;

	private readonly int rwoNrdn1D;

	private readonly int Jc3btTSJM;

	private float zwQiwvMWt;

	private Task? fPcztee66;

	private bool yM7X3q3J42;

	private static string VQxXXKTuhW;

	private static string Q1PXM7Nr9l;

	private readonly string y2KXkWGkXf;

	private readonly string UIFXdFp5he;

	private readonly string wvdXrPFxNt;

	private readonly string RceXJbomhk;

	private readonly string nKTX4c0fOX;

	private readonly string rDdXn7CN9d;

	private readonly string WqeX11uDjA;

	private StereoCalibrationResult IsmXOMXdJK;

	private readonly MvsService zxZX6q4xbh;

	private CancellationTokenSource? xuCXHZe8Mn;

	private BlockingCollection<FramePair>? IdlXj9uEhE;

	private readonly Dispatcher fahXRFnC4I;

	private WriteableBitmap? DQ0XvIFbFu;

	private WriteableBitmap? D6ZX98ZXnQ;

	private PointF[]? WuVXU4vOqp;

	private readonly List<Mat> uDgXhjWisv;

	private readonly List<Mat> Lc4Xecsr2q;

	private readonly List<(PointF[] Master, PointF[] Slave)> r3eXm7whmy;

	[NotifyCanExecuteChangedFor("StartCalibrationCommand")]
	[ObservableProperty]
	private bool xQkXuo12mo;

	[ObservableProperty]
	private int yPvX7cve72;

	[ObservableProperty]
	private string QNtX85aBIe;

	[ObservableProperty]
	private string MIpXp2KxRQ;

	[ObservableProperty]
	private string CXIXSgiCT7;

	[ObservableProperty]
	private string VMtXxdsEJm;

	[ObservableProperty]
	private string iLxXsV5sIw;

	[ObservableProperty]
	private WriteableBitmap? RISXqpGS4E;

	[ObservableProperty]
	private WriteableBitmap? cHLXWXW9yv;

	[ObservableProperty]
	private bool YKYXfS1yJX;

	[ObservableProperty]
	private bool H1VXK0O79U;

	[ObservableProperty]
	private bool sWrXVxxxq9;

	[ObservableProperty]
	private bool EuIXIokgyS;

	[ObservableProperty]
	private bool zPiX5VBV3I;

	[ObservableProperty]
	private bool KM8XAhHioE;

	[NotifyCanExecuteChangedFor("ShowHittingZoneCommand")]
	[ObservableProperty]
	[NotifyCanExecuteChangedFor("StartCalibrationCommand")]
	[NotifyCanExecuteChangedFor("StartCamerasCommand")]
	private string hTWXZe1vyJ;

	[ObservableProperty]
	private double JjrXtmSnBQ;

	[ObservableProperty]
	private double o4bX0F29TC;

	[ObservableProperty]
	private double BrsXwHcmx2;

	[ObservableProperty]
	private double lICXoMWPDu;

	[ObservableProperty]
	private double KLGXlDNUSy;

	[ObservableProperty]
	private double wTGXL9woL7;

	[ObservableProperty]
	private string CIqXYboPuM;

	[ObservableProperty]
	private string q1sXDaBkaV;

	[ObservableProperty]
	private WriteableBitmap? pnDXgxyeCa;

	private WriteableBitmap? B1JXPdjMTm;

	[CompilerGenerated]
	private readonly IAsyncRelayCommand zV1XEQucfq;

	[CompilerGenerated]
	private readonly IAsyncRelayCommand SDKXQuRNvZ;

	[CompilerGenerated]
	private readonly IAsyncRelayCommand SVEXaIw2f2;

	[CompilerGenerated]
	private readonly IAsyncRelayCommand JlgXBY9hAi;

	[CompilerGenerated]
	private readonly IRelayCommand q3AXCS2AQO;

	[CompilerGenerated]
	private readonly ICommand j4WXyCh4L7;

	[CompilerGenerated]
	private readonly ICommand PP4XTYmg95;

	[CompilerGenerated]
	private readonly IRelayCommand C8tXcjpibf;

	private Mat? KkbX26npVO;

	private Rectangle T2rXG2fRMJ;

	private bool TZ7XFrYJGD;

	private bool ksqXNqsSas;

	private readonly StringBuilder L6bXbeSx47;

	private string rgtXiII7JQ;

	public string LogButtonText
	{
		get
		{
			if (!IsLogShown)
			{
				return xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1076);
			}
			return xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1098);
		}
	}

	public IAsyncRelayCommand StartCamerasCommand
	{
		[CompilerGenerated]
		get
		{
			return zV1XEQucfq;
		}
	}

	public IAsyncRelayCommand StartCalibrationCommand
	{
		[CompilerGenerated]
		get
		{
			return SDKXQuRNvZ;
		}
	}

	public IAsyncRelayCommand StartCalibrationFromFolderCommand
	{
		[CompilerGenerated]
		get
		{
			return SVEXaIw2f2;
		}
	}

	public IAsyncRelayCommand ShowHittingZoneCommand
	{
		[CompilerGenerated]
		get
		{
			return JlgXBY9hAi;
		}
	}

	public IRelayCommand ShowDistortionViewerCommand
	{
		[CompilerGenerated]
		get
		{
			return q3AXCS2AQO;
		}
	}

	public ICommand ToggleLogCommand
	{
		[CompilerGenerated]
		get
		{
			return j4WXyCh4L7;
		}
	}

	public ICommand OpenSettingsCommand
	{
		[CompilerGenerated]
		get
		{
			return PP4XTYmg95;
		}
	}

	public IRelayCommand ForceAcceptCalibrationCommand
	{
		[CompilerGenerated]
		get
		{
			return C8tXcjpibf;
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public bool StartCalibrationButtonEnabled
	{
		get
		{
			return xQkXuo12mo;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(xQkXuo12mo, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.eJRXRugCo);
				xQkXuo12mo = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.ULvdMnHxM);
				StartCalibrationCommand.NotifyCanExecuteChanged();
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int CalibrationImageCountCaptured
	{
		get
		{
			return yPvX7cve72;
		}
		set
		{
			if (!EqualityComparer<int>.Default.Equals(yPvX7cve72, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.GIBMnO2vx);
				yPvX7cve72 = value;
				gSyVahwYQ(value);
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.HpprOwUq7);
			}
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string CalibrationImageCountProgression
	{
		get
		{
			return QNtX85aBIe;
		}
		[MemberNotNull("calibrationImageCountProgression")]
		set
		{
			if (!EqualityComparer<string>.Default.Equals(QNtX85aBIe, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.CalibrationImageCountProgression);
				QNtX85aBIe = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.CalibrationImageCountProgression);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string LogString
	{
		get
		{
			return MIpXp2KxRQ;
		}
		[MemberNotNull("logString")]
		set
		{
			if (!EqualityComparer<string>.Default.Equals(MIpXp2KxRQ, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.LogString);
				MIpXp2KxRQ = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.LogString);
			}
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string MasterCameraId
	{
		get
		{
			return CXIXSgiCT7;
		}
		[MemberNotNull("masterCameraId")]
		set
		{
			if (!EqualityComparer<string>.Default.Equals(CXIXSgiCT7, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.MasterCameraId);
				CXIXSgiCT7 = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.MasterCameraId);
			}
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string SlaveCameraId
	{
		get
		{
			return VMtXxdsEJm;
		}
		[MemberNotNull("slaveCameraId")]
		set
		{
			if (!EqualityComparer<string>.Default.Equals(VMtXxdsEJm, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.SlaveCameraId);
				VMtXxdsEJm = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.SlaveCameraId);
			}
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string CalibrationOverallValue
	{
		get
		{
			return iLxXsV5sIw;
		}
		[MemberNotNull("calibrationOverallValue")]
		set
		{
			if (!EqualityComparer<string>.Default.Equals(iLxXsV5sIw, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.CalibrationOverallValue);
				iLxXsV5sIw = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.CalibrationOverallValue);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public WriteableBitmap? MasterImage
	{
		get
		{
			return RISXqpGS4E;
		}
		set
		{
			if (!EqualityComparer<WriteableBitmap>.Default.Equals(RISXqpGS4E, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.MasterImage);
				RISXqpGS4E = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.MasterImage);
			}
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public WriteableBitmap? SlaveImage
	{
		get
		{
			return cHLXWXW9yv;
		}
		set
		{
			if (!EqualityComparer<WriteableBitmap>.Default.Equals(cHLXWXW9yv, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.SlaveImage);
				cHLXWXW9yv = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.SlaveImage);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool CalibrationSuccess
	{
		get
		{
			return YKYXfS1yJX;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(YKYXfS1yJX, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.CalibrationSuccess);
				YKYXfS1yJX = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.CalibrationSuccess);
			}
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public bool CalibrationInProgress
	{
		get
		{
			return H1VXK0O79U;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(H1VXK0O79U, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.CalibrationInProgress);
				H1VXK0O79U = value;
				j3EIRm2I7(value);
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.CalibrationInProgress);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool CameraStarted
	{
		get
		{
			return sWrXVxxxq9;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(sWrXVxxxq9, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.CameraStarted);
				sWrXVxxxq9 = value;
				cIQ5hT00f(value);
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.CameraStarted);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsCalibrationComplete
	{
		get
		{
			return EuIXIokgyS;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(EuIXIokgyS, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.IsCalibrationComplete);
				EuIXIokgyS = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.IsCalibrationComplete);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsCalibrationCalculationInProgress
	{
		get
		{
			return zPiX5VBV3I;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(zPiX5VBV3I, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.IsCalibrationCalculationInProgress);
				zPiX5VBV3I = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.IsCalibrationCalculationInProgress);
			}
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public bool IsLogShown
	{
		get
		{
			return KM8XAhHioE;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(KM8XAhHioE, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.IsLogShown);
				KM8XAhHioE = value;
				ReWAq5vJM(value);
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.IsLogShown);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string GuidanceInstructionText
	{
		get
		{
			return hTWXZe1vyJ;
		}
		[MemberNotNull("guidanceInstructionText")]
		set
		{
			if (!EqualityComparer<string>.Default.Equals(hTWXZe1vyJ, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.GuidanceInstructionText);
				hTWXZe1vyJ = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.GuidanceInstructionText);
				StartCalibrationCommand.NotifyCanExecuteChanged();
				StartCamerasCommand.NotifyCanExecuteChanged();
				ShowHittingZoneCommand.NotifyCanExecuteChanged();
			}
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public double GuidanceOverall01
	{
		get
		{
			return JjrXtmSnBQ;
		}
		set
		{
			if (!EqualityComparer<double>.Default.Equals(JjrXtmSnBQ, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.GuidanceOverall01);
				JjrXtmSnBQ = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.GuidanceOverall01);
			}
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public double GuidanceCoverage01
	{
		get
		{
			return o4bX0F29TC;
		}
		set
		{
			if (!EqualityComparer<double>.Default.Equals(o4bX0F29TC, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.GuidanceCoverage01);
				o4bX0F29TC = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.GuidanceCoverage01);
			}
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public double GuidanceDepth01
	{
		get
		{
			return BrsXwHcmx2;
		}
		set
		{
			if (!EqualityComparer<double>.Default.Equals(BrsXwHcmx2, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.GuidanceDepth01);
				BrsXwHcmx2 = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.GuidanceDepth01);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public double GuidancePitch01
	{
		get
		{
			return lICXoMWPDu;
		}
		set
		{
			if (!EqualityComparer<double>.Default.Equals(lICXoMWPDu, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.GuidancePitch01);
				lICXoMWPDu = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.GuidancePitch01);
			}
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public double GuidanceRoll01
	{
		get
		{
			return KLGXlDNUSy;
		}
		set
		{
			if (!EqualityComparer<double>.Default.Equals(KLGXlDNUSy, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.GuidanceRoll01);
				KLGXlDNUSy = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.GuidanceRoll01);
			}
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public double GuidanceYaw01
	{
		get
		{
			return wTGXL9woL7;
		}
		set
		{
			if (!EqualityComparer<double>.Default.Equals(wTGXL9woL7, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.GuidanceYaw01);
				wTGXL9woL7 = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.GuidanceYaw01);
			}
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string StartCalibrationButtonText
	{
		get
		{
			return CIqXYboPuM;
		}
		[MemberNotNull("startCalibrationButtonText")]
		set
		{
			if (!EqualityComparer<string>.Default.Equals(CIqXYboPuM, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.StartCalibrationButtonText);
				CIqXYboPuM = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.StartCalibrationButtonText);
			}
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string StartCameraButtonText
	{
		get
		{
			return q1sXDaBkaV;
		}
		[MemberNotNull("startCameraButtonText")]
		set
		{
			if (!EqualityComparer<string>.Default.Equals(q1sXDaBkaV, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.StartCameraButtonText);
				q1sXDaBkaV = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.StartCameraButtonText);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public WriteableBitmap? HittingZoneImage
	{
		get
		{
			return pnDXgxyeCa;
		}
		set
		{
			if (!EqualityComparer<WriteableBitmap>.Default.Equals(pnDXgxyeCa, value))
			{
				OnPropertyChanging(eJRRugXCo0IBnO2vxE.NjCk3eu0x);
				pnDXgxyeCa = value;
				OnPropertyChanged(uOwUq7kYxgTbVyPEEq.KxgJTbVyP);
			}
		}
	}

	public MainWindowViewModel()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		yUwTkSv6y = new Size(7, 11);
		LsvcOBE7Z = new Size(540, 720);
		QPJ25BZrY = 0.075f;
		jDlGodKeM = 100;
		LBYF9RwTY = 0.6499999761581421;
		rwoNrdn1D = 25;
		Jc3btTSJM = 70;
		zwQiwvMWt = -1f;
		y2KXkWGkXf = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1120);
		UIFXdFp5he = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1250) + VQxXXKTuhW;
		wvdXrPFxNt = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1250) + Q1PXM7Nr9l;
		RceXJbomhk = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1402) + VQxXXKTuhW + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1546);
		nKTX4c0fOX = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1402) + Q1PXM7Nr9l + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1546);
		rDdXn7CN9d = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1570);
		WqeX11uDjA = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1704);
		IsmXOMXdJK = new StereoCalibrationResult();
		fahXRFnC4I = ((DispatcherObject)Application.Current).Dispatcher;
		uDgXhjWisv = new List<Mat>();
		Lc4Xecsr2q = new List<Mat>();
		r3eXm7whmy = new List<(PointF[], PointF[])>();
		xQkXuo12mo = true;
		QNtX85aBIe = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1860);
		MIpXp2KxRQ = string.Empty;
		CXIXSgiCT7 = string.Empty;
		VMtXxdsEJm = string.Empty;
		iLxXsV5sIw = string.Empty;
		hTWXZe1vyJ = "";
		CIqXYboPuM = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1870);
		q1sXDaBkaV = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1908);
		L6bXbeSx47 = new StringBuilder();
		base._002Ector();
		zxZX6q4xbh = new MvsService();
		try
		{
			SDKXQuRNvZ = new AsyncRelayCommand(v5VphgfqO, () => CameraStarted && !ksqXNqsSas);
			zV1XEQucfq = new AsyncRelayCommand(zBqUcQOwZ, () => !CalibrationInProgress);
			SVEXaIw2f2 = new AsyncRelayCommand(yUp8b635L, () => !CameraStarted);
			j4WXyCh4L7 = new RelayCommand(delegate
			{
				IsLogShown = !IsLogShown;
			});
			PP4XTYmg95 = new RelayCommand(qIuhX4rax);
			C8tXcjpibf = new RelayCommand(b0W7nGoeE);
			JlgXBY9hAi = new AsyncRelayCommand(WUV9KQ3fC, () => !CameraStarted && !CalibrationInProgress);
			q3AXCS2AQO = new RelayCommand(NEq4oMqMp);
			zxZX6q4xbh.EnumerateDevices();
			MasterCameraId = zxZX6q4xbh.GetMaster().GetSerialNumber();
			SlaveCameraId = zxZX6q4xbh.GetSlave().GetSerialNumber();
			VQxXXKTuhW = MasterCameraId;
			Q1PXM7Nr9l = SlaveCameraId;
		}
		catch (Exception ex)
		{
			OakmY9gMX(ex.Message);
		}
	}

	private void NEq4oMqMp()
	{
		DistortionViewerWindow distortionViewerWindow = new DistortionViewerWindow();
		((Window)distortionViewerWindow).Owner = Application.Current.MainWindow;
		distortionViewerWindow.SetCalibration(IsmXOMXdJK[CameraRole.Master].CameraMatrix, IsmXOMXdJK[CameraRole.Master].DistCoefficient, IsmXOMXdJK[CameraRole.Slave].CameraMatrix, IsmXOMXdJK[CameraRole.Slave].DistCoefficient, LsvcOBE7Z);
		((Window)distortionViewerWindow).Show();
	}

	private static void cBXnjjpY9(Mat P_0)
	{
		int x = P_0.Cols / 2;
		int y = P_0.Rows / 2;
		MCvScalar color = new MCvScalar(0.0, 0.0, 255.0);
		CvInvoke.Line(P_0, new Point(x, 0), new Point(x, P_0.Rows - 1), color);
		CvInvoke.Line(P_0, new Point(0, y), new Point(P_0.Cols - 1, y), color);
	}

	private Rectangle EPq1BAbvI(Size P_0, PointF P_1)
	{
		int num = 300;
		int num2 = 245;
		int captureROILeftAbsolute = ConfigConstantValue.CaptureROILeftAbsolute;
		int captureROIRightAbsolute = ConfigConstantValue.CaptureROIRightAbsolute;
		float captureROIHorizontalExpandPercent = ConfigConstantValue.CaptureROIHorizontalExpandPercent;
		float captureROIVerticalExpandPercent = ConfigConstantValue.CaptureROIVerticalExpandPercent;
		Rectangle a = new Rectangle(captureROILeftAbsolute, num, P_0.Width - captureROIRightAbsolute - captureROILeftAbsolute, P_0.Height - num2 - num);
		int num3 = (int)MathF.Round((float)a.Width * captureROIHorizontalExpandPercent / 100f);
		int num4 = (int)MathF.Round((float)a.Height * captureROIVerticalExpandPercent / 100f);
		a.X -= num3 / 2;
		a.Width += num3;
		a.Y -= num4 / 2;
		a.Height += num4;
		return Rectangle.Intersect(a, new Rectangle(0, 0, P_0.Width, P_0.Height));
	}

	private Rectangle lsBOO8xZ4(Size P_0, PointF P_1)
	{
		float num = ((!wlN6BQ7nS()) ? 0.38f : pylHydZoC());
		int num2 = (int)MathF.Round(815f * num);
		int num3 = (int)MathF.Round(457f * num);
		if (kApxIlS0s())
		{
			num2 = (int)MathF.Round(870f * num);
		}
		float num4 = 0f * num;
		float num5 = (float)P_0.Width / 2f;
		float num6 = (float)P_0.Height / 2f;
		float num7 = MathF.Max(0f, num5 - (float)num2 / 2f);
		float num8 = MathF.Max(0f, num6 - (float)num3 / 2f + num4);
		float num9 = MathF.Min(P_0.Width, num5 + (float)num2 / 2f);
		float num10 = MathF.Min(P_0.Height, num6 + (float)num3 / 2f + num4);
		return SrcvekkFx(num7, num8, num9, num10);
	}

	private bool wlN6BQ7nS()
	{
		return File.Exists(rDdXn7CN9d);
	}

	private float pylHydZoC()
	{
		if (!wlN6BQ7nS())
		{
			return -1f;
		}
		StereoCalibrationResult stereoCalibrationResult = StereoCalibrationResultXmlReader.Load(rDdXn7CN9d);
		PointF targetPO = stereoCalibrationResult.CameraResults[CameraRole.Master].TargetPO;
		PointF targetPX = stereoCalibrationResult.CameraResults[CameraRole.Master].TargetPX;
		PointF targetPY = stereoCalibrationResult.CameraResults[CameraRole.Master].TargetPY;
		PointF targetPO2 = stereoCalibrationResult.CameraResults[CameraRole.Slave].TargetPO;
		PointF targetPX2 = stereoCalibrationResult.CameraResults[CameraRole.Slave].TargetPX;
		PointF targetPY2 = stereoCalibrationResult.CameraResults[CameraRole.Slave].TargetPY;
		float num = 0.075f;
		int num2 = 11;
		int num3 = 7;
		float num4 = 0.075f * (float)(num2 - 1);
		float num5 = num * (float)(num3 - 1);
		if (num4 <= 0f || num5 <= 0f)
		{
			return -1f;
		}
		float num6 = gdijlhoi5(targetPX, targetPO);
		float num7 = gdijlhoi5(targetPX2, targetPO2);
		float num8 = gdijlhoi5(targetPY, targetPO);
		float num9 = gdijlhoi5(targetPY2, targetPO2);
		float num10 = num6 / num4 / 1000f;
		float num11 = num7 / num4 / 1000f;
		float num12 = num8 / num5 / 1000f;
		float num13 = num9 / num5 / 1000f;
		float num14 = (num10 + num11) / 2f;
		float num15 = (num12 + num13) / 2f;
		zwQiwvMWt = (num14 + num15) / 2f;
		if (zwQiwvMWt <= 0f || float.IsNaN(zwQiwvMWt) || float.IsInfinity(zwQiwvMWt))
		{
			return -1f;
		}
		return zwQiwvMWt;
	}

	private static float gdijlhoi5(PointF P_0, PointF P_1)
	{
		float num = P_0.X - P_1.X;
		float num2 = P_0.Y - P_1.Y;
		return MathF.Sqrt(num * num + num2 * num2);
	}

	private void NQpRCxB8G(StereoCalibrator P_0)
	{
		_003C_003Ec__DisplayClass95_0 CS_0024_003C_003E8__locals16 = new _003C_003Ec__DisplayClass95_0();
		CS_0024_003C_003E8__locals16.hwwndD2Zmq = this;
		CS_0024_003C_003E8__locals16.sbUnr3p8t9 = P_0.CurrentGuidance;
		fahXRFnC4I.Invoke((Action)delegate
		{
			CS_0024_003C_003E8__locals16.hwwndD2Zmq.GuidanceInstructionText = CS_0024_003C_003E8__locals16.sbUnr3p8t9.InstructionText;
			CS_0024_003C_003E8__locals16.hwwndD2Zmq.GuidanceOverall01 = CS_0024_003C_003E8__locals16.sbUnr3p8t9.Overall01;
			CS_0024_003C_003E8__locals16.hwwndD2Zmq.GuidanceCoverage01 = CS_0024_003C_003E8__locals16.sbUnr3p8t9.Coverage01;
			CS_0024_003C_003E8__locals16.hwwndD2Zmq.GuidanceDepth01 = CS_0024_003C_003E8__locals16.sbUnr3p8t9.Depth01;
			CS_0024_003C_003E8__locals16.hwwndD2Zmq.GuidancePitch01 = CS_0024_003C_003E8__locals16.sbUnr3p8t9.Pitch01;
			CS_0024_003C_003E8__locals16.hwwndD2Zmq.GuidanceRoll01 = CS_0024_003C_003E8__locals16.sbUnr3p8t9.Roll01;
			CS_0024_003C_003E8__locals16.hwwndD2Zmq.GuidanceYaw01 = CS_0024_003C_003E8__locals16.sbUnr3p8t9.Yaw01;
		});
	}

	private static Rectangle SrcvekkFx(float P_0, float P_1, float P_2, float P_3)
	{
		int num = (int)MathF.Round(P_0);
		int num2 = (int)MathF.Round(P_1);
		int num3 = (int)MathF.Round(P_2);
		int num4 = (int)MathF.Round(P_3);
		int width = Math.Max(0, num3 - num);
		int height = Math.Max(0, num4 - num2);
		return new Rectangle(num, num2, width, height);
	}

	private async Task WUV9KQ3fC()
	{
		fahXRFnC4I.Invoke((Action)delegate
		{
			IsCalibrationComplete = true;
			ksqXNqsSas = true;
		});
		await zBqUcQOwZ();
	}

	private async Task zBqUcQOwZ()
	{
		if (yM7X3q3J42)
		{
			return;
		}
		yM7X3q3J42 = true;
		try
		{
			_003C_003Ec__DisplayClass98_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass98_0();
			CS_0024_003C_003E8__locals8.k30n1EKTlu = this;
			if (CameraStarted)
			{
				fahXRFnC4I.Invoke((Action)delegate
				{
					CameraStarted = false;
					ksqXNqsSas = false;
				});
				await (xuCXHZe8Mn?.CancelAsync());
				if (fPcztee66 != null)
				{
					try
					{
						await fPcztee66;
					}
					catch
					{
					}
				}
				zxZX6q4xbh.StopGrabbings();
				return;
			}
			fahXRFnC4I.Invoke((Action)delegate
			{
				IsCalibrationComplete = false;
				CameraStarted = true;
			});
			zxZX6q4xbh.OpenDevices();
			MasterCameraId = zxZX6q4xbh.GetMaster().GetSerialNumber();
			SlaveCameraId = zxZX6q4xbh.GetSlave().GetSerialNumber();
			xuCXHZe8Mn = new CancellationTokenSource();
			IdlXj9uEhE = new BlockingCollection<FramePair>(new ConcurrentQueue<FramePair>());
			await zxZX6q4xbh.StartLowSpeedAcquisition();
			CS_0024_003C_003E8__locals8.LPTn4Y6Pg4 = new StereoCalibrator(yUwTkSv6y, QPJ25BZrY, LBYF9RwTY);
			CS_0024_003C_003E8__locals8.N9snnyhdhc = xuCXHZe8Mn.Token;
			fPcztee66 = Task.Run(() => CS_0024_003C_003E8__locals8.k30n1EKTlu.Ac7SYGvlO(CS_0024_003C_003E8__locals8.LPTn4Y6Pg4, CS_0024_003C_003E8__locals8.k30n1EKTlu.yUwTkSv6y, CS_0024_003C_003E8__locals8.N9snnyhdhc), CS_0024_003C_003E8__locals8.N9snnyhdhc);
		}
		finally
		{
			yM7X3q3J42 = false;
		}
	}

	private void qIuhX4rax()
	{
		SettingsWindow settingsWindow = new SettingsWindow();
		((Window)settingsWindow).Owner = Application.Current.MainWindow;
		((Window)settingsWindow).WindowStartupLocation = (WindowStartupLocation)2;
		((Window)settingsWindow).ShowDialog();
	}

	private void za2eUf2YK(string P_0)
	{
		_003C_003Ec__DisplayClass102_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass102_0();
		CS_0024_003C_003E8__locals8.RWN4Em5jyU = this;
		CS_0024_003C_003E8__locals8.G4c4QrQvBn = P_0;
		if (!(CS_0024_003C_003E8__locals8.G4c4QrQvBn == rgtXiII7JQ))
		{
			rgtXiII7JQ = CS_0024_003C_003E8__locals8.G4c4QrQvBn;
			fahXRFnC4I.Invoke((Action)delegate
			{
				CS_0024_003C_003E8__locals8.RWN4Em5jyU.L6bXbeSx47.AppendLine(CS_0024_003C_003E8__locals8.G4c4QrQvBn);
				CS_0024_003C_003E8__locals8.RWN4Em5jyU.LogString = CS_0024_003C_003E8__locals8.RWN4Em5jyU.L6bXbeSx47.ToString();
			});
		}
	}

	private void OakmY9gMX(string P_0)
	{
		_003C_003Ec__DisplayClass103_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass103_0();
		CS_0024_003C_003E8__locals6.PeQ4BTjgyH = this;
		CS_0024_003C_003E8__locals6.bbf4CHPV47 = P_0;
		fahXRFnC4I.Invoke((Action)delegate
		{
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			CS_0024_003C_003E8__locals6.PeQ4BTjgyH.LogString = CS_0024_003C_003E8__locals6.PeQ4BTjgyH.LogString + CS_0024_003C_003E8__locals6.bbf4CHPV47 + Environment.NewLine;
			MessageBox.Show(CS_0024_003C_003E8__locals6.bbf4CHPV47, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(14432), (MessageBoxButton)0, (MessageBoxImage)16);
		});
	}

	private void IjJugyukQ(int P_0, int P_1)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		if (DQ0XvIFbFu == null || ((BitmapSource)DQ0XvIFbFu).PixelWidth != P_0 || ((BitmapSource)DQ0XvIFbFu).PixelHeight != P_1)
		{
			DQ0XvIFbFu = new WriteableBitmap(P_0, P_1, 96.0, 96.0, PixelFormats.Bgr24, (BitmapPalette)null);
			MasterImage = DQ0XvIFbFu;
		}
		if (D6ZX98ZXnQ == null || ((BitmapSource)D6ZX98ZXnQ).PixelWidth != P_0 || ((BitmapSource)D6ZX98ZXnQ).PixelHeight != P_1)
		{
			D6ZX98ZXnQ = new WriteableBitmap(P_0, P_1, 96.0, 96.0, PixelFormats.Bgr24, (BitmapPalette)null);
			SlaveImage = D6ZX98ZXnQ;
		}
	}

	private void b0W7nGoeE()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		Op4WsrFjW(rDdXn7CN9d);
		new CalibrationResultXmlSerializer().Serialize(rDdXn7CN9d, IsmXOMXdJK);
		MessageBox.Show(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1938), xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2076), (MessageBoxButton)0, (MessageBoxImage)64);
	}

	private async Task yUp8b635L()
	{
		fahXRFnC4I.Invoke((Action)delegate
		{
			CalibrationInProgress = true;
			IsCalibrationComplete = false;
			CalibrationSuccess = false;
			IsCalibrationCalculationInProgress = true;
		});
		try
		{
			_003C_003Ec__DisplayClass106_0 _003C_003Ec__DisplayClass106_ = new _003C_003Ec__DisplayClass106_0();
			_003C_003Ec__DisplayClass106_.KNK4c7Vqna = this;
			_003C_003Ec__DisplayClass106_.gfb4TxFTyp = new StereoCalibrator(yUwTkSv6y, QPJ25BZrY, jDlGodKeM);
			IsmXOMXdJK = await Task.Run(() => _003C_003Ec__DisplayClass106_.gfb4TxFTyp.CalibrateFromFiles(_003C_003Ec__DisplayClass106_.KNK4c7Vqna.UIFXdFp5he, _003C_003Ec__DisplayClass106_.KNK4c7Vqna.wvdXrPFxNt, _003C_003Ec__DisplayClass106_.KNK4c7Vqna.RceXJbomhk, _003C_003Ec__DisplayClass106_.KNK4c7Vqna.nKTX4c0fOX));
			IsmXOMXdJK[CameraRole.Master].CameraId = VQxXXKTuhW;
			IsmXOMXdJK[CameraRole.Slave].CameraId = Q1PXM7Nr9l;
			BoardSpacingScaleReport boardSpacingScaleReport = BoardScaleValidator.AnalyzeScaleFromDotGrid(IsmXOMXdJK[CameraRole.Master].CameraMatrix, IsmXOMXdJK[CameraRole.Master].DistCoefficient, IsmXOMXdJK[CameraRole.Slave].CameraMatrix, IsmXOMXdJK[CameraRole.Slave].DistCoefficient, IsmXOMXdJK.RotationMatrix, IsmXOMXdJK.TranslationVector, LsvcOBE7Z, yUwTkSv6y, 0.075, r3eXm7whmy);
			za2eUf2YK(boardSpacingScaleReport.ToString());
			CalibrationSuccess = t6RqMd76x(IsmXOMXdJK) && boardSpacingScaleReport.SpacingScaleErrorPercent < 0.01;
			if (CalibrationSuccess)
			{
				CalibrationResultXmlSerializer calibrationResultXmlSerializer = new CalibrationResultXmlSerializer();
				string text = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1570);
				Op4WsrFjW(text);
				calibrationResultXmlSerializer.Serialize(text, IsmXOMXdJK);
			}
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
			OakmY9gMX(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(14752) + ex.Message + Environment.NewLine + ex.StackTrace);
		}
		finally
		{
			fahXRFnC4I.Invoke((Action)delegate
			{
				IsCalibrationCalculationInProgress = false;
				IsCalibrationComplete = true;
				CalibrationInProgress = false;
			});
		}
	}

	private async Task v5VphgfqO()
	{
		fahXRFnC4I.Invoke((Action)delegate
		{
			StartCalibrationButtonEnabled = false;
			ksqXNqsSas = false;
		});
		try
		{
			LogString = "";
			L6bXbeSx47.Clear();
			CalibrationImageCountCaptured = 0;
			WuVXU4vOqp = null;
			uDgXhjWisv.ForEach(delegate(Mat m)
			{
				m.Dispose();
			});
			Lc4Xecsr2q.ForEach(delegate(Mat m)
			{
				m.Dispose();
			});
			uDgXhjWisv.Clear();
			Lc4Xecsr2q.Clear();
			r3eXm7whmy.Clear();
			GuidanceInstructionText = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(14672);
			MainWindowViewModel mainWindowViewModel = this;
			MainWindowViewModel mainWindowViewModel2 = this;
			MainWindowViewModel mainWindowViewModel3 = this;
			MainWindowViewModel mainWindowViewModel4 = this;
			MainWindowViewModel mainWindowViewModel5 = this;
			double num = (GuidanceYaw01 = 0.0);
			double num3 = (mainWindowViewModel5.GuidanceRoll01 = num);
			double num5 = (mainWindowViewModel4.GuidancePitch01 = num3);
			double num7 = (mainWindowViewModel3.GuidanceDepth01 = num5);
			double guidanceOverall = (mainWindowViewModel2.GuidanceCoverage01 = num7);
			mainWindowViewModel.GuidanceOverall01 = guidanceOverall;
			if (CalibrationInProgress)
			{
				try
				{
					await (xuCXHZe8Mn?.CancelAsync());
					zxZX6q4xbh.StopGrabbings();
					fahXRFnC4I.Invoke<bool>((Func<bool>)(() => CalibrationInProgress = false));
					return;
				}
				catch (Exception ex)
				{
					OakmY9gMX(ex.Message);
				}
			}
			fahXRFnC4I.Invoke((Action)delegate
			{
				CalibrationInProgress = true;
				StartCalibrationButtonEnabled = false;
			});
		}
		catch (Exception ex2)
		{
			EventViewerLogger.LogException(ex2);
			za2eUf2YK(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(14752) + ex2.Message + Environment.NewLine + ex2.StackTrace);
			fahXRFnC4I.Invoke((Action)delegate
			{
				CalibrationInProgress = false;
				CameraStarted = false;
				StartCalibrationButtonEnabled = false;
			});
			xuCXHZe8Mn?.Cancel();
			zxZX6q4xbh.StopGrabbings();
		}
	}

	private async Task Ac7SYGvlO(StereoCalibrator P_0, Size P_1, CancellationToken P_2)
	{
		_ = 2;
		try
		{
			CalibrationImageCountCaptured = 0;
			WuVXU4vOqp = null;
			while (!P_2.IsCancellationRequested)
			{
				_003C_003Ec__DisplayClass108_0 CS_0024_003C_003E8__locals47 = new _003C_003Ec__DisplayClass108_0();
				CS_0024_003C_003E8__locals47.LXu4NXw8fH = this;
				if (zxZX6q4xbh.AreGrabbing())
				{
					Frame frame = zxZX6q4xbh.GetMaster().GetFrame();
					Frame frame2 = zxZX6q4xbh.GetSlave().GetFrame();
					CS_0024_003C_003E8__locals47.J0l4GOfoui = frame.GetImage(zxZX6q4xbh.GetMaster().GetCameraRotation());
					try
					{
						CS_0024_003C_003E8__locals47.K3Q4FKmTv7 = frame2.GetImage(zxZX6q4xbh.GetSlave().GetCameraRotation());
						try
						{
							DotGridFrame dotGridFrame;
							DotGridFrame dotGridFrame2;
							if (CalibrationInProgress)
							{
								dotGridFrame = P_0.DetectDotGrid(CS_0024_003C_003E8__locals47.J0l4GOfoui);
								dotGridFrame2 = P_0.DetectDotGrid(CS_0024_003C_003E8__locals47.K3Q4FKmTv7);
								if (CalibrationImageCountCaptured == 0 && WuVXU4vOqp == null)
								{
									P_0.InitializeDetectorFromTarget(CS_0024_003C_003E8__locals47.J0l4GOfoui);
									if (dotGridFrame.IsValid && dotGridFrame2.IsValid)
									{
										uDgXhjWisv.Add(CS_0024_003C_003E8__locals47.J0l4GOfoui.Clone());
										Lc4Xecsr2q.Add(CS_0024_003C_003E8__locals47.K3Q4FKmTv7.Clone());
										r3eXm7whmy.Add((dotGridFrame.Points.ToArray(), dotGridFrame2.Points.ToArray()));
										WuVXU4vOqp = dotGridFrame.Points;
										CalibrationImageCountCaptured++;
										NQpRCxB8G(P_0);
									}
									goto IL_035e;
								}
								if (!P_0.AcceptFrameIfUsable(CS_0024_003C_003E8__locals47.J0l4GOfoui, CS_0024_003C_003E8__locals47.K3Q4FKmTv7, WuVXU4vOqp, out PointF[] masterPts, out PointF[] slavePts, out string _))
								{
									goto IL_035e;
								}
								uDgXhjWisv.Add(CS_0024_003C_003E8__locals47.J0l4GOfoui.Clone());
								Lc4Xecsr2q.Add(CS_0024_003C_003E8__locals47.K3Q4FKmTv7.Clone());
								WuVXU4vOqp = masterPts;
								r3eXm7whmy.Add((masterPts.ToArray(), slavePts.ToArray()));
								CalibrationImageCountCaptured++;
								NQpRCxB8G(P_0);
								if ((CalibrationImageCountCaptured < rwoNrdn1D || !P_0.CurrentGuidance.IsComplete) && CalibrationImageCountCaptured < Jc3btTSJM)
								{
									goto IL_035e;
								}
								break;
							}
							if (!CalibrationInProgress && ksqXNqsSas)
							{
								PointF pointF = new PointF((float)CS_0024_003C_003E8__locals47.J0l4GOfoui.Cols / 2f, (float)CS_0024_003C_003E8__locals47.J0l4GOfoui.Rows / 2f);
								PointF pointF2 = new PointF((float)CS_0024_003C_003E8__locals47.K3Q4FKmTv7.Cols / 2f, (float)CS_0024_003C_003E8__locals47.K3Q4FKmTv7.Rows / 2f);
								Rectangle rect = (kApxIlS0s() ? lsBOO8xZ4(new Size(CS_0024_003C_003E8__locals47.J0l4GOfoui.Cols, CS_0024_003C_003E8__locals47.J0l4GOfoui.Rows), pointF) : EPq1BAbvI(new Size(CS_0024_003C_003E8__locals47.J0l4GOfoui.Cols, CS_0024_003C_003E8__locals47.J0l4GOfoui.Rows), pointF));
								Rectangle rect2 = (kApxIlS0s() ? lsBOO8xZ4(new Size(CS_0024_003C_003E8__locals47.K3Q4FKmTv7.Cols, CS_0024_003C_003E8__locals47.K3Q4FKmTv7.Rows), pointF2) : EPq1BAbvI(new Size(CS_0024_003C_003E8__locals47.K3Q4FKmTv7.Cols, CS_0024_003C_003E8__locals47.K3Q4FKmTv7.Rows), pointF2));
								CvInvoke.Rectangle(CS_0024_003C_003E8__locals47.J0l4GOfoui, rect, new MCvScalar(0.0, 255.0, 0.0), 2);
								CvInvoke.Rectangle(CS_0024_003C_003E8__locals47.K3Q4FKmTv7, rect2, new MCvScalar(0.0, 255.0, 0.0), 2);
								cBXnjjpY9(CS_0024_003C_003E8__locals47.J0l4GOfoui);
								cBXnjjpY9(CS_0024_003C_003E8__locals47.K3Q4FKmTv7);
							}
							else if (TZ7XFrYJGD)
							{
								CvInvoke.DestroyWindow(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(14610));
								TZ7XFrYJGD = false;
							}
							goto IL_05b1;
							IL_05b1:
							fahXRFnC4I.Invoke((Action)delegate
							{
								//IL_0063: Unknown result type (might be due to invalid IL or missing references)
								//IL_008d: Unknown result type (might be due to invalid IL or missing references)
								CS_0024_003C_003E8__locals47.LXu4NXw8fH.IjJugyukQ(CS_0024_003C_003E8__locals47.J0l4GOfoui.Width, CS_0024_003C_003E8__locals47.J0l4GOfoui.Height);
								Int32Rect val = default(Int32Rect);
								((Int32Rect)(ref val))._002Ector(0, 0, CS_0024_003C_003E8__locals47.J0l4GOfoui.Width, CS_0024_003C_003E8__locals47.J0l4GOfoui.Height);
								int step = CS_0024_003C_003E8__locals47.J0l4GOfoui.Step;
								int step2 = CS_0024_003C_003E8__locals47.K3Q4FKmTv7.Step;
								CS_0024_003C_003E8__locals47.LXu4NXw8fH.DQ0XvIFbFu.WritePixels(val, (IntPtr)CS_0024_003C_003E8__locals47.J0l4GOfoui.DataPointer, step * CS_0024_003C_003E8__locals47.J0l4GOfoui.Height, step);
								CS_0024_003C_003E8__locals47.LXu4NXw8fH.D6ZX98ZXnQ.WritePixels(val, (IntPtr)CS_0024_003C_003E8__locals47.K3Q4FKmTv7.DataPointer, step2 * CS_0024_003C_003E8__locals47.K3Q4FKmTv7.Height, step2);
							});
							await Task.Delay(100, P_2);
							continue;
							IL_035e:
							CvInvoke.DrawChessboardCorners(CS_0024_003C_003E8__locals47.J0l4GOfoui, yUwTkSv6y, new VectorOfPointF(dotGridFrame.Points), patternWasFound: true);
							CvInvoke.DrawChessboardCorners(CS_0024_003C_003E8__locals47.K3Q4FKmTv7, yUwTkSv6y, new VectorOfPointF(dotGridFrame2.Points), patternWasFound: true);
							goto IL_05b1;
						}
						finally
						{
							if (CS_0024_003C_003E8__locals47.K3Q4FKmTv7 != null)
							{
								((IDisposable)CS_0024_003C_003E8__locals47.K3Q4FKmTv7).Dispose();
							}
						}
					}
					finally
					{
						if (CS_0024_003C_003E8__locals47.J0l4GOfoui != null)
						{
							((IDisposable)CS_0024_003C_003E8__locals47.J0l4GOfoui).Dispose();
						}
					}
				}
				await Task.Delay(10, P_2);
			}
			await fPVst01oA(P_0);
		}
		catch (TaskCanceledException)
		{
		}
		catch (Exception ex2)
		{
			EventViewerLogger.LogException(ex2);
			OakmY9gMX(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(14638) + ex2.Message);
			fahXRFnC4I.Invoke((Action)delegate
			{
				CalibrationSuccess = false;
			});
		}
		finally
		{
			fahXRFnC4I.Invoke((Action)delegate
			{
				CalibrationInProgress = false;
				CameraStarted = false;
				StartCalibrationButtonEnabled = false;
			});
			uDgXhjWisv.ForEach(delegate(Mat o)
			{
				o.Dispose();
			});
			Lc4Xecsr2q.ForEach(delegate(Mat o)
			{
				o.Dispose();
			});
			uDgXhjWisv.Clear();
			Lc4Xecsr2q.Clear();
			if (TZ7XFrYJGD)
			{
				CvInvoke.DestroyWindow(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(14610));
				TZ7XFrYJGD = false;
			}
			KkbX26npVO?.Dispose();
			KkbX26npVO = null;
			if (zxZX6q4xbh.AreGrabbing())
			{
				zxZX6q4xbh.StopGrabbings();
			}
		}
	}

	private bool kApxIlS0s()
	{
		return File.Exists(WqeX11uDjA);
	}

	private async Task fPVst01oA(StereoCalibrator P_0)
	{
		_003C_003Ec__DisplayClass110_0 CS_0024_003C_003E8__locals12 = new _003C_003Ec__DisplayClass110_0();
		CS_0024_003C_003E8__locals12.edo4zCQmHP = P_0;
		CS_0024_003C_003E8__locals12.op3nMXekHn = this;
		IsCalibrationCalculationInProgress = true;
		za2eUf2YK(CS_0024_003C_003E8__locals12.edo4zCQmHP.CurrentGuidance.ToString());
		MainWindowViewModel mainWindowViewModel = this;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 1);
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(14468));
		defaultInterpolatedStringHandler.AppendFormatted(uDgXhjWisv.Count);
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(14484));
		mainWindowViewModel.za2eUf2YK(defaultInterpolatedStringHandler.ToStringAndClear());
		B7kKv77B1(uDgXhjWisv, Lc4Xecsr2q);
		CS_0024_003C_003E8__locals12.Ekkn3iBGmv = uDgXhjWisv.Select((Mat m) => m.Clone()).ToList();
		CS_0024_003C_003E8__locals12.RSunXJE5fE = Lc4Xecsr2q.Select((Mat m) => m.Clone()).ToList();
		IsmXOMXdJK = await Task.Run(() => CS_0024_003C_003E8__locals12.edo4zCQmHP.CalibrateFromMats(CS_0024_003C_003E8__locals12.Ekkn3iBGmv, CS_0024_003C_003E8__locals12.RSunXJE5fE, CS_0024_003C_003E8__locals12.op3nMXekHn.uDgXhjWisv[0].Clone(), CS_0024_003C_003E8__locals12.op3nMXekHn.Lc4Xecsr2q[0].Clone()));
		IsmXOMXdJK[CameraRole.Master].CameraId = MasterCameraId;
		IsmXOMXdJK[CameraRole.Slave].CameraId = SlaveCameraId;
		BoardSpacingScaleReport boardSpacingScaleReport = BoardScaleValidator.AnalyzeScaleFromDotGrid(IsmXOMXdJK[CameraRole.Master].CameraMatrix, IsmXOMXdJK[CameraRole.Master].DistCoefficient, IsmXOMXdJK[CameraRole.Slave].CameraMatrix, IsmXOMXdJK[CameraRole.Slave].DistCoefficient, IsmXOMXdJK.RotationMatrix, IsmXOMXdJK.TranslationVector, LsvcOBE7Z, yUwTkSv6y, 0.075, r3eXm7whmy);
		za2eUf2YK(boardSpacingScaleReport.ToString());
		CalibrationSuccess = t6RqMd76x(IsmXOMXdJK) && boardSpacingScaleReport.SpacingScaleErrorPercent < 0.01;
		if (CalibrationSuccess || !File.Exists(rDdXn7CN9d))
		{
			Op4WsrFjW(rDdXn7CN9d);
			new CalibrationResultXmlSerializer().Serialize(rDdXn7CN9d, IsmXOMXdJK);
		}
		await File.WriteAllTextAsync(new FileInfo(rDdXn7CN9d).DirectoryName + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(14562), L6bXbeSx47.ToString());
		fahXRFnC4I.Invoke((Action)delegate
		{
			CS_0024_003C_003E8__locals12.op3nMXekHn.IsCalibrationCalculationInProgress = false;
			CS_0024_003C_003E8__locals12.op3nMXekHn.IsCalibrationComplete = true;
		});
	}

	private bool t6RqMd76x(StereoCalibrationResult P_0)
	{
		IS0sJPjVt01oA86RMd iS0sJPjVt01oA86RMd = new IS0sJPjVt01oA86RMd(P_0);
		iS0sJPjVt01oA86RMd.S6vdzmXvpc = za2eUf2YK;
		iS0sJPjVt01oA86RMd.S6qdTtw9rI();
		bool num = iS0sJPjVt01oA86RMd.QnedPwpMqw();
		float num2 = iS0sJPjVt01oA86RMd.gj7dcojdUa();
		float num3 = StereoGeometryScore.ComputeGeometryScore(P_0);
		float num4 = (float)znGoeE6qUpb635LS5V.GdHdqhSiM7(P_0, num3);
		bool result = num && num3 > 95f && num4 > 93f;
		kDLf9m5p3(iS0sJPjVt01oA86RMd.JfXdGkSjoW(), num4, num3, num2);
		if (!num)
		{
			za2eUf2YK(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2092));
			foreach (string item in iS0sJPjVt01oA86RMd.fo9dFMu4l5())
			{
				za2eUf2YK(item);
			}
		}
		return result;
	}

	private static void Op4WsrFjW(string P_0)
	{
		if (!File.Exists(P_0))
		{
			return;
		}
		string? directoryName = Path.GetDirectoryName(P_0);
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(P_0);
		string extension = Path.GetExtension(P_0);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 3);
		defaultInterpolatedStringHandler.AppendFormatted(fileNameWithoutExtension);
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2200));
		defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2206));
		defaultInterpolatedStringHandler.AppendFormatted(extension);
		string destFileName = Path.Combine(directoryName, defaultInterpolatedStringHandler.ToStringAndClear());
		File.Move(P_0, destFileName);
		foreach (string item in Directory.GetFiles(directoryName, fileNameWithoutExtension + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2248) + extension).OrderByDescending(File.GetCreationTimeUtc).ToList()
			.Skip(3))
		{
			try
			{
				File.Delete(item);
			}
			catch
			{
			}
		}
	}

	private void kDLf9m5p3(List<string> P_0, float P_1, float P_2, float P_3)
	{
		LogString = string.Empty;
		za2eUf2YK(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2256));
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
		defaultInterpolatedStringHandler.AppendFormatted(P_1 > 93f);
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2314));
		defaultInterpolatedStringHandler.AppendFormatted(P_1);
		za2eUf2YK(defaultInterpolatedStringHandler.ToStringAndClear());
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
		defaultInterpolatedStringHandler.AppendFormatted(P_2 > 95f);
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2352));
		defaultInterpolatedStringHandler.AppendFormatted(P_2);
		za2eUf2YK(defaultInterpolatedStringHandler.ToStringAndClear());
		za2eUf2YK("");
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2396));
		defaultInterpolatedStringHandler.AppendFormatted(P_3);
		za2eUf2YK(defaultInterpolatedStringHandler.ToStringAndClear());
		za2eUf2YK(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2442));
		P_0.ForEach(delegate(string text)
		{
			za2eUf2YK(text.ToString());
		});
		CalibrationOverallValue = P_1.ToString(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2508));
	}

	private void B7kKv77B1(List<Mat> P_0, List<Mat> P_1)
	{
		try
		{
			string text = y2KXkWGkXf + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2520) + MasterCameraId + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2548);
			string text2 = y2KXkWGkXf + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2520) + SlaveCameraId + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2548);
			Directory.CreateDirectory(text);
			Directory.CreateDirectory(text2);
			string[] files = Directory.GetFiles(text);
			for (int i = 0; i < files.Length; i++)
			{
				File.Delete(files[i]);
			}
			files = Directory.GetFiles(text2);
			for (int i = 0; i < files.Length; i++)
			{
				File.Delete(files[i]);
			}
			string text3 = y2KXkWGkXf + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2554) + MasterCameraId + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1546);
			string text4 = y2KXkWGkXf + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2554) + SlaveCameraId + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1546);
			Directory.CreateDirectory(Path.GetDirectoryName(text3));
			Directory.CreateDirectory(Path.GetDirectoryName(text4));
			if (File.Exists(text3))
			{
				File.Delete(text3);
			}
			if (File.Exists(text4))
			{
				File.Delete(text4);
			}
			CvInvoke.Imwrite(text3, P_0[0]);
			CvInvoke.Imwrite(text4, P_1[0]);
			for (int j = 1; j < P_0.Count; j++)
			{
				string text5 = $"{j - 1}";
				text5 = text5.PadLeft(5, '0');
				CvInvoke.Imwrite(text + text5 + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2574), P_0[j]);
			}
			for (int k = 1; k < P_1.Count; k++)
			{
				string text6 = $"{k - 1}";
				text6 = text6.PadLeft(5, '0');
				CvInvoke.Imwrite(text2 + text6 + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2574), P_1[k]);
			}
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
			za2eUf2YK(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2586) + ex.Message + Environment.NewLine + ex.StackTrace);
		}
	}

	public void Dispose()
	{
		xuCXHZe8Mn?.Dispose();
		IdlXj9uEhE?.Dispose();
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void gSyVahwYQ(int P_0)
	{
		CalibrationImageCountProgression = $"{P_0}";
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void j3EIRm2I7(bool P_0)
	{
		StartCalibrationButtonText = (P_0 ? xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2724) : xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1870));
		StartCalibrationCommand.NotifyCanExecuteChanged();
		StartCamerasCommand.NotifyCanExecuteChanged();
		ShowHittingZoneCommand.NotifyCanExecuteChanged();
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void cIQ5hT00f(bool P_0)
	{
		StartCameraButtonText = (P_0 ? xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2764) : xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(1908));
		StartCalibrationCommand.NotifyCanExecuteChanged();
		ShowHittingZoneCommand.NotifyCanExecuteChanged();
		StartCalibrationFromFolderCommand.NotifyCanExecuteChanged();
		StartCamerasCommand.NotifyCanExecuteChanged();
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void ReWAq5vJM(bool P_0)
	{
		OnPropertyChanged(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2792));
	}

	static MainWindowViewModel()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		VQxXXKTuhW = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2822);
		Q1PXM7Nr9l = xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2848);
	}

	[CompilerGenerated]
	private bool BH4ZNehan()
	{
		if (CameraStarted)
		{
			return !ksqXNqsSas;
		}
		return false;
	}

	[CompilerGenerated]
	private bool IePtXR3XH()
	{
		return !CalibrationInProgress;
	}

	[CompilerGenerated]
	private bool tCW0nNrWR()
	{
		return !CameraStarted;
	}

	[CompilerGenerated]
	private void DBrwgjOv7()
	{
		IsLogShown = !IsLogShown;
	}

	[CompilerGenerated]
	private bool GfZoIM1ac()
	{
		if (!CameraStarted)
		{
			return !CalibrationInProgress;
		}
		return false;
	}

	[CompilerGenerated]
	private void jMJleOTjY()
	{
		IsCalibrationComplete = true;
		ksqXNqsSas = true;
	}

	[CompilerGenerated]
	private void Mo7Ll9dId()
	{
		CameraStarted = false;
		ksqXNqsSas = false;
	}

	[CompilerGenerated]
	private void yAMYhsRbE()
	{
		IsCalibrationComplete = false;
		CameraStarted = true;
	}

	[CompilerGenerated]
	private void MmeDCCroW()
	{
		CalibrationInProgress = true;
		IsCalibrationComplete = false;
		CalibrationSuccess = false;
		IsCalibrationCalculationInProgress = true;
	}

	[CompilerGenerated]
	private void ReJgSWw72()
	{
		IsCalibrationCalculationInProgress = false;
		IsCalibrationComplete = true;
		CalibrationInProgress = false;
	}

	[CompilerGenerated]
	private void R4kP0ShV7()
	{
		StartCalibrationButtonEnabled = false;
		ksqXNqsSas = false;
	}

	[CompilerGenerated]
	private bool OxcEynyUa()
	{
		return CalibrationInProgress = false;
	}

	[CompilerGenerated]
	private void QtWQWJ5C9()
	{
		CalibrationInProgress = true;
		StartCalibrationButtonEnabled = false;
	}

	[CompilerGenerated]
	private void rEnallFRM()
	{
		CalibrationInProgress = false;
		CameraStarted = false;
		StartCalibrationButtonEnabled = false;
	}

	[CompilerGenerated]
	private void YbwBYf1iG()
	{
		CalibrationSuccess = false;
	}

	[CompilerGenerated]
	private void X97C9yZlM()
	{
		CalibrationInProgress = false;
		CameraStarted = false;
		StartCalibrationButtonEnabled = false;
	}

	[CompilerGenerated]
	private void YoqyGKWB1(string P_0)
	{
		za2eUf2YK(P_0.ToString());
	}
}
