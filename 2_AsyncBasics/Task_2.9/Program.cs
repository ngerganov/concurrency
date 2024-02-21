namespace Task2._9;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            MainAsync.RunAsync(args).GetAwaiter().GetResult();
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex);
        }
    }
}