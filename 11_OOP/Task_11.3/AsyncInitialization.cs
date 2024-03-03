namespace Task_11._3;

public static class AsyncInitialization
{
    public static async Task WhenAllInitializedAsync(params object[] instances)
    {
        await Task.WhenAll(instances
            .OfType<IAsyncInitialization>()
            .Select(x => x.Initialization));
    }
}