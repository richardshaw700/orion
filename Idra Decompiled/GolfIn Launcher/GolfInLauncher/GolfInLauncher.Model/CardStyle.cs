using System.Runtime.CompilerServices;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using U9xbeMdbyr6Pactctj;

namespace GolfInLauncher.Model;

public class CardStyle : ObservableRecipient
{
	[CompilerGenerated]
	private double DmgsQdGlrg;

	[CompilerGenerated]
	private double v5lsxuvcUs;

	[CompilerGenerated]
	private double aOpsHPx04d;

	[CompilerGenerated]
	private double PMKscTHy8U;

	public double CardWidth
	{
		[CompilerGenerated]
		get
		{
			return DmgsQdGlrg;
		}
		[CompilerGenerated]
		private set
		{
			DmgsQdGlrg = value;
		}
	}

	public double CardHeight
	{
		[CompilerGenerated]
		get
		{
			return v5lsxuvcUs;
		}
		[CompilerGenerated]
		private set
		{
			v5lsxuvcUs = value;
		}
	}

	public double CardImgWidth
	{
		[CompilerGenerated]
		get
		{
			return aOpsHPx04d;
		}
		[CompilerGenerated]
		private set
		{
			aOpsHPx04d = value;
		}
	}

	public double CardImgHeight
	{
		[CompilerGenerated]
		get
		{
			return PMKscTHy8U;
		}
		[CompilerGenerated]
		private set
		{
			PMKscTHy8U = value;
		}
	}

	public void SetCardDimensions(int row)
	{
		double fullPrimaryScreenWidth = SystemParameters.FullPrimaryScreenWidth;
		double fullPrimaryScreenHeight = SystemParameters.FullPrimaryScreenHeight;
		switch (row)
		{
		case 8:
			CardWidth = fullPrimaryScreenWidth / 8.4;
			CardHeight = fullPrimaryScreenHeight / 4.0;
			CardImgWidth = fullPrimaryScreenWidth / 8.0;
			CardImgHeight = fullPrimaryScreenHeight / 5.3;
			break;
		case 9:
			CardWidth = fullPrimaryScreenWidth / 9.5;
			CardHeight = fullPrimaryScreenHeight / 4.5;
			CardImgWidth = fullPrimaryScreenWidth / 8.0;
			CardImgHeight = fullPrimaryScreenHeight / 6.1;
			break;
		default:
			CardWidth = fullPrimaryScreenWidth / 7.314;
			CardHeight = fullPrimaryScreenHeight / 3.604;
			CardImgWidth = fullPrimaryScreenWidth / 7.0;
			CardImgHeight = fullPrimaryScreenHeight / 4.6;
			break;
		}
	}

	public CardStyle()
	{
		lmHjJQCH4A8ZxGcE9N.F5fEhBwywTMpR();
		DmgsQdGlrg = SystemParameters.FullPrimaryScreenWidth / 7.314;
		v5lsxuvcUs = SystemParameters.FullPrimaryScreenHeight / 3.604;
		aOpsHPx04d = SystemParameters.FullPrimaryScreenWidth / 7.0;
		PMKscTHy8U = SystemParameters.FullPrimaryScreenHeight / 4.6;
		base._002Ector();
	}
}
