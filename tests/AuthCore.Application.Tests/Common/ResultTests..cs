using AuthCore.Application.Common;

namespace AuthCore.Application.Tests.Common;

public class ResultTests
{
    [Fact]
    public void Success_HasNoError()
    {
        var result= Result.Success();
        Assert.True(result.IsSuccess);
        Assert.Null(result.Error);
    }

    [Fact]
    public void Failure_WithEmptyError_ThrowsException()
    {
        Assert.Throws<InvalidOperationException>(() => Result.Failure(string.Empty));
    }
}