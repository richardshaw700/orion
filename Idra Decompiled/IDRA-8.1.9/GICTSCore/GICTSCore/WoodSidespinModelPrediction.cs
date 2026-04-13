using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using JdN3qlxpK1fXeWoSKd;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;
using Plotly.NET;
using Plotly.NET.LayoutObjects;
using lKEAGvFqWp7B16kDoY;

namespace GICTSCore;

public class WoodSidespinModelPrediction
{
	public class ModelInput
	{
		[CompilerGenerated]
		private float wL2Mhcfx09;

		[CompilerGenerated]
		private float ITXMt6odxM;

		[CompilerGenerated]
		private float vkgMrqgqDN;

		[CompilerGenerated]
		private float EIoMyvRQGn;

		[CompilerGenerated]
		private float mU9M9ueisp;

		[ColumnName("BallSpeed")]
		[LoadColumn(0)]
		public float BallSpeed
		{
			[CompilerGenerated]
			get
			{
				return wL2Mhcfx09;
			}
			[CompilerGenerated]
			set
			{
				wL2Mhcfx09 = value;
			}
		}

		[LoadColumn(1)]
		[ColumnName("LaunchAngle")]
		public float LaunchAngle
		{
			[CompilerGenerated]
			get
			{
				return ITXMt6odxM;
			}
			[CompilerGenerated]
			set
			{
				ITXMt6odxM = value;
			}
		}

		[LoadColumn(2)]
		[ColumnName("ClubFace")]
		public float ClubFace
		{
			[CompilerGenerated]
			get
			{
				return vkgMrqgqDN;
			}
			[CompilerGenerated]
			set
			{
				vkgMrqgqDN = value;
			}
		}

		[ColumnName("ClubPath")]
		[LoadColumn(3)]
		public float ClubPath
		{
			[CompilerGenerated]
			get
			{
				return EIoMyvRQGn;
			}
			[CompilerGenerated]
			set
			{
				EIoMyvRQGn = value;
			}
		}

		[ColumnName("SideSpin")]
		[LoadColumn(5)]
		public float SideSpin
		{
			[CompilerGenerated]
			get
			{
				return mU9M9ueisp;
			}
			[CompilerGenerated]
			set
			{
				mU9M9ueisp = value;
			}
		}

		public ModelInput()
		{
			fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
			base._002Ector();
		}
	}

	public class ModelOutput
	{
		[CompilerGenerated]
		private float tQOMADuYAC;

		[CompilerGenerated]
		private float qZuMjejQkE;

		[CompilerGenerated]
		private float uGWM6v0DbQ;

		[CompilerGenerated]
		private float uJeM1iGAnY;

		[CompilerGenerated]
		private float pBjMk3ubpj;

		[CompilerGenerated]
		private float[] UYeMdLB6kJ;

		[CompilerGenerated]
		private float iUwMNfGmMp;

		[ColumnName("BallSpeed")]
		public float BallSpeed
		{
			[CompilerGenerated]
			get
			{
				return tQOMADuYAC;
			}
			[CompilerGenerated]
			set
			{
				tQOMADuYAC = value;
			}
		}

		[ColumnName("LaunchAngle")]
		public float LaunchAngle
		{
			[CompilerGenerated]
			get
			{
				return qZuMjejQkE;
			}
			[CompilerGenerated]
			set
			{
				qZuMjejQkE = value;
			}
		}

		[ColumnName("ClubFace")]
		public float ClubFace
		{
			[CompilerGenerated]
			get
			{
				return uGWM6v0DbQ;
			}
			[CompilerGenerated]
			set
			{
				uGWM6v0DbQ = value;
			}
		}

		[ColumnName("ClubPath")]
		public float ClubPath
		{
			[CompilerGenerated]
			get
			{
				return uJeM1iGAnY;
			}
			[CompilerGenerated]
			set
			{
				uJeM1iGAnY = value;
			}
		}

		[ColumnName("SideSpin")]
		public float SideSpin
		{
			[CompilerGenerated]
			get
			{
				return pBjMk3ubpj;
			}
			[CompilerGenerated]
			set
			{
				pBjMk3ubpj = value;
			}
		}

		[ColumnName("Features")]
		public float[] Features
		{
			[CompilerGenerated]
			get
			{
				return UYeMdLB6kJ;
			}
			[CompilerGenerated]
			set
			{
				UYeMdLB6kJ = value;
			}
		}

		[ColumnName("Score")]
		public float Score
		{
			[CompilerGenerated]
			get
			{
				return iUwMNfGmMp;
			}
			[CompilerGenerated]
			set
			{
				iUwMNfGmMp = value;
			}
		}

		public ModelOutput()
		{
			fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
			base._002Ector();
		}
	}

	private static string DmSv1LsUPO;

	public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine;

	public const string RetrainFilePath = "C:\\Users\\AlexandreFortin\\Golf In\\Intranet - Documents\\Informatique\\Development\\Spin automatic shot\\WOOD\\Compile\\wood_2023-08-22_output.csv";

	public const char RetrainSeparatorChar = ',';

	public const bool RetrainHasHeader = true;

	private static PredictionEngine<ModelInput, ModelOutput> HjCv69HAVa()
	{
		MLContext mLContext = new MLContext();
		DataViewSchema inputSchema;
		ITransformer transformer = mLContext.Model.Load(DmSv1LsUPO, out inputSchema);
		return mLContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(transformer);
	}

	public static ModelOutput Predict(ModelInput input)
	{
		return PredictEngine.Value.Predict(input);
	}

