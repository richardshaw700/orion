using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using GICTSCore.Data;
using GIToolkit.Services;
using IDRAMonitor.Auxiliary.Messages;
using hkpxmGISLhTJrZLcmi;
using jBnbmEXkwPOPpPQ9mC;

namespace IDRAMonitor.Services;

public class ProjectProcessService : IProjectProcessService, IService
{
	[CompilerGenerated]
	private bool eDdFEL9qrQ;

	[CompilerGenerated]
	private bool og2FuwKA5H;

	[CompilerGenerated]
	private bool krlFpVcNMC;

	private readonly IMessagingService sb9F01WZdQ;

	private readonly ICircularLogService TqNFeDe5Nt;

	private readonly IProcessHelper x53FlPEK8E;

	private SemaphoreSlim VZvF85xg70;

	private Process StBFk609mG;

	private bool qLTF4AugOl;

	private bool owNFU6RiSc;

	public bool IsDesiredExit
	{
		[CompilerGenerated]
		get
		{
			return eDdFEL9qrQ;
		}
		[CompilerGenerated]
		set
		{
			eDdFEL9qrQ = value;
		}
	}

	public bool LaunchBackIdra
	{
		[CompilerGenerated]
		get
		{
			return og2FuwKA5H;
		}
		[CompilerGenerated]
		set
		{
			og2FuwKA5H = value;
		}
	}

	public bool IdraHasCloseSuccessfully
	{
		[CompilerGenerated]
		get
		{
			return krlFpVcNMC;
		}
		[CompilerGenerated]
		set
		{
			krlFpVcNMC = value;
		}
	}

