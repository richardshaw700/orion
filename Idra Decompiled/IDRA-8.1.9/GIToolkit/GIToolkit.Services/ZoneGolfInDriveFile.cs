using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Microsoft.Graph;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class ZoneGolfInDriveFile : IZoneGolfInDriveFile
{
	[CompilerGenerated]
	private bool qwhoPHlO0p;

	[CompilerGenerated]
	private bool xRNoz1n8qV;

	[CompilerGenerated]
	private SoftwareType af7tdvlNaO;

	[CompilerGenerated]
	private string S4mtiC5pcs;

	[CompilerGenerated]
	private long UOntudCjVT;

	[CompilerGenerated]
	private string RqntVKrjji;

	[CompilerGenerated]
	private string JCNtRVQIgK;

	public bool UseThisVersionInProduction
	{
		[CompilerGenerated]
		get
		{
			return qwhoPHlO0p;
		}
		[CompilerGenerated]
		private set
		{
			qwhoPHlO0p = value;
		}
	}

	public bool UseLatestVersion
	{
		[CompilerGenerated]
		get
		{
			return xRNoz1n8qV;
		}
		[CompilerGenerated]
		private set
		{
			xRNoz1n8qV = value;
		}
	}

	public SoftwareType SoftwareType
	{
		[CompilerGenerated]
		get
		{
			return af7tdvlNaO;
		}
		[CompilerGenerated]
		private set
		{
			af7tdvlNaO = value;
		}
	}

	public string FileName
	{
		[CompilerGenerated]
		get
		{
			return S4mtiC5pcs;
		}
		[CompilerGenerated]
		private set
		{
			S4mtiC5pcs = value;
		}
	}

	public long FileSize
	{
		[CompilerGenerated]
		get
		{
			return UOntudCjVT;
		}
		[CompilerGenerated]
		private set
		{
			UOntudCjVT = value;
		}
	}

	public string DownloadUrl
	{
		[CompilerGenerated]
		get
		{
			return RqntVKrjji;
		}
		[CompilerGenerated]
		private set
		{
			RqntVKrjji = value;
		}
	}

	public string ScriptToExecute
	{
		[CompilerGenerated]
		get
		{
			return JCNtRVQIgK;
		}
		[CompilerGenerated]
		private set
		{
			JCNtRVQIgK = value;
		}
	}

	public ZoneGolfInDriveFile(string fn)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		FileName = fn;
	}

	public ZoneGolfInDriveFile(DriveItem drive)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		if (drive == null)
		{
			return;
		}
		ResetZoneGolfInDrive();
		foreach (KeyValuePair<string, object> additionalDatum in drive.ListItem.Fields.AdditionalData)
		{
			JsonElement jsonElement = (JsonElement)additionalDatum.Value;
			string key = additionalDatum.Key;
			if (!(key == so95DAFNMfktfjp4Dm.An6v7kuCGg(10578)))
			{
				if (!(key == so95DAFNMfktfjp4Dm.An6v7kuCGg(10634)))
				{
					if (!(key == so95DAFNMfktfjp4Dm.An6v7kuCGg(10670)))
					{
						if (key == so95DAFNMfktfjp4Dm.An6v7kuCGg(10698))
						{
							ScriptToExecute = jsonElement.GetString();
						}
						continue;
					}
					string text = jsonElement.GetString();
					if (!(text == so95DAFNMfktfjp4Dm.An6v7kuCGg(8602)))
					{
						if (!(text == so95DAFNMfktfjp4Dm.An6v7kuCGg(10732)))
						{
							if (!(text == so95DAFNMfktfjp4Dm.An6v7kuCGg(10750)))
							{
								if (text == so95DAFNMfktfjp4Dm.An6v7kuCGg(10766))
								{
									SoftwareType = SoftwareType.Document;
								}
								else
								{
									SoftwareType = SoftwareType.Document;
								}
							}
							else
							{
								SoftwareType = SoftwareType.Script;
							}
						}
						else
						{
							SoftwareType = SoftwareType.Package;
						}
					}
					else
					{
						SoftwareType = SoftwareType.E6Connect;
					}
				}
				else
				{
					UseLatestVersion = jsonElement.GetBoolean();
				}
			}
			else
			{
				UseThisVersionInProduction = jsonElement.GetBoolean();
			}
		}
		FileName = drive.Name;
		FileSize = drive.Size.Value;
		drive.AdditionalData.TryGetValue(so95DAFNMfktfjp4Dm.An6v7kuCGg(10786), out var value);
		DownloadUrl = value.ToString();
	}

	public static bool IsUseInProduction(DriveItem driveItem)
	{
		try
		{
			return ((JsonElement)driveItem.ListItem.Fields.AdditionalData[so95DAFNMfktfjp4Dm.An6v7kuCGg(10578)]).GetBoolean();
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool IsProductionE6Connect(DriveItem driveItem)
	{
		try
		{
			return ((JsonElement)driveItem.ListItem.Fields.AdditionalData[so95DAFNMfktfjp4Dm.An6v7kuCGg(10578)]).GetBoolean() && ((JsonElement)driveItem.ListItem.Fields.AdditionalData[so95DAFNMfktfjp4Dm.An6v7kuCGg(10670)]).GetString() == so95DAFNMfktfjp4Dm.An6v7kuCGg(8602);
		}
		catch (Exception)
		{
			return false;
		}
	}

	public bool CanBeInstall()
	{
		if (SoftwareType != SoftwareType.Document)
		{
			return SoftwareType != SoftwareType.Script;
		}
		return false;
	}

	public void ResetZoneGolfInDrive()
	{
		UseThisVersionInProduction = false;
		UseLatestVersion = true;
		SoftwareType = SoftwareType.Document;
		FileName = string.Empty;
		FileSize = -1L;
		DownloadUrl = string.Empty;
		ScriptToExecute = string.Empty;
	}
}
