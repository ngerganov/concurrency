namespace Task_11._4;

class Program
{
    public static async Task Main(string[] args)
    {
        DataProcessor processor = new DataProcessor();

        Console.WriteLine("Example 1:");
        await Example1(processor);

        Console.WriteLine("\nExample 2:");
        await Example2(processor);
    }

    private static async Task Example1(DataProcessor processor)
    {
        int value = await processor.GetDataAsync();
        Console.WriteLine($"Value: {value}");
    }

    private static async Task Example2(DataProcessor processor)
    {
        AsyncLazy<int> task = processor.GetDataAsync();
        int value = await task;
        Console.WriteLine($"Value: {value}");
    }
}