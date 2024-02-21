namespace Task3._3;

public class AsyncLinqDemo
{
    private readonly ISlowRangeService _slowRangeService;

    public AsyncLinqDemo(ISlowRangeService slowRangeService)
    {
        _slowRangeService = slowRangeService;
    }

    public async Task WhereAwaitExample()
    {
        IAsyncEnumerable<int> values = _slowRangeService.GetSlowRange().WhereAwait(async value =>
        {
            await Task.Delay(10);
            return value % 2 == 0;
        });

        await foreach (int result in values)
        {
            Console.WriteLine(result);
        }
    }

    public async Task WhereExample()
    {
        IAsyncEnumerable<int> values = _slowRangeService.GetSlowRange().Where(value => value % 2 == 0);

        await foreach (int result in values)
        {
            Console.WriteLine(result);
        }
    }
}