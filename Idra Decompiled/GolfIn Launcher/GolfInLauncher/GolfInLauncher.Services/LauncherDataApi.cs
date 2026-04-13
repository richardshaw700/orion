using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using GIToolkit.Model;
using GIToolkit.Services;
using Golfin.Dtos;
using Lmttrs0IQc7UR7Zpt6;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Services;

public class LauncherDataApi : ILauncherDataApi, IService
{
	private TimeSpan cJP3rXEYGA;

	private readonly TimeSpan e7A34wfkQ0;

	private readonly INetworkUtility Ysj3Ou4x5Z;

	private readonly ILocalCachingServices lxn39VxIOV;

	private readonly ILauncherEnv c7D3AGoKBh;

	private readonly IZoneGolfInApi Ns53Dkggx0;

	public LauncherDataApi(INetworkUtility networkUtility, ILocalCachingServices localCachingServices, ILauncherEnv launcherEnv, IZoneGolfInApi zoneGolfInApi)
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
		Ysj3Ou4x5Z = networkUtility;
		lxn39VxIOV = localCachingServices;
		c7D3AGoKBh = launcherEnv;
		Ns53Dkggx0 = zoneGolfInApi;
		cJP3rXEYGA = new TimeSpan(DateTime.Now.Ticks);
		e7A34wfkQ0 = new TimeSpan(0, 0, 30);
	}

	public async Task<ErrorCode> FetchMinimumDataForLauncher()
	{
		ErrorCode result = default(ErrorCode);
		object obj;
		int num;
		bool flag2;
		try
		{
			c7D3AGoKBh.OldDataWasUsed = false;
			c7D3AGoKBh.ApiCallWasMade = false;
			ItQ31tmHNU();
			F3D3XsWfNU();
			bool flag = await Ns53Dkggx0.IsServerOn();
			if (!flag && c7D3AGoKBh.Employees == null)
			{
				result = new ErrorCode(success: false, aL07ImwcwlxdnyfI30.olMQlwrxmw(19672));
				return result;
			}
			if (flag)
			{
				await Ns53Dkggx0.Login<UserForLoginDto>(new UserForLoginDto
				{
					Username = ConfigurationManager.AppSettings[aL07ImwcwlxdnyfI30.olMQlwrxmw(19770)],
					Password = ConfigurationManager.AppSettings[aL07ImwcwlxdnyfI30.olMQlwrxmw(19798)]
				});
			}
			ILauncherEnv launcherEnv = c7D3AGoKBh;
			launcherEnv.Employees = await GetAllEmployeesAsync();
			if (c7D3AGoKBh.ApiCallWasMade)
			{
				c7D3AGoKBh.LastSyncTime = new TimeSpan(DateTime.Now.Ticks);
			}
			if (c7D3AGoKBh.OldDataWasUsed)
			{
				flag2 = await Ns53Dkggx0.IsServerOn();
				EventViewerLogger.LogWarning(string.Format(aL07ImwcwlxdnyfI30.olMQlwrxmw(19834), flag2, Ysj3Ou4x5Z.IsNetworkAvailable(0L)));
			}
			result = new ErrorCode(success: true);
			return result;
		}
		catch (Exception ex)
		{
			obj = ex;
			num = 1;
		}
		if (num != 1)
		{
			return result;
		}
		Exception ex2 = (Exception)obj;
		flag2 = await Ns53Dkggx0.IsServerOn();
		EventViewerLogger.LogWarning(string.Format(aL07ImwcwlxdnyfI30.olMQlwrxmw(20040), flag2, Ysj3Ou4x5Z.IsNetworkAvailable(0L), ex2.Message, ex2.StackTrace));
		return new ErrorCode(success: false, ex2.Message);
	}

	private void F3D3XsWfNU()
	{
		string apiToUse = ConfigurationManager.AppSettings[aL07ImwcwlxdnyfI30.olMQlwrxmw(12734)];
		Ns53Dkggx0.SetApiToUse(apiToUse);
	}

	public async Task<List<UserForManagementDto>> GetAllEmployeesAsync()
	{
		_ = 3;
		try
		{
			string cachedKey = aL07ImwcwlxdnyfI30.olMQlwrxmw(20290);
			if (lxn39VxIOV.Contains(cachedKey))
			{
				SyncObject obj = lxn39VxIOV.Get(cachedKey);
				bool flag = Ysj3Ou4x5Z.IsNetworkAvailable(0L);
				if (obj == null && !flag)
				{
					throw new Exception(aL07ImwcwlxdnyfI30.olMQlwrxmw(20318));
				}
				if (cJP3rXEYGA.Subtract(c7D3AGoKBh.LastSyncTime) > e7A34wfkQ0)
				{
					bool flag2 = !flag;
					if (!flag2)
					{
						flag2 = !(await Ns53Dkggx0.IsServerOn());
					}
					if (flag2)
					{
						c7D3AGoKBh.OldDataWasUsed = true;
						return lxn39VxIOV.TryDeserialize(obj) as List<UserForManagementDto>;
					}
					return await StoreEmployees(cachedKey);
				}
				if (obj == null)
				{
					return await StoreEmployees(cachedKey);
				}
				return lxn39VxIOV.TryDeserialize(obj) as List<UserForManagementDto>;
			}
			return await StoreEmployees(cachedKey);
		}
		catch (Exception ex)
		{
			throw new Exception(aL07ImwcwlxdnyfI30.olMQlwrxmw(20396) + ex.Message);
		}
	}

	public async Task<List<UserForManagementDto>> StoreEmployees(string cachedKey)
	{
		List<UserForManagementDto> list = await GetCloudEmployees();
		if (list != null)
		{
			lxn39VxIOV.ClearCache(cachedKey);
			lxn39VxIOV.Set(cachedKey, list);
			c7D3AGoKBh.ApiCallWasMade = true;
		}
		SyncObject obj = lxn39VxIOV.Get(cachedKey);
		return lxn39VxIOV.TryDeserialize(obj) as List<UserForManagementDto>;
	}

	public async Task<List<UserForManagementDto>> GetCloudEmployees()
	{
		try
		{
			List<UserForManagementDto> list = await Ns53Dkggx0.GetAllEmployees();
			if (list == null)
			{
				return null;
			}
			return list;
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
			return null;
		}
	}

	private void ItQ31tmHNU()
	{
		cJP3rXEYGA = new TimeSpan(DateTime.Now.Ticks);
	}
}
