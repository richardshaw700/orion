using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using GIToolkit.Model.Enum;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class NewRentalInvoiceDto
{
	[CompilerGenerated]
	private int QCWV8LsUpJ;

	[CompilerGenerated]
	private decimal ONxVlD7nax;

	[CompilerGenerated]
	private string puFVnAJ8bH;

	[CompilerGenerated]
	private int IQEV1YoYoQ;

	[CompilerGenerated]
	private int? s0rVbnnbG1;

	[CompilerGenerated]
	private TimeSpan hyaV5psRPZ;

	[CompilerGenerated]
	private InvoiceBillingTypes CIUVURJxA1;

	[CompilerGenerated]
	private List<NewPlayerInvoiceDto> H76VmkcVFM;

	public int SiteId
	{
		[CompilerGenerated]
		get
		{
			return QCWV8LsUpJ;
		}
		[CompilerGenerated]
		set
		{
			QCWV8LsUpJ = value;
		}
	}

	public decimal TotalAmount
	{
		[CompilerGenerated]
		get
		{
			return ONxVlD7nax;
		}
		[CompilerGenerated]
		set
		{
			ONxVlD7nax = value;
		}
	}

	public string CloseEmployeeName
	{
		[CompilerGenerated]
		get
		{
			return puFVnAJ8bH;
		}
		[CompilerGenerated]
		set
		{
			puFVnAJ8bH = value;
		}
	}

	public int CountOfPlayers
	{
		[CompilerGenerated]
		get
		{
			return IQEV1YoYoQ;
		}
		[CompilerGenerated]
		set
		{
			IQEV1YoYoQ = value;
		}
	}

	public int? RentalSessionId
	{
		[CompilerGenerated]
		get
		{
			return s0rVbnnbG1;
		}
		[CompilerGenerated]
		set
		{
			s0rVbnnbG1 = value;
		}
	}

	public TimeSpan Duration
	{
		[CompilerGenerated]
		get
		{
			return hyaV5psRPZ;
		}
		[CompilerGenerated]
		set
		{
			hyaV5psRPZ = value;
		}
	}

	public InvoiceBillingTypes InvoiceBillingType
	{
		[CompilerGenerated]
		get
		{
			return CIUVURJxA1;
		}
		[CompilerGenerated]
		set
		{
			CIUVURJxA1 = value;
		}
	}

	public List<NewPlayerInvoiceDto> PlayerInvoices
	{
		[CompilerGenerated]
		get
		{
			return H76VmkcVFM;
		}
		[CompilerGenerated]
		set
		{
			H76VmkcVFM = value;
		}
	}

	public void CalculTotalAmount()
	{
		TotalAmount = PlayerInvoices.Sum((NewPlayerInvoiceDto pi) => pi.TotalNet);
	}

	public void RegisterSale(int countOfPurchasers, decimal invoiceAmount, string closeEmployeeName)
	{
		if (countOfPurchasers == 0)
		{
			throw new DivideByZeroException(so95DAFNMfktfjp4Dm.An6v7kuCGg(410));
		}
		CloseEmployeeName = closeEmployeeName;
		TotalAmount = Math.Round(invoiceAmount, 2);
		CountOfPlayers = countOfPurchasers;
		PlayerInvoices = new List<NewPlayerInvoiceDto>();
		for (int i = 0; i < countOfPurchasers; i++)
		{
			NewPlayerInvoiceDto item = new NewPlayerInvoiceDto
			{
				Description = so95DAFNMfktfjp4Dm.An6v7kuCGg(482),
				TotalGross = Math.Round(TotalAmount / (decimal)countOfPurchasers, 2, MidpointRounding.AwayFromZero),
				TransactionDate = DateTime.Now,
				PlayerNumber = i
			};
			PlayerInvoices.Add(item);
		}
		CalculTotalAmount();
	}

	public NewRentalInvoiceDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
