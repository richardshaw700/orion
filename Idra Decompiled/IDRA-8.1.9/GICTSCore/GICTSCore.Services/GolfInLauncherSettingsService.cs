using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using GICTSCore.Data;
using JdN3qlxpK1fXeWoSKd;
using Microsoft.CSharp.RuntimeBinder;
using lKEAGvFqWp7B16kDoY;

namespace GICTSCore.Services;

public class GolfInLauncherSettingsService
{
	[CompilerGenerated]
	private static class _003C_003Eo__0
	{
		public static CallSite<Func<CallSite, object, string, object>> jFFMFKrSu0;

		public static CallSite<Func<CallSite, object, string, object>> ix3Mx8m4bo;

		public static CallSite<Func<CallSite, object, string, object>> uatMEbXFbj;

		public static CallSite<Func<CallSite, object, object>> UKZMoALiEJ;

		public static CallSite<Func<CallSite, object, string>> rWtMXywcdB;
	}

	public static string GetCustomerPIN()
	{
		string result = string.Empty;
		try
		{
			object arg = JsonSerializer.Deserialize<object>(File.ReadAllText(IDRAConstant.PathToGolfInLauncherJsonSettings, Encoding.Unicode));
			if (_003C_003Eo__0.UKZMoALiEJ == null)
			{
				_003C_003Eo__0.UKZMoALiEJ = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12520), null, typeof(GolfInLauncherSettingsService), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
			}
			Func<CallSite, object, object> target = _003C_003Eo__0.UKZMoALiEJ.Target;
			CallSite<Func<CallSite, object, object>> uKZMoALiEJ = _003C_003Eo__0.UKZMoALiEJ;
			if (_003C_003Eo__0.uatMEbXFbj == null)
			{
				_003C_003Eo__0.uatMEbXFbj = CallSite<Func<CallSite, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12540), null, typeof(GolfInLauncherSettingsService), new CSharpArgumentInfo[2]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target2 = _003C_003Eo__0.uatMEbXFbj.Target;
			CallSite<Func<CallSite, object, string, object>> uatMEbXFbj = _003C_003Eo__0.uatMEbXFbj;
			if (_003C_003Eo__0.ix3Mx8m4bo == null)
			{
				_003C_003Eo__0.ix3Mx8m4bo = CallSite<Func<CallSite, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12540), null, typeof(GolfInLauncherSettingsService), new CSharpArgumentInfo[2]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target3 = _003C_003Eo__0.ix3Mx8m4bo.Target;
			CallSite<Func<CallSite, object, string, object>> ix3Mx8m4bo = _003C_003Eo__0.ix3Mx8m4bo;
			if (_003C_003Eo__0.jFFMFKrSu0 == null)
			{
				_003C_003Eo__0.jFFMFKrSu0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12540), null, typeof(GolfInLauncherSettingsService), new CSharpArgumentInfo[2]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			result = (dynamic)target(uKZMoALiEJ, target2(uatMEbXFbj, target3(ix3Mx8m4bo, _003C_003Eo__0.jFFMFKrSu0.Target(_003C_003Eo__0.jFFMFKrSu0, arg, YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12566)), YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12592)), YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12604)));
		}
		catch
		{
		}
		return result;
	}

	public GolfInLauncherSettingsService()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
	}
}
