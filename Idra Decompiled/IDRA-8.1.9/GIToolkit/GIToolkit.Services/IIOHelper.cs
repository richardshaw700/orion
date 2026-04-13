using System.Collections.Generic;
using System.IO;

namespace GIToolkit.Services;

public interface IIOHelper
{
	bool DirectoryExist(string path);

	string FileReadAllText(string pathToFile);

	void FileWriteAllText(string pathToFile, string content);

	string GetFileVersionInfo(string pathToFile, bool isForFileVersion = false);

	void CreateDirectory(string path);

	bool FileCanBeUse(string pathToFile);

	bool FileExists(string pathToFile);

	long GetFileSize(string pathToFile);

	byte[] FileReadAllBytes(string filePath);

	List<string> GetPcInfoFromManagementObjectSearcher(string property, string win32Ressource);

	FileInfo[] GetFiles(string path);

	string[] GetFiles(string pathToFolder, string fileName, SearchOption searchOption);

	IEnumerable<string> ReadLines(string path);

	FileStream OpenRead(string path);

	DriveInfo[] GetDrives();

	string GetParentFolderFullName(string filePath);

	string GetCPUInfoFromWMI();

	void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs);

	void FileDelete(string path);
}
