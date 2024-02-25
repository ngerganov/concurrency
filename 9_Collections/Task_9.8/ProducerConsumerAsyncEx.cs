using Nito.AsyncEx;

namespace Task_9._8;

public class ProducerConsumerAsyncEx<T>
{
    private readonly AsyncProducerConsumerQueue<T> _queue = new AsyncProducerConsumerQueue<T>();

    public async Task EnqueueAsync(T item)
    {
        await _queue.EnqueueAsync(item);
    }

    public Task CompleteAsync()
    {
        _queue.CompleteAdding();
        return Task.CompletedTask;
    }

    public async Task<T> DequeueAsync()
    {
        return await _queue.DequeueAsync();
    }
}