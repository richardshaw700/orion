using System.Collections;
using System.ComponentModel.DataAnnotations;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace Golfin.CustomValidation;

public class NotNullOrEmptyCollectionAttribute : ValidationAttribute
{
	public override bool IsValid(object value)
	{
		if (value is ICollection collection)
		{
			return collection.Count != 0;
		}
		if (value is IEnumerable enumerable)
		{
			return enumerable.GetEnumerator().MoveNext();
		}
		return false;
	}

	public NotNullOrEmptyCollectionAttribute()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
