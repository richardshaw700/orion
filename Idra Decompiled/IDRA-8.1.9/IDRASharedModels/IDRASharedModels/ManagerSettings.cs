using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using F3frs5SXTsGVtVfuZX;
using GYFmeytn3uk9KnUELA;
using Newtonsoft.Json;
using RIrlNToRdPZ6Uy0SYo;

namespace IDRASharedModels;

[Serializable]
public class ManagerSettings
{
	[JsonIgnore]
	private string C0PhOMVPM;

	[JsonIgnore]
	private string jXQfZ6p2t;

	[CompilerGenerated]
	private bool ULHJcHqxU;

	[CompilerGenerated]
	private bool cb6L3TwLx;

	[CompilerGenerated]
	private bool NjQ5vY5rO;

	[CompilerGenerated]
	private TimeSpan HfCkvWyTN;

	[CompilerGenerated]
	private int j4xEgFcGp;

	[CompilerGenerated]
	private bool uaFI8uPKT;

	[CompilerGenerated]
	private bool CXjQxojL9;

	[CompilerGenerated]
	private int xva6t9uiC;

	[CompilerGenerated]
	private double Poqq7XFSQ;

	[CompilerGenerated]
	private bool iIm9yQp85;

	[CompilerGenerated]
	private int EOIGtdLuo;

	[CompilerGenerated]
	private VisualSettings vwWbghTnn;

	[CompilerGenerated]
	private RoundSettings xnMO0AMfN;

	[CompilerGenerated]
	private GameSettings xwsHHGU46;

	[CompilerGenerated]
	private Action oHfKxRmX4;

	[CompilerGenerated]
	private static readonly ManagerSettings s6tm3nZsn;

	private static readonly SemaphoreSlim pe17qbsCU;

	private string RIrrlNTRd;

	[JsonIgnore]
	private static string vhIwyRRTV
	{
		get
		{
			if (Environment.GetEnvironmentVariable(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(1192)) == null)
			{
				return mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(1228);
			}
			return mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(1288);
		}
	}

	public bool UseGolfInPostShotInGame
	{
		[CompilerGenerated]
		get
		{
			return ULHJcHqxU;
		}
		[CompilerGenerated]
		set
		{
			ULHJcHqxU = value;
		}
	}

	public bool UseGolfInPostShotInPractice
	{
		[CompilerGenerated]
		get
		{
			return cb6L3TwLx;
		}
		[CompilerGenerated]
		set
		{
			cb6L3TwLx = value;
		}
	}

	public bool DisplayGSProDataTile
	{
		[CompilerGenerated]
		get
		{
			return NjQ5vY5rO;
		}
		[CompilerGenerated]
		set
		{
			NjQ5vY5rO = value;
		}
	}

	public TimeSpan PostShotAutoContinueDuration
	{
		[CompilerGenerated]
		get
		{
			return HfCkvWyTN;
		}
		[CompilerGenerated]
		set
		{
			HfCkvWyTN = value;
		}
	}

	public int PostShotConsideredCenter
	{
		[CompilerGenerated]
		get
		{
			return j4xEgFcGp;
		}
		[CompilerGenerated]
		set
		{
			j4xEgFcGp = value;
		}
	}

	public bool PostShotMetricUnit
	{
		[CompilerGenerated]
		get
		{
			return uaFI8uPKT;
		}
		[CompilerGenerated]
		set
		{
			uaFI8uPKT = value;
		}
	}

	public bool UseSwingPlateDr
	{
		[CompilerGenerated]
		get
		{
			return CXjQxojL9;
		}
		[CompilerGenerated]
		set
		{
			CXjQxojL9 = value;
		}
	}

	public int SwingPlateDrPortComNumber
	{
		[CompilerGenerated]
		get
		{
			return xva6t9uiC;
		}
		[CompilerGenerated]
		set
		{
			xva6t9uiC = value;
		}
	}

	public double SwingPlateDrMinConsideredAngle
	{
		[CompilerGenerated]
		get
		{
			return Poqq7XFSQ;
		}
		[CompilerGenerated]
		set
		{
			Poqq7XFSQ = value;
		}
	}

