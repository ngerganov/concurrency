namespace Task_11._2;

public class MyAsyncClass
{
    private MyAsyncClass() { }

    private async Task<MyAsyncClass> InitializeAsync()
    {
        await Task.Delay(TimeSpan.FromSeconds(1));
        return this;
    }

    public static async Task<MyAsyncClass> CreateAsync()
    {
        var result = new MyAsyncClass();
        return await result.InitializeAsync();
    }
}