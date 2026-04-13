#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using GICTS.Data;
using GICTSCore.Data;
using GIToolkit.Services;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;

namespace GICTSCore.Services;

public class SpaceCleanUpService : ISpaceCleanUpService, IService
{
	public SpaceCleanUpService()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
	}

	public void KeepFreeSpace(int numberOfGB, int minimumNumberOfShotsToKeep)
	{
		DirectoryInfo path = new DirectoryInfo(IDRAConstant.GICTSSamplesShotsFolder);
		FreeUpSpace(path, numberOfGB, minimumNumberOfShotsToKeep);
		path = new DirectoryInfo(IDRAConstant.GICTSSamplesResultsFolder);
		FreeUpSpace(path, numberOfGB, minimumNumberOfShotsToKeep);
		path = new DirectoryInfo(IDRAConstant.GICTSSamplesGroundTruthFolder);
		FreeUpSpace(path, numberOfGB, minimumNumberOfShotsToKeep);
	}

	public void FreeUpSpace(DirectoryInfo path, int numberOfGB, int minimumNumberOfShotsToKeep)
	{
		DriveInfo driveInfo = new DriveInfo(Path.GetPathRoot(path.FullName));
		int numberOfShots = GetNumberOfShots(path.FullName);
		bool flag = driveInfo.AvailableFreeSpace / 1024 / 1024 / 1024 < numberOfGB && numberOfShots > minimumNumberOfShotsToKeep;
		while (flag)
		{
			List<string> firstShotDirectories = GetFirstShotDirectories(path);
			if (firstShotDirectories.Count > 0)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(firstShotDirectories.First());
				Trace.TraceInformation(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(13596) + directoryInfo.Name);
			}
			if (firstShotDirectories.Count > 0)
			{
				firstShotDirectories.ForEach(delegate(string x)
				{
					Trace.TraceInformation(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(23034) + x);
					Directory.Delete(x, recursive: true);
				});
			}
			numberOfShots = GetNumberOfShots(path.FullName);
			flag = driveInfo.AvailableFreeSpace / 1024 / 1024 / 1024 < numberOfGB && numberOfShots > minimumNumberOfShotsToKeep;
		}
	}

	public int GetNumberOfShots(string pathToMonitor)
	{
		return Directory.GetDirectories(pathToMonitor).ToList().Count;
	}

	public DirectoryInfo GetLastShotDirectory(string defaultPath)
	{
		return new DirectoryInfo(Directory.GetDirectories(defaultPath).ToList().OrderByDescending(delegate(string y)
		{
			string text = y.Split(Path.DirectorySeparatorChar).Last();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 5);
			defaultInterpolatedStringHandler.AppendFormatted(text.Split('_')[1]);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(23082));
			defaultInterpolatedStringHandler.AppendFormatted(text.Split('_')[2]);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(23082));
			defaultInterpolatedStringHandler.AppendFormatted(text.Split('_')[3]);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(612));
			defaultInterpolatedStringHandler.AppendFormatted(text.Split('_')[4]);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(23088));
			defaultInterpolatedStringHandler.AppendFormatted(text.Split('_')[5]);
			return DateTime.Parse(defaultInterpolatedStringHandler.ToStringAndClear(), CultureInfo.InvariantCulture);
		})
			.FirstOrDefault());
	}

	public string GetLastShotName(string defaultPath)
	{
		return GetLastShotDirectory(defaultPath).Name;
	}

	public DirectoryInfo GetFirstShotDirectory(string defaultPath)
	{
		List<string> list = Directory.GetDirectories(defaultPath).ToList();
		if (list.Count == 0)
		{
			return null;
		}
		return new DirectoryInfo(list.OrderBy(delegate(string y)
		{
			string text = y.Split(Path.DirectorySeparatorChar).Last();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 5);
			defaultInterpolatedStringHandler.AppendFormatted(text.Split('_')[1]);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(23082));
			defaultInterpolatedStringHandler.AppendFormatted(text.Split('_')[2]);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(23082));
			defaultInterpolatedStringHandler.AppendFormatted(text.Split('_')[3]);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(612));
			defaultInterpolatedStringHandler.AppendFormatted(text.Split('_')[4]);
			defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(23088));
			defaultInterpolatedStringHandler.AppendFormatted(text.Split('_')[5]);
			return DateTime.Parse(defaultInterpolatedStringHandler.ToStringAndClear(), CultureInfo.InvariantCulture);
		}).FirstOrDefault());
	}

	public List<string> GetFirstShotDirectories(DirectoryInfo pathDir)
	{
		DirectoryInfo firstShotDirectory = GetFirstShotDirectory(pathDir.FullName);
		if (firstShotDirectory == null)
		{
			return new List<string>();
		}
		return Directory.GetDirectories(pathDir.Parent.FullName, firstShotDirectory.Name, SearchOption.AllDirectories).ToList();
	}

	public void DeleteShot(CTSShotData newShot)
	{
		try
		{
			Directory.GetParent(newShot.FullFilename).Parent.Parent.GetDirectories(newShot.ShotName, SearchOption.AllDirectories).ToList().ForEach(delegate(DirectoryInfo x)
			{
				Trace.TraceInformation(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(23034) + x.FullName);
				x.Delete(recursive: true);
			});
		}
		catch
		{
		}
	}
}
