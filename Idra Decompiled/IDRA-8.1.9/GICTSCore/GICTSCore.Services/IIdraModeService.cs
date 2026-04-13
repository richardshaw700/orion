using System;
using System.Threading.Tasks;
using GICTSCore.Data;
using GIToolkit.Services;

namespace GICTSCore.Services;

public interface IIdraModeService : IService
{
	Task<IdraMode> GetCurrentMode();

	Task RefreshDocuments();

	Task<bool> SetMode(IdraMode newMode);

	void CloseGame(string gameProcessName);

	(bool, DateTime) IsIdraSavingShots();
}
