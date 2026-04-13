using System;
using System.Reflection;
using GYFmeytn3uk9KnUELA;
using RIrlNToRdPZ6Uy0SYo;

namespace fjlBqtse8BiwHQxML8;

internal class FO9NpG88hpH6kMxYAL
{
	internal delegate void TvMSUYvjvOoRnMO4Fr(object o);

	internal static Module x2sBsGWKiH;

	internal static void AZ5WGHkkyhsBl(int typemdt)
	{
		Type type = x2sBsGWKiH.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)x2sBsGWKiH.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public FO9NpG88hpH6kMxYAL()
	{
		l26t3npZsnUe1qbsCU.vf2WGHkzGx201();
		base._002Ector();
	}

	static FO9NpG88hpH6kMxYAL()
	{
		G2089JiDB7k4x1yr7J.kLjw4iIsCLsZtxc4lksN0j();
		l26t3npZsnUe1qbsCU.vf2WGHkzGx201();
		x2sBsGWKiH = typeof(FO9NpG88hpH6kMxYAL).Assembly.ManifestModule;
	}
}
