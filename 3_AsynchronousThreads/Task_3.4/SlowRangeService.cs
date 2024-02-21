namespace Task3._4;

public class SlowRangeService : ISlowRangeService
{
    public async IAsyncEnumerable<int> GetSlowRange(CancellationToken cancellationToken = default)
    {
        for (int i = 0; i != 10; ++i)
        {
            await Task.Delay(i * 100, cancellationToken);
            yield return i;
        }
    }
}