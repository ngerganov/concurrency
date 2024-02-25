namespace Task_9._6;

class Producer
{
    private readonly CommunicationChannel _communicationChannel;

    public Producer(CommunicationChannel communicationChannel)
    {
        _communicationChannel = communicationChannel;
    }

    public Task ProduceAsync()
    {
        _communicationChannel.AddItem(7);
        Console.WriteLine("Added item: 7");

        _communicationChannel.AddItem(13);
        Console.WriteLine("Added item: 13");

        _communicationChannel.CompleteAdding();
        return Task.CompletedTask;
    }
}