namespace Task3._4;

class Program
{
    static async Task Main(string[] args)
    {
        ISlowRangeService slowRangeService = new SlowRangeService();
        AsyncCancellationDemo asyncCancellationDemo = new AsyncCancellationDemo(slowRangeService);

        Console.WriteLine("Without Cancellation:");
        await asyncCancellationDemo.ConsumeSequence();

        Console.WriteLine("\nWith Cancellation:");
        using var cts = new CancellationTokenSource(500);
        CancellationToken cancellationToken = cts.Token;
        await asyncCancellationDemo.ConsumeSequence(cancellationToken);
    }
}