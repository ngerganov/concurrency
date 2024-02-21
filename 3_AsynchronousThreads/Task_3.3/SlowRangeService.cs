namespace Task3._3;

public class SlowRangeService : ISlowRangeService
{
    public async IAsyncEnumerable<int> GetSlowRange()
    {
        for (int i = 0; i != 10; ++i)
        {
            await Task.Delay(i * 100);
            yield return i;
        }
    }
}