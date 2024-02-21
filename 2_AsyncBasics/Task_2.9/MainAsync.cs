namespace Task2._9;

public static class MainAsync
{
    public static async Task RunAsync(string[] args)
    {
        try
        {
            var command = new MyAsyncCommand();
            await command.ExecuteAsync(args);
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex);
        }
    }
}