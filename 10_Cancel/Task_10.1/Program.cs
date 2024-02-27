namespace Task_10._1;

class Program
{
    static void Main(string[] args)
    {
        var example = new CancellationExample();

        Console.WriteLine("Synchronous cancellation:");
        example.IssueCancelRequest();
        Console.WriteLine();

        Console.WriteLine("Asynchronous cancellation:");
        example.IssueCancelRequestAsync().Wait();
    }
}