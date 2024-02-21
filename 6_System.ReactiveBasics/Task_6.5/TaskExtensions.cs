namespace Task_6._5;

public static class TaskExtensions
{
    public static async Task<T> TimeoutAfter<T>(this Task<T> task, TimeSpan timeout)
    {
        if (task == await Task.WhenAny(task, Task.Delay(timeout)))
            return await task;
        else
            throw new TimeoutException("Время операции истекло.");
    }
}