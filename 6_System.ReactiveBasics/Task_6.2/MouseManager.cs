using System.Diagnostics;
using System.Reactive.Concurrency;
using System.Reactive.Linq;

namespace Task_6._2;

public class MouseManager
{
    public void Start()
    {
        Observable.Interval(TimeSpan.FromSeconds(2))
            .Select(_ => GenerateRandomPosition())
            .ObserveOn(Scheduler.Default)
            .Select(position =>
            {
                Thread.Sleep(100);
                var result = position * 2;
                var thread = Thread.CurrentThread.ManagedThreadId;
                return $"Calculated result {result} on thread {thread}";
            })
            .ObserveOn(Scheduler.Default)
            .Subscribe(x => Console.WriteLine($"Result: {x} on thread {Thread.CurrentThread.ManagedThreadId}"));
    }

    private int GenerateRandomPosition()
    {
        return new Random().Next(100);
    }
}