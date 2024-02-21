namespace Task_6._2;

class Program
{
    static void Main(string[] args)
    {
        UIManager uiManager = new UIManager();
        MouseManager mouseManager = new MouseManager();

        uiManager.Start();
        mouseManager.Start();

        Thread.Sleep(TimeSpan.FromSeconds(10));
    }
}