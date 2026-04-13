using System.Runtime.Serialization;
using lKEAGvFqWp7B16kDoY;

namespace GICTS.Data;

[DataContract]
public class ClubData
{
	private double NcovbkM3bw;

	private double MXZvfHlJPP;

	private double jF2vIIjnPN;

	private double xOjvOKBvWt;

	[DataMember]
	public double ClubHeadSpeed
	{
		get
		{
			return NcovbkM3bw;
		}
		set
		{
			NcovbkM3bw = value;
		}
	}

	[DataMember]
	public double ClubHeadSpeedMPH
	{
		get
		{
			return ClubHeadSpeed / 1.467;
		}
		set
		{
		}
	}

	[DataMember]
	public double ClubAngleFace
	{
		get
		{
			return MXZvfHlJPP;
		}
		set
		{
			MXZvfHlJPP = value;
		}
	}

	[DataMember]
	public double ClubAnglePath
	{
		get
		{
			return jF2vIIjnPN;
		}
		set
		{
			jF2vIIjnPN = value;
		}
	}

	public double ClubAngleOfAttack
	{
		get
		{
			return xOjvOKBvWt;
		}
		set
		{
			xOjvOKBvWt = value;
		}
	}

	public ClubData()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
	}
}
