using System.Runtime.Serialization;
using lKEAGvFqWp7B16kDoY;

namespace GICTS.Data;

[DataContract]
public class ConfigData
{
	[DataMember]
	public bool LogToFile;

	[DataMember]
	public bool UsesClubs;

	[DataMember]
	public bool SendsTrajectory;

	[DataMember]
	public float OffsetClubFaceWood;

	[DataMember]
	public float OffsetClubFaceIron;

	[DataMember]
	public float PercentBackSpinWood;

	[DataMember]
	public float PercentBackSpinIron;

	[DataMember]
	public bool ShowBallOnScreen;

	[DataMember]
	public float BallOnScreenDistance;

	[DataMember]
	public bool StartBallAtImpact;

	[DataMember]
	public bool ShowPostShot;

	public ConfigData()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		UsesClubs = true;
		PercentBackSpinWood = 100f;
		PercentBackSpinIron = 90f;
		ShowBallOnScreen = true;
		BallOnScreenDistance = -1f;
		ShowPostShot = true;
		base._002Ector();
	}
}
