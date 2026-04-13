using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using E2ss4tufB1n6piMD1F;
using GICTS.Core;
using GICTS.Data;
using GIToolkit.Services;
using GhU84wwqvI4UZ3pBfu;
using IDRA.Auxiliary.Helpers;
using IDRA.Auxiliary.Messages;
using IDRA.Auxiliary.Navigations;
using IDRA.Models;
using sxB8TYTZ87aKuujytY;

namespace IDRA.ViewModels;

public class PostShotHistoryViewModel : ObservableRecipient, IViewModel
{
	[CompilerGenerated]
	private Dictionary<string, Dictionary<ClubTypeEnum, List<ShotDataForHistory>>> rCxHQIX7lV;

	private bool B5FHa6LX4D;

	private ObservableCollection<ObservableCollection<string>> Aq7HqTRpNO;

	private ObservableCollection<string> VrhHCLw4LW;

	private ObservableCollection<string> N5mH0H5g29;

	private ObservableCollection<BindableTuple<string, bool>> OSpH7okRTd;

	private ObservableCollection<BindableTuple<string, bool>> rMCHImmrVo;

	private string Y2JH8dkQDj;

	private ClubTypeEnum h4jHRkVyWJ;

	private readonly INavigationService<VM> qyiHF0lR44;

	private readonly IGICTSDirector smGHbNq83L;

	private readonly IMessagingService R1kH64HwVg;

	public Dictionary<string, Dictionary<ClubTypeEnum, List<ShotDataForHistory>>> ShotHistory
	{
		[CompilerGenerated]
		get
		{
			return rCxHQIX7lV;
		}
		[CompilerGenerated]
		set
		{
			rCxHQIX7lV = value;
		}
	}

	public bool UseGSPro
	{
		get
		{
			return B5FHa6LX4D;
		}
		set
		{
			SetProperty(ref B5FHa6LX4D, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(4400));
		}
	}

	public ObservableCollection<ObservableCollection<string>> ClubShots
	{
		get
		{
			return Aq7HqTRpNO;
		}
		set
		{
			SetProperty(ref Aq7HqTRpNO, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(5414));
		}
	}

	public ObservableCollection<string> ShotHistoryRowHeaders
	{
		get
		{
			return VrhHCLw4LW;
		}
		set
		{
			SetProperty(ref VrhHCLw4LW, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(5436));
		}
	}

	public ObservableCollection<string> ShotHistoryColumnHeaders
	{
		get
		{
			return N5mH0H5g29;
		}
		set
		{
			SetProperty(ref N5mH0H5g29, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(5482));
		}
	}

