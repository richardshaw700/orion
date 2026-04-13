using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GIToolkit.Model;
using GIToolkit.Models;
using GIToolkit.Services;
using GolfInLauncher.Messages;
using GolfInLauncher.Model;
using GolfInLauncher.Navigation;
using GolfInLauncher.Services;
using GolfInLauncher.Services.SoftwareUpdate;
using Golfin.Dtos;
using Lmttrs0IQc7UR7Zpt6;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.IdentityModel.Tokens;
using Tree.Extensions;
using Tree.Structures;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.ViewModels;

public class SupportViewModel : ObservableRecipient, IViewModel
{
	public sealed class LauncherTileItem : ObservableObject
	{
		[CompilerGenerated]
		private readonly SerializableCardLeaf K225VRxwCX;

		private bool euP5wVoMvD;

		public SerializableCardLeaf Leaf
		{
			[CompilerGenerated]
			get
			{
				return K225VRxwCX;
			}
		}

		public LauncherCard Card => Leaf.Card;

		public bool HasUpdate
		{
			get
			{
				return euP5wVoMvD;
			}
			set
			{
				SetProperty(ref euP5wVoMvD, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(17160));
			}
		}

		public LauncherTileItem(SerializableCardLeaf leaf, bool hasUpdate = false)
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
			K225VRxwCX = leaf ?? throw new ArgumentNullException(aL07ImwcwlxdnyfI30.olMQlwrxmw(17148));
			euP5wVoMvD = hasUpdate;
		}
	}

	private ObservableCollection<LauncherTileItem> K9PZxibTWn;

	private ObservableCollection<LauncherTileItem> EfNZH3ZniD;

	private ObservableCollection<LauncherTileItem> NwlZc9dF9M;

	private VerticalAlignment C2FZekTJGe;

	private bool cawZbAnFc2;

	[CompilerGenerated]
	private CardStyle tSEZV3jH9T;

	private readonly INavigationService<ViewModelNavigationPages> s0uZwJfxwa;

	private readonly IMessagingService BhkZ0gHlf6;

	private readonly ILauncherConfiguration YxmZChhfCd;

	private readonly IDialogCoordinator JIsZdERlCC;

	private readonly IProcessHelper ywNZyMdX6D;

	private readonly ILauncherSettings yxqZ6MstqD;

	public ObservableCollection<LauncherTileItem> SupportLauncherCardList
	{
		get
		{
			return K9PZxibTWn;
		}
		set
		{
			SetProperty(ref K9PZxibTWn, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(6522));
		}
	}

	public ObservableCollection<LauncherTileItem> FirstRowLauncherCardList
	{
		get
		{
			return EfNZH3ZniD;
		}
		set
		{
			SetProperty(ref EfNZH3ZniD, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3592));
		}
	}

	public ObservableCollection<LauncherTileItem> SecondRowLauncherCardList
	{
		get
		{
			return NwlZc9dF9M;
		}
		set
		{
			SetProperty(ref NwlZc9dF9M, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3644));
		}
	}

	public VerticalAlignment FirstRowVerticalAlignment
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return C2FZekTJGe;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			SetProperty(ref C2FZekTJGe, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3698));
		}
	}

	public bool IsFrench
	{
		get
		{
			return cawZbAnFc2;
		}
		set
		{
			SetProperty(ref cawZbAnFc2, value, aL07ImwcwlxdnyfI30.olMQlwrxmw(3752));
		}
	}

	public CardStyle CardStyle
	{
		[CompilerGenerated]
		get
		{
			return tSEZV3jH9T;
		}
		[CompilerGenerated]
		set
		{
			tSEZV3jH9T = value;
		}
	}

	public ICommand CloseCommand => new RelayCommand(delegate
	{
		s0uZwJfxwa.NavigateTo(ViewModelNavigationPages.Main);
	});

	public ICommand OpenWifiPanelCommand => new RelayCommand(delegate
	{
		s0uZwJfxwa.NavigateTo(ViewModelNavigationPages.Wifi);
	});

	public ICommand OpenTeamViewerCommand => new RelayCommand(delegate
	{
		BhkZ0gHlf6.Send(new RedirectToView(ViewModelNavigationPages.Support));
		s0uZwJfxwa.NavigateTo(ViewModelNavigationPages.Password);
	});

	public SupportViewModel(INavigationService<ViewModelNavigationPages> navigationService, ICultureHelper cultureHelper, IMessagingService messagingService, ILauncherConfiguration launcherConfiguration, IDialogCoordinator dialogCoordinator, IProcessHelper processHelper, ILauncherSettings launcherSettings)
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		tSEZV3jH9T = new CardStyle();
		base._002Ector();
		s0uZwJfxwa = navigationService;
		BhkZ0gHlf6 = messagingService;
		YxmZChhfCd = launcherConfiguration;
		JIsZdERlCC = dialogCoordinator;
		ywNZyMdX6D = processHelper;
		yxqZ6MstqD = launcherSettings;
		IsFrench = cultureHelper.GetCurrentLanguage() == Language.French;
		BhkZ0gHlf6.Register(this, delegate(object P_0, OnLanguageChangeMessage P_1)
		{
			IsFrench = P_1.NewLanguage == Language.French;
		});
		BhkZ0gHlf6.Register<RefreshAllChildList>(this, RefreshSupportCardList);
		BhkZ0gHlf6.Register<SupportLaunchProgramMessage>(this, LaunchProgram);
	}

	public async void LaunchProgram(object param, SupportLaunchProgramMessage message)
	{
		if (message.ProgramName == ProgramName.Maintenance)
		{
			s0uZwJfxwa.NavigateTo(ViewModelNavigationPages.Maintenance);
			return;
		}
		if (message.ProgramName == ProgramName.RestartComputer)
		{
			ywNZyMdX6D.AutoResetPC(underCondition: true);
			return;
		}
		if (message.ProgramName == ProgramName.SoftwareUpdate)
		{
			if (!yxqZ6MstqD.CustomerPin.IsNullOrEmpty())
			{
				BhkZ0gHlf6.Send(new RedirectToView(ViewModelNavigationPages.SoftwareUpdates));
				s0uZwJfxwa.NavigateTo(ViewModelNavigationPages.Password);
			}
			else
			{
				s0uZwJfxwa.NavigateTo(ViewModelNavigationPages.SoftwareUpdates);
			}
			return;
		}
		if (message.ProgramName == ProgramName.Calibration)
		{
			if (!yxqZ6MstqD.CustomerPin.IsNullOrEmpty())
			{
				BhkZ0gHlf6.Send(new RedirectToView(ViewModelNavigationPages.Calibration));
				s0uZwJfxwa.NavigateTo(ViewModelNavigationPages.Password);
			}
			else
			{
				BhkZ0gHlf6.Send(new CloseAndStartCalibrationMessage(100));
			}
			return;
		}
		List<SerializableCardLeaf> fromList = SupportLauncherCardList?.Select((LauncherTileItem x) => x.Leaf).ToList() ?? new List<SerializableCardLeaf>();
		ErrorCode errorCode = YxmZChhfCd.LaunchProgram(fromList, message.ProgramName);
		if (!errorCode.Success)
		{
			await JIsZdERlCC.ShowMessageAsync(this, aL07ImwcwlxdnyfI30.olMQlwrxmw(1648), errorCode.ErrorMessage);
		}
	}

	public async void RefreshSupportCardList(object param, RefreshAllChildList message)
	{
		List<SerializableCardLeaf> list = message.LauncherCardTree.Root.FindCardLeaves((SerializableCardLeaf x) => x.ParentCardName == ProgramName.Support).ToList();
		SerializableCardLeaf item = rc6ZG4YySR();
		list.Add(item);
		SerializableCardLeaf item2 = zbGZZr1s6y();
		list.Add(item2);
		List<LauncherTileItem> list2 = (from leaf in list
			orderby leaf.Card.OrderToDisplay
			select new LauncherTileItem(leaf)).ToList();
		SupportLauncherCardList = new ObservableCollection<LauncherTileItem>(list2);
		int index = checked(SupportLauncherCardList.Where((LauncherTileItem x) => x.Card.IsSoftwareAvailable).ToList().Count - 1);
		(int, int) tuple = GolfinUtils.GetPositionLists()[index];
		FirstRowVerticalAlignment = (VerticalAlignment)(tuple.Item2 == 0);
		FirstRowLauncherCardList = new ObservableCollection<LauncherTileItem>(SupportLauncherCardList.Where((LauncherTileItem x) => x.Card.IsSoftwareAvailable).Take(tuple.Item1));
		SecondRowLauncherCardList = new ObservableCollection<LauncherTileItem>(SupportLauncherCardList.Where((LauncherTileItem x) => x.Card.IsSoftwareAvailable).Reverse().Take(tuple.Item2)
			.Reverse());
		LauncherTileItem launcherTileItem = SupportLauncherCardList.FirstOrDefault((LauncherTileItem x) => x.Card.Name == ProgramName.SoftwareUpdate);
		if (launcherTileItem != null)
		{
			LauncherTileItem launcherTileItem2 = launcherTileItem;
			launcherTileItem2.HasUpdate = await WiRZ3NQVoC();
		}
	}

	private SerializableCardLeaf rc6ZG4YySR()
	{
		return new SerializableCardLeaf
		{
			Card = new LauncherCard
			{
				DisplayName = aL07ImwcwlxdnyfI30.olMQlwrxmw(6572),
				DisplayNameFR = aL07ImwcwlxdnyfI30.olMQlwrxmw(6606),
				IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(6632),
				Name = ProgramName.SoftwareUpdate,
				OrderToDisplay = -1,
				IsSoftwareAvailable = true
			},
			ParentCardName = ProgramName.Support
		};
	}

	private SerializableCardLeaf zbGZZr1s6y()
	{
		return new SerializableCardLeaf
		{
			Card = new LauncherCard
			{
				DisplayName = aL07ImwcwlxdnyfI30.olMQlwrxmw(6696),
				DisplayNameFR = aL07ImwcwlxdnyfI30.olMQlwrxmw(6696),
				IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(6732),
				Name = ProgramName.Calibration,
				OrderToDisplay = -1,
				IsSoftwareAvailable = true
			},
			ParentCardName = ProgramName.Support
		};
	}

	private async Task<bool> WiRZ3NQVoC()
	{
		return await SoftwareVersionsService.HasAnyNewVersionAvailableAsync(yxqZ6MstqD.LaunchOptions == LaunchOptions.UseRemoteInvoiceSoftware);
	}

	[CompilerGenerated]
	private void OTiZsasltn(object P_0, OnLanguageChangeMessage P_1)
	{
		IsFrench = P_1.NewLanguage == Language.French;
	}

	[CompilerGenerated]
	private void oF7ZqjidCE()
	{
		s0uZwJfxwa.NavigateTo(ViewModelNavigationPages.Main);
	}

	[CompilerGenerated]
	private void UZCZ5CmY3V()
	{
		s0uZwJfxwa.NavigateTo(ViewModelNavigationPages.Wifi);
	}

	[CompilerGenerated]
	private void fNoZQncIIh()
	{
		BhkZ0gHlf6.Send(new RedirectToView(ViewModelNavigationPages.Support));
		s0uZwJfxwa.NavigateTo(ViewModelNavigationPages.Password);
	}
}
