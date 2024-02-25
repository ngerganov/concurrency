using System.Threading.Tasks.Dataflow;

namespace Task_9._12;

public class Producer
{
    private readonly BufferBlock<int> _queue;

    public Producer(BufferBlock<int> queue)
    {
        _queue = queue;
    }

    public async Task ProduceAsync()
    {
        await _queue.SendAsync(7);
        await _queue.SendAsync(13);
        _queue.Complete();
    }
}