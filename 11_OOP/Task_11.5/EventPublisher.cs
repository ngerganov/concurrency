namespace Task_11._5;

public class EventPublisher
{
    public event EventHandler<MyEventArgs> MyEvent;

    public async Task RaiseMyEventAsync(string message)
    {
        EventHandler<MyEventArgs> handler = MyEvent;
        if (handler == null)
            return;

        var args = new MyEventArgs(message);
        handler(this, args);
        await args.WaitForDeferralsAsync();
    }
}