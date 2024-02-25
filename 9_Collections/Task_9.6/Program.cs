namespace Task_9._6;

class Program
{
    static async Task Main(string[] args)
    {
        var communicationChannel = new CommunicationChannel();

        var producer = new Producer(communicationChannel);
        await producer.ProduceAsync();

        var consumer = new Consumer(communicationChannel);
        await consumer.ConsumeAsync();
    }
}