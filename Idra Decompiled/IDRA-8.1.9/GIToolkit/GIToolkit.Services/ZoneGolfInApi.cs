using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
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
using RichardSzalay.MockHttp;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class ZoneGolfInApi : IZoneGolfInApi, IDisposable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass103_0
	{
		public string oGXEvNai4P;

		public _003C_003Ec__DisplayClass103_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<UserDto> tk6EDDLPDv()
		{
			return JsonConvert.DeserializeObject<IEnumerable<UserDto>>(oGXEvNai4P);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass104_0
	{
		public string yF0Ee36suh;

		public _003C_003Ec__DisplayClass104_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<UserForManagementDto> Rg5EJXJGwQ()
		{
			return JsonConvert.DeserializeObject<IEnumerable<UserForManagementDto>>(yF0Ee36suh);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass105_0
	{
		public string R5SE7LVppH;

		public _003C_003Ec__DisplayClass105_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<UserForManagementDto> iEPEK7RSil()
		{
			return JsonConvert.DeserializeObject<IEnumerable<UserForManagementDto>>(R5SE7LVppH);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass106_0
	{
		public string wkUEr0rCJv;

		public _003C_003Ec__DisplayClass106_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal UserDto tQEE4T6Ge6()
		{
			return JsonConvert.DeserializeObject<UserDto>(wkUEr0rCJv);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass111_0
	{
		public string eXXEl2yIRh;

		public _003C_003Ec__DisplayClass111_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal UserDto bHqE8Ba7xC()
		{
			return JsonConvert.DeserializeObject<UserDto>(eXXEl2yIRh);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass112_0
	{
		public string FqtE1cOH90;

		public _003C_003Ec__DisplayClass112_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal UserDto QMNEnOiIHn()
		{
			return JsonConvert.DeserializeObject<UserDto>(FqtE1cOH90);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass113_0
	{
		public string r0rE5kF9VI;

		public _003C_003Ec__DisplayClass113_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal UserDto XaVEbHlDT1()
		{
			return JsonConvert.DeserializeObject<UserDto>(r0rE5kF9VI);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass120_0
	{
		public string TWYEmWdQRJ;

		public _003C_003Ec__DisplayClass120_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<PromotionDto> PGLEUDqFWP()
		{
			return JsonConvert.DeserializeObject<IEnumerable<PromotionDto>>(TWYEmWdQRJ);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass121_0
	{
		public string NlZEfjNbnl;

		public _003C_003Ec__DisplayClass121_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<PromotionDto> unKEjT9QD2()
		{
			return JsonConvert.DeserializeObject<IEnumerable<PromotionDto>>(NlZEfjNbnl);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass125_0
	{
		public string jr1EHsJaMe;

		public _003C_003Ec__DisplayClass125_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal FeeScheduleDto rFbEyuG7PF()
		{
			return JsonConvert.DeserializeObject<FeeScheduleDto>(jr1EHsJaMe);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass127_0
	{
		public string XuMEGYpuIJ;

		public _003C_003Ec__DisplayClass127_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> mpsEwe9W34()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(XuMEGYpuIJ);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass128_0
	{
		public string vxiEsspevR;

		public _003C_003Ec__DisplayClass128_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> uaMECQBbcK()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(vxiEsspevR);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass129_0
	{
		public string ttWE99tBT7;

		public _003C_003Ec__DisplayClass129_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> BqPEOjMWwM()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(ttWE99tBT7);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass130_0
	{
		public string m7IEQpnZx3;

		public _003C_003Ec__DisplayClass130_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> PPeEhClHoA()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(m7IEQpnZx3);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass131_0
	{
		public string e0dELY4wrA;

		public _003C_003Ec__DisplayClass131_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> GQKETd456p()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(e0dELY4wrA);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass132_0
	{
		public string GPpEZH1YO6;

		public _003C_003Ec__DisplayClass132_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> CbLE0ByZKl()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(GPpEZH1YO6);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass133_0
	{
		public string NMCESY77Rk;

		public _003C_003Ec__DisplayClass133_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> qYNEMAFO6k()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(NMCESY77Rk);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass134_0
	{
		public string fFLENcq5B1;

		public _003C_003Ec__DisplayClass134_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> B5cEgNkZBh()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(fFLENcq5B1);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass135_0
	{
		public string WPfEI7j25C;

		public _003C_003Ec__DisplayClass135_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> K5AEciU6Wx()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(WPfEI7j25C);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass136_0
	{
		public string HgiEPM54om;

		public _003C_003Ec__DisplayClass136_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SalesReportDto> b3fEqIrW1W()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(HgiEPM54om);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass137_0
	{
		public string dScBdoeUyi;

		public _003C_003Ec__DisplayClass137_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<PlayerInvoiceSalesReportDto> v7KEzHVEO4()
		{
			return JsonConvert.DeserializeObject<IEnumerable<PlayerInvoiceSalesReportDto>>(dScBdoeUyi);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass138_0
	{
		public string nqxBuelgZi;

		public _003C_003Ec__DisplayClass138_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<ReleaseNoteDto> kptBiffBOT()
		{
			return JsonConvert.DeserializeObject<IEnumerable<ReleaseNoteDto>>(nqxBuelgZi);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass140_0
	{
		public string r0DBRemgQu;

		public _003C_003Ec__DisplayClass140_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal bool y6cBVDp7Gn()
		{
			return JsonConvert.DeserializeObject<bool>(r0DBRemgQu);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public string bk7Bkn3mv7;

		public _003C_003Ec__DisplayClass14_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal List<UserForManagementDto> IBDBADgD8Z()
		{
			return JsonConvert.DeserializeObject<List<UserForManagementDto>>(bk7Bkn3mv7);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public string TrdBXQan7t;

		public _003C_003Ec__DisplayClass15_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SiteLiteDto> IQQBaqY6d5()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SiteLiteDto>>(TrdBXQan7t);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public string oSIBpaNPRm;

		public _003C_003Ec__DisplayClass17_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<PromotionDto> z8CBFq12VD()
		{
			return JsonConvert.DeserializeObject<IEnumerable<PromotionDto>>(oSIBpaNPRm);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public string WcPBYS7aSH;

		public _003C_003Ec__DisplayClass18_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal SimulatorDto LocBWuI7GE()
		{
			return JsonConvert.DeserializeObject<SimulatorDto>(WcPBYS7aSH);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public string EDeB6D69d2;

		public _003C_003Ec__DisplayClass19_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IoTDeviceDto UI7BxjvfYu()
		{
			return JsonConvert.DeserializeObject<IoTDeviceDto>(EDeB6D69d2);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public string zc5BBxUJNg;

		public _003C_003Ec__DisplayClass20_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal SimulatorDto xACBEmCfUn()
		{
			return JsonConvert.DeserializeObject<SimulatorDto>(zc5BBxUJNg);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public string z36B2xXEY5;

		public _003C_003Ec__DisplayClass21_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<IoTDeviceDto> RL4B3JxGKR()
		{
			return JsonConvert.DeserializeObject<IEnumerable<IoTDeviceDto>>(z36B2xXEY5);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public string PCrBtAkcHK;

		public _003C_003Ec__DisplayClass22_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IoTDeviceStatusDto qesBoZ9VCV()
		{
			return JsonConvert.DeserializeObject<IoTDeviceStatusDto>(PCrBtAkcHK);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public string gIRBvANCYW;

		public _003C_003Ec__DisplayClass23_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IoTDeviceStatusDto fUABDJlOEW()
		{
			return JsonConvert.DeserializeObject<IoTDeviceStatusDto>(gIRBvANCYW);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public string JxVBeTyWS3;

		public _003C_003Ec__DisplayClass24_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IoTDeviceStatusDto iKTBJ6OrBo()
		{
			return JsonConvert.DeserializeObject<IoTDeviceStatusDto>(JxVBeTyWS3);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public string OT8B7nki5H;

		public _003C_003Ec__DisplayClass25_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IoTDeviceDto ibvBKAqiMJ()
		{
			return JsonConvert.DeserializeObject<IoTDeviceDto>(OT8B7nki5H);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public string RI4BrhoKGK;

		public _003C_003Ec__DisplayClass28_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal RentalInvoiceDto zDfB45wd8J()
		{
			return JsonConvert.DeserializeObject<RentalInvoiceDto>(RI4BrhoKGK);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public string U7xBlTySYn;

		public _003C_003Ec__DisplayClass29_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal NewRentalInvoiceDto EecB8rWBcT()
		{
			return JsonConvert.DeserializeObject<NewRentalInvoiceDto>(U7xBlTySYn);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public string KyiB1tLqFe;

		public _003C_003Ec__DisplayClass31_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal bool L3qBnq7vab()
		{
			return JsonConvert.DeserializeObject<bool>(KyiB1tLqFe);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public string TKNB5Avg9U;

		public _003C_003Ec__DisplayClass37_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal bool QTiBbqKLwO()
		{
			return JsonConvert.DeserializeObject<bool>(TKNB5Avg9U);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public string Cr1BmoM7O4;

		public _003C_003Ec__DisplayClass47_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal bool GZ0BUc3HfY()
		{
			return JsonConvert.DeserializeObject<bool>(Cr1BmoM7O4);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass48_0
	{
		public string r9ZBfiZCp3;

		public _003C_003Ec__DisplayClass48_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal bool GN5BjgJPwc()
		{
			return JsonConvert.DeserializeObject<bool>(r9ZBfiZCp3);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public string LUcBHGUYKf;

		public _003C_003Ec__DisplayClass49_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal bool m4IByrMPyr()
		{
			return JsonConvert.DeserializeObject<bool>(LUcBHGUYKf);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public string y3QBGsbDYq;

		public _003C_003Ec__DisplayClass55_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<AppointmentDto> fjrBwbQ5Lu()
		{
			return JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(y3QBGsbDYq);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public string uTHBstYTdd;

		public _003C_003Ec__DisplayClass56_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<AppointmentDto> C0UBCvCmwn()
		{
			return JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(uTHBstYTdd);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public string TKDB9SpfCA;

		public _003C_003Ec__DisplayClass57_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal AppointmentDto kFiBOqbFaR()
		{
			return JsonConvert.DeserializeObject<AppointmentDto>(TKDB9SpfCA);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public string Wk5BQp9O5q;

		public _003C_003Ec__DisplayClass58_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<AppointmentDto> K00Bh3kRgZ()
		{
			return JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(Wk5BQp9O5q);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public string bbTBL4XHt0;

		public _003C_003Ec__DisplayClass59_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<AppointmentDto> zMdBTduxk4()
		{
			return JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(bbTBL4XHt0);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public string d8hBZlYjo0;

		public _003C_003Ec__DisplayClass60_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal AppointmentRecurrenceDto DvtB0labjB()
		{
			return JsonConvert.DeserializeObject<AppointmentRecurrenceDto>(d8hBZlYjo0);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public string tIeBSjqw0E;

		public _003C_003Ec__DisplayClass67_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SimulatorRemoteManagementDto> KybBMegVCL()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SimulatorRemoteManagementDto>>(tIeBSjqw0E);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass68_0
	{
		public string Cf3BNp1JIU;

		public _003C_003Ec__DisplayClass68_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SimulatorDto> DAABg87JUu()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SimulatorDto>>(Cf3BNp1JIU);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public string zwlBIcLXTf;

		public _003C_003Ec__DisplayClass69_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SimulatorDto> wYMBcmNytE()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SimulatorDto>>(zwlBIcLXTf);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass70_0
	{
		public string o3aBPyci5V;

		public _003C_003Ec__DisplayClass70_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<DateTime?> QuCBqRT29m()
		{
			return JsonConvert.DeserializeObject<IEnumerable<DateTime?>>(o3aBPyci5V);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass71_0
	{
		public string e3H3d7yyhk;

		public _003C_003Ec__DisplayClass71_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<DateTime?> WMyBzFqqHl()
		{
			return JsonConvert.DeserializeObject<IEnumerable<DateTime?>>(e3H3d7yyhk);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass72_0
	{
		public string dXr3u6K0tr;

		public _003C_003Ec__DisplayClass72_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<AppointmentDto> rmQ3icO3yk()
		{
			return JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(dXr3u6K0tr);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass73_0
	{
		public string UNm3RlDOG1;

		public _003C_003Ec__DisplayClass73_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal AppointmentDto euW3Vl7qip()
		{
			return JsonConvert.DeserializeObject<AppointmentDto>(UNm3RlDOG1);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public string Lt43kOn3XE;

		public _003C_003Ec__DisplayClass79_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<AppointmentHistoryDto> Hy43A9h2VI()
		{
			return JsonConvert.DeserializeObject<IEnumerable<AppointmentHistoryDto>>(Lt43kOn3XE);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass80_0
	{
		public string xhM3XKMyV1;

		public _003C_003Ec__DisplayClass80_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<AppointmentHistoryDto> NcJ3av5Rll()
		{
			return JsonConvert.DeserializeObject<IEnumerable<AppointmentHistoryDto>>(xhM3XKMyV1);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass81_0
	{
		public string OMi3pyRjZu;

		public _003C_003Ec__DisplayClass81_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal ActiveAppointmentSimulatorDto VDJ3F3IZsF()
		{
			return JsonConvert.DeserializeObject<ActiveAppointmentSimulatorDto>(OMi3pyRjZu);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass82_0
	{
		public string DQK3Yrl8Eg;

		public _003C_003Ec__DisplayClass82_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal ActiveAppointmentSimulatorDto oiN3WWNo9K()
		{
			return JsonConvert.DeserializeObject<ActiveAppointmentSimulatorDto>(DQK3Yrl8Eg);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass83_0
	{
		public string Dgx367hIE9;

		public _003C_003Ec__DisplayClass83_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal ActiveAppointmentSimulatorDto Lb83xRfqeB()
		{
			return JsonConvert.DeserializeObject<ActiveAppointmentSimulatorDto>(Dgx367hIE9);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass84_0
	{
		public string eW83BHmZlm;

		public _003C_003Ec__DisplayClass84_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal ActiveAppointmentSimulatorDto ILW3EOjYjJ()
		{
			return JsonConvert.DeserializeObject<ActiveAppointmentSimulatorDto>(eW83BHmZlm);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass85_0
	{
		public string qB132TgoSJ;

		public _003C_003Ec__DisplayClass85_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SiteLiteDto> SHc33TKu6q()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SiteLiteDto>>(qB132TgoSJ);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass86_0
	{
		public string rSi3tvRgNq;

		public _003C_003Ec__DisplayClass86_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SiteLiteDto> Bxy3o4JvYq()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SiteLiteDto>>(rSi3tvRgNq);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass87_0
	{
		public string KQs3vr3QCK;

		public _003C_003Ec__DisplayClass87_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SiteLiteForProfileDto> VvN3DXRAyR()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SiteLiteForProfileDto>>(KQs3vr3QCK);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass88_0
	{
		public string mBS3ej9DhH;

		public _003C_003Ec__DisplayClass88_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal IEnumerable<SiteAdminSettingsDto> d1P3JYmFhv()
		{
			return JsonConvert.DeserializeObject<IEnumerable<SiteAdminSettingsDto>>(mBS3ej9DhH);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass89_0
	{
		public string Fh237X6NjM;

		public _003C_003Ec__DisplayClass89_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal SiteDto J8m3K7NTjW()
		{
			return JsonConvert.DeserializeObject<SiteDto>(Fh237X6NjM);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass92_0
	{
		public string Oeb3rVie6u;

		public _003C_003Ec__DisplayClass92_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal SiteReservationSettingDto W4M34bk3JK()
		{
			return JsonConvert.DeserializeObject<SiteReservationSettingDto>(Oeb3rVie6u);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public string Vty3l6nU12;

		public _003C_003Ec__DisplayClass93_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal SiteWebSettingDto aaw38oBZay()
		{
			return JsonConvert.DeserializeObject<SiteWebSettingDto>(Vty3l6nU12);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass97_0
	{
		public string a2s31PYSjh;

		public _003C_003Ec__DisplayClass97_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal List<DayOpeningHoursDto> RnY3nI43Q5()
		{
			return JsonConvert.DeserializeObject<List<DayOpeningHoursDto>>(a2s31PYSjh);
		}
	}

	private string MLKE2hNsvB;

	private readonly HttpClient V9AEoihwnS;

	[CompilerGenerated]
	private static readonly string f5YEtab6Zg;

	public static string ModelInvalid
	{
		[CompilerGenerated]
		get
		{
			return f5YEtab6Zg;
		}
	}

	public ZoneGolfInApi(int timeoutSec = 120, MockHttpMessageHandler mockHandler = null)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		MLKE2hNsvB = so95DAFNMfktfjp4Dm.An6v7kuCGg(9838);
		base._002Ector();
		if (mockHandler == null)
		{
			V9AEoihwnS = new HttpClient
			{
				Timeout = TimeSpan.FromSeconds(timeoutSec)
			};
		}
		else
		{
			V9AEoihwnS = mockHandler.ToHttpClient();
			V9AEoihwnS.BaseAddress = new Uri(so95DAFNMfktfjp4Dm.An6v7kuCGg(9870));
		}
		V9AEoihwnS.DefaultRequestHeaders.Accept.Clear();
		V9AEoihwnS.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		V9AEoihwnS.DefaultRequestHeaders.ConnectionClose = true;
	}

	public void ChangeCurrentCulture(SupportedCulture newCulture)
	{
		switch (newCulture)
		{
		case SupportedCulture.FR_CA:
			MLKE2hNsvB = so95DAFNMfktfjp4Dm.An6v7kuCGg(9942);
			break;
		case SupportedCulture.EN_US:
			MLKE2hNsvB = so95DAFNMfktfjp4Dm.An6v7kuCGg(9838);
			break;
		default:
			MLKE2hNsvB = so95DAFNMfktfjp4Dm.An6v7kuCGg(9838);
			break;
		}
	}

	public string GetCurrentAPICulture()
	{
		return MLKE2hNsvB;
	}

	public void SetApiToUse(AvailableAPI api)
	{
		switch (api)
		{
		case AvailableAPI.PROD:
			V9AEoihwnS.BaseAddress = new Uri(so95DAFNMfktfjp4Dm.An6v7kuCGg(9974));
			break;
		case AvailableAPI.QA:
			V9AEoihwnS.BaseAddress = new Uri(so95DAFNMfktfjp4Dm.An6v7kuCGg(10074));
			break;
		case AvailableAPI.DEV:
			V9AEoihwnS.BaseAddress = new Uri(so95DAFNMfktfjp4Dm.An6v7kuCGg(10170));
			break;
		case AvailableAPI.LOCAL:
			V9AEoihwnS.BaseAddress = new Uri(so95DAFNMfktfjp4Dm.An6v7kuCGg(10268));
			break;
		default:
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(10324));
		}
	}

	public void SetApiToUse(string apiUrl)
	{
		V9AEoihwnS.BaseAddress = new Uri(apiUrl);
	}

	public string GetApiUrl()
	{
		return V9AEoihwnS.BaseAddress.ToString();
	}

	public async Task<T> Login<T>(UserForLoginDto userForLoginDto) where T : class
	{
		if (userForLoginDto == null)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26976));
		}
		string content = JsonConvert.SerializeObject(userForLoginDto);
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(ApiReferenceURL.GetLoginUrl() + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		LoggedInfo loggedInfo = await response.Content.ReadAsAsync<LoggedInfo>();
		V9AEoihwnS.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(so95DAFNMfktfjp4Dm.An6v7kuCGg(10412), loggedInfo.Token);
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
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(ApiReferenceURL.GetLoginWithCardNumberUrl() + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		LoggedInfo loggedInfo = await response.Content.ReadAsAsync<LoggedInfo>();
		SetAuthorization(loggedInfo.Token);
		return loggedInfo;
	}

	public async Task<List<UserForManagementDto>> GetAllEmployees()
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass14_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(so95DAFNMfktfjp4Dm.An6v7kuCGg(26670) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.bk7Bkn3mv7 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<List<UserForManagementDto>>(CS_0024_003C_003E8__locals2.bk7Bkn3mv7));
	}

	public async Task<IEnumerable<SiteLiteDto>> GetAllLiteSites()
	{
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass15_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetLiteSitesUrl() + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.TrdBXQan7t = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SiteLiteDto>>(CS_0024_003C_003E8__locals2.TrdBXQan7t));
	}

	public async Task<UserDto> UpdateTestMember(string cardNumber, decimal defaultHourlyRate, UserUnitTestDto model)
	{
		HttpClient v9AEoihwnS = V9AEoihwnS;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(27264));
		defaultInterpolatedStringHandler.AppendFormatted(cardNumber);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(defaultHourlyRate);
		HttpResponseMessage response = await v9AEoihwnS.PutAsJsonAsync(defaultInterpolatedStringHandler.ToStringAndClear() + MLKE2hNsvB, model);
		await DjWEBMAHle(response);
		if (response.IsSuccessStatusCode)
		{
			return await response.Content.ReadAsAsync<UserDto>();
		}
		throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(27302));
	}

	public async Task<IEnumerable<PromotionDto>> GetDefaultPromotions()
	{
		_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass17_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetDefaultPromotions() + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.oSIBpaNPRm = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<PromotionDto>>(CS_0024_003C_003E8__locals2.oSIBpaNPRm));
	}

	public async Task<SimulatorDto> GetSimulatorExist(string simId)
	{
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass18_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetSimulatorExist(simId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.WcPBYS7aSH = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<SimulatorDto>(CS_0024_003C_003E8__locals2.WcPBYS7aSH));
	}

	public async Task<IoTDeviceDto> GetIoTDevice(string DeviceID)
	{
		_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass19_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetIoTDevice(DeviceID) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.EDeB6D69d2 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IoTDeviceDto>(CS_0024_003C_003E8__locals2.EDeB6D69d2));
	}

	public async Task<SimulatorDto> GetSimulatorForRemote(string simId)
	{
		_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass20_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetSimulatorForRemote(simId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.zc5BBxUJNg = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<SimulatorDto>(CS_0024_003C_003E8__locals2.zc5BBxUJNg));
	}

	public async Task<IEnumerable<IoTDeviceDto>> GetUnPairedIoTDevices()
	{
		_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass21_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetUnPairedIoTDevicesUrl() + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.z36B2xXEY5 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<IoTDeviceDto>>(CS_0024_003C_003E8__locals2.z36B2xXEY5));
	}

	public async Task<IoTDeviceStatusDto> GetIoTDeviceStatus(int DeviceID)
	{
		_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass22_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetIoTDeviceStatus(DeviceID) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.PCrBtAkcHK = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IoTDeviceStatusDto>(CS_0024_003C_003E8__locals2.PCrBtAkcHK));
	}

	public async Task<IoTDeviceStatusDto> GetIoTDeviceStatusBySimulatorID(string simulatorId)
	{
		_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass23_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetIoTDeviceStatusBySimulatorID(simulatorId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.gIRBvANCYW = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IoTDeviceStatusDto>(CS_0024_003C_003E8__locals2.gIRBvANCYW));
	}

	public async Task<IoTDeviceStatusDto> GetIoTDeviceStatusByAzureDeviceID(string azureDeviceID)
	{
		_003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass24_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetIoTDeviceStatusByAzureDeviceID(azureDeviceID) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.JxVBeTyWS3 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IoTDeviceStatusDto>(CS_0024_003C_003E8__locals2.JxVBeTyWS3));
	}

	public async Task<IoTDeviceDto> GetIoTDeviceBySimulator(string simulatorID)
	{
		_003C_003Ec__DisplayClass25_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass25_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetIoTDeviceBySimulator(simulatorID) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.OT8B7nki5H = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IoTDeviceDto>(CS_0024_003C_003E8__locals2.OT8B7nki5H));
	}

	public async Task<bool> UpdateRentalInvoice(int id, NewRentalInvoiceDto rentalInvoiceForUpdate)
	{
		if (rentalInvoiceForUpdate == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(rentalInvoiceForUpdate);
		HttpClient v9AEoihwnS = V9AEoihwnS;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(26752));
		defaultInterpolatedStringHandler.AppendFormatted(id);
		HttpResponseMessage response = await v9AEoihwnS.PutAsync(defaultInterpolatedStringHandler.ToStringAndClear() + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> AttachInvoiceToAppointment(int appointmentId, int invoiceId)
	{
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.GetAttachInvoiceToAppointment(appointmentId, invoiceId), HGqEEH90pq());
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<RentalInvoiceDto> GetRentalInvoice(int invoiceId)
	{
		_003C_003Ec__DisplayClass28_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass28_0();
		HttpClient v9AEoihwnS = V9AEoihwnS;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(26752));
		defaultInterpolatedStringHandler.AppendFormatted(invoiceId);
		HttpResponseMessage response = await v9AEoihwnS.GetAsync(defaultInterpolatedStringHandler.ToStringAndClear() + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.RI4BrhoKGK = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<RentalInvoiceDto>(CS_0024_003C_003E8__locals2.RI4BrhoKGK));
	}

	public async Task<NewRentalInvoiceDto> GetRentalInvoiceForRemote(int invoiceId)
	{
		_003C_003Ec__DisplayClass29_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass29_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetRentalInvoiceForRemote(invoiceId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.U7xBlTySYn = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<NewRentalInvoiceDto>(CS_0024_003C_003E8__locals2.U7xBlTySYn));
	}

	public async Task<SimulatorDto> CreateNewSimulator(SimulatorForCreationDto newSim)
	{
		if (newSim == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(newSim);
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(so95DAFNMfktfjp4Dm.An6v7kuCGg(26384) + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return await response.Content.ReadAsAsync<SimulatorDto>();
	}

	public async Task<bool> CheckConnection(string deviceID)
	{
		_003C_003Ec__DisplayClass31_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass31_0();
		string requestUri = ApiReferenceURL.GetConnectivityDevice(deviceID) + MLKE2hNsvB;
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(requestUri);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.KyiB1tLqFe = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<bool>(CS_0024_003C_003E8__locals2.KyiB1tLqFe));
	}

	public async Task<bool> NotifyIOTDevice(string deviceID)
	{
		string requestUri = ApiReferenceURL.PostNotifySim(deviceID) + MLKE2hNsvB;
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(requestUri, new StringContent(string.Empty, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> PutIotDevice(int id, IoTDeviceForUpdateDto ioTDeviceForUpdateDto)
	{
		if (ioTDeviceForUpdateDto == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(ioTDeviceForUpdateDto);
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.GetPutIotDeviceUrl(id) + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<RentalInvoiceDto> RegisterNewSessionSale(NewSessionSalesDto newSessionSales)
	{
		if (newSessionSales == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(newSessionSales);
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(so95DAFNMfktfjp4Dm.An6v7kuCGg(27068) + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return await response.Content.ReadAsAsync<RentalInvoiceDto>();
	}

	public async Task<RentalInvoiceDto> RegisterRemoteSale(RegisterSaleDto registerSaleDto)
	{
		if (registerSaleDto == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(registerSaleDto);
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(ApiReferenceURL.RegisterRemoteSaleUrl() + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return await response.Content.ReadAsAsync<RentalInvoiceDto>();
	}

	public async Task<bool> UdpateInvoice(int rentalInvoiceId, UpdateInvoiceDto updatedInvoice)
	{
		if (updatedInvoice == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(updatedInvoice);
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.UdpateInvoiceUrl(rentalInvoiceId) + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> IsServerOn()
	{
		_ = 3;
		try
		{
			_003C_003Ec__DisplayClass37_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass37_0();
			HttpResponseMessage response = await V9AEoihwnS.GetAsync(so95DAFNMfktfjp4Dm.An6v7kuCGg(26940) + MLKE2hNsvB);
			await DjWEBMAHle(response);
			CS_0024_003C_003E8__locals2.TKNB5Avg9U = await response.Content.ReadAsStringAsync();
			return await Task.Run(() => JsonConvert.DeserializeObject<bool>(CS_0024_003C_003E8__locals2.TKNB5Avg9U));
		}
		catch
		{
			return false;
		}
	}

	public HttpClient GetHttpContext()
	{
		return V9AEoihwnS;
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
		V9AEoihwnS.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(so95DAFNMfktfjp4Dm.An6v7kuCGg(10412), tokenStr);
	}

	public async Task<bool> StartRentalSession(RentalActionModifyDto rentalActionModifyDto)
	{
		if (string.IsNullOrWhiteSpace(rentalActionModifyDto?.SimulatorId))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26280));
		}
		string requestUri = ApiReferenceURL.StartRentalSession() + MLKE2hNsvB;
		string content = JsonConvert.SerializeObject(rentalActionModifyDto);
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(requestUri, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> ActivateRentalSession(RentalActionModifyDto rentalActionModifyDto)
	{
		if (string.IsNullOrWhiteSpace(rentalActionModifyDto?.SimulatorId))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26280));
		}
		string requestUri = ApiReferenceURL.ActivateRentalSession() + MLKE2hNsvB;
		string content = JsonConvert.SerializeObject(rentalActionModifyDto);
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(requestUri, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> PauseRentalSession(RentalActionModifyDto rentalActionModifyDto)
	{
		if (string.IsNullOrWhiteSpace(rentalActionModifyDto?.SimulatorId))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26280));
		}
		string requestUri = ApiReferenceURL.PauseRentalSession() + MLKE2hNsvB;
		string content = JsonConvert.SerializeObject(rentalActionModifyDto);
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(requestUri, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> ResumeRentalSession(RentalActionModifyDto rentalActionModifyDto)
	{
		if (string.IsNullOrWhiteSpace(rentalActionModifyDto?.SimulatorId))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26280));
		}
		string requestUri = ApiReferenceURL.ResumeRentalSession() + MLKE2hNsvB;
		string content = JsonConvert.SerializeObject(rentalActionModifyDto);
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(requestUri, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> StopRentalSession(RentalActionModifyDto rentalActionModifyDto)
	{
		if (string.IsNullOrWhiteSpace(rentalActionModifyDto?.SimulatorId))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26280));
		}
		string requestUri = ApiReferenceURL.StopRentalSession() + MLKE2hNsvB;
		string content = JsonConvert.SerializeObject(rentalActionModifyDto);
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(requestUri, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
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
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(ApiReferenceURL.GetEditRolesUrl(userNameOrEmail) + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return await response.Content.ReadAsAsync<string[]>();
	}

	public async Task<bool> UsernameExist(string userName)
	{
		_003C_003Ec__DisplayClass47_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass47_0();
		CS_0024_003C_003E8__locals2.Cr1BmoM7O4 = await V9AEoihwnS.GetStringAsync(ApiReferenceURL.GetUserNameExistUrl(userName) + MLKE2hNsvB);
		return await Task.Run(() => JsonConvert.DeserializeObject<bool>(CS_0024_003C_003E8__locals2.Cr1BmoM7O4));
	}

	public async Task<bool> CardExist(string cardNumber)
	{
		_003C_003Ec__DisplayClass48_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass48_0();
		CS_0024_003C_003E8__locals2.r9ZBfiZCp3 = await V9AEoihwnS.GetStringAsync(ApiReferenceURL.GetCardExistUrl(cardNumber) + MLKE2hNsvB);
		return await Task.Run(() => JsonConvert.DeserializeObject<bool>(CS_0024_003C_003E8__locals2.r9ZBfiZCp3));
	}

	public async Task<bool> EmailExist(string email)
	{
		_003C_003Ec__DisplayClass49_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass49_0();
		CS_0024_003C_003E8__locals2.LUcBHGUYKf = await V9AEoihwnS.GetStringAsync(ApiReferenceURL.GetEmailExistUrl(email) + MLKE2hNsvB);
		return await Task.Run(() => JsonConvert.DeserializeObject<bool>(CS_0024_003C_003E8__locals2.LUcBHGUYKf));
	}

	public async Task<bool> ActivateCard(string userId, ActivateCardDto tempUserForUpdateDto)
	{
		if (tempUserForUpdateDto == null || string.IsNullOrWhiteSpace(userId))
		{
			return false;
		}
		string content = JsonConvert.SerializeObject(tempUserForUpdateDto);
		string requestUri = ApiReferenceURL.GetActivateCardUrl(userId) + MLKE2hNsvB;
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(requestUri, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<UserDto> Register(UserForRegisterDto userForRegisterDto)
	{
		if (userForRegisterDto == null)
		{
			return null;
		}
		string content = JsonConvert.SerializeObject(userForRegisterDto);
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(ApiReferenceURL.GetRegisterUrl() + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return await response.Content.ReadAsAsync<UserDto>();
	}

	public async Task<bool> ForgotPassword(string email, SupportedCulture? webBrowserCulture = null)
	{
		if (string.IsNullOrWhiteSpace(email))
		{
			return false;
		}
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(ApiReferenceURL.GetForgotPasswordUrl(email, webBrowserCulture) + MLKE2hNsvB, new StringContent("", Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> ResetPassword(ResetPasswordDto model)
	{
		if (model == null)
		{
			return false;
		}
		string content = JsonConvert.SerializeObject(model);
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(ApiReferenceURL.GetResetPasswordUrl() + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<TempPasswordDto> GenerateTemporaryPassword(string emailOrUserName)
	{
		if (string.IsNullOrEmpty(emailOrUserName))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26618));
		}
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(ApiReferenceURL.GetGenerateTemporaryPasswordUrl(emailOrUserName) + MLKE2hNsvB, new StringContent("", Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return await response.Content.ReadAsAsync<TempPasswordDto>();
	}

	public async Task<IEnumerable<AppointmentDto>> GetAppointments()
	{
		_003C_003Ec__DisplayClass55_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass55_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetAppointmentsUrl() + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.y3QBGsbDYq = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(CS_0024_003C_003E8__locals2.y3QBGsbDYq));
	}

	public async Task<IEnumerable<AppointmentDto>> GetAppointments(AppointmentListFilter filters)
	{
		_003C_003Ec__DisplayClass56_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass56_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetAppointmentsUrl(filters) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.uTHBstYTdd = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(CS_0024_003C_003E8__locals2.uTHBstYTdd));
	}

	public async Task<AppointmentDto> GetAppointmentFromSimTime(string simulatorId, DateTime now)
	{
		_003C_003Ec__DisplayClass57_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass57_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetAppointmentFromSimTimeUrl(simulatorId, now) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.TKDB9SpfCA = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<AppointmentDto>(CS_0024_003C_003E8__locals2.TKDB9SpfCA));
	}

	public async Task<IEnumerable<AppointmentDto>> GetAppointmentsBySite(int siteId)
	{
		_003C_003Ec__DisplayClass58_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass58_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetAppointmentsBySiteUrl(siteId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.Wk5BQp9O5q = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(CS_0024_003C_003E8__locals2.Wk5BQp9O5q));
	}

	public async Task<IEnumerable<AppointmentDto>> GetAppointmentsBySite(int siteId, DateTime date)
	{
		_003C_003Ec__DisplayClass59_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass59_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetAppointmentsBySiteDateUrl(siteId, date) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.bbTBL4XHt0 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(CS_0024_003C_003E8__locals2.bbTBL4XHt0));
	}

	public async Task<AppointmentRecurrenceDto> GetAppointmentRecurrence(int appointmentRecurrenceId)
	{
		_003C_003Ec__DisplayClass60_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass60_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetAppointmentRecurrence(appointmentRecurrenceId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.d8hBZlYjo0 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<AppointmentRecurrenceDto>(CS_0024_003C_003E8__locals2.d8hBZlYjo0));
	}

	public async Task<bool> UpdateAppointment(int id, AppointmentForUpdateDto appointmentToUpdate)
	{
		if (appointmentToUpdate == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(appointmentToUpdate);
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.GetUpdateAppointmentUrl(id) + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<IoTDeviceDto> NewIotDevice(string azureDeviceId)
	{
		if (string.IsNullOrWhiteSpace(azureDeviceId))
		{
			throw new Exception(ModelInvalid);
		}
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(ApiReferenceURL.PostNewDeviceOnAzureHubUrl(Guid.NewGuid().ToString()) + MLKE2hNsvB, new StringContent(string.Empty));
		await DjWEBMAHle(response);
		return JsonConvert.DeserializeObject<IoTDeviceDto>(await response.Content.ReadAsStringAsync());
	}

	public async Task<bool> TransfertSimulatorReservation(string simGiverId, string simReceiverId)
	{
		if (string.IsNullOrWhiteSpace(simGiverId) || string.IsNullOrWhiteSpace(simReceiverId))
		{
			throw new Exception(ModelInvalid);
		}
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.TransfertSimulatorReservation(simGiverId, simReceiverId) + MLKE2hNsvB, new StringContent(string.Empty, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
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
			HttpResponseMessage simCreationResponse = await V9AEoihwnS.PostAsync(ApiReferenceURL.CreateSimulatorManagementUrl() + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
			await DjWEBMAHle(simCreationResponse);
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
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.UpdateSimulatorManagementUrl(id) + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> RemoveSimulatorManagement(string id)
	{
		if (id == null)
		{
			throw new Exception(ModelInvalid);
		}
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.RemoveSimulatorManagementUrl(id) + MLKE2hNsvB, new StringContent(string.Empty));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<IEnumerable<SimulatorRemoteManagementDto>> GetSimulatorsManagement()
	{
		_003C_003Ec__DisplayClass67_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass67_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetSimulatorsManagementUrl());
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.tIeBSjqw0E = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SimulatorRemoteManagementDto>>(CS_0024_003C_003E8__locals2.tIeBSjqw0E));
	}

	public async Task<IEnumerable<SimulatorDto>> GetSimulatorsBySite(int siteId)
	{
		_003C_003Ec__DisplayClass68_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass68_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetSimulatorsBySiteUrl(siteId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.Cf3BNp1JIU = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SimulatorDto>>(CS_0024_003C_003E8__locals2.Cf3BNp1JIU));
	}

	public async Task<IEnumerable<SimulatorDto>> GetSimulatorsAppointmentBySiteDate(int siteId, DateTime date)
	{
		_003C_003Ec__DisplayClass69_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass69_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetSimulatorsAppointmentBySiteDate(siteId, date) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.zwlBIcLXTf = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SimulatorDto>>(CS_0024_003C_003E8__locals2.zwlBIcLXTf));
	}

	public async Task<IEnumerable<DateTime?>> GetAppointmentAvailability(int siteId, DateTime startDate, int durationHour, int durationMin)
	{
		_003C_003Ec__DisplayClass70_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass70_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetAppointmentAvailabilityUrl(siteId, startDate, durationHour, durationMin) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.o3aBPyci5V = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<DateTime?>>(CS_0024_003C_003E8__locals2.o3aBPyci5V));
	}

	public async Task<IEnumerable<DateTime?>> GetAppointmentAvailabilityBySim(int siteId, DateTime startDate, int durationHour, int durationMin, string simId)
	{
		_003C_003Ec__DisplayClass71_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass71_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetAppointmentAvailabilityBySimUrl(siteId, startDate, durationHour, durationMin, simId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.e3H3d7yyhk = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<DateTime?>>(CS_0024_003C_003E8__locals2.e3H3d7yyhk));
	}

	public async Task<IEnumerable<AppointmentDto>> GetHasAppointmentConflict(int siteId, DateTime startDate, DateTime endDate, int day, DateTime? teeTime, int durationHour, int durationMin, string simId, int appointmentId)
	{
		_003C_003Ec__DisplayClass72_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass72_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetHasAppointmentConflictUrl(siteId, startDate, endDate, day, teeTime, durationHour, durationMin, simId, appointmentId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.dXr3u6K0tr = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<AppointmentDto>>(CS_0024_003C_003E8__locals2.dXr3u6K0tr));
	}

	public async Task<AppointmentDto> SearchAppointment(string idOrTitle, int siteId)
	{
		_003C_003Ec__DisplayClass73_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass73_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetSearchAppointment(idOrTitle, siteId));
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.UNm3RlDOG1 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<AppointmentDto>(CS_0024_003C_003E8__locals2.UNm3RlDOG1));
	}

	public async Task<AppointmentDto> AddNewAppointment(AppointmentForCreationDto appointment)
	{
		if (appointment == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(appointment);
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(ApiReferenceURL.GetCreateAppointmentUrl() + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return await response.Content.ReadAsAsync<AppointmentDto>();
	}

	public async Task<AppointmentDto> AddNewAppointmentBySim(string simId, AppointmentForCreationDto appointment)
	{
		if (appointment == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(appointment);
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(ApiReferenceURL.GetAddNewAppointmentBySimUrl(simId) + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return await response.Content.ReadAsAsync<AppointmentDto>();
	}

	public async Task<bool> AddRecurrentAppointment(string simId, AppointmentReccurenceForCreationDto appointment)
	{
		if (appointment == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(appointment);
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(ApiReferenceURL.GetAddRecurrentAppointmentUrl(simId) + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return await response.Content.ReadAsAsync<bool>();
	}

	public async Task<bool> DeleteAppointment(int id, SupportedCulture? webBrowserCulture = null)
	{
		HttpResponseMessage response = await V9AEoihwnS.DeleteAsync(ApiReferenceURL.GetDeleteAppointmentUrl(id, webBrowserCulture) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> DeleteAppointmentSeries(int id, SupportedCulture? webBrowserCulture = null)
	{
		HttpResponseMessage response = await V9AEoihwnS.DeleteAsync(ApiReferenceURL.GetDeleteAppointmentSeriesUrl(id, webBrowserCulture) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<IEnumerable<AppointmentHistoryDto>> GetAppointmentHistoryBySite(int siteId, DateTime dateStart, DateTime dateEnd)
	{
		_003C_003Ec__DisplayClass79_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass79_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetAppointmentHistoryBySite(siteId, dateStart, dateEnd) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.Lt43kOn3XE = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<AppointmentHistoryDto>>(CS_0024_003C_003E8__locals2.Lt43kOn3XE));
	}

	public async Task<IEnumerable<AppointmentHistoryDto>> GetAppointmentHistoryByReservation(int reservationId)
	{
		_003C_003Ec__DisplayClass80_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass80_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetAppointmentHistoryByReservation(reservationId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.xhM3XKMyV1 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<AppointmentHistoryDto>>(CS_0024_003C_003E8__locals2.xhM3XKMyV1));
	}

	public async Task<ActiveAppointmentSimulatorDto> GetActiveAppointmentSimulator(int id)
	{
		_003C_003Ec__DisplayClass81_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass81_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetActiveAppointmentSimulatorUrl(id) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.OMi3pyRjZu = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<ActiveAppointmentSimulatorDto>(CS_0024_003C_003E8__locals2.OMi3pyRjZu));
	}

	public async Task<ActiveAppointmentSimulatorDto> GetActiveAppointmentSimulatorFromSimId(string simulatorId)
	{
		_003C_003Ec__DisplayClass82_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass82_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetActiveAppointmentSimulatorFromSimIdUrl(simulatorId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.DQK3Yrl8Eg = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<ActiveAppointmentSimulatorDto>(CS_0024_003C_003E8__locals2.DQK3Yrl8Eg));
	}

	public async Task<ActiveAppointmentSimulatorDto> GetActiveAppointmentSimulatorFromAppointmentId(int appointmentId)
	{
		_003C_003Ec__DisplayClass83_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass83_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetActiveAppointmentSimulatorFromAppointmentIdUrl(appointmentId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.Dgx367hIE9 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<ActiveAppointmentSimulatorDto>(CS_0024_003C_003E8__locals2.Dgx367hIE9));
	}

	public async Task<ActiveAppointmentSimulatorDto> GetActiveAppointmentSimulatorFromRentalSessionId(int rentalSessionId)
	{
		_003C_003Ec__DisplayClass84_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass84_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetActiveAppointmentSimulatorFromRentalSessionIdUrl(rentalSessionId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.eW83BHmZlm = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<ActiveAppointmentSimulatorDto>(CS_0024_003C_003E8__locals2.eW83BHmZlm));
	}

	public async Task<IEnumerable<SiteLiteDto>> GetLiteSites()
	{
		_003C_003Ec__DisplayClass85_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass85_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetLiteSitesUrl() + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.qB132TgoSJ = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SiteLiteDto>>(CS_0024_003C_003E8__locals2.qB132TgoSJ));
	}

	public async Task<IEnumerable<SiteLiteDto>> GetLiteSitesForReservation()
	{
		_003C_003Ec__DisplayClass86_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass86_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetLiteSitesForReservationUrl() + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.rSi3tvRgNq = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SiteLiteDto>>(CS_0024_003C_003E8__locals2.rSi3tvRgNq));
	}

	public async Task<IEnumerable<SiteLiteForProfileDto>> GetLiteSitesForProfile()
	{
		_003C_003Ec__DisplayClass87_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass87_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetLiteSitesForProfileUrl() + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.KQs3vr3QCK = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SiteLiteForProfileDto>>(CS_0024_003C_003E8__locals2.KQs3vr3QCK));
	}

	public async Task<IEnumerable<SiteAdminSettingsDto>> GetSitesForAdminSettings()
	{
		_003C_003Ec__DisplayClass88_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass88_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetSitesForAdminSettingsUrl() + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.mBS3ej9DhH = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SiteAdminSettingsDto>>(CS_0024_003C_003E8__locals2.mBS3ej9DhH));
	}

	public async Task<SiteDto> GetSite(int siteId)
	{
		_003C_003Ec__DisplayClass89_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass89_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetSiteUrl(siteId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.Fh237X6NjM = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<SiteDto>(CS_0024_003C_003E8__locals2.Fh237X6NjM));
	}

	public async Task<bool> UpdateSite(int siteId, SiteForUpdateDto siteForUpdateDto)
	{
		if (siteForUpdateDto == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(siteForUpdateDto);
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.GetUpdateSiteUrl(siteId) + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<SiteDto> NewSite(SiteForCreationDto siteDto)
	{
		if (siteDto == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(siteDto);
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(ApiReferenceURL.GetNewSiteUrl() + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return await response.Content.ReadAsAsync<SiteDto>();
	}

	public async Task<SiteReservationSettingDto> GetSiteReservationSettingBySite(int siteId)
	{
		_003C_003Ec__DisplayClass92_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass92_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetSiteReservationSettingBySiteUrl(siteId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.Oeb3rVie6u = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<SiteReservationSettingDto>(CS_0024_003C_003E8__locals2.Oeb3rVie6u));
	}

	public async Task<SiteWebSettingDto> GetSiteWebSettingsBySite(int siteId)
	{
		_003C_003Ec__DisplayClass93_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass93_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetSiteWebSettingBySiteUrl(siteId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.Vty3l6nU12 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<SiteWebSettingDto>(CS_0024_003C_003E8__locals2.Vty3l6nU12));
	}

	public async Task<FeeScheduleDto> NewFeeSchedule(FeeScheduleForCreationDto feeScheduleDto)
	{
		if (feeScheduleDto == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(feeScheduleDto);
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(ApiReferenceURL.GetNewFeeScheduleUrl() + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return await response.Content.ReadAsAsync<FeeScheduleDto>();
	}

	public async Task<bool> UpdateSimulator(string simId, SimulatorForUpdateDto simulatorForUpdateDto)
	{
		if (simulatorForUpdateDto == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(simulatorForUpdateDto);
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.GetUpdateSimulatorUrl(simId) + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> UpdateSimulatorState(string simId, bool isAvailable)
	{
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.GetUpdateSimulatorStateUrl(simId, isAvailable) + MLKE2hNsvB, HGqEEH90pq());
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<List<DayOpeningHoursDto>> GetSiteWeekOpeningHours(int siteId)
	{
		_003C_003Ec__DisplayClass97_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass97_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetSiteWeekOpeningHoursUrl(siteId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.a2s31PYSjh = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<List<DayOpeningHoursDto>>(CS_0024_003C_003E8__locals2.a2s31PYSjh));
	}

	public async Task<bool> UpdateOpeningHour(int id, DayOpeningHoursForUpdateDto dayToUpdate)
	{
		if (dayToUpdate == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(dayToUpdate);
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.GetUpdateOpeningHourUrl(id) + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> UpdateReservationSettings(int id, SiteReservationSettingForUpdateDto siteReservationToUpdate)
	{
		if (siteReservationToUpdate == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(siteReservationToUpdate);
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.GetUpdateReservationSettingsUrl(id) + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<NotificationRecipientDto> CreateNotificationRecipient(NotificationRecipientForCreationDto notificationRecipientsDto)
	{
		if (notificationRecipientsDto == null || !UEOE3rTYAF(notificationRecipientsDto.Email))
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(notificationRecipientsDto);
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(ApiReferenceURL.CreateNotificationRecipient() + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return await response.Content.ReadAsAsync<NotificationRecipientDto>();
	}

	public async Task<bool> DeleteNotificationRecipient(int id)
	{
		HttpResponseMessage response = await V9AEoihwnS.DeleteAsync(ApiReferenceURL.GetDeleteNotificationRecipientUrl(id) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> UpdateWebSettings(int id, SiteWebSettingForUpdateDto siteWebToUpdate)
	{
		if (siteWebToUpdate == null)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(27364));
		}
		string content = JsonConvert.SerializeObject(siteWebToUpdate);
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.GetUpdateWebSettingsUrl(id) + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<IEnumerable<UserDto>> GetUsers(UserListFilter filters)
	{
		_003C_003Ec__DisplayClass103_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass103_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetUsersUrl(filters));
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.oGXEvNai4P = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<UserDto>>(CS_0024_003C_003E8__locals2.oGXEvNai4P));
	}

	public async Task<IEnumerable<UserForManagementDto>> GetUserByRoleForManagement(string role)
	{
		if (!string.IsNullOrWhiteSpace(role))
		{
			_003C_003Ec__DisplayClass104_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass104_0();
			HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetUserByRoleForManagementUrl(role) + MLKE2hNsvB);
			await DjWEBMAHle(response);
			CS_0024_003C_003E8__locals2.yF0Ee36suh = await response.Content.ReadAsStringAsync();
			return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<UserForManagementDto>>(CS_0024_003C_003E8__locals2.yF0Ee36suh));
		}
		throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(26838));
	}

	public async Task<IEnumerable<UserForManagementDto>> GetUserByRoleForManagement(string role, int siteId)
	{
		if (!string.IsNullOrWhiteSpace(role))
		{
			_003C_003Ec__DisplayClass105_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass105_0();
			HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetUserByRoleForManagementUrl(role, siteId) + MLKE2hNsvB);
			await DjWEBMAHle(response);
			CS_0024_003C_003E8__locals2.R5SE7LVppH = await response.Content.ReadAsStringAsync();
			return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<UserForManagementDto>>(CS_0024_003C_003E8__locals2.R5SE7LVppH));
		}
		throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(26838));
	}

	public async Task<UserDto> GetUser(string id)
	{
		if (!string.IsNullOrWhiteSpace(id))
		{
			_003C_003Ec__DisplayClass106_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass106_0();
			HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetUserUrl(id) + MLKE2hNsvB);
			await DjWEBMAHle(response);
			CS_0024_003C_003E8__locals2.wkUEr0rCJv = await response.Content.ReadAsStringAsync();
			return await Task.Run(() => JsonConvert.DeserializeObject<UserDto>(CS_0024_003C_003E8__locals2.wkUEr0rCJv));
		}
		throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(26796));
	}

	public async Task<bool> DeleteUser(string id)
	{
		if (!string.IsNullOrWhiteSpace(id))
		{
			HttpResponseMessage response = await V9AEoihwnS.DeleteAsync(ApiReferenceURL.GetDeleteUserUrl(id) + MLKE2hNsvB);
			await DjWEBMAHle(response);
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
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.GetUpdateUserUrl(userId) + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
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
		string requestUri = ApiReferenceURL.GetUpdateStaffUrl(staffId) + MLKE2hNsvB;
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(requestUri, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
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
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.GetUpdateMemberUrl(userId) + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<UserDto> GetUserByCardNumber(string cardNumber)
	{
		if (!string.IsNullOrWhiteSpace(cardNumber))
		{
			_003C_003Ec__DisplayClass111_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass111_0();
			HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetUserByCardNumberUrl(cardNumber) + MLKE2hNsvB);
			await DjWEBMAHle(response);
			CS_0024_003C_003E8__locals2.eXXEl2yIRh = await response.Content.ReadAsStringAsync();
			return await Task.Run(() => JsonConvert.DeserializeObject<UserDto>(CS_0024_003C_003E8__locals2.eXXEl2yIRh));
		}
		throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(26796));
	}

	public async Task<UserDto> GetUserByCardNumberWithinSite(string cardNumber, int siteId)
	{
		_003C_003Ec__DisplayClass112_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass112_0();
		if (string.IsNullOrWhiteSpace(cardNumber))
		{
			throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(26796));
		}
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetUserByCardNumberWithinSiteUrl(cardNumber, siteId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.FqtE1cOH90 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<UserDto>(CS_0024_003C_003E8__locals2.FqtE1cOH90));
	}

	public async Task<UserDto> GetUserByString(string userNameOrEmail)
	{
		if (!string.IsNullOrWhiteSpace(userNameOrEmail))
		{
			_003C_003Ec__DisplayClass113_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass113_0();
			HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetUserByStringUrl(userNameOrEmail) + MLKE2hNsvB);
			await DjWEBMAHle(response);
			CS_0024_003C_003E8__locals2.r0rE5kF9VI = await response.Content.ReadAsStringAsync();
			return await Task.Run(() => JsonConvert.DeserializeObject<UserDto>(CS_0024_003C_003E8__locals2.r0rE5kF9VI));
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
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.GetChangePasswordUrl(userId) + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<UserDto> VerifyCardNumber(string cardNumber)
	{
		throw new NotImplementedException();
	}

	public async Task<SiteStatistic> GetSiteStatistic(int siteId)
	{
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetSiteStatistic(siteId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		return JsonConvert.DeserializeObject<SiteStatistic>(await response.Content.ReadAsStringAsync());
	}

	public async Task<List<AppointmentDto>> GetMemberAppointments(string userId)
	{
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetMemberAppointments(userId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		return JsonConvert.DeserializeObject<List<AppointmentDto>>(await response.Content.ReadAsStringAsync());
	}

	public async Task<bool> UpdateUserSiteId(string userId, int siteId)
	{
		if (string.IsNullOrWhiteSpace(userId))
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(26324));
		}
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.GetUpdateUserSiteId(userId, siteId) + MLKE2hNsvB, new StringContent("", Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
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
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(addCardTransactionUrl + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<IEnumerable<PromotionDto>> GetPromotions()
	{
		_003C_003Ec__DisplayClass120_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass120_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetPromotionsUrl() + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.TWYEmWdQRJ = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<PromotionDto>>(CS_0024_003C_003E8__locals2.TWYEmWdQRJ));
	}

	public async Task<IEnumerable<PromotionDto>> GetPromotions(int siteId)
	{
		_003C_003Ec__DisplayClass121_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass121_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetPromotionsUrl(siteId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.NlZEfjNbnl = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<PromotionDto>>(CS_0024_003C_003E8__locals2.NlZEfjNbnl));
	}

	public async Task<PromotionDto> NewPromotion(PromotionForCreationDto promoDto)
	{
		if (promoDto == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(promoDto);
		HttpResponseMessage response = await V9AEoihwnS.PostAsync(ApiReferenceURL.GetNewPromotionUrl() + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return await response.Content.ReadAsAsync<PromotionDto>();
	}

	public async Task<bool> UpdatePromotion(int id, PromotionForUpdateDto promoForUpdate)
	{
		if (promoForUpdate == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(promoForUpdate);
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.GetUpdatePromotionUrl(id) + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> DeletePromo(int id)
	{
		HttpResponseMessage response = await V9AEoihwnS.DeleteAsync(ApiReferenceURL.GetDeletePromoUrl(id) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<FeeScheduleDto> GetSiteFeeSchedule(int siteId)
	{
		_003C_003Ec__DisplayClass125_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass125_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetSiteFeeScheduleUrl(siteId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.jr1EHsJaMe = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<FeeScheduleDto>(CS_0024_003C_003E8__locals2.jr1EHsJaMe));
	}

	public async Task<bool> ChangeFeeScheduleRate(HourRateToUpdateDto hourRateDtoToUpdate)
	{
		if (hourRateDtoToUpdate == null)
		{
			throw new Exception(ModelInvalid);
		}
		string content = JsonConvert.SerializeObject(hourRateDtoToUpdate);
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.GetChangeFeeScheduleRateUrl() + MLKE2hNsvB, new StringContent(content, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906)));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<IEnumerable<SalesReportDto>> GetTodaySales(int siteId, TimeSpan offset)
	{
		_003C_003Ec__DisplayClass127_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass127_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetTodaySalesUrl(siteId, offset) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.XuMEGYpuIJ = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.XuMEGYpuIJ));
	}

	public async Task<IEnumerable<SalesReportDto>> GetYesterdaySales(int siteId)
	{
		_003C_003Ec__DisplayClass128_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass128_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetYesterdaySalesUrl(siteId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.vxiEsspevR = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.vxiEsspevR));
	}

	public async Task<IEnumerable<SalesReportDto>> GetThisWeekSales(int siteId)
	{
		_003C_003Ec__DisplayClass129_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass129_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetThisWeekSales(siteId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.ttWE99tBT7 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.ttWE99tBT7));
	}

	public async Task<IEnumerable<SalesReportDto>> GetLastWeekSales(int siteId)
	{
		_003C_003Ec__DisplayClass130_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass130_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetLastWeekSales(siteId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.m7IEQpnZx3 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.m7IEQpnZx3));
	}

	public async Task<IEnumerable<SalesReportDto>> GetThisMonthSales(int siteId)
	{
		_003C_003Ec__DisplayClass131_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass131_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetThisMonthSalesUrl(siteId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.e0dELY4wrA = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.e0dELY4wrA));
	}

	public async Task<IEnumerable<SalesReportDto>> GetLastMonthSales(int siteId)
	{
		_003C_003Ec__DisplayClass132_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass132_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetLastMonthSalesUrl(siteId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.GPpEZH1YO6 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.GPpEZH1YO6));
	}

	public async Task<IEnumerable<SalesReportDto>> GetDaySales(int siteId, DateTime time)
	{
		_003C_003Ec__DisplayClass133_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass133_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetDaySalesUrl(siteId, time.Year, time.Month, time.Day) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.NMCESY77Rk = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.NMCESY77Rk));
	}

	public async Task<IEnumerable<SalesReportDto>> GetWeeklySales(int siteId, DateTime time)
	{
		_003C_003Ec__DisplayClass134_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass134_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetWeeklySalesUrl(siteId, time.Year, time.Month, time.Day) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.fFLENcq5B1 = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.fFLENcq5B1));
	}

	public async Task<IEnumerable<SalesReportDto>> GetMonthlySales(int siteId, int month)
	{
		_003C_003Ec__DisplayClass135_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass135_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetMonthlySalesUrl(siteId, month) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.WPfEI7j25C = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.WPfEI7j25C));
	}

	public async Task<IEnumerable<SalesReportDto>> BetweenTwoDate(int siteId, DateTime startDate, DateTime endDate)
	{
		_003C_003Ec__DisplayClass136_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass136_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetBetweenTwoDateUrl(siteId, startDate.Year, startDate.Month, startDate.Day, endDate.Year, endDate.Month, endDate.Day) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.HgiEPM54om = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<SalesReportDto>>(CS_0024_003C_003E8__locals2.HgiEPM54om));
	}

	[Obsolete("Only use in Monitor V2")]
	public async Task<IEnumerable<PlayerInvoiceSalesReportDto>> GetPlayerInvoices(int rentalInvoiceId)
	{
		_003C_003Ec__DisplayClass137_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass137_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetPlayerInvoicesUrl(rentalInvoiceId) + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.dScBdoeUyi = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<PlayerInvoiceSalesReportDto>>(CS_0024_003C_003E8__locals2.dScBdoeUyi));
	}

	public async Task<IEnumerable<ReleaseNoteDto>> GetAllReleaseNotes()
	{
		_003C_003Ec__DisplayClass138_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass138_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetAllReleaseNotesUrl() + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.nqxBuelgZi = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<ReleaseNoteDto>>(CS_0024_003C_003E8__locals2.nqxBuelgZi));
	}

	public async Task<bool> UpdateReleaseNotes(IEnumerable<ReleaseNoteDto> releasesNotes)
	{
		if (releasesNotes == null)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(27110));
		}
		string text = JsonConvert.SerializeObject(releasesNotes);
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.GetUpdateReleaseNotesUrl() + MLKE2hNsvB, HGqEEH90pq(text));
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> HasCurrentUserSeenLatestReleaseNote()
	{
		_003C_003Ec__DisplayClass140_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass140_0();
		HttpResponseMessage response = await V9AEoihwnS.GetAsync(ApiReferenceURL.GetHasCurrentUserSeenLatestReleaseNote() + MLKE2hNsvB);
		await DjWEBMAHle(response);
		CS_0024_003C_003E8__locals2.r0DBRemgQu = await response.Content.ReadAsStringAsync();
		return await Task.Run(() => JsonConvert.DeserializeObject<bool>(CS_0024_003C_003E8__locals2.r0DBRemgQu));
	}

	public async Task<bool> NotifyNewReleaseNote()
	{
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.GetNotifyNewReleaseNote() + MLKE2hNsvB, HGqEEH90pq());
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> MarkNewReleaseNoteViewByCurrentUser()
	{
		HttpResponseMessage response = await V9AEoihwnS.PutAsync(ApiReferenceURL.MarkNewReleaseNoteViewByCurrentUser() + MLKE2hNsvB, HGqEEH90pq());
		await DjWEBMAHle(response);
		return response.IsSuccessStatusCode;
	}

	private static StringContent HGqEEH90pq(string P_0 = null)
	{
		return new StringContent(P_0 ?? string.Empty, Encoding.UTF8, so95DAFNMfktfjp4Dm.An6v7kuCGg(9906));
	}

	private static async Task DjWEBMAHle(HttpResponseMessage P_0)
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

	private static bool UEOE3rTYAF(string P_0)
	{
		string pattern = so95DAFNMfktfjp4Dm.An6v7kuCGg(10428);
		return Regex.IsMatch(P_0, pattern);
	}

	public void Dispose()
	{
		V9AEoihwnS?.Dispose();
	}

	public Task<bool> DeleteAppointmentSeries(AppointmentRecurrenceForDeleteDto recurrenceToDelete)
	{
		throw new NotImplementedException();
	}

	public Task<PagedResult<ContactDto>> GetContacts(ContactListFilter filters)
	{
		throw new NotImplementedException();
	}

	public Task<ContactDto> UpdateContact(ContactDto contact, int id)
	{
		throw new NotImplementedException();
	}

	public Task<bool> DeleteContact(int contactId)
	{
		throw new NotImplementedException();
	}

	public Task<IEnumerable<SiteUserDto>> GetMembersAndContacts(UserListFilter filters)
	{
		throw new NotImplementedException();
	}

	public Task<ContactDto> CreateContact(CreateContactDto contact)
	{
		throw new NotImplementedException();
	}

	public Task<IEnumerable<DateTime?>> GetAvailabilitiesBySim(SimulatorAvailabilityDto availabilityDto)
	{
		throw new NotImplementedException();
	}

	static ZoneGolfInApi()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		f5YEtab6Zg = so95DAFNMfktfjp4Dm.An6v7kuCGg(10528);
	}
}
