using System.Globalization;
using System.Runtime.CompilerServices;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class AuthenticationConfig
{
	[CompilerGenerated]
	private string BTaYDY56FX;

	[CompilerGenerated]
	private string vTtYvRFDXM;

	[CompilerGenerated]
	private string rUkYJ6kmKv;

	[CompilerGenerated]
	private string FjEYeVSmOJ;

	[CompilerGenerated]
	private string vd9YKOv69Y;

	[CompilerGenerated]
	private string AmyY7bIViU;

	public string Instance
	{
		[CompilerGenerated]
		get
		{
			return BTaYDY56FX;
		}
		[CompilerGenerated]
		set
		{
			BTaYDY56FX = value;
		}
	}

	public string ApiUrl
	{
		[CompilerGenerated]
		get
		{
			return vTtYvRFDXM;
		}
		[CompilerGenerated]
		set
		{
			vTtYvRFDXM = value;
		}
	}

	public string Tenant
	{
		[CompilerGenerated]
		get
		{
			return rUkYJ6kmKv;
		}
		[CompilerGenerated]
		set
		{
			rUkYJ6kmKv = value;
		}
	}

	public string ClientId
	{
		[CompilerGenerated]
		get
		{
			return FjEYeVSmOJ;
		}
		[CompilerGenerated]
		set
		{
			FjEYeVSmOJ = value;
		}
	}

	public string Authority => string.Format(CultureInfo.InvariantCulture, Instance, Tenant);

	public string ClientSecret
	{
		[CompilerGenerated]
		get
		{
			return vd9YKOv69Y;
		}
		[CompilerGenerated]
		set
		{
			vd9YKOv69Y = value;
		}
	}

	public string CertificateName
	{
		[CompilerGenerated]
		get
		{
			return AmyY7bIViU;
		}
		[CompilerGenerated]
		set
		{
			AmyY7bIViU = value;
		}
	}

	public AuthenticationConfig(string tenant, string clientId, string clientSecret)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		BTaYDY56FX = so95DAFNMfktfjp4Dm.An6v7kuCGg(2188);
		vTtYvRFDXM = so95DAFNMfktfjp4Dm.An6v7kuCGg(2266);
		base._002Ector();
		Tenant = tenant;
		ClientId = clientId;
		ClientSecret = clientSecret;
	}
}
