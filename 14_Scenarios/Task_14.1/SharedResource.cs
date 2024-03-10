namespace Task_14._1;

public class SharedResource<T> : ISharedResource<T>
{
    private T _value;
    private readonly Func<T> _factory;
    private bool _initialized;

    public SharedResource(Func<T> factory)
    {
        _factory = factory ?? throw new ArgumentNullException(nameof(factory));
    }

    public T GetValue()
    {
        if (!_initialized)
        {
            _value = _factory();
            _initialized = true;
        }
        return _value;
    }
}