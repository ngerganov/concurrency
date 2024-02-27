namespace Task_10._4;

public class CancelableMethod
{
    public async Task<int> CancelableMethodAsync(CancellationToken cancellationToken)
    {
        try
        {
            Console.WriteLine("CancelableMethodAsync начал выполнение.");
            await Task.Delay(TimeSpan.FromSeconds(2), cancellationToken);
            Console.WriteLine("CancelableMethodAsync завершил выполнение.");
            return 42;
        }
        catch (TaskCanceledException)
        {
            Console.WriteLine("CancelableMethodAsync был отменен.");
            throw;
        }
    }
}