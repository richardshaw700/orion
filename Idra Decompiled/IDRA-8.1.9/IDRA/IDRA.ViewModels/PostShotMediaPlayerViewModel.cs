#define TRACE
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GICTS.Core;
using GICTSCore.Data;
using GIToolkit.Services;
using GhU84wwqvI4UZ3pBfu;
using IDRA.Auxiliary.Helpers;
using Unosquare.FFME;
using Unosquare.FFME.Common;
using sxB8TYTZ87aKuujytY;

namespace IDRA.ViewModels;

public class PostShotMediaPlayerViewModel : ObservableObject, IViewModel, IDisposable
{
	private string dDXHZLnlqF;

	private string FsGHlwhelj;

	private MediaElement qr3HkiKg8m;

	private readonly AsyncManualResetEvent zkjH2Etyej;

	private readonly SemaphoreSlim ywdHyDWux6;

	private readonly IGICTSDirector NjZHgfCGp0;

	public string PlayPauseImage
	{
		get
		{
			return dDXHZLnlqF;
		}
		set
		{
			SetProperty(ref dDXHZLnlqF, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(5656));
		}
	}

	public string FastSlowImage
	{
		get
		{
			return FsGHlwhelj;
		}
		set
		{
			SetProperty(ref FsGHlwhelj, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(5688));
		}
	}

	public MediaElement MediaElement
	{
		get
		{
			return qr3HkiKg8m;
		}
		set
		{
			SetProperty(ref qr3HkiKg8m, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(5718));
		}
	}

	public ICommand FastSlowCommand => new RelayCommand(delegate
	{
		if (MediaElement == null)
		{
			return;
		}
		ywdHyDWux6.Wait();
		try
		{
			MediaElement.SpeedRatio = ((MediaElement.SpeedRatio == 1.0) ? 0.25 : 1.0);
			W9VHuiuXpB();
		}
		finally
		{
			ywdHyDWux6.Release();
		}
	});

