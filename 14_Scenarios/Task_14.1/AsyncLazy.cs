namespace Task_14._1;

public class AsyncLazy<T>
{
    private readonly object _mutex = new object();
    private readonly Func<Task<T>> _factory;
    private readonly Lazy<Task<T>> _instance;

    public AsyncLazy(Func<Task<T>> factory)
    {
        _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        _instance = new Lazy<Task<T>>(() => Task.Run(factory));
    }

    public Task<T> GetValueAsync()
    {
        lock (_mutex)
        {
            return _instance.Value;
        }
    }
}