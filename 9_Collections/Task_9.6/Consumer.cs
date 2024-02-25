namespace Task_9._6;

class Consumer
{
    private readonly CommunicationChannel _communicationChannel;

    public Consumer(CommunicationChannel communicationChannel)
    {
        _communicationChannel = communicationChannel;
    }

    public Task ConsumeAsync()
    {
        foreach (var item in _communicationChannel.GetConsumingEnumerable())
        {
            Console.WriteLine($"Consumed item: {item}");
        }

        return Task.CompletedTask;
    }
}