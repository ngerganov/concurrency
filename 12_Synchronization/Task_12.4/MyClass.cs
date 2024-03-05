namespace Task_12._4;

public class MyClass
{
    private readonly TaskCompletionSource<object> _initialized = new TaskCompletionSource<object>();
    private int _value1;
    private int _value2;

    public async Task<int> WaitForInitializationAsync()
    {
        await _initialized.Task;
        return _value1 + _value2;
    }

    public void Initialize()
    {
        _value1 = 13;
        _value2 = 17;
        _initialized.TrySetResult(null);
    }
}