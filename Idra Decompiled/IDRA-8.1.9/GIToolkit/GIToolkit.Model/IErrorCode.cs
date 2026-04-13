namespace GIToolkit.Model;

public interface IErrorCode<T> : IErrorCode
{
	T Result { get; set; }
}
public interface IErrorCode
{
	bool Success { get; set; }

	string ErrorMessage { get; set; }

	int Code { get; set; }
}
