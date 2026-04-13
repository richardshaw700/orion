using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class FeeScheduleDto
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public DateTime IG5u8j1tGU;

		public _003C_003Ec__DisplayClass20_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal bool gghu4DUSBp(DayScheduleDto x)
		{
			return x.DayOfWeek == IG5u8j1tGU.DayOfWeek;
		}

		internal bool XWSurpcpmZ(HourRateDto x)
		{
			return x.StartFrom == IG5u8j1tGU.Hour;
		}
	}

	[CompilerGenerated]
	private int IS0uvD3ufg;

	[CompilerGenerated]
	private DateTime tmMuJ8kYSg;

	[CompilerGenerated]
	private decimal KcxueWPtT6;

	[CompilerGenerated]
	private string PqquKkchLM;

	[CompilerGenerated]
	private List<DayScheduleDto> mWyu7vFweN;

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return IS0uvD3ufg;
		}
		[CompilerGenerated]
		set
		{
			IS0uvD3ufg = value;
		}
	}

	public DateTime CreatedOn
	{
		[CompilerGenerated]
		get
		{
			return tmMuJ8kYSg;
		}
		[CompilerGenerated]
		set
		{
			tmMuJ8kYSg = value;
		}
	}

	public decimal DefaultHourlyRate
	{
		[CompilerGenerated]
		get
		{
			return KcxueWPtT6;
		}
		[CompilerGenerated]
		set
		{
			KcxueWPtT6 = value;
		}
	}

	public string ZoneName
	{
		[CompilerGenerated]
		get
		{
			return PqquKkchLM;
		}
		[CompilerGenerated]
		set
		{
			PqquKkchLM = value;
		}
	}

	public List<DayScheduleDto> DaySchedules
	{
		[CompilerGenerated]
		get
		{
			return mWyu7vFweN;
		}
		[CompilerGenerated]
		set
		{
			mWyu7vFweN = value;
		}
	}

	public decimal GetRatePerHour(DateTime timeOfTx)
	{
		_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass20_0();
		CS_0024_003C_003E8__locals3.IG5u8j1tGU = timeOfTx;
		if (DaySchedules == null || DaySchedules.Count == 0)
		{
			throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(54), so95DAFNMfktfjp4Dm.An6v7kuCGg(82));
		}
		DayScheduleDto dayScheduleDto = DaySchedules.SingleOrDefault((DayScheduleDto x) => x.DayOfWeek == CS_0024_003C_003E8__locals3.IG5u8j1tGU.DayOfWeek);
		if (dayScheduleDto == null || dayScheduleDto.HourRates == null)
		{
			throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(192), so95DAFNMfktfjp4Dm.An6v7kuCGg(214));
		}
		return (dayScheduleDto.HourRates.SingleOrDefault((HourRateDto x) => x.StartFrom == CS_0024_003C_003E8__locals3.IG5u8j1tGU.Hour) ?? throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(326))).HourlyRate;
	}

	public decimal ComputeTotalAmount(TimeSpan duration, DateTime currentTime)
	{
		decimal num = default(decimal);
		for (int i = 1; i <= duration.Days; i++)
		{
			DateTime dateTime = currentTime.AddDays(-i);
			for (int j = 0; j < 24; j++)
			{
				DateTime timeOfTx = dateTime.AddHours(j);
				num += GetRatePerHour(timeOfTx);
			}
		}
		for (int k = 1; k <= duration.Hours; k++)
		{
			DateTime timeOfTx2 = currentTime.AddHours(-k);
			num += GetRatePerHour(timeOfTx2);
		}
		num += (decimal)duration.Minutes / 60m * GetRatePerHour(currentTime);
		return num + (decimal)duration.Seconds / 60m / 60m * GetRatePerHour(currentTime);
	}

	public FeeScheduleDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
