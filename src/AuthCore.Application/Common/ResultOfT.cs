namespace AuthCore.Application.Common;
public class Result<T> : Result
{
    private readonly T? _value;
    private Result(bool isSuccess,T? value,string? error) : base(isSuccess, error)
    {
        _value = value;
    }

    public T Value=>IsSuccess ? _value! : throw new InvalidOperationException("Cannot access the value of a failed result.");

    public static Result<T> Success(T value) => new Result<T>(true, value, null);
    public static new Result<T> Failure(string error) => new Result<T>(false, default, error);
}