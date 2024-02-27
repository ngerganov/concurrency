namespace Task_10._1;

public class CancellationExample
{
    public void IssueCancelRequest()
    {
        using var cts = new CancellationTokenSource();
        var task = CancelableMethodAsync(cts.Token);
        cts.Cancel();

        try
        {
            task.Wait();
            Console.WriteLine("Задача выполнена успешно");
        }
        catch (AggregateException ex)
        {
            ex.Handle(e =>
            {
                if (e is OperationCanceledException)
                {
                    Console.WriteLine("Задача отменена");
                    return true;
                }
                else
                {
                    Console.WriteLine("Задача выполнена с ошибкой");
                    return true;
                }
            });
        }
    }

    public async Task IssueCancelRequestAsync()
    {
        using var cts = new CancellationTokenSource();
        var task = CancelableMethodAsync(cts.Token);
        cts.Cancel();

        try
        {
            await task;
            Console.WriteLine("Задача выполнена успешно");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Задача отменена");
        }
        catch (Exception)
        {
            Console.WriteLine("Задача выполнена с ошибкой");
            throw;
        }
    }

    private async Task CancelableMethodAsync(CancellationToken token)
    {
        await Task.Delay(TimeSpan.FromSeconds(3), token);
        Console.WriteLine("Длительная операция завершена");
    }
}