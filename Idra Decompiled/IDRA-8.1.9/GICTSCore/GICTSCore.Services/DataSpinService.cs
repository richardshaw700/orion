using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using GICTSCore.Data;
using GIToolkit.Services;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;

namespace GICTSCore.Services;

public class DataSpinService : IDataSpinService, IService
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public ObservableCollection<string> SrlMPb8tFG;

		public _003C_003Ec__DisplayClass3_0()
		{
			fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
			base._002Ector();
		}

		internal void rTXMQW5PH4(int x)
		{
			SrlMPb8tFG.Add(x.ToString());
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public ObservableCollection<string> IIIMq620wC;

		public _003C_003Ec__DisplayClass4_0()
		{
			fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
			base._002Ector();
		}

		internal void Rp7MGeaCJh(int x)
		{
			IIIMq620wC.Add(x + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2034));
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public ObservableCollection<string> eAdM2Hu7ZZ;

		public _003C_003Ec__DisplayClass7_0()
		{
			fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
			base._002Ector();
		}

		internal void q58MmkAs0s(int x)
		{
			eAdM2Hu7ZZ.Add(x + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1886));
		}
	}

	public DataSpinService()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
	}

	public void BulkEdit(SpinVariableType variableType, int atIndex, float newFactor, ObservableCollection<ObservableCollection<float>> spinFactorsMap)
	{
		checked
		{
			switch (variableType)
			{
			case SpinVariableType.BallSpeed:
			{
				for (int k = 0; k < spinFactorsMap[atIndex].Count; k++)
				{
					spinFactorsMap[atIndex][k] = newFactor;
				}
				break;
			}
			case SpinVariableType.LaunchAngle:
			{
				for (int l = 0; l < spinFactorsMap.Count; l++)
				{
					for (int m = 0; m < spinFactorsMap[l].Count; m++)
					{
						if (m == atIndex)
						{
							spinFactorsMap[l][m] = newFactor;
						}
					}
				}
				break;
			}
			case SpinVariableType.BallPosition:
			{
				for (int i = 0; i < spinFactorsMap.Count; i++)
				{
					for (int j = 0; j < spinFactorsMap[i].Count; j++)
					{
						if (j == atIndex)
						{
							spinFactorsMap[i][j] = newFactor;
						}
					}
				}
				break;
			}
			}
		}
	}

	public List<int> GetBallSpeedRangeBracket(DataSpinConfigModel dataSpinConfigModel)
	{
		List<int> list = new List<int>();
		checked
		{
			for (int i = 0; i <= dataSpinConfigModel.NbBallSpeedFactor; i++)
			{
				list.Add(dataSpinConfigModel.BallSpeedSteps * i);
			}
			return list;
		}
	}

	public ObservableCollection<string> GetBallSpeedHeaders(DataSpinConfigModel dataSpinConfigModel)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals3.SrlMPb8tFG = new ObservableCollection<string>();
		GetBallSpeedRangeBracket(dataSpinConfigModel).ForEach(delegate(int x)
		{
			CS_0024_003C_003E8__locals3.SrlMPb8tFG.Add(x.ToString());
		});
		return CS_0024_003C_003E8__locals3.SrlMPb8tFG;
	}

	public ObservableCollection<string> GetBallPositionHeaders(DataSpinConfigModel dataSpinConfigModel)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals3.IIIMq620wC = new ObservableCollection<string>();
		GetBallPositionRangeBracket(dataSpinConfigModel).ForEach(delegate(int x)
		{
			CS_0024_003C_003E8__locals3.IIIMq620wC.Add(x + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(2034));
		});
		return CS_0024_003C_003E8__locals3.IIIMq620wC;
	}

	public List<int> GetBallPositionRangeBracket(DataSpinConfigModel dataSpinConfigModel)
	{
		List<int> list = new List<int>();
		checked
		{
			for (int i = 0; i <= dataSpinConfigModel.NbBallPositionFactor; i++)
			{
				list.Add(dataSpinConfigModel.BallPositionSteps * i);
			}
			return list;
		}
	}

	public List<int> GetLaunchAngleRangeBracket(DataSpinConfigModel dataSpinConfigModel)
	{
		List<int> list = new List<int>();
		checked
		{
			for (int i = 0; i <= dataSpinConfigModel.NbLaunchAngleFactor; i++)
			{
				list.Add(dataSpinConfigModel.LaunchAngleSteps * i);
			}
			return list;
		}
	}

	public ObservableCollection<string> GetLaunchAngleHeaders(DataSpinConfigModel dataSpinConfigModel)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals3.eAdM2Hu7ZZ = new ObservableCollection<string>();
		GetLaunchAngleRangeBracket(dataSpinConfigModel).ForEach(delegate(int x)
		{
			CS_0024_003C_003E8__locals3.eAdM2Hu7ZZ.Add(x + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(1886));
		});
		return CS_0024_003C_003E8__locals3.eAdM2Hu7ZZ;
	}

	public List<List<float>> GenerateBackSpinFactorList(DataSpinConfigModel dataSpinConfigModel)
	{
		List<List<float>> list = new List<List<float>>();
		checked
		{
			for (int i = 0; i <= dataSpinConfigModel.NbBallSpeedFactor; i++)
			{
				List<float> list2 = new List<float>();
				for (int j = 0; j <= dataSpinConfigModel.NbLaunchAngleFactor; j++)
				{
					list2.Add(dataSpinConfigModel.DefaultFactorValue);
				}
				list.Add(list2);
			}
			return list;
		}
	}

	public List<List<float>> GenerateSideSpinFactorList(DataSpinConfigModel dataSpinConfigModel)
	{
		List<List<float>> list = new List<List<float>>();
		checked
		{
			for (int i = 0; i <= dataSpinConfigModel.NbBallSpeedFactor; i++)
			{
				List<float> list2 = new List<float>();
				for (int j = 0; j <= dataSpinConfigModel.NbBallPositionFactor; j++)
				{
					list2.Add(dataSpinConfigModel.DefaultOffsetValue);
				}
				list.Add(list2);
			}
			return list;
		}
	}

	public ObservableCollection<ObservableCollection<T>> ToObservableCollection<T>(List<List<T>> list)
	{
		ObservableCollection<ObservableCollection<T>> observableCollection = new ObservableCollection<ObservableCollection<T>>();
		foreach (List<T> item2 in list)
		{
			ObservableCollection<T> item = new ObservableCollection<T>(item2);
			observableCollection.Add(item);
		}
		return observableCollection;
	}

	public List<List<T>> ToList<T>(ObservableCollection<ObservableCollection<T>> observableCollection)
	{
		List<List<T>> list = new List<List<T>>();
		foreach (ObservableCollection<T> item2 in observableCollection)
		{
			List<T> item = new List<T>(item2);
			list.Add(item);
		}
		return list;
	}
}
