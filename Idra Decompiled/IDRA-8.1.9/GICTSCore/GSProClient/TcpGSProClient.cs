#define TRACE
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using GICTSCore.Data;
using GIToolkit.Services;
using IDRASharedModels;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;

namespace GSProClient;

public class TcpGSProClient : ITcpGSProClient, IDisposable, IService
{
	[CompilerGenerated]
	private Action<PlayerDataDto> SvqLHxE9Pw;

	[CompilerGenerated]
	private Action<PlayerDataDto> TrrLDH5ef0;

	[CompilerGenerated]
	private Action<string> MImLT22tgG;

	[CompilerGenerated]
	private Action<GSProComputeData> mqhLC4EGlS;

	[CompilerGenerated]
	private Action c1uLM05bBu;

	[CompilerGenerated]
	private Action KnRLKgfZNX;

	[CompilerGenerated]
	private Action lE7Lp8Wjle;

	[CompilerGenerated]
	private Action wlZL7ZRljQ;

	[CompilerGenerated]
	private Action<bool> hNDL8uOpRY;

	[CompilerGenerated]
	private Action<bool> NB0LuIXEbJ;

	[CompilerGenerated]
	private Action<ShotDataDto> hZKLYgIDBu;

	[CompilerGenerated]
	private ICircularLogService yFNLbhQWXO;

	private TcpClient yMRLfYdm4q;

	private ConcurrentQueue<string> jLKLI2HGvA;

	private Task kTjLOZxMMs;

	private Task NfGLaYhp7W;

	private CancellationTokenSource SmxLZJ6SJk;

	public Action<PlayerDataDto> OnPlayerDataReceived
	{
		[CompilerGenerated]
		get
		{
			return SvqLHxE9Pw;
		}
		[CompilerGenerated]
		set
		{
			SvqLHxE9Pw = value;
		}
	}

	public Action<PlayerDataDto> OnDistanceToPinReceived
	{
		[CompilerGenerated]
		get
		{
			return TrrLDH5ef0;
		}
		[CompilerGenerated]
		set
		{
			TrrLDH5ef0 = value;
		}
	}

	public Action<string> OnFirstTeeReceived
	{
		[CompilerGenerated]
		get
		{
			return MImLT22tgG;
		}
		[CompilerGenerated]
		set
		{
			MImLT22tgG = value;
		}
	}

	public Action<GSProComputeData> OnGameComputeDataReceived
	{
		[CompilerGenerated]
		get
		{
			return mqhLC4EGlS;
		}
		[CompilerGenerated]
		set
		{
			mqhLC4EGlS = value;
		}
	}

	public Action OnReadyReceiveShot
	{
		[CompilerGenerated]
		get
		{
			return c1uLM05bBu;
		}
		[CompilerGenerated]
		set
		{
			c1uLM05bBu = value;
		}
	}

	public Action OnRoundHasEnded
	{
		[CompilerGenerated]
		get
		{
			return KnRLKgfZNX;
		}
		[CompilerGenerated]
		set
		{
			KnRLKgfZNX = value;
		}
	}

	public Action OnConnectedToServer
	{
		[CompilerGenerated]
		get
		{
			return lE7Lp8Wjle;
		}
		[CompilerGenerated]
		set
		{
			lE7Lp8Wjle = value;
		}
	}

	public Action OnDisconnectedFromServer
	{
		[CompilerGenerated]
		get
		{
			return wlZL7ZRljQ;
		}
		[CompilerGenerated]
		set
		{
			wlZL7ZRljQ = value;
		}
	}

	public Action<bool> OnScoreCardVisible
	{
		[CompilerGenerated]
		get
		{
			return hNDL8uOpRY;
		}
		[CompilerGenerated]
		set
		{
			hNDL8uOpRY = value;
		}
	}

	public Action<bool> OnOSKVisible
	{
		[CompilerGenerated]
		get
		{
			return NB0LuIXEbJ;
		}
		[CompilerGenerated]
		set
		{
			NB0LuIXEbJ = value;
		}
	}

	public Action<ShotDataDto> OnShotReceived
	{
		[CompilerGenerated]
		get
		{
			return hZKLYgIDBu;
		}
		[CompilerGenerated]
		set
		{
			hZKLYgIDBu = value;
		}
	}

