using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class IOHelper : IIOHelper
{
	public void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(sourceDirName);
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		if (!directoryInfo.Exists)
		{
			throw new DirectoryNotFoundException(so95DAFNMfktfjp4Dm.An6v7kuCGg(3404) + sourceDirName);
		}
		if (!Directory.Exists(destDirName))
		{
			Directory.CreateDirectory(destDirName);
		}
		FileInfo[] files = directoryInfo.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			string destFileName = Path.Combine(destDirName, fileInfo.Name);
			fileInfo.CopyTo(destFileName, overwrite: true);
		}
		if (copySubDirs)
		{
			DirectoryInfo[] array = directories;
			foreach (DirectoryInfo directoryInfo2 in array)
			{
				string destDirName2 = Path.Combine(destDirName, directoryInfo2.Name);
				DirectoryCopy(directoryInfo2.FullName, destDirName2, copySubDirs);
			}
		}
	}

	public bool DirectoryExist(string path)
	{
		return Directory.Exists(path);
	}

	public string GetFileVersionInfo(string pathToFile, bool isForFileVersion = false)
	{
		FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(pathToFile);
		if (versionInfo == null)
		{
			throw new ArgumentNullException();
		}
		if (!isForFileVersion)
		{
			return versionInfo.ProductVersion;
		}
		return versionInfo.FileVersion;
	}

	public long GetFileSize(string pathToFile)
	{
		if (FileExists(pathToFile))
		{
			return new FileInfo(pathToFile).Length;
		}
		return -1L;
	}

	public string FileReadAllText(string pathToFile)
	{
		return File.ReadAllText(pathToFile);
	}

	public void FileWriteAllText(string pathToFile, string content)
	{
		File.WriteAllText(pathToFile, content);
	}

	public void CreateDirectory(string path)
	{
		Directory.CreateDirectory(path);
	}

	public FileInfo[] GetFiles(string path)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		if (!directoryInfo.Exists)
		{
			return null;
		}
		return directoryInfo.GetFiles();
	}

	public string GetParentFolderFullName(string filePath)
	{
		return (new DirectoryInfo(filePath) ?? throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(3516))).Parent.FullName;
	}

	public DriveInfo[] GetDrives()
	{
		return DriveInfo.GetDrives();
	}

	public FileStream OpenRead(string path)
	{
		return File.OpenRead(path);
	}

	public string[] GetFiles(string pathToFolder, string fileName, SearchOption searchOption)
	{
		string[] files = Directory.GetFiles(pathToFolder, fileName, searchOption);
		if (files.Length == 0)
		{
			return null;
		}
		return files;
	}

	public IEnumerable<string> ReadLines(string path)
	{
		IEnumerable<string> result = null;
		IEnumerable<string> enumerable = File.ReadLines(path);
		if (enumerable != null)
		{
			result = enumerable;
		}
		return result;
	}

	public bool FileCanBeUse(string pathToFile)
	{
		try
		{
			using (File.Open(GIConstant.PathToLauncherCardConfigJsonFile, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				return true;
			}
		}
		catch (IOException)
		{
			return false;
		}
	}

	public bool FileExists(string pathToFile)
	{
		return File.Exists(pathToFile);
	}

	public void FileDelete(string pathToFile)
	{
		File.Delete(pathToFile);
	}

	public byte[] FileReadAllBytes(string filePath)
	{
		return File.ReadAllBytes(filePath);
	}

	public List<string> GetPcInfoFromManagementObjectSearcher(string property, string win32Ressource)
	{
		List<string> list = new List<string>();
		foreach (ManagementObject item in new ManagementObjectSearcher(so95DAFNMfktfjp4Dm.An6v7kuCGg(3652) + win32Ressource).Get())
		{
			object propertyValue = item.GetPropertyValue(property);
			list.Add((propertyValue == null) ? (property + so95DAFNMfktfjp4Dm.An6v7kuCGg(3684)) : propertyValue.ToString());
		}
		return list;
	}

	public string GetCPUInfoFromWMI()
	{
		new StringBuilder();
		string result = so95DAFNMfktfjp4Dm.An6v7kuCGg(3708);
		foreach (ManagementObject item in new ManagementObjectSearcher(so95DAFNMfktfjp4Dm.An6v7kuCGg(3738)).Get())
		{
			string value = item[so95DAFNMfktfjp4Dm.An6v7kuCGg(3800)].ToString();
			object value2 = item[so95DAFNMfktfjp4Dm.An6v7kuCGg(3812)];
			object value3 = item[so95DAFNMfktfjp4Dm.An6v7kuCGg(3842)];
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 3);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(3896));
			defaultInterpolatedStringHandler.AppendFormatted<object>(value2);
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(3904));
			defaultInterpolatedStringHandler.AppendFormatted<object>(value3);
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(3930));
			result = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return result;
	}

	public static async Task WaitFileToUnlock(string fileName, int nbAttemps = 300, int delayBetweenAttemps = 100)
	{
		int cptAttemps = 0;
		while (true)
		{
			int num = cptAttemps + 1;
			cptAttemps = num;
			if (num >= nbAttemps)
			{
				break;
			}
			try
			{
				using (File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					break;
				}
			}
			catch (Exception)
			{
				await Task.Delay(TimeSpan.FromMilliseconds(delayBetweenAttemps));
			}
		}
	}

	public IOHelper()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
