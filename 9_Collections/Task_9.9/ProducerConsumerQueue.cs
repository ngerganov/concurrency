using System.Threading.Channels;

namespace Task_9._9;

public class ProducerConsumerQueue<T>
{
    private readonly Channel<T> _queue;

    public ProducerConsumerQueue(int maxCount)
    {
        _queue = Channel.CreateBounded<T>(maxCount);
    }

    public async Task EnqueueAsync(T item)
    {
        await _queue.Writer.WriteAsync(item);
    }

    public async Task<T> DequeueAsync()
    {
        return await _queue.Reader.ReadAsync();
    }

    public void CompleteAdding()
    {
        _queue.Writer.Complete();
    }
}