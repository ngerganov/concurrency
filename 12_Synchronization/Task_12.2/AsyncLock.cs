namespace Task_12._2;

public class AsyncLock
{
    private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

    public async Task<AsyncLockHandle> LockAsync()
    {
        await _semaphore.WaitAsync();
        return new AsyncLockHandle(_semaphore);
    }

    public struct AsyncLockHandle : IDisposable
    {
        private readonly SemaphoreSlim _semaphore;

        public AsyncLockHandle(SemaphoreSlim semaphore)
        {
            _semaphore = semaphore;
        }

        public void Dispose()
        {
            _semaphore.Release();
        }
    }
}