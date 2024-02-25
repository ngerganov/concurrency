using System.Threading.Tasks.Dataflow;

namespace Task_9._12;

public class Consumer
{
    private readonly BufferBlock<int> _queue;

    public Consumer(BufferBlock<int> queue)
    {
        _queue = queue;
    }

    public async Task ConsumeAsync()
    {
        while (await _queue.OutputAvailableAsync())
        {
            var item = await _queue.ReceiveAsync();
            Console.WriteLine(item);
        }
    }
}