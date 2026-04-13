using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GIToolkit.Model;
using GIToolkit.Services;
using GolfInLauncher.Messages;
using GolfInLauncher.Model;
using GolfInLauncher.Navigation;
using GolfInLauncher.Services;
using Golfin.Dtos;
using Lmttrs0IQc7UR7Zpt6;
using MahApps.Metro.Controls.Dialogs;
using Tree.Extensions;
using Tree.Structures;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.ViewModels;

public class MaintenanceViewModel : ObservableRecipient, IViewModel
{
	private ObservableCollection<SerializableCardLeaf> g4kkRcO5pB;

	private ObservableCollection<SerializableCardLeaf> QeGknkNdBN;

	private ObservableCollection<SerializableCardLeaf> KodkgbxB8K;

	private VerticalAlignment RJUko5RKpg;

	private bool nSOkh2tAH3;

	[CompilerGenerated]
	private CardStyle ufhkzOgPK9;

	private readonly INavigationService<ViewModelNavigationPages> JHU8pb1QJK;

	private readonly IMessagingService N0B8kWi4N7;

	private readonly ILauncherConfiguration oUC88XTk7C;

	private readonly IDialogCoordinator wMM8GS3i87;

	public ObservableCollection<SerializableCardLeaf> MaintenanceLauncherCardList
	{
		get
		{
			return g4kkRcO5pB;
		}
		set
		{
			SetProperty(ref g4kkRcO5pB, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3534));
		}
	}

	public ObservableCollection<SerializableCardLeaf> FirstRowLauncherCardList
	{
		get
		{
			return QeGknkNdBN;
		}
		set
		{
			SetProperty(ref QeGknkNdBN, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3592));
		}
	}

	public ObservableCollection<SerializableCardLeaf> SecondRowLauncherCardList
	{
		get
		{
			return KodkgbxB8K;
		}
		set
		{
			SetProperty(ref KodkgbxB8K, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3644));
		}
	}

	public VerticalAlignment FirstRowVerticalAlignment
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return RJUko5RKpg;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			SetProperty(ref RJUko5RKpg, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3698));
		}
	}

	public bool IsFrench
	{
		get
		{
			return nSOkh2tAH3;
		}
		set
		{
			SetProperty(ref nSOkh2tAH3, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3752));
		}
	}

	public CardStyle CardStyle
	{
		[CompilerGenerated]
		get
		{
			return ufhkzOgPK9;
		}
		[CompilerGenerated]
		set
		{
			ufhkzOgPK9 = value;
		}
	}

	public ICommand CloseCommand => new RelayCommand(delegate
	{
		JHU8pb1QJK.GoBack();
	});

	public MaintenanceViewModel(INavigationService<ViewModelNavigationPages> navigationService, ICultureHelper cultureHelper, IMessagingService messagingService, ILauncherConfiguration launcherConfiguration, IDialogCoordinator dialogCoordinator)
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		ufhkzOgPK9 = new CardStyle();
		base._002Ector();
		JHU8pb1QJK = navigationService;
		N0B8kWi4N7 = messagingService;
		oUC88XTk7C = launcherConfiguration;
		wMM8GS3i87 = dialogCoordinator;
		IsFrench = cultureHelper.GetCurrentLanguage() == Language.French;
		N0B8kWi4N7.Register(this, delegate(object P_0, OnLanguageChangeMessage P_1)
		{
			IsFrench = P_1.NewLanguage == Language.French;
		});
		N0B8kWi4N7.Register<RefreshAllChildList>(this, RefreshMaintenanceCardList);
		N0B8kWi4N7.Register<MaintenanceLaunchProgramMessage>(this, LaunchProgram);
	}

	public async void LaunchProgram(object obj, MaintenanceLaunchProgramMessage message)
	{
		ErrorCode errorCode = oUC88XTk7C.LaunchProgram(MaintenanceLauncherCardList.ToList(), message.ProgramName);
		if (!errorCode.Success)
		{
			await wMM8GS3i87.ShowMessageAsync(this, aL07ImwcwlxdnyfI30.olMQlwrxmw(1648), errorCode.ErrorMessage);
		}
	}

	public void RefreshMaintenanceCardList(object obj, RefreshAllChildList message)
	{
		List<SerializableCardLeaf> source = message.LauncherCardTree.Root.FindCardLeaves((SerializableCardLeaf x) => x.ParentCardName == ProgramName.Maintenance).ToList();
		MaintenanceLauncherCardList = new ObservableCollection<SerializableCardLeaf>(source.OrderBy((SerializableCardLeaf x) => x.Card.OrderToDisplay).ToList());
		int num = checked(MaintenanceLauncherCardList.Where((SerializableCardLeaf x) => x.Card.IsSoftwareAvailable).ToList().Count - 1);
		if (num > 0)
		{
			(int, int) tuple = GolfinUtils.GetPositionLists()[num];
			FirstRowVerticalAlignment = (VerticalAlignment)(tuple.Item2 == 0);
			FirstRowLauncherCardList = new ObservableCollection<SerializableCardLeaf>(MaintenanceLauncherCardList.Where((SerializableCardLeaf x) => x.Card.IsSoftwareAvailable).Take(tuple.Item1));
			SecondRowLauncherCardList = new ObservableCollection<SerializableCardLeaf>(MaintenanceLauncherCardList.Where((SerializableCardLeaf x) => x.Card.IsSoftwareAvailable).Reverse().Take(tuple.Item2)
				.Reverse());
		}
	}

	[CompilerGenerated]
	private void mKLktbRctn(object P_0, OnLanguageChangeMessage P_1)
	{
		IsFrench = P_1.NewLanguage == Language.French;
	}

	[CompilerGenerated]
	private void rIHkLgaNIO()
	{
		JHU8pb1QJK.GoBack();
	}
}
