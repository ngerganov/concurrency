namespace Task2._8;

public class ExceptionHandler
{
    public async Task ThrowExceptionAsync()
    {
        await Task.Delay(TimeSpan.FromSeconds(1));
        throw new InvalidOperationException("Test");
    }

    public async Task TestAsync()
    {
        try
        {
            await ThrowExceptionAsync();
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("InvalidOperationException");
        }
    }
}