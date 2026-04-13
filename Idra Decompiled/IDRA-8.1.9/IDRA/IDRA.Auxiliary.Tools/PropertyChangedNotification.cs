using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using GhU84wwqvI4UZ3pBfu;
using sxB8TYTZ87aKuujytY;

namespace IDRA.Auxiliary.Tools;

public abstract class PropertyChangedNotification : INotifyPropertyChanged, IDataErrorInfo
{
	private readonly Dictionary<string, object> QE6CtJ1LTH;

	[CompilerGenerated]
	private bool lS3CjYku8Q;

	string IDataErrorInfo.Error
	{
		get
		{
			throw new NotSupportedException(QQXBLjLprwI58ya4VR.y8v8TMFOCb(11566));
		}
	}

	public string this[string propertyName] => OnValidate(propertyName);

	protected virtual bool ThrowOnInvalidPropertyName
	{
		[CompilerGenerated]
		get
		{
			return lS3CjYku8Q;
		}
		[CompilerGenerated]
		private set
		{
			lS3CjYku8Q = value;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void SetValue<T>(Expression<Func<T>> propertySelector, T value)
	{
		string propertyName = rg5CggYasD(propertySelector);
		SetValue(propertyName, value);
	}

	protected void SetValue<T>(string propertyName, T value)
	{
		if (string.IsNullOrEmpty(propertyName))
		{
			throw new ArgumentException(QQXBLjLprwI58ya4VR.y8v8TMFOCb(11520), propertyName);
		}
		QE6CtJ1LTH[propertyName] = value;
		NotifyPropertyChanged(propertyName);
	}

	protected T GetValue<T>(Expression<Func<T>> propertySelector)
	{
		string propertyName = rg5CggYasD(propertySelector);
		return GetValue<T>(propertyName);
	}

	protected T GetValue<T>(string propertyName)
	{
		if (string.IsNullOrEmpty(propertyName))
		{
			throw new ArgumentException(QQXBLjLprwI58ya4VR.y8v8TMFOCb(11520), propertyName);
		}
		if (!QE6CtJ1LTH.TryGetValue(propertyName, out var value))
		{
			value = default(T);
			QE6CtJ1LTH.Add(propertyName, value);
		}
		return (T)value;
	}

	protected virtual string OnValidate(string propertyName)
	{
		if (string.IsNullOrEmpty(propertyName))
		{
			throw new ArgumentException(QQXBLjLprwI58ya4VR.y8v8TMFOCb(11520), propertyName);
		}
		string result = string.Empty;
		object value = TlpC4frivc(propertyName);
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
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		if (propertyChangedEventHandler != null)
		{
			PropertyChangedEventArgs e = new PropertyChangedEventArgs(propertyName);
			propertyChangedEventHandler(this, e);
		}
	}

	protected void NotifyPropertyChanged<T>(Expression<Func<T>> propertySelector)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		if (propertyChangedEventHandler != null)
		{
			string propertyName = rg5CggYasD(propertySelector);
			propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	private string rg5CggYasD(LambdaExpression P_0)
	{
		return ((P_0.Body as MemberExpression) ?? throw new InvalidOperationException()).Member.Name;
	}

	private object TlpC4frivc(string P_0)
	{
		if (!QE6CtJ1LTH.TryGetValue(P_0, out var value))
		{
			value = (TypeDescriptor.GetProperties(GetType()).Find(P_0, ignoreCase: false) ?? throw new ArgumentException(QQXBLjLprwI58ya4VR.y8v8TMFOCb(11520), P_0)).GetValue(this);
			QE6CtJ1LTH.Add(P_0, value);
		}
		return value;
	}

	[DebuggerStepThrough]
	[Conditional("DEBUG")]
	public void VerifyPropertyName(string propertyName)
	{
		if (TypeDescriptor.GetProperties(this)[propertyName] == null)
		{
			string message = QQXBLjLprwI58ya4VR.y8v8TMFOCb(11740) + propertyName;
			if (ThrowOnInvalidPropertyName)
			{
				throw new Exception(message);
			}
		}
	}

	protected PropertyChangedNotification()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		QE6CtJ1LTH = new Dictionary<string, object>();
		base._002Ector();
	}
}
