namespace Task_9._8;

class Program
{
    static async Task Main(string[] args)
    {
        await DemoProducerConsumerChannel();
        await DemoProducerConsumerDataflow();
        await DemoProducerConsumerAsyncEx();
    }

    static async Task DemoProducerConsumerChannel()
    {
        var producerConsumerChannel = new ProducerConsumerChannel();

        await producerConsumerChannel.EnqueueAsync(7);
        await producerConsumerChannel.EnqueueAsync(13);
        await producerConsumerChannel.CompleteAsync();

        await foreach (int value in producerConsumerChannel.DequeueAllAsync())
        {
            Console.WriteLine($"Channel: {value}");
        }
    }

    static async Task DemoProducerConsumerDataflow()
    {
        var producerConsumerDataflow = new ProducerConsumerDataflow<int>();

        await producerConsumerDataflow.EnqueueAsync(7);
        await producerConsumerDataflow.EnqueueAsync(13);
        await producerConsumerDataflow.CompleteAsync();

        while (true)
        {
            try
            {
                int value = await producerConsumerDataflow.DequeueAsync();
                Console.WriteLine($"Dataflow: {value}");
            }
            catch (InvalidOperationException)
            {
                break;
            }
        }
    }

    static async Task DemoProducerConsumerAsyncEx()
    {
        var producerConsumerAsyncEx = new ProducerConsumerAsyncEx<int>();

        await producerConsumerAsyncEx.EnqueueAsync(7);
        await producerConsumerAsyncEx.EnqueueAsync(13);
        await producerConsumerAsyncEx.CompleteAsync();

        while (true)
        {
            try
            {
                int value = await producerConsumerAsyncEx.DequeueAsync();
                Console.WriteLine($"AsyncEx: {value}");
            }
            catch (InvalidOperationException)
            {
                break;
            }
        }
    }
}