namespace Task5._2;

class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            var dataflowManager = new DataflowManager();
            await dataflowManager.ExecuteDataflow();
        }
        catch (AggregateException ex)
        {
            Console.WriteLine($"An error occurred: {ex.InnerException.Message}");
        }
    }
}