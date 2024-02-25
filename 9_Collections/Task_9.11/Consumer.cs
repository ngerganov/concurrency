namespace Task_9._11;

public class Consumer
{
    private readonly AsyncCollectionManager<int> _manager;

    public Consumer(AsyncCollectionManager<int> manager)
    {
        _manager = manager;
    }

    public async Task ConsumeItems()
    {
        try
        {
            while (true)
            {
                int item = await _manager.TakeAsync();
                Console.WriteLine(item);
            }
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("All items consumed");
        }
    }
}