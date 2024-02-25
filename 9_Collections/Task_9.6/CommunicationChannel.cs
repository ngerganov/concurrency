using System.Collections.Concurrent;

namespace Task_9._6;

class CommunicationChannel
{
    private readonly BlockingCollection<int> _blockingQueue = new BlockingCollection<int>();

    public void AddItem(int item)
    {
        _blockingQueue.Add(item);
    }

    public void CompleteAdding()
    {
        _blockingQueue.CompleteAdding();
    }

    public IEnumerable<int> GetConsumingEnumerable()
    {
        return _blockingQueue.GetConsumingEnumerable();
    }
}