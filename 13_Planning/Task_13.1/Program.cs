namespace Task_13._1;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting main thread...");

        Task task1 = Task.Run(() =>
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Task 1 is complete.");
        });

        Task<int> task2 = Task.Run(async () =>
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            Console.WriteLine("Task 2 is complete.");
            return 13;
        });

        int result = await task2;
        Console.WriteLine($"Result of Task 2: {result}");

        Console.WriteLine("Main thread finished.");
    }
}