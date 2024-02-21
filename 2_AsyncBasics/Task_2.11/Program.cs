namespace Task2._11;

class Program
{
    static async Task Main(string[] args)
    {
        var valueTaskMethods = new ValueTaskMethods();
        var consumer = new Consumer(valueTaskMethods);
            
        Console.WriteLine("Consuming ValueTask result:");
        await consumer.ConsumingMethodAsync();
    }
}