using System.Text.RegularExpressions;
using Lmttrs0IQc7UR7Zpt6;
using U9xbeMdbyr6Pactctj;

public sealed class ChocoOutputNormalizer
{
	private string? DJh8M9fKe;

	private static readonly Regex DjFGwR8Rc;

	private static readonly Regex i8WZKihZR;

	public (string? text, bool isProgress) Normalize(string line)
	{
		if (string.IsNullOrWhiteSpace(line))
		{
			return (text: null, isProgress: false);
		}
		line = line.Trim();
		if (i8WZKihZR.IsMatch(line))
		{
			return (text: line, isProgress: false);
		}
		if (DjFGwR8Rc.IsMatch(line))
		{
			string text = FmcklLyfb(line);
			if (text == DJh8M9fKe)
			{
				return (text: null, isProgress: true);
			}
			DJh8M9fKe = text;
			return (text: line, isProgress: true);
		}
		DJh8M9fKe = null;
		return (text: line, isProgress: false);
	}

	private static string FmcklLyfb(string P_0)
	{
		return Regex.Replace(P_0, aL07ImwcwlxdnyfI30.olMQlwrxmw(0), "", RegexOptions.Compiled).Trim().ToLowerInvariant();
	}

	public ChocoOutputNormalizer()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
	}

	static ChocoOutputNormalizer()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		DjFGwR8Rc = new Regex(aL07ImwcwlxdnyfI30.olMQlwrxmw(14), RegexOptions.IgnoreCase | RegexOptions.Compiled);
		i8WZKihZR = new Regex(aL07ImwcwlxdnyfI30.olMQlwrxmw(128), RegexOptions.IgnoreCase | RegexOptions.Compiled);
	}
}
