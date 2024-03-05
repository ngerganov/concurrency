using System.Reactive.Concurrency;

namespace Task_12._2;

public class DataService : IDataService
{
    private readonly AsyncLock _mutex = new AsyncLock();
    private int _value;

    public async Task<int> DelayAndIncrementAsync()
    {
        using (await _mutex.LockAsync())
        {
            int oldValue = _value;
            await Task.Delay(TimeSpan.FromSeconds(oldValue));
            _value = oldValue + 1;
            return _value;
        }
    }
}