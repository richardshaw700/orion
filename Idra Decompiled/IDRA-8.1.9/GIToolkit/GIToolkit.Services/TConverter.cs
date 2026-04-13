using System;
using System.ComponentModel;

namespace GIToolkit.Services;

public static class TConverter
{
	public static T ChangeType<T>(string value)
	{
		return (T)ChangeType(typeof(T), value);
	}

	public static object ChangeType(Type type, string value)
	{
		if (type == typeof(bool) && sbyte.TryParse(value, out var result))
		{
			return Convert.ToBoolean(result);
		}
		return TypeDescriptor.GetConverter(type).ConvertFrom(value);
	}

	public static void RegisterTypeConverter<T, TC>() where TC : TypeConverter
	{
		TypeDescriptor.AddAttributes(typeof(T), new TypeConverterAttribute(typeof(TC)));
	}
}
