namespace Task_10._6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press Ctrl+C to stop tracking");
        MouseTracker tracker = new MouseTracker();
        tracker.StartTracking();

        Console.ReadKey();
    }
}