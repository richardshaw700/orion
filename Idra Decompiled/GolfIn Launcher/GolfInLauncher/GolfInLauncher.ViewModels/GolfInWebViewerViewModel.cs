using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GIToolkit.Models;
using GIToolkit.Services;
using GolfInLauncher.Internationalization;
using GolfInLauncher.Messages;
using GolfInLauncher.Navigation;
using GolfInLauncher.Services;
using Golfin.Dtos;
using Lmttrs0IQc7UR7Zpt6;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.ViewModels;

public class GolfInWebViewerViewModel : ObservableRecipient, IViewModel, IDisposable
{
	private bool QfukmOvPnC;

	private bool RpjkIm95p8;

	private string WwMkEKFBI9;

	private GridLength n3nkfa4Vd6;

	private GridLength QpsklGc7Qy;

	private int bTxkiKd6Fq;

	private Uri P0nkP7Nf1N;

	private bool nZekJwhyEA;

	[CompilerGenerated]
	private bool XUDk7QZZi3;

	private readonly INavigationService<ViewModelNavigationPages> fWOkvsFC1P;

	private readonly ICultureHelper EBnkBVTmy9;

	private readonly IMessagingService Y63kWapV3N;

	private readonly IDialogCoordinator kPSkMTngMe;

	private LauncherCard yhdkFZKVUj;

	private WebView2 rJekUq6pAk;

