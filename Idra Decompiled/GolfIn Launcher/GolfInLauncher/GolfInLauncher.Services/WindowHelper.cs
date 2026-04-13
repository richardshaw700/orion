using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using GIToolkit.Services;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Services;

public class WindowHelper : IWindowHelper, IService
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0<T> where T : Window
	{
		public string name;

		public _003C_003Ec__DisplayClass0_0()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal bool HFJQ8ePgcD(T w)
		{
			return ((Window)w).Title.Equals(name);
		}
	}

	public bool IsWindowOpen<T>(string name = "") where T : Window
	{
		_003C_003Ec__DisplayClass0_0<T> CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass0_0<T>();
		CS_0024_003C_003E8__locals3.name = name;
		if (!string.IsNullOrEmpty(CS_0024_003C_003E8__locals3.name))
		{
			return ((IEnumerable)Application.Current.Windows).OfType<T>().Any((T w) => ((Window)w).Title.Equals(CS_0024_003C_003E8__locals3.name));
		}
		return ((IEnumerable)Application.Current.Windows).OfType<T>().Any();
	}

	public WindowHelper()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
	}
}
