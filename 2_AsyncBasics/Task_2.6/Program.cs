namespace Task2._6;

class Program
{
    static async Task Main(string[] args)
    {
        var taskProcessor = new TaskProcessor();

        try
        {
            await taskProcessor.ProcessTasksAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}