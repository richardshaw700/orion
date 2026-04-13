using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using GIToolkit.Model;
using GIToolkit.Models;
using GIToolkit.Services;
using GolfInLauncher.Messages;
using GolfInLauncher.Navigation;
using GolfInLauncher.Services.SoftwareUpdate;
using Golfin.Dtos;
using Lmttrs0IQc7UR7Zpt6;
using MahApps.Metro.Controls.Dialogs;
using Tree.Extensions;
using Tree.Structures;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Services;

public class LauncherConfiguration : ILauncherConfiguration, IService
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public SerializableCardLeaf zxr5okP8Qt;

		public _003C_003Ec__DisplayClass12_0()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal void TgA5grIYk9(SerializableCardLeaf card)
		{
			if (card.Card.Name == zxr5okP8Qt.ParentCardName)
			{
				if (card.Children == null)
				{
					card.Children = new List<SerializableCardLeaf>();
				}
				card.Children.Add(zxr5okP8Qt);
			}
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_1
	{
		public SerializableCardLeaf hxj5zGqe3Y;

		public _003C_003Ec__DisplayClass12_1()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal void R4C5hMkGeL(SerializableCardLeaf card)
		{
			if (card.Card.Name == hxj5zGqe3Y.ParentCardName)
			{
				card.Children.Remove(hxj5zGqe3Y);
			}
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public string tleQkZTIfd;

		public _003C_003Ec__DisplayClass14_0()
		{
			lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
			base._002Ector();
		}

		internal bool hCtQpkKy5Y(SerializableCardLeaf x)
		{
			return x.Card.Name == tleQkZTIfd;
		}
	}

	private readonly IGIEnvironnement ImC306DgBE;

	private readonly IIOHelper U5k3CxPSnW;

	private readonly ILauncherServices Q3X3dp4rfA;

	private readonly IJsonHelper SsQ3yE96nT;

	private readonly ICultureHelper Of936hjKYv;

	private readonly INavigationService<ViewModelNavigationPages> v823TxKhun;

	private readonly IMessagingService Lqk3YIsgRY;

	private readonly IDialogCoordinator F1H3SfdYg7;

	public LauncherConfiguration(IGIEnvironnement gIEnvironnement, IIOHelper iOHelper, ILauncherServices launcherServices, IJsonHelper jsonHelper, ICultureHelper cultureHelper, INavigationService<ViewModelNavigationPages> navigationService, IMessagingService messagingService, IDialogCoordinator dialogCoordinator)
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		base._002Ector();
		ImC306DgBE = gIEnvironnement;
		U5k3CxPSnW = iOHelper;
		Q3X3dp4rfA = launcherServices;
		SsQ3yE96nT = jsonHelper;
		Of936hjKYv = cultureHelper;
		v823TxKhun = navigationService;
		Lqk3YIsgRY = messagingService;
		F1H3SfdYg7 = dialogCoordinator;
	}

	private LauncherCardSettings xXK3brsn4i()
	{
		return new LauncherCardSettings
		{
			LauncherCards = VIX3VLLOZJ()
		};
	}

	private SerializableCardTree VIX3VLLOZJ()
	{
		LauncherCard card = new LauncherCard
		{
			IsSoftwareAvailable = false,
			Name = aL07ImwcwlxdnyfI30.olMQlwrxmw(8102)
		};
		SerializableCardTree obj = new SerializableCardTree
		{
			Root = new SerializableCardLeaf
			{
				Card = card
			}
		};
		SerializableCardLeaf root = obj.Root;
		root.Children = new List<SerializableCardLeaf>();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
		LauncherCard card2 = new LauncherCard
		{
			Name = ProgramName.E6Connect,
			DisplayName = ProgramName.E6Connect,
			DisplayNameFR = ProgramNameFR.E6Connect,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(8114),
			ExePath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(8160),
			ExeFolderPath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(8230),
			IsSoftwareAvailable = false,
			OrderToDisplay = 1
		};
		SerializableCardLeaf serializableCardLeaf = new SerializableCardLeaf
		{
			Card = card2
		};
		serializableCardLeaf.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf);
		string exePath = hJh3wyal6N();
		LauncherCard card3 = new LauncherCard
		{
			Name = ProgramName.IDRA,
			DisplayName = ProgramName.IDRA,
			DisplayNameFR = ProgramNameFR.IDRA,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(8274),
			ExePath = exePath,
			ExeFolderPath = GIConstant.SSCIDRAInstallPath,
			IsSoftwareAvailable = false,
			OrderToDisplay = 2
		};
		SerializableCardLeaf serializableCardLeaf2 = new SerializableCardLeaf
		{
			Card = card3
		};
		serializableCardLeaf2.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf2);
		LauncherCard card4 = new LauncherCard
		{
			Name = ProgramName.IDRAGSPro,
			DisplayName = ProgramName.IDRA,
			DisplayNameFR = ProgramNameFR.IDRA,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(8330),
			ExePath = exePath,
			ExeFolderPath = GIConstant.SSCIDRAInstallPath,
			IsSoftwareAvailable = true,
			OrderToDisplay = 3
		};
		SerializableCardLeaf serializableCardLeaf3 = new SerializableCardLeaf
		{
			Card = card4
		};
		serializableCardLeaf3.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf3);
		LauncherCard card5 = new LauncherCard
		{
			Name = ProgramName.E6Golf,
			DisplayName = ProgramName.E6Golf,
			DisplayNameFR = ProgramNameFR.E6Golf,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(8378),
			ExePath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(8418),
			ExeFolderPath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(8484),
			IsSoftwareAvailable = false,
			OrderToDisplay = 4
		};
		SerializableCardLeaf serializableCardLeaf4 = new SerializableCardLeaf
		{
			Card = card5
		};
		serializableCardLeaf4.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf4);
		LauncherCard card6 = new LauncherCard
		{
			Name = ProgramName.Support,
			DisplayName = ProgramName.Support,
			DisplayNameFR = ProgramNameFR.Support,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(8530),
			IsSoftwareAvailable = true,
			OrderToDisplay = 30
		};
		SerializableCardLeaf serializableCardLeaf5 = new SerializableCardLeaf
		{
			Card = card6
		};
		serializableCardLeaf5.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf5);
		serializableCardLeaf5.Children = new List<SerializableCardLeaf>();
		LauncherCard card7 = new LauncherCard
		{
			Name = ProgramName.RestartComputer,
			DisplayName = ProgramName.RestartComputer,
			DisplayNameFR = ProgramNameFR.RestartComputer,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(8572),
			IsSoftwareAvailable = true,
			OrderToDisplay = 5
		};
		SerializableCardLeaf serializableCardLeaf6 = new SerializableCardLeaf
		{
			Card = card7
		};
		serializableCardLeaf6.ParentCardName = serializableCardLeaf5.Card.Name;
		serializableCardLeaf5.Children.Add(serializableCardLeaf6);
		LauncherCard card8 = new LauncherCard
		{
			Name = ProgramName.Baseball,
			DisplayName = ProgramName.Baseball,
			DisplayNameFR = ProgramNameFR.Baseball,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(8638),
			ExePath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(8682),
			ExeFolderPath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(8796),
			IsSoftwareAvailable = false,
			OrderToDisplay = 5,
			ExeParams = aL07ImwcwlxdnyfI30.olMQlwrxmw(8878)
		};
		SerializableCardLeaf serializableCardLeaf7 = new SerializableCardLeaf
		{
			Card = card8
		};
		serializableCardLeaf7.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf7);
		LauncherCard card9 = new LauncherCard
		{
			Name = ProgramName.Hockey,
			DisplayName = ProgramName.Hockey,
			DisplayNameFR = ProgramNameFR.Hockey,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(8916),
			ExePath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(8956),
			ExeFolderPath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(9066),
			IsSoftwareAvailable = false,
			OrderToDisplay = 6,
			ExeParams = aL07ImwcwlxdnyfI30.olMQlwrxmw(9144)
		};
		SerializableCardLeaf serializableCardLeaf8 = new SerializableCardLeaf
		{
			Card = card9
		};
		serializableCardLeaf8.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf8);
		LauncherCard card10 = new LauncherCard
		{
			Name = ProgramName.Soccer,
			DisplayName = ProgramName.Soccer,
			DisplayNameFR = ProgramNameFR.Soccer,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(9178),
			ExePath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(9218),
			ExeFolderPath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(9328),
			IsSoftwareAvailable = false,
			OrderToDisplay = 7,
			ExeParams = aL07ImwcwlxdnyfI30.olMQlwrxmw(9406)
		};
		SerializableCardLeaf serializableCardLeaf9 = new SerializableCardLeaf
		{
			Card = card10
		};
		serializableCardLeaf9.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf9);
		LauncherCard card11 = new LauncherCard
		{
			Name = ProgramName.FootGolf,
			DisplayName = ProgramName.FootGolf,
			DisplayNameFR = ProgramNameFR.FootGolf,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(9440),
			ExePath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(9484),
			ExeFolderPath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(9598),
			IsSoftwareAvailable = false,
			OrderToDisplay = 8,
			ExeParams = aL07ImwcwlxdnyfI30.olMQlwrxmw(9680)
		};
		SerializableCardLeaf serializableCardLeaf10 = new SerializableCardLeaf
		{
			Card = card11
		};
		serializableCardLeaf10.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf10);
		LauncherCard card12 = new LauncherCard
		{
			Name = ProgramName.DodgeBall,
			DisplayName = ProgramName.DodgeBall,
			DisplayNameFR = ProgramNameFR.DodgeBall,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(9718),
			ExePath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(9764),
			ExeFolderPath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(9880),
			IsSoftwareAvailable = false,
			OrderToDisplay = 10,
			ExeParams = aL07ImwcwlxdnyfI30.olMQlwrxmw(9964)
		};
		SerializableCardLeaf serializableCardLeaf11 = new SerializableCardLeaf
		{
			Card = card12
		};
		serializableCardLeaf11.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf11);
		LauncherCard card13 = new LauncherCard
		{
			Name = ProgramName.DiscGolf,
			DisplayName = ProgramName.DiscGolf,
			DisplayNameFR = ProgramNameFR.DiscGolf,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(10004),
			ExePath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(10048),
			ExeFolderPath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(10162),
			IsSoftwareAvailable = false,
			OrderToDisplay = 11,
			ExeParams = aL07ImwcwlxdnyfI30.olMQlwrxmw(10244)
		};
		SerializableCardLeaf serializableCardLeaf12 = new SerializableCardLeaf
		{
			Card = card13
		};
		serializableCardLeaf12.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf12);
		LauncherCard card14 = new LauncherCard
		{
			Name = ProgramName.Bowling,
			DisplayName = ProgramName.Bowling,
			DisplayNameFR = ProgramNameFR.Bowling,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(10282),
			ExePath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(10324),
			ExeFolderPath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(10436),
			IsSoftwareAvailable = false,
			OrderToDisplay = 12,
			ExeParams = aL07ImwcwlxdnyfI30.olMQlwrxmw(10516)
		};
		SerializableCardLeaf serializableCardLeaf13 = new SerializableCardLeaf
		{
			Card = card14
		};
		serializableCardLeaf13.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf13);
		LauncherCard card15 = new LauncherCard
		{
			Name = ProgramName.WildWest,
			DisplayName = ProgramName.WildWest,
			DisplayNameFR = ProgramNameFR.WildWest,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(10552),
			ExePath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(10598),
			ExeFolderPath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(10670),
			IsSoftwareAvailable = false,
			OrderToDisplay = 13,
			ExeParams = string.Empty
		};
		SerializableCardLeaf serializableCardLeaf14 = new SerializableCardLeaf
		{
			Card = card15
		};
		serializableCardLeaf14.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf14);
		LauncherCard card16 = new LauncherCard
		{
			Name = ProgramName.FieldGoalFrenzy,
			DisplayName = ProgramName.FieldGoalFrenzy,
			DisplayNameFR = ProgramNameFR.FieldGoalFrenzy,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(10716),
			ExePath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(10774),
			ExeFolderPath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(10900),
			IsSoftwareAvailable = false,
			OrderToDisplay = 14,
			ExeParams = string.Empty
		};
		SerializableCardLeaf serializableCardLeaf15 = new SerializableCardLeaf
		{
			Card = card16
		};
		serializableCardLeaf15.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf15);
		LauncherCard card17 = new LauncherCard
		{
			Name = ProgramName.InsideHeat,
			DisplayName = ProgramName.InsideHeat,
			DisplayNameFR = ProgramNameFR.InsideHeat,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(10984),
			ExePath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(11032),
			ExeFolderPath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(11148),
			IsSoftwareAvailable = false,
			OrderToDisplay = 15,
			ExeParams = string.Empty
		};
		SerializableCardLeaf serializableCardLeaf16 = new SerializableCardLeaf
		{
			Card = card17
		};
		serializableCardLeaf16.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf16);
		LauncherCard card18 = new LauncherCard
		{
			Name = ProgramName.Quarterbacks,
			DisplayName = ProgramName.Quarterbacks,
			DisplayNameFR = ProgramNameFR.Quarterbacks,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(11234),
			ExePath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(11286),
			ExeFolderPath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(11408),
			IsSoftwareAvailable = false,
			OrderToDisplay = 16,
			ExeParams = string.Empty
		};
		SerializableCardLeaf serializableCardLeaf17 = new SerializableCardLeaf
		{
			Card = card18
		};
		serializableCardLeaf17.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf17);
		LauncherCard card19 = new LauncherCard
		{
			Name = ProgramName.Hoops,
			DisplayName = ProgramName.Hoops,
			DisplayNameFR = ProgramNameFR.Hoops,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(11498),
			ExePath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(11536),
			ExeFolderPath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(11630),
			IsSoftwareAvailable = false,
			OrderToDisplay = 17,
			ExeParams = string.Empty
		};
		SerializableCardLeaf serializableCardLeaf18 = new SerializableCardLeaf
		{
			Card = card19
		};
		serializableCardLeaf18.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf18);
		LauncherCard card20 = new LauncherCard
		{
			Name = ProgramName.Cornhole,
			DisplayName = ProgramName.Cornhole,
			DisplayNameFR = ProgramNameFR.Cornhole,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(11706),
			ExePath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(11750),
			ExeFolderPath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(11856),
			IsSoftwareAvailable = false,
			OrderToDisplay = 18,
			ExeParams = string.Empty
		};
		SerializableCardLeaf serializableCardLeaf19 = new SerializableCardLeaf
		{
			Card = card20
		};
		serializableCardLeaf19.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf19);
		LauncherCard card21 = new LauncherCard
		{
			Name = ProgramName.WildHunt,
			DisplayName = ProgramName.WildHunt,
			DisplayNameFR = ProgramNameFR.WildHunt,
			IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(11938),
			ExePath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(11982),
			ExeFolderPath = folderPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(12088),
			IsSoftwareAvailable = false,
			OrderToDisplay = 5,
			ExeParams = string.Empty
		};
		SerializableCardLeaf serializableCardLeaf20 = new SerializableCardLeaf
		{
			Card = card21
		};
		serializableCardLeaf20.ParentCardName = root.Card.Name;
		root.Children.Add(serializableCardLeaf20);
		return obj;
	}

	private string hJh3wyal6N()
	{
		if (GIConstant.UsingSSCInstallPath && SoftwareVersionsService.ConfigurationFileExists())
		{
			return SoftwareVersionsService.GetMainExecutablePath(Software.IDRA);
		}
		return GIConstant.SSCIDRAInstallPath + aL07ImwcwlxdnyfI30.olMQlwrxmw(12152);
	}

	public LauncherCardSettings GetOrSetAllLaucherCard()
	{
		LauncherCardSettings launcherCardSettings = xXK3brsn4i();
		try
		{
			ImC306DgBE.VerifyOrCreateGolfInFolder(GIConstant.PathToGolfInFolder);
			string pathToLauncherCardConfigJsonFile = GIConstant.PathToLauncherCardConfigJsonFile;
			if (U5k3CxPSnW.FileExists(pathToLauncherCardConfigJsonFile))
			{
				LauncherCardSettings launcherCardSettingsToObject = Q3X3dp4rfA.GetLauncherCardSettingsToObject(pathToLauncherCardConfigJsonFile);
				List<SerializableCardLeaf> list = launcherCardSettingsToObject.LauncherCards.FlattenCardTree().ToList();
				List<SerializableCardLeaf> list2 = launcherCardSettings.LauncherCards.FlattenCardTree().ToList();
				List<SerializableCardLeaf> list3 = list2.ExceptBy(list.Select((SerializableCardLeaf x) => x.Card.Name), (SerializableCardLeaf dlcf) => dlcf.Card.Name).ToList();
				List<SerializableCardLeaf> list4 = list.ExceptBy(list2.Select((SerializableCardLeaf x) => x.Card.Name), (SerializableCardLeaf clsf) => clsf.Card.Name).ToList();
				SerializableCardLeaf serializableCardLeaf = launcherCardSettingsToObject.LauncherCards.FlattenCardTree().FirstOrDefault((SerializableCardLeaf x) => x.Card.Name == ProgramName.IDRA);
				if (serializableCardLeaf != null)
				{
					serializableCardLeaf.Card.IconFileName = aL07ImwcwlxdnyfI30.olMQlwrxmw(8274);
				}
				if (!list3.Any() && !list4.Any())
				{
					return launcherCardSettingsToObject;
				}
				using (List<SerializableCardLeaf>.Enumerator enumerator = list3.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals9 = new _003C_003Ec__DisplayClass12_0();
						CS_0024_003C_003E8__locals9.zxr5okP8Qt = enumerator.Current;
						if (CS_0024_003C_003E8__locals9.zxr5okP8Qt.ParentCardName == launcherCardSettingsToObject.LauncherCards.Root.Card.Name)
						{
							launcherCardSettingsToObject.LauncherCards.Root.Children.Add(CS_0024_003C_003E8__locals9.zxr5okP8Qt);
							continue;
						}
						launcherCardSettingsToObject.LauncherCards.Root.TraverseCardTree(delegate(SerializableCardLeaf card)
						{
							if (card.Card.Name == CS_0024_003C_003E8__locals9.zxr5okP8Qt.ParentCardName)
							{
								if (card.Children == null)
								{
									card.Children = new List<SerializableCardLeaf>();
								}
								card.Children.Add(CS_0024_003C_003E8__locals9.zxr5okP8Qt);
							}
						});
					}
				}
				using (List<SerializableCardLeaf>.Enumerator enumerator = list4.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						_003C_003Ec__DisplayClass12_1 CS_0024_003C_003E8__locals11 = new _003C_003Ec__DisplayClass12_1();
						CS_0024_003C_003E8__locals11.hxj5zGqe3Y = enumerator.Current;
						if (CS_0024_003C_003E8__locals11.hxj5zGqe3Y.ParentCardName == launcherCardSettingsToObject.LauncherCards.Root.Card.Name)
						{
							launcherCardSettingsToObject.LauncherCards.Root.Children.Remove(CS_0024_003C_003E8__locals11.hxj5zGqe3Y);
							continue;
						}
						launcherCardSettingsToObject.LauncherCards.Root.TraverseCardTree(delegate(SerializableCardLeaf card)
						{
							if (card.Card.Name == CS_0024_003C_003E8__locals11.hxj5zGqe3Y.ParentCardName)
							{
								card.Children.Remove(CS_0024_003C_003E8__locals11.hxj5zGqe3Y);
							}
						});
					}
				}
				SaveSettings(launcherCardSettingsToObject);
			}
			else
			{
				SaveSettings(launcherCardSettings);
			}
		}
		catch (Exception ex)
		{
			EventViewerLogger.LogException(ex);
		}
		return launcherCardSettings;
	}

	public void SaveSettings(LauncherCardSettings settings)
	{
		string pathToLauncherCardConfigJsonFile = GIConstant.PathToLauncherCardConfigJsonFile;
		string content = SsQ3yE96nT.SerializeObject(settings);
		U5k3CxPSnW.FileWriteAllText(pathToLauncherCardConfigJsonFile, content);
	}

	public ErrorCode LaunchProgram(List<SerializableCardLeaf> fromList, string programNameToLaunch)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals3.tleQkZTIfd = programNameToLaunch;
		try
		{
			LauncherCard card = fromList.FirstOrDefault((SerializableCardLeaf x) => x.Card.Name == CS_0024_003C_003E8__locals3.tleQkZTIfd).Card;
			if (!VerifyFileExist(card))
			{
				return new ErrorCode(success: false, aL07ImwcwlxdnyfI30.olMQlwrxmw(12188) + CS_0024_003C_003E8__locals3.tleQkZTIfd);
			}
			v823TxKhun.NavigateTo(ViewModelNavigationPages.Web);
			Lqk3YIsgRY.Send(new ShowWebAssociatedWithCardMessage(card));
		}
		catch (Exception ex)
		{
			return new ErrorCode(success: false, aL07ImwcwlxdnyfI30.olMQlwrxmw(12260) + ex.Message);
		}
		return new ErrorCode(success: true);
	}

	public bool VerifyFileExist(LauncherCard card)
	{
		string pathToFile = GIConstant.PathToGolfInFolder + aL07ImwcwlxdnyfI30.olMQlwrxmw(3528) + card.VideoNameWithExtension;
		string pathToFile2 = Of936hjKYv.GetCurrentLanguage() switch
		{
			Language.French => card.RelativeWebFilePathFR, 
			Language.English => card.RelativeWebFilePathEN, 
			_ => card.RelativeWebFilePathEN, 
		};
		bool flag = !string.IsNullOrWhiteSpace(card.FileNameWithExtension) && !string.IsNullOrWhiteSpace(card.RelativeWebFilePathFR);
		bool flag2 = !string.IsNullOrWhiteSpace(card.VideoNameWithExtension) && !string.IsNullOrWhiteSpace(card.RelativeWebVideoPath);
		bool result = false;
		if (string.IsNullOrWhiteSpace(card.FileNameWithExtension) && string.IsNullOrWhiteSpace(card.VideoNameWithExtension))
		{
			return true;
		}
		if (flag && flag2)
		{
			result = U5k3CxPSnW.FileExists(pathToFile2) && U5k3CxPSnW.FileExists(pathToFile);
		}
		else if (flag)
		{
			result = U5k3CxPSnW.FileExists(pathToFile2);
		}
		else if (flag2)
		{
			result = U5k3CxPSnW.FileExists(pathToFile);
		}
		return result;
	}
}