	public bool UseAutoTee
	{
		[CompilerGenerated]
		get
		{
			return iIm9yQp85;
		}
		[CompilerGenerated]
		set
		{
			iIm9yQp85 = value;
		}
	}

	public int AutoTeeComPortNumber
	{
		[CompilerGenerated]
		get
		{
			return EOIGtdLuo;
		}
		[CompilerGenerated]
		set
		{
			EOIGtdLuo = value;
		}
	}

	public VisualSettings VisualSettings
	{
		[CompilerGenerated]
		get
		{
			return vwWbghTnn;
		}
		[CompilerGenerated]
		set
		{
			vwWbghTnn = value;
		}
	}

	public RoundSettings RoundSettings
	{
		[CompilerGenerated]
		get
		{
			return xnMO0AMfN;
		}
		[CompilerGenerated]
		set
		{
			xnMO0AMfN = value;
		}
	}

	public GameSettings GameSettings
	{
		[CompilerGenerated]
		get
		{
			return xwsHHGU46;
		}
		[CompilerGenerated]
		set
		{
			xwsHHGU46 = value;
		}
	}

	[JsonIgnore]
	public Action OnManagerSettingsReload
	{
		[CompilerGenerated]
		get
		{
			return oHfKxRmX4;
		}
		[CompilerGenerated]
		set
		{
			oHfKxRmX4 = value;
		}
	}

	[JsonIgnore]
	public static ManagerSettings Instance
	{
		[CompilerGenerated]
		get
		{
			return s6tm3nZsn;
		}
	}

	public ManagerSettings()
	{
		l26t3npZsnUe1qbsCU.vf2WGHkzGx201();
		C0PhOMVPM = mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(1336) + vhIwyRRTV + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(1370);
		jXQfZ6p2t = I74owsDxD();
		ULHJcHqxU = true;
		cb6L3TwLx = true;
		HfCkvWyTN = TimeSpan.FromSeconds(5.0);
		j4xEgFcGp = 10;
		xva6t9uiC = -1;
		Poqq7XFSQ = 2.0;
		EOIGtdLuo = -1;
		vwWbghTnn = new VisualSettings();
		xnMO0AMfN = new RoundSettings();
		xwsHHGU46 = new GameSettings();
		RIrrlNTRd = string.Empty;
		base._002Ector();
	}

	private static string I74owsDxD()
	{
		bool num = Environment.GetEnvironmentVariable(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(1192)) != null;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
		string text = Path.Combine(folderPath, mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(1426));
		string text2 = Path.Combine(folderPath, mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(1498));
		string path = (num ? text : text2);
		string result = Path.Combine(path, mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(1582));
		string text3 = Path.Combine(path, mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(1622));
		if (!num || !File.Exists(text3))
		{
			return result;
		}
		return text3;
	}

	public async Task<(bool, string)> SaveSetting()
	{
		await pe17qbsCU.WaitAsync();
		string logs = "";
		try
		{
			logs += string.Format(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(2830), RIrrlNTRd, this);
			bool result = await pEMtMvG6D(this, C0PhOMVPM);
			logs = ((!result) ? (logs + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(3022)) : (logs + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(2934)));
			(bool, string) tuple = await SaveEnablePostShotSetting(UseGolfInPostShotInGame || UseGolfInPostShotInPractice);
			result &= tuple.Item1;
			logs += tuple.Item2;
			if (result)
			{
				RIrrlNTRd = JsonConvert.SerializeObject(this);
			}
			return (result, logs);
		}
		catch (IOException ex)
		{
			logs = logs + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(3104) + ex.Message + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(72);
			return (true, logs);
		}
		finally
		{
			pe17qbsCU.Release();
		}
	}

	public async Task<(bool, string)> SaveEnablePostShotSetting(bool savePostShotVideo)
	{
		string logs = "";
		try
		{
			bool num = await COEXLy9ia(savePostShotVideo);
			logs = ((!num) ? (logs + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(2480)) : (logs + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(2324)));
			return (num, logs);
		}
		catch (IOException ex)
		{
			logs = logs + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(2630) + ex.Message + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(72);
			return (true, logs);
		}
	}