	public ObservableCollection<BindableTuple<string, bool>> ClubNames
	{
		get
		{
			return OSpH7okRTd;
		}
		set
		{
			OSpH7okRTd = value;
			OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5534));
		}
	}

	public ObservableCollection<BindableTuple<string, bool>> PlayerNames
	{
		get
		{
			return rMCHImmrVo;
		}
		set
		{
			rMCHImmrVo = value;
			OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5556));
		}
	}

	public string SelectedPlayer
	{
		get
		{
			return Y2JH8dkQDj;
		}
		set
		{
			Y2JH8dkQDj = value;
			OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5556));
		}
	}

	public ClubTypeEnum SelectedClub
	{
		get
		{
			return h4jHRkVyWJ;
		}
		set
		{
			h4jHRkVyWJ = value;
			OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5556));
		}
	}

	public ICommand NavigateBackToPostShot => new RelayCommand(delegate
	{
		PlayerNames = new ObservableCollection<BindableTuple<string, bool>>();
		ClubNames = new ObservableCollection<BindableTuple<string, bool>>();
		ClubShots = new ObservableCollection<ObservableCollection<string>>();
		ShotHistoryColumnHeaders = new ObservableCollection<string>();
		ShotHistoryRowHeaders = new ObservableCollection<string>();
		R1kH64HwVg.Send(new NavigatePostShotViewMessage(disableAutoContinueTimer: false));
	});

	public ICommand ClubSelected => new RelayCommand<string>(delegate(string P_0)
	{
		Enum.TryParse<ClubTypeEnum>(P_0, out var result);
		SelectedClub = result;
		l0hHsYMhT2();
		gdldzHiRbl();
	});

	public ICommand PlayerSelected => new RelayCommand<string>(delegate(string P_0)
	{
		SelectedPlayer = P_0;
		SelectedClub = ClubTypeEnum.Unknow;
		ycRd5VWRxU();
		l0hHsYMhT2();
		gdldzHiRbl();
	});

	public PostShotHistoryViewModel(INavigationService<VM> navigationService, IGICTSDirector gICTSDirector, IMessagingService messagingService)
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		rCxHQIX7lV = new Dictionary<string, Dictionary<ClubTypeEnum, List<ShotDataForHistory>>>();
		VrhHCLw4LW = new ObservableCollection<string>();
		N5mH0H5g29 = new ObservableCollection<string>();
		OSpH7okRTd = new ObservableCollection<BindableTuple<string, bool>>();
		rMCHImmrVo = new ObservableCollection<BindableTuple<string, bool>>();
		Y2JH8dkQDj = string.Empty;
		h4jHRkVyWJ = ClubTypeEnum.Unknow;
		base._002Ector();
		qyiHF0lR44 = navigationService;
		smGHbNq83L = gICTSDirector;
		R1kH64HwVg = messagingService;
		UseGSPro = smGHbNq83L.Settings.UseGSPro;
		R1kH64HwVg.Register(this, delegate(object P_0, hkynCxmFLwLsNkH4nK P_1)
		{
			if (P_0 != null)
			{
				ShotHistory = P_1.Value;
				if (ShotHistory.Count == 0)
				{
					SelectedPlayer = string.Empty;
					SelectedClub = ClubTypeEnum.Unknow;
				}
				else
				{
					gdldzHiRbl();
					l0hHsYMhT2();
					eQZdoOabkv();
				}
			}
		});
	}

	private void eQZdoOabkv()
	{
		PlayerNames = new ObservableCollection<BindableTuple<string, bool>>();
		foreach (string key in ShotHistory.Keys)
		{
			PlayerNames.Add(new BindableTuple<string, bool>
			{
				Item1 = key,
				Item2 = (key == SelectedPlayer)
			});
		}
		ycRd5VWRxU();
	}

	private void ycRd5VWRxU()
	{
		if (!ShotHistory.TryGetValue(SelectedPlayer, out var value))
		{
			return;
		}
		IOrderedEnumerable<ClubTypeEnum> orderedEnumerable = value.Keys.Order();
		ClubNames = new ObservableCollection<BindableTuple<string, bool>>();
		foreach (ClubTypeEnum item in orderedEnumerable)
		{
			ClubNames.Add(new BindableTuple<string, bool>
			{
				Item1 = item.ToString(),
				Item2 = (item == SelectedClub)
			});
		}
	}

	private void gdldzHiRbl()
	{
		PropertyInfo[] properties = new ShotDataToDisplayHistory().GetType().GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			ShotHistoryColumnHeaders.Add(propertyInfo.Name);
		}
		ShotHistoryRowHeaders = new ObservableCollection<string> { QQXBLjLprwI58ya4VR.y8v8TMFOCb(5582) };
		if (ShotHistory.TryGetValue(SelectedPlayer, out var value) && SelectedClub != ClubTypeEnum.Unknow)
		{
			for (int num = value[SelectedClub].Count; num > 0; num = checked(num - 1))
			{
				ShotHistoryRowHeaders.Add(num.ToString());
			}
		}
	}

	private void l0hHsYMhT2()
	{
		ClubShots = new ObservableCollection<ObservableCollection<string>>();
		if (!ShotHistory.TryGetValue(SelectedPlayer, out var value) || SelectedClub == ClubTypeEnum.Unknow)
		{
			return;
		}
		List<ShotDataForHistory> list = value[SelectedClub];
		if (list == null)
		{
			return;
		}
		double num = list.Average((ShotDataForHistory shot) => shot.LaunchDirection);
		double num2 = list.Average((ShotDataForHistory shot) => shot.ClubPath);
		double num3 = list.Average((ShotDataForHistory shot) => shot.FaceAngle);
		double num4 = list.Average((ShotDataForHistory shot) => shot.SideSpin);
		ObservableCollection<string> item = new ObservableCollection<string>
		{
			list.Average((ShotDataForHistory shot) => shot.CarryGame).ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)),
			list.Average((ShotDataForHistory shot) => shot.TotalDistance).ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)),
			list.Average((ShotDataForHistory shot) => shot.BallSpeed).ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)),
			list.Average((ShotDataForHistory shot) => shot.ClubSpeed).ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)),
			list.Average((ShotDataForHistory shot) => shot.SmashFactor).ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)),
			Math.Abs(num).ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)) + ((num > 0.0) ? QQXBLjLprwI58ya4VR.y8v8TMFOCb(5610) : QQXBLjLprwI58ya4VR.y8v8TMFOCb(5602)),
			list.Average((ShotDataForHistory shot) => shot.LaunchAngle).ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)),
			Math.Abs(num2).ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)) + ((num2 > 0.0) ? QQXBLjLprwI58ya4VR.y8v8TMFOCb(5630) : QQXBLjLprwI58ya4VR.y8v8TMFOCb(5618)),
			Math.Abs(num3).ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)) + ((num3 > 0.0) ? QQXBLjLprwI58ya4VR.y8v8TMFOCb(5642) : QQXBLjLprwI58ya4VR.y8v8TMFOCb(5602)),
			list.Average((ShotDataForHistory shot) => shot.Apex).ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)),
			list.Average((ShotDataForHistory shot) => shot.DescentAngle).ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)),
			list.Average((ShotDataForHistory shot) => shot.BackSpin).ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5650)),
			Math.Abs(num4).ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5650)) + ((num4 > 0.0) ? QQXBLjLprwI58ya4VR.y8v8TMFOCb(5610) : QQXBLjLprwI58ya4VR.y8v8TMFOCb(5602))
		};
		ClubShots.Add(item);
		foreach (ShotDataForHistory item3 in list.OrderByDescending((ShotDataForHistory x) => x.ShotTime))
		{
			ObservableCollection<string> item2 = new ObservableCollection<string>
			{
				item3.CarryGame.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)),
				item3.TotalDistance.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)),
				item3.BallSpeed.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)),
				item3.ClubSpeed.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)),
				item3.SmashFactor.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)),
				Math.Abs(item3.LaunchDirection).ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)) + item3.BallDirectionSide,
				item3.LaunchAngle.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)),
				Math.Abs(item3.ClubPath).ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)) + item3.ClubPathSide,
				Math.Abs(item3.FaceAngle).ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)) + item3.ClubFaceSide,
				item3.Apex.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)),
				item3.DescentAngle.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5592)),
				item3.BackSpin.ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5650)),
				Math.Abs(item3.SideSpin).ToString(QQXBLjLprwI58ya4VR.y8v8TMFOCb(5650)) + item3.SideSpinSide
			};
			ClubShots.Add(item2);
		}
	}

	[CompilerGenerated]
	private void zVdHx8EXsw(object P_0, hkynCxmFLwLsNkH4nK P_1)
	{
		if (P_0 != null)
		{
			ShotHistory = P_1.Value;
			if (ShotHistory.Count == 0)
			{
				SelectedPlayer = string.Empty;
				SelectedClub = ClubTypeEnum.Unknow;
			}
			else
			{
				gdldzHiRbl();
				l0hHsYMhT2();
				eQZdoOabkv();
			}
		}
	}

	[CompilerGenerated]
	private void QtpHdUCIRM()
	{
		PlayerNames = new ObservableCollection<BindableTuple<string, bool>>();
		ClubNames = new ObservableCollection<BindableTuple<string, bool>>();
		ClubShots = new ObservableCollection<ObservableCollection<string>>();
		ShotHistoryColumnHeaders = new ObservableCollection<string>();
		ShotHistoryRowHeaders = new ObservableCollection<string>();
		R1kH64HwVg.Send(new NavigatePostShotViewMessage(disableAutoContinueTimer: false));
	}

	[CompilerGenerated]
	private void C8mHHK7dK4(string P_0)
	{
		Enum.TryParse<ClubTypeEnum>(P_0, out var result);
		SelectedClub = result;
		l0hHsYMhT2();
		gdldzHiRbl();
	}

	[CompilerGenerated]
	private void A7qHEGBMW0(string P_0)
	{
		SelectedPlayer = P_0;
		SelectedClub = ClubTypeEnum.Unknow;
		ycRd5VWRxU();
		l0hHsYMhT2();
		gdldzHiRbl();
	}
}
