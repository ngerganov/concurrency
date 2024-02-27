using System.Reactive.Linq;

namespace Task_10._6;

public class MouseTracker
{
    private IDisposable? _mouseMovesSubscription;

    public void StartTracking()
    {
        IObservable<ConsoleCancelEventArgs> keyPresses = Observable.FromEventPattern<ConsoleCancelEventHandler, ConsoleCancelEventArgs>(
                handler => (s, a) => handler(s, a),
                handler => Console.CancelKeyPress += handler,
                handler => Console.CancelKeyPress -= handler)
            .Select(x => x.EventArgs);

        IObservable<long> mouseMoves = Observable.Interval(TimeSpan.FromSeconds(1));

        _mouseMovesSubscription = mouseMoves.Subscribe(value =>
        {
            Console.WriteLine("Mouse position: (" + value + ", " + value + ")");
        });

        keyPresses.Subscribe(key =>
        {
            if (key.SpecialKey == ConsoleSpecialKey.ControlC)
            {
                StopTracking();
                Console.WriteLine("Mouse tracking stopped.");
            }
        });
    }

    private void StopTracking()
    {
        _mouseMovesSubscription?.Dispose();
    }
}