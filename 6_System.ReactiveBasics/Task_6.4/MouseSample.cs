using System.Drawing;
using System.Net.Mime;
using System.Reactive.Linq;

namespace Task_6._4;

public class MouseSample
{
    public void SubscribeToMouseMoveEvents()
    {
        Observable.Interval(TimeSpan.FromSeconds(0.5))
            .Select(_ => new Point((int)(GetRandomNumber() * 100), (int)(GetRandomNumber() * 100)))
            .Sample(TimeSpan.FromSeconds(1))
            .Subscribe(point => HandleMouseMove(point, "Sample"));
    }

    private void HandleMouseMove(Point point, string methodName)
    {
        Console.WriteLine($"{DateTime.Now.Second}: {methodName} Saw ({point.X}, {point.Y})");
    }

    private double GetRandomNumber()
    {
        var random = new Random();
        return random.NextDouble() * 100;
    }
}