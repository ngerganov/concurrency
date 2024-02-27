namespace Task_10._5;

class Program
{
    static void Main(string[] args)
    {
        var matrices = new List<Matrix> { new Matrix(), new Matrix(), new Matrix() };
        var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;

        Task.Run(() =>
        {
            try
            {
                CancellationExample.RotateMatrices(matrices, 90, cancellationToken);
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Операция была отменена");
            }
        });

        Thread.Sleep(1000);
        cancellationTokenSource.Cancel();

        var matrices2 = new List<Matrix> { new Matrix(), new Matrix(), new Matrix() };
        var cancellationTokenSource2 = new CancellationTokenSource();
        var cancellationToken2 = cancellationTokenSource2.Token;

        Task.Run(() =>
        {
            try
            {
                CancellationExample.RotateMatrices2(matrices2, 90, cancellationToken2);
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Операция №2 была отменена");
            }
        });

        Thread.Sleep(1000);
        cancellationTokenSource2.Cancel();

        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var cancellationTokenSource3 = new CancellationTokenSource();
        var cancellationToken3 = cancellationTokenSource3.Token;

        Task.Run(() =>
        {
            try
            {
                var result = CancellationExample.MultiplyBy2(numbers, cancellationToken3);
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Операция умножения была отменена");
            }
        });

        Thread.Sleep(1000);
        cancellationTokenSource3.Cancel();
    }
}