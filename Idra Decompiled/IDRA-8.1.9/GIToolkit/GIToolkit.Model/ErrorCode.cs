using System.Runtime.CompilerServices;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Model;

public class ErrorCode : IErrorCode
{
	[CompilerGenerated]
	private bool PPytNyu7bq;

	[CompilerGenerated]
	private string xWStcZNhVj;

	[CompilerGenerated]
	private int DBktIBfBw9;

	public bool Success
	{
		[CompilerGenerated]
		get
		{
			return PPytNyu7bq;
		}
		[CompilerGenerated]
		set
		{
			PPytNyu7bq = value;
		}
	}

	public string ErrorMessage
	{
		[CompilerGenerated]
		get
		{
			return xWStcZNhVj;
		}
		[CompilerGenerated]
		set
		{
			xWStcZNhVj = value;
		}
	}

	public int Code
	{
		[CompilerGenerated]
		get
		{
			return DBktIBfBw9;
		}
		[CompilerGenerated]
		set
		{
			DBktIBfBw9 = value;
		}
	}

	public ErrorCode()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}

	public ErrorCode(bool success, string errorMessage = "", int code = -1)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		Success = success;
		ErrorMessage = errorMessage;
		Code = code;
	}
}
public class ErrorCode<T> : ErrorCode, IErrorCode<T>, IErrorCode
{
	[CompilerGenerated]
	private T PHNtqY0oy9;

	public T Result
	{
		[CompilerGenerated]
		get
		{
			return PHNtqY0oy9;
		}
		[CompilerGenerated]
		set
		{
			PHNtqY0oy9 = value;
		}
	}

	public ErrorCode()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}

	public ErrorCode(bool success, string errorMessage = "", int code = -1, T result = default(T))
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		base.Success = success;
		base.ErrorMessage = errorMessage;
		Result = result;
	}

	public ErrorCode(T result)
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
		Result = result;
		base.Success = true;
		base.ErrorMessage = string.Empty;
	}
}
