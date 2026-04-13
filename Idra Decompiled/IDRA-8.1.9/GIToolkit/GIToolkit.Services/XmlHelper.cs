using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class XmlHelper : IXmlHelper, IService
{
	[CompilerGenerated]
	private XmlDocument aTB6GVVgh8;

	[CompilerGenerated]
	private string t2X6C1Olbj;

	private readonly ICircularLogService b686skBnAM;

	public XmlDocument DocumentHandle
	{
		[CompilerGenerated]
		get
		{
			return aTB6GVVgh8;
		}
		[CompilerGenerated]
		private set
		{
			aTB6GVVgh8 = value;
		}
	}

	public string FilePath
	{
		[CompilerGenerated]
		get
		{
			return t2X6C1Olbj;
		}
		[CompilerGenerated]
		private set
		{
			t2X6C1Olbj = value;
		}
	}

	public bool HasLoadedFromContent
	{
		get
		{
			if (string.IsNullOrWhiteSpace(FilePath))
			{
				return DocumentHandle != null;
			}
			return false;
		}
	}

	public XmlHelper(ICircularLogService circularLogService)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		DocumentHandle = new XmlDocument();
		b686skBnAM = circularLogService;
	}

	public async Task<bool> LoadXmlDocument(string filePath)
	{
		b686skBnAM?.Log(so95DAFNMfktfjp4Dm.An6v7kuCGg(25152) + filePath);
		FileInfo fileInfo = new FileInfo(filePath);
		if (!fileInfo.Exists)
		{
			b686skBnAM?.Log(so95DAFNMfktfjp4Dm.An6v7kuCGg(25210), LogLevel.Error);
			throw new FileNotFoundException(filePath);
		}
		if (fileInfo.Length <= 0)
		{
			b686skBnAM?.Log(so95DAFNMfktfjp4Dm.An6v7kuCGg(25288), LogLevel.Error);
			throw new FileLoadException(filePath);
		}
		await IOHelper.WaitFileToUnlock(filePath);
		DocumentHandle.Load(filePath);
		FilePath = filePath;
		return true;
	}

	public void LoadXmlDocumentFromContent(string xmlContent)
	{
		b686skBnAM?.Log(so95DAFNMfktfjp4Dm.An6v7kuCGg(8058));
		DocumentHandle.LoadXml(xmlContent);
		FilePath = string.Empty;
	}

	public string ToPrettyText()
	{
		B5X6yPBx18();
		string empty = string.Empty;
		using StringWriter stringWriter = new StringWriter();
		using XmlWriter w = XmlWriter.Create(stringWriter, new XmlWriterSettings
		{
			OmitXmlDeclaration = true,
			Indent = true,
			NewLineOnAttributes = true
		});
		DocumentHandle.Save(w);
		return stringWriter.ToString();
	}

	public T ReadNodeValue<T>(string xNodePath)
	{
		B5X6yPBx18();
		b686skBnAM?.Log(so95DAFNMfktfjp4Dm.An6v7kuCGg(8128) + xNodePath);
		XmlNode xmlNode = DocumentHandle.DocumentElement.SelectSingleNode(xNodePath);
		if (xmlNode == null)
		{
			b686skBnAM?.Log(so95DAFNMfktfjp4Dm.An6v7kuCGg(8190) + xNodePath + so95DAFNMfktfjp4Dm.An6v7kuCGg(8204), LogLevel.Error);
			throw new NullReferenceException(so95DAFNMfktfjp4Dm.An6v7kuCGg(8190) + xNodePath + so95DAFNMfktfjp4Dm.An6v7kuCGg(8204));
		}
		try
		{
			return TConverter.ChangeType<T>(xmlNode.InnerText);
		}
		catch (InvalidCastException)
		{
			return default(T);
		}
	}

	public IEnumerable<T> ReadNodesValues<T>(string xNodePath)
	{
		B5X6yPBx18();
		b686skBnAM?.Log(so95DAFNMfktfjp4Dm.An6v7kuCGg(8128) + xNodePath);
		XmlNodeList xmlNodeList = DocumentHandle.DocumentElement.SelectNodes(xNodePath);
		if (xmlNodeList == null || xmlNodeList.Count == 0)
		{
			b686skBnAM?.Log(so95DAFNMfktfjp4Dm.An6v7kuCGg(8240) + xNodePath, LogLevel.Error);
			throw new NullReferenceException(so95DAFNMfktfjp4Dm.An6v7kuCGg(8302) + xNodePath + so95DAFNMfktfjp4Dm.An6v7kuCGg(8318));
		}
		try
		{
			List<T> list = new List<T>();
			foreach (XmlNode item2 in xmlNodeList)
			{
				T item = (T)Convert.ChangeType(item2.InnerText, typeof(T));
				list.Add(item);
			}
			return list.ToArray();
		}
		catch (InvalidCastException)
		{
			return Enumerable.Empty<T>();
		}
	}

	public async Task<T> SetNodeValue<T>(string xNodePath, T newValue)
	{
		B5X6yPBx18();
		ICircularLogService circularLogService = b686skBnAM;
		if (circularLogService != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 2);
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(25380));
			defaultInterpolatedStringHandler.AppendFormatted(xNodePath);
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(25454));
			defaultInterpolatedStringHandler.AppendFormatted(newValue);
			circularLogService.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		await LoadXmlDocument(FilePath);
		XmlNode? xmlNode = DocumentHandle.DocumentElement.SelectSingleNode(xNodePath);
		if (xmlNode == null)
		{
			b686skBnAM?.Log(so95DAFNMfktfjp4Dm.An6v7kuCGg(8190) + xNodePath + so95DAFNMfktfjp4Dm.An6v7kuCGg(8204), LogLevel.Error);
			throw new NullReferenceException(so95DAFNMfktfjp4Dm.An6v7kuCGg(8190) + xNodePath + so95DAFNMfktfjp4Dm.An6v7kuCGg(8204));
		}
		xmlNode.InnerText = newValue.ToString();
		DocumentHandle.Save(FilePath);
		await LoadXmlDocument(FilePath);
		return ReadNodeValue<T>(xNodePath);
	}

	private void B5X6yPBx18()
	{
		if (DocumentHandle == null || DocumentHandle.DocumentElement == null)
		{
			b686skBnAM?.Log(so95DAFNMfktfjp4Dm.An6v7kuCGg(8350), LogLevel.Error);
			throw new InvalidOperationException(so95DAFNMfktfjp4Dm.An6v7kuCGg(8414));
		}
	}

	public static bool AreEqual(string xml1, string xml2, string[] excludedXPaths = null)
	{
		XDocument xDocument = XDocument.Parse(xml1);
		XDocument xDocument2 = XDocument.Parse(xml2);
		if (excludedXPaths != null)
		{
			foreach (string expression in excludedXPaths)
			{
				List<XElement> list = xDocument.XPathSelectElements(expression).ToList();
				list.AddRange(xDocument2.XPathSelectElements(expression));
				foreach (XElement item in list)
				{
					item.Remove();
				}
			}
		}
		return XNode.DeepEquals(xDocument, xDocument2);
	}
}
