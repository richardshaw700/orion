using System;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Models;

[Serializable]
public class LauncherCard
{
	[CompilerGenerated]
	private string bYRtoAuqQS;

	[CompilerGenerated]
	private string vpittTuogn;

	[CompilerGenerated]
	private string NRVtDXGrxs;

	[CompilerGenerated]
	private string gtZtvXbmmi;

	[CompilerGenerated]
	private string mUGtJ0ZCkZ;

	[CompilerGenerated]
	private string XOQtegoB4Y;

	[CompilerGenerated]
	private string lIhtKt64TA;

	[CompilerGenerated]
	private int l0Nt7UiaLD;

	[CompilerGenerated]
	private string o8Xt4ZpJHd;

	[CompilerGenerated]
	private string XXRtrBELLV;

	[CompilerGenerated]
	private string km8t8taJbP;

	[CompilerGenerated]
	private string nPutljTRbc;

	[CompilerGenerated]
	private string iOTtn4EB8o;

	[CompilerGenerated]
	private bool Vjut1kmrmC;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return bYRtoAuqQS;
		}
		[CompilerGenerated]
		set
		{
			bYRtoAuqQS = value;
		}
	}

	public string DisplayName
	{
		[CompilerGenerated]
		get
		{
			return vpittTuogn;
		}
		[CompilerGenerated]
		set
		{
			vpittTuogn = value;
		}
	}

	public string DisplayNameFR
	{
		[CompilerGenerated]
		get
		{
			return NRVtDXGrxs;
		}
		[CompilerGenerated]
		set
		{
			NRVtDXGrxs = value;
		}
	}

	public string IconFileName
	{
		[CompilerGenerated]
		get
		{
			return gtZtvXbmmi;
		}
		[CompilerGenerated]
		set
		{
			gtZtvXbmmi = value;
		}
	}

	public string ExePath
	{
		[CompilerGenerated]
		get
		{
			return mUGtJ0ZCkZ;
		}
		[CompilerGenerated]
		set
		{
			mUGtJ0ZCkZ = value;
		}
	}

	public string ExeFolderPath
	{
		[CompilerGenerated]
		get
		{
			return XOQtegoB4Y;
		}
		[CompilerGenerated]
		set
		{
			XOQtegoB4Y = value;
		}
	}

	public string ExeParams
	{
		[CompilerGenerated]
		get
		{
			return lIhtKt64TA;
		}
		[CompilerGenerated]
		set
		{
			lIhtKt64TA = value;
		}
	}

	public int OrderToDisplay
	{
		[CompilerGenerated]
		get
		{
			return l0Nt7UiaLD;
		}
		[CompilerGenerated]
		set
		{
			l0Nt7UiaLD = value;
		}
	}

	public string RelativeWebFilePathFR
	{
		[CompilerGenerated]
		get
		{
			return o8Xt4ZpJHd;
		}
		[CompilerGenerated]
		set
		{
			o8Xt4ZpJHd = value;
		}
	}

	public string RelativeWebFilePathEN
	{
		[CompilerGenerated]
		get
		{
			return XXRtrBELLV;
		}
		[CompilerGenerated]
		set
		{
			XXRtrBELLV = value;
		}
	}

	public string FileNameWithExtension
	{
		[CompilerGenerated]
		get
		{
			return km8t8taJbP;
		}
		[CompilerGenerated]
		set
		{
			km8t8taJbP = value;
		}
	}

	public string RelativeWebVideoPath
	{
		[CompilerGenerated]
		get
		{
			return nPutljTRbc;
		}
		[CompilerGenerated]
		set
		{
			nPutljTRbc = value;
		}
	}

	public string VideoNameWithExtension
	{
		[CompilerGenerated]
		get
		{
			return iOTtn4EB8o;
		}
		[CompilerGenerated]
		set
		{
			iOTtn4EB8o = value;
		}
	}

	public bool IsSoftwareAvailable
	{
		[CompilerGenerated]
		get
		{
			return Vjut1kmrmC;
		}
		[CompilerGenerated]
		set
		{
			Vjut1kmrmC = value;
		}
	}

	[JsonIgnore]
	public bool IsSoftwareInstalled
	{
		get
		{
			if (ExePath != null)
			{
				return File.Exists(ExePath);
			}
			return true;
		}
	}

	public LauncherCard()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
