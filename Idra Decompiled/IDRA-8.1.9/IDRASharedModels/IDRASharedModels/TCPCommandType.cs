namespace IDRASharedModels;

public enum TCPCommandType
{
	BallData = 41500,
	ClubData = 41501,
	GameComputedData = 41503,
	FirstTeeEvent = 41504,
	AdjustBallPosition = 41505,
	Heartbeat = 41490,
	RecipeData = 41488,
	PlayerClubInfo = 45584,
	DistanceToPin = 45585,
	TrajectoryResult = 53504,
	ReadyReceiveShot = 45586,
	RoundHasEnded = 45587,
	ShotReceived = 53505,
	OpenGSProWithLogging = 53506,
	OnScorecardVisible = 53507,
	OnOSKVisible = 53508,
	MoveTeeBallLeft = 53509,
	MoveTeeBallRight = 53510
}
