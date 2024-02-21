namespace Task2._10;

public class MyDisposableClass : IAsyncDisposable
{
    private Func<Task> _disposeLogic;

    public ValueTask DisposeAsync()
    {
        if (_disposeLogic == null)
            return default;

        Func<Task> logic = _disposeLogic;
        _disposeLogic = null;
        return new ValueTask(logic());
    }
}