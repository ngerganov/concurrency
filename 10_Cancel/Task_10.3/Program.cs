namespace Task_10._3;

class Program
{
    static async Task Main(string[] args)
    {
        var timeoutCancellation = new TimeoutCancellation();
            
        Console.WriteLine("Выполнение метода с тайм-аутом (первый случай):");
        try
        {
            await timeoutCancellation.IssueTimeoutAsync();
        }
        catch (TaskCanceledException)
        {
            Console.WriteLine("Метод был отменен из-за тайм-аута.");
        }

        Console.WriteLine("\nВыполнение метода с тайм-аутом (второй случай):");
        await timeoutCancellation.IssueTimeoutAsyncSecondCase();
        Console.WriteLine("Метод завершен или отменен.");
    }
}