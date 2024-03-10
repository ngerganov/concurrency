namespace Task_14._7;

class Program
{
    static async Task Main(string[] args)
    {
        var (observable, progress) = ObservableProgress.CreateForUi<int>();
        
        using (observable.Subscribe(value => Console.WriteLine($"Progress: {value}%")))
        {
            var solvingTask = new SolvingTask();
            var result = await Task.Run(() => solvingTask.Solve(progress));
            Console.WriteLine($"Done! Result: {result}");
        }
    }
}