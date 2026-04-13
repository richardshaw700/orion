using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using hkpxmGISLhTJrZLcmi;
using jBnbmEXkwPOPpPQ9mC;

namespace QLXE2vtAnwIM12FOIk;

internal class fvP2RtqLoAmdJsltkQ : ObservableObject, IDataErrorInfo
{
	private readonly Dictionary<string, object> tdjGj482G9;

	string IDataErrorInfo.Error
	{
		get
		{
			throw new NotSupportedException(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6744));
		}
	}

	string IDataErrorInfo.this[string P_0] => OnValidate(P_0);

	protected virtual string OnValidate(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			throw new ArgumentException(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6698), P_0);
		}
		string result = string.Empty;
		object value = dwCFzf8Ahj(P_0);
		List<ValidationResult> list = new List<ValidationResult>(1);
		if (!Validator.TryValidateProperty(value, new ValidationContext(this, null, null)
		{
			MemberName = P_0
		}, list))
		{
			result = list.First().ErrorMessage;
		}
		return result;
	}

	private object dwCFzf8Ahj(string P_0)
	{
		if (!tdjGj482G9.TryGetValue(P_0, out var value))
		{
			value = (TypeDescriptor.GetProperties(GetType()).Find(P_0, ignoreCase: false) ?? throw new ArgumentException(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6698), P_0)).GetValue(this);
			tdjGj482G9.Add(P_0, value);
		}
		return value;
	}

	protected bool PpeGrV7Kmr<P1aeDuWmLDaQxnw57P>(ref P1aeDuWmLDaQxnw57P P_0, P1aeDuWmLDaQxnw57P j30Ho03Q7ADxBeJl70, [CallerMemberName] string propertyName = null)
	{
		bool result = SetProperty(ref P_0, j30Ho03Q7ADxBeJl70, propertyName);
		tdjGj482G9[propertyName] = P_0;
		return result;
	}

	public fvP2RtqLoAmdJsltkQ()
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		tdjGj482G9 = new Dictionary<string, object>();
		base._002Ector();
	}
}