	public ProjectProcessService(IProcessHelper processHelper, IMessagingService messagingService, ICircularLogService circularLogService)
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		og2FuwKA5H = true;
		VZvF85xg70 = new SemaphoreSlim(1, 1);
		base._002Ector();
		x53FlPEK8E = processHelper;
		sb9F01WZdQ = messagingService;
		TqNFeDe5Nt = circularLogService;
	}

	public async Task LaunchIdra([CallerMemberName] string caller = "")
	{
		bool shouldReleaseSemaphore = false;
		try
		{
			if (!VZvF85xg70.Wait(0))
			{
				return;
			}
			shouldReleaseSemaphore = true;
			ICircularLogService tqNFeDe5Nt = TqNFeDe5Nt;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(99, 3);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(14432));
			defaultInterpolatedStringHandler.AppendFormatted(qLTF4AugOl);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(14552));
			defaultInterpolatedStringHandler.AppendFormatted(LaunchBackIdra);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(14612));
			defaultInterpolatedStringHandler.AppendFormatted(caller);
			tqNFeDe5Nt.Log(defaultInterpolatedStringHandler.ToStringAndClear());
			if (!LaunchBackIdra)
			{
				TqNFeDe5Nt.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(14642));
				sb9F01WZdQ.Send(new CloseApplicationMessage(100));
			}
			else
			{
				if (qLTF4AugOl)
				{
					return;
				}
				qLTF4AugOl = true;
				await Task.Delay(TimeSpan.FromSeconds(1.0));
				StBFk609mG = StBFk609mG ?? x53FlPEK8E.GetProcessByName(IDRAConstant.IdraProcessName);
				try
				{
					if (StBFk609mG != null)
					{
						TqNFeDe5Nt.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(14756), LogLevel.Warning);
						IsDesiredExit = true;
						StBFk609mG.Kill();
					}
				}
				catch (Exception ex)
				{
					TqNFeDe5Nt.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(14852) + ex.Message, LogLevel.Error);
				}
				string fileName = AppDomain.CurrentDomain.BaseDirectory.Replace(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(12044), ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9812)) + ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(9336) + IDRAConstant.IdraProcess;
				try
				{
					StBFk609mG = x53FlPEK8E.CreateProcess(fileName);
					StBFk609mG.StartInfo.Verb = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(14936);
					TqNFeDe5Nt.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(14950));
					StBFk609mG.Start();
					TqNFeDe5Nt.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(15084));
					x53FlPEK8E.ModifyWindowState(StBFk609mG?.ProcessName, ShowWindowEnum.ShowDefault);
					qDVFOa1NvR(StBFk609mG, IdraProcess_Exited);
					return;
				}
				catch (Exception ex2)
				{
					TqNFeDe5Nt.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(15170), LogLevel.Error);
					EventViewerLogger.LogException(ex2);
					return;
				}
			}
		}
		finally
		{
			if (shouldReleaseSemaphore)
			{
				VZvF85xg70.Release();
			}
			IsDesiredExit = false;
			qLTF4AugOl = false;
		}
	}

	private void IdraProcess_Exited(object sender, EventArgs e)
	{
		ICircularLogService tqNFeDe5Nt = TqNFeDe5Nt;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 1);
		defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5730));
		defaultInterpolatedStringHandler.AppendFormatted(IsDesiredExit);
		tqNFeDe5Nt.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		if (!IsDesiredExit)
		{
			Task.Run(async delegate
			{
				await LaunchIdra(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(13652));
			});
		}
	}

	private void qDVFOa1NvR(Process P_0, EventHandler P_1)
	{
		try
		{
			x53FlPEK8E.AttachListenerOnExited(P_0, P_1);
		}
		catch (Exception ex)
		{
			TqNFeDe5Nt.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(5804) + ex.Message, LogLevel.Error);
		}
	}

	public async Task ResetIdra()
	{
		TqNFeDe5Nt.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(15270));
		IsDesiredExit = true;
		LaunchBackIdra = true;
		await CloseIdra(IDRAtoIDRAMCommunication.CommunicationCode.ResetIDRA);
		if (!IdraHasCloseSuccessfully)
		{
			TqNFeDe5Nt.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(15314), LogLevel.Warning);
			await LaunchIdra(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(15434));
		}
		IdraHasCloseSuccessfully = false;
	}

	public async Task CloseApplication()
	{
		if (!owNFU6RiSc)
		{
			owNFU6RiSc = true;
			TqNFeDe5Nt.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(13692), LogLevel.Warning);
			IsDesiredExit = true;
			LaunchBackIdra = false;
			await CloseIdra(IDRAtoIDRAMCommunication.CommunicationCode.NormalClose);
			sb9F01WZdQ.Send(new CloseApplicationMessage(100));
		}
	}

	public async Task CloseIdra(int closeCode)
	{
		_ = 2;
		try
		{
			TqNFeDe5Nt.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(13738));
			await (await FileProcessCommunication.GetInstanceAsync(new IDRAtoIDRAMCommunication(), TqNFeDe5Nt)).WriteMessage(IDRAtoIDRAMCommunication.CommunicationCode.ResetIDRA);
			if (StBFk609mG == null || StBFk609mG.HandleCount <= 0)
			{
				return;
			}
			try
			{
				x53FlPEK8E.DetachListenerOnExited(StBFk609mG, IdraProcess_Exited);
			}
			catch (Exception ex)
			{
				TqNFeDe5Nt.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(13788) + ex.Message, LogLevel.Error);
			}
			ICircularLogService tqNFeDe5Nt = TqNFeDe5Nt;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 1);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(13976));
			defaultInterpolatedStringHandler.AppendFormatted(IDRAConstant.ResetMaxDelayTimeMs);
			defaultInterpolatedStringHandler.AppendLiteral(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(13996));
			tqNFeDe5Nt.Log(defaultInterpolatedStringHandler.ToStringAndClear());
			await Task.Delay(IDRAConstant.ResetMaxDelayTimeMs);
			if (!IdraHasCloseSuccessfully)
			{
				TqNFeDe5Nt.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(14076), LogLevel.Warning);
				if (!StBFk609mG.HasExited)
				{
					StBFk609mG.Kill();
				}
				StBFk609mG.Dispose();
				StBFk609mG = null;
			}
		}
		catch (Exception ex2)
		{
			if (StBFk609mG != null && StBFk609mG.Container != null)
			{
				TqNFeDe5Nt.Log(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(14202) + ex2.Message, LogLevel.Error);
				StBFk609mG.Kill();
				EventViewerLogger.LogException(ex2);
			}
		}
	}

	[CompilerGenerated]
	private async Task? H4RFNv4w0m()
	{
		await LaunchIdra(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(13652));
	}
}
