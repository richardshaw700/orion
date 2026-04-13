using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using GhU84wwqvI4UZ3pBfu;
using sxB8TYTZ87aKuujytY;

namespace Js6uMe7CjbKKllWb6H;

internal class oqYFAV0jWhOS0yPo6J : ObservableObject, IDataErrorInfo
{
	private readonly Dictionary<string, object> HhUCeEafRZ;

	string IDataErrorInfo.Error
	{
		get
		{
			throw new NotSupportedException(QQXBLjLprwI58ya4VR.y8v8TMFOCb(11566));
		}
	}

	string IDataErrorInfo.this[string P_0] => OnValidate(P_0);

	protected virtual string OnValidate(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			throw new ArgumentException(QQXBLjLprwI58ya4VR.y8v8TMFOCb(11520), P_0);
		}
		string result = string.Empty;
		object value = hZdCBFmqJb(P_0);
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

	private object hZdCBFmqJb(string P_0)
	{
		if (!HhUCeEafRZ.TryGetValue(P_0, out var value))
		{
			value = (TypeDescriptor.GetProperties(GetType()).Find(P_0, ignoreCase: false) ?? throw new ArgumentException(QQXBLjLprwI58ya4VR.y8v8TMFOCb(11520), P_0)).GetValue(this);
			HhUCeEafRZ.Add(P_0, value);
		}
		return value;
	}

	protected bool fo8CDD9tAn<fh4vocI4TXEACeFawZ>(ref fh4vocI4TXEACeFawZ P_0, fh4vocI4TXEACeFawZ ba5XsC8wL5ALsEynX7, [CallerMemberName] string propertyName = null)
	{
		bool result = SetProperty(ref P_0, ba5XsC8wL5ALsEynX7, propertyName);
		HhUCeEafRZ[propertyName] = P_0;
		return result;
	}

	public oqYFAV0jWhOS0yPo6J()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		HhUCeEafRZ = new Dictionary<string, object>();
		base._002Ector();
	}
}
