namespace Task_7._1;

class AsynchronousSuccess : IMyInterface
{
    public async Task<int> SomethingAsync()
    {
        await Task.Yield();
        return 13;
    }
}