	public async Task<string> Reload(bool checkNewProp = true)
	{
		_ = 3;
		try
		{
			await pe17qbsCU.WaitAsync();
			ManagerSettings managerSettings;
			if (!File.Exists(C0PhOMVPM))
			{
				managerSettings = new ManagerSettings();
				await pEMtMvG6D(managerSettings, C0PhOMVPM);
				KRbxL8QAM(managerSettings);
				return "";
			}
			await ygaFhUEeP(C0PhOMVPM);
			managerSettings = JsonConvert.DeserializeObject<ManagerSettings>(File.ReadAllText(C0PhOMVPM));
			if (checkNewProp && !JsonPropertyComparer.IsJsonPropSameAsSavedFile(managerSettings, C0PhOMVPM))
			{
				await pEMtMvG6D(managerSettings, C0PhOMVPM);
			}
			RIrrlNTRd = JsonConvert.SerializeObject(this);
			KRbxL8QAM(managerSettings);
			OnManagerSettingsReload?.Invoke();
		}
		catch (Exception ex)
		{
			if (!string.IsNullOrWhiteSpace(RIrrlNTRd))
			{
				KRbxL8QAM(JsonConvert.DeserializeObject<ManagerSettings>(RIrrlNTRd));
			}
			return ex.Message;
		}
		finally
		{
			pe17qbsCU.Release();
		}
		return "";
	}

	private void KRbxL8QAM(ManagerSettings P_0)
	{
		UseGolfInPostShotInGame = P_0.UseGolfInPostShotInGame;
		UseGolfInPostShotInPractice = P_0.UseGolfInPostShotInPractice;
		DisplayGSProDataTile = P_0.DisplayGSProDataTile;
		PostShotAutoContinueDuration = P_0.PostShotAutoContinueDuration;
		PostShotConsideredCenter = P_0.PostShotConsideredCenter;
		PostShotMetricUnit = P_0.PostShotMetricUnit;
		SwingPlateDrPortComNumber = P_0.SwingPlateDrPortComNumber;
		SwingPlateDrMinConsideredAngle = P_0.SwingPlateDrMinConsideredAngle;
		UseSwingPlateDr = P_0.UseSwingPlateDr;
		AutoTeeComPortNumber = P_0.AutoTeeComPortNumber;
		UseAutoTee = P_0.UseAutoTee;
		VisualSettings = P_0.VisualSettings;
		RoundSettings = P_0.RoundSettings;
		GameSettings = P_0.GameSettings;
	}

