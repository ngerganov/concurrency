namespace Task_6._4;

class Program
{
    static void Main(string[] args)
    {
        var mouseThrottle = new MouseThrottle();
        var mouseSample = new MouseSample();

        mouseThrottle.SubscribeToMouseMoveEvents();
        mouseSample.SubscribeToMouseMoveEvents();

        Console.ReadLine();
    }
}