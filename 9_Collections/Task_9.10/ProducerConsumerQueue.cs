using System.Threading.Channels;

namespace Task_9._10;

public class ProducerConsumerQueue<T>
{
    private readonly ChannelWriter<T> _writer;

    public ProducerConsumerQueue(int bufferSize)
    {
        Channel<T> queue = Channel.CreateBounded<T>(new BoundedChannelOptions(bufferSize)
        {
            FullMode = BoundedChannelFullMode.DropOldest
        });
        _writer = queue.Writer;
    }

    public async Task EnqueueAsync(T item)
    {
        await _writer.WriteAsync(item);
    }
}