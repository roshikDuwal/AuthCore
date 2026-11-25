using AuthCore.Application.Common;

namespace AuthCore.Application.Tests.Common;

public class ResultOfTTests
{
    [Fact]
    public void Success_HasNoError()
    {
        var result = Result<int>.Success(22);
        Assert.True(result.IsSuccess);
        Assert.Null(result.Error);
    }

    [Fact]
    public void Failure_WithEmptyError_ThrowsException()
    {
        Assert.Throws<InvalidOperationException>(() => Result<int>.Failure(string.Empty));
    }

    [Fact]
    public void Success_ReturnsValue()
    {
        var result=Result<int>.Success(42);
        Assert.Equal(42,result.Value);
    }

    [Fact]
    public void Value_OnFailure_Throws()
    {
        var result=Result<int>.Failure("Something went wrong");
        Assert.Throws<InvalidOperationException>(()=>result.Value);
    }
}