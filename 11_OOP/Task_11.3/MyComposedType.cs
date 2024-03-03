namespace Task_11._3;

public class MyComposedType : IAsyncInitialization
{
    private readonly MyFundamentalType _fundamental;

    public MyComposedType(MyFundamentalType fundamental)
    {
        _fundamental = fundamental;
        Initialization = InitializeAsync();
    }

    public Task Initialization { get; private set; }

    private async Task InitializeAsync()
    {
        var fundamentalAsyncInit = _fundamental as IAsyncInitialization;
        if (fundamentalAsyncInit != null)
            await fundamentalAsyncInit.Initialization;

        await Task.Delay(TimeSpan.FromSeconds(1));
        Console.WriteLine("MyComposedType initialized asynchronously.");
    }
}