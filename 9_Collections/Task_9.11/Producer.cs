namespace Task_9._11;

public class Producer
{
    private readonly AsyncCollectionManager<int> _manager;

    public Producer(AsyncCollectionManager<int> manager)
    {
        _manager = manager;
    }

    public async Task ProduceItems()
    {
        await _manager.AddAsync(7);
        await _manager.AddAsync(13);
        _manager.CompleteAdding();
    }
}