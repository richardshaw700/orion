using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;

namespace GIToolkit.Services;

public interface IXmlHelper : IService
{
	XmlDocument DocumentHandle { get; }

	string FilePath { get; }

	bool HasLoadedFromContent { get; }

	Task<bool> LoadXmlDocument(string filePath);

	void LoadXmlDocumentFromContent(string xmlContent);

	IEnumerable<T> ReadNodesValues<T>(string xNodePath);

	T ReadNodeValue<T>(string xNodePath);

	Task<T> SetNodeValue<T>(string xNodePath, T newValue);

	string ToPrettyText();
}
