using System.Collections.Concurrent;
using Nito.AsyncEx;

namespace Task_9._11;

public class AsyncCollectionManager<T>
{
    private readonly AsyncCollection<T> _asyncCollection;

    public AsyncCollectionManager(IProducerConsumerCollection<T> collection)
    {
        _asyncCollection = new AsyncCollection<T>(collection);
    }

    public async Task AddAsync(T item)
    {
        await _asyncCollection.AddAsync(item);
    }

    public async Task<T> TakeAsync()
    {
        return await _asyncCollection.TakeAsync();
    }

    public void CompleteAdding()
    {
        _asyncCollection.CompleteAdding();
    }
}