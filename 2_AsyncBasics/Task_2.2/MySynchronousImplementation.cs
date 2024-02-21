namespace Task2._2;

public class MySynchronousImplementation : IMyAsyncInterface
{
    public Task<int> GetValueAsync()
    {
        return Task.FromResult(13);
    }

    public Task DoSomethingAsync()
    {
        return Task.CompletedTask;
    }
}