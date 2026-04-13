using System;
using System.Collections.Generic;
using GIToolkit.Services;
using Golfin.Dtos;

namespace GolfInLauncher.Services;

public interface ILauncherEnv : IService
{
	bool ApiCallWasMade { get; set; }

	List<UserForManagementDto> Employees { get; set; }

	TimeSpan LastSyncTime { get; set; }

	bool OldDataWasUsed { get; set; }
}
