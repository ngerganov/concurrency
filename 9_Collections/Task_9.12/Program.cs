using System.Threading.Tasks.Dataflow;

namespace Task_9._12;

class Program
{
    static async Task Main(string[] args)
    {
        var queue = new BufferBlock<int>();
        var producer = new Producer(queue);
        var consumer = new Consumer(queue);

        await producer.ProduceAsync();
        await consumer.ConsumeAsync();
    }
}