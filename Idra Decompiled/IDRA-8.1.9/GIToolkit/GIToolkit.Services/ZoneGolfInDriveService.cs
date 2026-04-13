using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using GIToolkit.Model;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class ZoneGolfInDriveService : IZoneGolfInDriveService
{
	[CompilerGenerated]
	private IZoneGolfInDriveFile sbvtX66VAo;

	[CompilerGenerated]
	private ProductVersionInfo BE2tFYgDfc;

	[CompilerGenerated]
	private ProductVersionInfo CBytpEpUQL;

	private readonly IIOHelper hRYtWAKq0q;

	private readonly IProcessHelper XyXtYuQlxr;

	private readonly IMicrosoftGraphService JQytxEIaxp;

	private readonly IPowershellService R5Ut6AATiM;

	private string lkWtEQa8bY;

	public IZoneGolfInDriveFile CurrentDriveFile
	{
		[CompilerGenerated]
		get
		{
			return sbvtX66VAo;
		}
		[CompilerGenerated]
		private set
		{
			sbvtX66VAo = value;
		}
	}

	public ProductVersionInfo DownloadedProductInfo
	{
		[CompilerGenerated]
		get
		{
			return BE2tFYgDfc;
		}
		[CompilerGenerated]
		private set
		{
			BE2tFYgDfc = value;
		}
	}

	public ProductVersionInfo InstalledProductInfo
	{
		[CompilerGenerated]
		get
		{
			return CBytpEpUQL;
		}
		[CompilerGenerated]
		private set
		{
			CBytpEpUQL = value;
		}
	}

	[SpecialName]
	private string vdAy2HUsAe()
	{
		if (CurrentDriveFile == null)
		{
			return string.Empty;
		}
		return lkWtEQa8bY + so95DAFNMfktfjp4Dm.An6v7kuCGg(3212) + CurrentDriveFile?.FileName;
	}

	public ZoneGolfInDriveService(IIOHelper iioHelper, IProcessHelper processHelper, IMicrosoftGraphService microsoftGraphService, IPowershellService powershellService)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		lkWtEQa8bY = string.Empty;
		base._002Ector();
		XyXtYuQlxr = processHelper;
		JQytxEIaxp = microsoftGraphService;
		R5Ut6AATiM = powershellService;
		hRYtWAKq0q = iioHelper;
		if (!hRYtWAKq0q.DirectoryExist(GIConstant.GolfInFolder))
		{
			hRYtWAKq0q.CreateDirectory(GIConstant.GolfInFolder);
		}
	}

	public async Task SetCurrentDriveFile(IZoneGolfInDriveFile newCurrentDriveFile, string downloadPath = "")
	{
		if (string.IsNullOrWhiteSpace(downloadPath))
		{
			downloadPath = GIConstant.GolfInFolder;
		}
		CurrentDriveFile = newCurrentDriveFile;
		lkWtEQa8bY = downloadPath;
		DownloadedProductInfo = await R5Ut6AATiM.GetPackageProductVersionInfo(vdAy2HUsAe());
		ProductVersionInfo value = ((DownloadedProductInfo == null) ? null : (await R5Ut6AATiM.GetInstalledPackageProductVersionInfo(DownloadedProductInfo.ProductName)));
		InstalledProductInfo = value;
	}

	public bool DriveFileIsInstalledOnPC()
	{
		return InstalledProductInfo != null;
	}

	public Version GetInstalledVersion()
	{
		if (!DriveFileIsInstalledOnPC())
		{
			return null;
		}
		if (!(InstalledProductInfo.GetProductVersion() != null) || string.IsNullOrEmpty(InstalledProductInfo.ProductVersion))
		{
			return null;
		}
		return InstalledProductInfo.GetProductVersion();
	}

	public Version GetDownloadedVersion()
	{
		if (DownloadedProductInfo == null)
		{
			return null;
		}
		bool flag = DownloadedProductInfo.GetFileVersion() != null && !string.IsNullOrEmpty(DownloadedProductInfo.FileVersion);
		if (DownloadedProductInfo.GetProductVersion() != null && !string.IsNullOrEmpty(DownloadedProductInfo.ProductVersion))
		{
			return DownloadedProductInfo.GetProductVersion();
		}
		if (flag)
		{
			return DownloadedProductInfo.GetFileVersion();
		}
		return null;
	}

	public bool DriveFileUpdateIsNeeded()
	{
		if (CurrentDriveFile == null)
		{
			throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(10846));
		}
		if (!DriveFileIsInstalledOnPC())
		{
			return true;
		}
		Version downloadedVersion = GetDownloadedVersion();
		Version installedVersion = GetInstalledVersion();
		bool num = downloadedVersion != null;
		bool flag = installedVersion != null;
		bool flag2 = (CurrentDriveFile.UseLatestVersion ? (downloadedVersion > installedVersion) : (downloadedVersion != installedVersion));
		return !num || !flag || flag2;
	}

	public bool DriveFileLastUpdateHasBeenDownloaded()
	{
		if (CurrentDriveFile == null)
		{
			throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(10846));
		}
		if (DownloadedProductInfo == null)
		{
			return false;
		}
		return DownloadedProductInfo.FileSize == CurrentDriveFile.FileSize;
	}

	public async Task DownloadExecutableDriveFile(Action<object, DownloadProgressChangedEventArgs> onProgress, Action<object, AsyncCompletedEventArgs> onCompleted)
	{
		if (DriveFileUpdateIsNeeded() && !DriveFileLastUpdateHasBeenDownloaded())
		{
			await JQytxEIaxp.DownloadFile(vdAy2HUsAe(), CurrentDriveFile.DownloadUrl, onProgress, onCompleted);
		}
	}

	public async Task DownloadFile(Action<object, DownloadProgressChangedEventArgs> onProgress, Action<object, AsyncCompletedEventArgs> onCompleted)
	{
		if (!DriveFileLastUpdateHasBeenDownloaded())
		{
			await JQytxEIaxp.DownloadFile(vdAy2HUsAe(), CurrentDriveFile.DownloadUrl, onProgress, onCompleted);
		}
	}

	public async Task<ErrorCode> InstallPackageDriveFile()
	{
		if (CurrentDriveFile == null || DownloadedProductInfo == null)
		{
			throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(10846));
		}
		try
		{
			if (!DriveFileUpdateIsNeeded())
			{
				return new ErrorCode(success: true, string.Empty);
			}
			if (!CurrentDriveFile.CanBeInstall())
			{
				return new ErrorCode(success: false, so95DAFNMfktfjp4Dm.An6v7kuCGg(27594));
			}
			if (!DriveFileLastUpdateHasBeenDownloaded())
			{
				return new ErrorCode(success: false, so95DAFNMfktfjp4Dm.An6v7kuCGg(27686) + DownloadedProductInfo.ProductName + so95DAFNMfktfjp4Dm.An6v7kuCGg(27706));
			}
			if (!string.IsNullOrWhiteSpace(CurrentDriveFile.ScriptToExecute))
			{
				await R5Ut6AATiM.ExecutePowerShellScript(CurrentDriveFile.ScriptToExecute);
				return new ErrorCode(success: true, string.Empty);
			}
			return (await XyXtYuQlxr.InstallProductPackages(vdAy2HUsAe())) ? new ErrorCode(success: true, string.Empty) : new ErrorCode(success: false, so95DAFNMfktfjp4Dm.An6v7kuCGg(27760) + CurrentDriveFile.FileName + so95DAFNMfktfjp4Dm.An6v7kuCGg(27820));
		}
		catch (Exception ex)
		{
			return new ErrorCode(success: false, so95DAFNMfktfjp4Dm.An6v7kuCGg(27878) + CurrentDriveFile.FileName + so95DAFNMfktfjp4Dm.An6v7kuCGg(27962) + ex.Message);
		}
	}
}
