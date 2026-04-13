using System.ComponentModel;
using System.Reflection;

public static class HikrobotParameterExtensions
{
	public static string GetDescription(this HikrobotParameter parameter)
	{
		FieldInfo field = parameter.GetType().GetField(parameter.ToString());
		if (field != null)
		{
			return ((DescriptionAttribute)field.GetCustomAttribute(typeof(DescriptionAttribute)))?.Description ?? parameter.ToString();
		}
		return parameter.ToString();
	}
}
