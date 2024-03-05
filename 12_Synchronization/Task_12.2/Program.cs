namespace Task_12._2;

class Program
{
    static async Task Main(string[] args)
    {
        IDataService dataService = new DataService();

        Console.WriteLine("Starting tasks...");

        var task1 = dataService.DelayAndIncrementAsync();
        var task2 = dataService.DelayAndIncrementAsync();
        var task3 = dataService.DelayAndIncrementAsync();

        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine($"Task 1 result: {await task1}");
        Console.WriteLine($"Task 2 result: {await task2}");
        Console.WriteLine($"Task 3 result: {await task3}");

        Console.WriteLine("All tasks completed.");
    }
}