	public ICircularLogService Logger
	{
		[CompilerGenerated]
		get
		{
			return yFNLbhQWXO;
		}
		[CompilerGenerated]
		private set
		{
			yFNLbhQWXO = value;
		}
	}

	public TcpGSProClient()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		jLKLI2HGvA = new ConcurrentQueue<string>();
		SmxLZJ6SJk = new CancellationTokenSource();
		base._002Ector();
		Logger = new CircularLogService();
		Logger.SetupLogFile(IDRAConstant.ApiCommGSProLogDirectoryPath, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(476), useTraceLoggingMethod: false, 30, 1048576L);
		Logger.SetLogLevel(LogLevel.Debug);
	}

	public bool IsConnectedToServer()
	{
		TcpClient tcpClient = yMRLfYdm4q;
		if (tcpClient == null)
		{
			return false;
		}
		return tcpClient.Client?.Connected == true;
	}

	private bool LWNLwloMdf()
	{
		if (IsConnectedToServer())
		{
			return yMRLfYdm4q.GetStream()?.CanWrite ?? false;
		}
		return false;
	}

	public async Task<bool> ConnectToGSPro()
	{
		if (IsConnectedToServer())
		{
			return false;
		}
		try
		{
			await LOTLsBUKfu();
			yMRLfYdm4q = new TcpClient
			{
				NoDelay = true,
				ReceiveBufferSize = 8192,
				SendBufferSize = 16384,
				ReceiveTimeout = 1000,
				SendTimeout = 1000
			};
			await yMRLfYdm4q.ConnectAsync(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12234), 9050);
			if (!IsConnectedToServer())
			{
				Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(18074));
				return false;
			}
			Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(18148));
			OnConnectedToServer?.Invoke();
			jLKLI2HGvA = new ConcurrentQueue<string>();
			SmxLZJ6SJk = new CancellationTokenSource();
			kTjLOZxMMs = Task.Factory.StartNew((Func<object?, Task>)b9ILS6rlJM, (object?)SmxLZJ6SJk.Token, SmxLZJ6SJk.Token);
			NfGLaYhp7W = Task.Factory.StartNew((Func<object?, Task>)rckLn7FrW4, (object?)SmxLZJ6SJk.Token, SmxLZJ6SJk.Token);
			return true;
		}
		catch (SocketException ex)
		{
			Logger.Log(ex.ToString(), LogLevel.Error);
			return false;
		}
		catch (Exception ex2)
		{
			Logger.Log(ex2.ToString(), LogLevel.Error);
			return false;
		}
	}

	public async Task<bool> SendBallAndClubData(BallDataDto ballData, ClubDataDto clubData)
	{
		bool flag = await SendBallData(ballData);
		if (flag)
		{
			flag = await SendClubData(clubData);
		}
		return flag;
	}

	public async Task<bool> SendClubData(ClubDataDto clubData)
	{
		string s = JsonSerializer.Serialize(new MessageDto
		{
			Command = TCPCommandType.ClubData,
			JsonData = Encoding.ASCII.GetBytes(JsonSerializer.Serialize(clubData))
		});
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		return await hOlLVA9APo(bytes);
	}

	public async Task<bool> SendBallData(BallDataDto ballData)
	{
		string s = JsonSerializer.Serialize(new MessageDto
		{
			Command = TCPCommandType.BallData,
			JsonData = Encoding.ASCII.GetBytes(JsonSerializer.Serialize(ballData))
		});
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		return await hOlLVA9APo(bytes);
	}

	public async Task<bool> SendOpenGSProWithLoggingSystem(bool val)
	{
		string s = JsonSerializer.Serialize(new MessageDto
		{
			Command = TCPCommandType.OpenGSProWithLogging,
			JsonData = Encoding.ASCII.GetBytes(JsonSerializer.Serialize(val))
		});
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		return await hOlLVA9APo(bytes);
	}

	public async Task<bool> SendBallPositionToGsp(GspBoothData booth)
	{
		string s = JsonSerializer.Serialize(new MessageDto
		{
			Command = TCPCommandType.AdjustBallPosition,
			JsonData = Encoding.ASCII.GetBytes(JsonSerializer.Serialize(booth))
		});
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		return await hOlLVA9APo(bytes);
	}

	public async Task<bool> SendAutoTeeMoveBallLeft()
	{
		string s = JsonSerializer.Serialize(new MessageDto
		{
			Command = TCPCommandType.MoveTeeBallLeft
		});
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		return await hOlLVA9APo(bytes);
	}

	public async Task<bool> SendAutoTeeMoveBallRight()
	{
		string s = JsonSerializer.Serialize(new MessageDto
		{
			Command = TCPCommandType.MoveTeeBallRight
		});
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		return await hOlLVA9APo(bytes);
	}

	public void DisconnectFromServer()
	{
		try
		{
			if (yMRLfYdm4q != null)
			{
				yMRLfYdm4q?.Close();
				yMRLfYdm4q?.Dispose();
				yMRLfYdm4q = null;
			}
		}
		catch (Exception ex)
		{
			Logger.Log(ex.ToString(), LogLevel.Error);
		}
	}

	public async Task CloseTCPConnection()
	{
		try
		{
			DisconnectFromServer();
			await LOTLsBUKfu();
			OnDisconnectedFromServer?.Invoke();
		}
		catch (Exception ex)
		{
			Logger.Log(ex.ToString(), LogLevel.Error);
		}
	}

	private async Task LOTLsBUKfu()
	{
		if (SmxLZJ6SJk != null && NfGLaYhp7W != null && kTjLOZxMMs != null)
		{
			SmxLZJ6SJk.Cancel();
			bool hasReleaseResponseTask = await pTCLgmijM9(NfGLaYhp7W, 1000);
			bool num = await pTCLgmijM9(kTjLOZxMMs, 1000);
			if (!hasReleaseResponseTask)
			{
				NfGLaYhp7W.Dispose();
			}
			if (!num)
			{
				kTjLOZxMMs.Dispose();
			}
			NfGLaYhp7W = null;
			kTjLOZxMMs = null;
		}
	}

	private async Task<bool> pTCLgmijM9(Task P_0, int P_1)
	{
		bool num = await Task.WhenAny(P_0, Task.Delay(P_1)) == P_0;
		if (!num)
		{
			Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(17990));
			throw new TimeoutException(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(18008));
		}
		return num;
	}

	private static async Task<aUdVuAgFR52UQd9YuO> kpeLLJxhu6<aUdVuAgFR52UQd9YuO>(Task<aUdVuAgFR52UQd9YuO> P_0, int P_1, int P_2 = 500)
	{
		while (checked(P_1--) > 0)
		{
			try
			{
				return await P_0;
			}
			catch (Exception ex)
			{
				Trace.WriteLine(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(19258) + ex.Message);
				if (P_1 > 0)
				{
					await Task.Delay(P_2);
				}
			}
		}
		throw new Exception(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(19320));
	}

	private async Task rckLn7FrW4(object? state)
	{
		if (state == null)
		{
			return;
		}
		CancellationToken token = (CancellationToken)state;
		while (!jLKLI2HGvA.IsEmpty || !token.IsCancellationRequested)
		{
			if (!jLKLI2HGvA.TryDequeue(out var result))
			{
				await Task.Delay(50);
				continue;
			}
			foreach (Match item in new Regex(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(18354)).Matches(result))
			{
				if (!item.Value.Contains(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(18374)))
				{
					Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(18388) + item.Value);
				}
				try
				{
					MessageDto messageDto = JsonSerializer.Deserialize<MessageDto>(item.Value);
					if (messageDto == null)
					{
						continue;
					}
					switch (messageDto.Command)
					{
					case TCPCommandType.PlayerClubInfo:
					{
						Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(18462));
						if (messageDto.JsonData == null)
						{
							Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(18536));
							break;
						}
						PlayerDataDto obj2 = JsonSerializer.Deserialize<PlayerDataDto>(Encoding.ASCII.GetString(messageDto.JsonData));
						OnPlayerDataReceived?.Invoke(obj2);
						Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(18596) + Encoding.ASCII.GetString(messageDto.JsonData));
						break;
					}
					case TCPCommandType.DistanceToPin:
					{
						if (messageDto.JsonData == null)
						{
							Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(18652));
							break;
						}
						PlayerDataDto obj4 = JsonSerializer.Deserialize<PlayerDataDto>(Encoding.ASCII.GetString(messageDto.JsonData));
						OnDistanceToPinReceived?.Invoke(obj4);
						Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(18710) + Encoding.ASCII.GetString(messageDto.JsonData));
						break;
					}
					case TCPCommandType.TrajectoryResult:
					{
						if (messageDto.JsonData == null)
						{
							Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(18764));
							break;
						}
						string text = JsonSerializer.Deserialize<string>(Encoding.ASCII.GetString(messageDto.JsonData));
						Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(18822) + text);
						break;
					}
					case TCPCommandType.ReadyReceiveShot:
						OnReadyReceiveShot?.Invoke();
						Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(18850));
						break;
					case TCPCommandType.FirstTeeEvent:
					{
						string obj7 = JsonSerializer.Deserialize<string>(Encoding.ASCII.GetString(messageDto.JsonData));
						OnFirstTeeReceived?.Invoke(obj7);
						break;
					}
					case TCPCommandType.GameComputedData:
					{
						GSProComputeData obj5 = JsonSerializer.Deserialize<GSProComputeData>(Encoding.ASCII.GetString(messageDto.JsonData));
						OnGameComputeDataReceived?.Invoke(obj5);
						Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(18896));
						break;
					}
					case TCPCommandType.RoundHasEnded:
						OnRoundHasEnded?.Invoke();
						Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(18954));
						break;
					case TCPCommandType.OnScorecardVisible:
					{
						bool obj6 = JsonSerializer.Deserialize<bool>(Encoding.ASCII.GetString(messageDto.JsonData));
						OnScoreCardVisible?.Invoke(obj6);
						Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(18988));
						break;
					}
					case TCPCommandType.OnOSKVisible:
					{
						bool obj3 = JsonSerializer.Deserialize<bool>(Encoding.ASCII.GetString(messageDto.JsonData));
						OnOSKVisible?.Invoke(obj3);
						Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(19046));
						break;
					}
					case TCPCommandType.ShotReceived:
					{
						if (messageDto.JsonData == null)
						{
							Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(19092));
							break;
						}
						ShotDataDto obj = JsonSerializer.Deserialize<ShotDataDto>(Encoding.ASCII.GetString(messageDto.JsonData));
						OnShotReceived?.Invoke(obj);
						Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(19140) + Encoding.ASCII.GetString(messageDto.JsonData));
						break;
					}
					}
				}
				catch (Exception ex)
				{
					Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(19196) + ex.Message, LogLevel.Error);
				}
			}
		}
	}

	private async Task b9ILS6rlJM(object? state)
	{
		if (state == null)
		{
			return;
		}
		CancellationToken token = (CancellationToken)state;
		byte[] bytes = new byte[8192];
		try
		{
			while (!token.IsCancellationRequested)
			{
				if (!IsConnectedToServer())
				{
					await Task.Delay(100, token);
					continue;
				}
				while (!token.IsCancellationRequested && IsConnectedToServer())
				{
					int num = await yMRLfYdm4q.GetStream().ReadAsync(bytes, token);
					if (num <= 0)
					{
						break;
					}
					string item = Encoding.ASCII.GetString(bytes, 0, num);
					jLKLI2HGvA.Enqueue(item);
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Log(ex.ToString(), LogLevel.Error);
		}
		await Task.Delay(500, token);
		Logger.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(18188));
	}

	private async Task<bool> hOlLVA9APo(byte[] P_0)
	{
		try
		{
			if (!LWNLwloMdf())
			{
				return false;
			}
			return await kpeLLJxhu6(pTCLgmijM9(yMRLfYdm4q.GetStream()?.WriteAsync(P_0, 0, P_0.Length), 200), 3);
		}
		catch (Exception ex)
		{
			Logger.Log(ex.ToString(), LogLevel.Error);
			return false;
		}
	}

	public void Dispose()
	{
		Logger?.LogFileCloseTag();
		CloseTCPConnection().Wait();
	}
}
