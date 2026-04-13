using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using GIToolkit.Model.API;
using GIToolkit.Model.Dtos.AppointmentDtos;
using GIToolkit.Model.Dtos.Contacts;
using GIToolkit.Model.Dtos.SimulatorDtos;
using GIToolkit.Model.Dtos.UserDtos;
using GIToolkit.Model.Paging;
using Golfin.Dtos;
using Newtonsoft.Json;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class ZoneGolfinApiV2 : IZoneGolfInApi
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass103_0
	{
		public string lgP3HvlhRy;

		public _003C_003Ec__DisplayClass103_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<UserDto> Gtl3yWx3ho()
		{
			return JsonConvert.DeserializeObject<IEnumerable<UserDto>>(lgP3HvlhRy);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass105_0
	{
		public string Cy03GeVRd7;

		public _003C_003Ec__DisplayClass105_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<UserForManagementDto> dkN3wEZMoA()
		{
			return JsonConvert.DeserializeObject<IEnumerable<UserForManagementDto>>(Cy03GeVRd7);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass106_0
	{
		public string pjd3sK0fev;

		public _003C_003Ec__DisplayClass106_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<UserForManagementDto> oL33C3N88p()
		{
			return JsonConvert.DeserializeObject<IEnumerable<UserForManagementDto>>(pjd3sK0fev);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass107_0
	{
		public string QKY39owR6b;

		public _003C_003Ec__DisplayClass107_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal UserDto E9Z3OEv95B()
		{
			return JsonConvert.DeserializeObject<UserDto>(QKY39owR6b);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass112_0
	{
		public string kei3QD8p2D;

		public _003C_003Ec__DisplayClass112_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal UserDto dqP3hxXQIZ()
		{
			return JsonConvert.DeserializeObject<UserDto>(kei3QD8p2D);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass113_0
	{
		public string TBI3LPp9kR;

		public _003C_003Ec__DisplayClass113_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal UserDto VDm3TH1PrA()
		{
			return JsonConvert.DeserializeObject<UserDto>(TBI3LPp9kR);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass114_0
	{
		public string MEP3ZvukNn;

		public _003C_003Ec__DisplayClass114_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal UserDto ars30SDnUQ()
		{
			return JsonConvert.DeserializeObject<UserDto>(MEP3ZvukNn);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass121_0
	{
		public string Li43SH1UTJ;

		public _003C_003Ec__DisplayClass121_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<PromotionDto> yq23MrjoCS()
		{
			return JsonConvert.DeserializeObject<IEnumerable<PromotionDto>>(Li43SH1UTJ);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass122_0
	{
		public string yK13Nlexnj;

		public _003C_003Ec__DisplayClass122_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<PromotionDto> ue33gs8n4q()
		{
			return JsonConvert.DeserializeObject<IEnumerable<PromotionDto>>(yK13Nlexnj);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass126_0
	{
		public string JH63I5ORj1;

		public _003C_003Ec__DisplayClass126_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal FeeScheduleDto SOF3cs3MrZ()
		{
			return JsonConvert.DeserializeObject<FeeScheduleDto>(JH63I5ORj1);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass128_0
	{
		public string GXT3PP1ksr;

		public _003C_003Ec__DisplayClass128_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> Xir3qnSEBW()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(GXT3PP1ksr);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass129_0
	{
		public string WsF2dMCNw4;

		public _003C_003Ec__DisplayClass129_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> Vji3zc9DKH()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(WsF2dMCNw4);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass130_0
	{
		public string XCv2u0u5JM;

		public _003C_003Ec__DisplayClass130_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> RO82inkxvL()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(XCv2u0u5JM);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass131_0
	{
		public string fMf2RNxrhI;

		public _003C_003Ec__DisplayClass131_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> d4P2VOUjuw()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(fMf2RNxrhI);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass132_0
	{
		public string wKv2kuyDI8;

		public _003C_003Ec__DisplayClass132_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> J0M2A1ePi4()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(wKv2kuyDI8);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass133_0
	{
		public string GVe2XkmQo3;

		public _003C_003Ec__DisplayClass133_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> jE52aShDP2()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(GVe2XkmQo3);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass134_0
	{
		public string vGg2pT8Tll;

		public _003C_003Ec__DisplayClass134_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> vWi2FlyXme()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(vGg2pT8Tll);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass135_0
	{
		public string rSs2YyDBxG;

		public _003C_003Ec__DisplayClass135_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> nSl2WMxYTA()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(rSs2YyDBxG);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass136_0
	{
		public string W6W26fP6gL;

		public _003C_003Ec__DisplayClass136_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> Cr52xgCvFx()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(W6W26fP6gL);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass137_0
	{
		public string jYc2BvkRmW;

		public _003C_003Ec__DisplayClass137_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> pkn2EHn8xd()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(jYc2BvkRmW);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass138_0
	{
		public string e5q22FoICf;

		public _003C_003Ec__DisplayClass138_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<PlayerInvoiceSalesReportDto> M0y23rAC46()
		{
			return JsonConvert.DeserializeObject<IEnumerable<PlayerInvoiceSalesReportDto>>(e5q22FoICf);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass139_0
	{
		public string a2h2tP3PRY;

		public _003C_003Ec__DisplayClass139_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<ReleaseNoteDto> BT82ojPfnl()
		{
			return JsonConvert.DeserializeObject<IEnumerable<ReleaseNoteDto>>(a2h2tP3PRY);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public string nFr2vscvmF;

		public _003C_003Ec__DisplayClass13_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal List<UserForManagementDto> Vwt2DvIJN4()
		{
			return JsonConvert.DeserializeObject<List<UserForManagementDto>>(nFr2vscvmF);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass141_0
	{
		public string lsQ2ex3odg;

		public _003C_003Ec__DisplayClass141_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal bool teQ2JtB0as()
		{
			return JsonConvert.DeserializeObject<bool>(lsQ2ex3odg);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public string yA7272oeP0;

		public _003C_003Ec__DisplayClass14_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SiteLiteDto> rYk2KE6cQS()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SiteLiteDto>>(yA7272oeP0);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass151_0
	{
		public string uag2r3hBNP;

		public _003C_003Ec__DisplayClass151_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<DateTime?> duh24vyM7A()
		{
			return JsonConvert.DeserializeObject<IEnumerable<DateTime?>>(uag2r3hBNP);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public string DOo2lPSeys;

		public _003C_003Ec__DisplayClass16_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<PromotionDto> pet28pE5uT()
		{
			return JsonConvert.DeserializeObject<IEnumerable<PromotionDto>>(DOo2lPSeys);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public string F6821OIgRp;

		public _003C_003Ec__DisplayClass17_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal SimulatorDto hRB2nCR1Mr()
		{
			return JsonConvert.DeserializeObject<SimulatorDto>(F6821OIgRp);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public string DC825dckUH;

		public _003C_003Ec__DisplayClass18_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IoTDeviceDto ra82bjxBgA()
		{
			return JsonConvert.DeserializeObject<IoTDeviceDto>(DC825dckUH);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public string jSH2mI5ij2;

		public _003C_003Ec__DisplayClass19_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal SimulatorDto T0E2UvnSLw()
		{
			return JsonConvert.DeserializeObject<SimulatorDto>(jSH2mI5ij2);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public string LG02fENbWb;

		public _003C_003Ec__DisplayClass20_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<IoTDeviceDto> MZ12jbuuUV()
		{
			return JsonConvert.DeserializeObject<IEnumerable<IoTDeviceDto>>(LG02fENbWb);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public string rTa2HOnul7;

		public _003C_003Ec__DisplayClass21_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IoTDeviceStatusDto FLP2yymWCT()
		{
			return JsonConvert.DeserializeObject<IoTDeviceStatusDto>(rTa2HOnul7);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public string rRb2GGET3J;

		public _003C_003Ec__DisplayClass22_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IoTDeviceStatusDto to62wswMru()
		{
			return JsonConvert.DeserializeObject<IoTDeviceStatusDto>(rRb2GGET3J);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public string E4v2s10A7y;

		public _003C_003Ec__DisplayClass23_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IoTDeviceStatusDto gLd2Ct3F59()
		{
			return JsonConvert.DeserializeObject<IoTDeviceStatusDto>(E4v2s10A7y);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public string UBD29ZQSXI;

		public _003C_003Ec__DisplayClass24_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IoTDeviceDto T0u2OTqrLu()
		{
			return JsonConvert.DeserializeObject<IoTDeviceDto>(UBD29ZQSXI);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public string QyC2Q0u0m8;

		public _003C_003Ec__DisplayClass27_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal RentalInvoiceDto uiU2h1sAlt()
		{
			return JsonConvert.DeserializeObject<RentalInvoiceDto>(QyC2Q0u0m8);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public string IuL2LW26n9;

		public _003C_003Ec__DisplayClass28_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal NewRentalInvoiceDto bfg2TbKUrY()
		{
			return JsonConvert.DeserializeObject<NewRentalInvoiceDto>(IuL2LW26n9);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public string dZR2ZvZYJP;

		public _003C_003Ec__DisplayClass30_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal bool rol20Sx1An()
		{
			return JsonConvert.DeserializeObject<bool>(dZR2ZvZYJP);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public string xhO2SEkKEt;

		public _003C_003Ec__DisplayClass36_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal bool Ugp2MUCBbU()
		{
			return JsonConvert.DeserializeObject<bool>(xhO2SEkKEt);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public string VYl2NIiNej;

		public _003C_003Ec__DisplayClass46_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal bool oXe2gNPec4()
		{
			return JsonConvert.DeserializeObject<bool>(VYl2NIiNej);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public string Dad2IO0wqw;

		public _003C_003Ec__DisplayClass47_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal bool uU72cAhrc3()
		{
			return JsonConvert.DeserializeObject<bool>(Dad2IO0wqw);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass48_0
	{
		public string u7Z2PhVa21;

		public _003C_003Ec__DisplayClass48_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal bool yIM2qjjgnt()
		{
			return JsonConvert.DeserializeObject<bool>(u7Z2PhVa21);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public string csNod9tghy;

		public _003C_003Ec__DisplayClass54_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<AppointmentDto> W3X2zuZZ3r()
		{
			return JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(csNod9tghy);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public string nU9ou6lm2k;

		public _003C_003Ec__DisplayClass55_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<AppointmentDto> KvVoi8raSc()
		{
			return JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(nU9ou6lm2k);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public string ByEoRBTvww;

		public _003C_003Ec__DisplayClass56_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal AppointmentDto IlToVQ6rLj()
		{
			return JsonConvert.DeserializeObject<AppointmentDto>(ByEoRBTvww);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public string u9NokxNqV0;

		public _003C_003Ec__DisplayClass57_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<AppointmentDto> HOYoAlljE0()
		{
			return JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(u9NokxNqV0);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public string eq6oXoZLMa;

		public _003C_003Ec__DisplayClass58_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<AppointmentDto> M5GoaFlRKo()
		{
			return JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(eq6oXoZLMa);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public string J0Sop2PuFS;

		public _003C_003Ec__DisplayClass59_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal AppointmentRecurrenceDto vqcoFNeQ9B()
		{
			return JsonConvert.DeserializeObject<AppointmentRecurrenceDto>(J0Sop2PuFS);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass66_0
	{
		public string kMIoYrKtdZ;

		public _003C_003Ec__DisplayClass66_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SimulatorRemoteManagementDto> RYwoWLw8oS()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SimulatorRemoteManagementDto>>(kMIoYrKtdZ);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public string l3Lo6xZ243;

		public _003C_003Ec__DisplayClass67_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SimulatorDto> Qs3ox5RoA7()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SimulatorDto>>(l3Lo6xZ243);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass68_0
	{
		public string nEboBNEwV8;

		public _003C_003Ec__DisplayClass68_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SimulatorDto> dxnoEwb5hl()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SimulatorDto>>(nEboBNEwV8);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public string pbto2k7Lxy;

		public _003C_003Ec__DisplayClass69_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<DateTime?> lvwo3TRs5W()
		{
			return JsonConvert.DeserializeObject<IEnumerable<DateTime?>>(pbto2k7Lxy);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass70_0
	{
		public string iTbotdeBWI;

		public _003C_003Ec__DisplayClass70_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<DateTime?> vyroopy1sG()
		{
			return JsonConvert.DeserializeObject<IEnumerable<DateTime?>>(iTbotdeBWI);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass71_0
	{
		public string HlVov7gDbb;

		public _003C_003Ec__DisplayClass71_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<AppointmentDto> RRgoDtVfLC()
		{
			return JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(HlVov7gDbb);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass72_0
	{
		public string pgWoecscb9;

		public _003C_003Ec__DisplayClass72_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal AppointmentDto FT4oJQmTyD()
		{
			return JsonConvert.DeserializeObject<AppointmentDto>(pgWoecscb9);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public string sIGo79N1qb;

		public _003C_003Ec__DisplayClass79_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<AppointmentHistoryDto> rajoKu1AGd()
		{
			return JsonConvert.DeserializeObject<IEnumerable<AppointmentHistoryDto>>(sIGo79N1qb);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass80_0
	{
		public string iZ9orq4HoF;

		public _003C_003Ec__DisplayClass80_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<AppointmentHistoryDto> HI6o4vMGrq()
		{
			return JsonConvert.DeserializeObject<IEnumerable<AppointmentHistoryDto>>(iZ9orq4HoF);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass81_0
	{
		public string T9folDEYS4;

		public _003C_003Ec__DisplayClass81_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal ActiveAppointmentSimulatorDto HJQo87NMZm()
		{
			return JsonConvert.DeserializeObject<ActiveAppointmentSimulatorDto>(T9folDEYS4);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass82_0
	{
		public string ypno1Sh4se;

		public _003C_003Ec__DisplayClass82_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal ActiveAppointmentSimulatorDto QxIontWtUG()
		{
			return JsonConvert.DeserializeObject<ActiveAppointmentSimulatorDto>(ypno1Sh4se);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass83_0
	{
		public string Vdto5WGuoZ;

		public _003C_003Ec__DisplayClass83_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal ActiveAppointmentSimulatorDto aqMobljuMy()
		{
			return JsonConvert.DeserializeObject<ActiveAppointmentSimulatorDto>(Vdto5WGuoZ);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass84_0
	{
		public string rjTom4UYpv;

		public _003C_003Ec__DisplayClass84_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal ActiveAppointmentSimulatorDto PLjoUfoqbE()
		{
			return JsonConvert.DeserializeObject<ActiveAppointmentSimulatorDto>(rjTom4UYpv);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass85_0
	{
		public string bswofYjOqr;

		public _003C_003Ec__DisplayClass85_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SiteLiteDto> EiwojJpX6i()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SiteLiteDto>>(bswofYjOqr);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass86_0
	{
		public string Oo3oHu9pBZ;

		public _003C_003Ec__DisplayClass86_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SiteLiteDto> J1EoycSnb7()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SiteLiteDto>>(Oo3oHu9pBZ);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass87_0
	{
		public string HFPoGMVdpn;

		public _003C_003Ec__DisplayClass87_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SiteLiteForProfileDto> oJQowXcdYU()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SiteLiteForProfileDto>>(HFPoGMVdpn);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass88_0
	{
		public string J2RosJ1LaD;

		public _003C_003Ec__DisplayClass88_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SiteAdminSettingsDto> stgoCnFA4d()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SiteAdminSettingsDto>>(J2RosJ1LaD);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass89_0
	{
		public string hrLo9u6gec;

		public _003C_003Ec__DisplayClass89_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal SiteDto YoHoOIwjOF()
		{
			return JsonConvert.DeserializeObject<SiteDto>(hrLo9u6gec);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass92_0
	{
		public string yCYoQAsWUi;

		public _003C_003Ec__DisplayClass92_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal SiteReservationSettingDto TLIohLPhvk()
		{
			return JsonConvert.DeserializeObject<SiteReservationSettingDto>(yCYoQAsWUi);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public string OPuoLLsLOa;

		public _003C_003Ec__DisplayClass93_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal SiteWebSettingDto qtOoTQk497()
		{
			return JsonConvert.DeserializeObject<SiteWebSettingDto>(OPuoLLsLOa);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass97_0
	{
		public string euDoZiOPYZ;

		public _003C_003Ec__DisplayClass97_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal List<DayOpeningHoursDto> hveo0fRJKx()
		{
			return JsonConvert.DeserializeObject<List<DayOpeningHoursDto>>(euDoZiOPYZ);
		}
	}

	private string fJs3mAljTh;

	private readonly HttpClient iNg3jKWm0d;

	[CompilerGenerated]
	private static readonly string AIX3fSkMbD;

	public static string ModelInvalid
	{
		[CompilerGenerated]
		get
		{
			return AIX3fSkMbD;
		}
	}

	public ZoneGolfinApiV2(HttpClient httpClient)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		fJs3mAljTh = so95DAFNMfktfjp4Dm.An6v7kuCGg(9838);
		base._002Ector();
		iNg3jKWm0d = httpClient;
		iNg3jKWm0d.DefaultRequestHeaders.Add(so95DAFNMfktfjp4Dm.An6v7kuCGg(10562), so95DAFNMfktfjp4Dm.An6v7kuCGg(9906));
	}

	public void ChangeCurrentCulture(SupportedCulture newCulture)
	{
		switch (newCulture)
		{
		case SupportedCulture.FR_CA:
			fJs3mAljTh = so95DAFNMfktfjp4Dm.An6v7kuCGg(9942);
			break;
		case SupportedCulture.EN_US:
			fJs3mAljTh = so95DAFNMfktfjp4Dm.An6v7kuCGg(9838);
			break;
		default:
			fJs3mAljTh = so95DAFNMfktfjp4Dm.An6v7kuCGg(9838);
			break;
		}
	}

	public string GetCurrentAPICulture()
	{
		return fJs3mAljTh;
	}

	public void SetApiToUse(AvailableAPI api)
	{
		switch (api)
		{
		case AvailableAPI.PROD:
			iNg3jKWm0d.BaseAddress = new Uri(so95DAFNMfktfjp4Dm.An6v7kuCGg(9974));
			break;
		case AvailableAPI.QA:
			iNg3jKWm0d.BaseAddress = new Uri(so95DAFNMfktfjp4Dm.An6v7kuCGg(10074));
			break;
		case AvailableAPI.DEV:
			iNg3jKWm0d.BaseAddress = new Uri(so95DAFNMfktfjp4Dm.An6v7kuCGg(10170));
			break;
		case AvailableAPI.LOCAL:
			iNg3jKWm0d.BaseAddress = new Uri(so95DAFNMfktfjp4Dm.An6v7kuCGg(10268));
			break;
		default:
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(10324));
		}
	}

	public void SetApiToUse(string apiUrl)
	{
		iNg3jKWm0d.BaseAddress = new Uri(apiUrl);
	}

	public string GetApiUrl()
	{
		return iNg3jKWm0d.BaseAddress.ToString();
	}

	public async Task<T> Login<T>(UserForLoginDto userForLoginDto) where T : class
	{
		if (userForLoginDto == null)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26976));
		}
		string content = JsonConvert.SerializeObject(userForLoginDto);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(ApiReferenceURL.GetLoginUrl() + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		LoggedInfo loggedInfo = await response.Content.ReadAsAsync<LoggedInfo>();
		iNg3jKWm0d.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(so95DAFNMfktfjp4Dm.An6v7kuCGg(10412), loggedInfo.Token);
		if (typeof(T) == typeof(LoggedInfo))
		{
			return loggedInfo as T;
		}
		if (typeof(T) == typeof(UserDto))
		{
			return loggedInfo.User as T;
		}
		return null;
	}

	public async Task<LoggedInfo> LoginWithCardNumber(UserForLoginFromCardNumberDto userLoginCardInfo)
	{
		string content = JsonConvert.SerializeObject(userLoginCardInfo);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(ApiReferenceURL.GetLoginWithCardNumberUrl() + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		LoggedInfo loggedInfo = await response.Content.ReadAsAsync<LoggedInfo>();
		SetAuthorization(loggedInfo.Token);
		return loggedInfo;
	}

	public async Task<List<UserForManagementDto>> GetAllEmployees()
	{
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass13_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(so95DAFNMfktfjp4Dm.An6v7kuCGg(26670) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.nFr2vscvmF = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<List<UserForManagementDto>>(CS_0024_003C_003E8__locals2.nFr2vscvmF));
	}

	public async Task<IEnumerable<SiteLiteDto>> GetAllLiteSites()
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass14_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetLiteSitesUrl() + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.yA7272oeP0 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SiteLiteDto>>(CS_0024_003C_003E8__locals2.yA7272oeP0));
	}

	public async Task<UserDto> UpdateTestMember(string cardNumber, decimal defaultHourlyRate, UserUnitTestDto model)
	{
		HttpClient client = iNg3jKWm0d;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(27264));
		defaultInterpolatedStringHandler.AppendFormatted(cardNumber);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(defaultHourlyRate);
		HttpResponseMessage response = await client.PutAsJsonAsync(defaultInterpolatedStringHandler.ToStringAndClear() + fJs3mAljTh, model);
		await c6C35jo4PL(response);
		if (response.IsSuccessStatusCode)
		{
			return await response.Content.ReadAsAsync<UserDto>();
		}
		throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(27302));
	}

	public async Task<IEnumerable<PromotionDto>> GetDefaultPromotions()
	{
		_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass16_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetDefaultPromotions() + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.DOo2lPSeys = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<PromotionDto>>(CS_0024_003C_003E8__locals2.DOo2lPSeys));
	}

	public async Task<SimulatorDto> GetSimulatorExist(string simId)
	{
		_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass17_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetSimulatorExist(simId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.F6821OIgRp = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<SimulatorDto>(CS_0024_003C_003E8__locals2.F6821OIgRp));
	}

	public async Task<IoTDeviceDto> GetIoTDevice(string DeviceID)
	{
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass18_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetIoTDevice(DeviceID) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.DC825dckUH = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IoTDeviceDto>(CS_0024_003C_003E8__locals2.DC825dckUH));
	}

	public async Task<SimulatorDto> GetSimulatorForRemote(string simId)
	{
		_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass19_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetSimulatorForRemote(simId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.jSH2mI5ij2 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<SimulatorDto>(CS_0024_003C_003E8__locals2.jSH2mI5ij2));
	}

	public async Task<IEnumerable<IoTDeviceDto>> GetUnPairedIoTDevices()
	{
		_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass20_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetUnPairedIoTDevicesUrl() + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.LG02fENbWb = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<IoTDeviceDto>>(CS_0024_003C_003E8__locals2.LG02fENbWb));
	}

	public async Task<IoTDeviceStatusDto> GetIoTDeviceStatus(int DeviceID)
	{
		_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass21_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetIoTDeviceStatus(DeviceID) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.rTa2HOnul7 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IoTDeviceStatusDto>(CS_0024_003C_003E8__locals2.rTa2HOnul7));
	}

	public async Task<IoTDeviceStatusDto> GetIoTDeviceStatusBySimulatorID(string simulatorId)
	{
		_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass22_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetIoTDeviceStatusBySimulatorID(simulatorId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.rRb2GGET3J = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IoTDeviceStatusDto>(CS_0024_003C_003E8__locals2.rRb2GGET3J));
	}

	public async Task<IoTDeviceStatusDto> GetIoTDeviceStatusByAzureDeviceID(string azureDeviceID)
	{
		_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass23_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetIoTDeviceStatusByAzureDeviceID(azureDeviceID) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.E4v2s10A7y = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IoTDeviceStatusDto>(CS_0024_003C_003E8__locals2.E4v2s10A7y));
	}

	public async Task<IoTDeviceDto> GetIoTDeviceBySimulator(string simulatorID)
	{
		_003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass24_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetIoTDeviceBySimulator(simulatorID) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.UBD29ZQSXI = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IoTDeviceDto>(CS_0024_003C_003E8__locals2.UBD29ZQSXI));
	}

	public async Task<bool> UpdateRentalInvoice(int id, NewRentalInvoiceDto rentalInvoiceForUpdate)
	{
		if (rentalInvoiceForUpdate == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(rentalInvoiceForUpdate);
		HttpClient httpClient = iNg3jKWm0d;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(26752));
		defaultInterpolatedStringHandler.AppendFormatted(id);
		HttpResponseMessage response = await httpClient.PutAsync(defaultInterpolatedStringHandler.ToStringAndClear() + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> AttachInvoiceToAppointment(int appointmentId, int invoiceId)
	{
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.GetAttachInvoiceToAppointment(appointmentId, invoiceId), qYu3birVMU());
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<RentalInvoiceDto> GetRentalInvoice(int invoiceId)
	{
		_003C_003Ec__DisplayClass27_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass27_0();
		HttpClient httpClient = iNg3jKWm0d;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(26752));
		defaultInterpolatedStringHandler.AppendFormatted(invoiceId);
		HttpResponseMessage response = await httpClient.GetAsync(defaultInterpolatedStringHandler.ToStringAndClear() + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.QyC2Q0u0m8 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<RentalInvoiceDto>(CS_0024_003C_003E8__locals2.QyC2Q0u0m8));
	}

	public async Task<NewRentalInvoiceDto> GetRentalInvoiceForRemote(int invoiceId)
	{
		_003C_003Ec__DisplayClass28_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass28_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetRentalInvoiceForRemote(invoiceId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.IuL2LW26n9 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<NewRentalInvoiceDto>(CS_0024_003C_003E8__locals2.IuL2LW26n9));
	}

	public async Task<SimulatorDto> CreateNewSimulator(SimulatorForCreationDto newSim)
	{
		if (newSim == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(newSim);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(so95DAFNMfktfjp4Dm.An6v7kuCGg(26384) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return await response.Content.ReadAsAsync<SimulatorDto>();
	}

	public async Task<bool> CheckConnection(string deviceID)
	{
		_003C_003Ec__DisplayClass30_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass30_0();
		string requestUri = ApiReferenceURL.GetConnectivityDevice(deviceID) + fJs3mAljTh;
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(requestUri);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.dZR2ZvZYJP = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<bool>(CS_0024_003C_003E8__locals2.dZR2ZvZYJP));
	}

	public async Task<bool> NotifyIOTDevice(string deviceID)
	{
		string requestUri = ApiReferenceURL.PostNotifySim(deviceID) + fJs3mAljTh;
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(requestUri, new StringContent(string.Empty, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> PutIotDevice(int id, IoTDeviceForUpdateDto ioTDeviceForUpdateDto)
	{
		if (ioTDeviceForUpdateDto == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(ioTDeviceForUpdateDto);
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.GetPutIotDeviceUrl(id) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<RentalInvoiceDto> RegisterNewSessionSale(NewSessionSalesDto newSessionSales)
	{
		if (newSessionSales == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(newSessionSales);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(so95DAFNMfktfjp4Dm.An6v7kuCGg(27068) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return await response.Content.ReadAsAsync<RentalInvoiceDto>();
	}

	public async Task<RentalInvoiceDto> RegisterRemoteSale(RegisterSaleDto registerSaleDto)
	{
		if (registerSaleDto == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(registerSaleDto);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(ApiReferenceURL.RegisterRemoteSaleUrl() + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return await response.Content.ReadAsAsync<RentalInvoiceDto>();
	}

	public async Task<bool> UdpateInvoice(int rentalInvoiceId, UpdateInvoiceDto updatedInvoice)
	{
		if (updatedInvoice == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(updatedInvoice);
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.UdpateInvoiceUrl(rentalInvoiceId) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> IsServerOn()
	{
		_003C_003Ec__DisplayClass36_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass36_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(so95DAFNMfktfjp4Dm.An6v7kuCGg(26940) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.xhO2SEkKEt = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<bool>(CS_0024_003C_003E8__locals2.xhO2SEkKEt));
	}

	public HttpClient GetHttpContext()
	{
		return iNg3jKWm0d;
	}

	public bool IsTokenValid(string tokenStr)
	{
		JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
		if (!jwtSecurityTokenHandler.CanReadToken(tokenStr))
		{
			return false;
		}
		try
		{
			JwtSecurityToken jwtSecurityToken = jwtSecurityTokenHandler.ReadJwtToken(tokenStr);
			if (jwtSecurityToken.ValidTo < DateTime.UtcNow)
			{
				return false;
			}
			JwtHeader header = jwtSecurityToken.Header;
			if (header == null)
			{
				return false;
			}
			if (!(header.Alg == so95DAFNMfktfjp4Dm.An6v7kuCGg(10398)))
			{
				return false;
			}
			SetAuthorization(tokenStr);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public void SetAuthorization(string tokenStr)
	{
		iNg3jKWm0d.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(so95DAFNMfktfjp4Dm.An6v7kuCGg(10412), tokenStr);
	}

	public async Task<bool> StartRentalSession(RentalActionModifyDto rentalActionModifyDto)
	{
		if (string.IsNullOrWhiteSpace(rentalActionModifyDto?.SimulatorId))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26280));
		}
		string requestUri = ApiReferenceURL.StartRentalSession() + fJs3mAljTh;
		string content = JsonConvert.SerializeObject(rentalActionModifyDto);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(requestUri, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> ActivateRentalSession(RentalActionModifyDto rentalActionModifyDto)
	{
		if (string.IsNullOrWhiteSpace(rentalActionModifyDto?.SimulatorId))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26280));
		}
		string requestUri = ApiReferenceURL.ActivateRentalSession() + fJs3mAljTh;
		string content = JsonConvert.SerializeObject(rentalActionModifyDto);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(requestUri, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> PauseRentalSession(RentalActionModifyDto rentalActionModifyDto)
	{
		if (string.IsNullOrWhiteSpace(rentalActionModifyDto?.SimulatorId))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26280));
		}
		string requestUri = ApiReferenceURL.PauseRentalSession() + fJs3mAljTh;
		string content = JsonConvert.SerializeObject(rentalActionModifyDto);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(requestUri, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> ResumeRentalSession(RentalActionModifyDto rentalActionModifyDto)
	{
		if (string.IsNullOrWhiteSpace(rentalActionModifyDto?.SimulatorId))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26280));
		}
		string requestUri = ApiReferenceURL.ResumeRentalSession() + fJs3mAljTh;
		string content = JsonConvert.SerializeObject(rentalActionModifyDto);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(requestUri, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> StopRentalSession(RentalActionModifyDto rentalActionModifyDto)
	{
		if (string.IsNullOrWhiteSpace(rentalActionModifyDto?.SimulatorId))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26280));
		}
		string requestUri = ApiReferenceURL.StopRentalSession() + fJs3mAljTh;
		string content = JsonConvert.SerializeObject(rentalActionModifyDto);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(requestUri, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<string[]> EditRoles(string userNameOrEmail, string[] roles)
	{
		if (roles.Length == 0)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26470));
		}
		if (string.IsNullOrWhiteSpace(userNameOrEmail))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26550));
		}
		string content = JsonConvert.SerializeObject(roles);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(ApiReferenceURL.GetEditRolesUrl(userNameOrEmail) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return await response.Content.ReadAsAsync<string[]>();
	}

	public async Task<bool> UsernameExist(string userName)
	{
		_003C_003Ec__DisplayClass46_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass46_0();
		CS_0024_003C_003E8__locals2.VYl2NIiNej = await iNg3jKWm0d.GetStringAsync(ApiReferenceURL.GetUserNameExistUrl(userName) + fJs3mAljTh);
		return await Task.Run(() => JsonConvert.DeserializeObject<bool>(CS_0024_003C_003E8__locals2.VYl2NIiNej));
	}

	public async Task<bool> CardExist(string cardNumber)
	{
		_003C_003Ec__DisplayClass47_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass47_0();
		CS_0024_003C_003E8__locals2.Dad2IO0wqw = await iNg3jKWm0d.GetStringAsync(ApiReferenceURL.GetCardExistUrl(cardNumber) + fJs3mAljTh);
		return await Task.Run(() => JsonConvert.DeserializeObject<bool>(CS_0024_003C_003E8__locals2.Dad2IO0wqw));
	}

	public async Task<bool> EmailExist(string email)
	{
		_003C_003Ec__DisplayClass48_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass48_0();
		CS_0024_003C_003E8__locals2.u7Z2PhVa21 = await iNg3jKWm0d.GetStringAsync(ApiReferenceURL.GetEmailExistUrl(email) + fJs3mAljTh);
		return await Task.Run(() => JsonConvert.DeserializeObject<bool>(CS_0024_003C_003E8__locals2.u7Z2PhVa21));
	}

	public async Task<bool> ActivateCard(string userId, ActivateCardDto tempUserForUpdateDto)
	{
		if (tempUserForUpdateDto == null || string.IsNullOrWhiteSpace(userId))
		{
			return false;
		}
		string content = JsonConvert.SerializeObject(tempUserForUpdateDto);
		string requestUri = ApiReferenceURL.GetActivateCardUrl(userId) + fJs3mAljTh;
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(requestUri, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<UserDto> Register(UserForRegisterDto userForRegisterDto)
	{
		if (userForRegisterDto == null)
		{
			return null;
		}
		string content = JsonConvert.SerializeObject(userForRegisterDto);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(ApiReferenceURL.GetRegisterUrl() + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return await response.Content.ReadAsAsync<UserDto>();
	}

	public async Task<bool> ForgotPassword(string email, SupportedCulture? webBrowserCulture = null)
	{
		if (string.IsNullOrWhiteSpace(email))
		{
			return false;
		}
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(ApiReferenceURL.GetForgotPasswordUrl(email, webBrowserCulture) + fJs3mAljTh, new StringContent("", Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> ResetPassword(ResetPasswordDto model)
	{
		if (model == null)
		{
			return false;
		}
		string content = JsonConvert.SerializeObject(model);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(ApiReferenceURL.GetResetPasswordUrl() + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<TempPasswordDto> GenerateTemporaryPassword(string emailOrUserName)
	{
		if (string.IsNullOrEmpty(emailOrUserName))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26618));
		}
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(ApiReferenceURL.GetGenerateTemporaryPasswordUrl(emailOrUserName) + fJs3mAljTh, new StringContent("", Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return await response.Content.ReadAsAsync<TempPasswordDto>();
	}

	public async Task<IEnumerable<AppointmentDto>> GetAppointments()
	{
		_003C_003Ec__DisplayClass54_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass54_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetAppointmentsUrl() + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.csNod9tghy = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(CS_0024_003C_003E8__locals2.csNod9tghy));
	}

	public async Task<IEnumerable<AppointmentDto>> GetAppointments(AppointmentListFilter filters)
	{
		_003C_003Ec__DisplayClass55_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass55_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetAppointmentsUrl(filters));
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.nU9ou6lm2k = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(CS_0024_003C_003E8__locals2.nU9ou6lm2k));
	}

	public async Task<AppointmentDto> GetAppointmentFromSimTime(string simulatorId, DateTime now)
	{
		_003C_003Ec__DisplayClass56_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass56_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetAppointmentFromSimTimeUrl(simulatorId, now) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.ByEoRBTvww = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<AppointmentDto>(CS_0024_003C_003E8__locals2.ByEoRBTvww));
	}

	public async Task<IEnumerable<AppointmentDto>> GetAppointmentsBySite(int siteId)
	{
		_003C_003Ec__DisplayClass57_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass57_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetAppointmentsBySiteUrl(siteId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.u9NokxNqV0 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(CS_0024_003C_003E8__locals2.u9NokxNqV0));
	}

	public async Task<IEnumerable<AppointmentDto>> GetAppointmentsBySite(int siteId, DateTime date)
	{
		_003C_003Ec__DisplayClass58_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass58_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetAppointmentsBySiteDateUrl(siteId, date) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.eq6oXoZLMa = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(CS_0024_003C_003E8__locals2.eq6oXoZLMa));
	}

	public async Task<AppointmentRecurrenceDto> GetAppointmentRecurrence(int appointmentRecurrenceId)
	{
		_003C_003Ec__DisplayClass59_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass59_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetAppointmentRecurrence(appointmentRecurrenceId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.J0Sop2PuFS = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<AppointmentRecurrenceDto>(CS_0024_003C_003E8__locals2.J0Sop2PuFS));
	}

	public async Task<bool> UpdateAppointment(int id, AppointmentForUpdateDto appointmentToUpdate)
	{
		if (appointmentToUpdate == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(appointmentToUpdate);
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.GetUpdateAppointmentUrl(id) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<IoTDeviceDto> NewIotDevice(string azureDeviceId)
	{
		if (string.IsNullOrWhiteSpace(azureDeviceId))
		{
			throw new Exception(ModelInvalid);
		}
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(ApiReferenceURL.PostNewDeviceOnAzureHubUrl(Guid.NewGuid().ToString()) + fJs3mAljTh, new StringContent(string.Empty));
		await c6C35jo4PL(response);
		return JsonConvert.DeserializeObject<IoTDeviceDto>(await response.Content.ReadAsStringAsync());
	}

	public async Task<bool> TransfertSimulatorReservation(string simGiverId, string simReceiverId)
	{
		if (string.IsNullOrWhiteSpace(simGiverId) || string.IsNullOrWhiteSpace(simReceiverId))
		{
			throw new Exception(ModelInvalid);
		}
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.TransfertSimulatorReservation(simGiverId, simReceiverId) + fJs3mAljTh, new StringContent(string.Empty, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<SimulatorRemoteManagementPostDto> NewSimulatorManagement(SimulatorRemoteManagementPostDto simDto)
	{
		_ = 3;
		try
		{
			IoTDeviceDto ioTDeviceDto = await NewIotDevice(Guid.NewGuid().ToString());
			if (ioTDeviceDto == null)
			{
				throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(27010));
			}
			simDto.AzureDeviceId = ioTDeviceDto.AzureDeviceId;
			simDto.AzureSharedAccessKey = ioTDeviceDto.SharedKeyAccess;
			string content = JsonConvert.SerializeObject(simDto);
			HttpResponseMessage simCreationResponse = await iNg3jKWm0d.PostAsync(ApiReferenceURL.CreateSimulatorManagementUrl() + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
			await c6C35jo4PL(simCreationResponse);
			return await simCreationResponse.Content.ReadAsAsync<SimulatorRemoteManagementPostDto>();
		}
		catch (Exception ex)
		{
			throw new HttpRequestException(ex.Message);
		}
	}

	public async Task<bool> UpdateSimulatorManagement(string id, SimulatorRemoteManagementPutDto simForUpdate)
	{
		if (simForUpdate == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(simForUpdate);
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.UpdateSimulatorManagementUrl(id) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> RemoveSimulatorManagement(string id)
	{
		if (id == null)
		{
			throw new Exception(ModelInvalid);
		}
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.RemoveSimulatorManagementUrl(id) + fJs3mAljTh, new StringContent(string.Empty));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<IEnumerable<SimulatorRemoteManagementDto>> GetSimulatorsManagement()
	{
		_003C_003Ec__DisplayClass66_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass66_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetSimulatorsManagementUrl());
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.kMIoYrKtdZ = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SimulatorRemoteManagementDto>>(CS_0024_003C_003E8__locals2.kMIoYrKtdZ));
	}

	public async Task<IEnumerable<SimulatorDto>> GetSimulatorsBySite(int siteId)
	{
		_003C_003Ec__DisplayClass67_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass67_0();
		SimulatorListFilter filters = new SimulatorListFilter
		{
			SiteId = siteId
		};
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetSimulatorsUrl(filters));
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.l3Lo6xZ243 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SimulatorDto>>(CS_0024_003C_003E8__locals2.l3Lo6xZ243));
	}

	public async Task<IEnumerable<SimulatorDto>> GetSimulatorsAppointmentBySiteDate(int siteId, DateTime date)
	{
		_003C_003Ec__DisplayClass68_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass68_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetSimulatorsAppointmentBySiteDate(siteId, date) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.nEboBNEwV8 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SimulatorDto>>(CS_0024_003C_003E8__locals2.nEboBNEwV8));
	}

	public async Task<IEnumerable<DateTime?>> GetAppointmentAvailability(int siteId, DateTime startDate, int durationHour, int durationMin)
	{
		_003C_003Ec__DisplayClass69_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass69_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetAppointmentAvailabilityUrl(siteId, startDate, durationHour, durationMin) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.pbto2k7Lxy = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<DateTime?>>(CS_0024_003C_003E8__locals2.pbto2k7Lxy));
	}

	public async Task<IEnumerable<DateTime?>> GetAppointmentAvailabilityBySim(int siteId, DateTime startDate, int durationHour, int durationMin, string simId)
	{
		_003C_003Ec__DisplayClass70_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass70_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetAppointmentAvailabilityBySimUrl(siteId, startDate, durationHour, durationMin, simId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.iTbotdeBWI = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<DateTime?>>(CS_0024_003C_003E8__locals2.iTbotdeBWI));
	}

	public async Task<IEnumerable<AppointmentDto>> GetHasAppointmentConflict(int siteId, DateTime startDate, DateTime endDate, int day, DateTime? teeTime, int durationHour, int durationMin, string simId, int appointmentId)
	{
		_003C_003Ec__DisplayClass71_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass71_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetHasAppointmentConflictUrl(siteId, startDate, endDate, day, teeTime, durationHour, durationMin, simId, appointmentId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.HlVov7gDbb = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(CS_0024_003C_003E8__locals2.HlVov7gDbb));
	}

	public async Task<AppointmentDto> SearchAppointment(string idOrTitle, int siteId)
	{
		_003C_003Ec__DisplayClass72_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass72_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetSearchAppointment(idOrTitle, siteId));
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.pgWoecscb9 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<AppointmentDto>(CS_0024_003C_003E8__locals2.pgWoecscb9));
	}

	public async Task<AppointmentDto> AddNewAppointment(AppointmentForCreationDto appointment)
	{
		if (appointment == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(appointment);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(ApiReferenceURL.GetCreateAppointmentUrl() + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return await response.Content.ReadAsAsync<AppointmentDto>();
	}

	public async Task<AppointmentDto> AddNewAppointmentBySim(string simId, AppointmentForCreationDto appointment)
	{
		if (appointment == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(appointment);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(ApiReferenceURL.GetAddNewAppointmentBySimUrl(simId) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return await response.Content.ReadAsAsync<AppointmentDto>();
	}

	public async Task<bool> AddRecurrentAppointment(string simId, AppointmentReccurenceForCreationDto appointment)
	{
		if (appointment == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(appointment);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(ApiReferenceURL.GetAddRecurrentAppointmentUrl(simId) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return await response.Content.ReadAsAsync<bool>();
	}

	public async Task<bool> DeleteAppointment(int id, SupportedCulture? webBrowserCulture = null)
	{
		HttpResponseMessage response = await iNg3jKWm0d.DeleteAsync(ApiReferenceURL.GetDeleteAppointmentUrl(id, webBrowserCulture) + fJs3mAljTh);
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> DeleteAppointmentSeries(int id, SupportedCulture? webBrowserCulture = null)
	{
		HttpResponseMessage response = await iNg3jKWm0d.DeleteAsync(ApiReferenceURL.GetDeleteAppointmentSeriesUrl(id, webBrowserCulture) + fJs3mAljTh);
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> DeleteAppointmentSeries(AppointmentRecurrenceForDeleteDto recurrenceToDelete)
	{
		HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, ApiReferenceURL.GetDeleteAppointmentSeriesUrl() + fJs3mAljTh)
		{
			Content = new StringContent(System.Text.Json.JsonSerializer.Serialize(recurrenceToDelete), Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906))
		};
		HttpResponseMessage response = await iNg3jKWm0d.SendAsync(request);
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<IEnumerable<AppointmentHistoryDto>> GetAppointmentHistoryBySite(int siteId, DateTime dateStart, DateTime dateEnd)
	{
		_003C_003Ec__DisplayClass79_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass79_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetAppointmentHistoryBySite(siteId, dateStart, dateEnd) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.sIGo79N1qb = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<AppointmentHistoryDto>>(CS_0024_003C_003E8__locals2.sIGo79N1qb));
	}

	public async Task<IEnumerable<AppointmentHistoryDto>> GetAppointmentHistoryByReservation(int reservationId)
	{
		_003C_003Ec__DisplayClass80_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass80_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetAppointmentHistoryByReservation(reservationId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.iZ9orq4HoF = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<AppointmentHistoryDto>>(CS_0024_003C_003E8__locals2.iZ9orq4HoF));
	}

	public async Task<ActiveAppointmentSimulatorDto> GetActiveAppointmentSimulator(int id)
	{
		_003C_003Ec__DisplayClass81_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass81_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetActiveAppointmentSimulatorUrl(id) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.T9folDEYS4 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<ActiveAppointmentSimulatorDto>(CS_0024_003C_003E8__locals2.T9folDEYS4));
	}

	public async Task<ActiveAppointmentSimulatorDto> GetActiveAppointmentSimulatorFromSimId(string simulatorId)
	{
		_003C_003Ec__DisplayClass82_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass82_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetActiveAppointmentSimulatorFromSimIdUrl(simulatorId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.ypno1Sh4se = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<ActiveAppointmentSimulatorDto>(CS_0024_003C_003E8__locals2.ypno1Sh4se));
	}

	public async Task<ActiveAppointmentSimulatorDto> GetActiveAppointmentSimulatorFromAppointmentId(int appointmentId)
	{
		_003C_003Ec__DisplayClass83_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass83_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetActiveAppointmentSimulatorFromAppointmentIdUrl(appointmentId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.Vdto5WGuoZ = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<ActiveAppointmentSimulatorDto>(CS_0024_003C_003E8__locals2.Vdto5WGuoZ));
	}

	public async Task<ActiveAppointmentSimulatorDto> GetActiveAppointmentSimulatorFromRentalSessionId(int rentalSessionId)
	{
		_003C_003Ec__DisplayClass84_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass84_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetActiveAppointmentSimulatorFromRentalSessionIdUrl(rentalSessionId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.rjTom4UYpv = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<ActiveAppointmentSimulatorDto>(CS_0024_003C_003E8__locals2.rjTom4UYpv));
	}

	public async Task<IEnumerable<SiteLiteDto>> GetLiteSites()
	{
		_003C_003Ec__DisplayClass85_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass85_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetLiteSitesUrl() + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.bswofYjOqr = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SiteLiteDto>>(CS_0024_003C_003E8__locals2.bswofYjOqr));
	}

	public async Task<IEnumerable<SiteLiteDto>> GetLiteSitesForReservation()
	{
		_003C_003Ec__DisplayClass86_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass86_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetLiteSitesForReservationUrl() + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.Oo3oHu9pBZ = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SiteLiteDto>>(CS_0024_003C_003E8__locals2.Oo3oHu9pBZ));
	}

	public async Task<IEnumerable<SiteLiteForProfileDto>> GetLiteSitesForProfile()
	{
		_003C_003Ec__DisplayClass87_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass87_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetLiteSitesForProfileUrl() + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.HFPoGMVdpn = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SiteLiteForProfileDto>>(CS_0024_003C_003E8__locals2.HFPoGMVdpn));
	}

	public async Task<IEnumerable<SiteAdminSettingsDto>> GetSitesForAdminSettings()
	{
		_003C_003Ec__DisplayClass88_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass88_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetSitesForAdminSettingsUrl() + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.J2RosJ1LaD = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SiteAdminSettingsDto>>(CS_0024_003C_003E8__locals2.J2RosJ1LaD));
	}

	public async Task<SiteDto> GetSite(int siteId)
	{
		_003C_003Ec__DisplayClass89_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass89_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetSiteUrl(siteId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.hrLo9u6gec = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<SiteDto>(CS_0024_003C_003E8__locals2.hrLo9u6gec));
	}

	public async Task<bool> UpdateSite(int siteId, SiteForUpdateDto siteForUpdateDto)
	{
		if (siteForUpdateDto == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(siteForUpdateDto);
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.GetUpdateSiteUrl(siteId) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<SiteDto> NewSite(SiteForCreationDto siteDto)
	{
		if (siteDto == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(siteDto);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(ApiReferenceURL.GetNewSiteUrl() + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return await response.Content.ReadAsAsync<SiteDto>();
	}

	public async Task<SiteReservationSettingDto> GetSiteReservationSettingBySite(int siteId)
	{
		_003C_003Ec__DisplayClass92_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass92_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetSiteReservationSettingBySiteUrl(siteId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.yCYoQAsWUi = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<SiteReservationSettingDto>(CS_0024_003C_003E8__locals2.yCYoQAsWUi));
	}

	public async Task<SiteWebSettingDto> GetSiteWebSettingsBySite(int siteId)
	{
		_003C_003Ec__DisplayClass93_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass93_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetSiteWebSettingBySiteUrl(siteId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.OPuoLLsLOa = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<SiteWebSettingDto>(CS_0024_003C_003E8__locals2.OPuoLLsLOa));
	}

	public async Task<FeeScheduleDto> NewFeeSchedule(FeeScheduleForCreationDto feeScheduleDto)
	{
		if (feeScheduleDto == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(feeScheduleDto);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(ApiReferenceURL.GetNewFeeScheduleUrl() + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return await response.Content.ReadAsAsync<FeeScheduleDto>();
	}

	public async Task<bool> UpdateSimulator(string simId, SimulatorForUpdateDto simulatorForUpdateDto)
	{
		if (simulatorForUpdateDto == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(simulatorForUpdateDto);
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.GetUpdateSimulatorUrl(simId) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> UpdateSimulatorState(string simId, bool isAvailable)
	{
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.GetUpdateSimulatorStateUrl(simId, isAvailable) + fJs3mAljTh, qYu3birVMU());
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<List<DayOpeningHoursDto>> GetSiteWeekOpeningHours(int siteId)
	{
		_003C_003Ec__DisplayClass97_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass97_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetSiteWeekOpeningHoursUrl(siteId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.euDoZiOPYZ = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<List<DayOpeningHoursDto>>(CS_0024_003C_003E8__locals2.euDoZiOPYZ));
	}

	public async Task<bool> UpdateOpeningHour(int id, DayOpeningHoursForUpdateDto dayToUpdate)
	{
		if (dayToUpdate == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(dayToUpdate);
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.GetUpdateOpeningHourUrl(id) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> UpdateReservationSettings(int id, SiteReservationSettingForUpdateDto siteReservationToUpdate)
	{
		if (siteReservationToUpdate == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(siteReservationToUpdate);
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.GetUpdateReservationSettingsUrl(id) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<NotificationRecipientDto> CreateNotificationRecipient(NotificationRecipientForCreationDto notificationRecipientsDto)
	{
		if (notificationRecipientsDto == null || !pZS3U9K1Ru(notificationRecipientsDto.Email))
		{
			return null;
		}
		string content = JsonConvert.SerializeObject(notificationRecipientsDto);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(ApiReferenceURL.CreateNotificationRecipient() + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return await response.Content.ReadAsAsync<NotificationRecipientDto>();
	}

	public async Task<bool> DeleteNotificationRecipient(int id)
	{
		HttpResponseMessage response = await iNg3jKWm0d.DeleteAsync(ApiReferenceURL.GetDeleteNotificationRecipientUrl(id) + fJs3mAljTh);
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> UpdateWebSettings(int id, SiteWebSettingForUpdateDto siteWebToUpdate)
	{
		if (siteWebToUpdate == null)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(27364));
		}
		string content = JsonConvert.SerializeObject(siteWebToUpdate);
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.GetUpdateWebSettingsUrl(id) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<IEnumerable<UserDto>> GetUsers(UserListFilter filters)
	{
		_003C_003Ec__DisplayClass103_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass103_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetUsersUrl(filters));
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.lgP3HvlhRy = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<UserDto>>(CS_0024_003C_003E8__locals2.lgP3HvlhRy));
	}

	public async Task<IEnumerable<SiteUserDto>> GetMembersAndContacts(UserListFilter filters)
	{
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetMembersAndContactsUrl(filters));
		await c6C35jo4PL(response);
		return JsonConvert.DeserializeObject<IEnumerable<SiteUserDto>>(await response.Content.ReadAsStringAsync());
	}

	public async Task<IEnumerable<UserForManagementDto>> GetUserByRoleForManagement(string role)
	{
		if (!string.IsNullOrWhiteSpace(role))
		{
			_003C_003Ec__DisplayClass105_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass105_0();
			HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetUserByRoleForManagementUrl(role) + fJs3mAljTh);
			await c6C35jo4PL(response);
			CS_0024_003C_003E8__locals2.Cy03GeVRd7 = await response.Content.ReadAsStringAsync();
			return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<UserForManagementDto>>(CS_0024_003C_003E8__locals2.Cy03GeVRd7));
		}
		throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(26838));
	}

	public async Task<IEnumerable<UserForManagementDto>> GetUserByRoleForManagement(string role, int siteId)
	{
		if (!string.IsNullOrWhiteSpace(role))
		{
			_003C_003Ec__DisplayClass106_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass106_0();
			HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetUserByRoleForManagementUrl(role, siteId) + fJs3mAljTh);
			await c6C35jo4PL(response);
			CS_0024_003C_003E8__locals2.pjd3sK0fev = await response.Content.ReadAsStringAsync();
			return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<UserForManagementDto>>(CS_0024_003C_003E8__locals2.pjd3sK0fev));
		}
		throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(26838));
	}

	public async Task<UserDto> GetUser(string id)
	{
		if (!string.IsNullOrWhiteSpace(id))
		{
			_003C_003Ec__DisplayClass107_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass107_0();
			HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetUserUrl(id) + fJs3mAljTh);
			await c6C35jo4PL(response);
			CS_0024_003C_003E8__locals2.QKY39owR6b = await response.Content.ReadAsStringAsync();
			return await Task.Run(() => JsonConvert.DeserializeObject<UserDto>(CS_0024_003C_003E8__locals2.QKY39owR6b));
		}
		throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(26796));
	}

	public async Task<bool> DeleteUser(string id)
	{
		if (!string.IsNullOrWhiteSpace(id))
		{
			HttpResponseMessage response = await iNg3jKWm0d.DeleteAsync(ApiReferenceURL.GetDeleteUserUrl(id) + fJs3mAljTh);
			await c6C35jo4PL(response);
			return response.IsSuccessStatusCode;
		}
		throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(26416));
	}

	public async Task<bool> UpdateUser(string userId, UserForUpdateDto userForUpdateDto)
	{
		if (userForUpdateDto == null)
		{
			throw new Exception(ModelInvalid);
		}
		if (string.IsNullOrWhiteSpace(userId))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26324));
		}
		if (userForUpdateDto.CardNumber == string.Empty)
		{
			userForUpdateDto.CardNumber = null;
		}
		string content = JsonConvert.SerializeObject(userForUpdateDto);
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.GetUpdateUserUrl(userId) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> UpdateStaff(string staffId, StaffForUpdateDto staffForUpdateDto)
	{
		if (staffForUpdateDto == null)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(27170));
		}
		if (string.IsNullOrWhiteSpace(staffId))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(27212));
		}
		string content = JsonConvert.SerializeObject(staffForUpdateDto);
		string requestUri = ApiReferenceURL.GetUpdateStaffUrl(staffId) + fJs3mAljTh;
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(requestUri, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> UpdateMember(string userId, UserManagementUpdateDto userForUpdateDto)
	{
		if (userForUpdateDto == null)
		{
			throw new Exception(ModelInvalid);
		}
		if (string.IsNullOrWhiteSpace(userId))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26324));
		}
		string content = JsonConvert.SerializeObject(userForUpdateDto);
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.GetUpdateMemberUrl(userId) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<UserDto> GetUserByCardNumber(string cardNumber)
	{
		if (!string.IsNullOrWhiteSpace(cardNumber))
		{
			_003C_003Ec__DisplayClass112_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass112_0();
			HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetUserByCardNumberUrl(cardNumber) + fJs3mAljTh);
			await c6C35jo4PL(response);
			CS_0024_003C_003E8__locals2.kei3QD8p2D = await response.Content.ReadAsStringAsync();
			return await Task.Run(() => JsonConvert.DeserializeObject<UserDto>(CS_0024_003C_003E8__locals2.kei3QD8p2D));
		}
		throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(26796));
	}

	public async Task<UserDto> GetUserByCardNumberWithinSite(string cardNumber, int siteId)
	{
		_003C_003Ec__DisplayClass113_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass113_0();
		if (string.IsNullOrWhiteSpace(cardNumber))
		{
			throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(26796));
		}
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetUserByCardNumberWithinSiteUrl(cardNumber, siteId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.TBI3LPp9kR = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<UserDto>(CS_0024_003C_003E8__locals2.TBI3LPp9kR));
	}

	public async Task<UserDto> GetUserByString(string userNameOrEmail)
	{
		if (!string.IsNullOrWhiteSpace(userNameOrEmail))
		{
			_003C_003Ec__DisplayClass114_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass114_0();
			HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetUserByStringUrl(userNameOrEmail) + fJs3mAljTh);
			await c6C35jo4PL(response);
			CS_0024_003C_003E8__locals2.MEP3ZvukNn = await response.Content.ReadAsStringAsync();
			return await Task.Run(() => JsonConvert.DeserializeObject<UserDto>(CS_0024_003C_003E8__locals2.MEP3ZvukNn));
		}
		throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(26796));
	}

	public async Task<bool> ChangePassword(string userId, ChangePasswordDto changePasswordDto)
	{
		if (changePasswordDto == null)
		{
			throw new Exception(ModelInvalid);
		}
		if (string.IsNullOrWhiteSpace(userId))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26324));
		}
		string content = JsonConvert.SerializeObject(changePasswordDto);
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.GetChangePasswordUrl(userId) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<UserDto> VerifyCardNumber(string cardNumber)
	{
		throw new NotImplementedException();
	}

	public async Task<SiteStatistic> GetSiteStatistic(int siteId)
	{
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetSiteStatistic(siteId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		return JsonConvert.DeserializeObject<SiteStatistic>(await response.Content.ReadAsStringAsync());
	}

	public async Task<List<AppointmentDto>> GetMemberAppointments(string userId)
	{
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetMemberAppointments(userId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		return JsonConvert.DeserializeObject<List<AppointmentDto>>(await response.Content.ReadAsStringAsync());
	}

	public async Task<bool> UpdateUserSiteId(string userId, int siteId)
	{
		if (string.IsNullOrWhiteSpace(userId))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26324));
		}
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.GetUpdateUserSiteId(userId, siteId) + fJs3mAljTh, new StringContent("", Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> AddCardTransaction(string userId, NewCardTransactionDto newCardTxDto)
	{
		if (newCardTxDto == null || string.IsNullOrWhiteSpace(userId))
		{
			return false;
		}
		string content = JsonConvert.SerializeObject(newCardTxDto);
		string addCardTransactionUrl = ApiReferenceURL.GetAddCardTransactionUrl(userId);
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(addCardTransactionUrl + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<IEnumerable<PromotionDto>> GetPromotions()
	{
		_003C_003Ec__DisplayClass121_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass121_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetPromotionsUrl() + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.Li43SH1UTJ = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<PromotionDto>>(CS_0024_003C_003E8__locals2.Li43SH1UTJ));
	}

	public async Task<IEnumerable<PromotionDto>> GetPromotions(int siteId)
	{
		_003C_003Ec__DisplayClass122_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass122_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetPromotionsUrl(siteId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.yK13Nlexnj = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<PromotionDto>>(CS_0024_003C_003E8__locals2.yK13Nlexnj));
	}

	public async Task<PromotionDto> NewPromotion(PromotionForCreationDto promoDto)
	{
		if (promoDto == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(promoDto);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(ApiReferenceURL.GetNewPromotionUrl() + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return await response.Content.ReadAsAsync<PromotionDto>();
	}

	public async Task<bool> UpdatePromotion(int id, PromotionForUpdateDto promoForUpdate)
	{
		if (promoForUpdate == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(promoForUpdate);
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.GetUpdatePromotionUrl(id) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> DeletePromo(int id)
	{
		HttpResponseMessage response = await iNg3jKWm0d.DeleteAsync(ApiReferenceURL.GetDeletePromoUrl(id) + fJs3mAljTh);
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<FeeScheduleDto> GetSiteFeeSchedule(int siteId)
	{
		_003C_003Ec__DisplayClass126_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass126_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetSiteFeeScheduleUrl(siteId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.JH63I5ORj1 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<FeeScheduleDto>(CS_0024_003C_003E8__locals2.JH63I5ORj1));
	}

	public async Task<bool> ChangeFeeScheduleRate(HourRateToUpdateDto hourRateDtoToUpdate)
	{
		if (hourRateDtoToUpdate == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(hourRateDtoToUpdate);
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.GetChangeFeeScheduleRateUrl() + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<IEnumerable<SalesReportDto>> GetTodaySales(int siteId, TimeSpan offset)
	{
		_003C_003Ec__DisplayClass128_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass128_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetTodaySalesUrl(siteId, offset) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.GXT3PP1ksr = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.GXT3PP1ksr));
	}

	public async Task<IEnumerable<SalesReportDto>> GetYesterdaySales(int siteId)
	{
		_003C_003Ec__DisplayClass129_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass129_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetYesterdaySalesUrl(siteId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.WsF2dMCNw4 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.WsF2dMCNw4));
	}

	public async Task<IEnumerable<SalesReportDto>> GetThisWeekSales(int siteId)
	{
		_003C_003Ec__DisplayClass130_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass130_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetThisWeekSales(siteId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.XCv2u0u5JM = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.XCv2u0u5JM));
	}

	public async Task<IEnumerable<SalesReportDto>> GetLastWeekSales(int siteId)
	{
		_003C_003Ec__DisplayClass131_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass131_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetLastWeekSales(siteId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.fMf2RNxrhI = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.fMf2RNxrhI));
	}

	public async Task<IEnumerable<SalesReportDto>> GetThisMonthSales(int siteId)
	{
		_003C_003Ec__DisplayClass132_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass132_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetThisMonthSalesUrl(siteId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.wKv2kuyDI8 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.wKv2kuyDI8));
	}

	public async Task<IEnumerable<SalesReportDto>> GetLastMonthSales(int siteId)
	{
		_003C_003Ec__DisplayClass133_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass133_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetLastMonthSalesUrl(siteId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.GVe2XkmQo3 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.GVe2XkmQo3));
	}

	public async Task<IEnumerable<SalesReportDto>> GetDaySales(int siteId, DateTime time)
	{
		_003C_003Ec__DisplayClass134_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass134_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetDaySalesUrl(siteId, time.Year, time.Month, time.Day) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.vGg2pT8Tll = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.vGg2pT8Tll));
	}

	public async Task<IEnumerable<SalesReportDto>> GetWeeklySales(int siteId, DateTime time)
	{
		_003C_003Ec__DisplayClass135_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass135_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetWeeklySalesUrl(siteId, time.Year, time.Month, time.Day) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.rSs2YyDBxG = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.rSs2YyDBxG));
	}

	public async Task<IEnumerable<SalesReportDto>> GetMonthlySales(int siteId, int month)
	{
		_003C_003Ec__DisplayClass136_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass136_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetMonthlySalesUrl(siteId, month) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.W6W26fP6gL = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.W6W26fP6gL));
	}

	public async Task<IEnumerable<SalesReportDto>> BetweenTwoDate(int siteId, DateTime startDate, DateTime endDate)
	{
		_003C_003Ec__DisplayClass137_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass137_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetBetweenTwoDateUrl(siteId, startDate.Year, startDate.Month, startDate.Day, endDate.Year, endDate.Month, endDate.Day) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.jYc2BvkRmW = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.jYc2BvkRmW));
	}

	[Obsolete("Only use in Monitor V2")]
	public async Task<IEnumerable<PlayerInvoiceSalesReportDto>> GetPlayerInvoices(int rentalInvoiceId)
	{
		_003C_003Ec__DisplayClass138_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass138_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetPlayerInvoicesUrl(rentalInvoiceId) + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.e5q22FoICf = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<PlayerInvoiceSalesReportDto>>(CS_0024_003C_003E8__locals2.e5q22FoICf));
	}

	public async Task<IEnumerable<ReleaseNoteDto>> GetAllReleaseNotes()
	{
		_003C_003Ec__DisplayClass139_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass139_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetAllReleaseNotesUrl() + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.a2h2tP3PRY = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<ReleaseNoteDto>>(CS_0024_003C_003E8__locals2.a2h2tP3PRY));
	}

	public async Task<bool> UpdateReleaseNotes(IEnumerable<ReleaseNoteDto> releasesNotes)
	{
		if (releasesNotes == null)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(27110));
		}
		string text = JsonConvert.SerializeObject(releasesNotes);
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.GetUpdateReleaseNotesUrl() + fJs3mAljTh, qYu3birVMU(text));
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> HasCurrentUserSeenLatestReleaseNote()
	{
		_003C_003Ec__DisplayClass141_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass141_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetHasCurrentUserSeenLatestReleaseNote() + fJs3mAljTh);
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.lsQ2ex3odg = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<bool>(CS_0024_003C_003E8__locals2.lsQ2ex3odg));
	}

	public async Task<bool> NotifyNewReleaseNote()
	{
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.GetNotifyNewReleaseNote() + fJs3mAljTh, qYu3birVMU());
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> MarkNewReleaseNoteViewByCurrentUser()
	{
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.MarkNewReleaseNoteViewByCurrentUser() + fJs3mAljTh, qYu3birVMU());
		await c6C35jo4PL(response);
		return response.IsSuccessStatusCode;
	}

	private static StringContent qYu3birVMU(string P_0 = null)
	{
		return new StringContent(P_0 ?? string.Empty, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906));
	}

	private static async Task c6C35jo4PL(HttpResponseMessage P_0)
	{
		if (!P_0.IsSuccessStatusCode)
		{
			string value = await P_0.Content.ReadAsStringAsync();
			string message = so95DAFNMfktfjp4Dm.An6v7kuCGg(27418);
			try
			{
				message = JsonConvert.DeserializeObject<string>(value) ?? so95DAFNMfktfjp4Dm.An6v7kuCGg(27418);
			}
			catch (Exception)
			{
			}
			throw new HttpRequestException(message);
		}
	}

	private static bool pZS3U9K1Ru(string P_0)
	{
		string pattern = so95DAFNMfktfjp4Dm.An6v7kuCGg(10428);
		return Regex.IsMatch(P_0, pattern);
	}

	public async Task<PagedResult<ContactDto>> GetContacts(ContactListFilter filters)
	{
		string text = ApiReferenceURL.GetContactsUrl(filters);
		if (filters.SiteId.HasValue)
		{
			string text2 = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
			defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(14440));
			defaultInterpolatedStringHandler.AppendFormatted(filters.SiteId);
			text = text2 + defaultInterpolatedStringHandler.ToStringAndClear();
		}
		if (!string.IsNullOrWhiteSpace(filters.FullName))
		{
			text = text + so95DAFNMfktfjp4Dm.An6v7kuCGg(27476) + filters.FullName;
		}
		if (!string.IsNullOrWhiteSpace(filters.Email))
		{
			text = text + so95DAFNMfktfjp4Dm.An6v7kuCGg(27500) + filters.Email;
		}
		if (!string.IsNullOrWhiteSpace(filters.PhoneNumber))
		{
			text = text + so95DAFNMfktfjp4Dm.An6v7kuCGg(27518) + filters.PhoneNumber;
		}
		if (filters.HasSubscribedToNews.HasValue)
		{
			string text3 = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(21, 1);
			defaultInterpolatedStringHandler2.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(27548));
			defaultInterpolatedStringHandler2.AppendFormatted(filters.HasSubscribedToNews);
			text = text3 + defaultInterpolatedStringHandler2.ToStringAndClear();
		}
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(text);
		await c6C35jo4PL(response);
		return JsonConvert.DeserializeObject<PagedResult<ContactDto>>(await response.Content.ReadAsStringAsync());
	}

	public async Task<ContactDto> CreateContact(CreateContactDto contact)
	{
		string content = JsonConvert.SerializeObject(contact);
		HttpResponseMessage response = await iNg3jKWm0d.PostAsync(ApiReferenceURL.GetBaseContactUrl() + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return JsonConvert.DeserializeObject<ContactDto>(await response.Content.ReadAsStringAsync());
	}

	public async Task<ContactDto> UpdateContact(ContactDto contact, int id)
	{
		string content = JsonConvert.SerializeObject(contact);
		HttpResponseMessage response = await iNg3jKWm0d.PutAsync(ApiReferenceURL.GetUpdateContactUrl(id) + fJs3mAljTh, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await c6C35jo4PL(response);
		return JsonConvert.DeserializeObject<ContactDto>(await response.Content.ReadAsStringAsync());
	}

	public async Task<bool> DeleteContact(int id)
	{
		await c6C35jo4PL(await iNg3jKWm0d.DeleteAsync(ApiReferenceURL.GetUpdateContactUrl(id) + fJs3mAljTh));
		return true;
	}

	public async Task<IEnumerable<DateTime?>> GetAvailabilitiesBySim(SimulatorAvailabilityDto availabilityDto)
	{
		_003C_003Ec__DisplayClass151_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass151_0();
		HttpResponseMessage response = await iNg3jKWm0d.GetAsync(ApiReferenceURL.GetBaseSimulatorAvailabilityUrl(availabilityDto));
		await c6C35jo4PL(response);
		CS_0024_003C_003E8__locals2.uag2r3hBNP = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<DateTime?>>(CS_0024_003C_003E8__locals2.uag2r3hBNP));
	}

	static ZoneGolfinApiV2()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		AIX3fSkMbD = so95DAFNMfktfjp4Dm.An6v7kuCGg(10528);
	}
}
