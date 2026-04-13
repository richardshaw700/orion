using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using GICTS.Data;
using GIToolkit.Helpers;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;
using w51ddNTrxy51GwXxPV;

namespace GICTSCore.Services.LocalAPI;

public class TruSimE6APIService : CommunicationIDRALocalAPI
{
	private readonly UNfueTvIXSsMOJnqF9 LHMThp7yoN;

	private readonly Dictionary<string, string> aIZTtlqTwg;

	public override ILocalAPIGameSettings LocalAPIGameSettings => new LocalAPITruSimSettings();

	public override bool IsConnected => LHMThp7yoN.hO5D0pfh98();

	public TruSimE6APIService()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		aIZTtlqTwg = new Dictionary<string, string>
		{
			{
				YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15158),
				YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15872)
			},
			{
				YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15224),
				YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15242)
			}
		};
		base._002Ector();
		LHMThp7yoN = new UNfueTvIXSsMOJnqF9(vbxTaPuYTq(PJfTZUoYNw()), _0020: false);
		LHMThp7yoN.EMyDOT0ADm(dTCTBVo2Pr);
		LHMThp7yoN.B2ZDaLX340(EKJTOPsw4s);
		LHMThp7yoN.RqsDZO4rLu(juETb1qyit);
		LHMThp7yoN.s6kDUmZhT1(ldITfyHVU6);
		LHMThp7yoN.zH1DBxil5f(fNRTIAW4Oi);
	}

	public override void Connect()
	{
		if (LHMThp7yoN.hO5D0pfh98())
		{
			OnNewTextMessage?.Invoke(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15884));
			return;
		}
		IPEndPoint iPEndPoint;
		if (IPAddress.TryParse(LocalAPIGameSettings.HostName, out IPAddress address))
		{
			iPEndPoint = new IPEndPoint(address, LocalAPIGameSettings.PortNo);
		}
		else
		{
			IPHostEntry hostEntry;
			try
			{
				hostEntry = Dns.GetHostEntry(LocalAPIGameSettings.HostName);
			}
			catch (Exception ex)
			{
				OnNewTextMessage?.Invoke(ex.Message);
				return;
			}
			List<IPEndPoint> list = new List<IPEndPoint>();
			IPAddress[] addressList = hostEntry.AddressList;
			foreach (IPAddress iPAddress in addressList)
			{
				if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
				{
					list.Add(new IPEndPoint(iPAddress, LocalAPIGameSettings.PortNo));
				}
			}
			if (list.Count != 1)
			{
				if (list.Count > 1)
				{
					StringBuilder stringBuilder = new StringBuilder(512);
					stringBuilder.Append(string.Format(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15944), LocalAPIGameSettings.HostName));
					foreach (IPEndPoint item in list)
					{
						stringBuilder.Append(string.Format(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16076), item.Address.ToString()));
					}
					OnNewTextMessage?.Invoke(stringBuilder.ToString());
				}
				else
				{
					OnNewTextMessage?.Invoke(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16116) + LocalAPIGameSettings.HostName + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16186));
				}
				return;
			}
			iPEndPoint = list[0];
		}
		LHMThp7yoN.ykgDAH314t(iPEndPoint);
	}

	private void juETb1qyit(bool P_0)
	{
		string text = (P_0 ? YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2404) : YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16192));
		OnNewTextMessage?.Invoke(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16210) + text);
		OnClientConnected?.Invoke(P_0);
	}

	private void ldITfyHVU6(string P_0)
	{
		OnNewTextMessage?.Invoke(P_0);
		OnClientDisconnected?.Invoke(obj: true);
	}

	private void fNRTIAW4Oi(bool P_0)
	{
		string text = (P_0 ? YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2404) : YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16192));
		OnNewTextMessage?.Invoke(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16242) + text);
		OnAuthenticated?.Invoke(P_0);
	}

	private void EKJTOPsw4s(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return;
		}
		try
		{
			JsonElement toJsonObj = default(JsonElement);
			string text = PrettyJson(P_0, ref toJsonObj, logIntdented: false);
			if (!GIUtils.FilterMessage(toJsonObj, aIZTtlqTwg))
			{
				OnNewTextMessage?.Invoke(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16276) + (string.IsNullOrEmpty(text) ? P_0 : text));
			}
			GICTSMessage.InfoSubClassEnum lastCommand = GICTSMessage.InfoSubClassEnum.Unknown;
			JsonDocument jsonDocument = JsonDocument.Parse(P_0);
			JsonElement rootElement = jsonDocument.RootElement;
			string text2 = rootElement.GetProperty(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15158)).GetString();
			if (!(text2 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15254)))
			{
				if (!(text2 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1306)))
				{
					if (text2 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13640))
					{
						string text3 = rootElement.GetProperty(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15224)).GetString();
						if (!(text3 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16370)))
						{
							if (text3 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14842))
							{
								lastCommand = GICTSMessage.InfoSubClassEnum.ClubType;
								OnSetClubType?.Invoke(GICTSMessage.InfoClassEnum.ACK, CurrentClubType);
							}
						}
						else
						{
							lastCommand = GICTSMessage.InfoSubClassEnum.SetTrackingStatusData;
							OnTrackingStatusData?.Invoke();
						}
					}
				}
				else
				{
					string text3 = rootElement.GetProperty(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15224)).GetString();
					if (!(text3 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15170)))
					{
						if (text3 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14842))
						{
							lastCommand = GICTSMessage.InfoSubClassEnum.ClubType;
							OnSetClubType?.Invoke(GICTSMessage.InfoClassEnum.Warning, CurrentClubType);
						}
					}
					else
					{
						lastCommand = GICTSMessage.InfoSubClassEnum.Handshake;
						OnClientConnected?.Invoke(obj: true);
						OnAuthenticated?.Invoke(obj: true);
					}
				}
			}
			else
			{
				string text3 = rootElement.GetProperty(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15224)).GetString();
				if (!(text3 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15242)))
				{
					if (!(text3 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15350)))
					{
						if (!(text3 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15334)))
						{
							if (!(text3 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15306)))
							{
								if (!(text3 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15410)))
								{
									if (text3 == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(15360))
									{
										lastCommand = GICTSMessage.InfoSubClassEnum.EnvironmentDataModified;
										SimCommandEnvironmentDataModifiedMsg obj = JsonSerializer.Deserialize<SimCommandEnvironmentDataModifiedMsg>(rootElement.GetProperty(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16294)).GetRawText());
										OnEnvironmentDataModified?.Invoke(obj);
									}
								}
								else
								{
									lastCommand = GICTSMessage.InfoSubClassEnum.PlayerDataModified;
									JsonElement property = rootElement.GetProperty(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16294));
									string key = property.GetProperty(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16312)).GetString();
									JsonElement property2 = property.GetProperty(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16332));
									ClubTypeDictionairy.E6ClubTypesDictionairy.TryGetValue(key, out var value);
									CurrentClubType = value;
									CurrentPlayerHandedness = ((property2.GetString() == YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16356)) ? PlayerHandednessNatureEnum.Right : PlayerHandednessNatureEnum.Left);
									OnPlayerDataModified?.Invoke(CurrentPlayerHandedness, CurrentClubType, "");
								}
							}
							else
							{
								lastCommand = GICTSMessage.InfoSubClassEnum.ShotComplete;
								SimCommandShotCompletedMsg obj2 = JsonSerializer.Deserialize<SimCommandShotCompletedMsg>(rootElement.GetProperty(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16294)).GetRawText());
								OnShotCompleted?.Invoke(obj2);
							}
						}
						else
						{
							lastCommand = GICTSMessage.InfoSubClassEnum.Disarm;
							SimCommandDisarmMsg simCommandDisarmMsg = JsonSerializer.Deserialize<SimCommandDisarmMsg>(jsonDocument.RootElement.ToString());
							OnDisarmed?.Invoke(simCommandDisarmMsg.Details);
						}
					}
					else
					{
						lastCommand = GICTSMessage.InfoSubClassEnum.Arm;
						SimCommandArmMsg simCommandArmMsg = JsonSerializer.Deserialize<SimCommandArmMsg>(jsonDocument.RootElement.ToString());
						OnArmed?.Invoke(simCommandArmMsg.Details);
					}
				}
				else
				{
					lastPingPong = DateTime.Now;
					OnPing?.Invoke(lastPingPong);
				}
			}
			LastCommand = lastCommand;
		}
		catch (Exception ex)
		{
			OnNewTextMessage?.Invoke(hLMTUAfsYH(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16416)) + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16452) + ex.Message);
		}
	}

	public override void Disconnect()
	{
		base.Disconnect();
		LHMThp7yoN.m3eDy3OeHO();
	}

	private TruSimData vbxTaPuYTq(CTSShotData P_0)
	{
		return new TruSimData
		{
			ballData = P_0.Ball,
			clubData = P_0.Club,
			ConfigData = P_0.ConfigData
		};
	}

	public override void SendShot(CTSShotData shot)
	{
		if (!LHMThp7yoN.hO5D0pfh98())
		{
			Connect();
		}
		SendConfigDataMessage(shot.ConfigData);
		if (!LHMThp7yoN.SendShot(vbxTaPuYTq(shot)))
		{
			OnNewTextMessage?.Invoke(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16472));
		}
	}

	private CTSShotData PJfTZUoYNw()
	{
		return new CTSShotData
		{
			Ball = new BallData
			{
				LaunchDirection = -7.638,
				LaunchAngle = 12.0,
				BallSpeed = 190.0,
				SideSpin = 6000.0
			},
			Club = new ClubData
			{
				ClubAngleFace = 0.0,
				ClubAnglePath = 0.0,
				ClubHeadSpeed = 125.0
			}
		};
	}

	public override void SendUpdateShot(CTSShotData shot)
	{
		if (!LHMThp7yoN.hO5D0pfh98())
		{
			Connect();
		}
		if (!LHMThp7yoN.tlXDk7vvuM(vbxTaPuYTq(shot)))
		{
			OnNewTextMessage?.Invoke(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16472));
		}
	}

	private string hLMTUAfsYH(string P_0 = "")
	{
		return YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16518) + P_0 + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13724);
	}

	private void dTCTBVo2Pr(string P_0)
	{
		JsonElement toJsonObj = default(JsonElement);
		P_0 = PrettyJson(P_0, ref toJsonObj, logIntdented: false);
		if (!GIUtils.FilterMessage(toJsonObj, aIZTtlqTwg))
		{
			OnNewTextMessage?.Invoke(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16524) + P_0);
		}
	}

	protected string ReadSerializedStream(MemoryStream mStream)
	{
		mStream.Position = 0L;
		return new StreamReader(mStream).ReadToEnd();
	}

	public override void GetPlayerDataMessage()
	{
		string text = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16542);
		LHMThp7yoN.jNmD1AkuP6(text);
	}

	public override void GetEnvironmentDataMessage()
	{
		string text = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16598);
		LHMThp7yoN.jNmD1AkuP6(text);
	}

	public override void SetClubTypeMessage(SetClubTypeData msg)
	{
		string text = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16664) + msg.ClubType + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16744);
		LHMThp7yoN.jNmD1AkuP6(text);
	}

	public override void SendAnyMessage(string msg)
	{
		string text = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16752) + msg + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16776);
		LHMThp7yoN.jNmD1AkuP6(text);
	}

	public override void SendConfigDataMessage(ConfigData msg)
	{
		MemoryStream memoryStream = new MemoryStream();
		new DataContractJsonSerializer(typeof(ConfigData)).WriteObject(memoryStream, msg);
		string text = ReadSerializedStream(memoryStream);
		string text2 = LHMThp7yoN.JljDlHJb23(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14772), text);
		LHMThp7yoN.jNmD1AkuP6(text2);
	}

	public override void SendStatusMessage(TrackingStatusData msg)
	{
		MemoryStream memoryStream = new MemoryStream();
		new DataContractJsonSerializer(typeof(TrackingStatusData)).WriteObject(memoryStream, msg);
		string text = ReadSerializedStream(memoryStream);
		string text2 = LHMThp7yoN.JljDlHJb23(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(14688), text);
		LHMThp7yoN.jNmD1AkuP6(text2);
	}

	public override void SendBoothDataMessage(BoothData msg)
	{
		MemoryStream memoryStream = new MemoryStream();
		new DataContractJsonSerializer(typeof(BoothData)).WriteObject(memoryStream, msg);
		string text = ReadSerializedStream(memoryStream);
		string text2 = LHMThp7yoN.JljDlHJb23(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(16784), text);
		LHMThp7yoN.jNmD1AkuP6(text2);
	}
}
