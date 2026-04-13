using System;

namespace GICTSCore.Services.LocalAPI;

public static class MathExtensions
{
	public static T Clamp<T>(this T self, T min, T max) where T : IComparable
	{
		object obj = min;
		if (self.CompareTo(obj) < 0)
		{
			return min;
		}
		object obj2 = max;
		if (self.CompareTo(obj2) > 0)
		{
			return max;
		}
		return self;
	}
}
