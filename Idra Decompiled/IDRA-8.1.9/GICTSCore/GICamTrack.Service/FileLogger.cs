using System.IO;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;

namespace GICamTrack.Service;

public class FileLogger : LogBase
{
	public string filePath;

	public bool appendToFile;

	public bool deleteAtStart;

	public FileLogger()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		filePath = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(618);
		appendToFile = true;
		base._002Ector();
	}

	public FileLogger(string filePath, bool append = true, bool deleteAtStart = false)
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		this.filePath = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(618);
		appendToFile = true;
		base._002Ector();
		this.filePath = filePath;
		appendToFile = append;
		this.deleteAtStart = deleteAtStart;
		if (deleteAtStart)
		{
			if (File.Exists(filePath))
			{
				File.Copy(filePath, filePath + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(636), overwrite: true);
			}
			File.Delete(filePath);
		}
	}

	public override void Log(string message)
	{
		lock (lockObj)
		{
			if (!File.Exists(filePath))
			{
				File.CreateText(filePath).Close();
			}
			if (!File.Exists(filePath))
			{
				return;
			}
			try
			{
				using StreamWriter streamWriter = new StreamWriter(filePath, appendToFile);
				streamWriter.WriteLine(message);
				streamWriter.Close();
			}
			catch
			{
			}
		}
	}
}
