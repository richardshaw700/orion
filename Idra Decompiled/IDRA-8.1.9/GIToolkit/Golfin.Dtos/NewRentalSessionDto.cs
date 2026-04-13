using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using GIToolkit.Services;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class NewRentalSessionDto
{
	[CompilerGenerated]
	private DateTime zRkRsOF7Mo;

	[CompilerGenerated]
	private DateTime? MIYROUxKnV;

	[CompilerGenerated]
	private RentalState M3wR9xIYNc;

	[CompilerGenerated]
	private decimal epuRhucDvS;

	[CompilerGenerated]
	private double tquRQIgQoQ;

	[CompilerGenerated]
	private string eETRTDlgAF;

	[CompilerGenerated]
	private List<NewRentalTransactionDto> hUrRLou9pI;

	public DateTime StartedOn
	{
		[CompilerGenerated]
		get
		{
			return zRkRsOF7Mo;
		}
		[CompilerGenerated]
		set
		{
			zRkRsOF7Mo = value;
		}
	}

	public DateTime? EndedOn
	{
		[CompilerGenerated]
		get
		{
			return MIYROUxKnV;
		}
		[CompilerGenerated]
		set
		{
			MIYROUxKnV = value;
		}
	}

	public RentalState State
	{
		[CompilerGenerated]
		get
		{
			return M3wR9xIYNc;
		}
		[CompilerGenerated]
		set
		{
			M3wR9xIYNc = value;
		}
	}

	public decimal TotalAmount
	{
		[CompilerGenerated]
		get
		{
			return epuRhucDvS;
		}
		[CompilerGenerated]
		set
		{
			epuRhucDvS = value;
		}
	}

	public double TotalMinutes
	{
		[CompilerGenerated]
		get
		{
			return tquRQIgQoQ;
		}
		[CompilerGenerated]
		set
		{
			tquRQIgQoQ = value;
		}
	}

	public string SimulatorId
	{
		[CompilerGenerated]
		get
		{
			return eETRTDlgAF;
		}
		[CompilerGenerated]
		set
		{
			eETRTDlgAF = value;
		}
	}

	public List<NewRentalTransactionDto> RentalTransactions
	{
		[CompilerGenerated]
		get
		{
			return hUrRLou9pI;
		}
		[CompilerGenerated]
		set
		{
			hUrRLou9pI = value;
		}
	}

	public double CalculTotalMinutes()
	{
		if (RentalTransactions == null || RentalTransactions.Count <= 0)
		{
			return 0.0;
		}
		double num = RentalTransactions.Sum((NewRentalTransactionDto x) => x.Duration.TotalMinutes) - RentalTransactions.Where((NewRentalTransactionDto x) => x.Action == RentalAction.Activate || x.Action == RentalAction.Resume).Sum((NewRentalTransactionDto x) => x.Duration.TotalMinutes);
		if (State == RentalState.Activated)
		{
			num += (DateTime.Now - RentalTransactions.Last().CurrentTime).TotalMinutes;
		}
		TotalMinutes = num;
		return TotalMinutes;
	}

	public void StartSession(string simId, FeeScheduleDto scheduler)
	{
		StartedOn = DateTime.Now;
		State = RentalState.Opened;
		RentalTransactions = new List<NewRentalTransactionDto>();
		TotalMinutes = 0.0;
		SimulatorId = simId;
		O6dRClgD9M(RentalAction.Start, RentalState.Opened, scheduler);
	}

	public void ActivateSession(FeeScheduleDto scheduler)
	{
		O6dRClgD9M(RentalAction.Activate, RentalState.Activated, scheduler);
	}

	public void ResumeSession(FeeScheduleDto scheduler)
	{
		O6dRClgD9M(RentalAction.Resume, RentalState.Activated, scheduler);
	}

	public void CloseSession(FeeScheduleDto scheduler)
	{
		O6dRClgD9M(RentalAction.Close, RentalState.Closed, scheduler);
		EndedOn = DateTime.Now;
		TotalAmount = CalculTotalAmount();
	}

	private void O6dRClgD9M(RentalAction P_0, RentalState P_1, FeeScheduleDto P_2)
	{
		NewRentalTransactionDto newRentalTransactionDto = new NewRentalTransactionDto
		{
			Action = P_0,
			Rate = GetNowRate(P_2),
			Duration = GetLastRentalTxDuration(),
			RentalTransactionInfo = new NewRentalTransactionInfoDto
			{
				GameName = GameProcessService.GetCurrentGameName()
			}
		};
		newRentalTransactionDto.Amount = P_2.ComputeTotalAmount(newRentalTransactionDto.Duration, newRentalTransactionDto.CurrentTime);
		RentalTransactions.Add(newRentalTransactionDto);
		State = P_1;
		TotalMinutes = CalculTotalMinutes();
	}

	public void PauseSession(FeeScheduleDto scheduler)
	{
		O6dRClgD9M(RentalAction.Pause, RentalState.Paused, scheduler);
	}

	public static decimal GetNowRate(FeeScheduleDto scheduler)
	{
		if (scheduler == null)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(852));
		}
		return scheduler.GetRatePerHour(DateTime.Now);
	}

	public decimal CalculTotalAmount()
	{
		if (RentalTransactions == null || RentalTransactions.Count <= 0)
		{
			throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(934), so95DAFNMfktfjp4Dm.An6v7kuCGg(974));
		}
		if (RentalTransactions.All((NewRentalTransactionDto x) => x.Action != RentalAction.Activate))
		{
			TotalAmount = 0m;
		}
		else
		{
			TotalAmount = RentalTransactions.Sum((NewRentalTransactionDto x) => x.Amount) - RentalTransactions.Where((NewRentalTransactionDto x) => x.Action == RentalAction.Activate || x.Action == RentalAction.Resume).Sum((NewRentalTransactionDto x) => x.Amount);
			TotalAmount = Math.Round(TotalAmount, 2, MidpointRounding.AwayFromZero);
		}
		return TotalAmount;
	}

	public TimeSpan GetLastRentalTxDuration()
	{
		if (RentalTransactions == null || RentalTransactions.Count <= 0)
		{
			return new TimeSpan(0, 0, 0);
		}
		return DateTime.Now - RentalTransactions.Last().CurrentTime;
	}

	public NewRentalSessionDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
