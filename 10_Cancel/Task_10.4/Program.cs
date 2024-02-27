namespace Task_10._4;

class Program
{
    static async Task Main(string[] args)
    {
        using var cts = new CancellationTokenSource();
        var cancellationToken = cts.Token;

        var cancelableMethod = new CancelableMethod();

        var task = cancelableMethod.CancelableMethodAsync(cancellationToken);

        await Task.Delay(1000);
        Console.WriteLine("Отмена задачи...");
        cts.Cancel();

        try
        {
            await task;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Основная задача была отменена.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}