	public static List<Tuple<string, double>> CalculatePFI(MLContext mlContext, IDataView trainData, ITransformer model, string labelColumnName)
	{
		IDataView data = model.Transform(trainData);
		var orderedEnumerable = from kvp in mlContext.Regression.PermutationFeatureImportance(model, data, labelColumnName)
			select new
			{
				kvp.Key,
				kvp.Value.RSquared
			} into myFeatures
			orderby Math.Abs(myFeatures.RSquared.Mean) descending
			select myFeatures;
		List<Tuple<string, double>> list = new List<Tuple<string, double>>();
		foreach (var item2 in orderedEnumerable)
		{
			double item = Math.Abs(item2.RSquared.Mean);
			list.Add(new Tuple<string, double>(item2.Key, item));
		}
		return list;
	}

	public static void PlotRSquaredValues(IDataView trainData, ITransformer model, string labelColumnName, string folderPath)
	{
		int count = 1000;
		IDataView data = model.Transform(trainData);
		IEnumerable<float> enumerable = data.GetColumn<float>(labelColumnName).Take(count);
		IEnumerable<float> enumerable2 = data.GetColumn<float>(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7688)).Take(count);
		Layout layout = Layout.init<IConvertible>(Title.init(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7702)), null, null, null, null, null, null, null, null, null, null, Color.fromString(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7734)));
		LinearAxis xAxis = LinearAxis.init<IConvertible, IConvertible, IConvertible, IConvertible, IConvertible, IConvertible>(null, null, Title.init(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7752)), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, ZeroLineColor: Color.fromString(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7778)), GridColor: Color.fromString(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7778)), GridDash: null, GridWidth: null, ZeroLine: null, ZeroLineWidth: 2.0);
		LinearAxis yAxis = LinearAxis.init<IConvertible, IConvertible, IConvertible, IConvertible, IConvertible, IConvertible>(null, null, Title.init(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7792)), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, ZeroLineColor: Color.fromString(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7778)), GridColor: Color.fromString(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7778)), GridDash: null, GridWidth: null, ZeroLine: null, ZeroLineWidth: 2.0);
		float num = Math.Max(enumerable.Max(), enumerable2.Max());
		float[] x = new float[2] { 0f, num };
		float[] y = new float[2] { 0f, num };
		GenericChart.GenericChart genericChart = Chart2D.Chart.Scatter<float, float, string>(enumerable, enumerable2, StyleParam.Mode.Markers, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, false, true).WithLayout(layout).WithXAxis(xAxis)
			.WithYAxis(yAxis);
		GenericChart.GenericChart genericChart2 = Chart2D.Chart.Line<float, float, string>(x, y, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, false, true).WithLayout(layout).WithLine(Line.init(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1.5));
		GenericChart.GenericChart genericChart3 = Chart.Combine(new GenericChart.GenericChart[2] { genericChart, genericChart2 });
		string path = folderPath + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7828);
		genericChart3.SaveHtml(path);
	}

	public static void Train(string outputModelPath, string inputDataFilePath = "C:\\Users\\AlexandreFortin\\Golf In\\Intranet - Documents\\Informatique\\Development\\Spin automatic shot\\WOOD\\Compile\\wood_2023-08-22_output.csv", char separatorChar = ',', bool hasHeader = true)
	{
		MLContext mlContext = new MLContext();
		IDataView dataView = LoadIDataViewFromFile(mlContext, inputDataFilePath, separatorChar, hasHeader);
		ITransformer model = RetrainModel(mlContext, dataView);
		SaveModel(mlContext, model, dataView, outputModelPath);
	}

	public static IDataView LoadIDataViewFromFile(MLContext mlContext, string inputDataFilePath, char separatorChar, bool hasHeader)
	{
		return mlContext.Data.LoadFromTextFile<ModelInput>(inputDataFilePath, separatorChar, hasHeader);
	}

	public static void SaveModel(MLContext mlContext, ITransformer model, IDataView data, string modelSavePath)
	{
		DataViewSchema schema = data.Schema;
		using FileStream stream = File.Create(modelSavePath);
		mlContext.Model.Save(model, schema, stream);
	}

	public static ITransformer RetrainModel(MLContext mlContext, IDataView trainData)
	{
		return BuildPipeline(mlContext).Fit(trainData);
	}

	public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
	{
		return mlContext.Transforms.ReplaceMissingValues(new InputOutputColumnPair[4]
		{
			new InputOutputColumnPair(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7874), YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7874)),
			new InputOutputColumnPair(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7896), YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7896)),
			new InputOutputColumnPair(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7922), YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7922)),
			new InputOutputColumnPair(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7942), YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7942))
		}).Append(mlContext.Transforms.Concatenate(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7962), YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7874), YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7896), YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7922), YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7942))).Append(mlContext.Regression.Trainers.FastTree(new FastTreeRegressionTrainer.Options
		{
			NumberOfLeaves = 32,
			MinimumExampleCountPerLeaf = 2,
			NumberOfTrees = 82,
			MaximumBinCountPerFeature = 418,
			FeatureFraction = 0.99999999,
			LearningRate = 0.134223765022089,
			LabelColumnName = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8078),
			FeatureColumnName = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7962),
			DiskTranspose = false
		}));
	}

	public WoodSidespinModelPrediction()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
	}

	static WoodSidespinModelPrediction()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		DmSv1LsUPO = Path.GetFullPath(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8250));
		PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => HjCv69HAVa(), isThreadSafe: true);
	}
}
