using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using U4yoVEpfEeOhjCsFXj;

namespace GIToolkit.Extensions;

public static class EnumExtensions
{
	public static string GetDescription(this Enum value)
	{
		if (value == null)
		{
			return string.Empty;
		}
		if (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) is DescriptionAttribute descriptionAttribute)
		{
			return descriptionAttribute.Description;
		}
		return value.ToString();
	}

	public static T GetValueFromDescription<T>(string description)
	{
		Type typeFromHandle = typeof(T);
		if (!typeFromHandle.IsEnum)
		{
			throw new InvalidOperationException();
		}
		FieldInfo[] fields = typeFromHandle.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			if (Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute)) is DescriptionAttribute descriptionAttribute)
			{
				if (descriptionAttribute.Description == description)
				{
					return (T)fieldInfo.GetValue(null);
				}
			}
			else if (fieldInfo.Name == description)
			{
				return (T)fieldInfo.GetValue(null);
			}
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(21200));
		defaultInterpolatedStringHandler.AppendFormatted(typeFromHandle);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(21274));
		throw new ArgumentException(defaultInterpolatedStringHandler.ToStringAndClear(), so95DAFNMfktfjp4Dm.An6v7kuCGg(21280));
	}
}
