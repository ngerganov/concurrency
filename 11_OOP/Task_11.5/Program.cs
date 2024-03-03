namespace Task_11._5;

class Program
{
    static async Task Main(string[] args)
    {
        EventPublisher eventPublisher = new EventPublisher();
        EventHandler eventHandler = new EventHandler();

        eventPublisher.MyEvent += eventHandler.AsyncHandler;

        await eventPublisher.RaiseMyEventAsync("Hello from event!");
    }
}