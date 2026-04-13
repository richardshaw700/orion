using System;
using System.Collections.Generic;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Services;

public class GolfinUtils
{
	public static string GeneratePin(DateTime? utcTime = null)
	{
		if (!utcTime.HasValue)
		{
			utcTime = DateTime.UtcNow;
		}
		int? num = checked(utcTime?.Year * utcTime?.Month * utcTime?.Day) / 36;
		if (num < 100)
		{
			num = checked(num * 100);
		}
		else if (num < 1000)
		{
			num = checked(num * 10);
		}
		else if (num > 10000)
		{
			num /= 10;
		}
		return num.ToString();
	}

	public static List<(int, int)> GetPositionLists()
	{
		return new List<(int, int)>
		{
			(1, 0),
			(2, 0),
			(3, 0),
			(4, 0),
			(5, 0),
			(3, 3),
			(4, 3),
			(4, 4),
			(5, 4),
			(5, 5),
			(6, 5),
			(6, 6),
			(7, 6),
			(7, 7),
			(8, 7),
			(8, 8),
			(9, 8),
			(9, 9)
		};
	}

	public GolfinUtils()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
	}
}
