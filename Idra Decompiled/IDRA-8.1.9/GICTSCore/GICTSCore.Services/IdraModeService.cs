using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using GICTS.Data;
using GICTSCore.Data;
using GIToolkit.Helpers;
using GIToolkit.Services;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;

namespace GICTSCore.Services;

public class IdraModeService : IIdraModeService, IService
{
	private ModeSetting l79HEGxdOI;

	private ModeSetting FeSHoGwIlp;

	private ModeSetting eNkHXGYCyI;

	private ModeSetting jkjHesdWKI;

	private bool GQiH0fJUla;

	private bool tdVHRJwr0A;

	private readonly IXmlHelper GmiHz5HKL2;

	private readonly ICircularLogService oslDwcxGQN;

	private readonly IGICTSSettingsWrapper HQhDsgVvLS;

	private readonly IProcessHelper s7cDgZCXk9;

	private GICTSSettings FPIDLfy0mj;

	public IdraModeService(IXmlHelper xmlHelper, ICircularLogService circularLogService, IGICTSSettingsWrapper gICTSSettingsWrapper, IProcessHelper processHelper)
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		l79HEGxdOI = new ModeSetting
		{
			StartAutoShotMode = true,
			StartWithGame = true,
			RunningMode = 11,
			ShowInterface = false,
			DebugLevel = 1,
			CurrentSetJsonMode = IdraMode.Play
		};
		FeSHoGwIlp = new ModeSetting
		{
			StartAutoShotMode = true,
			StartWithGame = true,
			RunningMode = 11,
			ShowInterface = false,
			DebugLevel = 1,
			CurrentSetJsonMode = IdraMode.ShotDiagnostic
		};
		eNkHXGYCyI = new ModeSetting
		{
			StartAutoShotMode = false,
			StartWithGame = false,
			RunningMode = -1,
			ShowInterface = true,
			DebugLevel = 1,
			CurrentSetJsonMode = IdraMode.TroubleShooting
		};
		jkjHesdWKI = new ModeSetting
		{
			StartAutoShotMode = true,
			StartWithGame = true,
			RunningMode = 11,
			ShowInterface = false,
			DebugLevel = 1,
			CurrentSetJsonMode = IdraMode.ShotRegistration
		};
		base._002Ector();
		GmiHz5HKL2 = xmlHelper;
		oslDwcxGQN = circularLogService;
		HQhDsgVvLS = gICTSSettingsWrapper;
		s7cDgZCXk9 = processHelper;
	}

	public async Task RefreshDocuments()
	{
		_ = 1;
		try
		{
			FPIDLfy0mj = await HQhDsgVvLS.LoadSettings(IDRAConstant.GICTSSettingsFilePath);
			FileInfo fileInfo = new FileInfo(IDRAConstant.IdraConfigurationFilePath());
			fileInfo.ReadAllTextWithBackup();
			await GmiHz5HKL2.LoadXmlDocument(fileInfo.FullName);
			oslDwcxGQN.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(22418) + IDRAConstant.IdraConfigurationFilePath() + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(5170) + Path.GetFileName(IDRAConstant.GICTSSettingsFilePath));
		}
		catch (Exception ex) when (((ex is FileNotFoundException || ex is FileLoadException) ? 1 : 0) != 0)
		{
			oslDwcxGQN.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(22464) + ex.Message + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(22516), LogLevel.Warning);
			tdVHRJwr0A = true;
			return;
		}
		catch (Exception ex2)
		{
			EventViewerLogger.LogException(ex2);
		}
		tdVHRJwr0A = false;
		GQiH0fJUla = true;
	}

	public async Task<IdraMode> GetCurrentMode()
	{
		if (!GQiH0fJUla)
		{
			await RefreshDocuments();
		}
		if (tdVHRJwr0A)
		{
			await SEYHxEY1sI(l79HEGxdOI);
			return IdraMode.Play;
		}
		ModeSetting modeSetting = await aaeHFWiM7G();
		ModeSetting modeSetting2 = modeSetting;
		IdraMode result;
		if (modeSetting2.Equals(l79HEGxdOI))
		{
			result = IdraMode.Play;
		}
		else
		{
			ModeSetting modeSetting3 = modeSetting;
			if (modeSetting3.Equals(FeSHoGwIlp))
			{
				result = IdraMode.ShotDiagnostic;
			}
			else
			{
				ModeSetting modeSetting4 = modeSetting;
				if (modeSetting4.Equals(eNkHXGYCyI))
				{
					result = IdraMode.TroubleShooting;
				}
				else
				{
					ModeSetting modeSetting5 = modeSetting;
					result = ((!modeSetting5.Equals(jkjHesdWKI)) ? IdraMode.Unknow : IdraMode.ShotRegistration);
				}
			}
		}
		return result;
	}

	public async Task<bool> SetMode(IdraMode newMode)
	{
		_ = 4;
		try
		{
			if (!GQiH0fJUla)
			{
				await RefreshDocuments();
			}
			switch (newMode)
			{
			case IdraMode.Play:
			case IdraMode.Unknow:
				await SEYHxEY1sI(l79HEGxdOI);
				break;
			case IdraMode.ShotDiagnostic:
				await SEYHxEY1sI(FeSHoGwIlp);
				break;
			case IdraMode.TroubleShooting:
				await SEYHxEY1sI(eNkHXGYCyI);
				break;
			case IdraMode.ShotRegistration:
				await SEYHxEY1sI(jkjHesdWKI);
				break;
			default:
				throw new Exception(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(22604));
			}
		}
		catch (Exception ex)
		{
			oslDwcxGQN.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(22632) + ex.Message, LogLevel.Error);
			EventViewerLogger.LogException(ex);
			return false;
		}
		return true;
	}

	public (bool, DateTime) IsIdraSavingShots()
	{
		try
		{
			DateTime dateTime = DateTime.ParseExact(GmiHz5HKL2.ReadNodeValue<string>(IDRAConstant.AutoSaveShotUntilTimestampXPath), new string[2]
			{
				YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12714),
				YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12772)
			}, CultureInfo.InvariantCulture, DateTimeStyles.None);
			return (dateTime > DateTime.Now, dateTime);
		}
		catch (Exception ex)
		{
			oslDwcxGQN.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12816) + ex.Message);
			return (false, DateTime.MinValue);
		}
	}

	private async Task<ModeSetting> aaeHFWiM7G()
	{
		if (!GQiH0fJUla)
		{
			await RefreshDocuments();
		}
		ModeSetting setting = new ModeSetting
		{
			StartAutoShotMode = FPIDLfy0mj.StartAutoShotMode,
			StartWithGame = FPIDLfy0mj.StartWithGame,
			RunningMode = FPIDLfy0mj.CamerasStartRunningMode,
			CurrentSetJsonMode = FPIDLfy0mj.CurrentSetMode,
			ShowInterface = GmiHz5HKL2.ReadNodeValue<bool>(IDRAConstant.ShowInterfaceNodeXPath),
			DebugLevel = GmiHz5HKL2.ReadNodeValue<int>(IDRAConstant.DebugLevelNodeXPath)
		};
		(bool, DateTime) tuple = IsIdraSavingShots();
		if (setting.Equals(FeSHoGwIlp) && !tuple.Item1)
		{
			ICircularLogService circularLogService = oslDwcxGQN;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(66, 1);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(22230));
			defaultInterpolatedStringHandler.AppendFormatted(tuple.Item2);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(22310));
			circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear());
			setting = l79HEGxdOI;
			await SEYHxEY1sI(setting);
		}
		oslDwcxGQN.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(22370), setting);
		return setting;
	}

	private async Task SEYHxEY1sI(ModeSetting P_0)
	{
		if (!GQiH0fJUla)
		{
			await RefreshDocuments();
		}
		oslDwcxGQN.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(22720), P_0);
		try
		{
			FPIDLfy0mj.StartAutoShotMode = P_0.StartAutoShotMode;
			FPIDLfy0mj.StartWithGame = P_0.StartWithGame;
			FPIDLfy0mj.CamerasStartRunningMode = P_0.RunningMode;
			FPIDLfy0mj.CurrentSetMode = P_0.CurrentSetJsonMode;
			await HQhDsgVvLS.SaveSettings(FPIDLfy0mj, IDRAConstant.GICTSSettingsFilePath);
		}
		catch (Exception ex)
		{
			oslDwcxGQN.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(22790) + ex.Message + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(22884), P_0);
			EventViewerLogger.LogException(ex);
		}
		if (tdVHRJwr0A)
		{
			return;
		}
		try
		{
			await GmiHz5HKL2.SetNodeValue(IDRAConstant.ShowInterfaceNodeXPath, Convert.ToSByte(P_0.ShowInterface));
			await GmiHz5HKL2.SetNodeValue(IDRAConstant.DebugLevelNodeXPath, P_0.DebugLevel);
			if (P_0.CurrentSetJsonMode == IdraMode.Play)
			{
				await GmiHz5HKL2.SetNodeValue(IDRAConstant.AutoSaveShotUntilTimestampXPath, DateTime.Now.ToString(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12714), CultureInfo.InvariantCulture));
			}
			else
			{
				await GmiHz5HKL2.SetNodeValue(IDRAConstant.AutoSaveShotUntilTimestampXPath, DateTime.Now.AddHours(24.0).ToString(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12714), CultureInfo.InvariantCulture));
			}
		}
		catch (Exception ex2)
		{
			oslDwcxGQN.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(22926) + ex2.Message + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(22884), P_0, LogLevel.Error);
			EventViewerLogger.LogException(ex2);
		}
	}

	public void CloseGame(string gameProcessName)
	{
		oslDwcxGQN.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(12934));
		try
		{
			using Process process = s7cDgZCXk9.GetProcessByName(gameProcessName);
			process?.Kill();
		}
		catch (Exception ex)
		{
			oslDwcxGQN.Log(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13008) + ex.Message, LogLevel.Error);
			EventViewerLogger.LogException(ex);
		}
	}
}