	public ICommand PlayPauseCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		if (MediaElement == null)
		{
			return;
		}
		await ywdHyDWux6.WaitAsync();
		try
		{
			switch (MediaElement.MediaState)
			{
			case MediaPlaybackState.Play:
				await MediaElement.Pause();
				break;
			case MediaPlaybackState.Pause:
			case MediaPlaybackState.Stop:
				await MediaElement.Play();
				break;
			}
			W9VHuiuXpB();
		}
		finally
		{
			ywdHyDWux6.Release();
		}
	});

	[SpecialName]
	private int FHkHrcXFiM()
	{
		return checked((int)TimeSpan.FromSeconds(15.0).TotalMilliseconds);
	}

	public PostShotMediaPlayerViewModel(IGICTSDirector gICTSDirector)
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		dDXHZLnlqF = QQXBLjLprwI58ya4VR.y8v8TMFOCb(5746);
		FsGHlwhelj = QQXBLjLprwI58ya4VR.y8v8TMFOCb(5912);
		zkjH2Etyej = new AsyncManualResetEvent();
		ywdHyDWux6 = new SemaphoreSlim(1, 1);
		base._002Ector();
		NjZHgfCGp0 = gICTSDirector;
	}

	public void ListenOnPostShotEvent(bool listenOnPostShotVideo)
	{
		IGICTSDirector njZHgfCGp = NjZHgfCGp0;
		njZHgfCGp.OnPostShotVideoExported = (Func<string, int, Task>)Delegate.Remove(njZHgfCGp.OnPostShotVideoExported, new Func<string, int, Task>(A0EHJLREXt));
		if (listenOnPostShotVideo)
		{
			IGICTSDirector njZHgfCGp2 = NjZHgfCGp0;
			njZHgfCGp2.OnPostShotVideoExported = (Func<string, int, Task>)Delegate.Combine(njZHgfCGp2.OnPostShotVideoExported, new Func<string, int, Task>(A0EHJLREXt));
		}
		else
		{
			zkjH2Etyej.Reset();
		}
	}

	public async Task ClosePostShotVideo()
	{
		zkjH2Etyej?.Reset();
		if (MediaElement != null)
		{
			MediaElement.MediaEnded -= PJHHmHuTlS;
			await MediaElement.Close();
			MediaElement?.Dispose();
			MediaElement = null;
		}
	}

	public async Task InitializeDependencyUIElement(MediaElement mediaElement)
	{
		await ywdHyDWux6.WaitAsync();
		try
		{
			MediaElement = mediaElement;
			MediaElement.MediaEnded += PJHHmHuTlS;
			zkjH2Etyej.Set();
		}
		finally
		{
			ywdHyDWux6.Release();
		}
	}

	public async Task OpenMediaPlayerPostShotVideo()
	{
		try
		{
			await ((DispatcherObject)Application.Current).Dispatcher.InvokeAsync<Task>((Func<Task>)async delegate
			{
				if (MediaElement != null)
				{
					if (MediaElement.CanPause)
					{
						await MediaElement.Close();
					}
					await MediaElement.Open(new Uri(IDRAConstant.GICTSSamplePostShotVideo));
					await MediaElement.Play();
					W9VHuiuXpB();
				}
			});
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
		}
	}

	private async void PJHHmHuTlS(object P_0, EventArgs P_1)
	{
		await ywdHyDWux6.WaitAsync();
		try
		{
			await MediaElement.Stop();
			await MediaElement.Play();
		}
		finally
		{
			ywdHyDWux6.Release();
		}
	}

	private void W9VHuiuXpB()
	{
		MediaElement mediaElement = MediaElement;
		FastSlowImage = ((mediaElement != null && mediaElement.SpeedRatio == 1.0) ? QQXBLjLprwI58ya4VR.y8v8TMFOCb(6092) : QQXBLjLprwI58ya4VR.y8v8TMFOCb(5912));
		MediaElement mediaElement2 = MediaElement;
		PlayPauseImage = ((mediaElement2 != null && mediaElement2.MediaState == MediaPlaybackState.Play) ? QQXBLjLprwI58ya4VR.y8v8TMFOCb(6268) : QQXBLjLprwI58ya4VR.y8v8TMFOCb(5746));
	}

	private async Task A0EHJLREXt(string P_0, int P_1)
	{
		if (!(await zkjH2Etyej.WaitAsync(FHkHrcXFiM())))
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 1);
			defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(14592));
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now);
			defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(14598));
			Trace.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
			return;
		}
		await ywdHyDWux6.WaitAsync();
		try
		{
			await OpenMediaPlayerPostShotVideo();
		}
		finally
		{
			ywdHyDWux6.Release();
		}
	}

	public void Dispose()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		IGICTSDirector njZHgfCGp = NjZHgfCGp0;
		njZHgfCGp.OnPostShotVideoExported = (Func<string, int, Task>)Delegate.Remove(njZHgfCGp.OnPostShotVideoExported, new Func<string, int, Task>(A0EHJLREXt));
		if (MediaElement != null)
		{
			MediaElement.MediaEnded -= PJHHmHuTlS;
			((DispatcherOperation)((DispatcherObject)Application.Current).Dispatcher.InvokeAsync<Task>((Func<Task>)async delegate
			{
				await MediaElement.Stop();
				await MediaElement.Close();
			})).Wait();
		}
		ywdHyDWux6?.Dispose();
		GC.SuppressFinalize(this);
	}

	[CompilerGenerated]
	private void i0xHOVbPj7()
	{
		if (MediaElement == null)
		{
			return;
		}
		ywdHyDWux6.Wait();
		try
		{
			MediaElement.SpeedRatio = ((MediaElement.SpeedRatio == 1.0) ? 0.25 : 1.0);
			W9VHuiuXpB();
		}
		finally
		{
			ywdHyDWux6.Release();
		}
	}

	[CompilerGenerated]
	private async Task NcoHMvwfIG()
	{
		if (MediaElement == null)
		{
			return;
		}
		await ywdHyDWux6.WaitAsync();
		try
		{
			switch (MediaElement.MediaState)
			{
			case MediaPlaybackState.Play:
				await MediaElement.Pause();
				break;
			case MediaPlaybackState.Pause:
			case MediaPlaybackState.Stop:
				await MediaElement.Play();
				break;
			}
			W9VHuiuXpB();
		}
		finally
		{
			ywdHyDWux6.Release();
		}
	}

	[CompilerGenerated]
	private async Task peGHPQ40Zj()
	{
		if (MediaElement != null)
		{
			if (MediaElement.CanPause)
			{
				await MediaElement.Close();
			}
			await MediaElement.Open(new Uri(IDRAConstant.GICTSSamplePostShotVideo));
			await MediaElement.Play();
			W9VHuiuXpB();
		}
	}

	[CompilerGenerated]
	private async Task HnLHcYVRi9()
	{
		await MediaElement.Stop();
		await MediaElement.Close();
	}
}
