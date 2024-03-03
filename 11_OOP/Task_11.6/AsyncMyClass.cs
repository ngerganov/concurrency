namespace Task_11._6;

public class AsyncMyClass : IAsyncDisposable
{
    public async ValueTask DisposeAsync()
    {
        await Task.Delay(TimeSpan.FromSeconds(2));
        Console.WriteLine("AsyncMyClass disposed asynchronously.");
    }
}