namespace Task_12._3;

class Program
{
    static void Main(string[] args)
    {
        MyClass myClass = new MyClass();

        var initializeThread = new Thread(() =>
        {
            myClass.InitializeFromAnotherThread();
        });
        initializeThread.Start();

        int initializedValue = myClass.WaitForInitialization();

        Console.WriteLine("Value: " + initializedValue);
    }
}