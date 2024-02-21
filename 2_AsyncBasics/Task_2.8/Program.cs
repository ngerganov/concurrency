namespace Task2._8;

class Program
{
    static async Task Main(string[] args)
    {
        var exceptionHandler = new ExceptionHandler();

        try
        {
            await exceptionHandler.TestAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
        }
    }
}