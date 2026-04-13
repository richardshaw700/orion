using System;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class E6ConnectServices : IE6ConnectServices
{
	private readonly IIOHelper wINYpobDxr;

	public E6ConnectServices(IIOHelper iioHelper)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		wINYpobDxr = iioHelper;
	}

	public string GetTruTrackXml(string pathToTruTrackXml)
	{
		string text = pathToTruTrackXml + so95DAFNMfktfjp4Dm.An6v7kuCGg(1604);
		if (wINYpobDxr.FileExists(text))
		{
			return wINYpobDxr.FileReadAllText(text);
		}
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(1632) + text;
	}

	public bool SetTruTrackXML(string pathToTruTrackXml, string newTruTrackContent)
	{
		try
		{
			if (wINYpobDxr.DirectoryExist(pathToTruTrackXml))
			{
				wINYpobDxr.FileWriteAllText(pathToTruTrackXml + so95DAFNMfktfjp4Dm.An6v7kuCGg(1604), newTruTrackContent);
				return true;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}
}
