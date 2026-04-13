using System;
using System.ComponentModel;

namespace IDRAMonitor.Converters;

public static class TConverter
{
	public static T ChangeType<T>(string value)
	{
		return (T)ChangeType(typeof(T), value);
	}

	public static object ChangeType(Type t, string value)
	{
		if (t == typeof(bool) && sbyte.TryParse(value, out var result))
		{
			return Convert.ToBoolean(result);
		}
		return TypeDescriptor.GetConverter(t).ConvertFrom(value);
	}

	public static void RegisterTypeConverter<T, TC>() where TC : TypeConverter
	{
		TypeDescriptor.AddAttributes(typeof(T), new TypeConverterAttribute(typeof(TC)));
	}
}
