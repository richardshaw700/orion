using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using GIToolkit.Services;
using GolfInLauncher.Internationalization;
using Lmttrs0IQc7UR7Zpt6;
using U9xbeMdbyr6Pactctj;
using kYcZlfcjxZnXny35tZ;

namespace GolfInLauncher.Services.SoftwareUpdate;

public sealed class SoftwareVersionsService
{
	private readonly struct GA2UOGVdpPqSC3y8l0 : IEquatable<GA2UOGVdpPqSC3y8l0>
	{
		[CompilerGenerated]
		private readonly XElement D5pQepSyJR;

		[CompilerGenerated]
		private readonly string t3NQb7XB1Q;

		[CompilerGenerated]
		private readonly rkEwTEHKaH3YOl6yUG pnVQVRwGbL;

		public rkEwTEHKaH3YOl6yUG Key
		{
			[CompilerGenerated]
			get
			{
				return pnVQVRwGbL;
			}
			[CompilerGenerated]
			init
			{
				pnVQVRwGbL = rkEwTEHKaH3YOl6yUG;
			}
		}

		public GA2UOGVdpPqSC3y8l0(XElement P_0, string P_1, rkEwTEHKaH3YOl6yUG P_2)
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			D5pQepSyJR = P_0;
			t3NQb7XB1Q = P_1;
			pnVQVRwGbL = P_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public XElement VVYQ3VjXdF()
		{
			return D5pQepSyJR;
		}

		[SpecialName]
		[CompilerGenerated]
		public void HpMQsrSejM(XElement P_0)
		{
			D5pQepSyJR = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public string upbQ5CRXpM()
		{
			return t3NQb7XB1Q;
		}

		[SpecialName]
		[CompilerGenerated]
		public void GasQQKFc6m(string P_0)
		{
			t3NQb7XB1Q = P_0;
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(aL07ImwcwlxdnyfI30.olMQlwrxmw(21954));
			stringBuilder.Append(aL07ImwcwlxdnyfI30.olMQlwrxmw(21984));
			if (G2VQGKRAYl(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		[CompilerGenerated]
		private bool G2VQGKRAYl(StringBuilder P_0)
		{
			P_0.Append(aL07ImwcwlxdnyfI30.olMQlwrxmw(21994));
			P_0.Append(VVYQ3VjXdF());
			P_0.Append(aL07ImwcwlxdnyfI30.olMQlwrxmw(22018));
			P_0.Append((object?)upbQ5CRXpM());
			P_0.Append(aL07ImwcwlxdnyfI30.olMQlwrxmw(22040));
			P_0.Append(Key.ToString());
			return true;
		}

		[CompilerGenerated]
		public static bool operator !=(GA2UOGVdpPqSC3y8l0 P_0, GA2UOGVdpPqSC3y8l0 P_1)
		{
			return !(P_0 == P_1);
		}

		[CompilerGenerated]
		public static bool operator ==(GA2UOGVdpPqSC3y8l0 P_0, GA2UOGVdpPqSC3y8l0 P_1)
		{
			return P_0.Equals(P_1);
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<XElement>.Default.GetHashCode(D5pQepSyJR) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(t3NQb7XB1Q)) * -1521134295 + EqualityComparer<rkEwTEHKaH3YOl6yUG>.Default.GetHashCode(pnVQVRwGbL);
		}

		[CompilerGenerated]
		public override bool Equals(object P_0)
		{
			if (P_0 is GA2UOGVdpPqSC3y8l0)
			{
				return Equals((GA2UOGVdpPqSC3y8l0)P_0);
			}
			return false;
		}

		[CompilerGenerated]
		public bool Equals(GA2UOGVdpPqSC3y8l0 P_0)
		{
			if (EqualityComparer<XElement>.Default.Equals(D5pQepSyJR, P_0.D5pQepSyJR) && EqualityComparer<string>.Default.Equals(t3NQb7XB1Q, P_0.t3NQb7XB1Q))
			{
				return EqualityComparer<rkEwTEHKaH3YOl6yUG>.Default.Equals(pnVQVRwGbL, P_0.pnVQVRwGbL);
			}
			return false;
		}

		[CompilerGenerated]
		public void oHsQZBYBnp(out XElement P_0, out string P_1, out rkEwTEHKaH3YOl6yUG P_2)
		{
			P_0 = VVYQ3VjXdF();
			P_1 = upbQ5CRXpM();
			P_2 = Key;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec w6kQysSiv7;

		public static Func<XElement, bool> IjKQ6U7ytw;

		public static Func<GA2UOGVdpPqSC3y8l0, rkEwTEHKaH3YOl6yUG> Ct9QTpfA7b;

		public static Func<XElement, bool> i5hQYVexwA;

		public static Func<XElement, string> VwwQS0DhPh;

		static _003C_003Ec()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			w6kQysSiv7 = new _003C_003Ec();
		}

		public _003C_003Ec()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal bool nSdQwwYkTl(XElement n)
		{
			return string.Equals((string?)n.Attribute(aL07ImwcwlxdnyfI30.olMQlwrxmw(14706)), aL07ImwcwlxdnyfI30.olMQlwrxmw(14736), StringComparison.OrdinalIgnoreCase);
		}

		internal rkEwTEHKaH3YOl6yUG iuqQ0DBf3i(GA2UOGVdpPqSC3y8l0 x)
		{
			return x.Key;
		}

		internal bool oi5QC21tDd(XElement v)
		{
			return string.Equals((string?)v.Attribute(aL07ImwcwlxdnyfI30.olMQlwrxmw(14706)), aL07ImwcwlxdnyfI30.olMQlwrxmw(14736), StringComparison.OrdinalIgnoreCase);
		}

		internal string CxbQdT3sxG(XElement v)
		{
			return v.Value.Trim();
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public Software SZVQXL7exd;

		public _003C_003Ec__DisplayClass13_0()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal bool W10QN8V7Pm(XElement s)
		{
			return string.Equals((string?)s.Attribute(aL07ImwcwlxdnyfI30.olMQlwrxmw(22060)), SZVQXL7exd.ToString(), StringComparison.OrdinalIgnoreCase);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Ec__DisplayClass15_0
	{
		public string rGKQ1mxMLX;

		public Software WvoQrvS45y;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public CancellationTokenSource apUQONTpEC;

		public _003C_003Ec__DisplayClass18_0()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal void FTpQ4QH56k()
		{
			try
			{
				apUQONTpEC.Cancel();
			}
			catch
			{
			}
			try
			{
				Process vSsspFwDWu = SoftwareVersionsService.vSsspFwDWu;
				if (vSsspFwDWu != null && !vSsspFwDWu.HasExited)
				{
					SoftwareVersionsService.vSsspFwDWu.Kill(entireProcessTree: true);
				}
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public Software HJSQAiHtb5;

		public string o4MQDGj0V6;

		public _003C_003Ec__DisplayClass4_0()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal string RTaQ9FDJhc(XDocument _, XElement softwareElement)
		{
			string obj = softwareElement.Element(aL07ImwcwlxdnyfI30.olMQlwrxmw(13940))?.Value;
			if (obj == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(59, 1);
				defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(22072));
				defaultInterpolatedStringHandler.AppendFormatted(HJSQAiHtb5);
				defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(14100));
				throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			string path = obj;
			string path2 = UdV3nv5G8t(softwareElement, HJSQAiHtb5);
			string path3 = ((HJSQAiHtb5 == Software.ZGISRemote) ? aL07ImwcwlxdnyfI30.olMQlwrxmw(14108) : HJSQAiHtb5.ToString());
			return Path.Combine(o4MQDGj0V6, path3, path2, path);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public Software mNVQuDVWGr;

		public _003C_003Ec__DisplayClass6_0()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal string GySQarpfFy(XDocument _, XElement softwareElement)
		{
			return UdV3nv5G8t(softwareElement, mNVQuDVWGr);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public Software XtaQjNwt8Z;

		public string OUCQmxH41O;

		public Func<XElement, GA2UOGVdpPqSC3y8l0> tpoQINlQIg;

		public _003C_003Ec__DisplayClass8_0()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal string SfdQKCrsYk(XDocument _, XElement softwareElement)
		{
			_003C_003Ec__DisplayClass8_1 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_1();
			List<XElement> list = (softwareElement.Element(aL07ImwcwlxdnyfI30.olMQlwrxmw(14568)) ?? throw new InvalidOperationException(string.Format(Resources.SoftwareUpdateNoVersionInstalled, XtaQjNwt8Z))).Elements(aL07ImwcwlxdnyfI30.olMQlwrxmw(14588)).ToList();
			if (list.Count == 0)
			{
				throw new InvalidOperationException(string.Format(Resources.SoftwareUpdateNoVersionInstalled, XtaQjNwt8Z));
			}
			XElement xElement = list.SingleOrDefault(_003C_003Ec.w6kQysSiv7.nSdQwwYkTl) ?? throw new InvalidOperationException(string.Format(Resources.SoftwareUpdateNoActiveVersionFound, XtaQjNwt8Z));
			string text = xElement.Value.Trim();
			_003C_003Ec__DisplayClass8_.x89Qft1QXo = apl3g4hMMN(text, XtaQjNwt8Z);
			GA2UOGVdpPqSC3y8l0 gA2UOGVdpPqSC3y8l = list.Select((XElement element) => new GA2UOGVdpPqSC3y8l0(element, element.Value.Trim(), apl3g4hMMN(element.Value.Trim(), XtaQjNwt8Z))).ToList().Where(_003C_003Ec__DisplayClass8_.jwBQEHSwb6)
				.OrderByDescending(_003C_003Ec.w6kQysSiv7.iuqQ0DBf3i)
				.FirstOrDefault();
			if (gA2UOGVdpPqSC3y8l.VVYQ3VjXdF() == null)
			{
				throw new InvalidOperationException(string.Format(Resources.SoftwareUpdateAlreadyLowestActiveVersion, XtaQjNwt8Z, text));
			}
			MLj3FHdRQn(OUCQmxH41O, XtaQjNwt8Z, gA2UOGVdpPqSC3y8l.upbQ5CRXpM(), softwareElement);
			tyl3oaDET3(xElement, _0020: false);
			tyl3oaDET3(gA2UOGVdpPqSC3y8l.VVYQ3VjXdF(), _0020: true);
			return gA2UOGVdpPqSC3y8l.upbQ5CRXpM();
		}

		internal GA2UOGVdpPqSC3y8l0 TepQ2r1W6A(XElement element)
		{
			return new GA2UOGVdpPqSC3y8l0(element, element.Value.Trim(), apl3g4hMMN(element.Value.Trim(), XtaQjNwt8Z));
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_1
	{
		public rkEwTEHKaH3YOl6yUG x89Qft1QXo;

		public _003C_003Ec__DisplayClass8_1()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal bool jwBQEHSwb6(GA2UOGVdpPqSC3y8l0 x)
		{
			return x.Key.CompareTo(x89Qft1QXo) < 0;
		}
	}

	private static Process? vSsspFwDWu;

	public static bool ConfigurationFileExists()
	{
		return File.Exists(aL07ImwcwlxdnyfI30.olMQlwrxmw(13686));
	}

	public static string GetSoftwareChocolateyPackageName(Software software)
	{
		string result = "";
		switch (software)
		{
		case Software.IDRA:
			result = aL07ImwcwlxdnyfI30.olMQlwrxmw(13806);
			break;
		case Software.ZGISRemote:
			result = aL07ImwcwlxdnyfI30.olMQlwrxmw(13834);
			break;
		case Software.GolfInLauncher:
			result = aL07ImwcwlxdnyfI30.olMQlwrxmw(13860);
			break;
		case Software.IDRAAutoCalibration:
			result = aL07ImwcwlxdnyfI30.olMQlwrxmw(13894);
			break;
		}
		return result;
	}

	public static string GetMainExecutablePath(Software software)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals8.HJSQAiHtb5 = software;
		CS_0024_003C_003E8__locals8.o4MQDGj0V6 = GIConstant.SSCInstallPath;
		return Q0U3Ucu6BY(CS_0024_003C_003E8__locals8.HJSQAiHtb5, delegate(XDocument _, XElement softwareElement)
		{
			string obj = softwareElement.Element(aL07ImwcwlxdnyfI30.olMQlwrxmw(13940))?.Value;
			if (obj == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(59, 1);
				defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(22072));
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals8.HJSQAiHtb5);
				defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(14100));
				throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			string path = obj;
			string path2 = UdV3nv5G8t(softwareElement, CS_0024_003C_003E8__locals8.HJSQAiHtb5);
			string path3 = ((CS_0024_003C_003E8__locals8.HJSQAiHtb5 == Software.ZGISRemote) ? aL07ImwcwlxdnyfI30.olMQlwrxmw(14108) : CS_0024_003C_003E8__locals8.HJSQAiHtb5.ToString());
			return Path.Combine(CS_0024_003C_003E8__locals8.o4MQDGj0V6, path3, path2, path);
		});
	}

	public static async Task<bool> HasAnyNewVersionAvailableAsync(bool isZGISRemoteEnabled)
	{
		Software[] values = Enum.GetValues<Software>();
		foreach (Software software in values)
		{
			if (software != Software.ZGISRemote || isZGISRemoteEnabled)
			{
				string activeSoftwareVersionNumber = GetActiveSoftwareVersionNumber(software);
				if (!(await IsVersionLatestAvailableAsync(software, activeSoftwareVersionNumber)))
				{
					return true;
				}
			}
		}
		return false;
	}

	public static string GetActiveSoftwareVersionNumber(Software software)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals4.mNVQuDVWGr = software;
		if (CS_0024_003C_003E8__locals4.mNVQuDVWGr != Software.GolfInLauncher)
		{
			return Q0U3Ucu6BY(CS_0024_003C_003E8__locals4.mNVQuDVWGr, (XDocument _, XElement softwareElement) => UdV3nv5G8t(softwareElement, CS_0024_003C_003E8__locals4.mNVQuDVWGr));
		}
		return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
	}

	public static async Task<bool> IsVersionLatestAvailableAsync(Software software, string currentVersion)
	{
		return currentVersion == await new ChocolateyLatestVersionFinder(new CircularLogService()).FindPackageLatestVersionNumber(GetSoftwareChocolateyPackageName(software));
	}

	public static string SetActiveVersionToPrevious(Software software)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals11 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals11.XtaQjNwt8Z = software;
		CS_0024_003C_003E8__locals11.OUCQmxH41O = GIConstant.SSCInstallPath;
		return Xoj3t1yoDh(CS_0024_003C_003E8__locals11.XtaQjNwt8Z, delegate(XDocument _, XElement softwareElement)
		{
			_003C_003Ec__DisplayClass8_1 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_1();
			List<XElement> list = (softwareElement.Element(aL07ImwcwlxdnyfI30.olMQlwrxmw(14568)) ?? throw new InvalidOperationException(string.Format(Resources.SoftwareUpdateNoVersionInstalled, CS_0024_003C_003E8__locals11.XtaQjNwt8Z))).Elements(aL07ImwcwlxdnyfI30.olMQlwrxmw(14588)).ToList();
			if (list.Count == 0)
			{
				throw new InvalidOperationException(string.Format(Resources.SoftwareUpdateNoVersionInstalled, CS_0024_003C_003E8__locals11.XtaQjNwt8Z));
			}
			XElement xElement = list.SingleOrDefault(_003C_003Ec.w6kQysSiv7.nSdQwwYkTl) ?? throw new InvalidOperationException(string.Format(Resources.SoftwareUpdateNoActiveVersionFound, CS_0024_003C_003E8__locals11.XtaQjNwt8Z));
			string text = xElement.Value.Trim();
			_003C_003Ec__DisplayClass8_.x89Qft1QXo = apl3g4hMMN(text, CS_0024_003C_003E8__locals11.XtaQjNwt8Z);
			GA2UOGVdpPqSC3y8l0 gA2UOGVdpPqSC3y8l = list.Select((XElement element) => new GA2UOGVdpPqSC3y8l0(element, element.Value.Trim(), apl3g4hMMN(element.Value.Trim(), CS_0024_003C_003E8__locals11.XtaQjNwt8Z))).ToList().Where(_003C_003Ec__DisplayClass8_.jwBQEHSwb6)
				.OrderByDescending(_003C_003Ec.w6kQysSiv7.iuqQ0DBf3i)
				.FirstOrDefault();
			if (gA2UOGVdpPqSC3y8l.VVYQ3VjXdF() == null)
			{
				throw new InvalidOperationException(string.Format(Resources.SoftwareUpdateAlreadyLowestActiveVersion, CS_0024_003C_003E8__locals11.XtaQjNwt8Z, text));
			}
			MLj3FHdRQn(CS_0024_003C_003E8__locals11.OUCQmxH41O, CS_0024_003C_003E8__locals11.XtaQjNwt8Z, gA2UOGVdpPqSC3y8l.upbQ5CRXpM(), softwareElement);
			tyl3oaDET3(xElement, _0020: false);
			tyl3oaDET3(gA2UOGVdpPqSC3y8l.VVYQ3VjXdF(), _0020: true);
			return gA2UOGVdpPqSC3y8l.upbQ5CRXpM();
		});
	}

	private static void MLj3FHdRQn(string P_0, Software P_1, string P_2, XElement P_3)
	{
		string obj = P_3.Element(aL07ImwcwlxdnyfI30.olMQlwrxmw(13940))?.Value;
		if (obj == null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(63, 1);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(13974));
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(14100));
			throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		string path = obj;
		string path2 = ((P_1 == Software.ZGISRemote) ? aL07ImwcwlxdnyfI30.olMQlwrxmw(14108) : P_1.ToString());
		string text = Path.Combine(P_0, path2, P_2);
		if (!Directory.Exists(text))
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(69, 3);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(14134));
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(14188));
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(14206));
			defaultInterpolatedStringHandler.AppendFormatted(text);
			throw new DirectoryNotFoundException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		string text2 = Path.Combine(text, path);
		if (!File.Exists(text2))
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(77, 3);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(14134));
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(14188));
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(14284));
			defaultInterpolatedStringHandler.AppendFormatted(text2);
			throw new FileNotFoundException(defaultInterpolatedStringHandler.ToStringAndClear(), text2);
		}
	}

	private static pQcgoIQEd1ERKbGoEL Q0U3Ucu6BY<pQcgoIQEd1ERKbGoEL>(Software P_0, Func<XDocument, XElement, pQcgoIQEd1ERKbGoEL> P_1)
	{
		XDocument xDocument = QUy3LA5aeP();
		XElement arg = EHQ3RrDyRC(xDocument, P_0);
		return P_1(xDocument, arg);
	}

	private static bFBhcVxjrAeubEVbta Xoj3t1yoDh<bFBhcVxjrAeubEVbta>(Software P_0, Func<XDocument, XElement, bFBhcVxjrAeubEVbta> P_1)
	{
		XDocument xDocument = QUy3LA5aeP();
		XElement arg = EHQ3RrDyRC(xDocument, P_0);
		bFBhcVxjrAeubEVbta result = P_1(xDocument, arg);
		xDocument.Save(aL07ImwcwlxdnyfI30.olMQlwrxmw(13686));
		return result;
	}

	private static XDocument QUy3LA5aeP()
	{
		if (!File.Exists(aL07ImwcwlxdnyfI30.olMQlwrxmw(13686)))
		{
			throw new FileNotFoundException(aL07ImwcwlxdnyfI30.olMQlwrxmw(14378), aL07ImwcwlxdnyfI30.olMQlwrxmw(13686));
		}
		return XDocument.Load(aL07ImwcwlxdnyfI30.olMQlwrxmw(13686));
	}

	private static XElement EHQ3RrDyRC(XDocument P_0, Software P_1)
	{
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass13_0();
		CS_0024_003C_003E8__locals3.SZVQXL7exd = P_1;
		XElement? obj = P_0.Root?.Elements(aL07ImwcwlxdnyfI30.olMQlwrxmw(14448)).FirstOrDefault((XElement s) => string.Equals((string?)s.Attribute(aL07ImwcwlxdnyfI30.olMQlwrxmw(22060)), CS_0024_003C_003E8__locals3.SZVQXL7exd.ToString(), StringComparison.OrdinalIgnoreCase));
		if (obj == null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 1);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(14468));
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals3.SZVQXL7exd);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(14492));
			throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return obj;
	}

	private static string UdV3nv5G8t(XElement P_0, Software P_1)
	{
		string? obj = (from v in P_0.Element(aL07ImwcwlxdnyfI30.olMQlwrxmw(14568))?.Elements(aL07ImwcwlxdnyfI30.olMQlwrxmw(14588))
			where string.Equals((string?)v.Attribute(aL07ImwcwlxdnyfI30.olMQlwrxmw(14706)), aL07ImwcwlxdnyfI30.olMQlwrxmw(14736), StringComparison.OrdinalIgnoreCase)
			select v.Value.Trim()).SingleOrDefault();
		if (string.IsNullOrWhiteSpace(obj))
		{
			throw new InvalidOperationException(string.Format(Resources.SoftwareUpdateNoVersionInstalled, P_1));
		}
		return obj;
	}

	private static rkEwTEHKaH3YOl6yUG apl3g4hMMN(string P_0, Software P_1)
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		_003C_003Ec__DisplayClass15_.rGKQ1mxMLX = P_0;
		_003C_003Ec__DisplayClass15_.WvoQrvS45y = P_1;
		Match match = Regex.Match(_003C_003Ec__DisplayClass15_.rGKQ1mxMLX, aL07ImwcwlxdnyfI30.olMQlwrxmw(14604));
		if (!match.Success)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 2);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(14646));
			defaultInterpolatedStringHandler.AppendFormatted(_003C_003Ec__DisplayClass15_.rGKQ1mxMLX);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(14188));
			defaultInterpolatedStringHandler.AppendFormatted(_003C_003Ec__DisplayClass15_.WvoQrvS45y);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(14668));
			throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		string[] source = match.Groups[1].Value.Split('.', StringSplitOptions.RemoveEmptyEntries);
		return new rkEwTEHKaH3YOl6yUG(hys3zVxkvl(source.ElementAtOrDefault(0) ?? aL07ImwcwlxdnyfI30.olMQlwrxmw(3522), ref _003C_003Ec__DisplayClass15_), hys3zVxkvl(source.ElementAtOrDefault(1) ?? aL07ImwcwlxdnyfI30.olMQlwrxmw(3522), ref _003C_003Ec__DisplayClass15_), hys3zVxkvl(source.ElementAtOrDefault(2) ?? aL07ImwcwlxdnyfI30.olMQlwrxmw(3522), ref _003C_003Ec__DisplayClass15_), hys3zVxkvl(source.ElementAtOrDefault(3) ?? aL07ImwcwlxdnyfI30.olMQlwrxmw(3522), ref _003C_003Ec__DisplayClass15_));
	}

	private static void tyl3oaDET3(XElement P_0, bool P_1)
	{
		P_0.SetAttributeValue(aL07ImwcwlxdnyfI30.olMQlwrxmw(14706), P_1 ? aL07ImwcwlxdnyfI30.olMQlwrxmw(14736) : aL07ImwcwlxdnyfI30.olMQlwrxmw(14722));
	}

	public static void CancelCurrentUpdate()
	{
		try
		{
			Process process = vSsspFwDWu;
			if (process != null && !process.HasExited)
			{
				vSsspFwDWu.Kill(entireProcessTree: true);
			}
		}
		catch
		{
		}
	}

	public static async Task<int> RunChocolateyUpdateForSoftwareAsync(string chocolateyPackageName, bool showPowerShellWindowAndKeepOpen = false, string? processNameToStop = null, string? alwaysStartExePath = null, string? alwaysStartExeArgs = null, string? logPath = null, bool runAsAdministrator = true, int timeoutMilliseconds = -1, IProgress<string>? progress = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass18_0();
		if (string.IsNullOrWhiteSpace(chocolateyPackageName))
		{
			throw new ArgumentException(aL07ImwcwlxdnyfI30.olMQlwrxmw(22190), aL07ImwcwlxdnyfI30.olMQlwrxmw(22290));
		}
		string baseDirectory = AppContext.BaseDirectory;
		string text = Path.Combine(baseDirectory, aL07ImwcwlxdnyfI30.olMQlwrxmw(22336));
		if (!File.Exists(text))
		{
			throw new FileNotFoundException(aL07ImwcwlxdnyfI30.olMQlwrxmw(22404), text);
		}
		if (progress != null && string.IsNullOrWhiteSpace(logPath))
		{
			throw new ArgumentException(aL07ImwcwlxdnyfI30.olMQlwrxmw(22502), aL07ImwcwlxdnyfI30.olMQlwrxmw(22626));
		}
		if (!string.IsNullOrWhiteSpace(logPath))
		{
			Directory.CreateDirectory(Path.GetDirectoryName(logPath));
		}
		if (!string.IsNullOrWhiteSpace(logPath) && File.Exists(logPath))
		{
			File.Delete(logPath);
		}
		ProcessStartInfo processStartInfo = new ProcessStartInfo
		{
			FileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(22644),
			UseShellExecute = true,
			WorkingDirectory = baseDirectory,
			CreateNoWindow = !showPowerShellWindowAndKeepOpen,
			WindowStyle = ((!showPowerShellWindowAndKeepOpen) ? ProcessWindowStyle.Hidden : ProcessWindowStyle.Normal)
		};
		if (runAsAdministrator)
		{
			processStartInfo.Verb = aL07ImwcwlxdnyfI30.olMQlwrxmw(6946);
		}
		if (showPowerShellWindowAndKeepOpen)
		{
			processStartInfo.ArgumentList.Add(aL07ImwcwlxdnyfI30.olMQlwrxmw(22676));
		}
		processStartInfo.ArgumentList.Add(aL07ImwcwlxdnyfI30.olMQlwrxmw(22694));
		processStartInfo.ArgumentList.Add(aL07ImwcwlxdnyfI30.olMQlwrxmw(22718));
		processStartInfo.ArgumentList.Add(aL07ImwcwlxdnyfI30.olMQlwrxmw(22754));
		processStartInfo.ArgumentList.Add(aL07ImwcwlxdnyfI30.olMQlwrxmw(22770));
		processStartInfo.ArgumentList.Add(text);
		processStartInfo.ArgumentList.Add(aL07ImwcwlxdnyfI30.olMQlwrxmw(22784));
		processStartInfo.ArgumentList.Add(chocolateyPackageName);
		if (!string.IsNullOrWhiteSpace(processNameToStop))
		{
			processStartInfo.ArgumentList.Add(aL07ImwcwlxdnyfI30.olMQlwrxmw(22822));
			processStartInfo.ArgumentList.Add(processNameToStop);
		}
		if (!string.IsNullOrWhiteSpace(logPath))
		{
			processStartInfo.ArgumentList.Add(aL07ImwcwlxdnyfI30.olMQlwrxmw(22862));
			processStartInfo.ArgumentList.Add(logPath);
		}
		if (!string.IsNullOrWhiteSpace(alwaysStartExePath))
		{
			processStartInfo.ArgumentList.Add(aL07ImwcwlxdnyfI30.olMQlwrxmw(22882));
			processStartInfo.ArgumentList.Add(alwaysStartExePath);
			if (!string.IsNullOrWhiteSpace(alwaysStartExeArgs))
			{
				processStartInfo.ArgumentList.Add(aL07ImwcwlxdnyfI30.olMQlwrxmw(22924));
				processStartInfo.ArgumentList.Add(alwaysStartExeArgs);
			}
		}
		vSsspFwDWu = Process.Start(processStartInfo) ?? throw new InvalidOperationException(aL07ImwcwlxdnyfI30.olMQlwrxmw(22966));
		CS_0024_003C_003E8__locals6.apUQONTpEC = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
		try
		{
			Task tailTask = Task.CompletedTask;
			bool tailingEnabled = progress != null && !string.IsNullOrWhiteSpace(logPath);
			if (tailingEnabled)
			{
				tailTask = rJi3hZp8N1(logPath, progress, CS_0024_003C_003E8__locals6.apUQONTpEC.Token);
			}
			using (cancellationToken.Register(delegate
			{
				try
				{
					CS_0024_003C_003E8__locals6.apUQONTpEC.Cancel();
				}
				catch
				{
				}
				try
				{
					Process process = vSsspFwDWu;
					if (process != null && !process.HasExited)
					{
						vSsspFwDWu.Kill(entireProcessTree: true);
					}
				}
				catch
				{
				}
			}))
			{
				int exitCode;
				try
				{
					Task waitTask = vSsspFwDWu.WaitForExitAsync(cancellationToken);
					if (timeoutMilliseconds > 0)
					{
						Task timeoutTask = Task.Delay(timeoutMilliseconds, cancellationToken);
						if (await Task.WhenAny(waitTask, timeoutTask).ConfigureAwait(continueOnCapturedContext: false) == timeoutTask)
						{
							try
							{
								vSsspFwDWu.Kill(entireProcessTree: true);
							}
							catch
							{
							}
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 1);
							defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(23032));
							defaultInterpolatedStringHandler.AppendFormatted(timeoutMilliseconds);
							defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(23108));
							throw new TimeoutException(defaultInterpolatedStringHandler.ToStringAndClear());
						}
					}
					await waitTask.ConfigureAwait(continueOnCapturedContext: false);
					exitCode = vSsspFwDWu.ExitCode;
				}
				finally
				{
					if (tailingEnabled)
					{
						try
						{
							await Task.Delay(250, CancellationToken.None).ConfigureAwait(continueOnCapturedContext: false);
						}
						catch
						{
						}
						try
						{
							CS_0024_003C_003E8__locals6.apUQONTpEC.Cancel();
						}
						catch
						{
						}
						try
						{
							await tailTask.ConfigureAwait(continueOnCapturedContext: false);
						}
						catch (OperationCanceledException)
						{
						}
					}
					vSsspFwDWu = null;
				}
				return exitCode;
			}
		}
		finally
		{
			if (CS_0024_003C_003E8__locals6.apUQONTpEC != null)
			{
				((IDisposable)CS_0024_003C_003E8__locals6.apUQONTpEC).Dispose();
			}
		}
	}

	private static async Task rJi3hZp8N1(string P_0, IProgress<string> P_1, CancellationToken P_2)
	{
		checked
		{
			for (int i = 0; i < 50; i++)
			{
				if (File.Exists(P_0))
				{
					break;
				}
				await Task.Delay(100, P_2);
			}
			if (!File.Exists(P_0))
			{
				return;
			}
			long position = 0L;
			string remainder = "";
			while (!P_2.IsCancellationRequested)
			{
				try
				{
					await using FileStream fs = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (position > fs.Length)
					{
						position = 0L;
					}
					fs.Seek(position, SeekOrigin.Begin);
					using StreamReader sr = new StreamReader(fs, Encoding.UTF8, detectEncodingFromByteOrderMarks: true);
					string text = await sr.ReadToEndAsync(P_2);
					position = fs.Position;
					if (!string.IsNullOrEmpty(text))
					{
						text = remainder + text;
						remainder = "";
						string[] array = text.Split(new string[2]
						{
							aL07ImwcwlxdnyfI30.olMQlwrxmw(23120),
							aL07ImwcwlxdnyfI30.olMQlwrxmw(23128)
						}, StringSplitOptions.None);
						if (!text.EndsWith(aL07ImwcwlxdnyfI30.olMQlwrxmw(23128)) && array.Length != 0)
						{
							remainder = array[^1];
							for (int j = 0; j < array.Length - 1; j++)
							{
								if (array[j].Length > 0)
								{
									P_1.Report(array[j]);
								}
							}
						}
						else
						{
							string[] array2 = array;
							foreach (string text2 in array2)
							{
								if (text2.Length > 0)
								{
									P_1.Report(text2);
								}
							}
						}
					}
				}
				catch
				{
				}
				await Task.Delay(250, P_2);
			}
		}
	}

	public SoftwareVersionsService()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
	}

	[CompilerGenerated]
	internal static int hys3zVxkvl(string P_0, ref _003C_003Ec__DisplayClass15_0 P_1)
	{
		if (!int.TryParse(P_0, NumberStyles.None, CultureInfo.InvariantCulture, out var result) || result < 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 3);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(14646));
			defaultInterpolatedStringHandler.AppendFormatted(P_1.rGKQ1mxMLX);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(14188));
			defaultInterpolatedStringHandler.AppendFormatted(P_1.WvoQrvS45y);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(14748));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(14100));
			throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return result;
	}
}
