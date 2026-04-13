using System;
using GIToolkit.Services;

namespace Golfin.Dtos;

public interface IAppointmentContactInfo
{
	string Email { get; set; }

	string Phone { get; set; }

	string UserId { get; set; }

	int SiteId { get; set; }

	int NumberOfPlayers { get; set; }

	string Title { get; set; }

	bool IsFirstTimePlay { get; set; }

	bool NotifyRecipient { get; set; }

	bool ShouldAddAsContact { get; set; }

	bool HasSubscribedToNews { get; set; }

	int DurationHour { get; set; }

	int DurationMin { get; set; }

	DateTime? StartTime { get; set; }

	TimeSpan UserTimeZoneOffset { get; set; }

	SupportedCulture WebBrowserCulture { get; set; }
}
