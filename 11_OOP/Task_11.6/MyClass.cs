namespace Task_11._6;

public class MyClass : IDisposable
{
    private readonly CancellationTokenSource _disposeCts = new CancellationTokenSource();

    public async Task<int> CalculateValueAsync(CancellationToken cancellationToken)
    {
        using CancellationTokenSource combinedCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, _disposeCts.Token);
        await Task.Delay(TimeSpan.FromSeconds(2), combinedCts.Token);
        return 13;
    }

    public void Dispose()
    {
        _disposeCts.Cancel();
    }
}