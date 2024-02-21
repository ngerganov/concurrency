namespace Task3._3;

class Program
{
    static async Task Main(string[] args)
    {
        ISlowRangeService slowRangeService = new SlowRangeService();
        AsyncLinqDemo asyncLinqDemo = new AsyncLinqDemo(slowRangeService);

        Console.WriteLine("WhereAwait Example:");
        await asyncLinqDemo.WhereAwaitExample();

        Console.WriteLine("\nWhere Example:");
        await asyncLinqDemo.WhereExample();
    }
}