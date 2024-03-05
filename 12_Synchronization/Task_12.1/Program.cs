namespace Task_12._1;

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();

        Thread thread1 = new Thread(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                myObject.Increment();
                Console.WriteLine($"Поток 1: Увеличение значения. Текущее значение: {myObject.GetValue()}");
                Thread.Sleep(100);
            }
        });

        Thread thread2 = new Thread(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                myObject.Increment();
                Console.WriteLine($"Поток 2: Увеличение значения. Текущее значение: {myObject.GetValue()}");
                Thread.Sleep(100);
            }
        });

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine($"Итоговое значение: {myObject.GetValue()}");
    }
}