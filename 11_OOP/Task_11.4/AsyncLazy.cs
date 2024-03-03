using System.Runtime.CompilerServices;

namespace Task_11._4;

public class AsyncLazy<T> : Lazy<Task<T>>
{
    public AsyncLazy(Func<Task<T>> taskFactory) :
        base(() => Task.Factory.StartNew(taskFactory).Unwrap()) { }

    public TaskAwaiter<T> GetAwaiter() => Value.GetAwaiter();
}