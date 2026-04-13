namespace GIToolkit.Services;

public interface IE6ConnectServices
{
	string GetTruTrackXml(string pathToTruTrackXml);

	bool SetTruTrackXML(string pathToTruTrackXml, string newTruTrackContent);
}
