namespace Task2._1;

public class DelayExample
{
    public static async Task<T> DelayResult<T>(T result, TimeSpan delay)
    {
        await Task.Delay(delay);
        return result;
    }
}