using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using GolfInPlugin;
using IDRASharedModels;
using Newtonsoft.Json;
using sX02IJN7NqxvB7iKPK;
using wVHl9VOlgpYv6rdPWy;
using zLGfTg8qMbPmqnv69o;

namespace j78BTXhiBI0LPWc8Et;

internal sealed class sJ9hssTCYj7GDPnrdy
{
	[CompilerGenerated]
	private Action<BallDataDto> CLRwDN2Mo9;

	[CompilerGenerated]
	private Action<ClubDataDto> eJTwPySeV7;

	[CompilerGenerated]
	private Action<GspBoothData> Fe6weyfX19;

	[CompilerGenerated]
	private Action Rm4wRNxuKm;

	[CompilerGenerated]
	private Action VxYws2qi6l;

	private TcpListener rEhwWBA96P;

	private TcpClient RiEwHPqaeG;

	private ConcurrentQueue<string> rYUwxPea18;

	private Task UoVw0JfpBK;

	private Task M6QwgtOgnk;

	private CancellationTokenSource yKZwSII2MY;

	[SpecialName]
	[CompilerGenerated]
	public Action<BallDataDto> tDKVuJCjx()
	{
		return CLRwDN2Mo9;
	}

	[SpecialName]
	[CompilerGenerated]
	public void yaH8e2TOS(Action<BallDataDto> P_0)
	{
		CLRwDN2Mo9 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public Action<ClubDataDto> fM0zAP3Se()
	{
		return eJTwPySeV7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void gTowtcIv4c(Action<ClubDataDto> P_0)
	{
		eJTwPySeV7 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public Action<GspBoothData> jvYwc6BBni()
	{
		return Fe6weyfX19;
	}

	[SpecialName]
	[CompilerGenerated]
	public void JU3wKoNnBc(Action<GspBoothData> P_0)
	{
		Fe6weyfX19 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public Action dshwTP5Pcs()
	{
		return Rm4wRNxuKm;
	}

	[SpecialName]
	[CompilerGenerated]
	public void w0pwhU8MVE(Action P_0)
	{
		Rm4wRNxuKm = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public Action u3xwl4KeZJ()
	{
		return VxYws2qi6l;
	}

	[SpecialName]
	[CompilerGenerated]
	public void sI0wrdHipp(Action P_0)
	{
		VxYws2qi6l = P_0;
	}

	public void g1y4Hnb4Q()
	{
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(1380));
		if (PY5NEVtJT())
		{
			return;
		}
		try
		{
			rYUwxPea18 = new ConcurrentQueue<string>();
			yKZwSII2MY = new CancellationTokenSource();
			UoVw0JfpBK = Task.Factory.StartNew((Func<object?, Task>)JAtZJBAfL, (object?)yKZwSII2MY.Token, yKZwSII2MY.Token);
			M6QwgtOgnk = Task.Factory.StartNew((Func<object?, Task>)LFNQ4nTkU, (object?)yKZwSII2MY.Token, yKZwSII2MY.Token);
		}
		catch (Exception ex)
		{
			global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(1422) + ex.Source));
		}
	}

	public bool PY5NEVtJT()
	{
		TcpClient riEwHPqaeG = RiEwHPqaeG;
		if (riEwHPqaeG == null)
		{
			return false;
		}
		return riEwHPqaeG.Client?.GXh5Rfs9W() == true;
	}

	private async Task LFNQ4nTkU(object P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		CancellationToken token = (CancellationToken)P_0;
		while (!rYUwxPea18.IsEmpty || !token.IsCancellationRequested)
		{
			if (rYUwxPea18.TryDequeue(out var result))
			{
				MatchCollection matchCollection = new Regex(Dpdrn94xidrKkBCvWK.vZjKJCNxST(4788)).Matches(result);
				foreach (Match item in matchCollection)
				{
					if (!item.Value.Contains(Dpdrn94xidrKkBCvWK.vZjKJCNxST(4808)))
					{
						global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(4822) + item.Value));
					}
					try
					{
						MessageDto messageDto = JsonConvert.DeserializeObject<MessageDto>(item.Value);
						if (messageDto == null)
						{
							continue;
						}
						switch (messageDto.Command)
						{
						case TCPCommandType.MoveTeeBallLeft:
							global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(4896));
							dshwTP5Pcs()?.Invoke();
							break;
						case TCPCommandType.MoveTeeBallRight:
							global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(5004));
							u3xwl4KeZJ()?.Invoke();
							break;
						case TCPCommandType.BallData:
						{
							if (messageDto.JsonData == null)
							{
								global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(5114));
								break;
							}
							BallDataDto obj3 = JsonConvert.DeserializeObject<BallDataDto>(Encoding.ASCII.GetString(messageDto.JsonData));
							global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(5160));
							tDKVuJCjx()?.Invoke(obj3);
							break;
						}
						case TCPCommandType.ClubData:
						{
							if (messageDto.JsonData == null)
							{
								global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(5204));
								break;
							}
							ClubDataDto obj2 = JsonConvert.DeserializeObject<ClubDataDto>(Encoding.ASCII.GetString(messageDto.JsonData));
							global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(5250));
							fM0zAP3Se()?.Invoke(obj2);
							break;
						}
						case TCPCommandType.Heartbeat:
							await qJ2kka49R();
							break;
						case TCPCommandType.OpenGSProWithLogging:
						{
							if (messageDto.JsonData == null)
							{
								global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(5294));
								break;
							}
							bool flag = JsonConvert.DeserializeObject<bool>(Encoding.ASCII.GetString(messageDto.JsonData));
							global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(5338), flag));
							global::GolfInPlugin.GolfInPlugin.Instance.SetOpenLoggingConsole(flag);
							break;
						}
						case TCPCommandType.AdjustBallPosition:
						{
							if (messageDto.JsonData == null)
							{
								global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(5294));
								break;
							}
							GspBoothData obj = JsonConvert.DeserializeObject<GspBoothData>(Encoding.ASCII.GetString(messageDto.JsonData));
							jvYwc6BBni()(obj);
							break;
						}
						}
					}
					catch (Exception ex)
					{
						global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(5400) + ex.Message));
					}
				}
			}
			await Task.Delay(50);
		}
	}

	private async Task JAtZJBAfL(object P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		CancellationToken token = (CancellationToken)P_0;
		rEhwWBA96P = new TcpListener(IPAddress.Parse(Dpdrn94xidrKkBCvWK.vZjKJCNxST(4502)), 9050);
		rEhwWBA96P.Start();
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(4524));
		byte[] array = new byte[16384];
		while (!token.IsCancellationRequested)
		{
			try
			{
				using (RiEwHPqaeG = await (rEhwWBA96P?.AcceptTcpClientAsync()))
				{
					IPEndPoint iPEndPoint = (IPEndPoint)RiEwHPqaeG.Client.RemoteEndPoint;
					global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(4566), iPEndPoint.Address, iPEndPoint.Port));
					using NetworkStream networkStream = RiEwHPqaeG.GetStream();
					while (!token.IsCancellationRequested && PY5NEVtJT())
					{
						int num = 0;
						if (networkStream.DataAvailable)
						{
							num = await networkStream.ReadAsync(array, 0, array.Length, token);
						}
						if (num > 0)
						{
							string item = Encoding.ASCII.GetString(array, 0, num);
							rYUwxPea18.Enqueue(item);
						}
					}
				}
			}
			catch (SocketException ex)
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)string.Format(Dpdrn94xidrKkBCvWK.vZjKJCNxST(4614), ex.ErrorCode, ex.Message));
				LCX3ulxyj();
				rEhwWBA96P.Stop();
				yKZwSII2MY.Cancel();
				Console.WriteLine(ex.Message);
			}
			catch (Exception ex2)
			{
				global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(4720) + ex2.Message));
				LCX3ulxyj();
			}
		}
	}

	public async Task is3GCUVgj(PlayerDataDto P_0)
	{
		string s = JsonConvert.SerializeObject(new MessageDto
		{
			Command = TCPCommandType.PlayerClubInfo,
			JsonData = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(P_0))
		});
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		await gOdayBdT2(bytes);
	}

	public async Task EkwL1oKVa(PlayerDataDto P_0)
	{
		string s = JsonConvert.SerializeObject(new MessageDto
		{
			Command = TCPCommandType.DistanceToPin,
			JsonData = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(P_0))
		});
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		await gOdayBdT2(bytes);
	}

	public async Task CGq2jlBQ6(string P_0)
	{
		string s = JsonConvert.SerializeObject(new MessageDto
		{
			Command = TCPCommandType.FirstTeeEvent,
			JsonData = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(P_0))
		});
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		await gOdayBdT2(bytes);
	}

	public async Task Mb9Xa82QP(GSProComputeData P_0)
	{
		string s = JsonConvert.SerializeObject(new MessageDto
		{
			Command = TCPCommandType.GameComputedData,
			JsonData = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(P_0))
		});
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		await gOdayBdT2(bytes);
	}

	public async Task FmuInJAVu(ShotDataDto P_0)
	{
		string s = JsonConvert.SerializeObject(new MessageDto
		{
			Command = TCPCommandType.ShotReceived,
			JsonData = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(P_0))
		});
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		await gOdayBdT2(bytes);
	}

	public async Task qJ2kka49R()
	{
		string s = JsonConvert.SerializeObject(new MessageDto
		{
			Command = TCPCommandType.Heartbeat,
			JsonData = null
		});
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		await gOdayBdT2(bytes);
	}

	public async Task mYnMuZQtU()
	{
		string s = JsonConvert.SerializeObject(new MessageDto
		{
			Command = TCPCommandType.ReadyReceiveShot,
			JsonData = null
		});
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		await gOdayBdT2(bytes);
	}

	public async Task s6XpTi0a2()
	{
		string s = JsonConvert.SerializeObject(new MessageDto
		{
			Command = TCPCommandType.RoundHasEnded,
			JsonData = null
		});
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		await gOdayBdT2(bytes);
	}

	public async Task CiUUnW4ue(bool P_0)
	{
		string s = JsonConvert.SerializeObject(new MessageDto
		{
			Command = TCPCommandType.OnScorecardVisible,
			JsonData = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(P_0))
		});
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		await gOdayBdT2(bytes);
	}

	public async Task XLsippTXf(bool P_0)
	{
		string s = JsonConvert.SerializeObject(new MessageDto
		{
			Command = TCPCommandType.OnOSKVisible,
			JsonData = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(P_0))
		});
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		await gOdayBdT2(bytes);
	}

	private async Task<bool> gOdayBdT2(byte[] P_0)
	{
		if (!PY5NEVtJT())
		{
			return false;
		}
		try
		{
			NetworkStream stream = RiEwHPqaeG.GetStream();
			if (stream.CanWrite)
			{
				await stream.WriteAsync(P_0, 0, P_0.Length);
			}
			return true;
		}
		catch (Exception ex)
		{
			global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(5462) + ex.ToString()));
			return false;
		}
	}

	public void LCX3ulxyj()
	{
		if (!PY5NEVtJT())
		{
			return;
		}
		try
		{
			global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(1492));
			RiEwHPqaeG?.Close();
			RiEwHPqaeG?.Dispose();
			RiEwHPqaeG = null;
		}
		catch (Exception ex)
		{
			global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(1542) + ex.Message + Dpdrn94xidrKkBCvWK.vZjKJCNxST(1608)));
		}
	}

	public async Task vI1ABmETr()
	{
		_ = 1;
		try
		{
			global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(4374));
			yKZwSII2MY.Cancel();
			bool hasReleaseResponseTask = await IXM6fQoVh(M6QwgtOgnk, 1000);
			bool num = await IXM6fQoVh(UoVw0JfpBK, 1000);
			if (!hasReleaseResponseTask)
			{
				M6QwgtOgnk.Dispose();
			}
			if (!num)
			{
				UoVw0JfpBK.Dispose();
			}
			M6QwgtOgnk = null;
			UoVw0JfpBK = null;
			LCX3ulxyj();
			rEhwWBA96P?.Stop();
			rEhwWBA96P = null;
		}
		catch (Exception ex)
		{
			global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogError((object)(Dpdrn94xidrKkBCvWK.vZjKJCNxST(1542) + ex.Message + Dpdrn94xidrKkBCvWK.vZjKJCNxST(1608)));
		}
		global::GolfInPlugin.GolfInPlugin.l6UB92DOY.LogInfo((object)Dpdrn94xidrKkBCvWK.vZjKJCNxST(4424));
	}

	private async Task<bool> IXM6fQoVh(Task P_0, int P_1)
	{
		return await Task.WhenAny(new Task[2]
		{
			P_0,
			Task.Delay(P_1)
		}) == P_0;
	}

	public sJ9hssTCYj7GDPnrdy()
	{
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		rYUwxPea18 = new ConcurrentQueue<string>();
		yKZwSII2MY = new CancellationTokenSource();
		base._002Ector();
	}
}
