namespace Task_6._3;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Пример использования Window:");
        WindowBufferExamples.RunWindowExample();

        Console.WriteLine("\nПример использования Buffer:");
        WindowBufferExamples.RunBufferExample();

        Console.WriteLine("\nПример использования обработки событий мыши:");
        MouseEventsHandler mouseHandler = new MouseEventsHandler();
        mouseHandler.MouseMoved += MouseHandler_MouseMoved;
        mouseHandler.SimulateMouseMovement();

        Console.ReadLine();
    }

    private static void MouseHandler_MouseMoved(object sender, MouseEventArgs e)
    {
        Console.WriteLine($"{DateTime.Now.Second}: Mouse moved.");
    }
}