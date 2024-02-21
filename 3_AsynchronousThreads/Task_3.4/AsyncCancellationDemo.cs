namespace Task3._4;

public class AsyncCancellationDemo
{
    private readonly ISlowRangeService _slowRangeService;

    public AsyncCancellationDemo(ISlowRangeService slowRangeService)
    {
        _slowRangeService = slowRangeService;
    }

    public async Task ConsumeSequence(CancellationToken cancellationToken = default)
    {
        try
        {
            await foreach (int result in _slowRangeService.GetSlowRange(cancellationToken))
            {
                Console.WriteLine(result);
            }
        }
        catch (TaskCanceledException)
        {
            Console.WriteLine("Operation was canceled.");
        }
    }
}