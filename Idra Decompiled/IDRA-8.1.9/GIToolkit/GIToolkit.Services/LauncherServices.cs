using System;
using GIToolkit.Models;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class LauncherServices : ILauncherServices
{
	private readonly IIOHelper QZW69FlAYO;

	private readonly IJsonHelper pAY6hmHbDb;

	public LauncherServices(IIOHelper iioHelper, IJsonHelper jsonHelper)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		QZW69FlAYO = iioHelper;
		pAY6hmHbDb = jsonHelper;
	}

	public LauncherCardSettings GetLauncherCardSettingsToObject(string pathToJsonFile)
	{
		if (!QZW69FlAYO.FileExists(pathToJsonFile))
		{
			return null;
		}
		string content = QZW69FlAYO.FileReadAllText(pathToJsonFile);
		return pAY6hmHbDb.DeserializeObject<LauncherCardSettings>(content);
	}

	public string GetLauncherCardSettings(string pathToJsonFile)
	{
		if (!QZW69FlAYO.FileExists(pathToJsonFile))
		{
			return null;
		}
		return QZW69FlAYO.FileReadAllText(pathToJsonFile);
	}

	public bool SetLauncherCardSettings(string pathToFolder, string pathToFile, string newLauncherCard)
	{
		try
		{
			if (QZW69FlAYO.DirectoryExist(pathToFolder))
			{
				QZW69FlAYO.FileWriteAllText(pathToFile, newLauncherCard);
				return true;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}
}
