namespace Task_11._5;

public class EventHandler
{
    public async void AsyncHandler(object sender, MyEventArgs args)
    {
        using IDisposable deferral = args.GetDeferral();
        Console.WriteLine($"AsyncHandler processing message: {args.Message}");
        await Task.Delay(TimeSpan.FromSeconds(2));
        Console.WriteLine("AsyncHandler completed processing.");
    }
}