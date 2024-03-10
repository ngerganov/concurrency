namespace Task_12._6;

class PingPong
{
    private readonly AutoResetEvent _pingEvent = new AutoResetEvent(true);
    private readonly AutoResetEvent _pongEvent = new AutoResetEvent(false);

    private bool _stopThreads = false;

    private void PrintPing()
    {
        while (!_stopThreads)
        {
            _pingEvent.WaitOne();
            Console.WriteLine("Пинг");
            Thread.Sleep(1000);
            _pongEvent.Set();
        }
    }

    private void PrintPong()
    {
        while (!_stopThreads)
        {
            _pongEvent.WaitOne();
            Console.WriteLine("Понг");
            Thread.Sleep(1000);
            _pingEvent.Set();
        }
    }

    public void Run()
    {
        Thread pingThread = new Thread(PrintPing);
        Thread pongThread = new Thread(PrintPong);

        pingThread.Start();
        pongThread.Start();

        Console.WriteLine("Для остановки нажмите любую клавишу...");
        Console.ReadKey();

        _stopThreads = true;
        _pingEvent.Set();
        _pongEvent.Set();

        pingThread.Join();
        pongThread.Join();
    }
}