namespace Task_9._10;

class Program
{
    static async Task Main(string[] args)
    {
        var queue = new ProducerConsumerQueue<int>(1);
        
        await queue.EnqueueAsync(7);
        Console.WriteLine("Объект 7 поставлен в очередь");
        
        await queue.EnqueueAsync(13);
        Console.WriteLine("Объект 13 поставлен в очередь");
    }
}