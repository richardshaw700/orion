using System;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using JdN3qlxpK1fXeWoSKd;
using NvAPIWrapper.GPU;
using NvAPIWrapper.Native.GPU;
using lKEAGvFqWp7B16kDoY;

namespace GICTSCore.Services;

public class MetricService
{
	public static long GetMemoryUsage(Process process)
	{
		if (process == null)
		{
			return -1L;
		}
		return process.PrivateMemorySize64 / 1048576;
	}

	public static long GetWorkingSetMemory(Process process)
	{
		if (process == null)
		{
			return -1L;
		}
		return process.WorkingSet64 / 1048576;
	}

	public static ulong GetTotalRAMMemory()
	{
		using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13114)))
		{
			using ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator();
			if (managementObjectEnumerator.MoveNext())
			{
				return Convert.ToUInt64(managementObjectEnumerator.Current[YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13222)]) / 1048576;
			}
		}
		return 0uL;
	}

	public static string GetRAMInfo(string processName = "")
	{
		string result = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13264);
		if (string.IsNullOrWhiteSpace(processName) && Process.GetCurrentProcess() == null)
		{
			return result;
		}
		Process process = (string.IsNullOrWhiteSpace(processName) ? Process.GetCurrentProcess() : Process.GetProcessesByName(processName).FirstOrDefault());
		if (process == null)
		{
			return result;
		}
		ulong totalRAMMemory = GetTotalRAMMemory();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(80, 5);
		defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13312));
		defaultInterpolatedStringHandler.AppendFormatted(process.ProcessName);
		defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13334));
		defaultInterpolatedStringHandler.AppendFormatted(GetWorkingSetMemory(process));
		defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13410));
		defaultInterpolatedStringHandler.AppendFormatted(totalRAMMemory);
		defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13426));
		defaultInterpolatedStringHandler.AppendFormatted(GetMemoryUsage(process));
		defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13410));
		defaultInterpolatedStringHandler.AppendFormatted(totalRAMMemory);
		defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13470));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetVRAMNividiaInfo()
	{
		string result = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13480);
		PhysicalGPU[] physicalGPUs = PhysicalGPU.GetPhysicalGPUs();
		foreach (PhysicalGPU physicalGPU in physicalGPUs)
		{
			if (physicalGPU.GPUType == GPUType.Discrete)
			{
				ulong num = physicalGPU.MemoryInformation.DedicatedVideoMemoryInkB;
				ulong num2 = checked(num - physicalGPU.MemoryInformation.CurrentAvailableDedicatedVideoMemoryInkB);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 4);
				defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13522));
				defaultInterpolatedStringHandler.AppendFormatted(physicalGPU.FullName);
				defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13536));
				defaultInterpolatedStringHandler.AppendFormatted(num2 / 1024);
				defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13410));
				defaultInterpolatedStringHandler.AppendFormatted(num / 1024);
				defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13558));
				defaultInterpolatedStringHandler.AppendFormatted(physicalGPU.MemoryInformation.CurrentAvailableDedicatedVideoMemoryInkB / 1024);
				defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13470));
				result = defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}
		return result;
	}

	public MetricService()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
	}
}
