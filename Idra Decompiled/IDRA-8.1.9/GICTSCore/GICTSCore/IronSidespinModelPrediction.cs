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

public class IronSidespinModelPrediction
{
	public class ModelInput
	{
		[CompilerGenerated]
		private float xpKCFrh7G4;

		[CompilerGenerated]
		private float fuJCx4km51;

		[CompilerGenerated]
		private float kocCE5enxe;

		[CompilerGenerated]
		private float RhjCohVGYR;

		[CompilerGenerated]
		private float AymCXxSIBA;

		[ColumnName("BallSpeed")]
		[LoadColumn(0)]
		public float BallSpeed
		{
			[CompilerGenerated]
			get
			{
				return xpKCFrh7G4;
			}
			[CompilerGenerated]
			set
			{
				xpKCFrh7G4 = value;
			}
		}

		[ColumnName("LaunchAngle")]
		[LoadColumn(1)]
		public float LaunchAngle
		{
			[CompilerGenerated]
			get
			{
				return fuJCx4km51;
			}
			[CompilerGenerated]
			set
			{
				fuJCx4km51 = value;
			}
		}

		[ColumnName("ClubFace")]
		[LoadColumn(2)]
		public float ClubFace
		{
			[CompilerGenerated]
			get
			{
				return kocCE5enxe;
			}
			[CompilerGenerated]
			set
			{
				kocCE5enxe = value;
			}
		}

		[ColumnName("ClubPath")]
		[LoadColumn(3)]
		public float ClubPath
		{
			[CompilerGenerated]
			get
			{
				return RhjCohVGYR;
			}
			[CompilerGenerated]
			set
			{
				RhjCohVGYR = value;
			}
		}

		[ColumnName("SideSpin")]
		[LoadColumn(5)]
		public float SideSpin
		{
			[CompilerGenerated]
			get
			{
				return AymCXxSIBA;
			}
			[CompilerGenerated]
			set
			{
				AymCXxSIBA = value;
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
		private float vKQCeQ8Bf2;

		[CompilerGenerated]
		private float fhiC0RwKik;

		[CompilerGenerated]
		private float IVMCRLf925;

		[CompilerGenerated]
		private float F00CzLikXJ;

		[CompilerGenerated]
		private float vraMwqZkHI;

		[CompilerGenerated]
		private float[] bejMs6rBHR;

		[CompilerGenerated]
		private float SbMMgUJWPs;

		[ColumnName("BallSpeed")]
		public float BallSpeed
		{
			[CompilerGenerated]
			get
			{
				return vKQCeQ8Bf2;
			}
			[CompilerGenerated]
			set
			{
				vKQCeQ8Bf2 = value;
			}
		}

		[ColumnName("LaunchAngle")]
		public float LaunchAngle
		{
			[CompilerGenerated]
			get
			{
				return fhiC0RwKik;
			}
			[CompilerGenerated]
			set
			{
				fhiC0RwKik = value;
			}
		}

		[ColumnName("ClubFace")]
		public float ClubFace
		{
			[CompilerGenerated]
			get
			{
				return IVMCRLf925;
			}
			[CompilerGenerated]
			set
			{
				IVMCRLf925 = value;
			}
		}

		[ColumnName("ClubPath")]
		public float ClubPath
		{
			[CompilerGenerated]
			get
			{
				return F00CzLikXJ;
			}
			[CompilerGenerated]
			set
			{
				F00CzLikXJ = value;
			}
		}

		[ColumnName("SideSpin")]
		public float SideSpin
		{
			[CompilerGenerated]
			get
			{
				return vraMwqZkHI;
			}
			[CompilerGenerated]
			set
			{
				vraMwqZkHI = value;
			}
		}

		[ColumnName("Features")]
		public float[] Features
		{
			[CompilerGenerated]
			get
			{
				return bejMs6rBHR;
			}
			[CompilerGenerated]
			set
			{
				bejMs6rBHR = value;
			}
		}

		[ColumnName("Score")]
		public float Score
		{
			[CompilerGenerated]
			get
			{
				return SbMMgUJWPs;
			}
			[CompilerGenerated]
			set
			{
				SbMMgUJWPs = value;
			}
		}

		public ModelOutput()
		{
			fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
			base._002Ector();
		}
	}

	private static string op2v9yyawI;

	public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine;

	public const string RetrainFilePath = "C:\\Users\\AlexandreFortin\\Golf In\\Intranet - Documents\\Informatique\\Development\\Spin automatic shot\\IRON\\Compile\\iron_181k_shots.csv";

	public const char RetrainSeparatorChar = ',';

	public const bool RetrainHasHeader = true;

	private static PredictionEngine<ModelInput, ModelOutput> BNYvyP8Hq6()
	{
		MLContext mLContext = new MLContext();
		DataViewSchema inputSchema;
		ITransformer transformer = mLContext.Model.Load(op2v9yyawI, out inputSchema);
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

	public static void Train(string outputModelPath, string inputDataFilePath = "C:\\Users\\AlexandreFortin\\Golf In\\Intranet - Documents\\Informatique\\Development\\Spin automatic shot\\IRON\\Compile\\iron_181k_shots.csv", char separatorChar = ',', bool hasHeader = true)
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
			NumberOfLeaves = 931,
			MinimumExampleCountPerLeaf = 64,
			NumberOfTrees = 736,
			MaximumBinCountPerFeature = 62,
			FeatureFraction = 0.99999999,
			LearningRate = 0.0177458105229472,
			LabelColumnName = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8078),
			FeatureColumnName = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7962),
			DiskTranspose = false
		}));
	}

	public IronSidespinModelPrediction()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
	}

	static IronSidespinModelPrediction()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		op2v9yyawI = Path.GetFullPath(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(8098));
		PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => BNYvyP8Hq6(), isThreadSafe: true);
	}
}
