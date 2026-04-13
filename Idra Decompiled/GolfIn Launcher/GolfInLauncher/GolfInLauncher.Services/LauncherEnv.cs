using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GIToolkit.Services;
using Golfin.Dtos;
using Lmttrs0IQc7UR7Zpt6;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Services;

[Serializable]
public class LauncherEnv : ILauncherEnv, IService
{
	[CompilerGenerated]
	private bool WPP3aEefyd;

	[CompilerGenerated]
	private TimeSpan GaU3udP0FD;

	[CompilerGenerated]
	private bool xOX3KPxoRP;

	[CompilerGenerated]
	private List<UserForManagementDto> rsu32DDj2O;

	public bool OldDataWasUsed
	{
		[CompilerGenerated]
		get
		{
			return WPP3aEefyd;
		}
		[CompilerGenerated]
		set
		{
			WPP3aEefyd = value;
		}
	}

	public TimeSpan LastSyncTime
	{
		[CompilerGenerated]
		get
		{
			return GaU3udP0FD;
		}
		[CompilerGenerated]
		set
		{
			GaU3udP0FD = value;
		}
	}

	public bool ApiCallWasMade
	{
		[CompilerGenerated]
		get
		{
			return xOX3KPxoRP;
		}
		[CompilerGenerated]
		set
		{
			xOX3KPxoRP = value;
		}
	}

	public List<UserForManagementDto> Employees
	{
		[CompilerGenerated]
		get
		{
			return rsu32DDj2O;
		}
		[CompilerGenerated]
		set
		{
			rsu32DDj2O = value;
		}
	}

	public static string LauncherDataKey => aL07ImwcwlxdnyfI30.olMQlwrxmw(12750);

	public LauncherEnv()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
	}
}
