using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace Golfin.Dtos;

public class NewPlayerInvoiceDto
{
	[CompilerGenerated]
	private int uTyVGtSORm;

	[CompilerGenerated]
	private string dnpVCK8JNT;

	[CompilerGenerated]
	private DeductionType RtsVsH6E7y;

	[CompilerGenerated]
	private decimal qhQVOyI4FD;

	[CompilerGenerated]
	private DateTime ThiV90dtNV;

	[CompilerGenerated]
	private decimal HhmVhUvhKH;

	[CompilerGenerated]
	private decimal fUHVQjJnSW;

	[CompilerGenerated]
	private bool B87VTAeogO;

	[CompilerGenerated]
	private bool SvOVLom6xV;

	[CompilerGenerated]
	private bool YIdV0X2q22;

	[CompilerGenerated]
	private decimal XqnVZDfWXb;

	[CompilerGenerated]
	private List<NewCardTransactionDto> bwRVMcCrQM;

	[CompilerGenerated]
	private MemberUpdateDto iS4VSr98FH;

	[CompilerGenerated]
	private int vPCVgs24Sb;

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return uTyVGtSORm;
		}
		[CompilerGenerated]
		set
		{
			uTyVGtSORm = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return dnpVCK8JNT;
		}
		[CompilerGenerated]
		set
		{
			dnpVCK8JNT = value;
		}
	}

	public DeductionType PromoType
	{
		[CompilerGenerated]
		get
		{
			return RtsVsH6E7y;
		}
		[CompilerGenerated]
		set
		{
			RtsVsH6E7y = value;
		}
	}

	public decimal PromoValue
	{
		[CompilerGenerated]
		get
		{
			return qhQVOyI4FD;
		}
		[CompilerGenerated]
		set
		{
			qhQVOyI4FD = value;
		}
	}

	public string PlayerName
	{
		get
		{
			string text;
			if (User != null)
			{
				text = User.FullName;
				if (text == null)
				{
					return "";
				}
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
				defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(504));
				defaultInterpolatedStringHandler.AppendFormatted(PlayerNumber + 1);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			return text;
		}
	}

	public DateTime TransactionDate
	{
		[CompilerGenerated]
		get
		{
			return ThiV90dtNV;
		}
		[CompilerGenerated]
		set
		{
			ThiV90dtNV = value;
		}
	}

	public decimal TotalGross
	{
		[CompilerGenerated]
		get
		{
			return HhmVhUvhKH;
		}
		[CompilerGenerated]
		set
		{
			HhmVhUvhKH = value;
		}
	}

	public decimal Rebate
	{
		[CompilerGenerated]
		get
		{
			return fUHVQjJnSW;
		}
		[CompilerGenerated]
		set
		{
			fUHVQjJnSW = value;
		}
	}

	public decimal TotalNet
	{
		get
		{
			if (!(TotalGross - Rebate - Math.Abs(CardAmountTaken) <= 0m))
			{
				return TotalGross - Rebate - Math.Abs(CardAmountTaken);
			}
			return 0m;
		}
	}

	public bool HasAlreadyScanCard
	{
		[CompilerGenerated]
		get
		{
			return B87VTAeogO;
		}
		[CompilerGenerated]
		set
		{
			B87VTAeogO = value;
		}
	}

	public bool HasGameAttendantMistake
	{
		[CompilerGenerated]
		get
		{
			return SvOVLom6xV;
		}
		[CompilerGenerated]
		set
		{
			SvOVLom6xV = value;
		}
	}

	public bool HasAlreadyPaid
	{
		[CompilerGenerated]
		get
		{
			return YIdV0X2q22;
		}
		[CompilerGenerated]
		set
		{
			YIdV0X2q22 = value;
		}
	}

	public decimal CardAmountTaken
	{
		[CompilerGenerated]
		get
		{
			return XqnVZDfWXb;
		}
		[CompilerGenerated]
		set
		{
			XqnVZDfWXb = value;
		}
	}

	public List<NewCardTransactionDto> NewCardTxToUser
	{
		[CompilerGenerated]
		get
		{
			return bwRVMcCrQM;
		}
		[CompilerGenerated]
		set
		{
			bwRVMcCrQM = value;
		}
	}

	public MemberUpdateDto User
	{
		[CompilerGenerated]
		get
		{
			return iS4VSr98FH;
		}
		[CompilerGenerated]
		set
		{
			iS4VSr98FH = value;
		}
	}

	public int PlayerNumber
	{
		[CompilerGenerated]
		get
		{
			return vPCVgs24Sb;
		}
		[CompilerGenerated]
		set
		{
			vPCVgs24Sb = value;
		}
	}

	public void ResetUserBalanceToDefault()
	{
		if (HasAlreadyScanCard && User != null)
		{
			User.Balance += Math.Abs(CardAmountTaken);
			HasAlreadyPaid = false;
			HasAlreadyScanCard = false;
			HasGameAttendantMistake = true;
			CardAmountTaken = 0m;
			User = null;
		}
		PromoType = DeductionType.FlatPrice;
		PromoValue = 0m;
		Description = so95DAFNMfktfjp4Dm.An6v7kuCGg(482);
		Rebate = 0m;
	}

	public static decimal Clamp(decimal value, decimal min, decimal max)
	{
		if (!(value < min))
		{
			if (!(value > max))
			{
				return value;
			}
			return max;
		}
		return min;
	}

	public void ApplyPromotion(PromotionDto promo, UserDto member)
	{
		switch (promo.DeductionType)
		{
		case DeductionType.None:
			CardAmountTaken = 0m;
			Rebate = 0m;
			Description = promo.Name;
			PromoType = promo.DeductionType;
			PromoValue = promo.Price;
			if (member != null)
			{
				xjhVHHTAOg(member);
				HasGameAttendantMistake = false;
				hl1Vwge0U5(promo.Price, Description);
			}
			break;
		case DeductionType.FlatPrice:
			CardAmountTaken = 0m;
			Rebate = ((TotalGross == 0m) ? 0m : (TotalGross - promo.Price));
			Description = promo.Name;
			PromoType = promo.DeductionType;
			PromoValue = promo.Price;
			if (member != null)
			{
				xjhVHHTAOg(member);
				HasGameAttendantMistake = false;
				hl1Vwge0U5(Math.Abs(TotalGross - Rebate), Description);
			}
			break;
		case DeductionType.Percentage:
			CardAmountTaken = 0m;
			Rebate = Math.Round(TotalGross * (promo.Price / 100m), 2, MidpointRounding.AwayFromZero);
			Description = promo.Name;
			PromoType = promo.DeductionType;
			PromoValue = promo.Price;
			if (member != null)
			{
				xjhVHHTAOg(member);
				HasGameAttendantMistake = false;
				hl1Vwge0U5(Math.Abs(TotalGross - Rebate), Description);
			}
			break;
		case DeductionType.PricePerHour:
		case DeductionType.PercentagePerHour:
			break;
		}
	}

	private void xjhVHHTAOg(UserDto P_0)
	{
		if (User == null || !(User.CardNumber == P_0.CardNumber))
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(522));
			}
			User = new MemberUpdateDto
			{
				Id = P_0.Id,
				Balance = P_0.Balance,
				CardNumber = P_0.CardNumber,
				FullName = P_0.FullName,
				IsTemporaryMember = P_0.IsTemporaryMember
			};
			NewCardTxToUser = new List<NewCardTransactionDto>();
		}
	}

	private void hl1Vwge0U5(decimal P_0, string P_1)
	{
		if (User == null)
		{
			throw new ArgumentNullException(so95DAFNMfktfjp4Dm.An6v7kuCGg(662));
		}
		if (User.Balance > 0m)
		{
			decimal num;
			if (P_0 >= User.Balance)
			{
				num = User.Balance;
				User.Balance = 0m;
			}
			else
			{
				num = P_0;
				User.Balance -= P_0;
			}
			CardAmountTaken = num * -1m;
			HasAlreadyPaid = true;
			NewCardTxToUser.Add(new NewCardTransactionDto
			{
				Amount = CardAmountTaken,
				AmountPaid = Math.Abs(CardAmountTaken),
				Reason = P_1,
				TxDate = DateTime.Now
			});
		}
		HasAlreadyScanCard = true;
	}

	public NewPlayerInvoiceDto()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
