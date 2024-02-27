namespace Task_10._3;

public class TimeoutCancellation
{
    public async Task IssueTimeoutAsync()
    {
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
        CancellationToken token = cts.Token;
        await Task.Delay(TimeSpan.FromSeconds(10), token);
    }

    public async Task IssueTimeoutAsyncSecondCase()
    {
        using var cts = new CancellationTokenSource();
        CancellationToken token = cts.Token;
        cts.CancelAfter(TimeSpan.FromSeconds(5));
        await Task.Delay(TimeSpan.FromSeconds(4), token);
    }
}