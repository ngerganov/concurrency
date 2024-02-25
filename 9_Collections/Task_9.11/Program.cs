using System.Collections.Concurrent;

namespace Task_9._11;

class Program
{
    static async Task Main(string[] args)
    {
        var asyncStackManager = new AsyncCollectionManager<int>(new ConcurrentStack<int>());
        var producer = new Producer(asyncStackManager);
        var consumer = new Consumer(asyncStackManager);

        var produceTask = producer.ProduceItems();
        var consumeTask = consumer.ConsumeItems();

        await Task.WhenAll(produceTask, consumeTask);
    }
}