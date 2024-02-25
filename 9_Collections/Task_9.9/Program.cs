using System.Threading.Channels;

namespace Task_9._9;

class Program
{
    static async Task Main(string[] args)
    {
        var queue = new ProducerConsumerQueue<int>(1);

        Task producerTask = Task.Run(async () =>
        {
            await queue.EnqueueAsync(7);
            Console.WriteLine("Добавлено 7 в очередь");
            await queue.EnqueueAsync(13);
            Console.WriteLine("Добавлено 13 в очередь после удаления из очереди 7");
            queue.CompleteAdding();
        });

        Task consumerTask = Task.Run(async () =>
        {
            while (true)
            {
                int item;
                try
                {
                    item = await queue.DequeueAsync();
                }
                catch (ChannelClosedException)
                {
                    break;
                }
                Console.WriteLine($"Удалено из очереди: {item}");
            }
        });

        await Task.WhenAll(producerTask, consumerTask);
    }
}