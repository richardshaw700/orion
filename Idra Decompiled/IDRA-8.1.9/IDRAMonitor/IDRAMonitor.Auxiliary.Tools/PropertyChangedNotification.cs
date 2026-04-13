using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using hkpxmGISLhTJrZLcmi;
using jBnbmEXkwPOPpPQ9mC;

namespace IDRAMonitor.Auxiliary.Tools;

public abstract class PropertyChangedNotification : INotifyPropertyChanged, IDataErrorInfo
{
	private readonly Dictionary<string, object> T2ZFoYatuh;

	[CompilerGenerated]
	private PropertyChangedEventHandler xW7Fb0Ec9T;

	[CompilerGenerated]
	private bool EfPFs2pP9w;

	string IDataErrorInfo.Error
	{
		get
		{
			throw new NotSupportedException(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6744));
		}
	}

	public string this[string propertyName] => OnValidate(propertyName);

	protected virtual bool ThrowOnInvalidPropertyName
	{
		[CompilerGenerated]
		get
		{
			return EfPFs2pP9w;
		}
		[CompilerGenerated]
		private set
		{
			EfPFs2pP9w = value;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = xW7Fb0Ec9T;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref xW7Fb0Ec9T, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = xW7Fb0Ec9T;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref xW7Fb0Ec9T, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	protected void SetValue<T>(Expression<Func<T>> propertySelector, T value)
	{
		string propertyName = TDoFdxWTtP(propertySelector);
		SetValue(propertyName, value);
	}

	protected void SetValue<T>(string propertyName, T value)
	{
		if (string.IsNullOrEmpty(propertyName))
		{
			throw new ArgumentException(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6698), propertyName);
		}
		T2ZFoYatuh[propertyName] = value;
		NotifyPropertyChanged(propertyName);
	}

	protected T GetValue<T>(Expression<Func<T>> propertySelector)
	{
		string propertyName = TDoFdxWTtP(propertySelector);
		return GetValue<T>(propertyName);
	}

	protected T GetValue<T>(string propertyName)
	{
		if (string.IsNullOrEmpty(propertyName))
		{
			throw new ArgumentException(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6698), propertyName);
		}
		if (!T2ZFoYatuh.TryGetValue(propertyName, out var value))
		{
			value = default(T);
			T2ZFoYatuh.Add(propertyName, value);
		}
		return (T)value;
	}

	protected virtual string OnValidate(string propertyName)
	{
		if (string.IsNullOrEmpty(propertyName))
		{
			throw new ArgumentException(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6698), propertyName);
		}
		string result = string.Empty;
		object value = umQFSugPdK(propertyName);
		List<ValidationResult> list = new List<ValidationResult>(1);
		if (!Validator.TryValidateProperty(value, new ValidationContext(this, null, null)
		{
			MemberName = propertyName
		}, list))
		{
			result = list.First().ErrorMessage;
		}
		return result;
	}

	protected void NotifyPropertyChanged(string propertyName)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = xW7Fb0Ec9T;
		if (propertyChangedEventHandler != null)
		{
			PropertyChangedEventArgs e = new PropertyChangedEventArgs(propertyName);
			propertyChangedEventHandler(this, e);
		}
	}

	protected void NotifyPropertyChanged<T>(Expression<Func<T>> propertySelector)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = xW7Fb0Ec9T;
		if (propertyChangedEventHandler != null)
		{
			string propertyName = TDoFdxWTtP(propertySelector);
			propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	private string TDoFdxWTtP(LambdaExpression P_0)
	{
		return ((P_0.Body as MemberExpression) ?? throw new InvalidOperationException()).Member.Name;
	}

	private object umQFSugPdK(string P_0)
	{
		if (!T2ZFoYatuh.TryGetValue(P_0, out var value))
		{
			value = (TypeDescriptor.GetProperties(GetType()).Find(P_0, ignoreCase: false) ?? throw new ArgumentException(ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6698), P_0)).GetValue(this);
			T2ZFoYatuh.Add(P_0, value);
		}
		return value;
	}

	[Conditional("DEBUG")]
	[DebuggerStepThrough]
	public void VerifyPropertyName(string propertyName)
	{
		if (TypeDescriptor.GetProperties(this)[propertyName] == null)
		{
			string message = ovjWJt1tE1HTo0M6Yo.z0lG4sgh92(6918) + propertyName;
			if (ThrowOnInvalidPropertyName)
			{
				throw new Exception(message);
			}
		}
	}

	protected PropertyChangedNotification()
	{
		sfdIMacorwsONDcXji.p9wJZFvkayjbK();
		T2ZFoYatuh = new Dictionary<string, object>();
		base._002Ector();
	}
}
