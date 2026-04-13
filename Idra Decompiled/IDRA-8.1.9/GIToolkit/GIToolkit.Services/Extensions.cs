using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using U4yoVEpfEeOhjCsFXj;

namespace GIToolkit.Services;

public static class Extensions
{
	public static TimeSpan Sum(this IEnumerable<TimeSpan> rt)
	{
		TimeSpan zero = TimeSpan.Zero;
		foreach (TimeSpan item in rt)
		{
			zero += item;
		}
		return zero;
	}

	public static IEnumerable<T> Flatten<T, R>(this IEnumerable<T> source, Func<T, R> recursion) where R : IEnumerable<T>
	{
		List<T> list = source.ToList();
		IEnumerable<R> enumerable = source.Select(recursion);
		if (enumerable != null)
		{
			foreach (R item in enumerable)
			{
				if (item != null)
				{
					list.AddRange(item.Flatten(recursion));
				}
			}
		}
		return list;
	}

	public static CultureInfo GetAsCultureInfo(this SupportedCulture sc)
	{
		return new CultureInfo(sc.ToString().Replace(so95DAFNMfktfjp4Dm.An6v7kuCGg(2176), so95DAFNMfktfjp4Dm.An6v7kuCGg(2182)));
	}
}
