using System;
using System.Text.RegularExpressions;

namespace SoftwareUpgradeLoadingScreen;

public sealed class ChocoOutputNormalizer
{
	private string? _lastProgressLine;

	private static readonly Regex ProgressRegex = new Regex("^(Progress|Downloading|Extracting|Installing|Verifying)", RegexOptions.IgnoreCase | RegexOptions.Compiled);

	private static readonly Regex ErrorRegex = new Regex("\\b(error|failed|exception)\\b", RegexOptions.IgnoreCase | RegexOptions.Compiled);

	public (string? text, bool isProgress) Normalize(string line)
	{
		if (string.IsNullOrWhiteSpace(line))
		{
			return (text: null, isProgress: false);
		}
		line = line.Trim();
		if (ErrorRegex.IsMatch(line))
		{
			_lastProgressLine = null;
			return (text: line, isProgress: false);
		}
		if (ProgressRegex.IsMatch(line))
		{
			if (string.Equals(line, _lastProgressLine, StringComparison.Ordinal))
			{
				return (text: null, isProgress: true);
			}
			_lastProgressLine = line;
			return (text: line, isProgress: true);
		}
		_lastProgressLine = null;
		return (text: line, isProgress: false);
	}
}
