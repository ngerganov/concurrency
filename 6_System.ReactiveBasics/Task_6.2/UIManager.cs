using System.Diagnostics;
using System.Reactive.Linq;

namespace Task_6._2;

public class UIManager
{
    public void Start()
    {
        Console.WriteLine($"UI thread is {Thread.CurrentThread.ManagedThreadId}");
        Observable.Interval(TimeSpan.FromSeconds(1))
            .Subscribe(x => Console.WriteLine($"Interval {x} on thread {Thread.CurrentThread.ManagedThreadId}"));
    }
}