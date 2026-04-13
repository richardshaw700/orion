using System.Collections.Generic;
using System.Collections.ObjectModel;
using GICTSCore.Data;
using GIToolkit.Services;

namespace GICTSCore.Services;

public interface IDataSpinService : IService
{
	List<List<float>> GenerateBackSpinFactorList(DataSpinConfigModel dataSpinConfigModel);

	List<List<float>> GenerateSideSpinFactorList(DataSpinConfigModel dataSpinConfigModel);

	ObservableCollection<ObservableCollection<T>> ToObservableCollection<T>(List<List<T>> list);

	List<List<T>> ToList<T>(ObservableCollection<ObservableCollection<T>> observableCollection);

	ObservableCollection<string> GetBallSpeedHeaders(DataSpinConfigModel dataSpinConfigModel);

	ObservableCollection<string> GetLaunchAngleHeaders(DataSpinConfigModel dataSpinConfigModel);

	ObservableCollection<string> GetBallPositionHeaders(DataSpinConfigModel dataSpinConfigModel);

	void BulkEdit(SpinVariableType variableType, int atIndex, float newFactor, ObservableCollection<ObservableCollection<float>> spinFactorsMap);

	List<int> GetBallSpeedRangeBracket(DataSpinConfigModel dataSpinConfigModel);

	List<int> GetLaunchAngleRangeBracket(DataSpinConfigModel dataSpinConfigModel);

	List<int> GetBallPositionRangeBracket(DataSpinConfigModel dataSpinConfigModel);
}