	private async Task ygaFhUEeP(string P_0, int P_1 = 300, int P_2 = 100)
	{
		int cptAttemps = 0;
		while (true)
		{
			int num = cptAttemps + 1;
			cptAttemps = num;
			if (num >= P_1)
			{
				break;
			}
			try
			{
				using (File.Open(P_0, FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					break;
				}
			}
			catch (Exception)
			{
				await Task.Delay(TimeSpan.FromMilliseconds(P_2));
			}
		}
	}

	private async Task OT6iK6cdv(FileInfo P_0)
	{
		Directory.CreateDirectory(P_0.DirectoryName);
		if (!P_0.Exists)
		{
			string contents = JsonConvert.SerializeObject(new ManagerSettings());
			P_0.WriteAllTextWithBackupGSProVersion(contents);
		}
		await ygaFhUEeP(P_0.FullName);
	}

	private async Task<bool> pEMtMvG6D(ManagerSettings P_0, string P_1)
	{
		FileInfo file = new FileInfo(P_1);
		await OT6iK6cdv(file);
		try
		{
			file.WriteAllTextWithBackupGSProVersion(JsonConvert.SerializeObject(P_0, Formatting.Indented));
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private async Task<bool> COEXLy9ia(bool P_0)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(jXQfZ6p2t);
			if (!fileInfo.Exists || fileInfo.Length <= 0)
			{
				return false;
			}
			await ygaFhUEeP(jXQfZ6p2t);
			XmlDocument val = new XmlDocument();
			val.Load(jXQfZ6p2t);
			XmlNode val2 = ((XmlNode)val.DocumentElement).SelectSingleNode(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(2098)) ?? throw new NullReferenceException(mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(2184));
			if (val2.InnerText == mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(2312) == P_0)
			{
				return true;
			}
			val2.InnerText = (P_0 ? mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(2312) : mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(2318));
			val.Save(jXQfZ6p2t);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool operator ==(ManagerSettings obj1, ManagerSettings obj2)
	{
		if ((object)obj1 == obj2)
		{
			return true;
		}
		if ((object)obj1 == null || (object)obj2 == null)
		{
			return false;
		}
		bool num = obj1.UseGolfInPostShotInPractice == obj2.UseGolfInPostShotInPractice && obj1.UseGolfInPostShotInGame == obj2.UseGolfInPostShotInGame && obj1.DisplayGSProDataTile == obj2.DisplayGSProDataTile && obj1.PostShotAutoContinueDuration == obj2.PostShotAutoContinueDuration && obj1.PostShotConsideredCenter == obj2.PostShotConsideredCenter && obj1.PostShotMetricUnit == obj2.PostShotMetricUnit && obj1.SwingPlateDrPortComNumber == obj2.SwingPlateDrPortComNumber && obj1.SwingPlateDrMinConsideredAngle == obj2.SwingPlateDrMinConsideredAngle && obj1.UseSwingPlateDr == obj2.UseSwingPlateDr && obj1.UseAutoTee == obj2.UseAutoTee && obj1.AutoTeeComPortNumber == obj2.AutoTeeComPortNumber;
		bool flag = obj1.VisualSettings.EnableDistanceDisplay == obj2.VisualSettings.EnableDistanceDisplay && obj1.VisualSettings.EnableGimmeCircle == obj2.VisualSettings.EnableGimmeCircle && obj1.VisualSettings.EnableTeeOffset == obj2.VisualSettings.EnableTeeOffset && obj1.VisualSettings.BaseCenterOffsetInches == obj2.VisualSettings.BaseCenterOffsetInches && obj1.VisualSettings.ScreenWidthInches == obj2.VisualSettings.ScreenWidthInches && obj1.VisualSettings.DistanceCountDirection == obj2.VisualSettings.DistanceCountDirection;
		bool flag2 = obj1.RoundSettings.PermitMulligan == obj2.RoundSettings.PermitMulligan && obj1.RoundSettings.UseCourseElevation == obj2.RoundSettings.UseCourseElevation && obj1.RoundSettings.ForceRealistic == obj2.RoundSettings.ForceRealistic && obj1.RoundSettings.Pins == obj2.RoundSettings.Pins && obj1.RoundSettings.Stimp == obj2.RoundSettings.Stimp && obj1.RoundSettings.SelectedGimmeCircleDistance == obj2.RoundSettings.SelectedGimmeCircleDistance && obj1.RoundSettings.FairWayFirmnessDD == obj2.RoundSettings.FairWayFirmnessDD && obj1.RoundSettings.GreenFirmnessDD == obj2.RoundSettings.GreenFirmnessDD && obj1.RoundSettings.PuttingDD == obj2.RoundSettings.PuttingDD && obj1.RoundSettings.ConcedeDD == obj2.RoundSettings.ConcedeDD && obj1.RoundSettings.AutoConcede == obj2.RoundSettings.AutoConcede;
		bool flag3 = obj1.GameSettings.GlobalAltitude == obj2.GameSettings.GlobalAltitude && obj1.GameSettings.PlayerRotation == obj2.GameSettings.PlayerRotation && obj1.GameSettings.ForceOSK == obj2.GameSettings.ForceOSK && obj1.GameSettings.MiniMapLocation == obj2.GameSettings.MiniMapLocation && obj1.GameSettings.ScoreCardTimeAfterHole == obj2.GameSettings.ScoreCardTimeAfterHole;
		return num && flag && flag2 && flag3;
	}

	public static bool operator !=(ManagerSettings obj1, ManagerSettings obj2)
	{
		return !(obj1 == obj2);
	}

	static ManagerSettings()
	{
		G2089JiDB7k4x1yr7J.kLjw4iIsCLsZtxc4lksN0j();
		l26t3npZsnUe1qbsCU.vf2WGHkzGx201();
		s6tm3nZsn = new ManagerSettings();
		pe17qbsCU = new SemaphoreSlim(1, 1);
	}
}
