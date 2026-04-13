using System;
using System.Runtime.CompilerServices;
using System.Threading;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class DownloadWebFileOptions
{
	[CompilerGenerated]
	private string BFiEXS4Lb0;

	[CompilerGenerated]
	private string crTEF40nYm;

	[CompilerGenerated]
	private string QNGEpa7hkI;

	[CompilerGenerated]
	private Action<long, long> sNuEWUWgJr;

	[CompilerGenerated]
	private Action hueEYmdpoF;

	[CompilerGenerated]
	private CancellationToken QhsExph71I;

	public string HttpUrlRequest
	{
		[CompilerGenerated]
		get
		{
			return BFiEXS4Lb0;
		}
		[CompilerGenerated]
		private set
		{
			BFiEXS4Lb0 = value;
		}
	}

	public string OutputFileName
	{
		[CompilerGenerated]
		get
		{
			return crTEF40nYm;
		}
		[CompilerGenerated]
		private set
		{
			crTEF40nYm = value;
		}
	}

	public string OutputTempHostFolderName
	{
		[CompilerGenerated]
		get
		{
			return QNGEpa7hkI;
		}
		[CompilerGenerated]
		private set
		{
			QNGEpa7hkI = value;
		}
	}

	public Action<long, long> OnProgress
	{
		[CompilerGenerated]
		get
		{
			return sNuEWUWgJr;
		}
		[CompilerGenerated]
		set
		{
			sNuEWUWgJr = value;
		}
	}

	public Action OnCompleted
	{
		[CompilerGenerated]
		get
		{
			return hueEYmdpoF;
		}
		[CompilerGenerated]
		set
		{
			hueEYmdpoF = value;
		}
	}

	public CancellationToken CancellationToken
	{
		[CompilerGenerated]
		get
		{
			return QhsExph71I;
		}
		[CompilerGenerated]
		set
		{
			QhsExph71I = value;
		}
	}

	private bool aZBERZ6CT3()
	{
		if (!string.IsNullOrWhiteSpace(HttpUrlRequest) && !string.IsNullOrWhiteSpace(OutputFileName))
		{
			return !string.IsNullOrWhiteSpace(OutputTempHostFolderName);
		}
		return false;
	}

	public DownloadWebFileOptions(string httpUrlRequest, string outputFileName, string outputTempHostFolder)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		HttpUrlRequest = httpUrlRequest;
		OutputFileName = outputFileName;
		OutputTempHostFolderName = outputTempHostFolder;
		if (!aZBERZ6CT3())
		{
			throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(9762));
		}
	}
}
