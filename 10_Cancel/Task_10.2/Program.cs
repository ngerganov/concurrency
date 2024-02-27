namespace Task_10._2;

class Program
{
    static void Main(string[] args)
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        CancellationToken cancellationToken = cancellationTokenSource.Token;

        CancelableProcessor processor = new CancelableProcessor();

        Console.WriteLine("Пример использования CancelableMethod:");
        try
        {
            int result1 = processor.CancelableMethod(cancellationToken);
            Console.WriteLine($"Результат: {result1}");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Метод был отменен.");
        }

        Console.WriteLine("Пример использования CancelableMethodWithLimit:");
        try
        {
            int result2 = processor.CancelableMethodWithLimit(cancellationToken);
            Console.WriteLine($"Результат: {result2}");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Метод был отменен.");
        }
    }
}