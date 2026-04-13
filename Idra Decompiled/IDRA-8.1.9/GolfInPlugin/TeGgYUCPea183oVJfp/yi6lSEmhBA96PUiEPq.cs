using System;
using System.Reflection;
using zLGfTg8qMbPmqnv69o;

namespace TeGgYUCPea183oVJfp;

internal class yi6lSEmhBA96PUiEPq
{
	internal delegate void xK26Qt5OgnkBKZII2M(object o);

	internal static Module EIjKDyWkJ9;

	internal static void QIVXwo88j3GTZ(int typemdt)
	{
		Type type = EIjKDyWkJ9.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)EIjKDyWkJ9.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public yi6lSEmhBA96PUiEPq()
	{
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		base._002Ector();
	}

	static yi6lSEmhBA96PUiEPq()
	{
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		EIjKDyWkJ9 = typeof(yi6lSEmhBA96PUiEPq).Assembly.ManifestModule;
	}
}
