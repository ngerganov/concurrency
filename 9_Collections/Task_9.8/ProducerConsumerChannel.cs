using System.Threading.Channels;

namespace Task_9._8;

public class ProducerConsumerChannel
{
    private readonly Channel<int> _queue = Channel.CreateUnbounded<int>();

    public async Task EnqueueAsync(int item)
    {
        await _queue.Writer.WriteAsync(item);
    }

    public Task CompleteAsync()
    {
        _queue.Writer.Complete();
        return Task.CompletedTask;
    }

    public async IAsyncEnumerable<int> DequeueAllAsync()
    {
        await foreach (int item in _queue.Reader.ReadAllAsync())
        {
            yield return item;
        }
    }
}