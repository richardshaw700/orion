using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using lKEAGvFqWp7B16kDoY;

namespace GICTS.Data;

public class GICTSMessage
{
	public enum MessageDirectionEnum
	{
		Sent,
		Received
	}

	public enum InfoClassEnum
	{
		Handshake,
		Authentication,
		SimCommand,
		ACK,
		Warning,
		Response
	}

	public enum InfoSubClassEnum
	{
		Unknown,
		Handshake,
		Challenge,
		Ping,
		Pong,
		Arm,
		Disarm,
		ClubType,
		BallOnTee,
		CommandResult,
		SetBallDatat,
		SetClubData,
		SetTrackingStatusData,
		ShotComplete,
		EnvironmentDataModified,
		PlayerDataModified,
		ComputeData,
		FirstTee
	}

	[CompilerGenerated]
	private MessageDirectionEnum smaS8yaUZ7;

	[CompilerGenerated]
	private InfoClassEnum y21SuQDmuL;

	[CompilerGenerated]
	private InfoSubClassEnum UneSYCjuIA;

	[CompilerGenerated]
	private JsonMessage WjjSbNROCV;

	public DateTime TxTime => DateTime.Now;

	public MessageDirectionEnum Direction
	{
		[CompilerGenerated]
		get
		{
			return smaS8yaUZ7;
		}
		[CompilerGenerated]
		set
		{
			smaS8yaUZ7 = value;
		}
	}

	public InfoClassEnum InfoClass
	{
		[CompilerGenerated]
		get
		{
			return y21SuQDmuL;
		}
		[CompilerGenerated]
		set
		{
			y21SuQDmuL = value;
		}
	}

	public InfoSubClassEnum InfoSubClass
	{
		[CompilerGenerated]
		get
		{
			return UneSYCjuIA;
		}
		[CompilerGenerated]
		set
		{
			UneSYCjuIA = value;
		}
	}

	public JsonMessage Message
	{
		[CompilerGenerated]
		get
		{
			return WjjSbNROCV;
		}
		[CompilerGenerated]
		set
		{
			WjjSbNROCV = value;
		}
	}

	public string ToText()
	{
		JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
		jsonSerializerOptions.Converters.Add(new GICamJsonMessagePolymorphicSerializerConverter());
		return JsonSerializer.Serialize(this, jsonSerializerOptions);
	}

	public GICTSMessage()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
	}
}
