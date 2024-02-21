namespace Task2._3;

class Program
{
    static async Task Main(string[] args)
    {
        var myTask = new MyAsyncTask();

        var progress = new Progress<double>();
        progress.ProgressChanged += (sender, value) =>
        {
            Console.WriteLine($"Прогресс выполнения: {value}%");
        };

        await myTask.MyMethodAsync(progress);

        Console.WriteLine("Операция завершена");
    }
}