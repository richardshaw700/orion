using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;
using GIToolkit.Services;
using IDRAAutoCalibration.Services;
using IodKeMsDBY9RwTYmwo;
using mMWtJPWctee66WM7q3;

namespace PkY9gMOXojJgyukQM0;

internal class qIuX4r1axfa2Uf2YKa
{
	[SpecialName]
	private static string V5PkUfRF1G()
	{
		if (!GIConstant.UsingSSCInstallPath)
		{
			return xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5218);
		}
		return GIConstant.SSCProgramDataPath + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5318);
	}

	[SpecialName]
	private static string BbkkeGGKKV()
	{
		if (!GIConstant.UsingSSCInstallPath)
		{
			return xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5332);
		}
		return GIConstant.SSCProgramDataPath + xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5446);
	}

	[SpecialName]
	private static string P0SkuOeLat()
	{
		return xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5474);
	}

	[SpecialName]
	private static string Nr1k8ipblw()
	{
		return xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5514);
	}

	[SpecialName]
	private static string J3DkS4X8i3()
	{
		return Path.Combine(BbkkeGGKKV(), P0SkuOeLat());
	}

	[SpecialName]
	private static string jvGks3wbnr()
	{
		return Path.Combine(BbkkeGGKKV(), Nr1k8ipblw());
	}

	private static bool FWkk6cQx64()
	{
		if (!File.Exists(jvGks3wbnr()))
		{
			return !File.Exists(J3DkS4X8i3());
		}
		return true;
	}

	private static string QnjkHH0ykE()
	{
		if (!FWkk6cQx64())
		{
			return J3DkS4X8i3();
		}
		return jvGks3wbnr();
	}

	private static CameraRotation qIjkjOhByf(int P_0)
	{
		CameraRotation result = CameraRotation.UNKNOWN;
		switch (P_0)
		{
		case 90:
			result = CameraRotation.CAMERA_ROTATION_90;
			break;
		case 180:
			result = CameraRotation.CAMERA_ROTATION_180;
			break;
		case 270:
			result = CameraRotation.CAMERA_ROTATION_270;
			break;
		}
		return result;
	}

	public static CameraRotation oTSkRVrvYD()
	{
		return rSxk9Uvom5(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5570), CameraRotation.CAMERA_ROTATION_90);
	}

	public static CameraRotation Ts1kvluYBH()
	{
		return rSxk9Uvom5(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5664), CameraRotation.CAMERA_ROTATION_270);
	}

	public static CameraRotation rSxk9Uvom5(string P_0, CameraRotation P_1)
	{
		CameraRotation result = P_1;
		if (File.Exists(QnjkHH0ykE()))
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(QnjkHH0ykE());
			XmlNode xmlNode = xmlDocument.SelectSingleNode(P_0);
			if (xmlNode != null && int.TryParse(xmlNode.InnerText, out var result2))
			{
				CameraRotation cameraRotation = qIjkjOhByf(result2);
				if (cameraRotation != CameraRotation.UNKNOWN)
				{
					result = cameraRotation;
				}
			}
		}
		return result;
	}

	public qIuX4r1axfa2Uf2YKa()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		base._002Ector();
	}
}
