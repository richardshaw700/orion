using System.Runtime.CompilerServices;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using GIToolkit.Services;
using GolfInLauncher.Messages;
using GolfInLauncher.Services;
using Lmttrs0IQc7UR7Zpt6;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.ViewModels;

public class ContainerViewModel : ObservableRecipient, IViewModel
{
	private ObservableRecipient QeIkTcicbW;

	private bool UhykYYb7hy;

	private string MdFkSeYWYq;

	private WindowStartupLocation rdvkNpoc5Z;

	private ResizeMode PpkkX1EQn1;

	private bool GNIk1Oli2w;

	private WindowStyle GqIkrx4q9K;

	private WindowState kPdk4x53J1;

	private readonly IMessagingService D5EkOYNvrF;

	private readonly ICircularLogService qnPk9MlZV0;

	public ObservableRecipient CurrentPage
	{
		get
		{
			return QeIkTcicbW;
		}
		set
		{
			SetProperty(ref QeIkTcicbW, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3000));
		}
	}

	public bool TopMost
	{
		get
		{
			return UhykYYb7hy;
		}
		set
		{
			SetProperty(ref UhykYYb7hy, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3026));
		}
	}

	public string Title
	{
		get
		{
			return MdFkSeYWYq;
		}
		set
		{
			SetProperty(ref MdFkSeYWYq, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3044));
		}
	}

	public WindowStartupLocation WindowStartupLocation
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return rdvkNpoc5Z;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			SetProperty(ref rdvkNpoc5Z, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3058));
		}
	}

	public ResizeMode ResizeMode
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return PpkkX1EQn1;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			SetProperty(ref PpkkX1EQn1, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3104));
		}
	}

	public bool AllowTransparency
	{
		get
		{
			return GNIk1Oli2w;
		}
		set
		{
			SetProperty(ref GNIk1Oli2w, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3128));
		}
	}

	public WindowStyle WindowStyle
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return GqIkrx4q9K;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			SetProperty(ref GqIkrx4q9K, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3166));
		}
	}

	public WindowState WindowState
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return kPdk4x53J1;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			SetProperty(ref kPdk4x53J1, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3192));
		}
	}

	public ContainerViewModel(IMessagingService messagingService, ICircularLogService circularLogService)
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
		D5EkOYNvrF = messagingService;
		qnPk9MlZV0 = circularLogService;
		D5EkOYNvrF.Register(this, delegate(object P_0, ObservableRecipient P_1)
		{
			CurrentPage = P_1;
		});
		D5EkOYNvrF.Register<SendContainerConfigMessage>(this, SetCurrentWindow);
		qnPk9MlZV0?.SetupLogFile(LauncherConstant.LauncherLogDirectoryPath, aL07ImwcwlxdnyfI30.olMQlwrxmw(3218), useTraceLoggingMethod: true, 30, 1048576L);
	}

	public void SetCurrentWindow(object obj, SendContainerConfigMessage message)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		TopMost = message.Arguments.TopMost;
		Title = message.Arguments.Title;
		ResizeMode = message.Arguments.ResizeMode;
		WindowStyle = message.Arguments.WindowStyle;
		WindowState = message.Arguments.WindowState;
	}

	[CompilerGenerated]
	private void N76k6R4rPC(object P_0, ObservableRecipient P_1)
	{
		CurrentPage = P_1;
	}
}
