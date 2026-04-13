using System;
using System.Configuration;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class ConfigurationHelper : IConfigurationHelper, IService
{
	public void ToggleConfigEncryption(string exeFile, bool protectSection)
	{
		try
		{
			Configuration obj = ConfigurationManager.OpenExeConfiguration(exeFile);
			ConfigurationSection section = obj.GetSection(so95DAFNMfktfjp4Dm.An6v7kuCGg(1492));
			ConnectionStringsSection val = (ConnectionStringsSection)(object)((section is ConnectionStringsSection) ? section : null);
			if (protectSection)
			{
				if (!((ConfigurationSection)val).SectionInformation.IsProtected)
				{
					((ConfigurationSection)val).SectionInformation.ProtectSection(so95DAFNMfktfjp4Dm.An6v7kuCGg(1530));
				}
			}
			else if (((ConfigurationSection)val).SectionInformation.IsProtected)
			{
				((ConfigurationSection)val).SectionInformation.UnprotectSection();
			}
			obj.Save();
		}
		catch (Exception)
		{
		}
	}

	public string GetConnectionStringByName(string name)
	{
		string result = null;
		ConnectionStringSettings val = ConfigurationManager.ConnectionStrings[name];
		if (val != null)
		{
			result = val.ConnectionString;
		}
		return result;
	}

	public ConfigurationHelper()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
