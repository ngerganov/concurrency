using System.Threading.Tasks.Dataflow;

namespace Task_9._8;

public class ProducerConsumerDataflow<T>
{
    private readonly BufferBlock<T> _buffer = new BufferBlock<T>();

    public async Task EnqueueAsync(T item)
    {
        await _buffer.SendAsync(item);
    }

    public Task CompleteAsync()
    {
        _buffer.Complete();
        return Task.CompletedTask;
    }

    public async Task<T> DequeueAsync()
    {
        return await _buffer.ReceiveAsync();
    }
}