using System.IO;
using System.Text;
using F3frs5SXTsGVtVfuZX;
using GYFmeytn3uk9KnUELA;

namespace IDRASharedModels;

public static class HelperExtensions
{
	public static void WriteAllTextWithBackupGSProVersion(this FileInfo fileInfo, string contents, bool useBackup = true)
	{
		string tempFileName = Path.GetTempFileName();
		string text = fileInfo.FullName + mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(1148);
		if (useBackup && File.Exists(text))
		{
			File.Delete(text);
		}
		byte[] bytes = Encoding.UTF8.GetBytes(contents);
		using (FileStream fileStream = File.Create(tempFileName, 4096, FileOptions.WriteThrough))
		{
			fileStream.Write(bytes, 0, bytes.Length);
		}
		if (!File.Exists(fileInfo.FullName))
		{
			File.WriteAllText(fileInfo.FullName, string.Empty);
		}
		if (useBackup && !File.Exists(text))
		{
			File.WriteAllText(text, string.Empty);
		}
		if (useBackup)
		{
			File.Replace(tempFileName, fileInfo.FullName, text);
		}
		else
		{
			File.Replace(tempFileName, fileInfo.FullName, null);
		}
	}

	static HelperExtensions()
	{
		G2089JiDB7k4x1yr7J.kLjw4iIsCLsZtxc4lksN0j();
	}
}
