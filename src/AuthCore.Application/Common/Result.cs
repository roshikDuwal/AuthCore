namespace AuthCore.Application.Common;
public class Result
{
    protected Result(bool isSuccess, string? error)
    {
        if(isSuccess && error is not null) throw new InvalidOperationException("A successful result cannot have an error.");
        if(!isSuccess && string.IsNullOrWhiteSpace(error)) throw new InvalidOperationException("A failure result must have an error message.");
        IsSuccess=isSuccess;
        Error=error;
    }

    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public string? Error { get; }

    public static Result Success()=> new(true, null);
    public static Result Failure(string error)=> new(false, error);
}