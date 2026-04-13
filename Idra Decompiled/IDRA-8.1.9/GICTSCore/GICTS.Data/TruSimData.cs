using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;

namespace GICTS.Data;

[DataContract]
public class TruSimData
{
	[DataContract]
	public class LockSimulatorData
	{
		[DataMember]
		public double CenterOffset;

		[DataMember]
		public string BoothType;

		public LockSimulatorData()
		{
			fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
			BoothType = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7664);
			base._002Ector();
		}
	}

	[DataContract]
	public class SetClubTypeData
	{
		[DataMember]
		public string ClubType;

		public SetClubTypeData()
		{
			fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
			ClubType = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1392);
			base._002Ector();
		}
	}

	public const string NL_LAUNCH_ANGLE = "LaunchAngle";

	public const string NL_LAUNCH_DIRECTION = "LaunchDirection";

	public const string NL_BALL_SPEED = "BallSpeed";

	public const string NL_BACK_SPIN = "BackSpin";

	public const string NL_SIDE_SPIN = "SideSpin";

	public const string NL_SPIN_AXIS = "SpinAxis";

	public const string NL_TOTAL_SPIN = "TotalSpin";

	public const string NL_CLUB_HEAD_SPEED = "ClubHeadSpeed";

	public const string NL_CLUB_ANGLE_FACE = "ClubAngleFace";

	public const string NL_CLUB_ANGLE_PATH = "ClubAnglePath";

	public const string NL_SHOW_STATUS = "ShowStatusTrue";

	public const string NL_STATUS_TYPE = "StatusType";

	public const string NL_MESSAGE = "Message";

	public const string NL_LOG_TO_FILE = "LogToFileTrue";

	public const string NL_USES_CLUBS = "UsesClubsTrue";

	public const string NL_SENDS_TRAJECTORY = "SendsTrajectoryTrue";

	public static string[] ClubTypes;

	private BallData MkBvan6xUY;

	private ClubData aSjvZFPyyW;

	private TrackingStatusData CphvUpHL81;

	private ConfigData O2cvBC7t6K;

	private static Dictionary<string, double> KH7vhidxga;

	[DataMember]
	public BallData ballData
	{
		get
		{
			return MkBvan6xUY;
		}
		set
		{
			MkBvan6xUY = value;
		}
	}

	[DataMember]
	public ClubData clubData
	{
		get
		{
			return aSjvZFPyyW;
		}
		set
		{
			aSjvZFPyyW = value;
		}
	}

	[DataMember]
	public TrackingStatusData trackingStatusData
	{
		get
		{
			return CphvUpHL81;
		}
		set
		{
			CphvUpHL81 = value;
		}
	}

	[DataMember]
	public ConfigData ConfigData
	{
		get
		{
			return O2cvBC7t6K;
		}
		set
		{
			O2cvBC7t6K = value;
		}
	}

	public TruSimData()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
		MkBvan6xUY = new BallData();
		aSjvZFPyyW = new ClubData();
		CphvUpHL81 = new TrackingStatusData();
		O2cvBC7t6K = new ConfigData();
	}

	public string GetTruSimDataJSON()
	{
		MemoryStream memoryStream = new MemoryStream();
		new DataContractJsonSerializer(typeof(TruSimData)).WriteObject(memoryStream, this);
		return ReadSerializedStream(memoryStream);
	}

	public static TruSimData GetTruSimDataFromJSON(string szStream)
	{
		DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(TruSimData));
		MemoryStream stream = new MemoryStream(Encoding.ASCII.GetBytes(szStream));
		return (TruSimData)dataContractJsonSerializer.ReadObject(stream);
	}

	public string GetBallDataJSON()
	{
		MemoryStream memoryStream = new MemoryStream();
		new DataContractJsonSerializer(typeof(BallData)).WriteObject(memoryStream, MkBvan6xUY);
		return ReadSerializedStream(memoryStream);
	}

	public string GetClubDataJSON()
	{
		MemoryStream memoryStream = new MemoryStream();
		new DataContractJsonSerializer(typeof(ClubData)).WriteObject(memoryStream, aSjvZFPyyW);
		return ReadSerializedStream(memoryStream);
	}

	public string GetTrackingDataJSON()
	{
		MemoryStream memoryStream = new MemoryStream();
		new DataContractJsonSerializer(typeof(TrackingStatusData)).WriteObject(memoryStream, CphvUpHL81);
		return ReadSerializedStream(memoryStream);
	}

	public string GetConfigDataJSON()
	{
		MemoryStream memoryStream = new MemoryStream();
		new DataContractJsonSerializer(typeof(ConfigData)).WriteObject(memoryStream, O2cvBC7t6K);
		return ReadSerializedStream(memoryStream);
	}

	protected string ReadSerializedStream(MemoryStream mStream)
	{
		mStream.Position = 0L;
		return new StreamReader(mStream).ReadToEnd();
	}

	public static double GetDefaultValue(string szKey)
	{
		double value = 0.0;
		KH7vhidxga.TryGetValue(szKey, out value);
		return value;
	}

	static TruSimData()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		ClubTypes = new string[27]
		{
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1392),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7150),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7164),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7178),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7192),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7206),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7220),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7234),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7248),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7262),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7280),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7298),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7316),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7370),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7384),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7398),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7412),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7426),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1378),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7440),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7454),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7468),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7482),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7512),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7532),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7554),
			YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1406)
		};
		KH7vhidxga = new Dictionary<string, double>();
	}
}
