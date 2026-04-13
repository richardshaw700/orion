using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using GIToolkit.Resources;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.CustomValidation;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class EitherRequiredAttribute : ValidationAttribute
{
	private readonly string hhQvJeU2c6;

	private readonly string qfvveX3Xj3;

	public EitherRequiredAttribute(string field1, string field2)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		hhQvJeU2c6 = field1;
		qfvveX3Xj3 = field2;
		base.ErrorMessageResourceType = typeof(DtoTraduction);
		base.ErrorMessageResourceName = DtoTraduction.ValidationAttribute_EitherOneRequired;
	}

	protected override ValidationResult IsValid(object value, ValidationContext validationContext)
	{
		if (!Yayvv3Bc7m(hhQvJeU2c6, validationContext, out var propertyInfo))
		{
			return new ValidationResult(string.Format(so95DAFNMfktfjp4Dm.An6v7kuCGg(21306), hhQvJeU2c6), new string[1] { hhQvJeU2c6 });
		}
		if (!Yayvv3Bc7m(qfvveX3Xj3, validationContext, out var propertyInfo2))
		{
			return new ValidationResult(string.Format(so95DAFNMfktfjp4Dm.An6v7kuCGg(21306), qfvveX3Xj3), new string[1] { hhQvJeU2c6 });
		}
		if (propertyInfo.GetValue(validationContext.ObjectInstance) != null || propertyInfo2.GetValue(validationContext.ObjectInstance) != null)
		{
			return ValidationResult.Success;
		}
		return new ValidationResult(string.Format(base.ErrorMessageResourceName, hhQvJeU2c6, qfvveX3Xj3), new string[2] { hhQvJeU2c6, qfvveX3Xj3 });
	}

	private bool Yayvv3Bc7m(string P_0, ValidationContext P_1, out PropertyInfo P_2)
	{
		return (P_2 = P_1.ObjectType.GetProperty(P_0)) != null;
	}
}
