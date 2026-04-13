using System;
using System.Runtime.CompilerServices;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class ProductVersionInfo
{
	[CompilerGenerated]
	private string DDExf0lot3;

	[CompilerGenerated]
	private string oOsxyZXEfx;

	[CompilerGenerated]
	private string N0UxHnGjaM;

	[CompilerGenerated]
	private string w7qxwX1VIh;

	[CompilerGenerated]
	private string SakxG5JHux;

	[CompilerGenerated]
	private string Iw6xCUoLVs;

	[CompilerGenerated]
	private string m1axsVYLXg;

	[CompilerGenerated]
	private string KynxOiMQ7o;

	[CompilerGenerated]
	private string BLIx9s2XE7;

	[CompilerGenerated]
	private long tbZxhExanM;

	public string ProductName
	{
		[CompilerGenerated]
		get
		{
			return DDExf0lot3;
		}
		[CompilerGenerated]
		set
		{
			DDExf0lot3 = value;
		}
	}

	public string FileVersion
	{
		[CompilerGenerated]
		get
		{
			return oOsxyZXEfx;
		}
		[CompilerGenerated]
		set
		{
			oOsxyZXEfx = value;
		}
	}

	public string ProductVersion
	{
		[CompilerGenerated]
		get
		{
			return N0UxHnGjaM;
		}
		[CompilerGenerated]
		set
		{
			N0UxHnGjaM = value;
		}
	}

	public string FileName
	{
		[CompilerGenerated]
		get
		{
			return w7qxwX1VIh;
		}
		[CompilerGenerated]
		set
		{
			w7qxwX1VIh = value;
		}
	}

	public string OriginalFileName
	{
		[CompilerGenerated]
		get
		{
			return SakxG5JHux;
		}
		[CompilerGenerated]
		set
		{
			SakxG5JHux = value;
		}
	}

	public string FileDescription
	{
		[CompilerGenerated]
		get
		{
			return Iw6xCUoLVs;
		}
		[CompilerGenerated]
		set
		{
			Iw6xCUoLVs = value;
		}
	}

	public string Comments
	{
		[CompilerGenerated]
		get
		{
			return m1axsVYLXg;
		}
		[CompilerGenerated]
		set
		{
			m1axsVYLXg = value;
		}
	}

	public string CompanyName
	{
		[CompilerGenerated]
		get
		{
			return KynxOiMQ7o;
		}
		[CompilerGenerated]
		set
		{
			KynxOiMQ7o = value;
		}
	}

	public string Language
	{
		[CompilerGenerated]
		get
		{
			return BLIx9s2XE7;
		}
		[CompilerGenerated]
		set
		{
			BLIx9s2XE7 = value;
		}
	}

	public long FileSize
	{
		[CompilerGenerated]
		get
		{
			return tbZxhExanM;
		}
		[CompilerGenerated]
		set
		{
			tbZxhExanM = value;
		}
	}

	public ProductVersionInfo()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}

	public ProductVersionInfo(string productName, string productVersion)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		ProductName = productName;
		ProductVersion = productVersion;
	}

	public Version GetFileVersion()
	{
		if (!Version.TryParse(FileVersion, out Version result))
		{
			return null;
		}
		return result;
	}

	public Version GetProductVersion()
	{
		if (!Version.TryParse(ProductVersion, out Version result))
		{
			return null;
		}
		return result;
	}
}
