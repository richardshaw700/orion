using System.ComponentModel.DataAnnotations;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace Golfin.CustomValidation;

public class CardNumberLengthAttribute : ValidationAttribute
{
	private readonly int IXEYXqHjYq;

	private readonly int OCpYF0kQvg;

	public CardNumberLengthAttribute(int maximumLength, int minimumLength = 0)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		IXEYXqHjYq = maximumLength;
		OCpYF0kQvg = minimumLength;
	}

	public override bool IsValid(object value)
	{
		string text = value as string;
		if (string.IsNullOrEmpty(text))
		{
			return true;
		}
		int length = text.Length;
		if (length >= OCpYF0kQvg)
		{
			return length <= IXEYXqHjYq;
		}
		return false;
	}
}
