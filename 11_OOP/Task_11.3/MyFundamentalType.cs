namespace Task_11._3;

public class MyFundamentalType : IAsyncInitialization
{
    public MyFundamentalType()
    {
        Initialization = InitializeAsync();
    }

    public Task Initialization { get; private set; }

    private async Task InitializeAsync()
    {
        await Task.Delay(TimeSpan.FromSeconds(1));
        Console.WriteLine("MyFundamentalType initialized asynchronously.");
    }
}