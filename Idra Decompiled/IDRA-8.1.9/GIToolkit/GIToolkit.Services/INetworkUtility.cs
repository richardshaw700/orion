using System;

namespace GIToolkit.Services;

public interface INetworkUtility
{
	event Action<bool> OnConnnectionStatusChanged;

	bool IsNetworkAvailable(long minimumSpeed);

	void StartNetworkStatusTask();
}
