using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using GIToolkit.Services;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class RentalSessionDto
{
	[CompilerGenerated]
	private int XH8AxMnH6R;

	[CompilerGenerated]
	private DateTime lAUA69DncL;

	[CompilerGenerated]
	private DateTime? CkZAEggnQ4;

	[CompilerGenerated]
	private RentalState IbUABdlnYl;

	[CompilerGenerated]
	private decimal CpjA3JWEwf;

	[CompilerGenerated]
	private double epvA27f81N;

	[CompilerGenerated]
	private string zW9AocHxBn;

	[CompilerGenerated]
	private int? rE7Ateb6qV;

	[CompilerGenerated]
	private List<RentalTransactionDto> btBADiQmkn;

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return XH8AxMnH6R;
		}
		[CompilerGenerated]
		set
		{
			XH8AxMnH6R = value;
		}
	}

	public DateTime StartedOn
	{
		[CompilerGenerated]
		get
		{
			return lAUA69DncL;
		}
		[CompilerGenerated]
		set
		{
			lAUA69DncL = value;
		}
	}

	public DateTime? EndedOn
	{
		[CompilerGenerated]
		get
		{
			return CkZAEggnQ4;
		}
		[CompilerGenerated]
		set
		{
			CkZAEggnQ4 = value;
		}
	}

	public RentalState State
	{
		[CompilerGenerated]
		get
		{
			return IbUABdlnYl;
		}
		[CompilerGenerated]
		set
		{
			IbUABdlnYl = value;
		}
	}

	public decimal TotalAmount
	{
		[CompilerGenerated]
		get
		{
			return CpjA3JWEwf;
		}
		[CompilerGenerated]
		set
		{
			CpjA3JWEwf = value;
		}
	}

	public double TotalMinutes
	{
		[CompilerGenerated]
		get
		{
			return epvA27f81N;
		}
		[CompilerGenerated]
		set
		{
			epvA27f81N = value;
		}
	}

	public string SimulatorId
	{
		[CompilerGenerated]
		get
		{
			return zW9AocHxBn;
		}
		[CompilerGenerated]
		set
		{
			zW9AocHxBn = value;
		}
	}

	public int? RentalInvoiceId
	{
		[CompilerGenerated]
		get
		{
			return rE7Ateb6qV;
		}
		[CompilerGenerated]
		set
		{
			rE7Ateb6qV = value;
		}
	}

	public List<RentalTransactionDto> RentalTransactions
	{
		[CompilerGenerated]
		get
		{
			return btBADiQmkn;
		}
		[CompilerGenerated]
		set
		{
			btBADiQmkn = value;
		}
	}

	public TimeSpan GetTimerTime()
	{
		if (RentalTransactions == null || RentalTransactions.Count <= 0)
		{
			return new TimeSpan(0, 0, 0);
		}
		TimeSpan timeSpan = RentalTransactions.Select((RentalTransactionDto x) => x.Duration).Sum();
		TimeSpan timeSpan2 = (from x in RentalTransactions
			where x.Action == RentalAction.Activate || x.Action == RentalAction.Resume
			select x.Duration).Sum();
		TimeSpan result = timeSpan - timeSpan2;
		if (State == RentalState.Activated)
		{
			TimeSpan timeSpan3 = DateTime.UtcNow - RentalTransactions.Last().CurrentTime;
			result += timeSpan3;
		}
		return result;
	}

	public RentalSessionDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
