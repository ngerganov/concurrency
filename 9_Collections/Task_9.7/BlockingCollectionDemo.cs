using System.Collections.Concurrent;

namespace Task_9._7;

public class BlockingCollectionDemo
{
    private readonly BlockingCollection<int> _blockingStack;
    private readonly BlockingCollection<int> _blockingBag;

    public BlockingCollectionDemo()
    {
        _blockingStack = new BlockingCollection<int>(new ConcurrentStack<int>());
        _blockingBag = new BlockingCollection<int>(new ConcurrentBag<int>());
    }

    public void AddElementsToBlockingStack()
    {
        _blockingStack.Add(7);
        _blockingStack.Add(13);
        _blockingStack.CompleteAdding();
    }

    public void ConsumeElementsFromBlockingStack()
    {
        Console.WriteLine("Blocking Stack (LIFO):");
        foreach (int item in _blockingStack.GetConsumingEnumerable())
        {
            Console.WriteLine(item);
        }
    }

    public void AddElementsToBlockingBag()
    {
        _blockingBag.Add(7);
        _blockingBag.Add(13);
        _blockingBag.CompleteAdding();
    }

    public void ConsumeElementsFromBlockingBag()
    {
        Console.WriteLine("Blocking Bag (Unordered Multiset):");
        foreach (int item in _blockingBag.GetConsumingEnumerable())
        {
            Console.WriteLine(item);
        }
    }
}