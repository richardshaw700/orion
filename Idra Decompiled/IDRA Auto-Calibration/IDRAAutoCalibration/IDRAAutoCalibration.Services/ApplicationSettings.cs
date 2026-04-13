using System;
using System.IO;
using System.Text.Json;
using IDRAAutoCalibration.DTO;
using IodKeMsDBY9RwTYmwo;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration.Services;

public static class ApplicationSettings
{
	private static readonly string ufyMY198Jq;

	private static AppSettings? rZbMDHhAaT;

	public static AppSettings Current
	{
		get
		{
			if (rZbMDHhAaT != null)
			{
				return rZbMDHhAaT;
			}
			if (!File.Exists(ufyMY198Jq) || rZbMDHhAaT == null)
			{
				rZbMDHhAaT = new AppSettings();
			}
			if (File.Exists(ufyMY198Jq))
			{
				rZbMDHhAaT = JsonSerializer.Deserialize<AppSettings>(File.ReadAllText(ufyMY198Jq)) ?? new AppSettings();
			}
			return rZbMDHhAaT;
		}
		set
		{
			rZbMDHhAaT = value;
		}
	}

	public static void Save()
	{
		string contents = JsonSerializer.Serialize(rZbMDHhAaT, new JsonSerializerOptions
		{
			WriteIndented = true
		});
		File.WriteAllText(ufyMY198Jq, contents);
	}

	private static string TL3MLklHXk()
	{
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3640), xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3688), xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3734));
		Directory.CreateDirectory(Path.GetDirectoryName(text));
		return text;
	}

	static ApplicationSettings()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		ufyMY198Jq = TL3MLklHXk();
		rZbMDHhAaT = null;
	}
}