	public bool ShowBrowser
	{
		get
		{
			return QfukmOvPnC;
		}
		set
		{
			SetProperty(ref QfukmOvPnC, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3230));
		}
	}

	public bool ShowDocument
	{
		get
		{
			return RpjkIm95p8;
		}
		set
		{
			SetProperty(ref RpjkIm95p8, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3256));
		}
	}

	public string PDFFile
	{
		get
		{
			return WwMkEKFBI9;
		}
		set
		{
			SetProperty(ref WwMkEKFBI9, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3284));
		}
	}

	public GridLength DocumentColWidth
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return n3nkfa4Vd6;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			SetProperty(ref n3nkfa4Vd6, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3302));
		}
	}

	public GridLength VideoColWidth
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return QpsklGc7Qy;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			SetProperty(ref QpsklGc7Qy, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3338));
		}
	}

	public int BtnHomeCol
	{
		get
		{
			return bTxkiKd6Fq;
		}
		set
		{
			SetProperty(ref bTxkiKd6Fq, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3368));
		}
	}

	public Uri MediaPlayerSource
	{
		get
		{
			return P0nkP7Nf1N;
		}
		set
		{
			SetProperty(ref P0nkP7Nf1N, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3392));
		}
	}

	public bool ShowVideo
	{
		get
		{
			return nZekJwhyEA;
		}
		set
		{
			SetProperty(ref nZekJwhyEA, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3430));
		}
	}

	public bool IsDocument
	{
		[CompilerGenerated]
		get
		{
			return XUDk7QZZi3;
		}
		[CompilerGenerated]
		set
		{
			XUDk7QZZi3 = value;
		}
	}

	public ICommand WindowLoadCommand => new AsyncRelayCommand<WebView2>(async delegate(WebView2 P_0)
	{
		rJekUq6pAk = P_0;
		if (ShowBrowser && sHlkAv94JU(yhdkFZKVUj))
		{
			try
			{
				string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), aL07ImwcwlxdnyfI30.olMQlwrxmw(12368), aL07ImwcwlxdnyfI30.olMQlwrxmw(17062));
				Directory.CreateDirectory(text);
				CoreWebView2EnvironmentOptions options = new CoreWebView2EnvironmentOptions();
				CoreWebView2Environment environment = await CoreWebView2Environment.CreateAsync(null, text, options);
				await rJekUq6pAk.EnsureCoreWebView2Async(environment);
				rJekUq6pAk.CoreWebView2.NewWindowRequested += HbSkDGANJi;
				rJekUq6pAk.Source = new Uri((EBnkBVTmy9.GetCurrentLanguage() == Language.French) ? yhdkFZKVUj.RelativeWebFilePathFR : yhdkFZKVUj.RelativeWebFilePathEN);
			}
			catch (Exception ex)
			{
				await kPSkMTngMe.ShowMessageAsync(this, Resources.WarningText, aL07ImwcwlxdnyfI30.olMQlwrxmw(17082) + ex.Message);
			}
		}
	});

	public ICommand OpenKeyboard => new AsyncRelayCommand((Func<Task>)async delegate
	{
		try
		{
			await Task.Run(delegate
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
				defaultInterpolatedStringHandler.AppendFormatted(Environment.GetFolderPath(Environment.SpecialFolder.System));
				defaultInterpolatedStringHandler.AppendFormatted(Path.DirectorySeparatorChar);
				defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(6928));
				Process.Start(new ProcessStartInfo(defaultInterpolatedStringHandler.ToStringAndClear())
				{
					UseShellExecute = true,
					Verb = aL07ImwcwlxdnyfI30.olMQlwrxmw(6946)
				});
			});
		}
		catch (Exception ex)
		{
			_ = ex;
			await kPSkMTngMe.ShowMessageAsync(this, Resources.WarningText, aL07ImwcwlxdnyfI30.olMQlwrxmw(16996));
		}
	});

	public ICommand BackCommand => new RelayCommand<WebView2>(delegate(WebView2 P_0)
	{
		if (P_0 != null && P_0.CanGoBack)
		{
			P_0.GoBack();
		}
		else
		{
			fWOkvsFC1P.GoBack();
		}
	});

	public ICommand CloseCommand => new RelayCommand(delegate
	{
		fWOkvsFC1P.NavigateTo(ViewModelNavigationPages.Main);
	});

	public GolfInWebViewerViewModel(INavigationService<ViewModelNavigationPages> navigationService, ICultureHelper cultureHelper, IMessagingService messagingService, IDialogCoordinator dialogCoordinator)
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
		fWOkvsFC1P = navigationService;
		EBnkBVTmy9 = cultureHelper;
		Y63kWapV3N = messagingService;
		kPSkMTngMe = dialogCoordinator;
		Environment.SetEnvironmentVariable(aL07ImwcwlxdnyfI30.olMQlwrxmw(3452), aL07ImwcwlxdnyfI30.olMQlwrxmw(3522));
		Y63kWapV3N.Register(this, async delegate(object P_0, ShowWebAssociatedWithCardMessage P_1)
		{
			await LoadedView(P_1);
		});
	}

	public void InitializeView()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		BtnHomeCol = 1;
		VideoColWidth = new GridLength(1.0, (GridUnitType)2);
		DocumentColWidth = new GridLength(1.0, (GridUnitType)2);
		ShowVideo = true;
		ShowDocument = true;
	}

	public async Task LoadedView(ShowWebAssociatedWithCardMessage message)
	{
		InitializeView();
		yhdkFZKVUj = message.Card;
		HandleDocument(yhdkFZKVUj);
		HandleVideo(yhdkFZKVUj);
	}

	public void HandleDocument(LauncherCard card)
	{
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrWhiteSpace(card.FileNameWithExtension) || !string.IsNullOrWhiteSpace(card.RelativeWebFilePathFR))
		{
			if (!string.IsNullOrWhiteSpace(card.FileNameWithExtension) && !string.IsNullOrWhiteSpace(card.RelativeWebFilePathFR))
			{
				IsDocument = true;
				PDFFile = EBnkBVTmy9.GetCurrentLanguage() switch
				{
					Language.French => GIConstant.PathToFRDocuments + aL07ImwcwlxdnyfI30.olMQlwrxmw(3528) + card.FileNameWithExtension, 
					Language.English => GIConstant.PathToENDocuments + aL07ImwcwlxdnyfI30.olMQlwrxmw(3528) + card.FileNameWithExtension, 
					_ => GIConstant.PathToENDocuments + aL07ImwcwlxdnyfI30.olMQlwrxmw(3528) + card.FileNameWithExtension, 
				};
				ShowDocument = true;
				ShowBrowser = false;
			}
			else
			{
				ShowBrowser = true;
				IsDocument = false;
				ShowDocument = false;
				PDFFile = string.Empty;
			}
		}
		else
		{
			ShowDocument = false;
			DocumentColWidth = new GridLength(0.0);
			BtnHomeCol = 0;
		}
	}

	public void HandleVideo(LauncherCard card)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrWhiteSpace(card.VideoNameWithExtension) || !string.IsNullOrWhiteSpace(card.RelativeWebVideoPath))
		{
			ShowVideo = true;
			string uriString = string.Empty;
			if (!string.IsNullOrWhiteSpace(card.RelativeWebVideoPath))
			{
				uriString = card.RelativeWebVideoPath;
			}
			if (!string.IsNullOrWhiteSpace(card.VideoNameWithExtension))
			{
				uriString = GIConstant.PathToGolfInFolder + aL07ImwcwlxdnyfI30.olMQlwrxmw(3528) + card.VideoNameWithExtension;
			}
			MediaPlayerSource = new Uri(uriString);
		}
		else
		{
			ShowVideo = false;
			MediaPlayerSource = null;
			VideoColWidth = new GridLength(0.0);
		}
	}

	public void Dispose()
	{
		if (rJekUq6pAk != null)
		{
			((HwndHost)rJekUq6pAk).Dispose();
		}
	}

	private bool sHlkAv94JU(LauncherCard P_0)
	{
		if (string.IsNullOrWhiteSpace(yhdkFZKVUj.RelativeWebFilePathEN) || EBnkBVTmy9.GetCurrentLanguage() != Language.English)
		{
			if (!string.IsNullOrWhiteSpace(yhdkFZKVUj.RelativeWebFilePathFR))
			{
				return EBnkBVTmy9.GetCurrentLanguage() == Language.French;
			}
			return false;
		}
		return true;
	}

	private void HbSkDGANJi(object? sender, CoreWebView2NewWindowRequestedEventArgs P_1)
	{
		P_1.Handled = true;
		rJekUq6pAk.Source = new Uri(P_1.Uri);
	}

	[CompilerGenerated]
	private async void qxgkaxlKR0(object P_0, ShowWebAssociatedWithCardMessage P_1)
	{
		await LoadedView(P_1);
	}

	[CompilerGenerated]
	private async Task XXNkuIsuga(WebView2 P_0)
	{
		rJekUq6pAk = P_0;
		if (ShowBrowser && sHlkAv94JU(yhdkFZKVUj))
		{
			try
			{
				string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), aL07ImwcwlxdnyfI30.olMQlwrxmw(12368), aL07ImwcwlxdnyfI30.olMQlwrxmw(17062));
				Directory.CreateDirectory(text);
				CoreWebView2EnvironmentOptions options = new CoreWebView2EnvironmentOptions();
				CoreWebView2Environment environment = await CoreWebView2Environment.CreateAsync(null, text, options);
				await rJekUq6pAk.EnsureCoreWebView2Async(environment);
				rJekUq6pAk.CoreWebView2.NewWindowRequested += HbSkDGANJi;
				rJekUq6pAk.Source = new Uri((EBnkBVTmy9.GetCurrentLanguage() == Language.French) ? yhdkFZKVUj.RelativeWebFilePathFR : yhdkFZKVUj.RelativeWebFilePathEN);
			}
			catch (Exception ex)
			{
				await kPSkMTngMe.ShowMessageAsync(this, Resources.WarningText, aL07ImwcwlxdnyfI30.olMQlwrxmw(17082) + ex.Message);
			}
		}
	}

	[CompilerGenerated]
	private async Task jaEkKPXXEu()
	{
		try
		{
			await Task.Run(delegate
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
				defaultInterpolatedStringHandler.AppendFormatted(Environment.GetFolderPath(Environment.SpecialFolder.System));
				defaultInterpolatedStringHandler.AppendFormatted(Path.DirectorySeparatorChar);
				defaultInterpolatedStringHandler.AppendLiteral(aL07ImwcwlxdnyfI30.olMQlwrxmw(6928));
				Process.Start(new ProcessStartInfo(defaultInterpolatedStringHandler.ToStringAndClear())
				{
					UseShellExecute = true,
					Verb = aL07ImwcwlxdnyfI30.olMQlwrxmw(6946)
				});
			});
		}
		catch (Exception ex)
		{
			_ = ex;
			await kPSkMTngMe.ShowMessageAsync(this, Resources.WarningText, aL07ImwcwlxdnyfI30.olMQlwrxmw(16996));
		}
	}

	[CompilerGenerated]
	private void sD1k2io9yZ(WebView2 P_0)
	{
		if (P_0 != null && P_0.CanGoBack)
		{
			P_0.GoBack();
		}
		else
		{
			fWOkvsFC1P.GoBack();
		}
	}

	[CompilerGenerated]
	private void hOfkj2iWiB()
	{
		fWOkvsFC1P.NavigateTo(ViewModelNavigationPages.Main);
	}
}
