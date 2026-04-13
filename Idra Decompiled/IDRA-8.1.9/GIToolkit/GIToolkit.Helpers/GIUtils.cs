using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using GIToolkit.Services;
using Microsoft.CSharp.RuntimeBinder;
using U4yoVEpfEeOhjCsFXj;

namespace GIToolkit.Helpers;

public static class GIUtils
{
	[CompilerGenerated]
	private static class _003C_003Eo__3<T> where T : IComparable<T>
	{
		public static CallSite<Func<CallSite, object, object, object>> _003C_003Ep__0;

		public static CallSite<Func<CallSite, Type, object, object>> _003C_003Ep__1;

		public static CallSite<Func<CallSite, object, T, object>> _003C_003Ep__2;

		public static CallSite<Func<CallSite, object, bool>> _003C_003Ep__3;

		public static CallSite<Func<CallSite, object, T>> _003C_003Ep__4;
	}

	public static async Task<bool> AwaitTimeoutTask(Task task, int timeout)
	{
		return await Task.WhenAny(task, Task.Delay(timeout)) == task;
	}

	public static bool SequenceChildEqual<T>(List<List<T>> source, List<List<T>> compare)
	{
		if (source == null || compare == null)
		{
			if (source == null)
			{
				return compare == null;
			}
			return false;
		}
		if (source.Count != compare.Count)
		{
			return false;
		}
		bool flag = true;
		for (int i = 0; i < source.Count; i++)
		{
			flag = source[i].SequenceEqual(compare[i]);
			if (!flag)
			{
				break;
			}
		}
		return flag;
	}

	public static bool FilterMessage(JsonElement jsonElement, Dictionary<string, string> propertyValues)
	{
		if (jsonElement.ValueKind == JsonValueKind.Null)
		{
			return false;
		}
		foreach (KeyValuePair<string, string> propertyValue in propertyValues)
		{
			if (jsonElement.TryGetProperty(propertyValue.Key, out var value) && value.GetString() == propertyValue.Value)
			{
				return true;
			}
		}
		return false;
	}

	public static int GetClosestIndexToValueFromList<T>(T compareValue, List<T> range) where T : IComparable<T>
	{
		int result = 0;
		FieldInfo? field = typeof(T).GetField(so95DAFNMfktfjp4Dm.An6v7kuCGg(20896), BindingFlags.Static | BindingFlags.Public);
		if (field == null)
		{
			throw new NotSupportedException(typeof(T).Name);
		}
		T val = (T)field.GetValue(null);
		foreach (T item in range)
		{
			object arg = (dynamic)item - (dynamic)compareValue;
			if (_003C_003Eo__3<T>._003C_003Ep__1 == null)
			{
				_003C_003Eo__3<T>._003C_003Ep__1 = CallSite<Func<CallSite, Type, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, so95DAFNMfktfjp4Dm.An6v7kuCGg(20916), null, typeof(GIUtils), new CSharpArgumentInfo[2]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			dynamic val2 = _003C_003Eo__3<T>._003C_003Ep__1.Target(_003C_003Eo__3<T>._003C_003Ep__1, typeof(Math), arg);
			if (val2 < val)
			{
				val = val2;
				result = range.IndexOf(item);
			}
		}
		return result;
	}

	private static bool IOyv2X49rJ(string P_0, string P_1)
	{
		if (string.IsNullOrWhiteSpace(P_0) || P_0.Any((char x) => x == '\0'))
		{
			return false;
		}
		try
		{
			if (!(P_1 == so95DAFNMfktfjp4Dm.An6v7kuCGg(20926)))
			{
				if (P_1 == so95DAFNMfktfjp4Dm.An6v7kuCGg(20938))
				{
					using (JsonDocument.Parse(P_0))
					{
					}
				}
			}
			else
			{
				new XmlDocument().LoadXml(P_0);
			}
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	public static string ReadAllTextWithBackup(this FileInfo fileInfo)
	{
		if (!fileInfo.Exists)
		{
			throw new FileNotFoundException(so95DAFNMfktfjp4Dm.An6v7kuCGg(20952) + fileInfo.Name + so95DAFNMfktfjp4Dm.An6v7kuCGg(20998));
		}
		string text = null;
		try
		{
			text = File.ReadAllText(fileInfo.FullName);
		}
		catch (Exception)
		{
		}
		if (IOyv2X49rJ(text, fileInfo.Extension))
		{
			return text;
		}
		FileInfo fileInfo2 = new FileInfo(fileInfo.FullName + so95DAFNMfktfjp4Dm.An6v7kuCGg(21004));
		if (!fileInfo2.Exists)
		{
			fileInfo.Delete();
			throw new FileNotFoundException(so95DAFNMfktfjp4Dm.An6v7kuCGg(21022) + fileInfo.Name + so95DAFNMfktfjp4Dm.An6v7kuCGg(20998));
		}
		try
		{
			text = File.ReadAllText(fileInfo2.FullName);
		}
		catch (Exception)
		{
			EventViewerLogger.LogWarning(so95DAFNMfktfjp4Dm.An6v7kuCGg(20952) + fileInfo.Name + so95DAFNMfktfjp4Dm.An6v7kuCGg(21082));
			throw new FileNotFoundException(so95DAFNMfktfjp4Dm.An6v7kuCGg(20952) + fileInfo.Name + so95DAFNMfktfjp4Dm.An6v7kuCGg(21082));
		}
		if (!IOyv2X49rJ(text, fileInfo.Extension))
		{
			EventViewerLogger.LogWarning(so95DAFNMfktfjp4Dm.An6v7kuCGg(20952) + fileInfo.Name + so95DAFNMfktfjp4Dm.An6v7kuCGg(21148));
			throw new FileLoadException(so95DAFNMfktfjp4Dm.An6v7kuCGg(20952) + fileInfo.Name + so95DAFNMfktfjp4Dm.An6v7kuCGg(21148));
		}
		fileInfo.WriteAllTextWithBackup(text);
		return text;
	}

	public static void WriteAllTextWithBackup(this FileInfo fileInfo, string contents, bool useBackup = true)
	{
		string tempFileName = Path.GetTempFileName();
		string text = fileInfo.FullName + so95DAFNMfktfjp4Dm.An6v7kuCGg(21004);
		if (useBackup && File.Exists(text))
		{
			File.Delete(text);
		}
		File.WriteAllText(tempFileName, contents, Encoding.UTF8);
		if (!File.Exists(fileInfo.FullName))
		{
			File.WriteAllText(fileInfo.FullName, string.Empty);
		}
		File.Replace(tempFileName, fileInfo.FullName, useBackup ? text : null);
	}

	public static bool IsDirectoryFree(string directoryPath)
	{
		try
		{
			string[] files = Directory.GetFiles(directoryPath);
			foreach (string path in files)
			{
				try
				{
					using FileStream fileStream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None);
					fileStream.Close();
				}
				catch (IOException)
				{
					return false;
				}
			}
			return true;
		}
		catch
		{
			return false;
		}
	}
}
